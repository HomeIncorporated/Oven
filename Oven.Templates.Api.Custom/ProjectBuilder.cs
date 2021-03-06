﻿using Oven.Helpers;
using Oven.Shared;
using System;
using System.Threading.Tasks;

namespace Oven.Templates.Api.Custom
{
    /// <summary>
    /// Master Builder Api Custom Project
    /// </summary>
    public class ProjectBuilder
    {
        /// <summary>
        /// Build Master Builder Api Custom Project
        /// </summary>
        public async Task<string> RunAsync(BuilderSettings builderSettings, Request.Project project, SolutionWriter solutionWriter, string solutionDirectory, SourceControl.Git git, SourceControl.Models.GetRepository repository)
        {
            var apiProjectDirectory = FileHelper.CreateFolder(solutionDirectory, $"{project.InternalName}.Api.Custom");

            if (!FileHelper.IsDirectoryEmpty(apiProjectDirectory))
            {
                // If directory exists then skip this project, user can do what ever they want here
                return null;
            }

            solutionWriter.SetProjectDirectory(apiProjectDirectory);

            // Create Project Files
            solutionWriter.AddTemplate(new ProjectFiles.ProjectTemplate(project));

            // Extension Point
            solutionWriter.AddTemplate(new ProjectFiles.ExtensionPointTemplate(project));

            var errors = await solutionWriter.WriteAndClean();
            if (!string.IsNullOrEmpty(errors))
            {
                return errors;
            }

            return null;
        }
    }
}