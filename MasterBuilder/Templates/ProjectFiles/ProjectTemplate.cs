﻿using MasterBuilder.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterBuilder.Templates.ProjectFiles
{
    public class ProjectTemplate
    {
        public static string FileName(Project project)
        {
            return $"{project.InternalName}.csproj";
        }
        public static string Evaluate(Project project)
        {
            string solutionGuid = Guid.NewGuid().ToString();
            return $@"<Project Sdk=""Microsoft.NET.Sdk.Web"">

  <PropertyGroup>
    <TargetFramework>netcoreapp2.0</TargetFramework>
    <TypeScriptCompileBlocked>true</TypeScriptCompileBlocked>
    <TypeScriptToolsVersion>Latest</TypeScriptToolsVersion>
    <IsPackable>false</IsPackable>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include=""Microsoft.AspNetCore.All"" Version=""2.0.0"" />
  </ItemGroup>

  <ItemGroup>
    <DotNetCliToolReference Include=""Microsoft.VisualStudio.Web.CodeGeneration.Tools"" Version=""2.0.0"" />
  </ItemGroup>

  <ItemGroup>
    <!-- Files not to publish (note that the 'dist' subfolders are re-added below) -->
    <Content Remove=""ClientApp\**"" />
  </ItemGroup>

  <Target Name=""DebugRunWebpack"" BeforeTargets=""Build"" Condition="" '$(Configuration)' == 'Debug' And !Exists('wwwroot\dist') "">
    <!-- Ensure Node.js is installed -->
    <Exec Command=""node --version"" ContinueOnError=""true"">
      <Output TaskParameter=""ExitCode"" PropertyName=""ErrorCode"" />
    </Exec>
    <Error Condition=""'$(ErrorCode)' != '0'"" Text=""Node.js is required to build and run this project. To continue, please install Node.js from https://nodejs.org/, and then restart your command prompt or IDE."" />

    <!-- In development, the dist files won't exist on the first run or when cloning to
         a different machine, so rebuild them if not already present. -->
    <Message Importance=""high"" Text=""Performing first-run Webpack build..."" />
    <Exec Command=""node node_modules/webpack/bin/webpack.js --config webpack.config.vendor.js"" />
    <Exec Command=""node node_modules/webpack/bin/webpack.js"" />
  </Target>

  <Target Name=""PublishRunWebpack"" AfterTargets=""ComputeFilesToPublish"">
    <!-- As part of publishing, ensure the JS resources are freshly built in production mode -->
    <Exec Command=""npm install"" />
    <Exec Command=""node node_modules/webpack/bin/webpack.js --config webpack.config.vendor.js --env.prod"" />
    <Exec Command=""node node_modules/webpack/bin/webpack.js --env.prod"" />

    <!-- Include the newly-built files in the publish output -->
    <ItemGroup>
      <DistFiles Include=""wwwroot\dist\**; ClientApp\dist\**"" />
      <ResolvedFileToPublish Include=""@(DistFiles->'%(FullPath)')"" Exclude=""@(ResolvedFileToPublish)"">
        <RelativePath>%(DistFiles.Identity)</RelativePath>
        <CopyToPublishDirectory>PreserveNewest</CopyToPublishDirectory>
      </ResolvedFileToPublish>
    </ItemGroup>
  </Target>

</Project>";
        }
    }
}
