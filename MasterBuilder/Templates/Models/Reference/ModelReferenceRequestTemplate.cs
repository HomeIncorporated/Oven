using MasterBuilder.Interfaces;
using MasterBuilder.Request;

namespace MasterBuilder.Templates.Models.Reference
{
    /// <summary>
    /// Model Search Request Template
    /// </summary>
    public class ModelReferenceRequestTemplate : ITemplate
    {
        private readonly Project Project;
        private readonly Screen Screen;
        private readonly FormField FormField;

        /// <summary>
        /// Constructor
        /// </summary>
        public ModelReferenceRequestTemplate(Project project, Screen screen, FormField formField)
        {
            Project = project;
            Screen = screen;
            FormField = formField;
        }

        /// <summary>
        /// Get file name
        /// </summary>
        public string GetFileName()
        {
            return $"{FormField.ReferenceRequestClass}.cs";
        }

        /// <summary>
        /// Get file path
        /// </summary>
        public string[] GetFilePath()
        {
            return new string[] { "Models", Screen.InternalName, "Reference" };
        }

        /// <summary>
        /// Get file content
        /// </summary>
        public string GetFileContent()
        {            
            return $@"using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace {Project.InternalName}.Models.{Screen.InternalName}.Reference
{{
    /// <summary>
    /// {FormField.TitleValue} Reference Request
    /// </summary>
    public class {FormField.ReferenceRequestClass}
    {{
        /// <summary>
        /// Page
        /// </summary>
        [Required]
        [DefaultValue(1)]
        public int Page {{ get; set; }}
        /// <summary>
        /// Page Size
        /// </summary>
        [Required]
        [DefaultValue(10)]
        public int PageSize {{ get; set; }}
        /// <summary>
        /// Query
        /// </summary>
        public string Query {{ get; set; }}
    }}
}}";
        }


    }
}
