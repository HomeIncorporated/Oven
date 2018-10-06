﻿using Oven.Helpers;
using Oven.Shared;
using System;
using System.Threading.Tasks;

namespace Oven.Templates.Api.Shared
{
    /// <summary>
    /// Master Builder Api Shared Project
    /// </summary>
    public class ProjectBuilder
    {
        /// <summary>
        /// Build Master Builder Api Shared Project
        /// </summary>
        public async Task<string> RunAsync(BuilderSettings builderSettings, Request.Project project, SolutionWriter solutionWriter, string solutionDirectory, SourceControl.Git git, SourceControl.Models.GetRepository repository)
        {
            var apiProjectDirectory = FileHelper.CreateFolder(solutionDirectory, $"{project.InternalName}.Api.Shared");

            solutionWriter.SetProjectDirectory(apiProjectDirectory);

            // Create Project Files
            solutionWriter.AddTemplate(new ProjectFiles.ProjectTemplate(project));

            var errors = await solutionWriter.WriteAndClean();
            if (!string.IsNullOrEmpty(errors))
            {
                return errors;
            }

            return null;
        }
    }
}