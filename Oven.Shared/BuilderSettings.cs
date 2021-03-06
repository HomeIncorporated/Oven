namespace Oven.Shared
{
    /// <summary>
    /// Builder Settings
    /// </summary>
    public class BuilderSettings
    {
        /// <summary>
        /// Base project output directory
        /// </summary>
        public string OutputDirectory { get; set; }
        /// <summary>
        /// Git User Name
        /// </summary>
        public string GitUserName { get; set; }
        /// <summary>
        /// Git Email
        /// </summary>
        public string GitEmail { get; set; }
        /// <summary>
        /// Visual Studio Team Services Personal Access Token
        /// </summary>
        public string VstsPersonalAccessToken { get; set; }
        /// <summary>
        /// Allow push to git, NOTE: Git Pull will need to be run at least once before Git Push will work
        /// </summary>
        public bool GitPushOn { get; set; } = true;
        /// <summary>
        /// Allow pull from git
        /// </summary>
        public bool GitPullOn { get; set; } = true;
    }
}
