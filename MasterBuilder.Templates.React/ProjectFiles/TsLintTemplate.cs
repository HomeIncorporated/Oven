using MasterBuilder.Interfaces;
using MasterBuilder.Request;

namespace MasterBuilder.Templates.React.ProjectFiles
{
    /// <summary>
    /// tslint.json configuration
    /// </summary>
    public class TsLintTemplate : ITemplate
    {
        private readonly Project Project;

        /// <summary>
        /// Constructor
        /// </summary>
        public TsLintTemplate(Project project)
        {
            Project = project;
        }

        /// <summary>
        /// Get file name
        /// </summary>
        public string GetFileName()
        {
            return "tslint.json";
        }

        /// <summary>
        /// Get file content
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
            return @"{
    ""extends"": [
        ""tslint-react""
    ],
    ""rules"": {
        ""align"": [
            true,
            ""parameters"",
            ""arguments"",
            ""statements""
        ],
        ""ban"": false,
        ""class-name"": true,
        ""comment-format"": [
            true,
            ""check-space""
        ],
        ""curly"": true,
        ""eofline"": false,
        ""forin"": true,
        ""indent"": [
            true,
            ""spaces"",
            2
        ],
        ""interface-name"": [
            true,
            ""never-prefix""
        ],
        ""jsdoc-format"": true,
        ""jsx-boolean-value"": false,
        ""jsx-no-lambda"": false,
        ""jsx-no-multiline-js"": false,
        ""label-position"": true,
        ""max-line-length"": [
            true,
            {
                ""limit"": 120,
                ""ignore-pattern"": ""^import {(.*?)}""
            }
        ],
        ""member-ordering"": [
            true,
            {
                ""order"": [
                    ""public-before-private"",
                    ""static-before-instance"",
                    ""variables-before-functions""
                ]
            }
        ],
        ""no-any"": false,
        ""no-arg"": true,
        ""no-bitwise"": true,
        ""no-console"": [
            true,
            ""error"",
            ""debug"",
            ""info"",
            ""time"",
            ""timeEnd"",
            ""trace""
        ],
        ""no-consecutive-blank-lines"": true,
        ""no-construct"": true,
        ""no-debugger"": true,
        ""no-duplicate-variable"": true,
        ""no-empty"": true,
        ""no-eval"": true,
        ""no-shadowed-variable"": true,
        ""no-string-literal"": true,
        ""no-switch-case-fall-through"": true,
        ""no-trailing-whitespace"": false,
        ""no-unused-expression"": true,
        ""no-use-before-declare"": false,
        ""one-line"": [
            true,
            ""check-catch"",
            ""check-else"",
            ""check-open-brace"",
            ""check-whitespace""
        ],
        ""quotemark"": [
            true,
            ""single"",
            ""jsx-double""
        ],
        ""radix"": true,
        ""semicolon"": [
            true,
            ""always"",
            ""ignore-bound-class-methods""
        ],
        ""switch-default"": true,
        ""trailing-comma"": [
            false
        ],
        ""triple-equals"": [
            true,
            ""allow-null-check""
        ],
        ""typedef"": [
            true,
            ""parameter"",
            ""property-declaration""
        ],
        ""typedef-whitespace"": [
            true,
            {
                ""call-signature"": ""nospace"",
                ""index-signature"": ""nospace"",
                ""parameter"": ""nospace"",
                ""property-declaration"": ""nospace"",
                ""variable-declaration"": ""nospace""
            }
        ],
        ""variable-name"": [
            true,
            ""ban-keywords"",
            ""check-format"",
            ""allow-leading-underscore"",
            ""allow-pascal-case""
        ],
        ""whitespace"": [
            true,
            ""check-branch"",
            ""check-decl"",
            ""check-module"",
            ""check-operator"",
            ""check-separator"",
            ""check-type"",
            ""check-typecast""
        ]
    }
}";
        }
    }
}