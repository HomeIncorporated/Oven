using Oven.Request;
using System.Collections.Generic;
using Oven.Interfaces;

namespace Oven.Templates.DataAccessLayer.Extensions
{
    /// <summary>
    /// Extensions Template Builder
    /// </summary>
    public class ExtensionsTemplateBuilder : ITemplateBuilder
    {
        private readonly Project Project;

        /// <summary>
        /// Constructor
        /// </summary>
        public ExtensionsTemplateBuilder(Project project)
        {
            Project = project;
        }

        /// <summary>
        /// Get model templates
        /// </summary>
        public IEnumerable<ITemplate> GetTemplates()
        {
            return new List<ITemplate>
            {
            };
        }

        public IEnumerable<ITemplateBuilder> GetTemplateBuilders() => new ITemplateBuilder[] { };
    }
}
