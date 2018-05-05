using MasterBuilder.Interfaces;
using MasterBuilder.Request;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterBuilder.Templates.Api.Models.Export
{
    /// <summary>
    /// Model Template Builder
    /// </summary>
    public class ModelTemplateBuilder : ITemplateBuilder
    {
        private readonly Project Project;

        /// <summary>
        /// Constructor
        /// </summary>
        public ModelTemplateBuilder(Project project)
        {
            Project = project;
        }

        /// <summary>
        /// Get model templates
        /// </summary>
        public IEnumerable<ITemplate> GetTemplates()
        {
            var templates = new List<ITemplate>();

            if (Project.Id == Project.MasterBuilderId)
            {
                var projectEntity = Project.Entities.SingleOrDefault(a => a.Id == new Guid("{89920EA4-9099-487A-AEBB-390E401FEC26}"));
                templates.AddRange(new ExportModelTemplateBuilder(Project, projectEntity, projectEntity).GetTemplates());
            }

            return templates;
        }
    }
}