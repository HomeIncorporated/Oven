﻿namespace MasterBuilder.Templates.ProjectFiles
{
    public class TypeScriptConfigTemplate
    {
        public static string FileName()
        {
            return "tsconfig.json";
        }
        public static string Evaluate()
        {
            return @"{
  ""compilerOptions"": {
    ""module"": ""es2015"",
    ""moduleResolution"": ""node"",
    ""target"": ""es5"",
    ""sourceMap"": true,
    ""experimentalDecorators"": true,
    ""emitDecoratorMetadata"": true,
    ""skipDefaultLibCheck"": true,
    ""skipLibCheck"": true, // Workaround for https://github.com/angular/angular/issues/17863. Remove this if you upgrade to a fixed version of Angular.
    ""strict"": true,
    ""lib"": [ ""es6"", ""dom"" ],
    ""types"": [ ""webpack-env"" ]
    },
  ""exclude"": [ ""bin"", ""node_modules"" ],
  ""atom"": { ""rewriteTsconfig"": false }
}";
        }
    }
}
