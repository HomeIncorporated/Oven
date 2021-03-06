using Oven.Interfaces;
using Oven.Request;

namespace Oven.Templates.Api.Models
{
    /// <summary>
    /// Model Search Response Template
    /// </summary>
    public class ModelSearchResponseTemplate : ITemplate
    {
        private readonly Project Project;
        private readonly Screen Screen;
        private readonly ScreenSection ScreenSection;

        /// <summary>
        /// Constructor
        /// </summary>
        public ModelSearchResponseTemplate(Project project, Screen screen, ScreenSection screenSection)
        {
            Project = project;
            Screen = screen;
            ScreenSection = screenSection;
        }

        /// <summary>
        /// Get file name
        /// </summary>
        public string GetFileName()
        {
            return $"{ScreenSection.SearchSection.SearchResponseClass}.cs";
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
            return $@"using System;
using Oven.Shared;

namespace {Project.InternalName}.Models
{{
    /// <summary>
    /// {Screen.InternalName} Screen Search Response
    /// </summary>
    public class {ScreenSection.SearchSection.SearchResponseClass}
    {{
        /// <summary>
        /// Total Pages
        /// </summary>
        public int TotalPages {{ get; set; }}
        /// <summary>
        /// Total Items
        /// </summary>
        public int TotalItems {{ get; set; }}
        /// <summary>
        /// {ScreenSection.SearchSection.SearchItemClass}
        /// </summary>
        public {ScreenSection.SearchSection.SearchItemClass}[] Items {{ get; set; }}
    }}
}}";
        }
    }
}
