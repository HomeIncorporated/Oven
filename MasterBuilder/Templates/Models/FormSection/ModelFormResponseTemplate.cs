using MasterBuilder.Interfaces;
using MasterBuilder.Request;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterBuilder.Templates.Models
{
    /// <summary>
    /// Model Form Response Template
    /// </summary>
    public class ModelFormResponseTemplate : ITemplate
    {
        private readonly Project Project;
        private readonly Screen Screen;
        private readonly IEnumerable<ScreenSection> ScreenSections;
        private readonly IEnumerable<ScreenSection> ChildScreenSections;

        /// <summary>
        /// Constructor
        /// </summary>
        public ModelFormResponseTemplate(Project project, Screen screen, IEnumerable<ScreenSection> screenSections, IEnumerable<ScreenSection> childScreenSection = null)
        {
            Project = project;
            Screen = screen;
            ScreenSections = screenSections;
            ChildScreenSections = childScreenSection;
        }

        /// <summary>
        /// Get file name
        /// </summary>
        public string GetFileName()
        {
            return $"{ScreenSections.First().FormResponseClass}.cs";
        }

        /// <summary>
        /// Get file path
        /// </summary>
        public string[] GetFilePath()
        {
            return new string[] { "Models", Screen.InternalName };
        }

        /// <summary>
        /// Get file content
        /// </summary>
        public string GetFileContent()
        {
            var properties = new List<string>();
            
            foreach (var group in (from formSection in ScreenSections
                                    from ff in formSection.FormSection.FormFields
                                    select ff).GroupBy(ff => ff.EntityPropertyId))
            {
                properties.Add(ModelFormResponsePropertyTemplate.Evaluate(group.FirstOrDefault()));
            }

            if (ChildScreenSections != null)
            {
                foreach (var childScreenSection in ChildScreenSections)
                {
                    properties.Add($@"        /// <summary>
        /// {childScreenSection.Entity.Title} Response
        /// </summary>
        [Display(Name = ""{childScreenSection.Entity.Title}"")]
        public {childScreenSection.FormResponseClass} {childScreenSection.Entity.InternalName} {{ get; set; }}");
                }
            }

            return $@"using System;
using System.ComponentModel.DataAnnotations;

namespace {Project.InternalName}.Models
{{
    /// <summary>
    /// {Screen.InternalName} Screen Load
    /// </summary>
    public class {ScreenSections.First().FormResponseClass}
    {{
{string.Join(Environment.NewLine, properties)}
    }}
}}";
        }
    }
}
