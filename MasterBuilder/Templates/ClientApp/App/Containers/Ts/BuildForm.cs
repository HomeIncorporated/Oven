using Humanizer;
using MasterBuilder.Request;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterBuilder.Templates.ClientApp.App.Containers.Ts
{
    /// <summary>
    /// Build Form
    /// </summary>
    public class BuildForm
    {
        private readonly Project Project;
        private readonly Screen Screen;
        private Entity _entity;
        
        /// <summary>
        /// Constructor
        /// </summary>
        public BuildForm(Project project, Screen screen)
        {
            Project = project;
            Screen = screen;

            _entity = Project.Entities.SingleOrDefault(p => p.Id == Screen.EntityId);
        }

        /// <summary>
        /// Imports
        /// </summary>
        public IEnumerable<string> GetImports()
        {
            var imports = new List<string>();
            if (_entity == null)
            {
                return imports;
            }

            imports.Add("import { Operation } from '../../models/Operation';");
            imports.Add("import { FormControl, FormGroup, Validators } from '@angular/forms';");
            imports.Add("import { Observable } from 'rxjs/Observable';");

            var referenceEntities = (from property in _entity.Properties
                                     where property.PropertyType == PropertyTypeEnum.ReferenceRelationship &&
                                     property.ParentEntityId.HasValue
                                     from entity in Project.Entities
                                     where entity.Id == property.ParentEntityId.Value
                                     select entity).Distinct().ToArray();

            if (referenceEntities.Any())
            {
                imports.Add("import { ReferenceRequest } from '../../models/ReferenceRequest';");
                foreach (var entity in referenceEntities)
                {
                    imports.Add($"import {{ {entity.InternalName}Service }} from '../../shared/{entity.InternalName.ToLowerInvariant()}.service';");
                    imports.Add($"import {{ {entity.InternalName}ReferenceItem }} from '../../models/{entity.InternalName.ToLowerInvariant()}/{entity.InternalName}ReferenceItem';");
                    imports.Add($"import {{ {entity.InternalName}ReferenceResponse }} from '../../models/{entity.InternalName.ToLowerInvariant()}/{entity.InternalName}ReferenceResponse';");
                }
            }

            return imports;
        }

        /// <summary>
        /// ngOnInit
        /// </summary>
        public IEnumerable<string> GetngOnInit()
        {
            var lines = new List<string>();
            if (_entity == null)
            {
                return lines;
            }

            var referenceEntities = (from property in _entity.Properties
                                     where property.PropertyType == PropertyTypeEnum.ReferenceRelationship &&
                                     property.ParentEntityId.HasValue
                                     from entity in Project.Entities
                                     where entity.Id == property.ParentEntityId.Value
                                     select entity).Distinct().ToArray();

            foreach (var entity in referenceEntities)
            {
                lines.Add($@"        this.{entity.InternalName.Camelize()}Service.get{entity.InternalName}References(null , 1, 100).subscribe((result: any) => {{
                if (result != null) {{
                    this.{entity.InternalName.Camelize()}Reference.items = result.items;
                }}
            }});");
            }

            return lines;
        }

        /// <summary>
        /// Get constructor parameters
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetConstructorParamerters()
        {
            var imports = new List<string>();
            if (_entity == null)
            {
                return imports;
            }
            
            var referenceEntities = (from property in _entity.Properties
                                     where property.PropertyType == PropertyTypeEnum.ReferenceRelationship &&
                                     property.ParentEntityId.HasValue
                                     from entity in Project.Entities
                                     where entity.Id == property.ParentEntityId.Value
                                     select entity).Distinct().ToArray();

            if (referenceEntities.Any())
            {
                foreach (var entity in referenceEntities)
                {
                    imports.Add($"private {entity.InternalName.Camelize()}Service: {entity.InternalName}Service");
                }
            }

            return imports;
        }

        /// <summary>
        /// Get functions
        /// </summary>
        public string GetFunctions()
        {
            if (_entity == null)
            {
                return string.Empty;
            }

            var sectionImports = new List<string>();
            var sections = new List<string>();
            var properties = new List<string>();

            var formControls = new List<string>();
            var formCode = new List<string>();

            foreach (var property in _entity.Properties)
            {
                if (property.PropertyType == PropertyTypeEnum.PrimaryKey)
                {
                    continue;
                }

                var propertyValidators = new List<string>();
                if (property.ValidationItems != null)
                {
                    foreach (var validationItem in property.ValidationItems)
                    {
                        switch (validationItem.ValidationType)
                        {
                            case ValidationTypeEnum.Required:
                                propertyValidators.Add("            Validators.required");
                                break;
                            case ValidationTypeEnum.MaximumLength:
                                propertyValidators.Add($"            Validators.maxLength({validationItem.IntegerValue.Value})");
                                break;
                            case ValidationTypeEnum.MinimumLength:
                                propertyValidators.Add($"            Validators.minLength({validationItem.IntegerValue.Value})");
                                break;
                            case ValidationTypeEnum.MaximumValue:
                                propertyValidators.Add($"            Validators.max({validationItem.IntegerValue.Value})");
                                break;
                            case ValidationTypeEnum.MinimumValue:
                                propertyValidators.Add($"            Validators.min({validationItem.IntegerValue.Value})");
                                break;
                            case ValidationTypeEnum.Unique:
                                break;
                            case ValidationTypeEnum.Email:
                                propertyValidators.Add($"            Validators.email");
                                break;
                            case ValidationTypeEnum.RequiredTrue:
                                propertyValidators.Add($"            Validators.requiredTrue");
                                break;
                            case ValidationTypeEnum.Pattern:
                                propertyValidators.Add($"            Validators.pattern({validationItem.StringValue})");
                                break;
                            default:
                                break;
                        }
                    }
                }

                var propertyValidatorsString = (propertyValidators.Any() ? $",[{Environment.NewLine}{string.Join(string.Concat(",", Environment.NewLine), propertyValidators)}]" : string.Empty);

                if (property.PropertyType == PropertyTypeEnum.ParentRelationship)
                {
                    formControls.Add($@"        this.{Screen.InternalName.Camelize()}Form.addControl('{property.InternalName.Camelize()}Id', new FormControl(this.{Screen.InternalName.Camelize()}.{property.InternalName.Camelize()}Id{propertyValidatorsString}));");
                    properties.Add($@"    get {property.InternalName.Camelize()}Id() {{ return this.{Screen.InternalName.Camelize()}Form.get('{property.InternalName.Camelize()}Id'); }}");
                }
                else if (property.PropertyType == PropertyTypeEnum.ReferenceRelationship)
                {
                    formControls.Add($@"         let {property.InternalName.Camelize()}Control: FormControl = new FormControl(this.{Screen.InternalName.Camelize()}.{property.InternalName.Camelize()}Id{propertyValidatorsString});
        this.{Screen.InternalName.Camelize()}Form.addControl('{property.InternalName.Camelize()}Id', {property.InternalName.Camelize()}Control);");

                    properties.Add($@"    get {property.InternalName.Camelize()}Id() {{ return this.{Screen.InternalName.Camelize()}Form.get('{property.InternalName.Camelize()}Id'); }}");
                    
                    var parentEntity = (from e in Project.Entities
                                        where e.Id == property.ParentEntityId.Value
                                        select e).SingleOrDefault();
                    properties.Add($"public {parentEntity.InternalName.Camelize()}Reference: {parentEntity.InternalName}ReferenceResponse = new {parentEntity.InternalName}ReferenceResponse();");   
                }
                else
                {
                    formControls.Add($@"         this.{Screen.InternalName.Camelize()}Form.addControl('{property.InternalName.Camelize()}', new FormControl(this.{Screen.InternalName.Camelize()}.{property.InternalName.Camelize()}{propertyValidatorsString}));");
                    properties.Add($@"    get {property.InternalName.Camelize()}() {{ return this.{Screen.InternalName.Camelize()}Form.get('{property.InternalName.Camelize()}'); }}");
                }
            }

            return $@" 

    setupForm(){{
        this.{Screen.InternalName.Camelize()}Form = new FormGroup({{
        }});
{string.Join(Environment.NewLine, formControls)}

{string.Join(Environment.NewLine, formCode)}
    }}

{string.Join(Environment.NewLine, properties)}

    referenceCompare(referenceItem1: any, referenceItem2: any): boolean {{
        return referenceItem1 === referenceItem2;
    }}

    private getPatchOperations(): Operation[] {{
        let operations: Operation[] = [];

        Object.keys(this.{Screen.InternalName.Camelize()}Form.controls).forEach((name) => {{
            let currentControl = this.{Screen.InternalName.Camelize()}Form.controls[name];

            if (currentControl.dirty) {{
                let operation = new Operation();
                operation.op = 'replace';
                operation.path = '/' + name;
                if (currentControl.value instanceof Object) {{
                    operation.value = currentControl.value.id;
                }} else {{
                    operation.value = currentControl.value;
                }}
                operations.push(operation);
            }}
        }});
        return operations;
    }}

    onSubmit() {{ 
        // Don't submit if nothing has changed
        if (this.{Screen.InternalName.Camelize()}Form.pristine || !this.{Screen.InternalName.Camelize()}Form.valid) {{
            return;
        }}
        
        if (this.new){{
            // Post new
            this.{_entity.InternalName.Camelize()}Service.add{_entity.InternalName}{Screen.InternalName}(this.{Screen.InternalName.Camelize()}Form.getRawValue()).subscribe( id => {{
                this.router.navigate([this.router.url + '/' + id]);
            }});
        }} else {{
            // Patch existing
            let operations = this.getPatchOperations();
            this.{_entity.InternalName.Camelize()}Service.update{_entity.InternalName}{Screen.InternalName}(this.{Screen.InternalName.Camelize()}.id, operations).subscribe( result => {{
                this.{Screen.InternalName.Camelize()}Form.markAsPristine({{ onlySelf: false }});
            }});
        }}
    }}";
        }
    }
}
