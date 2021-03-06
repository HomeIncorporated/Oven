using Oven.Interfaces;
using Oven.Request;
using System.Collections.Generic;

namespace Oven.Templates.DataAccessLayer.Entities
{
    /// <summary>
    /// Entity Template Builder
    /// </summary>
    public class EntityTemplateBuilder : ITemplateBuilder
    {
        private readonly Project Project;

        /// <summary>
        /// Constructor
        /// </summary>
        public EntityTemplateBuilder(Project project)
        {
            Project = project;
        }

        /// <summary>
        /// Get entity templates
        /// </summary>
        public IEnumerable<ITemplate> GetTemplates()
        {
            var templates = new List<ITemplate>();

            foreach (var entity in Project.Entities)
            {
                templates.Add(new EntityTemplate(Project, entity));
            }

            return templates;
        }

        public IEnumerable<ITemplateBuilder> GetTemplateBuilders() => new ITemplateBuilder[] { };
    }
}
