using Humanizer;
using MasterBuilder.Helpers;
using MasterBuilder.Request;
using System;

namespace MasterBuilder.Templates.ProjectFiles
{
    /// <summary>
    /// package.json configuration
    /// </summary>
    public class PackageJsonTemplate : ITemplate
    {
        private readonly Project Project;

        /// <summary>
        /// Constructor
        /// </summary>
        public PackageJsonTemplate(Project project)
        {
            Project = project;
        }

        /// <summary>
        /// Get file name
        /// </summary>
        public string GetFileName()
        {
            return "package.json";
        }

        /// <summary>
        /// Get file path
        /// </summary>
        public string[] GetFilePath()
        {
            return new string[] { };
        }

        /// <summary>
        /// Get file path
        /// </summary>
        /// <returns></returns>
        public string GetFileContent()
        {
            var angularVersion = "^5.1.3"; //same version used by multiple angular packages

            // 'private: true' ensures that this project will not be published on npm
            var topSettings = $@"""name"": ""{Project.InternalName.Kebaberize()}"",
  ""private"": true,
  ""version"": ""{Project.Version}""";

            var scripts = @"""scripts"": {
    ""lint"": ""tslint -p tsconfig.json"",
    ""test"": ""npm run build:vendor && karma start ClientApp/test/karma.conf.js"",
    ""test:watch"": ""npm run test -- --auto-watch --no-single-run"",
    ""test:ci"": ""npm run test -- --browsers PhantomJS_custom"",
    ""test:ci:watch"": ""npm run test:ci -- --auto-watch --no-single-run"",
    ""test:coverage"": ""npm run test -- --coverage"",
    ""build:dev"": ""npm run build:vendor && npm run build:webpack"",
    ""build:webpack"": ""webpack --progress --color"",
    ""build:prod"": ""npm run clean && npm run build:vendor -- --env.prod && npm run build:webpack -- --env.prod"",
    ""build:vendor"": ""webpack --config webpack.config.vendor.js --progress --color"",
    ""clean"": ""rimraf wwwroot/dist clientapp/dist""
  }";

            var dependencies = $@"""dependencies"": {{
    ""@angular/material"": ""^5.0.3"",
    ""hammerjs"": ""^2.0.8"",
    ""@angular/cdk"": ""^5.0.3"",
    ""@angular/animations"": ""{angularVersion}"",
    ""@angular/common"": ""{angularVersion}"",
    ""@angular/compiler"": ""{angularVersion}"",
    ""@angular/compiler-cli"": ""{angularVersion}"",
    ""@angular/core"": ""{angularVersion}"",
    ""@angular/forms"": ""{angularVersion}"",
    ""@angular/http"": ""{angularVersion}"",
    ""@angular/platform-browser"": ""{angularVersion}"",
    ""@angular/platform-browser-dynamic"": ""{angularVersion}"",
    ""@angular/platform-server"": ""{angularVersion}"",
    ""@angular/router"": ""{angularVersion}"",
    ""@angular/flex-layout"": ""^2.0.0-beta.12"",
    ""@nguniversal/aspnetcore-engine"": ""^5.0.0-beta.5"",
    ""@nguniversal/common"": ""^5.0.0-beta.5"",
    ""@ngx-translate/core"": ""^8.0.0"",
    ""@ngx-translate/http-loader"": ""^2.0.0"",
    ""@types/node"": ""^7.0.12"",
    ""angular2-router-loader"": ""^0.3.5"",
    ""angular2-template-loader"": ""^0.6.2"",
    ""aspnet-prerendering"": ""^3.0.1"",
    ""aspnet-webpack"": ""^2.0.1"",
    ""awesome-typescript-loader"": ""^3.0.0"",
    ""bootstrap"": ""^3.3.7"",
    ""bootstrap-sass"": ""^3.3.7"",
    ""core-js"": ""^2.5.1"",
    ""css"": ""^2.2.1"",
    ""css-loader"": ""^0.28.7"",
    ""event-source-polyfill"": ""^0.0.9"",
    ""expose-loader"": ""^0.7.3"",
    ""extract-text-webpack-plugin"": ""^3.0.0"",
    ""file-loader"": ""^0.11.2"",
    ""html-loader"": ""^0.5.1"",
    ""isomorphic-fetch"": ""^2.2.1"",
    ""jquery"": ""^2.2.1"",
    ""json-loader"": ""^0.5.4"",
    ""moment"": ""2.18.1"",
    ""ngx-bootstrap"": ""2.0.0-beta.6"",
    ""node-sass"": ""^4.5.2"",
    ""preboot"": ""^5.0.0"",
    ""raw-loader"": ""^0.5.1"",
    ""rimraf"": ""^2.6.2"",
    ""rxjs"": ""^5.4.3"",
    ""sass-loader"": ""^6.0.6"",
    ""style-loader"": ""^0.18.2"",
    ""to-string-loader"": ""^1.1.5"",
    ""typescript"": ""2.5.3"",
    ""url-loader"": ""^0.5.7"",
    ""webpack"": ""^3.6.0"",
    ""webpack-hot-middleware"": ""^2.19.1"",
    ""webpack-merge"": ""^4.1.0"",
    ""zone.js"": ""^0.8.17""
  }}";

            var devDependencies = @"""devDependencies"": {
    ""@angular/cli"": ""^1.6.3"",
    ""@ngtools/webpack"": ""^1.9.3"",
    ""@types/chai"": ""^3.4.34"",
    ""@types/jasmine"": ""^2.5.37"",
    ""chai"": ""^3.5.0"",
    ""codelyzer"": ""^3.0.0"",
    ""istanbul-instrumenter-loader"": ""^3.0.0"",
    ""jasmine-core"": ""^2.5.2"",
    ""karma"": ""^1.7.1"",
    ""karma-chai"": ""^0.1.0"",
    ""karma-chrome-launcher"": ""^2.2.0"",
    ""karma-coverage"": ""^1.1.1"",
    ""karma-jasmine"": ""^1.1.0"",
    ""karma-mocha-reporter"": ""^2.2.4"",
    ""karma-phantomjs-launcher"": ""^1.0.4"",
    ""karma-remap-coverage"": ""^0.1.4"",
    ""karma-sourcemap-loader"": ""^0.3.7"",
    ""karma-webpack"": ""^2.0.3"",
    ""tslint"": ""^5.7.0"",
    ""webpack-bundle-analyzer"": ""^2.9.0""
  }";

            return string.Concat("{", 
                string.Join(",", topSettings, scripts, dependencies, devDependencies), 
                "}");
        }
        
    }
}
