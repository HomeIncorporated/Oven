using Oven.Helpers;
using Oven.Shared;
using System.Threading.Tasks;

namespace Oven.Templates.Api
{
    /// <summary>
    /// Master Builder Api Project
    /// </summary>
    public class ProjectBuilder
    {
        /// <summary>
        /// Build Master Builder Api Project
        /// </summary>
        public async Task<string> RunAsync(BuilderSettings builderSettings, Request.Project project, SolutionWriter solutionWriter, string solutionDirectory, SourceControl.Git git, SourceControl.Models.GetRepository repository)
        {
            var apiProjectDirectory = FileHelper.CreateFolder(solutionDirectory, $"{project.InternalName}.Api");

            solutionWriter.SetProjectDirectory(apiProjectDirectory);

            // Create Project Files
            solutionWriter.AddTemplate(new ProjectFiles.ProjectTemplate(project));
            solutionWriter.AddTemplate(new ProjectFiles.AppSettingsTemplate(project));
            solutionWriter.AddTemplate(new ProjectFiles.WebConfigTemplate());
            solutionWriter.AddTemplate(new ProjectFiles.NuGetconfigTemplate(project));

            // Controllers
            solutionWriter.AddTemplate(new Controllers.ControllerTemplateBuilder(project));

            // Models
            solutionWriter.AddTemplate(new Models.ModelTemplateBuilder(project));
            // Models/Export
            solutionWriter.AddTemplate(new Models.Export.ModelTemplateBuilder(project));
            
            // Services
            solutionWriter.AddTemplate(new Services.ServiceTemplateBuilder(project));
            // Services/Contracts
            solutionWriter.AddTemplate(new Services.Contracts.ServiceContractTemplateBuilder(project));
            // Extensions
            solutionWriter.AddTemplate(new Extensions.NonDefaultAttributeTemplate(project));

            var errors = await solutionWriter.WriteAndClean();
            if (!string.IsNullOrEmpty(errors))
            {
                return errors;
            }

            return null;
        }
    }
}