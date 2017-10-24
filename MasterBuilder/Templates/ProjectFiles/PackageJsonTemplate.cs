﻿using MasterBuilder.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterBuilder.Templates.ProjectFiles
{
    public class PackageJsonTemplate
    {
        public static string FileName()
        {
            return "package.json";
        }
        public static string Evaluate(Project project)
        {
            var topSettings = $@"""name"": ""{project.InternalName}"",
  ""private"": true,
  ""version"": ""{project.Version}"",
  ""scripts"": {{
    ""test"": ""karma start ClientApp/test/karma.conf.js""
  }}";

            var dependencies = @"""dependencies"": {
    ""@angular/animations"": ""4.2.5"",
    ""@angular/common"": ""4.2.5"",
    ""@angular/compiler"": ""4.2.5"",
    ""@angular/compiler-cli"": ""4.2.5"",
    ""@angular/core"": ""4.2.5"",
    ""@angular/forms"": ""4.2.5"",
    ""@angular/http"": ""4.2.5"",
    ""@angular/platform-browser"": ""4.2.5"",
    ""@angular/platform-browser-dynamic"": ""4.2.5"",
    ""@angular/platform-server"": ""4.2.5"",
    ""@angular/router"": ""4.2.5"",
    ""@ngtools/webpack"": ""1.5.0"",
    ""@types/webpack-env"": ""1.13.0"",
    ""angular2-template-loader"": ""0.6.2"",
    ""aspnet-prerendering"": ""^3.0.1"",
    ""aspnet-webpack"": ""^2.0.1"",
    ""awesome-typescript-loader"": ""3.2.1"",
    ""bootstrap"": ""3.3.7"",
    ""css"": ""2.2.1"",
    ""css-loader"": ""0.28.4"",
    ""es6-shim"": ""0.35.3"",
    ""event-source-polyfill"": ""0.0.9"",
    ""expose-loader"": ""0.7.3"",
    ""extract-text-webpack-plugin"": ""2.1.2"",
    ""file-loader"": ""0.11.2"",
    ""html-loader"": ""0.4.5"",
    ""isomorphic-fetch"": ""2.2.1"",
    ""jquery"": ""3.2.1"",
    ""json-loader"": ""0.5.4"",
    ""preboot"": ""4.5.2"",
    ""raw-loader"": ""0.5.1"",
    ""reflect-metadata"": ""0.1.10"",
    ""rxjs"": ""5.4.2"",
    ""style-loader"": ""0.18.2"",
    ""to-string-loader"": ""1.1.5"",
    ""typescript"": ""2.4.1"",
    ""url-loader"": ""0.5.9"",
    ""webpack"": ""2.5.1"",
    ""webpack-hot-middleware"": ""2.18.2"",
    ""webpack-merge"": ""4.1.0"",
    ""zone.js"": ""0.8.12""
  }";

            var devDependencies = @"""devDependencies"": {
    ""@types/chai"": ""4.0.1"",
    ""@types/jasmine"": ""2.5.53"",
    ""chai"": ""4.0.2"",
    ""jasmine-core"": ""2.6.4"",
    ""karma"": ""1.7.0"",
    ""karma-chai"": ""0.1.0"",
    ""karma-chrome-launcher"": ""2.2.0"",
    ""karma-cli"": ""1.0.1"",
    ""karma-jasmine"": ""1.1.0"",
    ""karma-webpack"": ""2.0.3""
  }";

            return string.Concat("{", 
                string.Join(",", topSettings, dependencies, devDependencies), 
                "}");
        }
    }
}
