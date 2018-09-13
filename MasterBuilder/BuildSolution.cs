using MasterBuilder.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasterBuilder
{
    /// <summary>
    /// Build Solution
    /// </summary>
    public class BuildSolution
    {
        private readonly BuilderSettings builderSettings;

        /// <summary>
        /// Constructor
        /// </summary>
        public BuildSolution(BuilderSettings builderSettings)
        {
            this.builderSettings = builderSettings;
        }

        /// <summary>
        /// Run Master Builder
        /// </summary>
        public async Task<string> RunAsync(Request.Project project)
        {
            if (project == null)
            {
                return "null project";
            }

            // Validate & Pre Process Project
            if (!project.ValidateAndResolve(out string messages))
            {
                return messages;
            }

            var topProjectDirectory = FileHelper.CreateFolder(builderSettings.OutputDirectory, project.InternalName);

            SourceControl.Git git = null;
            SourceControl.Models.GetRepository repository = null;
            Dictionary<string, SourceControl.Models.GetRepository> repos = null;
            if (builderSettings.GitPushOn || builderSettings.GitPullOn || builderSettings.CreateMigrations)
            {
                git = new SourceControl.Git(topProjectDirectory, project, builderSettings.GitUserName, builderSettings.GitEmail, builderSettings.VstsPersonalAccessToken);
            }

            if (builderSettings.GitPullOn)
            {
                repos = await git.SetupAndGetRepos();
                repository = repos[project.InternalName];
            }

            // Create Solution Directory
            var solutionDirectory = FileHelper.CreateFolder(topProjectDirectory, project.InternalName);
            
            var solutionWriter = new Helpers.SolutionWriter(solutionDirectory, project.CleanDirectoryIgnoreDirectories);

            var solution = new SolutionBuilder();
            var errors = await solution.RunAsync(builderSettings, project, solutionWriter, solutionDirectory);
            if (!string.IsNullOrEmpty(errors))
            {
                return errors;
            }

            var react = new Templates.React.ProjectBuilder();
            errors = await react.RunAsync(builderSettings, project, solutionWriter, solutionDirectory);
            if (!string.IsNullOrEmpty(errors))
            {
                return errors;
            }
            
            var api = new Templates.Api.ProjectBuilder();
            errors = await api.RunAsync(builderSettings, project, solutionWriter, solutionDirectory, git, repository);
            if (!string.IsNullOrEmpty(errors))
            {
                return errors;
            }

            var dal = new Templates.DataAccessLayer.ProjectBuilder();
            errors = await dal.RunAsync(builderSettings, project, solutionWriter, solutionDirectory, git, repository);
            if (!string.IsNullOrEmpty(errors))
            {
                return errors;
            }

            if (builderSettings.GitPushOn)
            {
                var rtf = new SourceControl.RequestToFileSystem(topProjectDirectory, project);
                await rtf.Write();

                git.StageCommitPush(repos["Json"], "Build");
                git.StageCommitPush(repository, "Build");
            }
            return "Success";
        }
    }
}
