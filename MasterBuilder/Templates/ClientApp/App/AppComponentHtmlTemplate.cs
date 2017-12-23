using MasterBuilder.Helpers;

namespace MasterBuilder.Templates.ClientApp.App
{
    /// <summary>
    /// app.component template
    /// </summary>
    public class AppComponentHtmlTemplate : ITemplate
    {
        /// <summary>
        /// Get file name
        /// </summary>
        public string GetFileName()
        {
            return "app.component.html";
        }

        /// <summary>
        /// Get file path
        /// </summary>
        public string[] GetFilePath()
        {
            return new[] { "ClientApp", "app" };
        }

        /// <summary>
        /// Get file content
        /// </summary>
        public string GetFileContent()
        {
            return @"<div class=""col-sm-3"">
    <app-nav-menu></app-nav-menu>
</div>
<div class=""col-sm-9 body-content"">
    <router-outlet></router-outlet>
</div>";
        }
    }
}
