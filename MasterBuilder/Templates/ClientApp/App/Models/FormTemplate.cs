using Humanizer;
using MasterBuilder.Interfaces;
using MasterBuilder.Request;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterBuilder.Templates.ClientApp.App.Models
{
    /// <summary>
    /// Form Template
    /// </summary>
    public class FormTemplate : ITemplate
    {
        private readonly Project Project;
        private readonly Screen Screen;
        private readonly IEnumerable<ScreenSection> ScreenSections;
        private readonly IEnumerable<ScreenSection> ChildScreenSections;
        private readonly Property ParentProperty;

        /// <summary>
        /// Constructor
        /// </summary>
        public FormTemplate(Project project, Screen screen, IEnumerable<ScreenSection> screenSections, IEnumerable<ScreenSection> childScreenSections, Property parentProperty)
        {
            Project = project;
            Screen = screen;
            ScreenSections = screenSections;
            ChildScreenSections = childScreenSections;
            ParentProperty = parentProperty;
        }

        /// <summary>
        /// Get file name
        /// </summary>
        public string GetFileName()
        {
            return $"{(ParentProperty != null ? ParentProperty.InternalName : Screen.InternalName)}.ts";
        }

        /// <summary>
        /// Get file path
        /// </summary>
        public string[] GetFilePath()
        {
            return new string[] { "ClientApp", "app", "models", $"{Screen.InternalName.ToLowerInvariant()}" };
        }

        /// <summary>
        /// Get Properties
        /// </summary>
        /// <param name="formField">The form field</param>
        /// <returns>List of properties for this form field</returns>
        private IEnumerable<string> GetProperties(FormField formField)
        {
            var properties = new List<string>();
            switch (formField.PropertyType)
            {
                case PropertyType.ReferenceRelationship:
                    properties.Add($"    {formField.InternalNameTypeScript}: {formField.TypeTypeScript};");
                    properties.Add($"    {formField.InternalNameAlternateTypeScript}: string;");
                    break;
                default:
                    properties.Add($"    {formField.InternalNameTypeScript}: {formField.TypeTypeScript};");
                    break;
            }

            return properties;
        }

        /// <summary>
        /// Get file content
        /// </summary>
        public string GetFileContent()
        {
            var properties = new List<string>();
            var imports = new List<string>();

            foreach (var group in (from screenSection in ScreenSections
                                       from ff in screenSection.FormSection.FormFields
                                       select ff).GroupBy(ff => ff.EntityPropertyId))
            {
                properties.AddRange(GetProperties(group.FirstOrDefault()));
            }

            // TODO: Enable child sections, this needs to be recursive
            //if (ChildScreenSections != null)
            //{
            //    foreach (var childProperty in (from child in ChildScreenSections
            //                                   select child.ParentEntityProperty).Distinct())
            //    {
            //        properties.Add($@"    {childProperty.InternalName.Camelize()}: {childProperty.InternalName};");
            //        imports.Add($@"import {{ {childProperty.InternalName} }} from './{childProperty.InternalName}';");
            //    }
            //}

            if (imports.Any())
            {
                imports.Add(Environment.NewLine);
            }

            return $@"{string.Join(Environment.NewLine, imports)}export class {(ParentProperty != null ? ParentProperty.InternalName : Screen.InternalName)} {{
{string.Join(Environment.NewLine, properties)}
}}";
        }
    }
}
