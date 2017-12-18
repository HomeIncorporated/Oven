using MasterBuilder.Helpers;
using MasterBuilder.Request;
using System;

namespace MasterBuilder.Templates.ProjectFiles
{
    /// <summary>
    /// angular-cli.json configration
    /// </summary>
    public class AngularCliJsonTemplate: ITemplate
    {
        private readonly Project Project;

        /// <summary>
        /// Constructor
        /// </summary>
        public AngularCliJsonTemplate(Project project)
        {
            Project = project;
        }

        /// <summary>
        /// Get file name
        /// </summary>
        public string GetFileName()
        {
            return "angular-cli.json";
        }

        /// <summary>
        /// Get file path
        /// </summary>
        public string[] GetFilePath()
        {
            return new string[] { };
        }

        /// <summary>
        /// Get file content
        /// </summary>
        public string GetFileContent()
        {
            return $@"{{
  ""$schema"": ""./node_modules/@angular/cli/lib/config/schema.json"",
  ""project"": {{
    ""name"": ""{Project.Title}""
  }},
  ""apps"": [
    {{
      ""root"": ""ClientApp""
    }}
  ],
  ""defaults"": {{
    ""styleExt"": ""scss"",
    ""component"": {{
      ""spec"": false
    }}
  }},
  ""lint"":[
    {{
      ""project"": ""ClientApp/tsconfig.app.json""
    }},
    {{
      ""project"": ""ClientApp/tsconfig.spec.json""
    }}
  ]
}}";
        }
    }
}