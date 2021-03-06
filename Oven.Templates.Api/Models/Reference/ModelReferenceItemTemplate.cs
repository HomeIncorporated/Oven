using Oven.Interfaces;
using Oven.Request;

namespace Oven.Templates.Api.Models.Reference
{
    /// <summary>
    /// Model Reference Item Template
    /// </summary>
    public class ModelReferenceItemTemplate : ITemplate
    {
        private readonly Project Project;
        private readonly Screen Screen;
        private readonly FormField FormField;

        /// <summary>
        /// Constructor
        /// </summary>
        public ModelReferenceItemTemplate(Project project, Screen screen, FormField formField)
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
            return $"{FormField.ReferenceItemClass}.cs";
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
using MongoDB.Bson;
using Oven.Shared;

namespace {Project.InternalName}.Models.{Screen.InternalName}.Reference
{{
    /// <summary>
    /// {FormField.TitleValue} Reference Item
    /// </summary>
    public class {FormField.ReferenceItemClass}
    {{
        /// <summary>
        /// Id
        /// </summary>
        public ObjectId Id {{ get; set; }}
        /// <summary>
        /// Title
        /// </summary>
        public string Title {{ get; set; }}
    }}
}}";
        }


    }
}
