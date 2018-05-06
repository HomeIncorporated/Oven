using MasterBuilder.Interfaces;
using MasterBuilder.Request;

namespace MasterBuilder.Templates.React.Views.Shared
{
    /// <summary>
    /// Layout
    /// </summary>
    public class LayoutTemplate : ITemplate
    {
        private readonly Project Project;

        /// <summary>
        /// Constructor
        /// </summary>
        public LayoutTemplate(Project project)
        {
            Project = project;
        }

        /// <summary>
        /// Get file name
        /// </summary>
        public string GetFileName()
        {
            return "_Layout.cshtml";
        }

        /// <summary>
        /// Get file path
        /// </summary>
        public string[] GetFilePath()
        {
            return new string[] { "Views", "Shared" };
        }

        /// <summary>
        /// Get file content
        /// </summary>
        public string GetFileContent()
        {
            return $@"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <title>@ViewData[""Title""] - {Project.Title}</title>
    <base href=""~/"" />

    <link rel=""stylesheet"" href=""~/dist/vendor.css"" asp-append-version=""true"" />
    <link rel=""stylesheet"" href=""~/dist/site.css"" asp-append-version=""true"" />
</head>
<body>
    <noscript><p>Please enable javascript to use this site</p></noscript>
    @RenderBody()

    <script src=""~/dist/vendor.js"" asp-append-version=""true""></script>
    @RenderSection(""scripts"", required: false)
</body>
</html>";
        }
    }
}