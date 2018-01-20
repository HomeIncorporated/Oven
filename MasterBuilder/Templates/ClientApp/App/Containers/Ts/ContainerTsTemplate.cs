using System;
using System.Collections.Generic;
using System.Linq;
using Humanizer;
using MasterBuilder.Interfaces;
using MasterBuilder.Request;

namespace MasterBuilder.Templates.ClientApp.App.Containers.Ts
{
    /// <summary>
    /// Container Ts Template
    /// </summary>
    public class ContainerTsTemplate: ITemplate
    {
        private readonly Project Project;
        private readonly Screen Screen;

        /// <summary>
        /// Constructor
        /// </summary>
        public ContainerTsTemplate(Project project, Screen screen)
        {
            Project = project;
            Screen = screen;
        }

        /// <summary>
        /// Get file name
        /// </summary>
        public string GetFileName()
        {
            return $"{Screen.InternalName.ToLowerInvariant()}.component.ts";
        }

        /// <summary>
        /// Get file path
        /// </summary>
        public string[] GetFilePath()
        {
            return new string[] { "ClientApp", "app", "containers", Screen.InternalName.ToLowerInvariant() };
        }

        /// <summary>
        /// Get file content
        /// </summary>
        public string GetFileContent()
        {
            var imports = new List<string>();
            var classProperties = new List<string>();
            var constructorBodySections = new List<string>();
            var onNgInitBodySections = new List<string>();
            var functions = new List<string>();
            var constructorParamerters = new List<string>{
                "private http: HttpClient",
                "private router: Router",
                "private route: ActivatedRoute"
            };
            var properties = new List<string>();
            var formControls = new List<string>();
            
            foreach (var screenSection in Screen.ScreenSections)
            {
                switch (screenSection.ScreenSectionType)
                {
                    case ScreenSectionTypeEnum.Form:

                        var formSectionPartial = new FormSectionPartial(Project, Screen, screenSection);
                        imports.AddRange(formSectionPartial.GetImports());
                        constructorParamerters.AddRange(formSectionPartial.GetConstructorParameters());
                        constructorBodySections.AddRange(formSectionPartial.GetConstructorBodySections());
                        classProperties.AddRange(formSectionPartial.GetClassProperties());
                        onNgInitBodySections.AddRange(formSectionPartial.GetOnNgInitBodySections());
                        functions.AddRange(formSectionPartial.GetFunctions());
                        properties.AddRange(formSectionPartial.GetProperties());
                        formControls.AddRange(formSectionPartial.GetFormControls());
                        
                        break;
                    case ScreenSectionTypeEnum.Search:

                        var searchSectionPartial = new SearchSectionPartial(Project, Screen, screenSection);
                        imports.AddRange(searchSectionPartial.GetImports());
                        constructorParamerters.AddRange(searchSectionPartial.GetConstructorParameters());
                        constructorBodySections.AddRange(searchSectionPartial.GetConstructorBodySections());
                        classProperties.AddRange(searchSectionPartial.GetClassProperties());
                        onNgInitBodySections.AddRange(searchSectionPartial.GetOnNgInitBodySections());
                        
                        break;
                    case ScreenSectionTypeEnum.MenuList:
                        // Nothing at the moment
                        break;
                    case ScreenSectionTypeEnum.Html:
                        // Probably never anything
                        break;
                    default:
                        break;
                }
                
                if (screenSection.MenuItems != null)
                {
                    foreach (var menuItem in screenSection.MenuItems)
                    {
                        switch (menuItem.MenuItemType)
                        {
                            case MenuItemTypeEnum.ApplicationLink:
                                break;
                            case MenuItemTypeEnum.New:
                                break;
                            case MenuItemTypeEnum.ServerFunction:
                                functions.Add($@"public {menuItem.InternalName.Camelize()}(){{
        this.{Screen.InternalName.Camelize()}Service.get{menuItem.InternalName}(this.{Screen.InternalName.Camelize()}.id).subscribe( result => {{
            alert(result);
        }});
    }}");
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            
            if (formControls.Any())
            {
                functions.Add($@"    setupForm(){{
        this.{Screen.InternalName.Camelize()}Form = new FormGroup({{}});
{string.Join(Environment.NewLine, formControls)}
    }}");
            }

            if (Screen.InternalName.Equals("home", StringComparison.OrdinalIgnoreCase))
            {
                imports.Add("import { TranslateService } from '@ngx-translate/core';");
                classProperties.Add($"title: string = '{Project.Title}'");
                constructorParamerters.Add("public translate: TranslateService");
                functions.Add(@"public setLanguage(lang) {
        this.translate.use(lang);
    }");
            }
            
            return $@"import {{ HttpClient }} from '@angular/common/http';
import {{ Component, Inject, OnInit }} from '@angular/core';
import {{ Router, ActivatedRoute }} from '@angular/router';
{string.Join(Environment.NewLine, imports.Distinct())}

@Component({{
    selector: '{Screen.InternalName.ToLowerInvariant()}',
    templateUrl: './{Screen.InternalName.ToLowerInvariant()}.component.html'
}})
export class {Screen.InternalName}Component implements OnInit {{
    {string.Join(string.Concat(Environment.NewLine, "    "), classProperties.Distinct())}

    constructor({string.Join(string.Concat(",", Environment.NewLine, "      "), constructorParamerters.Distinct())}){{
{string.Join(Environment.NewLine, constructorBodySections.Distinct())}
    }}

    ngOnInit(){{
{string.Join(Environment.NewLine, onNgInitBodySections.Distinct())}
    }}

{string.Join(Environment.NewLine, properties.Distinct())}

{string.Join(Environment.NewLine, functions.Distinct())}
}}";
        }
    }
}
