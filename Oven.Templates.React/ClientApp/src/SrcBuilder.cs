﻿using Oven.Interfaces;
using Oven.Request;
using System.Collections.Generic;

namespace Oven.Templates.React.ClientApp.Src
{
    /// <summary>
    /// Src Components
    /// </summary>
    public class SrcBuilder : ITemplateBuilder
    {
        private readonly Project Project;

        /// <summary>
        /// Constructor
        /// </summary>
        public SrcBuilder(Project project)
        {
            Project = project;
        }


        public IEnumerable<ITemplateBuilder> GetTemplateBuilders()
        {
            var templateBuilders = new List<ITemplateBuilder>
            {
                new Components.ComponentBuilder(Project),
                new Resources.ResourceBuilder(Project)
            };

            return templateBuilders;
        }

        public IEnumerable<ITemplate> GetTemplates()
        {
            var templates = new List<ITemplate>
            {
                new AppTemplate(Project),
                new IndexTemplate(Project),
                new LayoutTemplate(Project),
                new MenuTemplate(Project),
                new RestProviderTemplate(Project),
                new RoutesTemplate(Project),
                new RegisterServiceWorkerTemplate(Project)
            };

            return templates;
        }
    }
}
