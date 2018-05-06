using MasterBuilder.Interfaces;
using MasterBuilder.Request;

namespace MasterBuilder.Templates.React.ProjectFiles
{
    /// <summary>
    /// package-lock.json configuration
    /// </summary>
    public class PackageLockJsonTemplate : ITemplate
    {
        private readonly Project Project;

        /// <summary>
        /// Constructor
        /// </summary>
        public PackageLockJsonTemplate(Project project)
        {
            Project = project;
        }

        /// <summary>
        /// Get file name
        /// </summary>
        public string GetFileName()
        {
            return "package-lock.json";
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
            return $@"{{
  ""name"": ""jimjam"",
  ""version"": ""1.0.0"",
  ""lockfileVersion"": 1,
  ""requires"": true,
  ""dependencies"": {{
    ""abab"": {{
      ""version"": ""1.0.4"",
      ""resolved"": ""https://registry.npmjs.org/abab/-/abab-1.0.4.tgz"",
      ""integrity"": ""sha1-X6rZwsB/YN12dw9xzwJbYqY8/U4="",
      ""dev"": true
    }},
    ""abbrev"": {{
      ""version"": ""1.1.1"",
      ""resolved"": ""https://registry.npmjs.org/abbrev/-/abbrev-1.1.1.tgz"",
      ""integrity"": ""sha512-nne9/IiQ/hzIhY6pdDnbBtz7DjPTKrY00P/zvPSm5pOFkl6xuGrGnXn/VtTNNfNtAfZ9/1RtehkszU9qcTii0Q=="",
      ""dev"": true
    }},
    ""accepts"": {{
      ""version"": ""1.3.4"",
      ""resolved"": ""https://registry.npmjs.org/accepts/-/accepts-1.3.4.tgz"",
      ""integrity"": ""sha1-hiRnWMfdbSGmR0/whKR0DsBesh8="",
      ""dev"": true,
      ""requires"": {{
        ""mime-types"": ""2.1.17"",
        ""negotiator"": ""0.6.1""
      }}
    }},
    ""acorn-dynamic-import"": {{
      ""version"": ""2.0.2"",
      ""resolved"": ""https://registry.npmjs.org/acorn-dynamic-import/-/acorn-dynamic-import-2.0.2.tgz"",
      ""integrity"": ""sha1-x1K9IQvvZ5UBtsbLf8hPj0cVjMQ="",
      ""dev"": true,
      ""requires"": {{
        ""acorn"": ""4.0.13""
      }},
      ""dependencies"": {{
        ""acorn"": {{
          ""version"": ""4.0.13"",
          ""resolved"": ""https://registry.npmjs.org/acorn/-/acorn-4.0.13.tgz"",
          ""integrity"": ""sha1-EFSVrlNh1pe9GVyCUZLhrX8lN4c="",
          ""dev"": true
        }}
      }}
    }},
    ""acorn-globals"": {{
      ""version"": ""3.1.0"",
      ""resolved"": ""https://registry.npmjs.org/acorn-globals/-/acorn-globals-3.1.0.tgz"",
      ""integrity"": ""sha1-/YJw9x+7SZawBPqIDuXUZXOnMb8="",
      ""dev"": true,
      ""requires"": {{
        ""acorn"": ""4.0.13""
      }},
      ""dependencies"": {{
        ""acorn"": {{
          ""version"": ""4.0.13"",
          ""resolved"": ""https://registry.npmjs.org/acorn/-/acorn-4.0.13.tgz"",
          ""integrity"": ""sha1-EFSVrlNh1pe9GVyCUZLhrX8lN4c="",
          ""dev"": true
        }}
      }}
    }},
    ""acorn-jsx"": {{
      ""version"": ""3.0.1"",
      ""resolved"": ""https://registry.npmjs.org/acorn-jsx/-/acorn-jsx-3.0.1.tgz"",
      ""integrity"": ""sha1-r9+UiPsezvyDSPb7IvRk4ypYs2s="",
      ""dev"": true,
      ""requires"": {{
        ""acorn"": ""3.3.0""
      }},
      ""dependencies"": {{
        ""acorn"": {{
          ""version"": ""3.3.0"",
          ""resolved"": ""https://registry.npmjs.org/acorn/-/acorn-3.3.0.tgz"",
          ""integrity"": ""sha1-ReN/s56No/JbruP/U2niu18iAXo="",
          ""dev"": true
        }}
      }}
    }},
    ""ajv"": {{
      ""version"": ""4.11.8"",
      ""resolved"": ""https://registry.npmjs.org/ajv/-/ajv-4.11.8.tgz"",
      ""integrity"": ""sha1-gv+wKynmYq5TvcIK8VlHcGc5xTY="",
      ""dev"": true,
      ""requires"": {{
        ""co"": ""4.6.0"",
        ""json-stable-stringify"": ""1.0.1""
      }}
    }},
    ""ajv-keywords"": {{
      ""version"": ""1.5.1"",
      ""resolved"": ""https://registry.npmjs.org/ajv-keywords/-/ajv-keywords-1.5.1.tgz"",
      ""integrity"": ""sha1-MU3QpLM2j609/NxU7eYXG4htrzw="",
      ""dev"": true
    }},
    ""align-text"": {{
      ""version"": ""0.1.4"",
      ""resolved"": ""https://registry.npmjs.org/align-text/-/align-text-0.1.4.tgz"",
      ""integrity"": ""sha1-DNkKVhCT810KmSVsIrcGlDP60Rc="",
      ""dev"": true,
      ""requires"": {{
        ""kind-of"": ""3.2.2"",
        ""longest"": ""1.0.1"",
        ""repeat-string"": ""1.6.1""
      }}
    }},
    ""alphanum-sort"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/alphanum-sort/-/alphanum-sort-1.0.2.tgz"",
      ""integrity"": ""sha1-l6ERlkmyEa0zaR2fn0hqjsn74KM="",
      ""dev"": true
    }},
    ""amdefine"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/amdefine/-/amdefine-1.0.1.tgz"",
      ""integrity"": ""sha1-SlKCrBZHKek2Gbz9OtFR+BfOkfU="",
      ""dev"": true
    }},
    ""ansi-escapes"": {{
      ""version"": ""1.4.0"",
      ""resolved"": ""https://registry.npmjs.org/ansi-escapes/-/ansi-escapes-1.4.0.tgz"",
      ""integrity"": ""sha1-06ioOzGapneTZisT52HHkRQiMG4="",
      ""dev"": true
    }},
    ""ansi-html"": {{
      ""version"": ""0.0.7"",
      ""resolved"": ""https://registry.npmjs.org/ansi-html/-/ansi-html-0.0.7.tgz"",
      ""integrity"": ""sha1-gTWEAhliqenm/QOflA0S9WynhZ4="",
      ""dev"": true
    }},
    ""ansi-regex"": {{
      ""version"": ""2.1.1"",
      ""resolved"": ""https://registry.npmjs.org/ansi-regex/-/ansi-regex-2.1.1.tgz"",
      ""integrity"": ""sha1-w7M6te42DYbg5ijwRorn7yfWVN8="",
      ""dev"": true
    }},
    ""ansi-styles"": {{
      ""version"": ""2.2.1"",
      ""resolved"": ""https://registry.npmjs.org/ansi-styles/-/ansi-styles-2.2.1.tgz"",
      ""integrity"": ""sha1-tDLdM1i2NM914eRmQ2gkBTPB3b4="",
      ""dev"": true
    }},
    ""any-promise"": {{
      ""version"": ""0.1.0"",
      ""resolved"": ""https://registry.npmjs.org/any-promise/-/any-promise-0.1.0.tgz"",
      ""integrity"": ""sha1-gwtoCqflbzNFHUsEnzvYBESY7ic="",
      ""dev"": true
    }},
    ""anymatch"": {{
      ""version"": ""1.3.2"",
      ""resolved"": ""https://registry.npmjs.org/anymatch/-/anymatch-1.3.2.tgz"",
      ""integrity"": ""sha512-0XNayC8lTHQ2OI8aljNCN3sSx6hsr/1+rlcDAotXJR7C1oZZHCNsfpbKwMjRA3Uqb5tF1Rae2oloTr4xpq+WjA=="",
      ""dev"": true,
      ""requires"": {{
        ""micromatch"": ""2.3.11"",
        ""normalize-path"": ""2.1.1""
      }}
    }},
    ""append-transform"": {{
      ""version"": ""0.4.0"",
      ""resolved"": ""https://registry.npmjs.org/append-transform/-/append-transform-0.4.0.tgz"",
      ""integrity"": ""sha1-126/jKlNJ24keja61EpLdKthGZE="",
      ""dev"": true,
      ""requires"": {{
        ""default-require-extensions"": ""1.0.0""
      }}
    }},
    ""aproba"": {{
      ""version"": ""1.2.0"",
      ""resolved"": ""https://registry.npmjs.org/aproba/-/aproba-1.2.0.tgz"",
      ""integrity"": ""sha512-Y9J6ZjXtoYh8RnXVCMOU/ttDmk1aBjunq9vO0ta5x85WDQiQfUF9sIPBITdbiiIVcBo03Hi3jMxigBtsddlXRw=="",
      ""dev"": true
    }},
    ""are-we-there-yet"": {{
      ""version"": ""1.1.4"",
      ""resolved"": ""https://registry.npmjs.org/are-we-there-yet/-/are-we-there-yet-1.1.4.tgz"",
      ""integrity"": ""sha1-u13KOCu5TwXhUZQ3PRb9O6HKEQ0="",
      ""dev"": true,
      ""requires"": {{
        ""delegates"": ""1.0.0"",
        ""readable-stream"": ""2.3.3""
      }},
      ""dependencies"": {{
        ""isarray"": {{
          ""version"": ""1.0.0"",
          ""resolved"": ""https://registry.npmjs.org/isarray/-/isarray-1.0.0.tgz"",
          ""integrity"": ""sha1-u5NdSFgsuhaMBoNJV6VKPgcSTxE="",
          ""dev"": true
        }},
        ""readable-stream"": {{
          ""version"": ""2.3.3"",
          ""resolved"": ""https://registry.npmjs.org/readable-stream/-/readable-stream-2.3.3.tgz"",
          ""integrity"": ""sha512-m+qzzcn7KUxEmd1gMbchF+Y2eIUbieUaxkWtptyHywrX0rE8QEYqPC07Vuy4Wm32/xE16NcdBctb8S0Xe/5IeQ=="",
          ""dev"": true,
          ""requires"": {{
            ""core-util-is"": ""1.0.2"",
            ""inherits"": ""2.0.3"",
            ""isarray"": ""1.0.0"",
            ""process-nextick-args"": ""1.0.7"",
            ""safe-buffer"": ""5.1.1"",
            ""string_decoder"": ""1.0.3"",
            ""util-deprecate"": ""1.0.2""
          }}
        }},
        ""string_decoder"": {{
          ""version"": ""1.0.3"",
          ""resolved"": ""https://registry.npmjs.org/string_decoder/-/string_decoder-1.0.3.tgz"",
          ""integrity"": ""sha512-4AH6Z5fzNNBcH+6XDMfA/BTt87skxqJlO0lAh3Dker5zThcAxG6mKz+iGu308UKoPPQ8Dcqx/4JhujzltRa+hQ=="",
          ""dev"": true,
          ""requires"": {{
            ""safe-buffer"": ""5.1.1""
          }}
        }}
      }}
    }},
    ""argparse"": {{
      ""version"": ""1.0.9"",
      ""resolved"": ""https://registry.npmjs.org/argparse/-/argparse-1.0.9.tgz"",
      ""integrity"": ""sha1-c9g7wmP4bpf4zE9rrhsOkKfSLIY="",
      ""dev"": true,
      ""requires"": {{
        ""sprintf-js"": ""1.0.3""
      }}
    }},
    ""arr-diff"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/arr-diff/-/arr-diff-2.0.0.tgz"",
      ""integrity"": ""sha1-jzuCf5Vai9ZpaX5KQlasPOrjVs8="",
      ""dev"": true,
      ""requires"": {{
        ""arr-flatten"": ""1.1.0""
      }}
    }},
    ""arr-flatten"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/arr-flatten/-/arr-flatten-1.1.0.tgz"",
      ""integrity"": ""sha512-L3hKV5R/p5o81R7O02IGnwpDmkp6E982XhtbuwSe3O4qOtMMMtodicASA1Cny2U+aCXcNpml+m4dPsvsJ3jatg=="",
      ""dev"": true
    }},
    ""array-equal"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/array-equal/-/array-equal-1.0.0.tgz"",
      ""integrity"": ""sha1-jCpe8kcv2ep0KwTHenUJO6J1fJM="",
      ""dev"": true
    }},
    ""array-find-index"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/array-find-index/-/array-find-index-1.0.2.tgz"",
      ""integrity"": ""sha1-3wEKoSh+Fku9pvlyOwqWoexBh6E="",
      ""dev"": true
    }},
    ""array-flatten"": {{
      ""version"": ""1.1.1"",
      ""resolved"": ""https://registry.npmjs.org/array-flatten/-/array-flatten-1.1.1.tgz"",
      ""integrity"": ""sha1-ml9pkFGx5wczKPKgCJaLZOopVdI="",
      ""dev"": true
    }},
    ""array-union"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/array-union/-/array-union-1.0.2.tgz"",
      ""integrity"": ""sha1-mjRBDk9OPaI96jdb5b5w8kd47Dk="",
      ""dev"": true,
      ""requires"": {{
        ""array-uniq"": ""1.0.3""
      }}
    }},
    ""array-uniq"": {{
      ""version"": ""1.0.3"",
      ""resolved"": ""https://registry.npmjs.org/array-uniq/-/array-uniq-1.0.3.tgz"",
      ""integrity"": ""sha1-r2rId6Jcx/dOBYiUdThY39sk/bY="",
      ""dev"": true
    }},
    ""array-unique"": {{
      ""version"": ""0.2.1"",
      ""resolved"": ""https://registry.npmjs.org/array-unique/-/array-unique-0.2.1.tgz"",
      ""integrity"": ""sha1-odl8yvy8JiXMcPrc6zalDFiwGlM="",
      ""dev"": true
    }},
    ""arrify"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/arrify/-/arrify-1.0.1.tgz"",
      ""integrity"": ""sha1-iYUI2iIm84DfkEcoRWhJwVAaSw0="",
      ""dev"": true
    }},
    ""asap"": {{
      ""version"": ""2.0.6"",
      ""resolved"": ""https://registry.npmjs.org/asap/-/asap-2.0.6.tgz"",
      ""integrity"": ""sha1-5QNHYR1+aQlDIIu9r+vLwvuGbUY=""
    }},
    ""asn1"": {{
      ""version"": ""0.2.3"",
      ""resolved"": ""https://registry.npmjs.org/asn1/-/asn1-0.2.3.tgz"",
      ""integrity"": ""sha1-2sh4dxPJlmhJ/IGAd36+nB3fO4Y="",
      ""dev"": true
    }},
    ""asn1.js"": {{
      ""version"": ""4.9.2"",
      ""resolved"": ""https://registry.npmjs.org/asn1.js/-/asn1.js-4.9.2.tgz"",
      ""integrity"": ""sha512-b/OsSjvWEo8Pi8H0zsDd2P6Uqo2TK2pH8gNLSJtNLM2Db0v2QaAZ0pBQJXVjAn4gBuugeVDr7s63ZogpUIwWDg=="",
      ""dev"": true,
      ""requires"": {{
        ""bn.js"": ""4.11.8"",
        ""inherits"": ""2.0.3"",
        ""minimalistic-assert"": ""1.0.0""
      }}
    }},
    ""assert"": {{
      ""version"": ""1.4.1"",
      ""resolved"": ""https://registry.npmjs.org/assert/-/assert-1.4.1.tgz"",
      ""integrity"": ""sha1-mZEtWRg2tab1s0XA8H7vwI/GXZE="",
      ""dev"": true,
      ""requires"": {{
        ""util"": ""0.10.3""
      }}
    }},
    ""assert-plus"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/assert-plus/-/assert-plus-1.0.0.tgz"",
      ""integrity"": ""sha1-8S4PPF13sLHN2RRpQuTpbB5N1SU="",
      ""dev"": true
    }},
    ""astral-regex"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/astral-regex/-/astral-regex-1.0.0.tgz"",
      ""integrity"": ""sha512-+Ryf6g3BKoRc7jfp7ad8tM4TtMiaWvbF/1/sQcZPkkS7ag3D5nMBCe2UfOTONtAkaG0tO0ij3C5Lwmf1EiyjHg=="",
      ""dev"": true
    }},
    ""async"": {{
      ""version"": ""2.6.0"",
      ""resolved"": ""https://registry.npmjs.org/async/-/async-2.6.0.tgz"",
      ""integrity"": ""sha512-xAfGg1/NTLBBKlHFmnd7PlmUW9KhVQIUuSrYem9xzFUZy13ScvtyGGejaae9iAVRiRq9+Cx7DPFaAAhCpyxyPw=="",
      ""dev"": true,
      ""requires"": {{
        ""lodash"": ""4.17.4""
      }}
    }},
    ""async-each"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/async-each/-/async-each-1.0.1.tgz"",
      ""integrity"": ""sha1-GdOGodntxufByF04iu28xW0zYC0="",
      ""dev"": true
    }},
    ""async-foreach"": {{
      ""version"": ""0.1.3"",
      ""resolved"": ""https://registry.npmjs.org/async-foreach/-/async-foreach-0.1.3.tgz"",
      ""integrity"": ""sha1-NhIfhFwFeBct5Bmpfb6x0W7DRUI="",
      ""dev"": true
    }},
    ""asynckit"": {{
      ""version"": ""0.4.0"",
      ""resolved"": ""https://registry.npmjs.org/asynckit/-/asynckit-0.4.0.tgz"",
      ""integrity"": ""sha1-x57Zf380y48robyXkLzDZkdLS3k="",
      ""dev"": true
    }},
    ""atob"": {{
      ""version"": ""1.1.3"",
      ""resolved"": ""https://registry.npmjs.org/atob/-/atob-1.1.3.tgz"",
      ""integrity"": ""sha1-lfE2KbEsOlGl0hWr3OKqnzL4B3M="",
      ""dev"": true
    }},
    ""autoprefixer"": {{
      ""version"": ""6.7.7"",
      ""resolved"": ""https://registry.npmjs.org/autoprefixer/-/autoprefixer-6.7.7.tgz"",
      ""integrity"": ""sha1-Hb0cg1ZY41zj+ZhAmdsAWFx4IBQ="",
      ""dev"": true,
      ""requires"": {{
        ""browserslist"": ""1.7.7"",
        ""caniuse-db"": ""1.0.30000787"",
        ""normalize-range"": ""0.1.2"",
        ""num2fraction"": ""1.2.2"",
        ""postcss"": ""5.2.18"",
        ""postcss-value-parser"": ""3.3.0""
      }}
    }},
    ""aws-sign2"": {{
      ""version"": ""0.7.0"",
      ""resolved"": ""https://registry.npmjs.org/aws-sign2/-/aws-sign2-0.7.0.tgz"",
      ""integrity"": ""sha1-tG6JCTSpWR8tL2+G1+ap8bP+dqg="",
      ""dev"": true
    }},
    ""aws4"": {{
      ""version"": ""1.6.0"",
      ""resolved"": ""https://registry.npmjs.org/aws4/-/aws4-1.6.0.tgz"",
      ""integrity"": ""sha1-g+9cqGCysy5KDe7e6MdxudtXRx4="",
      ""dev"": true
    }},
    ""axios"": {{
      ""version"": ""0.17.1"",
      ""resolved"": ""https://registry.npmjs.org/axios/-/axios-0.17.1.tgz"",
      ""integrity"": ""sha1-LY4+XQvb1zJ/kbyBT1xXZg+Bgk0="",
      ""requires"": {{
        ""follow-redirects"": ""1.3.0"",
        ""is-buffer"": ""1.1.6""
      }},
      ""dependencies"": {{
        ""debug"": {{
          ""version"": ""3.1.0"",
          ""resolved"": ""https://registry.npmjs.org/debug/-/debug-3.1.0.tgz"",
          ""integrity"": ""sha512-OX8XqP7/1a9cqkxYw2yXss15f26NKWBpDXQd0/uK/KPqdQhxbPa994hnzjcE2VqQpDslf55723cKPUOGSmMY3g=="",
          ""requires"": {{
            ""ms"": ""2.0.0""
          }}
        }},
        ""follow-redirects"": {{
          ""version"": ""1.3.0"",
          ""resolved"": ""https://registry.npmjs.org/follow-redirects/-/follow-redirects-1.3.0.tgz"",
          ""integrity"": ""sha1-9oSHH8EW0uMp/aVe9naH9Pq8kFw="",
          ""requires"": {{
            ""debug"": ""3.1.0""
          }}
        }}
      }}
    }},
    ""babel-code-frame"": {{
      ""version"": ""6.26.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-code-frame/-/babel-code-frame-6.26.0.tgz"",
      ""integrity"": ""sha1-Y/1D99weO7fONZR9uP42mj9Yx0s="",
      ""dev"": true,
      ""requires"": {{
        ""chalk"": ""1.1.3"",
        ""esutils"": ""2.0.2"",
        ""js-tokens"": ""3.0.2""
      }}
    }},
    ""babel-core"": {{
      ""version"": ""6.26.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-core/-/babel-core-6.26.0.tgz"",
      ""integrity"": ""sha1-rzL3izGm/O8RnIew/Y2XU/A6C7g="",
      ""dev"": true,
      ""requires"": {{
        ""babel-code-frame"": ""6.26.0"",
        ""babel-generator"": ""6.26.0"",
        ""babel-helpers"": ""6.24.1"",
        ""babel-messages"": ""6.23.0"",
        ""babel-register"": ""6.26.0"",
        ""babel-runtime"": ""6.26.0"",
        ""babel-template"": ""6.26.0"",
        ""babel-traverse"": ""6.26.0"",
        ""babel-types"": ""6.26.0"",
        ""babylon"": ""6.18.0"",
        ""convert-source-map"": ""1.5.1"",
        ""debug"": ""2.6.9"",
        ""json5"": ""0.5.1"",
        ""lodash"": ""4.17.4"",
        ""minimatch"": ""3.0.4"",
        ""path-is-absolute"": ""1.0.1"",
        ""private"": ""0.1.8"",
        ""slash"": ""1.0.0"",
        ""source-map"": ""0.5.7""
      }},
      ""dependencies"": {{
        ""source-map"": {{
          ""version"": ""0.5.7"",
          ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.5.7.tgz"",
          ""integrity"": ""sha1-igOdLRAh0i0eoUyA2OpGi6LvP8w="",
          ""dev"": true
        }}
      }}
    }},
    ""babel-eslint"": {{
      ""version"": ""6.1.2"",
      ""resolved"": ""https://registry.npmjs.org/babel-eslint/-/babel-eslint-6.1.2.tgz"",
      ""integrity"": ""sha1-UpNBn+NnLWZZjTJ9qWlFZ7pqXy8="",
      ""dev"": true,
      ""requires"": {{
        ""babel-traverse"": ""6.26.0"",
        ""babel-types"": ""6.26.0"",
        ""babylon"": ""6.18.0"",
        ""lodash.assign"": ""4.2.0"",
        ""lodash.pickby"": ""4.6.0""
      }}
    }},
    ""babel-generator"": {{
      ""version"": ""6.26.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-generator/-/babel-generator-6.26.0.tgz"",
      ""integrity"": ""sha1-rBriAHC3n248odMmlhMFN3TyDcU="",
      ""dev"": true,
      ""requires"": {{
        ""babel-messages"": ""6.23.0"",
        ""babel-runtime"": ""6.26.0"",
        ""babel-types"": ""6.26.0"",
        ""detect-indent"": ""4.0.0"",
        ""jsesc"": ""1.3.0"",
        ""lodash"": ""4.17.4"",
        ""source-map"": ""0.5.7"",
        ""trim-right"": ""1.0.1""
      }},
      ""dependencies"": {{
        ""source-map"": {{
          ""version"": ""0.5.7"",
          ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.5.7.tgz"",
          ""integrity"": ""sha1-igOdLRAh0i0eoUyA2OpGi6LvP8w="",
          ""dev"": true
        }}
      }}
    }},
    ""babel-helper-bindify-decorators"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-helper-bindify-decorators/-/babel-helper-bindify-decorators-6.24.1.tgz"",
      ""integrity"": ""sha1-FMGeXxQte0fxmlJDHlKxzLxAozA="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0"",
        ""babel-traverse"": ""6.26.0"",
        ""babel-types"": ""6.26.0""
      }}
    }},
    ""babel-helper-builder-binary-assignment-operator-visitor"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-helper-builder-binary-assignment-operator-visitor/-/babel-helper-builder-binary-assignment-operator-visitor-6.24.1.tgz"",
      ""integrity"": ""sha1-zORReto1b0IgvK6KAsKzRvmlZmQ="",
      ""dev"": true,
      ""requires"": {{
        ""babel-helper-explode-assignable-expression"": ""6.24.1"",
        ""babel-runtime"": ""6.26.0"",
        ""babel-types"": ""6.26.0""
      }}
    }},
    ""babel-helper-builder-react-jsx"": {{
      ""version"": ""6.26.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-helper-builder-react-jsx/-/babel-helper-builder-react-jsx-6.26.0.tgz"",
      ""integrity"": ""sha1-Of+DE7dci2Xc7/HzHTg+D/KkCKA="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0"",
        ""babel-types"": ""6.26.0"",
        ""esutils"": ""2.0.2""
      }}
    }},
    ""babel-helper-call-delegate"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-helper-call-delegate/-/babel-helper-call-delegate-6.24.1.tgz"",
      ""integrity"": ""sha1-7Oaqzdx25Bw0YfiL/Fdb0Nqi340="",
      ""dev"": true,
      ""requires"": {{
        ""babel-helper-hoist-variables"": ""6.24.1"",
        ""babel-runtime"": ""6.26.0"",
        ""babel-traverse"": ""6.26.0"",
        ""babel-types"": ""6.26.0""
      }}
    }},
    ""babel-helper-define-map"": {{
      ""version"": ""6.26.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-helper-define-map/-/babel-helper-define-map-6.26.0.tgz"",
      ""integrity"": ""sha1-pfVtq0GiX5fstJjH66ypgZ+Vvl8="",
      ""dev"": true,
      ""requires"": {{
        ""babel-helper-function-name"": ""6.24.1"",
        ""babel-runtime"": ""6.26.0"",
        ""babel-types"": ""6.26.0"",
        ""lodash"": ""4.17.4""
      }}
    }},
    ""babel-helper-explode-assignable-expression"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-helper-explode-assignable-expression/-/babel-helper-explode-assignable-expression-6.24.1.tgz"",
      ""integrity"": ""sha1-8luCz33BBDPFX3BZLVdGQArCLKo="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0"",
        ""babel-traverse"": ""6.26.0"",
        ""babel-types"": ""6.26.0""
      }}
    }},
    ""babel-helper-explode-class"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-helper-explode-class/-/babel-helper-explode-class-6.24.1.tgz"",
      ""integrity"": ""sha1-fcKjkQ3uAHBW4eMdZAztPVTqqes="",
      ""dev"": true,
      ""requires"": {{
        ""babel-helper-bindify-decorators"": ""6.24.1"",
        ""babel-runtime"": ""6.26.0"",
        ""babel-traverse"": ""6.26.0"",
        ""babel-types"": ""6.26.0""
      }}
    }},
    ""babel-helper-function-name"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-helper-function-name/-/babel-helper-function-name-6.24.1.tgz"",
      ""integrity"": ""sha1-00dbjAPtmCQqJbSDUasYOZ01gKk="",
      ""dev"": true,
      ""requires"": {{
        ""babel-helper-get-function-arity"": ""6.24.1"",
        ""babel-runtime"": ""6.26.0"",
        ""babel-template"": ""6.26.0"",
        ""babel-traverse"": ""6.26.0"",
        ""babel-types"": ""6.26.0""
      }}
    }},
    ""babel-helper-get-function-arity"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-helper-get-function-arity/-/babel-helper-get-function-arity-6.24.1.tgz"",
      ""integrity"": ""sha1-j3eCqpNAfEHTqlCQj4mwMbG2hT0="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0"",
        ""babel-types"": ""6.26.0""
      }}
    }},
    ""babel-helper-hoist-variables"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-helper-hoist-variables/-/babel-helper-hoist-variables-6.24.1.tgz"",
      ""integrity"": ""sha1-HssnaJydJVE+rbyZFKc/VAi+enY="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0"",
        ""babel-types"": ""6.26.0""
      }}
    }},
    ""babel-helper-optimise-call-expression"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-helper-optimise-call-expression/-/babel-helper-optimise-call-expression-6.24.1.tgz"",
      ""integrity"": ""sha1-96E0J7qfc/j0+pk8VKl4gtEkQlc="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0"",
        ""babel-types"": ""6.26.0""
      }}
    }},
    ""babel-helper-regex"": {{
      ""version"": ""6.26.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-helper-regex/-/babel-helper-regex-6.26.0.tgz"",
      ""integrity"": ""sha1-MlxZ+QL4LyS3T6zu0DY5VPZJXnI="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0"",
        ""babel-types"": ""6.26.0"",
        ""lodash"": ""4.17.4""
      }}
    }},
    ""babel-helper-remap-async-to-generator"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-helper-remap-async-to-generator/-/babel-helper-remap-async-to-generator-6.24.1.tgz"",
      ""integrity"": ""sha1-XsWBgnrXI/7N04HxySg5BnbkVRs="",
      ""dev"": true,
      ""requires"": {{
        ""babel-helper-function-name"": ""6.24.1"",
        ""babel-runtime"": ""6.26.0"",
        ""babel-template"": ""6.26.0"",
        ""babel-traverse"": ""6.26.0"",
        ""babel-types"": ""6.26.0""
      }}
    }},
    ""babel-helper-replace-supers"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-helper-replace-supers/-/babel-helper-replace-supers-6.24.1.tgz"",
      ""integrity"": ""sha1-v22/5Dk40XNpohPKiov3S2qQqxo="",
      ""dev"": true,
      ""requires"": {{
        ""babel-helper-optimise-call-expression"": ""6.24.1"",
        ""babel-messages"": ""6.23.0"",
        ""babel-runtime"": ""6.26.0"",
        ""babel-template"": ""6.26.0"",
        ""babel-traverse"": ""6.26.0"",
        ""babel-types"": ""6.26.0""
      }}
    }},
    ""babel-helpers"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-helpers/-/babel-helpers-6.24.1.tgz"",
      ""integrity"": ""sha1-NHHenK7DiOXIUOWX5Yom3fN2ArI="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0"",
        ""babel-template"": ""6.26.0""
      }}
    }},
    ""babel-jest"": {{
      ""version"": ""21.2.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-jest/-/babel-jest-21.2.0.tgz"",
      ""integrity"": ""sha512-O0W2qLoWu1QOoOGgxiR2JID4O6WSpxPiQanrkyi9SSlM0PJ60Ptzlck47lhtnr9YZO3zYOsxHwnyeWJ6AffoBQ=="",
      ""dev"": true,
      ""requires"": {{
        ""babel-plugin-istanbul"": ""4.1.5"",
        ""babel-preset-jest"": ""21.2.0""
      }}
    }},
    ""babel-loader"": {{
      ""version"": ""6.4.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-loader/-/babel-loader-6.4.1.tgz"",
      ""integrity"": ""sha1-CzQRLVsHSKjc2/Uaz2+b1C1QuMo="",
      ""dev"": true,
      ""requires"": {{
        ""find-cache-dir"": ""0.1.1"",
        ""loader-utils"": ""0.2.17"",
        ""mkdirp"": ""0.5.1"",
        ""object-assign"": ""4.1.1""
      }}
    }},
    ""babel-messages"": {{
      ""version"": ""6.23.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-messages/-/babel-messages-6.23.0.tgz"",
      ""integrity"": ""sha1-8830cDhYA1sqKVHG7F7fbGLyYw4="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0""
      }}
    }},
    ""babel-plugin-check-es2015-constants"": {{
      ""version"": ""6.22.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-check-es2015-constants/-/babel-plugin-check-es2015-constants-6.22.0.tgz"",
      ""integrity"": ""sha1-NRV7EBQm/S/9PaP3XH0ekYNbv4o="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0""
      }}
    }},
    ""babel-plugin-istanbul"": {{
      ""version"": ""4.1.5"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-istanbul/-/babel-plugin-istanbul-4.1.5.tgz"",
      ""integrity"": ""sha1-Z2DN2Xf0EdPhdbsGTyvDJ9mbK24="",
      ""dev"": true,
      ""requires"": {{
        ""find-up"": ""2.1.0"",
        ""istanbul-lib-instrument"": ""1.9.1"",
        ""test-exclude"": ""4.1.1""
      }},
      ""dependencies"": {{
        ""find-up"": {{
          ""version"": ""2.1.0"",
          ""resolved"": ""https://registry.npmjs.org/find-up/-/find-up-2.1.0.tgz"",
          ""integrity"": ""sha1-RdG35QbHF93UgndaK3eSCjwMV6c="",
          ""dev"": true,
          ""requires"": {{
            ""locate-path"": ""2.0.0""
          }}
        }}
      }}
    }},
    ""babel-plugin-jest-hoist"": {{
      ""version"": ""21.2.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-jest-hoist/-/babel-plugin-jest-hoist-21.2.0.tgz"",
      ""integrity"": ""sha512-yi5QuiVyyvhBUDLP4ButAnhYzkdrUwWDtvUJv71hjH3fclhnZg4HkDeqaitcR2dZZx/E67kGkRcPVjtVu+SJfQ=="",
      ""dev"": true
    }},
    ""babel-plugin-react-transform"": {{
      ""version"": ""2.0.2"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-react-transform/-/babel-plugin-react-transform-2.0.2.tgz"",
      ""integrity"": ""sha1-UVu/qZaJOYEULZCx+bFjXeKZUQk="",
      ""dev"": true,
      ""requires"": {{
        ""lodash"": ""4.17.4""
      }}
    }},
    ""babel-plugin-syntax-async-functions"": {{
      ""version"": ""6.13.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-syntax-async-functions/-/babel-plugin-syntax-async-functions-6.13.0.tgz"",
      ""integrity"": ""sha1-ytnK0RkbWtY0vzCuCHI5HgZHvpU="",
      ""dev"": true
    }},
    ""babel-plugin-syntax-async-generators"": {{
      ""version"": ""6.13.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-syntax-async-generators/-/babel-plugin-syntax-async-generators-6.13.0.tgz"",
      ""integrity"": ""sha1-a8lj67FuzLrmuStZbrfzXDQqi5o="",
      ""dev"": true
    }},
    ""babel-plugin-syntax-class-constructor-call"": {{
      ""version"": ""6.18.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-syntax-class-constructor-call/-/babel-plugin-syntax-class-constructor-call-6.18.0.tgz"",
      ""integrity"": ""sha1-nLnTn+Q8hgC+yBRkVt3L1OGnZBY="",
      ""dev"": true
    }},
    ""babel-plugin-syntax-class-properties"": {{
      ""version"": ""6.13.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-syntax-class-properties/-/babel-plugin-syntax-class-properties-6.13.0.tgz"",
      ""integrity"": ""sha1-1+sjt5oxf4VDlixQW4J8fWysJ94="",
      ""dev"": true
    }},
    ""babel-plugin-syntax-decorators"": {{
      ""version"": ""6.13.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-syntax-decorators/-/babel-plugin-syntax-decorators-6.13.0.tgz"",
      ""integrity"": ""sha1-MSVjtNvePMgGzuPkFszurd0RrAs="",
      ""dev"": true
    }},
    ""babel-plugin-syntax-dynamic-import"": {{
      ""version"": ""6.18.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-syntax-dynamic-import/-/babel-plugin-syntax-dynamic-import-6.18.0.tgz"",
      ""integrity"": ""sha1-jWomIpyDdFqZgqRBBRVyyqF5sdo="",
      ""dev"": true
    }},
    ""babel-plugin-syntax-exponentiation-operator"": {{
      ""version"": ""6.13.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-syntax-exponentiation-operator/-/babel-plugin-syntax-exponentiation-operator-6.13.0.tgz"",
      ""integrity"": ""sha1-nufoM3KQ2pUoggGmpX9BcDF4MN4="",
      ""dev"": true
    }},
    ""babel-plugin-syntax-export-extensions"": {{
      ""version"": ""6.13.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-syntax-export-extensions/-/babel-plugin-syntax-export-extensions-6.13.0.tgz"",
      ""integrity"": ""sha1-cKFITw+QiaToStRLrDU8lbmxJyE="",
      ""dev"": true
    }},
    ""babel-plugin-syntax-flow"": {{
      ""version"": ""6.18.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-syntax-flow/-/babel-plugin-syntax-flow-6.18.0.tgz"",
      ""integrity"": ""sha1-TDqyCiryaqIM0lmVw5jE63AxDI0="",
      ""dev"": true
    }},
    ""babel-plugin-syntax-jsx"": {{
      ""version"": ""6.18.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-syntax-jsx/-/babel-plugin-syntax-jsx-6.18.0.tgz"",
      ""integrity"": ""sha1-CvMqmm4Tyno/1QaeYtew9Y0NiUY="",
      ""dev"": true
    }},
    ""babel-plugin-syntax-object-rest-spread"": {{
      ""version"": ""6.13.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-syntax-object-rest-spread/-/babel-plugin-syntax-object-rest-spread-6.13.0.tgz"",
      ""integrity"": ""sha1-/WU28rzhODb/o6VFjEkDpZe7O/U="",
      ""dev"": true
    }},
    ""babel-plugin-syntax-trailing-function-commas"": {{
      ""version"": ""6.22.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-syntax-trailing-function-commas/-/babel-plugin-syntax-trailing-function-commas-6.22.0.tgz"",
      ""integrity"": ""sha1-ugNgk3+NBuQBgKQ/4NVhb/9TLPM="",
      ""dev"": true
    }},
    ""babel-plugin-transform-async-generator-functions"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-async-generator-functions/-/babel-plugin-transform-async-generator-functions-6.24.1.tgz"",
      ""integrity"": ""sha1-8FiQAUX9PpkHpt3yjaWfIVJYpds="",
      ""dev"": true,
      ""requires"": {{
        ""babel-helper-remap-async-to-generator"": ""6.24.1"",
        ""babel-plugin-syntax-async-generators"": ""6.13.0"",
        ""babel-runtime"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-async-to-generator"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-async-to-generator/-/babel-plugin-transform-async-to-generator-6.24.1.tgz"",
      ""integrity"": ""sha1-ZTbjeK/2yx1VF6wOQOs+n8jQh2E="",
      ""dev"": true,
      ""requires"": {{
        ""babel-helper-remap-async-to-generator"": ""6.24.1"",
        ""babel-plugin-syntax-async-functions"": ""6.13.0"",
        ""babel-runtime"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-class-constructor-call"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-class-constructor-call/-/babel-plugin-transform-class-constructor-call-6.24.1.tgz"",
      ""integrity"": ""sha1-gNwoVQWsBn3LjWxl4vbxGrd2Xvk="",
      ""dev"": true,
      ""requires"": {{
        ""babel-plugin-syntax-class-constructor-call"": ""6.18.0"",
        ""babel-runtime"": ""6.26.0"",
        ""babel-template"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-class-properties"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-class-properties/-/babel-plugin-transform-class-properties-6.24.1.tgz"",
      ""integrity"": ""sha1-anl2PqYdM9NvN7YRqp3vgagbRqw="",
      ""dev"": true,
      ""requires"": {{
        ""babel-helper-function-name"": ""6.24.1"",
        ""babel-plugin-syntax-class-properties"": ""6.13.0"",
        ""babel-runtime"": ""6.26.0"",
        ""babel-template"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-decorators"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-decorators/-/babel-plugin-transform-decorators-6.24.1.tgz"",
      ""integrity"": ""sha1-eIAT2PjGtSIr33s0Q5Df13Vp4k0="",
      ""dev"": true,
      ""requires"": {{
        ""babel-helper-explode-class"": ""6.24.1"",
        ""babel-plugin-syntax-decorators"": ""6.13.0"",
        ""babel-runtime"": ""6.26.0"",
        ""babel-template"": ""6.26.0"",
        ""babel-types"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-decorators-legacy"": {{
      ""version"": ""1.3.4"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-decorators-legacy/-/babel-plugin-transform-decorators-legacy-1.3.4.tgz"",
      ""integrity"": ""sha1-dBtY9sW86eYCfgiC2cmU8E82aSU="",
      ""dev"": true,
      ""requires"": {{
        ""babel-plugin-syntax-decorators"": ""6.13.0"",
        ""babel-runtime"": ""6.26.0"",
        ""babel-template"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-es2015-arrow-functions"": {{
      ""version"": ""6.22.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-es2015-arrow-functions/-/babel-plugin-transform-es2015-arrow-functions-6.22.0.tgz"",
      ""integrity"": ""sha1-RSaSy3EdX3ncf4XkQM5BufJE0iE="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-es2015-block-scoped-functions"": {{
      ""version"": ""6.22.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-es2015-block-scoped-functions/-/babel-plugin-transform-es2015-block-scoped-functions-6.22.0.tgz"",
      ""integrity"": ""sha1-u8UbSflk1wy42OC5ToICRs46YUE="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-es2015-block-scoping"": {{
      ""version"": ""6.26.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-es2015-block-scoping/-/babel-plugin-transform-es2015-block-scoping-6.26.0.tgz"",
      ""integrity"": ""sha1-1w9SmcEwjQXBL0Y4E7CgnnOxiV8="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0"",
        ""babel-template"": ""6.26.0"",
        ""babel-traverse"": ""6.26.0"",
        ""babel-types"": ""6.26.0"",
        ""lodash"": ""4.17.4""
      }}
    }},
    ""babel-plugin-transform-es2015-classes"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-es2015-classes/-/babel-plugin-transform-es2015-classes-6.24.1.tgz"",
      ""integrity"": ""sha1-WkxYpQyclGHlZLSyo7+ryXolhNs="",
      ""dev"": true,
      ""requires"": {{
        ""babel-helper-define-map"": ""6.26.0"",
        ""babel-helper-function-name"": ""6.24.1"",
        ""babel-helper-optimise-call-expression"": ""6.24.1"",
        ""babel-helper-replace-supers"": ""6.24.1"",
        ""babel-messages"": ""6.23.0"",
        ""babel-runtime"": ""6.26.0"",
        ""babel-template"": ""6.26.0"",
        ""babel-traverse"": ""6.26.0"",
        ""babel-types"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-es2015-computed-properties"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-es2015-computed-properties/-/babel-plugin-transform-es2015-computed-properties-6.24.1.tgz"",
      ""integrity"": ""sha1-b+Ko0WiV1WNPTNmZttNICjCBWbM="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0"",
        ""babel-template"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-es2015-destructuring"": {{
      ""version"": ""6.23.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-es2015-destructuring/-/babel-plugin-transform-es2015-destructuring-6.23.0.tgz"",
      ""integrity"": ""sha1-mXux8auWf2gtKwh2/jWNYOdlxW0="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-es2015-duplicate-keys"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-es2015-duplicate-keys/-/babel-plugin-transform-es2015-duplicate-keys-6.24.1.tgz"",
      ""integrity"": ""sha1-c+s9MQypaePvnskcU3QabxV2Qj4="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0"",
        ""babel-types"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-es2015-for-of"": {{
      ""version"": ""6.23.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-es2015-for-of/-/babel-plugin-transform-es2015-for-of-6.23.0.tgz"",
      ""integrity"": ""sha1-9HyVsrYT3x0+zC/bdXNiPHUkhpE="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-es2015-function-name"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-es2015-function-name/-/babel-plugin-transform-es2015-function-name-6.24.1.tgz"",
      ""integrity"": ""sha1-g0yJhTvDaxrw86TF26qU/Y6sqos="",
      ""dev"": true,
      ""requires"": {{
        ""babel-helper-function-name"": ""6.24.1"",
        ""babel-runtime"": ""6.26.0"",
        ""babel-types"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-es2015-literals"": {{
      ""version"": ""6.22.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-es2015-literals/-/babel-plugin-transform-es2015-literals-6.22.0.tgz"",
      ""integrity"": ""sha1-T1SgLWzWbPkVKAAZox0xklN3yi4="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-es2015-modules-amd"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-es2015-modules-amd/-/babel-plugin-transform-es2015-modules-amd-6.24.1.tgz"",
      ""integrity"": ""sha1-Oz5UAXI5hC1tGcMBHEvS8AoA0VQ="",
      ""dev"": true,
      ""requires"": {{
        ""babel-plugin-transform-es2015-modules-commonjs"": ""6.26.0"",
        ""babel-runtime"": ""6.26.0"",
        ""babel-template"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-es2015-modules-commonjs"": {{
      ""version"": ""6.26.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-es2015-modules-commonjs/-/babel-plugin-transform-es2015-modules-commonjs-6.26.0.tgz"",
      ""integrity"": ""sha1-DYOUApt9xqvhqX7xgeAHWN0uXYo="",
      ""dev"": true,
      ""requires"": {{
        ""babel-plugin-transform-strict-mode"": ""6.24.1"",
        ""babel-runtime"": ""6.26.0"",
        ""babel-template"": ""6.26.0"",
        ""babel-types"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-es2015-modules-systemjs"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-es2015-modules-systemjs/-/babel-plugin-transform-es2015-modules-systemjs-6.24.1.tgz"",
      ""integrity"": ""sha1-/4mhQrkRmpBhlfXxBuzzBdlAfSM="",
      ""dev"": true,
      ""requires"": {{
        ""babel-helper-hoist-variables"": ""6.24.1"",
        ""babel-runtime"": ""6.26.0"",
        ""babel-template"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-es2015-modules-umd"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-es2015-modules-umd/-/babel-plugin-transform-es2015-modules-umd-6.24.1.tgz"",
      ""integrity"": ""sha1-rJl+YoXNGO1hdq22B9YCNErThGg="",
      ""dev"": true,
      ""requires"": {{
        ""babel-plugin-transform-es2015-modules-amd"": ""6.24.1"",
        ""babel-runtime"": ""6.26.0"",
        ""babel-template"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-es2015-object-super"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-es2015-object-super/-/babel-plugin-transform-es2015-object-super-6.24.1.tgz"",
      ""integrity"": ""sha1-JM72muIcuDp/hgPa0CH1cusnj40="",
      ""dev"": true,
      ""requires"": {{
        ""babel-helper-replace-supers"": ""6.24.1"",
        ""babel-runtime"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-es2015-parameters"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-es2015-parameters/-/babel-plugin-transform-es2015-parameters-6.24.1.tgz"",
      ""integrity"": ""sha1-V6w1GrScrxSpfNE7CfZv3wpiXys="",
      ""dev"": true,
      ""requires"": {{
        ""babel-helper-call-delegate"": ""6.24.1"",
        ""babel-helper-get-function-arity"": ""6.24.1"",
        ""babel-runtime"": ""6.26.0"",
        ""babel-template"": ""6.26.0"",
        ""babel-traverse"": ""6.26.0"",
        ""babel-types"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-es2015-shorthand-properties"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-es2015-shorthand-properties/-/babel-plugin-transform-es2015-shorthand-properties-6.24.1.tgz"",
      ""integrity"": ""sha1-JPh11nIch2YbvZmkYi5R8U3jiqA="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0"",
        ""babel-types"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-es2015-spread"": {{
      ""version"": ""6.22.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-es2015-spread/-/babel-plugin-transform-es2015-spread-6.22.0.tgz"",
      ""integrity"": ""sha1-1taKmfia7cRTbIGlQujdnxdG+NE="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-es2015-sticky-regex"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-es2015-sticky-regex/-/babel-plugin-transform-es2015-sticky-regex-6.24.1.tgz"",
      ""integrity"": ""sha1-AMHNsaynERLN8M9hJsLta0V8zbw="",
      ""dev"": true,
      ""requires"": {{
        ""babel-helper-regex"": ""6.26.0"",
        ""babel-runtime"": ""6.26.0"",
        ""babel-types"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-es2015-template-literals"": {{
      ""version"": ""6.22.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-es2015-template-literals/-/babel-plugin-transform-es2015-template-literals-6.22.0.tgz"",
      ""integrity"": ""sha1-qEs0UPfp+PH2g51taH2oS7EjbY0="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-es2015-typeof-symbol"": {{
      ""version"": ""6.23.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-es2015-typeof-symbol/-/babel-plugin-transform-es2015-typeof-symbol-6.23.0.tgz"",
      ""integrity"": ""sha1-3sCfHN3/lLUqxz1QXITfWdzOs3I="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-es2015-unicode-regex"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-es2015-unicode-regex/-/babel-plugin-transform-es2015-unicode-regex-6.24.1.tgz"",
      ""integrity"": ""sha1-04sS9C6nMj9yk4fxinxa4frrNek="",
      ""dev"": true,
      ""requires"": {{
        ""babel-helper-regex"": ""6.26.0"",
        ""babel-runtime"": ""6.26.0"",
        ""regexpu-core"": ""2.0.0""
      }}
    }},
    ""babel-plugin-transform-exponentiation-operator"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-exponentiation-operator/-/babel-plugin-transform-exponentiation-operator-6.24.1.tgz"",
      ""integrity"": ""sha1-KrDJx/MJj6SJB3cruBP+QejeOg4="",
      ""dev"": true,
      ""requires"": {{
        ""babel-helper-builder-binary-assignment-operator-visitor"": ""6.24.1"",
        ""babel-plugin-syntax-exponentiation-operator"": ""6.13.0"",
        ""babel-runtime"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-export-extensions"": {{
      ""version"": ""6.22.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-export-extensions/-/babel-plugin-transform-export-extensions-6.22.0.tgz"",
      ""integrity"": ""sha1-U3OLR+deghhYnuqUbLvTkQm75lM="",
      ""dev"": true,
      ""requires"": {{
        ""babel-plugin-syntax-export-extensions"": ""6.13.0"",
        ""babel-runtime"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-flow-strip-types"": {{
      ""version"": ""6.22.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-flow-strip-types/-/babel-plugin-transform-flow-strip-types-6.22.0.tgz"",
      ""integrity"": ""sha1-hMtnKTXUNxT9wyvOhFaNh0Qc988="",
      ""dev"": true,
      ""requires"": {{
        ""babel-plugin-syntax-flow"": ""6.18.0"",
        ""babel-runtime"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-object-rest-spread"": {{
      ""version"": ""6.26.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-object-rest-spread/-/babel-plugin-transform-object-rest-spread-6.26.0.tgz"",
      ""integrity"": ""sha1-DzZpLVD+9rfi1LOsFHgTepY7ewY="",
      ""dev"": true,
      ""requires"": {{
        ""babel-plugin-syntax-object-rest-spread"": ""6.13.0"",
        ""babel-runtime"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-react-display-name"": {{
      ""version"": ""6.25.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-react-display-name/-/babel-plugin-transform-react-display-name-6.25.0.tgz"",
      ""integrity"": ""sha1-Z+K/Hx6ck6sI25Z5LgU5K/LMKNE="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-react-jsx"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-react-jsx/-/babel-plugin-transform-react-jsx-6.24.1.tgz"",
      ""integrity"": ""sha1-hAoCjn30YN/DotKfDA2R9jduZqM="",
      ""dev"": true,
      ""requires"": {{
        ""babel-helper-builder-react-jsx"": ""6.26.0"",
        ""babel-plugin-syntax-jsx"": ""6.18.0"",
        ""babel-runtime"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-react-jsx-self"": {{
      ""version"": ""6.22.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-react-jsx-self/-/babel-plugin-transform-react-jsx-self-6.22.0.tgz"",
      ""integrity"": ""sha1-322AqdomEqEh5t3XVYvL7PBuY24="",
      ""dev"": true,
      ""requires"": {{
        ""babel-plugin-syntax-jsx"": ""6.18.0"",
        ""babel-runtime"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-react-jsx-source"": {{
      ""version"": ""6.22.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-react-jsx-source/-/babel-plugin-transform-react-jsx-source-6.22.0.tgz"",
      ""integrity"": ""sha1-ZqwSFT9c0tF7PBkmj0vwGX9E7NY="",
      ""dev"": true,
      ""requires"": {{
        ""babel-plugin-syntax-jsx"": ""6.18.0"",
        ""babel-runtime"": ""6.26.0""
      }}
    }},
    ""babel-plugin-transform-regenerator"": {{
      ""version"": ""6.26.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-regenerator/-/babel-plugin-transform-regenerator-6.26.0.tgz"",
      ""integrity"": ""sha1-4HA2lvveJ/Cj78rPi03KL3s6jy8="",
      ""dev"": true,
      ""requires"": {{
        ""regenerator-transform"": ""0.10.1""
      }}
    }},
    ""babel-plugin-transform-strict-mode"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-plugin-transform-strict-mode/-/babel-plugin-transform-strict-mode-6.24.1.tgz"",
      ""integrity"": ""sha1-1fr3qleKZbvlkc9e2uBKDGcCB1g="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0"",
        ""babel-types"": ""6.26.0""
      }}
    }},
    ""babel-polyfill"": {{
      ""version"": ""6.26.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-polyfill/-/babel-polyfill-6.26.0.tgz"",
      ""integrity"": ""sha1-N5k3q8Z9eJWXCtxiHyhM2WbPIVM="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0"",
        ""core-js"": ""2.5.3"",
        ""regenerator-runtime"": ""0.10.5""
      }},
      ""dependencies"": {{
        ""core-js"": {{
          ""version"": ""2.5.3"",
          ""resolved"": ""https://registry.npmjs.org/core-js/-/core-js-2.5.3.tgz"",
          ""integrity"": ""sha1-isw4NFgk8W2DZbfJtCWRaOjtYD4="",
          ""dev"": true
        }},
        ""regenerator-runtime"": {{
          ""version"": ""0.10.5"",
          ""resolved"": ""https://registry.npmjs.org/regenerator-runtime/-/regenerator-runtime-0.10.5.tgz"",
          ""integrity"": ""sha1-M2w+/BIgrc7dosn6tntaeVWjNlg="",
          ""dev"": true
        }}
      }}
    }},
    ""babel-preset-es2015"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-preset-es2015/-/babel-preset-es2015-6.24.1.tgz"",
      ""integrity"": ""sha1-1EBQ1rwsn+6nAqrzjXJ6AhBTiTk="",
      ""dev"": true,
      ""requires"": {{
        ""babel-plugin-check-es2015-constants"": ""6.22.0"",
        ""babel-plugin-transform-es2015-arrow-functions"": ""6.22.0"",
        ""babel-plugin-transform-es2015-block-scoped-functions"": ""6.22.0"",
        ""babel-plugin-transform-es2015-block-scoping"": ""6.26.0"",
        ""babel-plugin-transform-es2015-classes"": ""6.24.1"",
        ""babel-plugin-transform-es2015-computed-properties"": ""6.24.1"",
        ""babel-plugin-transform-es2015-destructuring"": ""6.23.0"",
        ""babel-plugin-transform-es2015-duplicate-keys"": ""6.24.1"",
        ""babel-plugin-transform-es2015-for-of"": ""6.23.0"",
        ""babel-plugin-transform-es2015-function-name"": ""6.24.1"",
        ""babel-plugin-transform-es2015-literals"": ""6.22.0"",
        ""babel-plugin-transform-es2015-modules-amd"": ""6.24.1"",
        ""babel-plugin-transform-es2015-modules-commonjs"": ""6.26.0"",
        ""babel-plugin-transform-es2015-modules-systemjs"": ""6.24.1"",
        ""babel-plugin-transform-es2015-modules-umd"": ""6.24.1"",
        ""babel-plugin-transform-es2015-object-super"": ""6.24.1"",
        ""babel-plugin-transform-es2015-parameters"": ""6.24.1"",
        ""babel-plugin-transform-es2015-shorthand-properties"": ""6.24.1"",
        ""babel-plugin-transform-es2015-spread"": ""6.22.0"",
        ""babel-plugin-transform-es2015-sticky-regex"": ""6.24.1"",
        ""babel-plugin-transform-es2015-template-literals"": ""6.22.0"",
        ""babel-plugin-transform-es2015-typeof-symbol"": ""6.23.0"",
        ""babel-plugin-transform-es2015-unicode-regex"": ""6.24.1"",
        ""babel-plugin-transform-regenerator"": ""6.26.0""
      }}
    }},
    ""babel-preset-flow"": {{
      ""version"": ""6.23.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-preset-flow/-/babel-preset-flow-6.23.0.tgz"",
      ""integrity"": ""sha1-5xIYiHCFrpoktb5Baa/7WZgWxJ0="",
      ""dev"": true,
      ""requires"": {{
        ""babel-plugin-transform-flow-strip-types"": ""6.22.0""
      }}
    }},
    ""babel-preset-jest"": {{
      ""version"": ""21.2.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-preset-jest/-/babel-preset-jest-21.2.0.tgz"",
      ""integrity"": ""sha512-hm9cBnr2h3J7yXoTtAVV0zg+3vg0Q/gT2GYuzlreTU0EPkJRtlNgKJJ3tBKEn0+VjAi3JykV6xCJkuUYttEEfA=="",
      ""dev"": true,
      ""requires"": {{
        ""babel-plugin-jest-hoist"": ""21.2.0"",
        ""babel-plugin-syntax-object-rest-spread"": ""6.13.0""
      }}
    }},
    ""babel-preset-react"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-preset-react/-/babel-preset-react-6.24.1.tgz"",
      ""integrity"": ""sha1-umnfrqRfw+xjm2pOzqbhdwLJE4A="",
      ""dev"": true,
      ""requires"": {{
        ""babel-plugin-syntax-jsx"": ""6.18.0"",
        ""babel-plugin-transform-react-display-name"": ""6.25.0"",
        ""babel-plugin-transform-react-jsx"": ""6.24.1"",
        ""babel-plugin-transform-react-jsx-self"": ""6.22.0"",
        ""babel-plugin-transform-react-jsx-source"": ""6.22.0"",
        ""babel-preset-flow"": ""6.23.0""
      }}
    }},
    ""babel-preset-react-hmre"": {{
      ""version"": ""1.1.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-preset-react-hmre/-/babel-preset-react-hmre-1.1.1.tgz"",
      ""integrity"": ""sha1-0hbmDLW41Mhz4Z7Q9U6v8UN7xJI="",
      ""dev"": true,
      ""requires"": {{
        ""babel-plugin-react-transform"": ""2.0.2"",
        ""react-transform-catch-errors"": ""1.0.2"",
        ""react-transform-hmr"": ""1.0.4"",
        ""redbox-react"": ""1.5.0""
      }}
    }},
    ""babel-preset-stage-1"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-preset-stage-1/-/babel-preset-stage-1-6.24.1.tgz"",
      ""integrity"": ""sha1-dpLNfc1oSZB+auSgqFWJz7niv7A="",
      ""dev"": true,
      ""requires"": {{
        ""babel-plugin-transform-class-constructor-call"": ""6.24.1"",
        ""babel-plugin-transform-export-extensions"": ""6.22.0"",
        ""babel-preset-stage-2"": ""6.24.1""
      }}
    }},
    ""babel-preset-stage-2"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-preset-stage-2/-/babel-preset-stage-2-6.24.1.tgz"",
      ""integrity"": ""sha1-2eKWD7PXEYfw5k7sYrwHdnIZvcE="",
      ""dev"": true,
      ""requires"": {{
        ""babel-plugin-syntax-dynamic-import"": ""6.18.0"",
        ""babel-plugin-transform-class-properties"": ""6.24.1"",
        ""babel-plugin-transform-decorators"": ""6.24.1"",
        ""babel-preset-stage-3"": ""6.24.1""
      }}
    }},
    ""babel-preset-stage-3"": {{
      ""version"": ""6.24.1"",
      ""resolved"": ""https://registry.npmjs.org/babel-preset-stage-3/-/babel-preset-stage-3-6.24.1.tgz"",
      ""integrity"": ""sha1-g2raCp56f6N8sTj7kyb4eTSkg5U="",
      ""dev"": true,
      ""requires"": {{
        ""babel-plugin-syntax-trailing-function-commas"": ""6.22.0"",
        ""babel-plugin-transform-async-generator-functions"": ""6.24.1"",
        ""babel-plugin-transform-async-to-generator"": ""6.24.1"",
        ""babel-plugin-transform-exponentiation-operator"": ""6.24.1"",
        ""babel-plugin-transform-object-rest-spread"": ""6.26.0""
      }}
    }},
    ""babel-register"": {{
      ""version"": ""6.26.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-register/-/babel-register-6.26.0.tgz"",
      ""integrity"": ""sha1-btAhFz4vy0htestFxgCahW9kcHE="",
      ""dev"": true,
      ""requires"": {{
        ""babel-core"": ""6.26.0"",
        ""babel-runtime"": ""6.26.0"",
        ""core-js"": ""2.5.3"",
        ""home-or-tmp"": ""2.0.0"",
        ""lodash"": ""4.17.4"",
        ""mkdirp"": ""0.5.1"",
        ""source-map-support"": ""0.4.18""
      }},
      ""dependencies"": {{
        ""core-js"": {{
          ""version"": ""2.5.3"",
          ""resolved"": ""https://registry.npmjs.org/core-js/-/core-js-2.5.3.tgz"",
          ""integrity"": ""sha1-isw4NFgk8W2DZbfJtCWRaOjtYD4="",
          ""dev"": true
        }}
      }}
    }},
    ""babel-runtime"": {{
      ""version"": ""6.26.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-runtime/-/babel-runtime-6.26.0.tgz"",
      ""integrity"": ""sha1-llxwWGaOgrVde/4E/yM3vItWR/4="",
      ""requires"": {{
        ""core-js"": ""2.5.3"",
        ""regenerator-runtime"": ""0.11.1""
      }},
      ""dependencies"": {{
        ""core-js"": {{
          ""version"": ""2.5.3"",
          ""resolved"": ""https://registry.npmjs.org/core-js/-/core-js-2.5.3.tgz"",
          ""integrity"": ""sha1-isw4NFgk8W2DZbfJtCWRaOjtYD4=""
        }}
      }}
    }},
    ""babel-template"": {{
      ""version"": ""6.26.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-template/-/babel-template-6.26.0.tgz"",
      ""integrity"": ""sha1-3gPi0WOWsGn0bdn/+FIfsaDjXgI="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0"",
        ""babel-traverse"": ""6.26.0"",
        ""babel-types"": ""6.26.0"",
        ""babylon"": ""6.18.0"",
        ""lodash"": ""4.17.4""
      }}
    }},
    ""babel-traverse"": {{
      ""version"": ""6.26.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-traverse/-/babel-traverse-6.26.0.tgz"",
      ""integrity"": ""sha1-RqnL1+3MYsjlwGTi0tjQ9ANXZu4="",
      ""dev"": true,
      ""requires"": {{
        ""babel-code-frame"": ""6.26.0"",
        ""babel-messages"": ""6.23.0"",
        ""babel-runtime"": ""6.26.0"",
        ""babel-types"": ""6.26.0"",
        ""babylon"": ""6.18.0"",
        ""debug"": ""2.6.9"",
        ""globals"": ""9.18.0"",
        ""invariant"": ""2.2.2"",
        ""lodash"": ""4.17.4""
      }}
    }},
    ""babel-types"": {{
      ""version"": ""6.26.0"",
      ""resolved"": ""https://registry.npmjs.org/babel-types/-/babel-types-6.26.0.tgz"",
      ""integrity"": ""sha1-o7Bz+Uq0nrb6Vc1lInozQ4BjJJc="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0"",
        ""esutils"": ""2.0.2"",
        ""lodash"": ""4.17.4"",
        ""to-fast-properties"": ""1.0.3""
      }}
    }},
    ""babylon"": {{
      ""version"": ""6.18.0"",
      ""resolved"": ""https://registry.npmjs.org/babylon/-/babylon-6.18.0.tgz"",
      ""integrity"": ""sha512-q/UEjfGJ2Cm3oKV71DJz9d25TPnq5rhBVL2Q4fA5wcC3jcrdn7+SssEybFIxwAvvP+YCsCYNKughoF33GxgycQ=="",
      ""dev"": true
    }},
    ""balanced-match"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/balanced-match/-/balanced-match-1.0.0.tgz"",
      ""integrity"": ""sha1-ibTRmasr7kneFk6gK4nORi1xt2c="",
      ""dev"": true
    }},
    ""base64-js"": {{
      ""version"": ""1.2.1"",
      ""resolved"": ""https://registry.npmjs.org/base64-js/-/base64-js-1.2.1.tgz"",
      ""integrity"": ""sha512-dwVUVIXsBZXwTuwnXI9RK8sBmgq09NDHzyR9SAph9eqk76gKK2JSQmZARC2zRC81JC2QTtxD0ARU5qTS25gIGw=="",
      ""dev"": true
    }},
    ""basic-auth"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/basic-auth/-/basic-auth-2.0.0.tgz"",
      ""integrity"": ""sha1-AV2z81PgLlY3d1X5YnQuiYHnu7o="",
      ""dev"": true,
      ""requires"": {{
        ""safe-buffer"": ""5.1.1""
      }}
    }},
    ""batch"": {{
      ""version"": ""0.6.1"",
      ""resolved"": ""https://registry.npmjs.org/batch/-/batch-0.6.1.tgz"",
      ""integrity"": ""sha1-3DQxT05nkxgJP8dgJyUl+UvyXBY="",
      ""dev"": true
    }},
    ""bcrypt-pbkdf"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/bcrypt-pbkdf/-/bcrypt-pbkdf-1.0.1.tgz"",
      ""integrity"": ""sha1-Y7xdy2EzG5K8Bf1SiVPDNGKgb40="",
      ""dev"": true,
      ""optional"": true,
      ""requires"": {{
        ""tweetnacl"": ""0.14.5""
      }}
    }},
    ""big.js"": {{
      ""version"": ""3.2.0"",
      ""resolved"": ""https://registry.npmjs.org/big.js/-/big.js-3.2.0.tgz"",
      ""integrity"": ""sha512-+hN/Zh2D08Mx65pZ/4g5bsmNiZUuChDiQfTUQ7qJr4/kuopCr88xZsAXv6mBoZEsUI4OuGHlX59qE94K2mMW8Q=="",
      ""dev"": true
    }},
    ""binary-extensions"": {{
      ""version"": ""1.11.0"",
      ""resolved"": ""https://registry.npmjs.org/binary-extensions/-/binary-extensions-1.11.0.tgz"",
      ""integrity"": ""sha1-RqoXUftqL5PuXmibsQh9SxTGwgU="",
      ""dev"": true
    }},
    ""block-stream"": {{
      ""version"": ""0.0.9"",
      ""resolved"": ""https://registry.npmjs.org/block-stream/-/block-stream-0.0.9.tgz"",
      ""integrity"": ""sha1-E+v+d4oDIFz+A3UUgeu0szAMEmo="",
      ""dev"": true,
      ""requires"": {{
        ""inherits"": ""2.0.3""
      }}
    }},
    ""bluebird"": {{
      ""version"": ""2.11.0"",
      ""resolved"": ""https://registry.npmjs.org/bluebird/-/bluebird-2.11.0.tgz"",
      ""integrity"": ""sha1-U0uQM8AiyVecVro7Plpcqvu2UOE="",
      ""dev"": true
    }},
    ""bn.js"": {{
      ""version"": ""4.11.8"",
      ""resolved"": ""https://registry.npmjs.org/bn.js/-/bn.js-4.11.8.tgz"",
      ""integrity"": ""sha512-ItfYfPLkWHUjckQCk8xC+LwxgK8NYcXywGigJgSwOP8Y2iyWT4f2vsZnoOXTTbo+o5yXmIUJ4gn5538SO5S3gA=="",
      ""dev"": true
    }},
    ""body-parser"": {{
      ""version"": ""1.18.2"",
      ""resolved"": ""https://registry.npmjs.org/body-parser/-/body-parser-1.18.2.tgz"",
      ""integrity"": ""sha1-h2eKGdhLR9hZuDGZvVm84iKxBFQ="",
      ""dev"": true,
      ""requires"": {{
        ""bytes"": ""3.0.0"",
        ""content-type"": ""1.0.4"",
        ""debug"": ""2.6.9"",
        ""depd"": ""1.1.1"",
        ""http-errors"": ""1.6.2"",
        ""iconv-lite"": ""0.4.19"",
        ""on-finished"": ""2.3.0"",
        ""qs"": ""6.5.1"",
        ""raw-body"": ""2.3.2"",
        ""type-is"": ""1.6.15""
      }}
    }},
    ""boolbase"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/boolbase/-/boolbase-1.0.0.tgz"",
      ""integrity"": ""sha1-aN/1++YMUes3cl6p4+0xDcwed24="",
      ""dev"": true
    }},
    ""boom"": {{
      ""version"": ""4.3.1"",
      ""resolved"": ""https://registry.npmjs.org/boom/-/boom-4.3.1.tgz"",
      ""integrity"": ""sha1-T4owBctKfjiJ90kDD9JbluAdLjE="",
      ""dev"": true,
      ""requires"": {{
        ""hoek"": ""4.2.0""
      }}
    }},
    ""bowser"": {{
      ""version"": ""1.9.1"",
      ""resolved"": ""https://registry.npmjs.org/bowser/-/bowser-1.9.1.tgz"",
      ""integrity"": ""sha512-UXti1JB6oK8hO983AImunnV6j/fqAEeDlPXh99zhsP5g32oLbxJJ6qcOaUesR+tqqhnUVQHlRJyD0dfiV0Hxaw==""
    }},
    ""brace-expansion"": {{
      ""version"": ""1.1.8"",
      ""resolved"": ""https://registry.npmjs.org/brace-expansion/-/brace-expansion-1.1.8.tgz"",
      ""integrity"": ""sha1-wHshHHyVLsH479Uad+8NHTmQopI="",
      ""dev"": true,
      ""requires"": {{
        ""balanced-match"": ""1.0.0"",
        ""concat-map"": ""0.0.1""
      }}
    }},
    ""braces"": {{
      ""version"": ""1.8.5"",
      ""resolved"": ""https://registry.npmjs.org/braces/-/braces-1.8.5.tgz"",
      ""integrity"": ""sha1-uneWLhLf+WnWt2cR6RS3N4V79qc="",
      ""dev"": true,
      ""requires"": {{
        ""expand-range"": ""1.8.2"",
        ""preserve"": ""0.2.0"",
        ""repeat-element"": ""1.1.2""
      }}
    }},
    ""brorand"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/brorand/-/brorand-1.1.0.tgz"",
      ""integrity"": ""sha1-EsJe/kCkXjwyPrhnWgoM5XsiNx8="",
      ""dev"": true
    }},
    ""browser-resolve"": {{
      ""version"": ""1.11.2"",
      ""resolved"": ""https://registry.npmjs.org/browser-resolve/-/browser-resolve-1.11.2.tgz"",
      ""integrity"": ""sha1-j/CbCixCFxihBRwmCzLkj0QpOM4="",
      ""dev"": true,
      ""requires"": {{
        ""resolve"": ""1.1.7""
      }}
    }},
    ""browserify-aes"": {{
      ""version"": ""1.1.1"",
      ""resolved"": ""https://registry.npmjs.org/browserify-aes/-/browserify-aes-1.1.1.tgz"",
      ""integrity"": ""sha512-UGnTYAnB2a3YuYKIRy1/4FB2HdM866E0qC46JXvVTYKlBlZlnvfpSfY6OKfXZAkv70eJ2a1SqzpAo5CRhZGDFg=="",
      ""dev"": true,
      ""requires"": {{
        ""buffer-xor"": ""1.0.3"",
        ""cipher-base"": ""1.0.4"",
        ""create-hash"": ""1.1.3"",
        ""evp_bytestokey"": ""1.0.3"",
        ""inherits"": ""2.0.3"",
        ""safe-buffer"": ""5.1.1""
      }}
    }},
    ""browserify-cipher"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/browserify-cipher/-/browserify-cipher-1.0.0.tgz"",
      ""integrity"": ""sha1-mYgkSHS/XtTijalWZtzWasj8Njo="",
      ""dev"": true,
      ""requires"": {{
        ""browserify-aes"": ""1.1.1"",
        ""browserify-des"": ""1.0.0"",
        ""evp_bytestokey"": ""1.0.3""
      }}
    }},
    ""browserify-des"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/browserify-des/-/browserify-des-1.0.0.tgz"",
      ""integrity"": ""sha1-2qJ3cXRwki7S/hhZQRihdUOXId0="",
      ""dev"": true,
      ""requires"": {{
        ""cipher-base"": ""1.0.4"",
        ""des.js"": ""1.0.0"",
        ""inherits"": ""2.0.3""
      }}
    }},
    ""browserify-rsa"": {{
      ""version"": ""4.0.1"",
      ""resolved"": ""https://registry.npmjs.org/browserify-rsa/-/browserify-rsa-4.0.1.tgz"",
      ""integrity"": ""sha1-IeCr+vbyApzy+vsTNWenAdQTVSQ="",
      ""dev"": true,
      ""requires"": {{
        ""bn.js"": ""4.11.8"",
        ""randombytes"": ""2.0.5""
      }}
    }},
    ""browserify-sign"": {{
      ""version"": ""4.0.4"",
      ""resolved"": ""https://registry.npmjs.org/browserify-sign/-/browserify-sign-4.0.4.tgz"",
      ""integrity"": ""sha1-qk62jl17ZYuqa/alfmMMvXqT0pg="",
      ""dev"": true,
      ""requires"": {{
        ""bn.js"": ""4.11.8"",
        ""browserify-rsa"": ""4.0.1"",
        ""create-hash"": ""1.1.3"",
        ""create-hmac"": ""1.1.6"",
        ""elliptic"": ""6.4.0"",
        ""inherits"": ""2.0.3"",
        ""parse-asn1"": ""5.1.0""
      }}
    }},
    ""browserify-zlib"": {{
      ""version"": ""0.2.0"",
      ""resolved"": ""https://registry.npmjs.org/browserify-zlib/-/browserify-zlib-0.2.0.tgz"",
      ""integrity"": ""sha512-Z942RysHXmJrhqk88FmKBVq/v5tqmSkDz7p54G/MGyjMnCFFnC79XWNbg+Vta8W6Wb2qtSZTSxIGkJrRpCFEiA=="",
      ""dev"": true,
      ""requires"": {{
        ""pako"": ""1.0.6""
      }}
    }},
    ""browserslist"": {{
      ""version"": ""1.7.7"",
      ""resolved"": ""https://registry.npmjs.org/browserslist/-/browserslist-1.7.7.tgz"",
      ""integrity"": ""sha1-C9dnBCWL6CmyOYu1Dkti0aFmsLk="",
      ""dev"": true,
      ""requires"": {{
        ""caniuse-db"": ""1.0.30000787"",
        ""electron-to-chromium"": ""1.3.30""
      }}
    }},
    ""bser"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/bser/-/bser-2.0.0.tgz"",
      ""integrity"": ""sha1-mseNPtXZFYBP2HrLFYvHlxR6Fxk="",
      ""dev"": true,
      ""requires"": {{
        ""node-int64"": ""0.4.0""
      }}
    }},
    ""buffer"": {{
      ""version"": ""4.9.1"",
      ""resolved"": ""https://registry.npmjs.org/buffer/-/buffer-4.9.1.tgz"",
      ""integrity"": ""sha1-bRu2AbB6TvztlwlBMgkwJ8lbwpg="",
      ""dev"": true,
      ""requires"": {{
        ""base64-js"": ""1.2.1"",
        ""ieee754"": ""1.1.8"",
        ""isarray"": ""1.0.0""
      }},
      ""dependencies"": {{
        ""isarray"": {{
          ""version"": ""1.0.0"",
          ""resolved"": ""https://registry.npmjs.org/isarray/-/isarray-1.0.0.tgz"",
          ""integrity"": ""sha1-u5NdSFgsuhaMBoNJV6VKPgcSTxE="",
          ""dev"": true
        }}
      }}
    }},
    ""buffer-xor"": {{
      ""version"": ""1.0.3"",
      ""resolved"": ""https://registry.npmjs.org/buffer-xor/-/buffer-xor-1.0.3.tgz"",
      ""integrity"": ""sha1-JuYe0UIvtw3ULm42cp7VHYVf6Nk="",
      ""dev"": true
    }},
    ""builtin-modules"": {{
      ""version"": ""1.1.1"",
      ""resolved"": ""https://registry.npmjs.org/builtin-modules/-/builtin-modules-1.1.1.tgz"",
      ""integrity"": ""sha1-Jw8HbFpywC9bZaR9+Uxf46J4iS8="",
      ""dev"": true
    }},
    ""builtin-status-codes"": {{
      ""version"": ""3.0.0"",
      ""resolved"": ""https://registry.npmjs.org/builtin-status-codes/-/builtin-status-codes-3.0.0.tgz"",
      ""integrity"": ""sha1-hZgoeOIbmOHGZCXgPQF0eI9Wnug="",
      ""dev"": true
    }},
    ""bytes"": {{
      ""version"": ""3.0.0"",
      ""resolved"": ""https://registry.npmjs.org/bytes/-/bytes-3.0.0.tgz"",
      ""integrity"": ""sha1-0ygVQE1olpn4Wk6k+odV3ROpYEg="",
      ""dev"": true
    }},
    ""caller-path"": {{
      ""version"": ""0.1.0"",
      ""resolved"": ""https://registry.npmjs.org/caller-path/-/caller-path-0.1.0.tgz"",
      ""integrity"": ""sha1-lAhe9jWB7NPaqSREqP6U6CV3dR8="",
      ""dev"": true,
      ""requires"": {{
        ""callsites"": ""0.2.0""
      }}
    }},
    ""callsites"": {{
      ""version"": ""0.2.0"",
      ""resolved"": ""https://registry.npmjs.org/callsites/-/callsites-0.2.0.tgz"",
      ""integrity"": ""sha1-r6uWJikQp/M8GaV3WCXGnzTjUMo="",
      ""dev"": true
    }},
    ""camel-case"": {{
      ""version"": ""3.0.0"",
      ""resolved"": ""https://registry.npmjs.org/camel-case/-/camel-case-3.0.0.tgz"",
      ""integrity"": ""sha1-yjw2iKTpzzpM2nd9xNy8cTJJz3M="",
      ""dev"": true,
      ""requires"": {{
        ""no-case"": ""2.3.2"",
        ""upper-case"": ""1.1.3""
      }}
    }},
    ""camelcase"": {{
      ""version"": ""2.1.1"",
      ""resolved"": ""https://registry.npmjs.org/camelcase/-/camelcase-2.1.1.tgz"",
      ""integrity"": ""sha1-fB0W1nmhu+WcoCys7PsBHiAfWh8="",
      ""dev"": true
    }},
    ""camelcase-keys"": {{
      ""version"": ""2.1.0"",
      ""resolved"": ""https://registry.npmjs.org/camelcase-keys/-/camelcase-keys-2.1.0.tgz"",
      ""integrity"": ""sha1-MIvur/3ygRkFHvodkyITyRuPkuc="",
      ""dev"": true,
      ""requires"": {{
        ""camelcase"": ""2.1.1"",
        ""map-obj"": ""1.0.1""
      }}
    }},
    ""caniuse-api"": {{
      ""version"": ""1.6.1"",
      ""resolved"": ""https://registry.npmjs.org/caniuse-api/-/caniuse-api-1.6.1.tgz"",
      ""integrity"": ""sha1-tTTnxzTE+B7F++isoq0kNUuWLGw="",
      ""dev"": true,
      ""requires"": {{
        ""browserslist"": ""1.7.7"",
        ""caniuse-db"": ""1.0.30000787"",
        ""lodash.memoize"": ""4.1.2"",
        ""lodash.uniq"": ""4.5.0""
      }}
    }},
    ""caniuse-db"": {{
      ""version"": ""1.0.30000787"",
      ""resolved"": ""https://registry.npmjs.org/caniuse-db/-/caniuse-db-1.0.30000787.tgz"",
      ""integrity"": ""sha1-ygeigb5Taoi9f6yWuolfPPU/gRs="",
      ""dev"": true
    }},
    ""caseless"": {{
      ""version"": ""0.12.0"",
      ""resolved"": ""https://registry.npmjs.org/caseless/-/caseless-0.12.0.tgz"",
      ""integrity"": ""sha1-G2gcIf+EAzyCZUMJBolCDRhxUdw="",
      ""dev"": true
    }},
    ""center-align"": {{
      ""version"": ""0.1.3"",
      ""resolved"": ""https://registry.npmjs.org/center-align/-/center-align-0.1.3.tgz"",
      ""integrity"": ""sha1-qg0yYptu6XIgBBHL1EYckHvCt60="",
      ""dev"": true,
      ""requires"": {{
        ""align-text"": ""0.1.4"",
        ""lazy-cache"": ""1.0.4""
      }},
      ""dependencies"": {{
        ""lazy-cache"": {{
          ""version"": ""1.0.4"",
          ""resolved"": ""https://registry.npmjs.org/lazy-cache/-/lazy-cache-1.0.4.tgz"",
          ""integrity"": ""sha1-odePw6UEdMuAhF07O24dpJpEbo4="",
          ""dev"": true
        }}
      }}
    }},
    ""chain-function"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/chain-function/-/chain-function-1.0.0.tgz"",
      ""integrity"": ""sha1-DUqzfn4Y6tC9xHuSB2QRjOWHM9w=""
    }},
    ""chalk"": {{
      ""version"": ""1.1.3"",
      ""resolved"": ""https://registry.npmjs.org/chalk/-/chalk-1.1.3.tgz"",
      ""integrity"": ""sha1-qBFcVeSnAv5NFQq9OHKCKn4J/Jg="",
      ""dev"": true,
      ""requires"": {{
        ""ansi-styles"": ""2.2.1"",
        ""escape-string-regexp"": ""1.0.5"",
        ""has-ansi"": ""2.0.0"",
        ""strip-ansi"": ""3.0.1"",
        ""supports-color"": ""2.0.0""
      }},
      ""dependencies"": {{
        ""supports-color"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/supports-color/-/supports-color-2.0.0.tgz"",
          ""integrity"": ""sha1-U10EXOa2Nj+kARcIRimZXp3zJMc="",
          ""dev"": true
        }}
      }}
    }},
    ""change-emitter"": {{
      ""version"": ""0.1.6"",
      ""resolved"": ""https://registry.npmjs.org/change-emitter/-/change-emitter-0.1.6.tgz"",
      ""integrity"": ""sha1-6LL+PX8at9aaMhma/5HqaTFAlRU=""
    }},
    ""cheerio"": {{
      ""version"": ""0.22.0"",
      ""resolved"": ""https://registry.npmjs.org/cheerio/-/cheerio-0.22.0.tgz"",
      ""integrity"": ""sha1-qbqoYKP5tZWmuBsahocxIe06Jp4="",
      ""dev"": true,
      ""requires"": {{
        ""css-select"": ""1.2.0"",
        ""dom-serializer"": ""0.1.0"",
        ""entities"": ""1.1.1"",
        ""htmlparser2"": ""3.9.2"",
        ""lodash.assignin"": ""4.2.0"",
        ""lodash.bind"": ""4.2.1"",
        ""lodash.defaults"": ""4.2.0"",
        ""lodash.filter"": ""4.6.0"",
        ""lodash.flatten"": ""4.4.0"",
        ""lodash.foreach"": ""4.5.0"",
        ""lodash.map"": ""4.6.0"",
        ""lodash.merge"": ""4.6.0"",
        ""lodash.pick"": ""4.4.0"",
        ""lodash.reduce"": ""4.6.0"",
        ""lodash.reject"": ""4.6.0"",
        ""lodash.some"": ""4.6.0""
      }}
    }},
    ""chokidar"": {{
      ""version"": ""1.7.0"",
      ""resolved"": ""https://registry.npmjs.org/chokidar/-/chokidar-1.7.0.tgz"",
      ""integrity"": ""sha1-eY5ol3gVHIB2tLNg5e3SjNortGg="",
      ""dev"": true,
      ""requires"": {{
        ""anymatch"": ""1.3.2"",
        ""async-each"": ""1.0.1"",
        ""fsevents"": ""1.1.3"",
        ""glob-parent"": ""2.0.0"",
        ""inherits"": ""2.0.3"",
        ""is-binary-path"": ""1.0.1"",
        ""is-glob"": ""2.0.1"",
        ""path-is-absolute"": ""1.0.1"",
        ""readdirp"": ""2.1.0""
      }}
    }},
    ""ci-info"": {{
      ""version"": ""1.1.2"",
      ""resolved"": ""https://registry.npmjs.org/ci-info/-/ci-info-1.1.2.tgz"",
      ""integrity"": ""sha512-uTGIPNx/nSpBdsF6xnseRXLLtfr9VLqkz8ZqHXr3Y7b6SftyRxBGjwMtJj1OhNbmlc1wZzLNAlAcvyIiE8a6ZA=="",
      ""dev"": true
    }},
    ""cipher-base"": {{
      ""version"": ""1.0.4"",
      ""resolved"": ""https://registry.npmjs.org/cipher-base/-/cipher-base-1.0.4.tgz"",
      ""integrity"": ""sha512-Kkht5ye6ZGmwv40uUDZztayT2ThLQGfnj/T71N/XzeZeo3nf8foyW7zGTsPYkEya3m5f3cAypH+qe7YOrM1U2Q=="",
      ""dev"": true,
      ""requires"": {{
        ""inherits"": ""2.0.3"",
        ""safe-buffer"": ""5.1.1""
      }}
    }},
    ""circular-json"": {{
      ""version"": ""0.3.3"",
      ""resolved"": ""https://registry.npmjs.org/circular-json/-/circular-json-0.3.3.tgz"",
      ""integrity"": ""sha512-UZK3NBx2Mca+b5LsG7bY183pHWt5Y1xts4P3Pz7ENTwGVnJOUWbRb3ocjvX7hx9tq/yTAdclXm9sZ38gNuem4A=="",
      ""dev"": true
    }},
    ""clap"": {{
      ""version"": ""1.2.3"",
      ""resolved"": ""https://registry.npmjs.org/clap/-/clap-1.2.3.tgz"",
      ""integrity"": ""sha512-4CoL/A3hf90V3VIEjeuhSvlGFEHKzOz+Wfc2IVZc+FaUgU0ZQafJTP49fvnULipOPcAfqhyI2duwQyns6xqjYA=="",
      ""dev"": true,
      ""requires"": {{
        ""chalk"": ""1.1.3""
      }}
    }},
    ""clean-css"": {{
      ""version"": ""4.1.9"",
      ""resolved"": ""https://registry.npmjs.org/clean-css/-/clean-css-4.1.9.tgz"",
      ""integrity"": ""sha1-Nc7ornaHpJuYA09w3gDE7dOCYwE="",
      ""dev"": true,
      ""requires"": {{
        ""source-map"": ""0.5.7""
      }},
      ""dependencies"": {{
        ""source-map"": {{
          ""version"": ""0.5.7"",
          ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.5.7.tgz"",
          ""integrity"": ""sha1-igOdLRAh0i0eoUyA2OpGi6LvP8w="",
          ""dev"": true
        }}
      }}
    }},
    ""cli-cursor"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/cli-cursor/-/cli-cursor-1.0.2.tgz"",
      ""integrity"": ""sha1-ZNo/fValRBLll5S9Ytw1KV6PKYc="",
      ""dev"": true,
      ""requires"": {{
        ""restore-cursor"": ""1.0.1""
      }}
    }},
    ""cli-width"": {{
      ""version"": ""2.2.0"",
      ""resolved"": ""https://registry.npmjs.org/cli-width/-/cli-width-2.2.0.tgz"",
      ""integrity"": ""sha1-/xnt6Kml5XkyQUewwR8PvLq+1jk="",
      ""dev"": true
    }},
    ""cliui"": {{
      ""version"": ""3.2.0"",
      ""resolved"": ""https://registry.npmjs.org/cliui/-/cliui-3.2.0.tgz"",
      ""integrity"": ""sha1-EgYBU3qRbSmUD5NNo7SNWFo5IT0="",
      ""dev"": true,
      ""requires"": {{
        ""string-width"": ""1.0.2"",
        ""strip-ansi"": ""3.0.1"",
        ""wrap-ansi"": ""2.1.0""
      }}
    }},
    ""clone"": {{
      ""version"": ""1.0.3"",
      ""resolved"": ""https://registry.npmjs.org/clone/-/clone-1.0.3.tgz"",
      ""integrity"": ""sha1-KY1+IjFmD0DAA8LtMUDezz9TCF8="",
      ""dev"": true
    }},
    ""clone-deep"": {{
      ""version"": ""0.3.0"",
      ""resolved"": ""https://registry.npmjs.org/clone-deep/-/clone-deep-0.3.0.tgz"",
      ""integrity"": ""sha1-NIxhrpzb4O3+BT2R/0zFIdeQ7eg="",
      ""dev"": true,
      ""requires"": {{
        ""for-own"": ""1.0.0"",
        ""is-plain-object"": ""2.0.4"",
        ""kind-of"": ""3.2.2"",
        ""shallow-clone"": ""0.1.2""
      }}
    }},
    ""co"": {{
      ""version"": ""4.6.0"",
      ""resolved"": ""https://registry.npmjs.org/co/-/co-4.6.0.tgz"",
      ""integrity"": ""sha1-bqa989hTrlTMuOR7+gvz+QMfsYQ="",
      ""dev"": true
    }},
    ""coa"": {{
      ""version"": ""1.0.4"",
      ""resolved"": ""https://registry.npmjs.org/coa/-/coa-1.0.4.tgz"",
      ""integrity"": ""sha1-qe8VNmDWqGqL3sAomlxoTSF0Mv0="",
      ""dev"": true,
      ""requires"": {{
        ""q"": ""1.5.1""
      }}
    }},
    ""code-point-at"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/code-point-at/-/code-point-at-1.1.0.tgz"",
      ""integrity"": ""sha1-DQcLTQQ6W+ozovGkDi7bPZpMz3c="",
      ""dev"": true
    }},
    ""color"": {{
      ""version"": ""0.11.4"",
      ""resolved"": ""https://registry.npmjs.org/color/-/color-0.11.4.tgz"",
      ""integrity"": ""sha1-bXtcdPtl6EHNSHkq0e1eB7kE12Q="",
      ""dev"": true,
      ""requires"": {{
        ""clone"": ""1.0.3"",
        ""color-convert"": ""1.9.1"",
        ""color-string"": ""0.3.0""
      }}
    }},
    ""color-convert"": {{
      ""version"": ""1.9.1"",
      ""resolved"": ""https://registry.npmjs.org/color-convert/-/color-convert-1.9.1.tgz"",
      ""integrity"": ""sha512-mjGanIiwQJskCC18rPR6OmrZ6fm2Lc7PeGFYwCmy5J34wC6F1PzdGL6xeMfmgicfYcNLGuVFA3WzXtIDCQSZxQ=="",
      ""dev"": true,
      ""requires"": {{
        ""color-name"": ""1.1.3""
      }}
    }},
    ""color-name"": {{
      ""version"": ""1.1.3"",
      ""resolved"": ""https://registry.npmjs.org/color-name/-/color-name-1.1.3.tgz"",
      ""integrity"": ""sha1-p9BVi9icQveV3UIyj3QIMcpTvCU="",
      ""dev"": true
    }},
    ""color-string"": {{
      ""version"": ""0.3.0"",
      ""resolved"": ""https://registry.npmjs.org/color-string/-/color-string-0.3.0.tgz"",
      ""integrity"": ""sha1-J9RvtnAlxcL6JZk7+/V55HhBuZE="",
      ""dev"": true,
      ""requires"": {{
        ""color-name"": ""1.1.3""
      }}
    }},
    ""colormin"": {{
      ""version"": ""1.1.2"",
      ""resolved"": ""https://registry.npmjs.org/colormin/-/colormin-1.1.2.tgz"",
      ""integrity"": ""sha1-6i90IKcrlogaOKrlnsEkpvcpgTM="",
      ""dev"": true,
      ""requires"": {{
        ""color"": ""0.11.4"",
        ""css-color-names"": ""0.0.4"",
        ""has"": ""1.0.1""
      }}
    }},
    ""colors"": {{
      ""version"": ""1.1.2"",
      ""resolved"": ""https://registry.npmjs.org/colors/-/colors-1.1.2.tgz"",
      ""integrity"": ""sha1-FopHAXVran9RoSzgyXv6KMCE7WM="",
      ""dev"": true
    }},
    ""combined-stream"": {{
      ""version"": ""1.0.5"",
      ""resolved"": ""https://registry.npmjs.org/combined-stream/-/combined-stream-1.0.5.tgz"",
      ""integrity"": ""sha1-k4NwpXtKUd6ix3wV1cX9+JUWQAk="",
      ""dev"": true,
      ""requires"": {{
        ""delayed-stream"": ""1.0.0""
      }}
    }},
    ""commander"": {{
      ""version"": ""2.1.0"",
      ""resolved"": ""https://registry.npmjs.org/commander/-/commander-2.1.0.tgz"",
      ""integrity"": ""sha1-0SG7roYNmZKj1Re6lvVliOR8Z4E="",
      ""dev"": true
    }},
    ""commondir"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/commondir/-/commondir-1.0.1.tgz"",
      ""integrity"": ""sha1-3dgA2gxmEnOTzKWVDqloo6rxJTs="",
      ""dev"": true
    }},
    ""compressible"": {{
      ""version"": ""2.0.12"",
      ""resolved"": ""https://registry.npmjs.org/compressible/-/compressible-2.0.12.tgz"",
      ""integrity"": ""sha1-xZpcmdt2dn6YdlAOJx72OzSTvWY="",
      ""dev"": true,
      ""requires"": {{
        ""mime-db"": ""1.30.0""
      }}
    }},
    ""compression"": {{
      ""version"": ""1.7.1"",
      ""resolved"": ""https://registry.npmjs.org/compression/-/compression-1.7.1.tgz"",
      ""integrity"": ""sha1-7/JgPvwuIs+G810uuTWJ+YdTc9s="",
      ""dev"": true,
      ""requires"": {{
        ""accepts"": ""1.3.4"",
        ""bytes"": ""3.0.0"",
        ""compressible"": ""2.0.12"",
        ""debug"": ""2.6.9"",
        ""on-headers"": ""1.0.1"",
        ""safe-buffer"": ""5.1.1"",
        ""vary"": ""1.1.2""
      }}
    }},
    ""concat-map"": {{
      ""version"": ""0.0.1"",
      ""resolved"": ""https://registry.npmjs.org/concat-map/-/concat-map-0.0.1.tgz"",
      ""integrity"": ""sha1-2Klr13/Wjfd5OnMDajug1UBdR3s="",
      ""dev"": true
    }},
    ""concat-stream"": {{
      ""version"": ""1.6.0"",
      ""resolved"": ""https://registry.npmjs.org/concat-stream/-/concat-stream-1.6.0.tgz"",
      ""integrity"": ""sha1-CqxmL9Ur54lk1VMvaUeE5wEQrPc="",
      ""dev"": true,
      ""requires"": {{
        ""inherits"": ""2.0.3"",
        ""readable-stream"": ""2.3.3"",
        ""typedarray"": ""0.0.6""
      }},
      ""dependencies"": {{
        ""isarray"": {{
          ""version"": ""1.0.0"",
          ""resolved"": ""https://registry.npmjs.org/isarray/-/isarray-1.0.0.tgz"",
          ""integrity"": ""sha1-u5NdSFgsuhaMBoNJV6VKPgcSTxE="",
          ""dev"": true
        }},
        ""readable-stream"": {{
          ""version"": ""2.3.3"",
          ""resolved"": ""https://registry.npmjs.org/readable-stream/-/readable-stream-2.3.3.tgz"",
          ""integrity"": ""sha512-m+qzzcn7KUxEmd1gMbchF+Y2eIUbieUaxkWtptyHywrX0rE8QEYqPC07Vuy4Wm32/xE16NcdBctb8S0Xe/5IeQ=="",
          ""dev"": true,
          ""requires"": {{
            ""core-util-is"": ""1.0.2"",
            ""inherits"": ""2.0.3"",
            ""isarray"": ""1.0.0"",
            ""process-nextick-args"": ""1.0.7"",
            ""safe-buffer"": ""5.1.1"",
            ""string_decoder"": ""1.0.3"",
            ""util-deprecate"": ""1.0.2""
          }}
        }},
        ""string_decoder"": {{
          ""version"": ""1.0.3"",
          ""resolved"": ""https://registry.npmjs.org/string_decoder/-/string_decoder-1.0.3.tgz"",
          ""integrity"": ""sha512-4AH6Z5fzNNBcH+6XDMfA/BTt87skxqJlO0lAh3Dker5zThcAxG6mKz+iGu308UKoPPQ8Dcqx/4JhujzltRa+hQ=="",
          ""dev"": true,
          ""requires"": {{
            ""safe-buffer"": ""5.1.1""
          }}
        }}
      }}
    }},
    ""connect-history-api-fallback"": {{
      ""version"": ""1.5.0"",
      ""resolved"": ""https://registry.npmjs.org/connect-history-api-fallback/-/connect-history-api-fallback-1.5.0.tgz"",
      ""integrity"": ""sha1-sGhzk0vF40T+9hGhlqb6rgruAVo="",
      ""dev"": true
    }},
    ""console-browserify"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/console-browserify/-/console-browserify-1.1.0.tgz"",
      ""integrity"": ""sha1-8CQcRXMKn8YyOyBtvzjtx0HQuxA="",
      ""dev"": true,
      ""requires"": {{
        ""date-now"": ""0.1.4""
      }}
    }},
    ""console-control-strings"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/console-control-strings/-/console-control-strings-1.1.0.tgz"",
      ""integrity"": ""sha1-PXz0Rk22RG6mRL9LOVB/mFEAjo4="",
      ""dev"": true
    }},
    ""constants-browserify"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/constants-browserify/-/constants-browserify-1.0.0.tgz"",
      ""integrity"": ""sha1-wguW2MYXdIqvHBYCF2DNJ/y4y3U="",
      ""dev"": true
    }},
    ""content-disposition"": {{
      ""version"": ""0.5.2"",
      ""resolved"": ""https://registry.npmjs.org/content-disposition/-/content-disposition-0.5.2.tgz"",
      ""integrity"": ""sha1-DPaLud318r55YcOoUXjLhdunjLQ="",
      ""dev"": true
    }},
    ""content-type"": {{
      ""version"": ""1.0.4"",
      ""resolved"": ""https://registry.npmjs.org/content-type/-/content-type-1.0.4.tgz"",
      ""integrity"": ""sha512-hIP3EEPs8tB9AT1L+NUqtwOAps4mk2Zob89MWXMHjHWg9milF/j4osnnQLXBCBFBk/tvIG/tUc9mOUJiPBhPXA=="",
      ""dev"": true
    }},
    ""content-type-parser"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/content-type-parser/-/content-type-parser-1.0.2.tgz"",
      ""integrity"": ""sha512-lM4l4CnMEwOLHAHr/P6MEZwZFPJFtAAKgL6pogbXmVZggIqXhdB6RbBtPOTsw2FcXwYhehRGERJmRrjOiIB8pQ=="",
      ""dev"": true
    }},
    ""convert-source-map"": {{
      ""version"": ""1.5.1"",
      ""resolved"": ""https://registry.npmjs.org/convert-source-map/-/convert-source-map-1.5.1.tgz"",
      ""integrity"": ""sha1-uCeAl7m8IpNl3lxiz1/K7YtVmeU="",
      ""dev"": true
    }},
    ""cookie"": {{
      ""version"": ""0.3.1"",
      ""resolved"": ""https://registry.npmjs.org/cookie/-/cookie-0.3.1.tgz"",
      ""integrity"": ""sha1-5+Ch+e9DtMi6klxcWpboBtFoc7s="",
      ""dev"": true
    }},
    ""cookie-signature"": {{
      ""version"": ""1.0.6"",
      ""resolved"": ""https://registry.npmjs.org/cookie-signature/-/cookie-signature-1.0.6.tgz"",
      ""integrity"": ""sha1-4wOogrNCzD7oylE6eZmXNNqzriw="",
      ""dev"": true
    }},
    ""copy-webpack-plugin"": {{
      ""version"": ""3.0.1"",
      ""resolved"": ""https://registry.npmjs.org/copy-webpack-plugin/-/copy-webpack-plugin-3.0.1.tgz"",
      ""integrity"": ""sha1-m7Pp1sYGTeZcW85EzyNrTQd6ITE="",
      ""dev"": true,
      ""requires"": {{
        ""bluebird"": ""2.11.0"",
        ""fs-extra"": ""0.26.7"",
        ""glob"": ""6.0.4"",
        ""lodash"": ""4.17.4"",
        ""minimatch"": ""3.0.4"",
        ""node-dir"": ""0.1.17""
      }}
    }},
    ""core-js"": {{
      ""version"": ""1.2.7"",
      ""resolved"": ""https://registry.npmjs.org/core-js/-/core-js-1.2.7.tgz"",
      ""integrity"": ""sha1-ZSKUwUZR2yj6k70tX/KYOk8IxjY=""
    }},
    ""core-util-is"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/core-util-is/-/core-util-is-1.0.2.tgz"",
      ""integrity"": ""sha1-tf1UIgqivFq1eqtxQMlAdUUDwac="",
      ""dev"": true
    }},
    ""cosmiconfig"": {{
      ""version"": ""2.2.2"",
      ""resolved"": ""https://registry.npmjs.org/cosmiconfig/-/cosmiconfig-2.2.2.tgz"",
      ""integrity"": ""sha512-GiNXLwAFPYHy25XmTPpafYvn3CLAkJ8FLsscq78MQd1Kh0OU6Yzhn4eV2MVF4G9WEQZoWEGltatdR+ntGPMl5A=="",
      ""dev"": true,
      ""requires"": {{
        ""is-directory"": ""0.3.1"",
        ""js-yaml"": ""3.7.0"",
        ""minimist"": ""1.2.0"",
        ""object-assign"": ""4.1.1"",
        ""os-homedir"": ""1.0.2"",
        ""parse-json"": ""2.2.0"",
        ""require-from-string"": ""1.2.1""
      }},
      ""dependencies"": {{
        ""minimist"": {{
          ""version"": ""1.2.0"",
          ""resolved"": ""https://registry.npmjs.org/minimist/-/minimist-1.2.0.tgz"",
          ""integrity"": ""sha1-o1AIsg9BOD7sH7kU9M1d95omQoQ="",
          ""dev"": true
        }}
      }}
    }},
    ""create-ecdh"": {{
      ""version"": ""4.0.0"",
      ""resolved"": ""https://registry.npmjs.org/create-ecdh/-/create-ecdh-4.0.0.tgz"",
      ""integrity"": ""sha1-iIxyNZbN92EvZJgjPuvXo1MBc30="",
      ""dev"": true,
      ""requires"": {{
        ""bn.js"": ""4.11.8"",
        ""elliptic"": ""6.4.0""
      }}
    }},
    ""create-hash"": {{
      ""version"": ""1.1.3"",
      ""resolved"": ""https://registry.npmjs.org/create-hash/-/create-hash-1.1.3.tgz"",
      ""integrity"": ""sha1-YGBCrIuSYnUPSDyt2rD1gZFy2P0="",
      ""dev"": true,
      ""requires"": {{
        ""cipher-base"": ""1.0.4"",
        ""inherits"": ""2.0.3"",
        ""ripemd160"": ""2.0.1"",
        ""sha.js"": ""2.4.9""
      }}
    }},
    ""create-hmac"": {{
      ""version"": ""1.1.6"",
      ""resolved"": ""https://registry.npmjs.org/create-hmac/-/create-hmac-1.1.6.tgz"",
      ""integrity"": ""sha1-rLniIaThe9sHbpBlfEK5PjcmzwY="",
      ""dev"": true,
      ""requires"": {{
        ""cipher-base"": ""1.0.4"",
        ""create-hash"": ""1.1.3"",
        ""inherits"": ""2.0.3"",
        ""ripemd160"": ""2.0.1"",
        ""safe-buffer"": ""5.1.1"",
        ""sha.js"": ""2.4.9""
      }}
    }},
    ""cross-env"": {{
      ""version"": ""5.1.3"",
      ""resolved"": ""https://registry.npmjs.org/cross-env/-/cross-env-5.1.3.tgz"",
      ""integrity"": ""sha512-UOokgwvDzCT0mqRSLEkJzUhYXB1vK3E5UgDrD41QiXsm9UetcW2rCGHYz/O3p873lMJ1VZbFCF9Izkwh7nYR5A=="",
      ""dev"": true,
      ""requires"": {{
        ""cross-spawn"": ""5.1.0"",
        ""is-windows"": ""1.0.1""
      }}
    }},
    ""cross-spawn"": {{
      ""version"": ""5.1.0"",
      ""resolved"": ""https://registry.npmjs.org/cross-spawn/-/cross-spawn-5.1.0.tgz"",
      ""integrity"": ""sha1-6L0O/uWPz/b4+UUQoKVUu/ojVEk="",
      ""dev"": true,
      ""requires"": {{
        ""lru-cache"": ""4.1.1"",
        ""shebang-command"": ""1.2.0"",
        ""which"": ""1.3.0""
      }}
    }},
    ""cryptiles"": {{
      ""version"": ""3.1.2"",
      ""resolved"": ""https://registry.npmjs.org/cryptiles/-/cryptiles-3.1.2.tgz"",
      ""integrity"": ""sha1-qJ+7Ig9c4l7FboxKqKT9e1sNKf4="",
      ""dev"": true,
      ""requires"": {{
        ""boom"": ""5.2.0""
      }},
      ""dependencies"": {{
        ""boom"": {{
          ""version"": ""5.2.0"",
          ""resolved"": ""https://registry.npmjs.org/boom/-/boom-5.2.0.tgz"",
          ""integrity"": ""sha512-Z5BTk6ZRe4tXXQlkqftmsAUANpXmuwlsF5Oov8ThoMbQRzdGTA1ngYRW160GexgOgjsFOKJz0LYhoNi+2AMBUw=="",
          ""dev"": true,
          ""requires"": {{
            ""hoek"": ""4.2.0""
          }}
        }}
      }}
    }},
    ""crypto-browserify"": {{
      ""version"": ""3.12.0"",
      ""resolved"": ""https://registry.npmjs.org/crypto-browserify/-/crypto-browserify-3.12.0.tgz"",
      ""integrity"": ""sha512-fz4spIh+znjO2VjL+IdhEpRJ3YN6sMzITSBijk6FK2UvTqruSQW+/cCZTSNsMiZNvUeq0CqurF+dAbyiGOY6Wg=="",
      ""dev"": true,
      ""requires"": {{
        ""browserify-cipher"": ""1.0.0"",
        ""browserify-sign"": ""4.0.4"",
        ""create-ecdh"": ""4.0.0"",
        ""create-hash"": ""1.1.3"",
        ""create-hmac"": ""1.1.6"",
        ""diffie-hellman"": ""5.0.2"",
        ""inherits"": ""2.0.3"",
        ""pbkdf2"": ""3.0.14"",
        ""public-encrypt"": ""4.0.0"",
        ""randombytes"": ""2.0.5"",
        ""randomfill"": ""1.0.3""
      }}
    }},
    ""css"": {{
      ""version"": ""2.2.1"",
      ""resolved"": ""https://registry.npmjs.org/css/-/css-2.2.1.tgz"",
      ""integrity"": ""sha1-c6TIHehdtmTU7mdPfUcIXjstVdw="",
      ""dev"": true,
      ""requires"": {{
        ""inherits"": ""2.0.3"",
        ""source-map"": ""0.1.43"",
        ""source-map-resolve"": ""0.3.1"",
        ""urix"": ""0.1.0""
      }},
      ""dependencies"": {{
        ""source-map"": {{
          ""version"": ""0.1.43"",
          ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.1.43.tgz"",
          ""integrity"": ""sha1-wkvBRspRfBRx9drL4lcbK3+eM0Y="",
          ""dev"": true,
          ""requires"": {{
            ""amdefine"": ""1.0.1""
          }}
        }}
      }}
    }},
    ""css-color-function"": {{
      ""version"": ""1.3.3"",
      ""resolved"": ""https://registry.npmjs.org/css-color-function/-/css-color-function-1.3.3.tgz"",
      ""integrity"": ""sha1-jtJMLAIFBzM5+voAS8jBQfzLKC4="",
      ""dev"": true,
      ""requires"": {{
        ""balanced-match"": ""0.1.0"",
        ""color"": ""0.11.4"",
        ""debug"": ""3.1.0"",
        ""rgb"": ""0.1.0""
      }},
      ""dependencies"": {{
        ""balanced-match"": {{
          ""version"": ""0.1.0"",
          ""resolved"": ""https://registry.npmjs.org/balanced-match/-/balanced-match-0.1.0.tgz"",
          ""integrity"": ""sha1-tQS9BYabOSWd0MXvw12EMXbczEo="",
          ""dev"": true
        }},
        ""debug"": {{
          ""version"": ""3.1.0"",
          ""resolved"": ""https://registry.npmjs.org/debug/-/debug-3.1.0.tgz"",
          ""integrity"": ""sha512-OX8XqP7/1a9cqkxYw2yXss15f26NKWBpDXQd0/uK/KPqdQhxbPa994hnzjcE2VqQpDslf55723cKPUOGSmMY3g=="",
          ""dev"": true,
          ""requires"": {{
            ""ms"": ""2.0.0""
          }}
        }}
      }}
    }},
    ""css-color-names"": {{
      ""version"": ""0.0.4"",
      ""resolved"": ""https://registry.npmjs.org/css-color-names/-/css-color-names-0.0.4.tgz"",
      ""integrity"": ""sha1-gIrcLnnPhHOAabZGyyDsJ762KeA="",
      ""dev"": true
    }},
    ""css-in-js-utils"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/css-in-js-utils/-/css-in-js-utils-2.0.0.tgz"",
      ""integrity"": ""sha512-yuWmPMD9FLi50Xf3k8W8oO3WM1eVnxEGCldCLyfusQ+CgivFk0s23yst4ooW6tfxMuSa03S6uUEga9UhX6GRrA=="",
      ""requires"": {{
        ""hyphenate-style-name"": ""1.0.2""
      }}
    }},
    ""css-loader"": {{
      ""version"": ""0.28.8"",
      ""resolved"": ""https://registry.npmjs.org/css-loader/-/css-loader-0.28.8.tgz"",
      ""integrity"": ""sha512-4jGj7Ag6WUZ5lQyE4te9sJLn0lgkz6HI3WDE4aw98AkW1IAKXPP4blTpPeorlLDpNsYvojo0SYgRJOdz2KbuAw=="",
      ""dev"": true,
      ""requires"": {{
        ""babel-code-frame"": ""6.26.0"",
        ""css-selector-tokenizer"": ""0.7.0"",
        ""cssnano"": ""3.10.0"",
        ""icss-utils"": ""2.1.0"",
        ""loader-utils"": ""1.1.0"",
        ""lodash.camelcase"": ""4.3.0"",
        ""object-assign"": ""4.1.1"",
        ""postcss"": ""5.2.18"",
        ""postcss-modules-extract-imports"": ""1.1.0"",
        ""postcss-modules-local-by-default"": ""1.2.0"",
        ""postcss-modules-scope"": ""1.1.0"",
        ""postcss-modules-values"": ""1.3.0"",
        ""postcss-value-parser"": ""3.3.0"",
        ""source-list-map"": ""2.0.0""
      }},
      ""dependencies"": {{
        ""loader-utils"": {{
          ""version"": ""1.1.0"",
          ""resolved"": ""https://registry.npmjs.org/loader-utils/-/loader-utils-1.1.0.tgz"",
          ""integrity"": ""sha1-yYrvSIvM7aL/teLeZG1qdUQp9c0="",
          ""dev"": true,
          ""requires"": {{
            ""big.js"": ""3.2.0"",
            ""emojis-list"": ""2.1.0"",
            ""json5"": ""0.5.1""
          }}
        }}
      }}
    }},
    ""css-select"": {{
      ""version"": ""1.2.0"",
      ""resolved"": ""https://registry.npmjs.org/css-select/-/css-select-1.2.0.tgz"",
      ""integrity"": ""sha1-KzoRBTnFNV8c2NMUYj6HCxIeyFg="",
      ""dev"": true,
      ""requires"": {{
        ""boolbase"": ""1.0.0"",
        ""css-what"": ""2.1.0"",
        ""domutils"": ""1.5.1"",
        ""nth-check"": ""1.0.1""
      }}
    }},
    ""css-selector-tokenizer"": {{
      ""version"": ""0.7.0"",
      ""resolved"": ""https://registry.npmjs.org/css-selector-tokenizer/-/css-selector-tokenizer-0.7.0.tgz"",
      ""integrity"": ""sha1-5piEdK6MlTR3v15+/s/OzNnPTIY="",
      ""dev"": true,
      ""requires"": {{
        ""cssesc"": ""0.1.0"",
        ""fastparse"": ""1.1.1"",
        ""regexpu-core"": ""1.0.0""
      }},
      ""dependencies"": {{
        ""regexpu-core"": {{
          ""version"": ""1.0.0"",
          ""resolved"": ""https://registry.npmjs.org/regexpu-core/-/regexpu-core-1.0.0.tgz"",
          ""integrity"": ""sha1-hqdj9Y7k18L2sQLkdkBQ3n7ZDGs="",
          ""dev"": true,
          ""requires"": {{
            ""regenerate"": ""1.3.3"",
            ""regjsgen"": ""0.2.0"",
            ""regjsparser"": ""0.1.5""
          }}
        }}
      }}
    }},
    ""css-what"": {{
      ""version"": ""2.1.0"",
      ""resolved"": ""https://registry.npmjs.org/css-what/-/css-what-2.1.0.tgz"",
      ""integrity"": ""sha1-lGfQMsOM+u+58teVASUwYvh/ob0="",
      ""dev"": true
    }},
    ""cssesc"": {{
      ""version"": ""0.1.0"",
      ""resolved"": ""https://registry.npmjs.org/cssesc/-/cssesc-0.1.0.tgz"",
      ""integrity"": ""sha1-yBSQPkViM3GgR3tAEJqq++6t27Q="",
      ""dev"": true
    }},
    ""cssnano"": {{
      ""version"": ""3.10.0"",
      ""resolved"": ""https://registry.npmjs.org/cssnano/-/cssnano-3.10.0.tgz"",
      ""integrity"": ""sha1-Tzj2zqK5sX+gFJDyPx3GjqZcHDg="",
      ""dev"": true,
      ""requires"": {{
        ""autoprefixer"": ""6.7.7"",
        ""decamelize"": ""1.2.0"",
        ""defined"": ""1.0.0"",
        ""has"": ""1.0.1"",
        ""object-assign"": ""4.1.1"",
        ""postcss"": ""5.2.18"",
        ""postcss-calc"": ""5.3.1"",
        ""postcss-colormin"": ""2.2.2"",
        ""postcss-convert-values"": ""2.6.1"",
        ""postcss-discard-comments"": ""2.0.4"",
        ""postcss-discard-duplicates"": ""2.1.0"",
        ""postcss-discard-empty"": ""2.1.0"",
        ""postcss-discard-overridden"": ""0.1.1"",
        ""postcss-discard-unused"": ""2.2.3"",
        ""postcss-filter-plugins"": ""2.0.2"",
        ""postcss-merge-idents"": ""2.1.7"",
        ""postcss-merge-longhand"": ""2.0.2"",
        ""postcss-merge-rules"": ""2.1.2"",
        ""postcss-minify-font-values"": ""1.0.5"",
        ""postcss-minify-gradients"": ""1.0.5"",
        ""postcss-minify-params"": ""1.2.2"",
        ""postcss-minify-selectors"": ""2.1.1"",
        ""postcss-normalize-charset"": ""1.1.1"",
        ""postcss-normalize-url"": ""3.0.8"",
        ""postcss-ordered-values"": ""2.2.3"",
        ""postcss-reduce-idents"": ""2.4.0"",
        ""postcss-reduce-initial"": ""1.0.1"",
        ""postcss-reduce-transforms"": ""1.0.4"",
        ""postcss-svgo"": ""2.1.6"",
        ""postcss-unique-selectors"": ""2.0.2"",
        ""postcss-value-parser"": ""3.3.0"",
        ""postcss-zindex"": ""2.2.0""
      }}
    }},
    ""csso"": {{
      ""version"": ""2.3.2"",
      ""resolved"": ""https://registry.npmjs.org/csso/-/csso-2.3.2.tgz"",
      ""integrity"": ""sha1-3dUsWHAz9J6Utx/FVWnyUuj/X4U="",
      ""dev"": true,
      ""requires"": {{
        ""clap"": ""1.2.3"",
        ""source-map"": ""0.5.7""
      }},
      ""dependencies"": {{
        ""source-map"": {{
          ""version"": ""0.5.7"",
          ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.5.7.tgz"",
          ""integrity"": ""sha1-igOdLRAh0i0eoUyA2OpGi6LvP8w="",
          ""dev"": true
        }}
      }}
    }},
    ""cssom"": {{
      ""version"": ""0.3.2"",
      ""resolved"": ""https://registry.npmjs.org/cssom/-/cssom-0.3.2.tgz"",
      ""integrity"": ""sha1-uANhcMefB6kP8vFuIihAJ6JDhIs="",
      ""dev"": true
    }},
    ""cssstyle"": {{
      ""version"": ""0.2.37"",
      ""resolved"": ""https://registry.npmjs.org/cssstyle/-/cssstyle-0.2.37.tgz"",
      ""integrity"": ""sha1-VBCXI0yyUTyDzu06zdwn/yeYfVQ="",
      ""dev"": true,
      ""requires"": {{
        ""cssom"": ""0.3.2""
      }}
    }},
    ""currently-unhandled"": {{
      ""version"": ""0.4.1"",
      ""resolved"": ""https://registry.npmjs.org/currently-unhandled/-/currently-unhandled-0.4.1.tgz"",
      ""integrity"": ""sha1-mI3zP+qxke95mmE2nddsF635V+o="",
      ""dev"": true,
      ""requires"": {{
        ""array-find-index"": ""1.0.2""
      }}
    }},
    ""d"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/d/-/d-1.0.0.tgz"",
      ""integrity"": ""sha1-dUu1v+VUUdpppYuU1F9MWwRi1Y8="",
      ""dev"": true,
      ""requires"": {{
        ""es5-ext"": ""0.10.37""
      }}
    }},
    ""dashdash"": {{
      ""version"": ""1.14.1"",
      ""resolved"": ""https://registry.npmjs.org/dashdash/-/dashdash-1.14.1.tgz"",
      ""integrity"": ""sha1-hTz6D3y+L+1d4gMmuN1YEDX24vA="",
      ""dev"": true,
      ""requires"": {{
        ""assert-plus"": ""1.0.0""
      }}
    }},
    ""date-now"": {{
      ""version"": ""0.1.4"",
      ""resolved"": ""https://registry.npmjs.org/date-now/-/date-now-0.1.4.tgz"",
      ""integrity"": ""sha1-6vQ5/U1ISK105cx9vvIAZyueNFs="",
      ""dev"": true
    }},
    ""debug"": {{
      ""version"": ""2.6.9"",
      ""resolved"": ""https://registry.npmjs.org/debug/-/debug-2.6.9.tgz"",
      ""integrity"": ""sha512-bC7ElrdJaJnPbAP+1EotYvqZsb3ecl5wi6Bfi6BJTUcNowp6cvspg0jXznRTKDjm/E7AdgFBVeAPVMNcKGsHMA=="",
      ""dev"": true,
      ""requires"": {{
        ""ms"": ""2.0.0""
      }}
    }},
    ""decamelize"": {{
      ""version"": ""1.2.0"",
      ""resolved"": ""https://registry.npmjs.org/decamelize/-/decamelize-1.2.0.tgz"",
      ""integrity"": ""sha1-9lNNFRSCabIDUue+4m9QH5oZEpA="",
      ""dev"": true
    }},
    ""deep-extend"": {{
      ""version"": ""0.4.2"",
      ""resolved"": ""https://registry.npmjs.org/deep-extend/-/deep-extend-0.4.2.tgz"",
      ""integrity"": ""sha1-SLaZwn4zS/ifEIkr5DL25MfTSn8="",
      ""dev"": true
    }},
    ""deep-is"": {{
      ""version"": ""0.1.3"",
      ""resolved"": ""https://registry.npmjs.org/deep-is/-/deep-is-0.1.3.tgz"",
      ""integrity"": ""sha1-s2nW+128E+7PUk+RsHD+7cNXzzQ="",
      ""dev"": true
    }},
    ""default-require-extensions"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/default-require-extensions/-/default-require-extensions-1.0.0.tgz"",
      ""integrity"": ""sha1-836hXT4T/9m0N9M+GnW1+5eHTLg="",
      ""dev"": true,
      ""requires"": {{
        ""strip-bom"": ""2.0.0""
      }}
    }},
    ""define-properties"": {{
      ""version"": ""1.1.2"",
      ""resolved"": ""https://registry.npmjs.org/define-properties/-/define-properties-1.1.2.tgz"",
      ""integrity"": ""sha1-g6c/L+pWmJj7c3GTyPhzyvbUXJQ="",
      ""dev"": true,
      ""requires"": {{
        ""foreach"": ""2.0.5"",
        ""object-keys"": ""1.0.11""
      }}
    }},
    ""defined"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/defined/-/defined-1.0.0.tgz"",
      ""integrity"": ""sha1-yY2bzvdWdBiOEQlpFRGZ45sfppM="",
      ""dev"": true
    }},
    ""del"": {{
      ""version"": ""2.2.2"",
      ""resolved"": ""https://registry.npmjs.org/del/-/del-2.2.2.tgz"",
      ""integrity"": ""sha1-wSyYHQZ4RshLyvhiz/kw2Qf/0ag="",
      ""dev"": true,
      ""requires"": {{
        ""globby"": ""5.0.0"",
        ""is-path-cwd"": ""1.0.0"",
        ""is-path-in-cwd"": ""1.0.0"",
        ""object-assign"": ""4.1.1"",
        ""pify"": ""2.3.0"",
        ""pinkie-promise"": ""2.0.1"",
        ""rimraf"": ""2.6.2""
      }}
    }},
    ""delayed-stream"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/delayed-stream/-/delayed-stream-1.0.0.tgz"",
      ""integrity"": ""sha1-3zrhmayt+31ECqrgsp4icrJOxhk="",
      ""dev"": true
    }},
    ""delegates"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/delegates/-/delegates-1.0.0.tgz"",
      ""integrity"": ""sha1-hMbhWbgZBP3KWaDvRM2HDTElD5o="",
      ""dev"": true
    }},
    ""depd"": {{
      ""version"": ""1.1.1"",
      ""resolved"": ""https://registry.npmjs.org/depd/-/depd-1.1.1.tgz"",
      ""integrity"": ""sha1-V4O04cRZ8G+lyif5kfPQbnoxA1k="",
      ""dev"": true
    }},
    ""des.js"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/des.js/-/des.js-1.0.0.tgz"",
      ""integrity"": ""sha1-wHTS4qpqipoH29YfmhXCzYPsjsw="",
      ""dev"": true,
      ""requires"": {{
        ""inherits"": ""2.0.3"",
        ""minimalistic-assert"": ""1.0.0""
      }}
    }},
    ""destroy"": {{
      ""version"": ""1.0.4"",
      ""resolved"": ""https://registry.npmjs.org/destroy/-/destroy-1.0.4.tgz"",
      ""integrity"": ""sha1-l4hXRCxEdJ5CBmE+N5RiBYJqvYA="",
      ""dev"": true
    }},
    ""detect-indent"": {{
      ""version"": ""4.0.0"",
      ""resolved"": ""https://registry.npmjs.org/detect-indent/-/detect-indent-4.0.0.tgz"",
      ""integrity"": ""sha1-920GQ1LN9Docts5hnE7jqUdd4gg="",
      ""dev"": true,
      ""requires"": {{
        ""repeating"": ""2.0.1""
      }}
    }},
    ""diffie-hellman"": {{
      ""version"": ""5.0.2"",
      ""resolved"": ""https://registry.npmjs.org/diffie-hellman/-/diffie-hellman-5.0.2.tgz"",
      ""integrity"": ""sha1-tYNXOScM/ias9jIJn97SoH8gnl4="",
      ""dev"": true,
      ""requires"": {{
        ""bn.js"": ""4.11.8"",
        ""miller-rabin"": ""4.0.1"",
        ""randombytes"": ""2.0.5""
      }}
    }},
    ""doctrine"": {{
      ""version"": ""1.5.0"",
      ""resolved"": ""https://registry.npmjs.org/doctrine/-/doctrine-1.5.0.tgz"",
      ""integrity"": ""sha1-N53Ocw9hZvds76TmcHoVmwLFpvo="",
      ""dev"": true,
      ""requires"": {{
        ""esutils"": ""2.0.2"",
        ""isarray"": ""1.0.0""
      }},
      ""dependencies"": {{
        ""isarray"": {{
          ""version"": ""1.0.0"",
          ""resolved"": ""https://registry.npmjs.org/isarray/-/isarray-1.0.0.tgz"",
          ""integrity"": ""sha1-u5NdSFgsuhaMBoNJV6VKPgcSTxE="",
          ""dev"": true
        }}
      }}
    }},
    ""dom-converter"": {{
      ""version"": ""0.1.4"",
      ""resolved"": ""https://registry.npmjs.org/dom-converter/-/dom-converter-0.1.4.tgz"",
      ""integrity"": ""sha1-pF71cnuJDJv/5tfIduexnLDhfzs="",
      ""dev"": true,
      ""requires"": {{
        ""utila"": ""0.3.3""
      }},
      ""dependencies"": {{
        ""utila"": {{
          ""version"": ""0.3.3"",
          ""resolved"": ""https://registry.npmjs.org/utila/-/utila-0.3.3.tgz"",
          ""integrity"": ""sha1-1+jn1+MJEHCSsF+NloiCTWM6QiY="",
          ""dev"": true
        }}
      }}
    }},
    ""dom-helpers"": {{
      ""version"": ""3.3.1"",
      ""resolved"": ""https://registry.npmjs.org/dom-helpers/-/dom-helpers-3.3.1.tgz"",
      ""integrity"": ""sha512-2Sm+JaYn74OiTM2wHvxJOo3roiq/h25Yi69Fqk269cNUwIXsCvATB6CRSFC9Am/20G2b28hGv/+7NiWydIrPvg==""
    }},
    ""dom-serializer"": {{
      ""version"": ""0.1.0"",
      ""resolved"": ""https://registry.npmjs.org/dom-serializer/-/dom-serializer-0.1.0.tgz"",
      ""integrity"": ""sha1-BzxpdUbOB4DOI75KKOKT5AvDDII="",
      ""dev"": true,
      ""requires"": {{
        ""domelementtype"": ""1.1.3"",
        ""entities"": ""1.1.1""
      }},
      ""dependencies"": {{
        ""domelementtype"": {{
          ""version"": ""1.1.3"",
          ""resolved"": ""https://registry.npmjs.org/domelementtype/-/domelementtype-1.1.3.tgz"",
          ""integrity"": ""sha1-vSh3PiZCiBrsUVRJJCmcXNgiGFs="",
          ""dev"": true
        }}
      }}
    }},
    ""dom-walk"": {{
      ""version"": ""0.1.1"",
      ""resolved"": ""https://registry.npmjs.org/dom-walk/-/dom-walk-0.1.1.tgz"",
      ""integrity"": ""sha1-ZyIm3HTI95mtNTB9+TaroRrNYBg="",
      ""dev"": true
    }},
    ""domain-browser"": {{
      ""version"": ""1.1.7"",
      ""resolved"": ""https://registry.npmjs.org/domain-browser/-/domain-browser-1.1.7.tgz"",
      ""integrity"": ""sha1-hnqksJP6oF8d4IwG9NeyH9+GmLw="",
      ""dev"": true
    }},
    ""domelementtype"": {{
      ""version"": ""1.3.0"",
      ""resolved"": ""https://registry.npmjs.org/domelementtype/-/domelementtype-1.3.0.tgz"",
      ""integrity"": ""sha1-sXrtguirWeUt2cGbF1bg/BhyBMI="",
      ""dev"": true
    }},
    ""domhandler"": {{
      ""version"": ""2.4.1"",
      ""resolved"": ""https://registry.npmjs.org/domhandler/-/domhandler-2.4.1.tgz"",
      ""integrity"": ""sha1-iS5HAAqZvlW783dP/qBWHYh5wlk="",
      ""dev"": true,
      ""requires"": {{
        ""domelementtype"": ""1.3.0""
      }}
    }},
    ""domutils"": {{
      ""version"": ""1.5.1"",
      ""resolved"": ""https://registry.npmjs.org/domutils/-/domutils-1.5.1.tgz"",
      ""integrity"": ""sha1-3NhIiib1Y9YQeeSMn3t+Mjc2gs8="",
      ""dev"": true,
      ""requires"": {{
        ""dom-serializer"": ""0.1.0"",
        ""domelementtype"": ""1.3.0""
      }}
    }},
    ""ecc-jsbn"": {{
      ""version"": ""0.1.1"",
      ""resolved"": ""https://registry.npmjs.org/ecc-jsbn/-/ecc-jsbn-0.1.1.tgz"",
      ""integrity"": ""sha1-D8c6ntXw1Tw4GTOYUj735UN3dQU="",
      ""dev"": true,
      ""optional"": true,
      ""requires"": {{
        ""jsbn"": ""0.1.1""
      }}
    }},
    ""ee-first"": {{
      ""version"": ""1.1.1"",
      ""resolved"": ""https://registry.npmjs.org/ee-first/-/ee-first-1.1.1.tgz"",
      ""integrity"": ""sha1-WQxhFWsK4vTwJVcyoViyZrxWsh0="",
      ""dev"": true
    }},
    ""ejs"": {{
      ""version"": ""2.5.7"",
      ""resolved"": ""https://registry.npmjs.org/ejs/-/ejs-2.5.7.tgz"",
      ""integrity"": ""sha1-zIcsFoiArjxxiXYv1f/ACJbJUYo="",
      ""dev"": true
    }},
    ""electron-releases"": {{
      ""version"": ""2.1.0"",
      ""resolved"": ""https://registry.npmjs.org/electron-releases/-/electron-releases-2.1.0.tgz"",
      ""integrity"": ""sha512-cyKFD1bTE/UgULXfaueIN1k5EPFzs+FRc/rvCY5tIynefAPqopQEgjr0EzY+U3Dqrk/G4m9tXSPuZ77v6dL/Rw=="",
      ""dev"": true
    }},
    ""electron-to-chromium"": {{
      ""version"": ""1.3.30"",
      ""resolved"": ""https://registry.npmjs.org/electron-to-chromium/-/electron-to-chromium-1.3.30.tgz"",
      ""integrity"": ""sha512-zx1Prv7kYLfc4OA60FhxGbSo4qrEjgSzpo1/37i7l9ltXPYOoQBtjQxY9KmsgfHnBxHlBGXwLlsbt/gub1w5lw=="",
      ""dev"": true,
      ""requires"": {{
        ""electron-releases"": ""2.1.0""
      }}
    }},
    ""elliptic"": {{
      ""version"": ""6.4.0"",
      ""resolved"": ""https://registry.npmjs.org/elliptic/-/elliptic-6.4.0.tgz"",
      ""integrity"": ""sha1-ysmvh2LIWDYYcAPI3+GT5eLq5d8="",
      ""dev"": true,
      ""requires"": {{
        ""bn.js"": ""4.11.8"",
        ""brorand"": ""1.1.0"",
        ""hash.js"": ""1.1.3"",
        ""hmac-drbg"": ""1.0.1"",
        ""inherits"": ""2.0.3"",
        ""minimalistic-assert"": ""1.0.0"",
        ""minimalistic-crypto-utils"": ""1.0.1""
      }}
    }},
    ""emojis-list"": {{
      ""version"": ""2.1.0"",
      ""resolved"": ""https://registry.npmjs.org/emojis-list/-/emojis-list-2.1.0.tgz"",
      ""integrity"": ""sha1-TapNnbAPmBmIDHn6RXrlsJof04k="",
      ""dev"": true
    }},
    ""encodeurl"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/encodeurl/-/encodeurl-1.0.1.tgz"",
      ""integrity"": ""sha1-eePVhlU0aQn+bw9Fpd5oEDspTSA="",
      ""dev"": true
    }},
    ""encoding"": {{
      ""version"": ""0.1.12"",
      ""resolved"": ""https://registry.npmjs.org/encoding/-/encoding-0.1.12.tgz"",
      ""integrity"": ""sha1-U4tm8+5izRq1HsMjgp0flIDHS+s="",
      ""requires"": {{
        ""iconv-lite"": ""0.4.19""
      }}
    }},
    ""enhanced-resolve"": {{
      ""version"": ""3.4.1"",
      ""resolved"": ""https://registry.npmjs.org/enhanced-resolve/-/enhanced-resolve-3.4.1.tgz"",
      ""integrity"": ""sha1-BCHjOf1xQZs9oT0Smzl5BAIwR24="",
      ""dev"": true,
      ""requires"": {{
        ""graceful-fs"": ""4.1.11"",
        ""memory-fs"": ""0.4.1"",
        ""object-assign"": ""4.1.1"",
        ""tapable"": ""0.2.8""
      }}
    }},
    ""entities"": {{
      ""version"": ""1.1.1"",
      ""resolved"": ""https://registry.npmjs.org/entities/-/entities-1.1.1.tgz"",
      ""integrity"": ""sha1-blwtClYhtdra7O+AuQ7ftc13cvA="",
      ""dev"": true
    }},
    ""enzyme"": {{
      ""version"": ""2.9.1"",
      ""resolved"": ""https://registry.npmjs.org/enzyme/-/enzyme-2.9.1.tgz"",
      ""integrity"": ""sha1-B9XOaRJBJA+4F78sSxjW5TAkDfY="",
      ""dev"": true,
      ""requires"": {{
        ""cheerio"": ""0.22.0"",
        ""function.prototype.name"": ""1.1.0"",
        ""is-subset"": ""0.1.1"",
        ""lodash"": ""4.17.4"",
        ""object-is"": ""1.0.1"",
        ""object.assign"": ""4.1.0"",
        ""object.entries"": ""1.0.4"",
        ""object.values"": ""1.0.4"",
        ""prop-types"": ""15.6.0"",
        ""uuid"": ""3.1.0""
      }}
    }},
    ""errno"": {{
      ""version"": ""0.1.6"",
      ""resolved"": ""https://registry.npmjs.org/errno/-/errno-0.1.6.tgz"",
      ""integrity"": ""sha512-IsORQDpaaSwcDP4ZZnHxgE85werpo34VYn1Ud3mq+eUsF593faR8oCZNXrROVkpFu2TsbrNhHin0aUrTsQ9vNw=="",
      ""dev"": true,
      ""requires"": {{
        ""prr"": ""1.0.1""
      }}
    }},
    ""error-ex"": {{
      ""version"": ""1.3.1"",
      ""resolved"": ""https://registry.npmjs.org/error-ex/-/error-ex-1.3.1.tgz"",
      ""integrity"": ""sha1-+FWobOYa3E6GIcPNoh56dhLDqNw="",
      ""dev"": true,
      ""requires"": {{
        ""is-arrayish"": ""0.2.1""
      }}
    }},
    ""error-stack-parser"": {{
      ""version"": ""1.3.6"",
      ""resolved"": ""https://registry.npmjs.org/error-stack-parser/-/error-stack-parser-1.3.6.tgz"",
      ""integrity"": ""sha1-4Oc7k+QXE40c18C3RrGkoUhUwpI="",
      ""dev"": true,
      ""requires"": {{
        ""stackframe"": ""0.3.1""
      }}
    }},
    ""es-abstract"": {{
      ""version"": ""1.10.0"",
      ""resolved"": ""https://registry.npmjs.org/es-abstract/-/es-abstract-1.10.0.tgz"",
      ""integrity"": ""sha512-/uh/DhdqIOSkAWifU+8nG78vlQxdLckUdI/sPgy0VhuXi2qJ7T8czBmqIYtLQVpCIFYafChnsRsB5pyb1JdmCQ=="",
      ""dev"": true,
      ""requires"": {{
        ""es-to-primitive"": ""1.1.1"",
        ""function-bind"": ""1.1.1"",
        ""has"": ""1.0.1"",
        ""is-callable"": ""1.1.3"",
        ""is-regex"": ""1.0.4""
      }}
    }},
    ""es-to-primitive"": {{
      ""version"": ""1.1.1"",
      ""resolved"": ""https://registry.npmjs.org/es-to-primitive/-/es-to-primitive-1.1.1.tgz"",
      ""integrity"": ""sha1-RTVSSKiJeQNLZ5Lhm7gfK3l13Q0="",
      ""dev"": true,
      ""requires"": {{
        ""is-callable"": ""1.1.3"",
        ""is-date-object"": ""1.0.1"",
        ""is-symbol"": ""1.0.1""
      }}
    }},
    ""es5-ext"": {{
      ""version"": ""0.10.37"",
      ""resolved"": ""https://registry.npmjs.org/es5-ext/-/es5-ext-0.10.37.tgz"",
      ""integrity"": ""sha1-DudB0Ui4AGm6J9AgOTdWryV978M="",
      ""dev"": true,
      ""requires"": {{
        ""es6-iterator"": ""2.0.3"",
        ""es6-symbol"": ""3.1.1""
      }}
    }},
    ""es6-iterator"": {{
      ""version"": ""2.0.3"",
      ""resolved"": ""https://registry.npmjs.org/es6-iterator/-/es6-iterator-2.0.3.tgz"",
      ""integrity"": ""sha1-p96IkUGgWpSwhUQDstCg+/qY87c="",
      ""dev"": true,
      ""requires"": {{
        ""d"": ""1.0.0"",
        ""es5-ext"": ""0.10.37"",
        ""es6-symbol"": ""3.1.1""
      }}
    }},
    ""es6-map"": {{
      ""version"": ""0.1.5"",
      ""resolved"": ""https://registry.npmjs.org/es6-map/-/es6-map-0.1.5.tgz"",
      ""integrity"": ""sha1-kTbgUD3MBqMBaQ8LsU/042TpSfA="",
      ""dev"": true,
      ""requires"": {{
        ""d"": ""1.0.0"",
        ""es5-ext"": ""0.10.37"",
        ""es6-iterator"": ""2.0.3"",
        ""es6-set"": ""0.1.5"",
        ""es6-symbol"": ""3.1.1"",
        ""event-emitter"": ""0.3.5""
      }}
    }},
    ""es6-set"": {{
      ""version"": ""0.1.5"",
      ""resolved"": ""https://registry.npmjs.org/es6-set/-/es6-set-0.1.5.tgz"",
      ""integrity"": ""sha1-0rPsXU2ADO2BjbU40ol02wpzzLE="",
      ""dev"": true,
      ""requires"": {{
        ""d"": ""1.0.0"",
        ""es5-ext"": ""0.10.37"",
        ""es6-iterator"": ""2.0.3"",
        ""es6-symbol"": ""3.1.1"",
        ""event-emitter"": ""0.3.5""
      }}
    }},
    ""es6-symbol"": {{
      ""version"": ""3.1.1"",
      ""resolved"": ""https://registry.npmjs.org/es6-symbol/-/es6-symbol-3.1.1.tgz"",
      ""integrity"": ""sha1-vwDvT9q2uhtG7Le2KbTH7VcVzHc="",
      ""dev"": true,
      ""requires"": {{
        ""d"": ""1.0.0"",
        ""es5-ext"": ""0.10.37""
      }}
    }},
    ""es6-weak-map"": {{
      ""version"": ""2.0.2"",
      ""resolved"": ""https://registry.npmjs.org/es6-weak-map/-/es6-weak-map-2.0.2.tgz"",
      ""integrity"": ""sha1-XjqzIlH/0VOKH45f+hNXdy+S2W8="",
      ""dev"": true,
      ""requires"": {{
        ""d"": ""1.0.0"",
        ""es5-ext"": ""0.10.37"",
        ""es6-iterator"": ""2.0.3"",
        ""es6-symbol"": ""3.1.1""
      }}
    }},
    ""escape-html"": {{
      ""version"": ""1.0.3"",
      ""resolved"": ""https://registry.npmjs.org/escape-html/-/escape-html-1.0.3.tgz"",
      ""integrity"": ""sha1-Aljq5NPQwJdN4cFpGI7wBR0dGYg="",
      ""dev"": true
    }},
    ""escape-string-regexp"": {{
      ""version"": ""1.0.5"",
      ""resolved"": ""https://registry.npmjs.org/escape-string-regexp/-/escape-string-regexp-1.0.5.tgz"",
      ""integrity"": ""sha1-G2HAViGQqN/2rjuyzwIAyhMLhtQ="",
      ""dev"": true
    }},
    ""escodegen"": {{
      ""version"": ""1.9.0"",
      ""resolved"": ""https://registry.npmjs.org/escodegen/-/escodegen-1.9.0.tgz"",
      ""integrity"": ""sha512-v0MYvNQ32bzwoG2OSFzWAkuahDQHK92JBN0pTAALJ4RIxEZe766QJPDR8Hqy7XNUy5K3fnVL76OqYAdc4TZEIw=="",
      ""dev"": true,
      ""requires"": {{
        ""esprima"": ""3.1.3"",
        ""estraverse"": ""4.2.0"",
        ""esutils"": ""2.0.2"",
        ""optionator"": ""0.8.2"",
        ""source-map"": ""0.5.7""
      }},
      ""dependencies"": {{
        ""esprima"": {{
          ""version"": ""3.1.3"",
          ""resolved"": ""https://registry.npmjs.org/esprima/-/esprima-3.1.3.tgz"",
          ""integrity"": ""sha1-/cpRzuYTOJXjyI1TXOSdv/YqRjM="",
          ""dev"": true
        }},
        ""source-map"": {{
          ""version"": ""0.5.7"",
          ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.5.7.tgz"",
          ""integrity"": ""sha1-igOdLRAh0i0eoUyA2OpGi6LvP8w="",
          ""dev"": true,
          ""optional"": true
        }}
      }}
    }},
    ""escope"": {{
      ""version"": ""3.6.0"",
      ""resolved"": ""https://registry.npmjs.org/escope/-/escope-3.6.0.tgz"",
      ""integrity"": ""sha1-4Bl16BJ4GhY6ba392AOY3GTIicM="",
      ""dev"": true,
      ""requires"": {{
        ""es6-map"": ""0.1.5"",
        ""es6-weak-map"": ""2.0.2"",
        ""esrecurse"": ""4.2.0"",
        ""estraverse"": ""4.2.0""
      }}
    }},
    ""eslint"": {{
      ""version"": ""2.13.1"",
      ""resolved"": ""https://registry.npmjs.org/eslint/-/eslint-2.13.1.tgz"",
      ""integrity"": ""sha1-5MyPoPAJ+4KaquI4VaKTYL4fbBE="",
      ""dev"": true,
      ""requires"": {{
        ""chalk"": ""1.1.3"",
        ""concat-stream"": ""1.6.0"",
        ""debug"": ""2.6.9"",
        ""doctrine"": ""1.5.0"",
        ""es6-map"": ""0.1.5"",
        ""escope"": ""3.6.0"",
        ""espree"": ""3.5.2"",
        ""estraverse"": ""4.2.0"",
        ""esutils"": ""2.0.2"",
        ""file-entry-cache"": ""1.3.1"",
        ""glob"": ""7.1.2"",
        ""globals"": ""9.18.0"",
        ""ignore"": ""3.3.7"",
        ""imurmurhash"": ""0.1.4"",
        ""inquirer"": ""0.12.0"",
        ""is-my-json-valid"": ""2.17.1"",
        ""is-resolvable"": ""1.0.1"",
        ""js-yaml"": ""3.7.0"",
        ""json-stable-stringify"": ""1.0.1"",
        ""levn"": ""0.3.0"",
        ""lodash"": ""4.17.4"",
        ""mkdirp"": ""0.5.1"",
        ""optionator"": ""0.8.2"",
        ""path-is-absolute"": ""1.0.1"",
        ""path-is-inside"": ""1.0.2"",
        ""pluralize"": ""1.2.1"",
        ""progress"": ""1.1.8"",
        ""require-uncached"": ""1.0.3"",
        ""shelljs"": ""0.6.1"",
        ""strip-json-comments"": ""1.0.4"",
        ""table"": ""3.8.3"",
        ""text-table"": ""0.2.0"",
        ""user-home"": ""2.0.0""
      }},
      ""dependencies"": {{
        ""glob"": {{
          ""version"": ""7.1.2"",
          ""resolved"": ""https://registry.npmjs.org/glob/-/glob-7.1.2.tgz"",
          ""integrity"": ""sha512-MJTUg1kjuLeQCJ+ccE4Vpa6kKVXkPYJ2mOCQyUuKLcLQsdrMCpBPUi8qVE6+YuaJkozeA9NusTAw3hLr8Xe5EQ=="",
          ""dev"": true,
          ""requires"": {{
            ""fs.realpath"": ""1.0.0"",
            ""inflight"": ""1.0.6"",
            ""inherits"": ""2.0.3"",
            ""minimatch"": ""3.0.4"",
            ""once"": ""1.4.0"",
            ""path-is-absolute"": ""1.0.1""
          }}
        }}
      }}
    }},
    ""eslint-config-airbnb"": {{
      ""version"": ""3.1.0"",
      ""resolved"": ""https://registry.npmjs.org/eslint-config-airbnb/-/eslint-config-airbnb-3.1.0.tgz"",
      ""integrity"": ""sha1-jQMLS4DaFxamcORmovr+RvZ0ZvQ="",
      ""dev"": true
    }},
    ""eslint-plugin-react"": {{
      ""version"": ""3.16.1"",
      ""resolved"": ""https://registry.npmjs.org/eslint-plugin-react/-/eslint-plugin-react-3.16.1.tgz"",
      ""integrity"": ""sha1-Ji2Wt318SkKvgJpzwOUnpYYSKTw="",
      ""dev"": true
    }},
    ""espree"": {{
      ""version"": ""3.5.2"",
      ""resolved"": ""https://registry.npmjs.org/espree/-/espree-3.5.2.tgz"",
      ""integrity"": ""sha512-sadKeYwaR/aJ3stC2CdvgXu1T16TdYN+qwCpcWbMnGJ8s0zNWemzrvb2GbD4OhmJ/fwpJjudThAlLobGbWZbCQ=="",
      ""dev"": true,
      ""requires"": {{
        ""acorn"": ""5.3.0"",
        ""acorn-jsx"": ""3.0.1""
      }},
      ""dependencies"": {{
        ""acorn"": {{
          ""version"": ""5.3.0"",
          ""resolved"": ""https://registry.npmjs.org/acorn/-/acorn-5.3.0.tgz"",
          ""integrity"": ""sha512-Yej+zOJ1Dm/IMZzzj78OntP/r3zHEaKcyNoU2lAaxPtrseM6rF0xwqoz5Q5ysAiED9hTjI2hgtvLXitlCN1/Ug=="",
          ""dev"": true
        }}
      }}
    }},
    ""esrecurse"": {{
      ""version"": ""4.2.0"",
      ""resolved"": ""https://registry.npmjs.org/esrecurse/-/esrecurse-4.2.0.tgz"",
      ""integrity"": ""sha1-+pVo2Y04I/mkHZHpAtyrnqblsWM="",
      ""dev"": true,
      ""requires"": {{
        ""estraverse"": ""4.2.0"",
        ""object-assign"": ""4.1.1""
      }}
    }},
    ""estraverse"": {{
      ""version"": ""4.2.0"",
      ""resolved"": ""https://registry.npmjs.org/estraverse/-/estraverse-4.2.0.tgz"",
      ""integrity"": ""sha1-De4/7TH81GlhjOc0IJn8GvoL2xM="",
      ""dev"": true
    }},
    ""esutils"": {{
      ""version"": ""2.0.2"",
      ""resolved"": ""https://registry.npmjs.org/esutils/-/esutils-2.0.2.tgz"",
      ""integrity"": ""sha1-Cr9PHKpbyx96nYrMbepPqqBLrJs="",
      ""dev"": true
    }},
    ""etag"": {{
      ""version"": ""1.8.1"",
      ""resolved"": ""https://registry.npmjs.org/etag/-/etag-1.8.1.tgz"",
      ""integrity"": ""sha1-Qa4u62XvpiJorr/qg6x9eSmbCIc="",
      ""dev"": true
    }},
    ""event-emitter"": {{
      ""version"": ""0.3.5"",
      ""resolved"": ""https://registry.npmjs.org/event-emitter/-/event-emitter-0.3.5.tgz"",
      ""integrity"": ""sha1-34xp7vFkeSPHFXuc6DhAYQsCzDk="",
      ""dev"": true,
      ""requires"": {{
        ""d"": ""1.0.0"",
        ""es5-ext"": ""0.10.37""
      }}
    }},
    ""eventemitter3"": {{
      ""version"": ""1.2.0"",
      ""resolved"": ""https://registry.npmjs.org/eventemitter3/-/eventemitter3-1.2.0.tgz"",
      ""integrity"": ""sha1-HIaZHYFq0eUEdQ5zh0Ik7PO+xQg="",
      ""dev"": true
    }},
    ""events"": {{
      ""version"": ""1.1.1"",
      ""resolved"": ""https://registry.npmjs.org/events/-/events-1.1.1.tgz"",
      ""integrity"": ""sha1-nr23Y1rQmccNzEwqH1AEKI6L2SQ="",
      ""dev"": true
    }},
    ""eventsource"": {{
      ""version"": ""0.1.6"",
      ""resolved"": ""https://registry.npmjs.org/eventsource/-/eventsource-0.1.6.tgz"",
      ""integrity"": ""sha1-Cs7ehJ7X3RzMMsgRuxG5RNTykjI="",
      ""dev"": true,
      ""requires"": {{
        ""original"": ""1.0.0""
      }}
    }},
    ""evp_bytestokey"": {{
      ""version"": ""1.0.3"",
      ""resolved"": ""https://registry.npmjs.org/evp_bytestokey/-/evp_bytestokey-1.0.3.tgz"",
      ""integrity"": ""sha512-/f2Go4TognH/KvCISP7OUsHn85hT9nUkxxA9BEWxFn+Oj9o8ZNLm/40hdlgSLyuOimsrTKLUMEorQexp/aPQeA=="",
      ""dev"": true,
      ""requires"": {{
        ""md5.js"": ""1.3.4"",
        ""safe-buffer"": ""5.1.1""
      }}
    }},
    ""exec-sh"": {{
      ""version"": ""0.2.1"",
      ""resolved"": ""https://registry.npmjs.org/exec-sh/-/exec-sh-0.2.1.tgz"",
      ""integrity"": ""sha512-aLt95pexaugVtQerpmE51+4QfWrNc304uez7jvj6fWnN8GeEHpttB8F36n8N7uVhUMbH/1enbxQ9HImZ4w/9qg=="",
      ""dev"": true,
      ""requires"": {{
        ""merge"": ""1.2.0""
      }}
    }},
    ""exit-hook"": {{
      ""version"": ""1.1.1"",
      ""resolved"": ""https://registry.npmjs.org/exit-hook/-/exit-hook-1.1.1.tgz"",
      ""integrity"": ""sha1-8FyiM7SMBdVP/wd2XfhQfpXAL/g="",
      ""dev"": true
    }},
    ""expand-brackets"": {{
      ""version"": ""0.1.5"",
      ""resolved"": ""https://registry.npmjs.org/expand-brackets/-/expand-brackets-0.1.5.tgz"",
      ""integrity"": ""sha1-3wcoTjQqgHzXM6xa9yQR5YHRF3s="",
      ""dev"": true,
      ""requires"": {{
        ""is-posix-bracket"": ""0.1.1""
      }}
    }},
    ""expand-range"": {{
      ""version"": ""1.8.2"",
      ""resolved"": ""https://registry.npmjs.org/expand-range/-/expand-range-1.8.2.tgz"",
      ""integrity"": ""sha1-opnv/TNf4nIeuujiV+x5ZE/IUzc="",
      ""dev"": true,
      ""requires"": {{
        ""fill-range"": ""2.2.3""
      }}
    }},
    ""expect"": {{
      ""version"": ""21.2.1"",
      ""resolved"": ""https://registry.npmjs.org/expect/-/expect-21.2.1.tgz"",
      ""integrity"": ""sha512-orfQQqFRTX0jH7znRIGi8ZMR8kTNpXklTTz8+HGTpmTKZo3Occ6JNB5FXMb8cRuiiC/GyDqsr30zUa66ACYlYw=="",
      ""dev"": true,
      ""requires"": {{
        ""ansi-styles"": ""3.2.0"",
        ""jest-diff"": ""21.2.1"",
        ""jest-get-type"": ""21.2.0"",
        ""jest-matcher-utils"": ""21.2.1"",
        ""jest-message-util"": ""21.2.1"",
        ""jest-regex-util"": ""21.2.0""
      }},
      ""dependencies"": {{
        ""ansi-styles"": {{
          ""version"": ""3.2.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-styles/-/ansi-styles-3.2.0.tgz"",
          ""integrity"": ""sha512-NnSOmMEYtVR2JVMIGTzynRkkaxtiq1xnFBcdQD/DnNCYPoEPsVJhM98BDyaoNOQIi7p4okdi3E27eN7GQbsUug=="",
          ""dev"": true,
          ""requires"": {{
            ""color-convert"": ""1.9.1""
          }}
        }}
      }}
    }},
    ""exports-loader"": {{
      ""version"": ""0.6.4"",
      ""resolved"": ""https://registry.npmjs.org/exports-loader/-/exports-loader-0.6.4.tgz"",
      ""integrity"": ""sha1-1w/GEhl1s1/BKDDPUnVL4nQPyIY="",
      ""dev"": true,
      ""requires"": {{
        ""loader-utils"": ""1.1.0"",
        ""source-map"": ""0.5.7""
      }},
      ""dependencies"": {{
        ""loader-utils"": {{
          ""version"": ""1.1.0"",
          ""resolved"": ""https://registry.npmjs.org/loader-utils/-/loader-utils-1.1.0.tgz"",
          ""integrity"": ""sha1-yYrvSIvM7aL/teLeZG1qdUQp9c0="",
          ""dev"": true,
          ""requires"": {{
            ""big.js"": ""3.2.0"",
            ""emojis-list"": ""2.1.0"",
            ""json5"": ""0.5.1""
          }}
        }},
        ""source-map"": {{
          ""version"": ""0.5.7"",
          ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.5.7.tgz"",
          ""integrity"": ""sha1-igOdLRAh0i0eoUyA2OpGi6LvP8w="",
          ""dev"": true
        }}
      }}
    }},
    ""express"": {{
      ""version"": ""4.16.2"",
      ""resolved"": ""https://registry.npmjs.org/express/-/express-4.16.2.tgz"",
      ""integrity"": ""sha1-41xt/i1kt9ygpc1PIXgb4ymeB2w="",
      ""dev"": true,
      ""requires"": {{
        ""accepts"": ""1.3.4"",
        ""array-flatten"": ""1.1.1"",
        ""body-parser"": ""1.18.2"",
        ""content-disposition"": ""0.5.2"",
        ""content-type"": ""1.0.4"",
        ""cookie"": ""0.3.1"",
        ""cookie-signature"": ""1.0.6"",
        ""debug"": ""2.6.9"",
        ""depd"": ""1.1.1"",
        ""encodeurl"": ""1.0.1"",
        ""escape-html"": ""1.0.3"",
        ""etag"": ""1.8.1"",
        ""finalhandler"": ""1.1.0"",
        ""fresh"": ""0.5.2"",
        ""merge-descriptors"": ""1.0.1"",
        ""methods"": ""1.1.2"",
        ""on-finished"": ""2.3.0"",
        ""parseurl"": ""1.3.2"",
        ""path-to-regexp"": ""0.1.7"",
        ""proxy-addr"": ""2.0.2"",
        ""qs"": ""6.5.1"",
        ""range-parser"": ""1.2.0"",
        ""safe-buffer"": ""5.1.1"",
        ""send"": ""0.16.1"",
        ""serve-static"": ""1.13.1"",
        ""setprototypeof"": ""1.1.0"",
        ""statuses"": ""1.3.1"",
        ""type-is"": ""1.6.15"",
        ""utils-merge"": ""1.0.1"",
        ""vary"": ""1.1.2""
      }},
      ""dependencies"": {{
        ""path-to-regexp"": {{
          ""version"": ""0.1.7"",
          ""resolved"": ""https://registry.npmjs.org/path-to-regexp/-/path-to-regexp-0.1.7.tgz"",
          ""integrity"": ""sha1-32BBeABfUi8V60SQ5yR6G/qmf4w="",
          ""dev"": true
        }}
      }}
    }},
    ""extend"": {{
      ""version"": ""3.0.1"",
      ""resolved"": ""https://registry.npmjs.org/extend/-/extend-3.0.1.tgz"",
      ""integrity"": ""sha1-p1Xqe8Gt/MWjHOfnYtuq3F5jZEQ="",
      ""dev"": true
    }},
    ""extglob"": {{
      ""version"": ""0.3.2"",
      ""resolved"": ""https://registry.npmjs.org/extglob/-/extglob-0.3.2.tgz"",
      ""integrity"": ""sha1-Lhj/PS9JqydlzskCPwEdqo2DSaE="",
      ""dev"": true,
      ""requires"": {{
        ""is-extglob"": ""1.0.0""
      }}
    }},
    ""extract-text-webpack-plugin"": {{
      ""version"": ""2.1.2"",
      ""resolved"": ""https://registry.npmjs.org/extract-text-webpack-plugin/-/extract-text-webpack-plugin-2.1.2.tgz"",
      ""integrity"": ""sha1-dW7076gVXDaBgz+8NNpTuUF0bWw="",
      ""dev"": true,
      ""requires"": {{
        ""async"": ""2.6.0"",
        ""loader-utils"": ""1.1.0"",
        ""schema-utils"": ""0.3.0"",
        ""webpack-sources"": ""1.1.0""
      }},
      ""dependencies"": {{
        ""loader-utils"": {{
          ""version"": ""1.1.0"",
          ""resolved"": ""https://registry.npmjs.org/loader-utils/-/loader-utils-1.1.0.tgz"",
          ""integrity"": ""sha1-yYrvSIvM7aL/teLeZG1qdUQp9c0="",
          ""dev"": true,
          ""requires"": {{
            ""big.js"": ""3.2.0"",
            ""emojis-list"": ""2.1.0"",
            ""json5"": ""0.5.1""
          }}
        }}
      }}
    }},
    ""extsprintf"": {{
      ""version"": ""1.3.0"",
      ""resolved"": ""https://registry.npmjs.org/extsprintf/-/extsprintf-1.3.0.tgz"",
      ""integrity"": ""sha1-lpGEQOMEGnpBT4xS48V06zw+HgU="",
      ""dev"": true
    }},
    ""fast-deep-equal"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/fast-deep-equal/-/fast-deep-equal-1.0.0.tgz"",
      ""integrity"": ""sha1-liVqO8l1WV6zbYLpkp0GDYk0Of8="",
      ""dev"": true
    }},
    ""fast-json-stable-stringify"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/fast-json-stable-stringify/-/fast-json-stable-stringify-2.0.0.tgz"",
      ""integrity"": ""sha1-1RQsDK7msRifh9OnYREGT4bIu/I="",
      ""dev"": true
    }},
    ""fast-levenshtein"": {{
      ""version"": ""2.0.6"",
      ""resolved"": ""https://registry.npmjs.org/fast-levenshtein/-/fast-levenshtein-2.0.6.tgz"",
      ""integrity"": ""sha1-PYpcZog6FqMMqGQ+hR8Zuqd5eRc="",
      ""dev"": true
    }},
    ""fastparse"": {{
      ""version"": ""1.1.1"",
      ""resolved"": ""https://registry.npmjs.org/fastparse/-/fastparse-1.1.1.tgz"",
      ""integrity"": ""sha1-0eJkOzipTXWDtHkGDmxK/8lAcfg="",
      ""dev"": true
    }},
    ""faye-websocket"": {{
      ""version"": ""0.10.0"",
      ""resolved"": ""https://registry.npmjs.org/faye-websocket/-/faye-websocket-0.10.0.tgz"",
      ""integrity"": ""sha1-TkkvjQTftviQA1B/btvy1QHnxvQ="",
      ""dev"": true,
      ""requires"": {{
        ""websocket-driver"": ""0.7.0""
      }}
    }},
    ""fb-watchman"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/fb-watchman/-/fb-watchman-2.0.0.tgz"",
      ""integrity"": ""sha1-VOmr99+i8mzZsWNsWIwa/AXeXVg="",
      ""dev"": true,
      ""requires"": {{
        ""bser"": ""2.0.0""
      }}
    }},
    ""fbjs"": {{
      ""version"": ""0.8.16"",
      ""resolved"": ""https://registry.npmjs.org/fbjs/-/fbjs-0.8.16.tgz"",
      ""integrity"": ""sha1-XmdDL1UNxBtXK/VYR7ispk5TN9s="",
      ""requires"": {{
        ""core-js"": ""1.2.7"",
        ""isomorphic-fetch"": ""2.2.1"",
        ""loose-envify"": ""1.3.1"",
        ""object-assign"": ""4.1.1"",
        ""promise"": ""7.3.1"",
        ""setimmediate"": ""1.0.5"",
        ""ua-parser-js"": ""0.7.17""
      }}
    }},
    ""figures"": {{
      ""version"": ""1.7.0"",
      ""resolved"": ""https://registry.npmjs.org/figures/-/figures-1.7.0.tgz"",
      ""integrity"": ""sha1-y+Hjr/zxzUS4DK3+0o3Hk6lwHS4="",
      ""dev"": true,
      ""requires"": {{
        ""escape-string-regexp"": ""1.0.5"",
        ""object-assign"": ""4.1.1""
      }}
    }},
    ""file-entry-cache"": {{
      ""version"": ""1.3.1"",
      ""resolved"": ""https://registry.npmjs.org/file-entry-cache/-/file-entry-cache-1.3.1.tgz"",
      ""integrity"": ""sha1-RMYepgeuS+nBQC9B9EJwy/4zT/g="",
      ""dev"": true,
      ""requires"": {{
        ""flat-cache"": ""1.3.0"",
        ""object-assign"": ""4.1.1""
      }}
    }},
    ""file-loader"": {{
      ""version"": ""0.8.5"",
      ""resolved"": ""https://registry.npmjs.org/file-loader/-/file-loader-0.8.5.tgz"",
      ""integrity"": ""sha1-knXQMf54DyfUf19K8CvUNxPMFRs="",
      ""dev"": true,
      ""requires"": {{
        ""loader-utils"": ""0.2.17""
      }}
    }},
    ""filename-regex"": {{
      ""version"": ""2.0.1"",
      ""resolved"": ""https://registry.npmjs.org/filename-regex/-/filename-regex-2.0.1.tgz"",
      ""integrity"": ""sha1-wcS5vuPglyXdsQa3XB4wH+LxiyY="",
      ""dev"": true
    }},
    ""fileset"": {{
      ""version"": ""2.0.3"",
      ""resolved"": ""https://registry.npmjs.org/fileset/-/fileset-2.0.3.tgz"",
      ""integrity"": ""sha1-jnVIqW08wjJ+5eZ0FocjozO7oqA="",
      ""dev"": true,
      ""requires"": {{
        ""glob"": ""7.1.2"",
        ""minimatch"": ""3.0.4""
      }},
      ""dependencies"": {{
        ""glob"": {{
          ""version"": ""7.1.2"",
          ""resolved"": ""https://registry.npmjs.org/glob/-/glob-7.1.2.tgz"",
          ""integrity"": ""sha512-MJTUg1kjuLeQCJ+ccE4Vpa6kKVXkPYJ2mOCQyUuKLcLQsdrMCpBPUi8qVE6+YuaJkozeA9NusTAw3hLr8Xe5EQ=="",
          ""dev"": true,
          ""requires"": {{
            ""fs.realpath"": ""1.0.0"",
            ""inflight"": ""1.0.6"",
            ""inherits"": ""2.0.3"",
            ""minimatch"": ""3.0.4"",
            ""once"": ""1.4.0"",
            ""path-is-absolute"": ""1.0.1""
          }}
        }}
      }}
    }},
    ""fill-range"": {{
      ""version"": ""2.2.3"",
      ""resolved"": ""https://registry.npmjs.org/fill-range/-/fill-range-2.2.3.tgz"",
      ""integrity"": ""sha1-ULd9/X5Gm8dJJHCWNpn+eoSFpyM="",
      ""dev"": true,
      ""requires"": {{
        ""is-number"": ""2.1.0"",
        ""isobject"": ""2.1.0"",
        ""randomatic"": ""1.1.7"",
        ""repeat-element"": ""1.1.2"",
        ""repeat-string"": ""1.6.1""
      }},
      ""dependencies"": {{
        ""isarray"": {{
          ""version"": ""1.0.0"",
          ""resolved"": ""https://registry.npmjs.org/isarray/-/isarray-1.0.0.tgz"",
          ""integrity"": ""sha1-u5NdSFgsuhaMBoNJV6VKPgcSTxE="",
          ""dev"": true
        }},
        ""isobject"": {{
          ""version"": ""2.1.0"",
          ""resolved"": ""https://registry.npmjs.org/isobject/-/isobject-2.1.0.tgz"",
          ""integrity"": ""sha1-8GVWEJaj8dou9GJy+BXIQNh+DIk="",
          ""dev"": true,
          ""requires"": {{
            ""isarray"": ""1.0.0""
          }}
        }}
      }}
    }},
    ""finalhandler"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/finalhandler/-/finalhandler-1.1.0.tgz"",
      ""integrity"": ""sha1-zgtoVbRYU+eRsvzGgARtiCU91/U="",
      ""dev"": true,
      ""requires"": {{
        ""debug"": ""2.6.9"",
        ""encodeurl"": ""1.0.1"",
        ""escape-html"": ""1.0.3"",
        ""on-finished"": ""2.3.0"",
        ""parseurl"": ""1.3.2"",
        ""statuses"": ""1.3.1"",
        ""unpipe"": ""1.0.0""
      }}
    }},
    ""find-cache-dir"": {{
      ""version"": ""0.1.1"",
      ""resolved"": ""https://registry.npmjs.org/find-cache-dir/-/find-cache-dir-0.1.1.tgz"",
      ""integrity"": ""sha1-yN765XyKUqinhPnjHFfHQumToLk="",
      ""dev"": true,
      ""requires"": {{
        ""commondir"": ""1.0.1"",
        ""mkdirp"": ""0.5.1"",
        ""pkg-dir"": ""1.0.0""
      }}
    }},
    ""find-up"": {{
      ""version"": ""1.1.2"",
      ""resolved"": ""https://registry.npmjs.org/find-up/-/find-up-1.1.2.tgz"",
      ""integrity"": ""sha1-ay6YIrGizgpgq2TWEOzK1TyyTQ8="",
      ""dev"": true,
      ""requires"": {{
        ""path-exists"": ""2.1.0"",
        ""pinkie-promise"": ""2.0.1""
      }}
    }},
    ""findup"": {{
      ""version"": ""0.1.5"",
      ""resolved"": ""https://registry.npmjs.org/findup/-/findup-0.1.5.tgz"",
      ""integrity"": ""sha1-itkpozk7rGJ5V6fl3kYjsGsOLOs="",
      ""dev"": true,
      ""requires"": {{
        ""colors"": ""0.6.2"",
        ""commander"": ""2.1.0""
      }},
      ""dependencies"": {{
        ""colors"": {{
          ""version"": ""0.6.2"",
          ""resolved"": ""https://registry.npmjs.org/colors/-/colors-0.6.2.tgz"",
          ""integrity"": ""sha1-JCP+ZnisDF2uiFLl0OW+CMmXq8w="",
          ""dev"": true
        }}
      }}
    }},
    ""flat-cache"": {{
      ""version"": ""1.3.0"",
      ""resolved"": ""https://registry.npmjs.org/flat-cache/-/flat-cache-1.3.0.tgz"",
      ""integrity"": ""sha1-0wMLMrOBVPTjt+nHCfSQ9++XxIE="",
      ""dev"": true,
      ""requires"": {{
        ""circular-json"": ""0.3.3"",
        ""del"": ""2.2.2"",
        ""graceful-fs"": ""4.1.11"",
        ""write"": ""0.2.1""
      }}
    }},
    ""flatten"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/flatten/-/flatten-1.0.2.tgz"",
      ""integrity"": ""sha1-2uRqnXj74lKSJYzB54CkHZXAN4I="",
      ""dev"": true
    }},
    ""for-in"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/for-in/-/for-in-1.0.2.tgz"",
      ""integrity"": ""sha1-gQaNKVqBQuwKxybG4iAMMPttXoA="",
      ""dev"": true
    }},
    ""for-own"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/for-own/-/for-own-1.0.0.tgz"",
      ""integrity"": ""sha1-xjMy9BXO3EsE2/5wz4NklMU8tEs="",
      ""dev"": true,
      ""requires"": {{
        ""for-in"": ""1.0.2""
      }}
    }},
    ""foreach"": {{
      ""version"": ""2.0.5"",
      ""resolved"": ""https://registry.npmjs.org/foreach/-/foreach-2.0.5.tgz"",
      ""integrity"": ""sha1-C+4AUBiusmDQo6865ljdATbsG5k="",
      ""dev"": true
    }},
    ""forever-agent"": {{
      ""version"": ""0.6.1"",
      ""resolved"": ""https://registry.npmjs.org/forever-agent/-/forever-agent-0.6.1.tgz"",
      ""integrity"": ""sha1-+8cfDEGt6zf5bFd60e1C2P2sypE="",
      ""dev"": true
    }},
    ""form-data"": {{
      ""version"": ""2.3.1"",
      ""resolved"": ""https://registry.npmjs.org/form-data/-/form-data-2.3.1.tgz"",
      ""integrity"": ""sha1-b7lPvXGIUwbXPRXMSX/kzE7NRL8="",
      ""dev"": true,
      ""requires"": {{
        ""asynckit"": ""0.4.0"",
        ""combined-stream"": ""1.0.5"",
        ""mime-types"": ""2.1.17""
      }}
    }},
    ""forwarded"": {{
      ""version"": ""0.1.2"",
      ""resolved"": ""https://registry.npmjs.org/forwarded/-/forwarded-0.1.2.tgz"",
      ""integrity"": ""sha1-mMI9qxF1ZXuMBXPozszZGw/xjIQ="",
      ""dev"": true
    }},
    ""fresh"": {{
      ""version"": ""0.5.2"",
      ""resolved"": ""https://registry.npmjs.org/fresh/-/fresh-0.5.2.tgz"",
      ""integrity"": ""sha1-PYyt2Q2XZWn6g1qx+OSyOhBWBac="",
      ""dev"": true
    }},
    ""fs-extra"": {{
      ""version"": ""0.26.7"",
      ""resolved"": ""https://registry.npmjs.org/fs-extra/-/fs-extra-0.26.7.tgz"",
      ""integrity"": ""sha1-muH92UiXeY7at20JGM9C0MMYT6k="",
      ""dev"": true,
      ""requires"": {{
        ""graceful-fs"": ""4.1.11"",
        ""jsonfile"": ""2.4.0"",
        ""klaw"": ""1.3.1"",
        ""path-is-absolute"": ""1.0.1"",
        ""rimraf"": ""2.6.2""
      }}
    }},
    ""fs-promise"": {{
      ""version"": ""0.3.1"",
      ""resolved"": ""https://registry.npmjs.org/fs-promise/-/fs-promise-0.3.1.tgz"",
      ""integrity"": ""sha1-vzQFA2jyTW3J38ZoirXOrY+GhCo="",
      ""dev"": true,
      ""requires"": {{
        ""any-promise"": ""0.1.0""
      }}
    }},
    ""fs.realpath"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/fs.realpath/-/fs.realpath-1.0.0.tgz"",
      ""integrity"": ""sha1-FQStJSMVjKpA20onh8sBQRmU6k8="",
      ""dev"": true
    }},
    ""fsevents"": {{
      ""version"": ""1.1.3"",
      ""resolved"": ""https://registry.npmjs.org/fsevents/-/fsevents-1.1.3.tgz"",
      ""integrity"": ""sha512-WIr7iDkdmdbxu/Gh6eKEZJL6KPE74/5MEsf2whTOFNxbIoIixogroLdKYqB6FDav4Wavh/lZdzzd3b2KxIXC5Q=="",
      ""dev"": true,
      ""optional"": true,
      ""requires"": {{
        ""nan"": ""2.8.0"",
        ""node-pre-gyp"": ""0.6.39""
      }},
      ""dependencies"": {{
        ""abbrev"": {{
          ""version"": ""1.1.0"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""ajv"": {{
          ""version"": ""4.11.8"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""co"": ""4.6.0"",
            ""json-stable-stringify"": ""1.0.1""
          }}
        }},
        ""ansi-regex"": {{
          ""version"": ""2.1.1"",
          ""bundled"": true,
          ""dev"": true
        }},
        ""aproba"": {{
          ""version"": ""1.1.1"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""are-we-there-yet"": {{
          ""version"": ""1.1.4"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""delegates"": ""1.0.0"",
            ""readable-stream"": ""2.2.9""
          }}
        }},
        ""asn1"": {{
          ""version"": ""0.2.3"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""assert-plus"": {{
          ""version"": ""0.2.0"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""asynckit"": {{
          ""version"": ""0.4.0"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""aws-sign2"": {{
          ""version"": ""0.6.0"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""aws4"": {{
          ""version"": ""1.6.0"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""balanced-match"": {{
          ""version"": ""0.4.2"",
          ""bundled"": true,
          ""dev"": true
        }},
        ""bcrypt-pbkdf"": {{
          ""version"": ""1.0.1"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""tweetnacl"": ""0.14.5""
          }}
        }},
        ""block-stream"": {{
          ""version"": ""0.0.9"",
          ""bundled"": true,
          ""dev"": true,
          ""requires"": {{
            ""inherits"": ""2.0.3""
          }}
        }},
        ""boom"": {{
          ""version"": ""2.10.1"",
          ""bundled"": true,
          ""dev"": true,
          ""requires"": {{
            ""hoek"": ""2.16.3""
          }}
        }},
        ""brace-expansion"": {{
          ""version"": ""1.1.7"",
          ""bundled"": true,
          ""dev"": true,
          ""requires"": {{
            ""balanced-match"": ""0.4.2"",
            ""concat-map"": ""0.0.1""
          }}
        }},
        ""buffer-shims"": {{
          ""version"": ""1.0.0"",
          ""bundled"": true,
          ""dev"": true
        }},
        ""caseless"": {{
          ""version"": ""0.12.0"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""co"": {{
          ""version"": ""4.6.0"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""code-point-at"": {{
          ""version"": ""1.1.0"",
          ""bundled"": true,
          ""dev"": true
        }},
        ""combined-stream"": {{
          ""version"": ""1.0.5"",
          ""bundled"": true,
          ""dev"": true,
          ""requires"": {{
            ""delayed-stream"": ""1.0.0""
          }}
        }},
        ""concat-map"": {{
          ""version"": ""0.0.1"",
          ""bundled"": true,
          ""dev"": true
        }},
        ""console-control-strings"": {{
          ""version"": ""1.1.0"",
          ""bundled"": true,
          ""dev"": true
        }},
        ""core-util-is"": {{
          ""version"": ""1.0.2"",
          ""bundled"": true,
          ""dev"": true
        }},
        ""cryptiles"": {{
          ""version"": ""2.0.5"",
          ""bundled"": true,
          ""dev"": true,
          ""requires"": {{
            ""boom"": ""2.10.1""
          }}
        }},
        ""dashdash"": {{
          ""version"": ""1.14.1"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""assert-plus"": ""1.0.0""
          }},
          ""dependencies"": {{
            ""assert-plus"": {{
              ""version"": ""1.0.0"",
              ""bundled"": true,
              ""dev"": true,
              ""optional"": true
            }}
          }}
        }},
        ""debug"": {{
          ""version"": ""2.6.8"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""ms"": ""2.0.0""
          }}
        }},
        ""deep-extend"": {{
          ""version"": ""0.4.2"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""delayed-stream"": {{
          ""version"": ""1.0.0"",
          ""bundled"": true,
          ""dev"": true
        }},
        ""delegates"": {{
          ""version"": ""1.0.0"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""detect-libc"": {{
          ""version"": ""1.0.2"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""ecc-jsbn"": {{
          ""version"": ""0.1.1"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""jsbn"": ""0.1.1""
          }}
        }},
        ""extend"": {{
          ""version"": ""3.0.1"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""extsprintf"": {{
          ""version"": ""1.0.2"",
          ""bundled"": true,
          ""dev"": true
        }},
        ""forever-agent"": {{
          ""version"": ""0.6.1"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""form-data"": {{
          ""version"": ""2.1.4"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""asynckit"": ""0.4.0"",
            ""combined-stream"": ""1.0.5"",
            ""mime-types"": ""2.1.15""
          }}
        }},
        ""fs.realpath"": {{
          ""version"": ""1.0.0"",
          ""bundled"": true,
          ""dev"": true
        }},
        ""fstream"": {{
          ""version"": ""1.0.11"",
          ""bundled"": true,
          ""dev"": true,
          ""requires"": {{
            ""graceful-fs"": ""4.1.11"",
            ""inherits"": ""2.0.3"",
            ""mkdirp"": ""0.5.1"",
            ""rimraf"": ""2.6.1""
          }}
        }},
        ""fstream-ignore"": {{
          ""version"": ""1.0.5"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""fstream"": ""1.0.11"",
            ""inherits"": ""2.0.3"",
            ""minimatch"": ""3.0.4""
          }}
        }},
        ""gauge"": {{
          ""version"": ""2.7.4"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""aproba"": ""1.1.1"",
            ""console-control-strings"": ""1.1.0"",
            ""has-unicode"": ""2.0.1"",
            ""object-assign"": ""4.1.1"",
            ""signal-exit"": ""3.0.2"",
            ""string-width"": ""1.0.2"",
            ""strip-ansi"": ""3.0.1"",
            ""wide-align"": ""1.1.2""
          }}
        }},
        ""getpass"": {{
          ""version"": ""0.1.7"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""assert-plus"": ""1.0.0""
          }},
          ""dependencies"": {{
            ""assert-plus"": {{
              ""version"": ""1.0.0"",
              ""bundled"": true,
              ""dev"": true,
              ""optional"": true
            }}
          }}
        }},
        ""glob"": {{
          ""version"": ""7.1.2"",
          ""bundled"": true,
          ""dev"": true,
          ""requires"": {{
            ""fs.realpath"": ""1.0.0"",
            ""inflight"": ""1.0.6"",
            ""inherits"": ""2.0.3"",
            ""minimatch"": ""3.0.4"",
            ""once"": ""1.4.0"",
            ""path-is-absolute"": ""1.0.1""
          }}
        }},
        ""graceful-fs"": {{
          ""version"": ""4.1.11"",
          ""bundled"": true,
          ""dev"": true
        }},
        ""har-schema"": {{
          ""version"": ""1.0.5"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""har-validator"": {{
          ""version"": ""4.2.1"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""ajv"": ""4.11.8"",
            ""har-schema"": ""1.0.5""
          }}
        }},
        ""has-unicode"": {{
          ""version"": ""2.0.1"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""hawk"": {{
          ""version"": ""3.1.3"",
          ""bundled"": true,
          ""dev"": true,
          ""requires"": {{
            ""boom"": ""2.10.1"",
            ""cryptiles"": ""2.0.5"",
            ""hoek"": ""2.16.3"",
            ""sntp"": ""1.0.9""
          }}
        }},
        ""hoek"": {{
          ""version"": ""2.16.3"",
          ""bundled"": true,
          ""dev"": true
        }},
        ""http-signature"": {{
          ""version"": ""1.1.1"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""assert-plus"": ""0.2.0"",
            ""jsprim"": ""1.4.0"",
            ""sshpk"": ""1.13.0""
          }}
        }},
        ""inflight"": {{
          ""version"": ""1.0.6"",
          ""bundled"": true,
          ""dev"": true,
          ""requires"": {{
            ""once"": ""1.4.0"",
            ""wrappy"": ""1.0.2""
          }}
        }},
        ""inherits"": {{
          ""version"": ""2.0.3"",
          ""bundled"": true,
          ""dev"": true
        }},
        ""ini"": {{
          ""version"": ""1.3.4"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""is-fullwidth-code-point"": {{
          ""version"": ""1.0.0"",
          ""bundled"": true,
          ""dev"": true,
          ""requires"": {{
            ""number-is-nan"": ""1.0.1""
          }}
        }},
        ""is-typedarray"": {{
          ""version"": ""1.0.0"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""isarray"": {{
          ""version"": ""1.0.0"",
          ""bundled"": true,
          ""dev"": true
        }},
        ""isstream"": {{
          ""version"": ""0.1.2"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""jodid25519"": {{
          ""version"": ""1.0.2"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""jsbn"": ""0.1.1""
          }}
        }},
        ""jsbn"": {{
          ""version"": ""0.1.1"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""json-schema"": {{
          ""version"": ""0.2.3"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""json-stable-stringify"": {{
          ""version"": ""1.0.1"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""jsonify"": ""0.0.0""
          }}
        }},
        ""json-stringify-safe"": {{
          ""version"": ""5.0.1"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""jsonify"": {{
          ""version"": ""0.0.0"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""jsprim"": {{
          ""version"": ""1.4.0"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""assert-plus"": ""1.0.0"",
            ""extsprintf"": ""1.0.2"",
            ""json-schema"": ""0.2.3"",
            ""verror"": ""1.3.6""
          }},
          ""dependencies"": {{
            ""assert-plus"": {{
              ""version"": ""1.0.0"",
              ""bundled"": true,
              ""dev"": true,
              ""optional"": true
            }}
          }}
        }},
        ""mime-db"": {{
          ""version"": ""1.27.0"",
          ""bundled"": true,
          ""dev"": true
        }},
        ""mime-types"": {{
          ""version"": ""2.1.15"",
          ""bundled"": true,
          ""dev"": true,
          ""requires"": {{
            ""mime-db"": ""1.27.0""
          }}
        }},
        ""minimatch"": {{
          ""version"": ""3.0.4"",
          ""bundled"": true,
          ""dev"": true,
          ""requires"": {{
            ""brace-expansion"": ""1.1.7""
          }}
        }},
        ""minimist"": {{
          ""version"": ""0.0.8"",
          ""bundled"": true,
          ""dev"": true
        }},
        ""mkdirp"": {{
          ""version"": ""0.5.1"",
          ""bundled"": true,
          ""dev"": true,
          ""requires"": {{
            ""minimist"": ""0.0.8""
          }}
        }},
        ""ms"": {{
          ""version"": ""2.0.0"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""node-pre-gyp"": {{
          ""version"": ""0.6.39"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""detect-libc"": ""1.0.2"",
            ""hawk"": ""3.1.3"",
            ""mkdirp"": ""0.5.1"",
            ""nopt"": ""4.0.1"",
            ""npmlog"": ""4.1.0"",
            ""rc"": ""1.2.1"",
            ""request"": ""2.81.0"",
            ""rimraf"": ""2.6.1"",
            ""semver"": ""5.3.0"",
            ""tar"": ""2.2.1"",
            ""tar-pack"": ""3.4.0""
          }}
        }},
        ""nopt"": {{
          ""version"": ""4.0.1"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""abbrev"": ""1.1.0"",
            ""osenv"": ""0.1.4""
          }}
        }},
        ""npmlog"": {{
          ""version"": ""4.1.0"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""are-we-there-yet"": ""1.1.4"",
            ""console-control-strings"": ""1.1.0"",
            ""gauge"": ""2.7.4"",
            ""set-blocking"": ""2.0.0""
          }}
        }},
        ""number-is-nan"": {{
          ""version"": ""1.0.1"",
          ""bundled"": true,
          ""dev"": true
        }},
        ""oauth-sign"": {{
          ""version"": ""0.8.2"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""object-assign"": {{
          ""version"": ""4.1.1"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""once"": {{
          ""version"": ""1.4.0"",
          ""bundled"": true,
          ""dev"": true,
          ""requires"": {{
            ""wrappy"": ""1.0.2""
          }}
        }},
        ""os-homedir"": {{
          ""version"": ""1.0.2"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""os-tmpdir"": {{
          ""version"": ""1.0.2"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""osenv"": {{
          ""version"": ""0.1.4"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""os-homedir"": ""1.0.2"",
            ""os-tmpdir"": ""1.0.2""
          }}
        }},
        ""path-is-absolute"": {{
          ""version"": ""1.0.1"",
          ""bundled"": true,
          ""dev"": true
        }},
        ""performance-now"": {{
          ""version"": ""0.2.0"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""process-nextick-args"": {{
          ""version"": ""1.0.7"",
          ""bundled"": true,
          ""dev"": true
        }},
        ""punycode"": {{
          ""version"": ""1.4.1"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""qs"": {{
          ""version"": ""6.4.0"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""rc"": {{
          ""version"": ""1.2.1"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""deep-extend"": ""0.4.2"",
            ""ini"": ""1.3.4"",
            ""minimist"": ""1.2.0"",
            ""strip-json-comments"": ""2.0.1""
          }},
          ""dependencies"": {{
            ""minimist"": {{
              ""version"": ""1.2.0"",
              ""bundled"": true,
              ""dev"": true,
              ""optional"": true
            }}
          }}
        }},
        ""readable-stream"": {{
          ""version"": ""2.2.9"",
          ""bundled"": true,
          ""dev"": true,
          ""requires"": {{
            ""buffer-shims"": ""1.0.0"",
            ""core-util-is"": ""1.0.2"",
            ""inherits"": ""2.0.3"",
            ""isarray"": ""1.0.0"",
            ""process-nextick-args"": ""1.0.7"",
            ""string_decoder"": ""1.0.1"",
            ""util-deprecate"": ""1.0.2""
          }}
        }},
        ""request"": {{
          ""version"": ""2.81.0"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""aws-sign2"": ""0.6.0"",
            ""aws4"": ""1.6.0"",
            ""caseless"": ""0.12.0"",
            ""combined-stream"": ""1.0.5"",
            ""extend"": ""3.0.1"",
            ""forever-agent"": ""0.6.1"",
            ""form-data"": ""2.1.4"",
            ""har-validator"": ""4.2.1"",
            ""hawk"": ""3.1.3"",
            ""http-signature"": ""1.1.1"",
            ""is-typedarray"": ""1.0.0"",
            ""isstream"": ""0.1.2"",
            ""json-stringify-safe"": ""5.0.1"",
            ""mime-types"": ""2.1.15"",
            ""oauth-sign"": ""0.8.2"",
            ""performance-now"": ""0.2.0"",
            ""qs"": ""6.4.0"",
            ""safe-buffer"": ""5.0.1"",
            ""stringstream"": ""0.0.5"",
            ""tough-cookie"": ""2.3.2"",
            ""tunnel-agent"": ""0.6.0"",
            ""uuid"": ""3.0.1""
          }}
        }},
        ""rimraf"": {{
          ""version"": ""2.6.1"",
          ""bundled"": true,
          ""dev"": true,
          ""requires"": {{
            ""glob"": ""7.1.2""
          }}
        }},
        ""safe-buffer"": {{
          ""version"": ""5.0.1"",
          ""bundled"": true,
          ""dev"": true
        }},
        ""semver"": {{
          ""version"": ""5.3.0"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""set-blocking"": {{
          ""version"": ""2.0.0"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""signal-exit"": {{
          ""version"": ""3.0.2"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""sntp"": {{
          ""version"": ""1.0.9"",
          ""bundled"": true,
          ""dev"": true,
          ""requires"": {{
            ""hoek"": ""2.16.3""
          }}
        }},
        ""sshpk"": {{
          ""version"": ""1.13.0"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""asn1"": ""0.2.3"",
            ""assert-plus"": ""1.0.0"",
            ""bcrypt-pbkdf"": ""1.0.1"",
            ""dashdash"": ""1.14.1"",
            ""ecc-jsbn"": ""0.1.1"",
            ""getpass"": ""0.1.7"",
            ""jodid25519"": ""1.0.2"",
            ""jsbn"": ""0.1.1"",
            ""tweetnacl"": ""0.14.5""
          }},
          ""dependencies"": {{
            ""assert-plus"": {{
              ""version"": ""1.0.0"",
              ""bundled"": true,
              ""dev"": true,
              ""optional"": true
            }}
          }}
        }},
        ""string-width"": {{
          ""version"": ""1.0.2"",
          ""bundled"": true,
          ""dev"": true,
          ""requires"": {{
            ""code-point-at"": ""1.1.0"",
            ""is-fullwidth-code-point"": ""1.0.0"",
            ""strip-ansi"": ""3.0.1""
          }}
        }},
        ""string_decoder"": {{
          ""version"": ""1.0.1"",
          ""bundled"": true,
          ""dev"": true,
          ""requires"": {{
            ""safe-buffer"": ""5.0.1""
          }}
        }},
        ""stringstream"": {{
          ""version"": ""0.0.5"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""strip-ansi"": {{
          ""version"": ""3.0.1"",
          ""bundled"": true,
          ""dev"": true,
          ""requires"": {{
            ""ansi-regex"": ""2.1.1""
          }}
        }},
        ""strip-json-comments"": {{
          ""version"": ""2.0.1"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""tar"": {{
          ""version"": ""2.2.1"",
          ""bundled"": true,
          ""dev"": true,
          ""requires"": {{
            ""block-stream"": ""0.0.9"",
            ""fstream"": ""1.0.11"",
            ""inherits"": ""2.0.3""
          }}
        }},
        ""tar-pack"": {{
          ""version"": ""3.4.0"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""debug"": ""2.6.8"",
            ""fstream"": ""1.0.11"",
            ""fstream-ignore"": ""1.0.5"",
            ""once"": ""1.4.0"",
            ""readable-stream"": ""2.2.9"",
            ""rimraf"": ""2.6.1"",
            ""tar"": ""2.2.1"",
            ""uid-number"": ""0.0.6""
          }}
        }},
        ""tough-cookie"": {{
          ""version"": ""2.3.2"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""punycode"": ""1.4.1""
          }}
        }},
        ""tunnel-agent"": {{
          ""version"": ""0.6.0"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""safe-buffer"": ""5.0.1""
          }}
        }},
        ""tweetnacl"": {{
          ""version"": ""0.14.5"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""uid-number"": {{
          ""version"": ""0.0.6"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""util-deprecate"": {{
          ""version"": ""1.0.2"",
          ""bundled"": true,
          ""dev"": true
        }},
        ""uuid"": {{
          ""version"": ""3.0.1"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true
        }},
        ""verror"": {{
          ""version"": ""1.3.6"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""extsprintf"": ""1.0.2""
          }}
        }},
        ""wide-align"": {{
          ""version"": ""1.1.2"",
          ""bundled"": true,
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""string-width"": ""1.0.2""
          }}
        }},
        ""wrappy"": {{
          ""version"": ""1.0.2"",
          ""bundled"": true,
          ""dev"": true
        }}
      }}
    }},
    ""fstream"": {{
      ""version"": ""1.0.11"",
      ""resolved"": ""https://registry.npmjs.org/fstream/-/fstream-1.0.11.tgz"",
      ""integrity"": ""sha1-XB+x8RdHcRTwYyoOtLcbPLD9MXE="",
      ""dev"": true,
      ""requires"": {{
        ""graceful-fs"": ""4.1.11"",
        ""inherits"": ""2.0.3"",
        ""mkdirp"": ""0.5.1"",
        ""rimraf"": ""2.6.2""
      }}
    }},
    ""function-bind"": {{
      ""version"": ""1.1.1"",
      ""resolved"": ""https://registry.npmjs.org/function-bind/-/function-bind-1.1.1.tgz"",
      ""integrity"": ""sha512-yIovAzMX49sF8Yl58fSCWJ5svSLuaibPxXQJFLmBObTuCr0Mf1KiPopGM9NiFjiYBCbfaa2Fh6breQ6ANVTI0A=="",
      ""dev"": true
    }},
    ""function.prototype.name"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/function.prototype.name/-/function.prototype.name-1.1.0.tgz"",
      ""integrity"": ""sha512-Bs0VRrTz4ghD8pTmbJQD1mZ8A/mN0ur/jGz+A6FBxPDUPkm1tNfF6bhTYPA7i7aF4lZJVr+OXTNNrnnIl58Wfg=="",
      ""dev"": true,
      ""requires"": {{
        ""define-properties"": ""1.1.2"",
        ""function-bind"": ""1.1.1"",
        ""is-callable"": ""1.1.3""
      }}
    }},
    ""gauge"": {{
      ""version"": ""2.7.4"",
      ""resolved"": ""https://registry.npmjs.org/gauge/-/gauge-2.7.4.tgz"",
      ""integrity"": ""sha1-LANAXHU4w51+s3sxcCLjJfsBi/c="",
      ""dev"": true,
      ""requires"": {{
        ""aproba"": ""1.2.0"",
        ""console-control-strings"": ""1.1.0"",
        ""has-unicode"": ""2.0.1"",
        ""object-assign"": ""4.1.1"",
        ""signal-exit"": ""3.0.2"",
        ""string-width"": ""1.0.2"",
        ""strip-ansi"": ""3.0.1"",
        ""wide-align"": ""1.1.2""
      }}
    }},
    ""gaze"": {{
      ""version"": ""1.1.2"",
      ""resolved"": ""https://registry.npmjs.org/gaze/-/gaze-1.1.2.tgz"",
      ""integrity"": ""sha1-hHIkZ3rbiHDWeSV+0ziP22HkAQU="",
      ""dev"": true,
      ""requires"": {{
        ""globule"": ""1.2.0""
      }}
    }},
    ""generate-function"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/generate-function/-/generate-function-2.0.0.tgz"",
      ""integrity"": ""sha1-aFj+fAlpt9TpCTM3ZHrHn2DfvnQ="",
      ""dev"": true
    }},
    ""generate-object-property"": {{
      ""version"": ""1.2.0"",
      ""resolved"": ""https://registry.npmjs.org/generate-object-property/-/generate-object-property-1.2.0.tgz"",
      ""integrity"": ""sha1-nA4cQDCM6AT0eDYYuTf6iPmdUNA="",
      ""dev"": true,
      ""requires"": {{
        ""is-property"": ""1.0.2""
      }}
    }},
    ""get-caller-file"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/get-caller-file/-/get-caller-file-1.0.2.tgz"",
      ""integrity"": ""sha1-9wLmMSfn4jHBYKgMFVSstw1QR+U="",
      ""dev"": true
    }},
    ""get-stdin"": {{
      ""version"": ""4.0.1"",
      ""resolved"": ""https://registry.npmjs.org/get-stdin/-/get-stdin-4.0.1.tgz"",
      ""integrity"": ""sha1-uWjGsKBDhDJJAui/Gl3zJXmkUP4="",
      ""dev"": true
    }},
    ""get-stream"": {{
      ""version"": ""3.0.0"",
      ""resolved"": ""https://registry.npmjs.org/get-stream/-/get-stream-3.0.0.tgz"",
      ""integrity"": ""sha1-jpQ9E1jcN1VQVOy+LtsFqhdO3hQ="",
      ""dev"": true
    }},
    ""getpass"": {{
      ""version"": ""0.1.7"",
      ""resolved"": ""https://registry.npmjs.org/getpass/-/getpass-0.1.7.tgz"",
      ""integrity"": ""sha1-Xv+OPmhNVprkyysSgmBOi6YhSfo="",
      ""dev"": true,
      ""requires"": {{
        ""assert-plus"": ""1.0.0""
      }}
    }},
    ""ghooks"": {{
      ""version"": ""2.0.2"",
      ""resolved"": ""https://registry.npmjs.org/ghooks/-/ghooks-2.0.2.tgz"",
      ""integrity"": ""sha1-sBruUk651u5zOe/CnNqVRRnxJVY="",
      ""dev"": true,
      ""requires"": {{
        ""findup"": ""0.1.5"",
        ""lodash.clone"": ""4.5.0"",
        ""manage-path"": ""2.0.0"",
        ""opt-cli"": ""1.5.1"",
        ""path-exists"": ""3.0.0"",
        ""spawn-command"": ""0.0.2""
      }},
      ""dependencies"": {{
        ""lodash.clone"": {{
          ""version"": ""4.5.0"",
          ""resolved"": ""https://registry.npmjs.org/lodash.clone/-/lodash.clone-4.5.0.tgz"",
          ""integrity"": ""sha1-GVhwRQ9aExkkeN9Lw9I9LeoZB7Y="",
          ""dev"": true
        }},
        ""path-exists"": {{
          ""version"": ""3.0.0"",
          ""resolved"": ""https://registry.npmjs.org/path-exists/-/path-exists-3.0.0.tgz"",
          ""integrity"": ""sha1-zg6+ql94yxiSXqfYENe1mwEP1RU="",
          ""dev"": true
        }}
      }}
    }},
    ""glob"": {{
      ""version"": ""6.0.4"",
      ""resolved"": ""https://registry.npmjs.org/glob/-/glob-6.0.4.tgz"",
      ""integrity"": ""sha1-DwiGD2oVUSey+t1PnOJLGqtuTSI="",
      ""dev"": true,
      ""requires"": {{
        ""inflight"": ""1.0.6"",
        ""inherits"": ""2.0.3"",
        ""minimatch"": ""3.0.4"",
        ""once"": ""1.4.0"",
        ""path-is-absolute"": ""1.0.1""
      }}
    }},
    ""glob-base"": {{
      ""version"": ""0.3.0"",
      ""resolved"": ""https://registry.npmjs.org/glob-base/-/glob-base-0.3.0.tgz"",
      ""integrity"": ""sha1-27Fk9iIbHAscz4Kuoyi0l98Oo8Q="",
      ""dev"": true,
      ""requires"": {{
        ""glob-parent"": ""2.0.0"",
        ""is-glob"": ""2.0.1""
      }}
    }},
    ""glob-parent"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/glob-parent/-/glob-parent-2.0.0.tgz"",
      ""integrity"": ""sha1-gTg9ctsFT8zPUzbaqQLxgvbtuyg="",
      ""dev"": true,
      ""requires"": {{
        ""is-glob"": ""2.0.1""
      }}
    }},
    ""global"": {{
      ""version"": ""4.3.2"",
      ""resolved"": ""https://registry.npmjs.org/global/-/global-4.3.2.tgz"",
      ""integrity"": ""sha1-52mJJopsdMOJCLEwWxD8DjlOnQ8="",
      ""dev"": true,
      ""requires"": {{
        ""min-document"": ""2.19.0"",
        ""process"": ""0.5.2""
      }}
    }},
    ""globals"": {{
      ""version"": ""9.18.0"",
      ""resolved"": ""https://registry.npmjs.org/globals/-/globals-9.18.0.tgz"",
      ""integrity"": ""sha512-S0nG3CLEQiY/ILxqtztTWH/3iRRdyBLw6KMDxnKMchrtbj2OFmehVh0WUCfW3DUrIgx/qFrJPICrq4Z4sTR9UQ=="",
      ""dev"": true
    }},
    ""globby"": {{
      ""version"": ""5.0.0"",
      ""resolved"": ""https://registry.npmjs.org/globby/-/globby-5.0.0.tgz"",
      ""integrity"": ""sha1-69hGZ8oNuzMLmbz8aOrCvFQ3Dg0="",
      ""dev"": true,
      ""requires"": {{
        ""array-union"": ""1.0.2"",
        ""arrify"": ""1.0.1"",
        ""glob"": ""7.1.2"",
        ""object-assign"": ""4.1.1"",
        ""pify"": ""2.3.0"",
        ""pinkie-promise"": ""2.0.1""
      }},
      ""dependencies"": {{
        ""glob"": {{
          ""version"": ""7.1.2"",
          ""resolved"": ""https://registry.npmjs.org/glob/-/glob-7.1.2.tgz"",
          ""integrity"": ""sha512-MJTUg1kjuLeQCJ+ccE4Vpa6kKVXkPYJ2mOCQyUuKLcLQsdrMCpBPUi8qVE6+YuaJkozeA9NusTAw3hLr8Xe5EQ=="",
          ""dev"": true,
          ""requires"": {{
            ""fs.realpath"": ""1.0.0"",
            ""inflight"": ""1.0.6"",
            ""inherits"": ""2.0.3"",
            ""minimatch"": ""3.0.4"",
            ""once"": ""1.4.0"",
            ""path-is-absolute"": ""1.0.1""
          }}
        }}
      }}
    }},
    ""globule"": {{
      ""version"": ""1.2.0"",
      ""resolved"": ""https://registry.npmjs.org/globule/-/globule-1.2.0.tgz"",
      ""integrity"": ""sha1-HcScaCLdnoovoAuiopUAboZkvQk="",
      ""dev"": true,
      ""requires"": {{
        ""glob"": ""7.1.2"",
        ""lodash"": ""4.17.4"",
        ""minimatch"": ""3.0.4""
      }},
      ""dependencies"": {{
        ""glob"": {{
          ""version"": ""7.1.2"",
          ""resolved"": ""https://registry.npmjs.org/glob/-/glob-7.1.2.tgz"",
          ""integrity"": ""sha512-MJTUg1kjuLeQCJ+ccE4Vpa6kKVXkPYJ2mOCQyUuKLcLQsdrMCpBPUi8qVE6+YuaJkozeA9NusTAw3hLr8Xe5EQ=="",
          ""dev"": true,
          ""requires"": {{
            ""fs.realpath"": ""1.0.0"",
            ""inflight"": ""1.0.6"",
            ""inherits"": ""2.0.3"",
            ""minimatch"": ""3.0.4"",
            ""once"": ""1.4.0"",
            ""path-is-absolute"": ""1.0.1""
          }}
        }}
      }}
    }},
    ""graceful-fs"": {{
      ""version"": ""4.1.11"",
      ""resolved"": ""https://registry.npmjs.org/graceful-fs/-/graceful-fs-4.1.11.tgz"",
      ""integrity"": ""sha1-Dovf5NHduIVNZOBOp8AOKgJuVlg="",
      ""dev"": true
    }},
    ""graceful-readlink"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/graceful-readlink/-/graceful-readlink-1.0.1.tgz"",
      ""integrity"": ""sha1-TK+tdrxi8C+gObL5Tpo906ORpyU="",
      ""dev"": true
    }},
    ""growly"": {{
      ""version"": ""1.3.0"",
      ""resolved"": ""https://registry.npmjs.org/growly/-/growly-1.3.0.tgz"",
      ""integrity"": ""sha1-8QdIy+dq+WS3yWyTxrzCivEgwIE="",
      ""dev"": true
    }},
    ""handlebars"": {{
      ""version"": ""4.0.11"",
      ""resolved"": ""https://registry.npmjs.org/handlebars/-/handlebars-4.0.11.tgz"",
      ""integrity"": ""sha1-Ywo13+ApS8KB7a5v/F0yn8eYLcw="",
      ""dev"": true,
      ""requires"": {{
        ""async"": ""1.5.2"",
        ""optimist"": ""0.6.1"",
        ""source-map"": ""0.4.4"",
        ""uglify-js"": ""2.8.29""
      }},
      ""dependencies"": {{
        ""async"": {{
          ""version"": ""1.5.2"",
          ""resolved"": ""https://registry.npmjs.org/async/-/async-1.5.2.tgz"",
          ""integrity"": ""sha1-7GphrlZIDAw8skHJVhjiCJL5Zyo="",
          ""dev"": true
        }},
        ""camelcase"": {{
          ""version"": ""1.2.1"",
          ""resolved"": ""https://registry.npmjs.org/camelcase/-/camelcase-1.2.1.tgz"",
          ""integrity"": ""sha1-m7UwTS4LVmmLLHWLCKPqqdqlijk="",
          ""dev"": true,
          ""optional"": true
        }},
        ""cliui"": {{
          ""version"": ""2.1.0"",
          ""resolved"": ""https://registry.npmjs.org/cliui/-/cliui-2.1.0.tgz"",
          ""integrity"": ""sha1-S0dXYP+AJkx2LDoXGQMukcf+oNE="",
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""center-align"": ""0.1.3"",
            ""right-align"": ""0.1.3"",
            ""wordwrap"": ""0.0.2""
          }}
        }},
        ""source-map"": {{
          ""version"": ""0.4.4"",
          ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.4.4.tgz"",
          ""integrity"": ""sha1-66T12pwNyZneaAMti092FzZSA2s="",
          ""dev"": true,
          ""requires"": {{
            ""amdefine"": ""1.0.1""
          }}
        }},
        ""uglify-js"": {{
          ""version"": ""2.8.29"",
          ""resolved"": ""https://registry.npmjs.org/uglify-js/-/uglify-js-2.8.29.tgz"",
          ""integrity"": ""sha1-KcVzMUgFe7Th913zW3qcty5qWd0="",
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""source-map"": ""0.5.7"",
            ""uglify-to-browserify"": ""1.0.2"",
            ""yargs"": ""3.10.0""
          }},
          ""dependencies"": {{
            ""source-map"": {{
              ""version"": ""0.5.7"",
              ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.5.7.tgz"",
              ""integrity"": ""sha1-igOdLRAh0i0eoUyA2OpGi6LvP8w="",
              ""dev"": true,
              ""optional"": true
            }}
          }}
        }},
        ""wordwrap"": {{
          ""version"": ""0.0.2"",
          ""resolved"": ""https://registry.npmjs.org/wordwrap/-/wordwrap-0.0.2.tgz"",
          ""integrity"": ""sha1-t5Zpu0LstAn4PVg8rVLKF+qhZD8="",
          ""dev"": true,
          ""optional"": true
        }},
        ""yargs"": {{
          ""version"": ""3.10.0"",
          ""resolved"": ""https://registry.npmjs.org/yargs/-/yargs-3.10.0.tgz"",
          ""integrity"": ""sha1-9+572FfdfB0tOMDnTvvWgdFDH9E="",
          ""dev"": true,
          ""optional"": true,
          ""requires"": {{
            ""camelcase"": ""1.2.1"",
            ""cliui"": ""2.1.0"",
            ""decamelize"": ""1.2.0"",
            ""window-size"": ""0.1.0""
          }}
        }}
      }}
    }},
    ""har-schema"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/har-schema/-/har-schema-2.0.0.tgz"",
      ""integrity"": ""sha1-qUwiJOvKwEeCoNkDVSHyRzW37JI="",
      ""dev"": true
    }},
    ""har-validator"": {{
      ""version"": ""5.0.3"",
      ""resolved"": ""https://registry.npmjs.org/har-validator/-/har-validator-5.0.3.tgz"",
      ""integrity"": ""sha1-ukAsJmGU8VlW7xXg/PJCmT9qff0="",
      ""dev"": true,
      ""requires"": {{
        ""ajv"": ""5.5.2"",
        ""har-schema"": ""2.0.0""
      }},
      ""dependencies"": {{
        ""ajv"": {{
          ""version"": ""5.5.2"",
          ""resolved"": ""https://registry.npmjs.org/ajv/-/ajv-5.5.2.tgz"",
          ""integrity"": ""sha1-c7Xuyj+rZT49P5Qis0GtQiBdyWU="",
          ""dev"": true,
          ""requires"": {{
            ""co"": ""4.6.0"",
            ""fast-deep-equal"": ""1.0.0"",
            ""fast-json-stable-stringify"": ""2.0.0"",
            ""json-schema-traverse"": ""0.3.1""
          }}
        }}
      }}
    }},
    ""has"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/has/-/has-1.0.1.tgz"",
      ""integrity"": ""sha1-hGFzP1OLCDfJNh45qauelwTcLyg="",
      ""dev"": true,
      ""requires"": {{
        ""function-bind"": ""1.1.1""
      }}
    }},
    ""has-ansi"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/has-ansi/-/has-ansi-2.0.0.tgz"",
      ""integrity"": ""sha1-NPUEnOHs3ysGSa8+8k5F7TVBbZE="",
      ""dev"": true,
      ""requires"": {{
        ""ansi-regex"": ""2.1.1""
      }}
    }},
    ""has-flag"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/has-flag/-/has-flag-1.0.0.tgz"",
      ""integrity"": ""sha1-nZ55MWXOAXoA8AQYxD+UKnsdEfo="",
      ""dev"": true
    }},
    ""has-symbols"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/has-symbols/-/has-symbols-1.0.0.tgz"",
      ""integrity"": ""sha1-uhqPGvKg/DllD1yFA2dwQSIGO0Q="",
      ""dev"": true
    }},
    ""has-unicode"": {{
      ""version"": ""2.0.1"",
      ""resolved"": ""https://registry.npmjs.org/has-unicode/-/has-unicode-2.0.1.tgz"",
      ""integrity"": ""sha1-4Ob+aijPUROIVeCG0Wkedx3iqLk="",
      ""dev"": true
    }},
    ""hash-base"": {{
      ""version"": ""2.0.2"",
      ""resolved"": ""https://registry.npmjs.org/hash-base/-/hash-base-2.0.2.tgz"",
      ""integrity"": ""sha1-ZuodhW206KVHDK32/OI65SRO8uE="",
      ""dev"": true,
      ""requires"": {{
        ""inherits"": ""2.0.3""
      }}
    }},
    ""hash.js"": {{
      ""version"": ""1.1.3"",
      ""resolved"": ""https://registry.npmjs.org/hash.js/-/hash.js-1.1.3.tgz"",
      ""integrity"": ""sha512-/UETyP0W22QILqS+6HowevwhEFJ3MBJnwTf75Qob9Wz9t0DPuisL8kW8YZMK62dHAKE1c1p+gY1TtOLY+USEHA=="",
      ""dev"": true,
      ""requires"": {{
        ""inherits"": ""2.0.3"",
        ""minimalistic-assert"": ""1.0.0""
      }}
    }},
    ""hawk"": {{
      ""version"": ""6.0.2"",
      ""resolved"": ""https://registry.npmjs.org/hawk/-/hawk-6.0.2.tgz"",
      ""integrity"": ""sha512-miowhl2+U7Qle4vdLqDdPt9m09K6yZhkLDTWGoUiUzrQCn+mHHSmfJgAyGaLRZbPmTqfFFjRV1QWCW0VWUJBbQ=="",
      ""dev"": true,
      ""requires"": {{
        ""boom"": ""4.3.1"",
        ""cryptiles"": ""3.1.2"",
        ""hoek"": ""4.2.0"",
        ""sntp"": ""2.1.0""
      }}
    }},
    ""he"": {{
      ""version"": ""1.1.1"",
      ""resolved"": ""https://registry.npmjs.org/he/-/he-1.1.1.tgz"",
      ""integrity"": ""sha1-k0EP0hsAlzUVH4howvJx80J+I/0="",
      ""dev"": true
    }},
    ""history"": {{
      ""version"": ""4.7.2"",
      ""resolved"": ""https://registry.npmjs.org/history/-/history-4.7.2.tgz"",
      ""integrity"": ""sha512-1zkBRWW6XweO0NBcjiphtVJVsIQ+SXF29z9DVkceeaSLVMFXHool+fdCZD4spDCfZJCILPILc3bm7Bc+HRi0nA=="",
      ""requires"": {{
        ""invariant"": ""2.2.2"",
        ""loose-envify"": ""1.3.1"",
        ""resolve-pathname"": ""2.2.0"",
        ""value-equal"": ""0.4.0"",
        ""warning"": ""3.0.0""
      }}
    }},
    ""hmac-drbg"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/hmac-drbg/-/hmac-drbg-1.0.1.tgz"",
      ""integrity"": ""sha1-0nRXAQJabHdabFRXk+1QL8DGSaE="",
      ""dev"": true,
      ""requires"": {{
        ""hash.js"": ""1.1.3"",
        ""minimalistic-assert"": ""1.0.0"",
        ""minimalistic-crypto-utils"": ""1.0.1""
      }}
    }},
    ""hoek"": {{
      ""version"": ""4.2.0"",
      ""resolved"": ""https://registry.npmjs.org/hoek/-/hoek-4.2.0.tgz"",
      ""integrity"": ""sha512-v0XCLxICi9nPfYrS9RL8HbYnXi9obYAeLbSP00BmnZwCK9+Ih9WOjoZ8YoHCoav2csqn4FOz4Orldsy2dmDwmQ=="",
      ""dev"": true
    }},
    ""hoist-non-react-statics"": {{
      ""version"": ""2.3.1"",
      ""resolved"": ""https://registry.npmjs.org/hoist-non-react-statics/-/hoist-non-react-statics-2.3.1.tgz"",
      ""integrity"": ""sha1-ND24TGAYxlB3iJgkATWhQg7iLOA=""
    }},
    ""home-or-tmp"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/home-or-tmp/-/home-or-tmp-2.0.0.tgz"",
      ""integrity"": ""sha1-42w/LSyufXRqhX440Y1fMqeILbg="",
      ""dev"": true,
      ""requires"": {{
        ""os-homedir"": ""1.0.2"",
        ""os-tmpdir"": ""1.0.2""
      }}
    }},
    ""hosted-git-info"": {{
      ""version"": ""2.5.0"",
      ""resolved"": ""https://registry.npmjs.org/hosted-git-info/-/hosted-git-info-2.5.0.tgz"",
      ""integrity"": ""sha512-pNgbURSuab90KbTqvRPsseaTxOJCZBD0a7t+haSN33piP9cCM4l0CqdzAif2hUqm716UovKB2ROmiabGAKVXyg=="",
      ""dev"": true
    }},
    ""html-comment-regex"": {{
      ""version"": ""1.1.1"",
      ""resolved"": ""https://registry.npmjs.org/html-comment-regex/-/html-comment-regex-1.1.1.tgz"",
      ""integrity"": ""sha1-ZouTd26q5V696POtRkswekljYl4="",
      ""dev"": true
    }},
    ""html-encoding-sniffer"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/html-encoding-sniffer/-/html-encoding-sniffer-1.0.2.tgz"",
      ""integrity"": ""sha512-71lZziiDnsuabfdYiUeWdCVyKuqwWi23L8YeIgV9jSSZHCtb6wB1BKWooH7L3tn4/FuZJMVWyNaIDr4RGmaSYw=="",
      ""dev"": true,
      ""requires"": {{
        ""whatwg-encoding"": ""1.0.3""
      }}
    }},
    ""html-entities"": {{
      ""version"": ""1.2.1"",
      ""resolved"": ""https://registry.npmjs.org/html-entities/-/html-entities-1.2.1.tgz"",
      ""integrity"": ""sha1-DfKTUfByEWNRXfueVUPl9u7VFi8="",
      ""dev"": true
    }},
    ""html-minifier"": {{
      ""version"": ""3.5.8"",
      ""resolved"": ""https://registry.npmjs.org/html-minifier/-/html-minifier-3.5.8.tgz"",
      ""integrity"": ""sha512-WX7D6PB9PFq05fZ1/CyxPUuyqXed6vh2fGOM80+zJT5wAO93D/cUjLs0CcbBFjQmlwmCgRvl97RurtArIpOnkw=="",
      ""dev"": true,
      ""requires"": {{
        ""camel-case"": ""3.0.0"",
        ""clean-css"": ""4.1.9"",
        ""commander"": ""2.12.2"",
        ""he"": ""1.1.1"",
        ""ncname"": ""1.0.0"",
        ""param-case"": ""2.1.1"",
        ""relateurl"": ""0.2.7"",
        ""uglify-js"": ""3.3.4""
      }},
      ""dependencies"": {{
        ""commander"": {{
          ""version"": ""2.12.2"",
          ""resolved"": ""https://registry.npmjs.org/commander/-/commander-2.12.2.tgz"",
          ""integrity"": ""sha512-BFnaq5ZOGcDN7FlrtBT4xxkgIToalIIxwjxLWVJ8bGTpe1LroqMiqQXdA7ygc7CRvaYS+9zfPGFnJqFSayx+AA=="",
          ""dev"": true
        }}
      }}
    }},
    ""html-webpack-plugin"": {{
      ""version"": ""2.30.1"",
      ""resolved"": ""https://registry.npmjs.org/html-webpack-plugin/-/html-webpack-plugin-2.30.1.tgz"",
      ""integrity"": ""sha1-f5xCG36pHsRg9WUn1430hO51N9U="",
      ""dev"": true,
      ""requires"": {{
        ""bluebird"": ""3.5.1"",
        ""html-minifier"": ""3.5.8"",
        ""loader-utils"": ""0.2.17"",
        ""lodash"": ""4.17.4"",
        ""pretty-error"": ""2.1.1"",
        ""toposort"": ""1.0.6""
      }},
      ""dependencies"": {{
        ""bluebird"": {{
          ""version"": ""3.5.1"",
          ""resolved"": ""https://registry.npmjs.org/bluebird/-/bluebird-3.5.1.tgz"",
          ""integrity"": ""sha512-MKiLiV+I1AA596t9w1sQJ8jkiSr5+ZKi0WKrYGUn6d1Fx+Ij4tIj+m2WMQSGczs5jZVxV339chE8iwk6F64wjA=="",
          ""dev"": true
        }}
      }}
    }},
    ""htmlparser2"": {{
      ""version"": ""3.9.2"",
      ""resolved"": ""https://registry.npmjs.org/htmlparser2/-/htmlparser2-3.9.2.tgz"",
      ""integrity"": ""sha1-G9+HrMoPP55T+k/M6w9LTLsAszg="",
      ""dev"": true,
      ""requires"": {{
        ""domelementtype"": ""1.3.0"",
        ""domhandler"": ""2.4.1"",
        ""domutils"": ""1.5.1"",
        ""entities"": ""1.1.1"",
        ""inherits"": ""2.0.3"",
        ""readable-stream"": ""2.3.3""
      }},
      ""dependencies"": {{
        ""isarray"": {{
          ""version"": ""1.0.0"",
          ""resolved"": ""https://registry.npmjs.org/isarray/-/isarray-1.0.0.tgz"",
          ""integrity"": ""sha1-u5NdSFgsuhaMBoNJV6VKPgcSTxE="",
          ""dev"": true
        }},
        ""readable-stream"": {{
          ""version"": ""2.3.3"",
          ""resolved"": ""https://registry.npmjs.org/readable-stream/-/readable-stream-2.3.3.tgz"",
          ""integrity"": ""sha512-m+qzzcn7KUxEmd1gMbchF+Y2eIUbieUaxkWtptyHywrX0rE8QEYqPC07Vuy4Wm32/xE16NcdBctb8S0Xe/5IeQ=="",
          ""dev"": true,
          ""requires"": {{
            ""core-util-is"": ""1.0.2"",
            ""inherits"": ""2.0.3"",
            ""isarray"": ""1.0.0"",
            ""process-nextick-args"": ""1.0.7"",
            ""safe-buffer"": ""5.1.1"",
            ""string_decoder"": ""1.0.3"",
            ""util-deprecate"": ""1.0.2""
          }}
        }},
        ""string_decoder"": {{
          ""version"": ""1.0.3"",
          ""resolved"": ""https://registry.npmjs.org/string_decoder/-/string_decoder-1.0.3.tgz"",
          ""integrity"": ""sha512-4AH6Z5fzNNBcH+6XDMfA/BTt87skxqJlO0lAh3Dker5zThcAxG6mKz+iGu308UKoPPQ8Dcqx/4JhujzltRa+hQ=="",
          ""dev"": true,
          ""requires"": {{
            ""safe-buffer"": ""5.1.1""
          }}
        }}
      }}
    }},
    ""http-errors"": {{
      ""version"": ""1.6.2"",
      ""resolved"": ""https://registry.npmjs.org/http-errors/-/http-errors-1.6.2.tgz"",
      ""integrity"": ""sha1-CgAsyFcHGSp+eUbO7cERVfYOxzY="",
      ""dev"": true,
      ""requires"": {{
        ""depd"": ""1.1.1"",
        ""inherits"": ""2.0.3"",
        ""setprototypeof"": ""1.0.3"",
        ""statuses"": ""1.3.1""
      }},
      ""dependencies"": {{
        ""setprototypeof"": {{
          ""version"": ""1.0.3"",
          ""resolved"": ""https://registry.npmjs.org/setprototypeof/-/setprototypeof-1.0.3.tgz"",
          ""integrity"": ""sha1-ZlZ+NwQ+608E2RvWWMDL77VbjgQ="",
          ""dev"": true
        }}
      }}
    }},
    ""http-parser-js"": {{
      ""version"": ""0.4.9"",
      ""resolved"": ""https://registry.npmjs.org/http-parser-js/-/http-parser-js-0.4.9.tgz"",
      ""integrity"": ""sha1-6hoE+2St/wJC6ZdPKX3Uw8rSceE="",
      ""dev"": true
    }},
    ""http-proxy"": {{
      ""version"": ""1.16.2"",
      ""resolved"": ""https://registry.npmjs.org/http-proxy/-/http-proxy-1.16.2.tgz"",
      ""integrity"": ""sha1-Bt/ykpUr9k2+hHH6nfcwZtTzd0I="",
      ""dev"": true,
      ""requires"": {{
        ""eventemitter3"": ""1.2.0"",
        ""requires-port"": ""1.0.0""
      }}
    }},
    ""http-proxy-middleware"": {{
      ""version"": ""0.17.4"",
      ""resolved"": ""https://registry.npmjs.org/http-proxy-middleware/-/http-proxy-middleware-0.17.4.tgz"",
      ""integrity"": ""sha1-ZC6ISIUdZvCdTxJJEoRtuutBuDM="",
      ""dev"": true,
      ""requires"": {{
        ""http-proxy"": ""1.16.2"",
        ""is-glob"": ""3.1.0"",
        ""lodash"": ""4.17.4"",
        ""micromatch"": ""2.3.11""
      }},
      ""dependencies"": {{
        ""is-extglob"": {{
          ""version"": ""2.1.1"",
          ""resolved"": ""https://registry.npmjs.org/is-extglob/-/is-extglob-2.1.1.tgz"",
          ""integrity"": ""sha1-qIwCU1eR8C7TfHahueqXc8gz+MI="",
          ""dev"": true
        }},
        ""is-glob"": {{
          ""version"": ""3.1.0"",
          ""resolved"": ""https://registry.npmjs.org/is-glob/-/is-glob-3.1.0.tgz"",
          ""integrity"": ""sha1-e6WuJCF4BKxwcHuWkiVnSGzD6Eo="",
          ""dev"": true,
          ""requires"": {{
            ""is-extglob"": ""2.1.1""
          }}
        }}
      }}
    }},
    ""http-signature"": {{
      ""version"": ""1.2.0"",
      ""resolved"": ""https://registry.npmjs.org/http-signature/-/http-signature-1.2.0.tgz"",
      ""integrity"": ""sha1-muzZJRFHcvPZW2WmCruPfBj7rOE="",
      ""dev"": true,
      ""requires"": {{
        ""assert-plus"": ""1.0.0"",
        ""jsprim"": ""1.4.1"",
        ""sshpk"": ""1.13.1""
      }}
    }},
    ""https-browserify"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/https-browserify/-/https-browserify-1.0.0.tgz"",
      ""integrity"": ""sha1-7AbBDgo0wPL68Zn3/X/Hj//QPHM="",
      ""dev"": true
    }},
    ""hyphenate-style-name"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/hyphenate-style-name/-/hyphenate-style-name-1.0.2.tgz"",
      ""integrity"": ""sha1-MRYKNpMK2vH8BMYHT360FGXU7Es=""
    }},
    ""iconv-lite"": {{
      ""version"": ""0.4.19"",
      ""resolved"": ""https://registry.npmjs.org/iconv-lite/-/iconv-lite-0.4.19.tgz"",
      ""integrity"": ""sha512-oTZqweIP51xaGPI4uPa56/Pri/480R+mo7SeU+YETByQNhDG55ycFyNLIgta9vXhILrxXDmF7ZGhqZIcuN0gJQ==""
    }},
    ""icss-replace-symbols"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/icss-replace-symbols/-/icss-replace-symbols-1.1.0.tgz"",
      ""integrity"": ""sha1-Bupvg2ead0njhs/h/oEq5dsiPe0="",
      ""dev"": true
    }},
    ""icss-utils"": {{
      ""version"": ""2.1.0"",
      ""resolved"": ""https://registry.npmjs.org/icss-utils/-/icss-utils-2.1.0.tgz"",
      ""integrity"": ""sha1-g/Cg7DeL8yRheLbCrZE28TWxyWI="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""6.0.16""
      }},
      ""dependencies"": {{
        ""ansi-styles"": {{
          ""version"": ""3.2.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-styles/-/ansi-styles-3.2.0.tgz"",
          ""integrity"": ""sha512-NnSOmMEYtVR2JVMIGTzynRkkaxtiq1xnFBcdQD/DnNCYPoEPsVJhM98BDyaoNOQIi7p4okdi3E27eN7GQbsUug=="",
          ""dev"": true,
          ""requires"": {{
            ""color-convert"": ""1.9.1""
          }}
        }},
        ""chalk"": {{
          ""version"": ""2.3.0"",
          ""resolved"": ""https://registry.npmjs.org/chalk/-/chalk-2.3.0.tgz"",
          ""integrity"": ""sha512-Az5zJR2CBujap2rqXGaJKaPHyJ0IrUimvYNX+ncCy8PJP4ltOGTrHUIo097ZaL2zMeKYpiCdqDvS6zdrTFok3Q=="",
          ""dev"": true,
          ""requires"": {{
            ""ansi-styles"": ""3.2.0"",
            ""escape-string-regexp"": ""1.0.5"",
            ""supports-color"": ""4.5.0""
          }},
          ""dependencies"": {{
            ""supports-color"": {{
              ""version"": ""4.5.0"",
              ""resolved"": ""https://registry.npmjs.org/supports-color/-/supports-color-4.5.0.tgz"",
              ""integrity"": ""sha1-vnoN5ITexcXN34s9WRJQRJEvY1s="",
              ""dev"": true,
              ""requires"": {{
                ""has-flag"": ""2.0.0""
              }}
            }}
          }}
        }},
        ""has-flag"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/has-flag/-/has-flag-2.0.0.tgz"",
          ""integrity"": ""sha1-6CB68cx7MNRGzHC3NLXovhj4jVE="",
          ""dev"": true
        }},
        ""postcss"": {{
          ""version"": ""6.0.16"",
          ""resolved"": ""https://registry.npmjs.org/postcss/-/postcss-6.0.16.tgz"",
          ""integrity"": ""sha512-m758RWPmSjFH/2MyyG3UOW1fgYbR9rtdzz5UNJnlm7OLtu4B2h9C6gi+bE4qFKghsBRFfZT8NzoQBs6JhLotoA=="",
          ""dev"": true,
          ""requires"": {{
            ""chalk"": ""2.3.0"",
            ""source-map"": ""0.6.1"",
            ""supports-color"": ""5.1.0""
          }}
        }},
        ""source-map"": {{
          ""version"": ""0.6.1"",
          ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.6.1.tgz"",
          ""integrity"": ""sha512-UjgapumWlbMhkBgzT7Ykc5YXUT46F0iKu8SGXq0bcwP5dz/h0Plj6enJqjz1Zbq2l5WaqYnrVbwWOWMyF3F47g=="",
          ""dev"": true
        }},
        ""supports-color"": {{
          ""version"": ""5.1.0"",
          ""resolved"": ""https://registry.npmjs.org/supports-color/-/supports-color-5.1.0.tgz"",
          ""integrity"": ""sha512-Ry0AwkoKjDpVKK4sV4h6o3UJmNRbjYm2uXhwfj3J56lMVdvnUNqzQVRztOOMGQ++w1K/TjNDFvpJk0F/LoeBCQ=="",
          ""dev"": true,
          ""requires"": {{
            ""has-flag"": ""2.0.0""
          }}
        }}
      }}
    }},
    ""ieee754"": {{
      ""version"": ""1.1.8"",
      ""resolved"": ""https://registry.npmjs.org/ieee754/-/ieee754-1.1.8.tgz"",
      ""integrity"": ""sha1-vjPUCsEO8ZJnAfbwii2G+/0a0+Q="",
      ""dev"": true
    }},
    ""ignore"": {{
      ""version"": ""3.3.7"",
      ""resolved"": ""https://registry.npmjs.org/ignore/-/ignore-3.3.7.tgz"",
      ""integrity"": ""sha512-YGG3ejvBNHRqu0559EOxxNFihD0AjpvHlC/pdGKd3X3ofe+CoJkYazwNJYTNebqpPKN+VVQbh4ZFn1DivMNuHA=="",
      ""dev"": true
    }},
    ""ignore-styles"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/ignore-styles/-/ignore-styles-2.0.0.tgz"",
      ""integrity"": ""sha1-RW8GUF7GpDoUeL+Zxpk67XXlqtU="",
      ""dev"": true
    }},
    ""immediate"": {{
      ""version"": ""3.0.6"",
      ""resolved"": ""https://registry.npmjs.org/immediate/-/immediate-3.0.6.tgz"",
      ""integrity"": ""sha1-nbHb0Pr43m++D13V5Wu2BigN5ps=""
    }},
    ""imports-loader"": {{
      ""version"": ""0.6.5"",
      ""resolved"": ""https://registry.npmjs.org/imports-loader/-/imports-loader-0.6.5.tgz"",
      ""integrity"": ""sha1-rnRlMDHVnjezwvslRKxhrq41MKY="",
      ""dev"": true,
      ""requires"": {{
        ""loader-utils"": ""0.2.17"",
        ""source-map"": ""0.1.31""
      }}
    }},
    ""imurmurhash"": {{
      ""version"": ""0.1.4"",
      ""resolved"": ""https://registry.npmjs.org/imurmurhash/-/imurmurhash-0.1.4.tgz"",
      ""integrity"": ""sha1-khi5srkoojixPcT7a21XbyMUU+o="",
      ""dev"": true
    }},
    ""in-publish"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/in-publish/-/in-publish-2.0.0.tgz"",
      ""integrity"": ""sha1-4g/146KvwmkDILbcVSaCqcf631E="",
      ""dev"": true
    }},
    ""indent-string"": {{
      ""version"": ""2.1.0"",
      ""resolved"": ""https://registry.npmjs.org/indent-string/-/indent-string-2.1.0.tgz"",
      ""integrity"": ""sha1-ji1INIdCEhtKghi3oTfppSBJ3IA="",
      ""dev"": true,
      ""requires"": {{
        ""repeating"": ""2.0.1""
      }}
    }},
    ""indexes-of"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/indexes-of/-/indexes-of-1.0.1.tgz"",
      ""integrity"": ""sha1-8w9xbI4r00bHtn0985FVZqfAVgc="",
      ""dev"": true
    }},
    ""indexof"": {{
      ""version"": ""0.0.1"",
      ""resolved"": ""https://registry.npmjs.org/indexof/-/indexof-0.0.1.tgz"",
      ""integrity"": ""sha1-gtwzbSMrkGIXnQWrMpOmYFn9Q10="",
      ""dev"": true
    }},
    ""inflight"": {{
      ""version"": ""1.0.6"",
      ""resolved"": ""https://registry.npmjs.org/inflight/-/inflight-1.0.6.tgz"",
      ""integrity"": ""sha1-Sb1jMdfQLQwJvJEKEHW6gWW1bfk="",
      ""dev"": true,
      ""requires"": {{
        ""once"": ""1.4.0"",
        ""wrappy"": ""1.0.2""
      }}
    }},
    ""inherits"": {{
      ""version"": ""2.0.3"",
      ""resolved"": ""https://registry.npmjs.org/inherits/-/inherits-2.0.3.tgz"",
      ""integrity"": ""sha1-Yzwsg+PaQqUC9SRmAiSA9CCCYd4="",
      ""dev"": true
    }},
    ""inline-style-prefixer"": {{
      ""version"": ""3.0.8"",
      ""resolved"": ""https://registry.npmjs.org/inline-style-prefixer/-/inline-style-prefixer-3.0.8.tgz"",
      ""integrity"": ""sha1-hVG45bTVcyROZqNLBPfTIHaitTQ="",
      ""requires"": {{
        ""bowser"": ""1.9.1"",
        ""css-in-js-utils"": ""2.0.0""
      }}
    }},
    ""inquirer"": {{
      ""version"": ""0.12.0"",
      ""resolved"": ""https://registry.npmjs.org/inquirer/-/inquirer-0.12.0.tgz"",
      ""integrity"": ""sha1-HvK/1jUE3wvHV4X/+MLEHfEvB34="",
      ""dev"": true,
      ""requires"": {{
        ""ansi-escapes"": ""1.4.0"",
        ""ansi-regex"": ""2.1.1"",
        ""chalk"": ""1.1.3"",
        ""cli-cursor"": ""1.0.2"",
        ""cli-width"": ""2.2.0"",
        ""figures"": ""1.7.0"",
        ""lodash"": ""4.17.4"",
        ""readline2"": ""1.0.1"",
        ""run-async"": ""0.1.0"",
        ""rx-lite"": ""3.1.2"",
        ""string-width"": ""1.0.2"",
        ""strip-ansi"": ""3.0.1"",
        ""through"": ""2.3.8""
      }}
    }},
    ""interpret"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/interpret/-/interpret-1.1.0.tgz"",
      ""integrity"": ""sha1-ftGxQQxqDg94z5XTuEQMY/eLhhQ="",
      ""dev"": true
    }},
    ""invariant"": {{
      ""version"": ""2.2.2"",
      ""resolved"": ""https://registry.npmjs.org/invariant/-/invariant-2.2.2.tgz"",
      ""integrity"": ""sha1-nh9WrArNtr8wMwbzOL47IErmA2A="",
      ""requires"": {{
        ""loose-envify"": ""1.3.1""
      }}
    }},
    ""invert-kv"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/invert-kv/-/invert-kv-1.0.0.tgz"",
      ""integrity"": ""sha1-EEqOSqym09jNFXqO+L+rLXo//bY="",
      ""dev"": true
    }},
    ""ipaddr.js"": {{
      ""version"": ""1.5.2"",
      ""resolved"": ""https://registry.npmjs.org/ipaddr.js/-/ipaddr.js-1.5.2.tgz"",
      ""integrity"": ""sha1-1LUFvemUaYfM8PxY2QEP+WB+P6A="",
      ""dev"": true
    }},
    ""is-absolute-url"": {{
      ""version"": ""2.1.0"",
      ""resolved"": ""https://registry.npmjs.org/is-absolute-url/-/is-absolute-url-2.1.0.tgz"",
      ""integrity"": ""sha1-UFMN+4T8yap9vnhS6Do3uTufKqY="",
      ""dev"": true
    }},
    ""is-arrayish"": {{
      ""version"": ""0.2.1"",
      ""resolved"": ""https://registry.npmjs.org/is-arrayish/-/is-arrayish-0.2.1.tgz"",
      ""integrity"": ""sha1-d8mYQFJ6qOyxqLppe4BkWnqSap0="",
      ""dev"": true
    }},
    ""is-binary-path"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/is-binary-path/-/is-binary-path-1.0.1.tgz"",
      ""integrity"": ""sha1-dfFmQrSA8YenEcgUFh/TpKdlWJg="",
      ""dev"": true,
      ""requires"": {{
        ""binary-extensions"": ""1.11.0""
      }}
    }},
    ""is-buffer"": {{
      ""version"": ""1.1.6"",
      ""resolved"": ""https://registry.npmjs.org/is-buffer/-/is-buffer-1.1.6.tgz"",
      ""integrity"": ""sha512-NcdALwpXkTm5Zvvbk7owOUSvVvBKDgKP5/ewfXEznmQFfs4ZRmanOeKBTjRVjka3QFoN6XJ+9F3USqfHqTaU5w==""
    }},
    ""is-builtin-module"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/is-builtin-module/-/is-builtin-module-1.0.0.tgz"",
      ""integrity"": ""sha1-VAVy0096wxGfj3bDDLwbHgN6/74="",
      ""dev"": true,
      ""requires"": {{
        ""builtin-modules"": ""1.1.1""
      }}
    }},
    ""is-callable"": {{
      ""version"": ""1.1.3"",
      ""resolved"": ""https://registry.npmjs.org/is-callable/-/is-callable-1.1.3.tgz"",
      ""integrity"": ""sha1-hut1OSgF3cM69xySoO7fdO52BLI="",
      ""dev"": true
    }},
    ""is-ci"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/is-ci/-/is-ci-1.1.0.tgz"",
      ""integrity"": ""sha512-c7TnwxLePuqIlxHgr7xtxzycJPegNHFuIrBkwbf8hc58//+Op1CqFkyS+xnIMkwn9UsJIwc174BIjkyBmSpjKg=="",
      ""dev"": true,
      ""requires"": {{
        ""ci-info"": ""1.1.2""
      }}
    }},
    ""is-date-object"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/is-date-object/-/is-date-object-1.0.1.tgz"",
      ""integrity"": ""sha1-mqIOtq7rv/d/vTPnTKAbM1gdOhY="",
      ""dev"": true
    }},
    ""is-directory"": {{
      ""version"": ""0.3.1"",
      ""resolved"": ""https://registry.npmjs.org/is-directory/-/is-directory-0.3.1.tgz"",
      ""integrity"": ""sha1-YTObbyR1/Hcv2cnYP1yFddwVSuE="",
      ""dev"": true
    }},
    ""is-dotfile"": {{
      ""version"": ""1.0.3"",
      ""resolved"": ""https://registry.npmjs.org/is-dotfile/-/is-dotfile-1.0.3.tgz"",
      ""integrity"": ""sha1-pqLzL/0t+wT1yiXs0Pa4PPeYoeE="",
      ""dev"": true
    }},
    ""is-equal-shallow"": {{
      ""version"": ""0.1.3"",
      ""resolved"": ""https://registry.npmjs.org/is-equal-shallow/-/is-equal-shallow-0.1.3.tgz"",
      ""integrity"": ""sha1-IjgJj8Ih3gvPpdnqxMRdY4qhxTQ="",
      ""dev"": true,
      ""requires"": {{
        ""is-primitive"": ""2.0.0""
      }}
    }},
    ""is-extendable"": {{
      ""version"": ""0.1.1"",
      ""resolved"": ""https://registry.npmjs.org/is-extendable/-/is-extendable-0.1.1.tgz"",
      ""integrity"": ""sha1-YrEQ4omkcUGOPsNqYX1HLjAd/Ik="",
      ""dev"": true
    }},
    ""is-extglob"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/is-extglob/-/is-extglob-1.0.0.tgz"",
      ""integrity"": ""sha1-rEaBd8SUNAWgkvyPKXYMb/xiBsA="",
      ""dev"": true
    }},
    ""is-finite"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/is-finite/-/is-finite-1.0.2.tgz"",
      ""integrity"": ""sha1-zGZ3aVYCvlUO8R6LSqYwU0K20Ko="",
      ""dev"": true,
      ""requires"": {{
        ""number-is-nan"": ""1.0.1""
      }}
    }},
    ""is-fullwidth-code-point"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/is-fullwidth-code-point/-/is-fullwidth-code-point-1.0.0.tgz"",
      ""integrity"": ""sha1-754xOG8DGn8NZDr4L95QxFfvAMs="",
      ""dev"": true,
      ""requires"": {{
        ""number-is-nan"": ""1.0.1""
      }}
    }},
    ""is-glob"": {{
      ""version"": ""2.0.1"",
      ""resolved"": ""https://registry.npmjs.org/is-glob/-/is-glob-2.0.1.tgz"",
      ""integrity"": ""sha1-0Jb5JqPe1WAPP9/ZEZjLCIjC2GM="",
      ""dev"": true,
      ""requires"": {{
        ""is-extglob"": ""1.0.0""
      }}
    }},
    ""is-my-json-valid"": {{
      ""version"": ""2.17.1"",
      ""resolved"": ""https://registry.npmjs.org/is-my-json-valid/-/is-my-json-valid-2.17.1.tgz"",
      ""integrity"": ""sha512-Q2khNw+oBlWuaYvEEHtKSw/pCxD2L5Rc1C+UQme9X6JdRDh7m5D7HkozA0qa3DUkQ6VzCnEm8mVIQPyIRkI5sQ=="",
      ""dev"": true,
      ""requires"": {{
        ""generate-function"": ""2.0.0"",
        ""generate-object-property"": ""1.2.0"",
        ""jsonpointer"": ""4.0.1"",
        ""xtend"": ""4.0.1""
      }}
    }},
    ""is-number"": {{
      ""version"": ""2.1.0"",
      ""resolved"": ""https://registry.npmjs.org/is-number/-/is-number-2.1.0.tgz"",
      ""integrity"": ""sha1-Afy7s5NGOlSPL0ZszhbezknbkI8="",
      ""dev"": true,
      ""requires"": {{
        ""kind-of"": ""3.2.2""
      }}
    }},
    ""is-path-cwd"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/is-path-cwd/-/is-path-cwd-1.0.0.tgz"",
      ""integrity"": ""sha1-0iXsIxMuie3Tj9p2dHLmLmXxEG0="",
      ""dev"": true
    }},
    ""is-path-in-cwd"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/is-path-in-cwd/-/is-path-in-cwd-1.0.0.tgz"",
      ""integrity"": ""sha1-ZHdYK4IU1gI0YJRWcAO+ip6sBNw="",
      ""dev"": true,
      ""requires"": {{
        ""is-path-inside"": ""1.0.1""
      }}
    }},
    ""is-path-inside"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/is-path-inside/-/is-path-inside-1.0.1.tgz"",
      ""integrity"": ""sha1-jvW33lBDej/cprToZe96pVy0gDY="",
      ""dev"": true,
      ""requires"": {{
        ""path-is-inside"": ""1.0.2""
      }}
    }},
    ""is-plain-obj"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/is-plain-obj/-/is-plain-obj-1.1.0.tgz"",
      ""integrity"": ""sha1-caUMhCnfync8kqOQpKA7OfzVHT4="",
      ""dev"": true
    }},
    ""is-plain-object"": {{
      ""version"": ""2.0.4"",
      ""resolved"": ""https://registry.npmjs.org/is-plain-object/-/is-plain-object-2.0.4.tgz"",
      ""integrity"": ""sha512-h5PpgXkWitc38BBMYawTYMWJHFZJVnBquFE57xFpjB8pJFiF6gZ+bU+WyI/yqXiFR5mdLsgYNaPe8uao6Uv9Og=="",
      ""dev"": true,
      ""requires"": {{
        ""isobject"": ""3.0.1""
      }}
    }},
    ""is-posix-bracket"": {{
      ""version"": ""0.1.1"",
      ""resolved"": ""https://registry.npmjs.org/is-posix-bracket/-/is-posix-bracket-0.1.1.tgz"",
      ""integrity"": ""sha1-MzTceXdDaOkvAW5vvAqI9c1ua8Q="",
      ""dev"": true
    }},
    ""is-primitive"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/is-primitive/-/is-primitive-2.0.0.tgz"",
      ""integrity"": ""sha1-IHurkWOEmcB7Kt8kCkGochADRXU="",
      ""dev"": true
    }},
    ""is-property"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/is-property/-/is-property-1.0.2.tgz"",
      ""integrity"": ""sha1-V/4cTkhHTt1lsJkR8msc1Ald2oQ="",
      ""dev"": true
    }},
    ""is-regex"": {{
      ""version"": ""1.0.4"",
      ""resolved"": ""https://registry.npmjs.org/is-regex/-/is-regex-1.0.4.tgz"",
      ""integrity"": ""sha1-VRdIm1RwkbCTDglWVM7SXul+lJE="",
      ""dev"": true,
      ""requires"": {{
        ""has"": ""1.0.1""
      }}
    }},
    ""is-resolvable"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/is-resolvable/-/is-resolvable-1.0.1.tgz"",
      ""integrity"": ""sha512-y5CXYbzvB3jTnWAZH1Nl7ykUWb6T3BcTs56HUruwBf8MhF56n1HWqhDWnVFo8GHrUPDgvUUNVhrc2U8W7iqz5g=="",
      ""dev"": true
    }},
    ""is-stream"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/is-stream/-/is-stream-1.1.0.tgz"",
      ""integrity"": ""sha1-EtSj3U5o4Lec6428hBc66A2RykQ=""
    }},
    ""is-subset"": {{
      ""version"": ""0.1.1"",
      ""resolved"": ""https://registry.npmjs.org/is-subset/-/is-subset-0.1.1.tgz"",
      ""integrity"": ""sha1-ilkRfZMt4d4A8kX83TnOQ/HpOaY="",
      ""dev"": true
    }},
    ""is-svg"": {{
      ""version"": ""2.1.0"",
      ""resolved"": ""https://registry.npmjs.org/is-svg/-/is-svg-2.1.0.tgz"",
      ""integrity"": ""sha1-z2EJDaDZ77yrhyLeum8DIgjbsOk="",
      ""dev"": true,
      ""requires"": {{
        ""html-comment-regex"": ""1.1.1""
      }}
    }},
    ""is-symbol"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/is-symbol/-/is-symbol-1.0.1.tgz"",
      ""integrity"": ""sha1-PMWfAAJRlLarLjjbrmaJJWtmBXI="",
      ""dev"": true
    }},
    ""is-typedarray"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/is-typedarray/-/is-typedarray-1.0.0.tgz"",
      ""integrity"": ""sha1-5HnICFjfDBsR3dppQPlgEfzaSpo="",
      ""dev"": true
    }},
    ""is-utf8"": {{
      ""version"": ""0.2.1"",
      ""resolved"": ""https://registry.npmjs.org/is-utf8/-/is-utf8-0.2.1.tgz"",
      ""integrity"": ""sha1-Sw2hRCEE0bM2NA6AeX6GXPOffXI="",
      ""dev"": true
    }},
    ""is-windows"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/is-windows/-/is-windows-1.0.1.tgz"",
      ""integrity"": ""sha1-MQ23D3QtJZoWo2kgK1GvhCMzENk="",
      ""dev"": true
    }},
    ""isarray"": {{
      ""version"": ""0.0.1"",
      ""resolved"": ""https://registry.npmjs.org/isarray/-/isarray-0.0.1.tgz"",
      ""integrity"": ""sha1-ihis/Kmo9Bd+Cav8YDiTmwXR7t8=""
    }},
    ""isexe"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/isexe/-/isexe-2.0.0.tgz"",
      ""integrity"": ""sha1-6PvzdNxVb/iUehDcsFctYz8s+hA="",
      ""dev"": true
    }},
    ""isobject"": {{
      ""version"": ""3.0.1"",
      ""resolved"": ""https://registry.npmjs.org/isobject/-/isobject-3.0.1.tgz"",
      ""integrity"": ""sha1-TkMekrEalzFjaqH5yNHMvP2reN8="",
      ""dev"": true
    }},
    ""isomorphic-fetch"": {{
      ""version"": ""2.2.1"",
      ""resolved"": ""https://registry.npmjs.org/isomorphic-fetch/-/isomorphic-fetch-2.2.1.tgz"",
      ""integrity"": ""sha1-YRrhrPFPXoH3KVB0coGf6XM1WKk="",
      ""requires"": {{
        ""node-fetch"": ""1.7.3"",
        ""whatwg-fetch"": ""2.0.3""
      }}
    }},
    ""isstream"": {{
      ""version"": ""0.1.2"",
      ""resolved"": ""https://registry.npmjs.org/isstream/-/isstream-0.1.2.tgz"",
      ""integrity"": ""sha1-R+Y/evVa+m+S4VAOaQ64uFKcCZo="",
      ""dev"": true
    }},
    ""istanbul-api"": {{
      ""version"": ""1.2.1"",
      ""resolved"": ""https://registry.npmjs.org/istanbul-api/-/istanbul-api-1.2.1.tgz"",
      ""integrity"": ""sha512-oFCwXvd65amgaPCzqrR+a2XjanS1MvpXN6l/MlMUTv6uiA1NOgGX+I0uyq8Lg3GDxsxPsaP1049krz3hIJ5+KA=="",
      ""dev"": true,
      ""requires"": {{
        ""async"": ""2.6.0"",
        ""fileset"": ""2.0.3"",
        ""istanbul-lib-coverage"": ""1.1.1"",
        ""istanbul-lib-hook"": ""1.1.0"",
        ""istanbul-lib-instrument"": ""1.9.1"",
        ""istanbul-lib-report"": ""1.1.2"",
        ""istanbul-lib-source-maps"": ""1.2.2"",
        ""istanbul-reports"": ""1.1.3"",
        ""js-yaml"": ""3.7.0"",
        ""mkdirp"": ""0.5.1"",
        ""once"": ""1.4.0""
      }}
    }},
    ""istanbul-lib-coverage"": {{
      ""version"": ""1.1.1"",
      ""resolved"": ""https://registry.npmjs.org/istanbul-lib-coverage/-/istanbul-lib-coverage-1.1.1.tgz"",
      ""integrity"": ""sha512-0+1vDkmzxqJIn5rcoEqapSB4DmPxE31EtI2dF2aCkV5esN9EWHxZ0dwgDClivMXJqE7zaYQxq30hj5L0nlTN5Q=="",
      ""dev"": true
    }},
    ""istanbul-lib-hook"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/istanbul-lib-hook/-/istanbul-lib-hook-1.1.0.tgz"",
      ""integrity"": ""sha512-U3qEgwVDUerZ0bt8cfl3dSP3S6opBoOtk3ROO5f2EfBr/SRiD9FQqzwaZBqFORu8W7O0EXpai+k7kxHK13beRg=="",
      ""dev"": true,
      ""requires"": {{
        ""append-transform"": ""0.4.0""
      }}
    }},
    ""istanbul-lib-instrument"": {{
      ""version"": ""1.9.1"",
      ""resolved"": ""https://registry.npmjs.org/istanbul-lib-instrument/-/istanbul-lib-instrument-1.9.1.tgz"",
      ""integrity"": ""sha512-RQmXeQ7sphar7k7O1wTNzVczF9igKpaeGQAG9qR2L+BS4DCJNTI9nytRmIVYevwO0bbq+2CXvJmYDuz0gMrywA=="",
      ""dev"": true,
      ""requires"": {{
        ""babel-generator"": ""6.26.0"",
        ""babel-template"": ""6.26.0"",
        ""babel-traverse"": ""6.26.0"",
        ""babel-types"": ""6.26.0"",
        ""babylon"": ""6.18.0"",
        ""istanbul-lib-coverage"": ""1.1.1"",
        ""semver"": ""5.4.1""
      }}
    }},
    ""istanbul-lib-report"": {{
      ""version"": ""1.1.2"",
      ""resolved"": ""https://registry.npmjs.org/istanbul-lib-report/-/istanbul-lib-report-1.1.2.tgz"",
      ""integrity"": ""sha512-UTv4VGx+HZivJQwAo1wnRwe1KTvFpfi/NYwN7DcsrdzMXwpRT/Yb6r4SBPoHWj4VuQPakR32g4PUUeyKkdDkBA=="",
      ""dev"": true,
      ""requires"": {{
        ""istanbul-lib-coverage"": ""1.1.1"",
        ""mkdirp"": ""0.5.1"",
        ""path-parse"": ""1.0.5"",
        ""supports-color"": ""3.2.3""
      }}
    }},
    ""istanbul-lib-source-maps"": {{
      ""version"": ""1.2.2"",
      ""resolved"": ""https://registry.npmjs.org/istanbul-lib-source-maps/-/istanbul-lib-source-maps-1.2.2.tgz"",
      ""integrity"": ""sha512-8BfdqSfEdtip7/wo1RnrvLpHVEd8zMZEDmOFEnpC6dg0vXflHt9nvoAyQUzig2uMSXfF2OBEYBV3CVjIL9JvaQ=="",
      ""dev"": true,
      ""requires"": {{
        ""debug"": ""3.1.0"",
        ""istanbul-lib-coverage"": ""1.1.1"",
        ""mkdirp"": ""0.5.1"",
        ""rimraf"": ""2.6.2"",
        ""source-map"": ""0.5.7""
      }},
      ""dependencies"": {{
        ""debug"": {{
          ""version"": ""3.1.0"",
          ""resolved"": ""https://registry.npmjs.org/debug/-/debug-3.1.0.tgz"",
          ""integrity"": ""sha512-OX8XqP7/1a9cqkxYw2yXss15f26NKWBpDXQd0/uK/KPqdQhxbPa994hnzjcE2VqQpDslf55723cKPUOGSmMY3g=="",
          ""dev"": true,
          ""requires"": {{
            ""ms"": ""2.0.0""
          }}
        }},
        ""source-map"": {{
          ""version"": ""0.5.7"",
          ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.5.7.tgz"",
          ""integrity"": ""sha1-igOdLRAh0i0eoUyA2OpGi6LvP8w="",
          ""dev"": true
        }}
      }}
    }},
    ""istanbul-reports"": {{
      ""version"": ""1.1.3"",
      ""resolved"": ""https://registry.npmjs.org/istanbul-reports/-/istanbul-reports-1.1.3.tgz"",
      ""integrity"": ""sha512-ZEelkHh8hrZNI5xDaKwPMFwDsUf5wIEI2bXAFGp1e6deR2mnEKBPhLJEgr4ZBt8Gi6Mj38E/C8kcy9XLggVO2Q=="",
      ""dev"": true,
      ""requires"": {{
        ""handlebars"": ""4.0.11""
      }}
    }},
    ""jest"": {{
      ""version"": ""21.2.1"",
      ""resolved"": ""https://registry.npmjs.org/jest/-/jest-21.2.1.tgz"",
      ""integrity"": ""sha512-mXN0ppPvWYoIcC+R+ctKxAJ28xkt/Z5Js875padm4GbgUn6baeR5N4Ng6LjatIRpUQDZVJABT7Y4gucFjPryfw=="",
      ""dev"": true,
      ""requires"": {{
        ""jest-cli"": ""21.2.1""
      }},
      ""dependencies"": {{
        ""ansi-escapes"": {{
          ""version"": ""3.0.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-escapes/-/ansi-escapes-3.0.0.tgz"",
          ""integrity"": ""sha512-O/klc27mWNUigtv0F8NJWbLF00OcegQalkqKURWdosW08YZKi4m6CnSUSvIZG1otNJbTWhN01Hhz389DW7mvDQ=="",
          ""dev"": true
        }},
        ""ansi-regex"": {{
          ""version"": ""3.0.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-regex/-/ansi-regex-3.0.0.tgz"",
          ""integrity"": ""sha1-7QMXwyIGT3lGbAKWa922Bas32Zg="",
          ""dev"": true
        }},
        ""ansi-styles"": {{
          ""version"": ""3.2.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-styles/-/ansi-styles-3.2.0.tgz"",
          ""integrity"": ""sha512-NnSOmMEYtVR2JVMIGTzynRkkaxtiq1xnFBcdQD/DnNCYPoEPsVJhM98BDyaoNOQIi7p4okdi3E27eN7GQbsUug=="",
          ""dev"": true,
          ""requires"": {{
            ""color-convert"": ""1.9.1""
          }}
        }},
        ""camelcase"": {{
          ""version"": ""4.1.0"",
          ""resolved"": ""https://registry.npmjs.org/camelcase/-/camelcase-4.1.0.tgz"",
          ""integrity"": ""sha1-1UVjW+HjPFQmScaRc+Xeas+uNN0="",
          ""dev"": true
        }},
        ""chalk"": {{
          ""version"": ""2.3.0"",
          ""resolved"": ""https://registry.npmjs.org/chalk/-/chalk-2.3.0.tgz"",
          ""integrity"": ""sha512-Az5zJR2CBujap2rqXGaJKaPHyJ0IrUimvYNX+ncCy8PJP4ltOGTrHUIo097ZaL2zMeKYpiCdqDvS6zdrTFok3Q=="",
          ""dev"": true,
          ""requires"": {{
            ""ansi-styles"": ""3.2.0"",
            ""escape-string-regexp"": ""1.0.5"",
            ""supports-color"": ""4.5.0""
          }}
        }},
        ""execa"": {{
          ""version"": ""0.7.0"",
          ""resolved"": ""https://registry.npmjs.org/execa/-/execa-0.7.0.tgz"",
          ""integrity"": ""sha1-lEvs00zEHuMqY6n68nrVpl/Fl3c="",
          ""dev"": true,
          ""requires"": {{
            ""cross-spawn"": ""5.1.0"",
            ""get-stream"": ""3.0.0"",
            ""is-stream"": ""1.1.0"",
            ""npm-run-path"": ""2.0.2"",
            ""p-finally"": ""1.0.0"",
            ""signal-exit"": ""3.0.2"",
            ""strip-eof"": ""1.0.0""
          }}
        }},
        ""find-up"": {{
          ""version"": ""2.1.0"",
          ""resolved"": ""https://registry.npmjs.org/find-up/-/find-up-2.1.0.tgz"",
          ""integrity"": ""sha1-RdG35QbHF93UgndaK3eSCjwMV6c="",
          ""dev"": true,
          ""requires"": {{
            ""locate-path"": ""2.0.0""
          }}
        }},
        ""glob"": {{
          ""version"": ""7.1.2"",
          ""resolved"": ""https://registry.npmjs.org/glob/-/glob-7.1.2.tgz"",
          ""integrity"": ""sha512-MJTUg1kjuLeQCJ+ccE4Vpa6kKVXkPYJ2mOCQyUuKLcLQsdrMCpBPUi8qVE6+YuaJkozeA9NusTAw3hLr8Xe5EQ=="",
          ""dev"": true,
          ""requires"": {{
            ""fs.realpath"": ""1.0.0"",
            ""inflight"": ""1.0.6"",
            ""inherits"": ""2.0.3"",
            ""minimatch"": ""3.0.4"",
            ""once"": ""1.4.0"",
            ""path-is-absolute"": ""1.0.1""
          }}
        }},
        ""has-flag"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/has-flag/-/has-flag-2.0.0.tgz"",
          ""integrity"": ""sha1-6CB68cx7MNRGzHC3NLXovhj4jVE="",
          ""dev"": true
        }},
        ""is-fullwidth-code-point"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/is-fullwidth-code-point/-/is-fullwidth-code-point-2.0.0.tgz"",
          ""integrity"": ""sha1-o7MKXE8ZkYMWeqq5O+764937ZU8="",
          ""dev"": true
        }},
        ""jest-cli"": {{
          ""version"": ""21.2.1"",
          ""resolved"": ""https://registry.npmjs.org/jest-cli/-/jest-cli-21.2.1.tgz"",
          ""integrity"": ""sha512-T1BzrbFxDIW/LLYQqVfo94y/hhaj1NzVQkZgBumAC+sxbjMROI7VkihOdxNR758iYbQykL2ZOWUBurFgkQrzdg=="",
          ""dev"": true,
          ""requires"": {{
            ""ansi-escapes"": ""3.0.0"",
            ""chalk"": ""2.3.0"",
            ""glob"": ""7.1.2"",
            ""graceful-fs"": ""4.1.11"",
            ""is-ci"": ""1.1.0"",
            ""istanbul-api"": ""1.2.1"",
            ""istanbul-lib-coverage"": ""1.1.1"",
            ""istanbul-lib-instrument"": ""1.9.1"",
            ""istanbul-lib-source-maps"": ""1.2.2"",
            ""jest-changed-files"": ""21.2.0"",
            ""jest-config"": ""21.2.1"",
            ""jest-environment-jsdom"": ""21.2.1"",
            ""jest-haste-map"": ""21.2.0"",
            ""jest-message-util"": ""21.2.1"",
            ""jest-regex-util"": ""21.2.0"",
            ""jest-resolve-dependencies"": ""21.2.0"",
            ""jest-runner"": ""21.2.1"",
            ""jest-runtime"": ""21.2.1"",
            ""jest-snapshot"": ""21.2.1"",
            ""jest-util"": ""21.2.1"",
            ""micromatch"": ""2.3.11"",
            ""node-notifier"": ""5.2.1"",
            ""pify"": ""3.0.0"",
            ""slash"": ""1.0.0"",
            ""string-length"": ""2.0.0"",
            ""strip-ansi"": ""4.0.0"",
            ""which"": ""1.3.0"",
            ""worker-farm"": ""1.5.2"",
            ""yargs"": ""9.0.1""
          }}
        }},
        ""load-json-file"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/load-json-file/-/load-json-file-2.0.0.tgz"",
          ""integrity"": ""sha1-eUfkIUmvgNaWy/eXvKq8/h/inKg="",
          ""dev"": true,
          ""requires"": {{
            ""graceful-fs"": ""4.1.11"",
            ""parse-json"": ""2.2.0"",
            ""pify"": ""2.3.0"",
            ""strip-bom"": ""3.0.0""
          }},
          ""dependencies"": {{
            ""pify"": {{
              ""version"": ""2.3.0"",
              ""resolved"": ""https://registry.npmjs.org/pify/-/pify-2.3.0.tgz"",
              ""integrity"": ""sha1-7RQaasBDqEnqWISY59yosVMw6Qw="",
              ""dev"": true
            }}
          }}
        }},
        ""npm-run-path"": {{
          ""version"": ""2.0.2"",
          ""resolved"": ""https://registry.npmjs.org/npm-run-path/-/npm-run-path-2.0.2.tgz"",
          ""integrity"": ""sha1-NakjLfo11wZ7TLLd8jV7GHFTbF8="",
          ""dev"": true,
          ""requires"": {{
            ""path-key"": ""2.0.1""
          }}
        }},
        ""os-locale"": {{
          ""version"": ""2.1.0"",
          ""resolved"": ""https://registry.npmjs.org/os-locale/-/os-locale-2.1.0.tgz"",
          ""integrity"": ""sha512-3sslG3zJbEYcaC4YVAvDorjGxc7tv6KVATnLPZONiljsUncvihe9BQoVCEs0RZ1kmf4Hk9OBqlZfJZWI4GanKA=="",
          ""dev"": true,
          ""requires"": {{
            ""execa"": ""0.7.0"",
            ""lcid"": ""1.0.0"",
            ""mem"": ""1.1.0""
          }}
        }},
        ""path-key"": {{
          ""version"": ""2.0.1"",
          ""resolved"": ""https://registry.npmjs.org/path-key/-/path-key-2.0.1.tgz"",
          ""integrity"": ""sha1-QRyttXTFoUDTpLGRDUDYDMn0C0A="",
          ""dev"": true
        }},
        ""path-type"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/path-type/-/path-type-2.0.0.tgz"",
          ""integrity"": ""sha1-8BLMuEFbcJb8LaoQVMPXI4lZTHM="",
          ""dev"": true,
          ""requires"": {{
            ""pify"": ""2.3.0""
          }},
          ""dependencies"": {{
            ""pify"": {{
              ""version"": ""2.3.0"",
              ""resolved"": ""https://registry.npmjs.org/pify/-/pify-2.3.0.tgz"",
              ""integrity"": ""sha1-7RQaasBDqEnqWISY59yosVMw6Qw="",
              ""dev"": true
            }}
          }}
        }},
        ""pify"": {{
          ""version"": ""3.0.0"",
          ""resolved"": ""https://registry.npmjs.org/pify/-/pify-3.0.0.tgz"",
          ""integrity"": ""sha1-5aSs0sEB/fPZpNB/DbxNtJ3SgXY="",
          ""dev"": true
        }},
        ""read-pkg"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/read-pkg/-/read-pkg-2.0.0.tgz"",
          ""integrity"": ""sha1-jvHAYjxqbbDcZxPEv6xGMysjaPg="",
          ""dev"": true,
          ""requires"": {{
            ""load-json-file"": ""2.0.0"",
            ""normalize-package-data"": ""2.4.0"",
            ""path-type"": ""2.0.0""
          }}
        }},
        ""read-pkg-up"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/read-pkg-up/-/read-pkg-up-2.0.0.tgz"",
          ""integrity"": ""sha1-a3KoBImE4MQeeVEP1en6mbO1Sb4="",
          ""dev"": true,
          ""requires"": {{
            ""find-up"": ""2.1.0"",
            ""read-pkg"": ""2.0.0""
          }}
        }},
        ""string-width"": {{
          ""version"": ""2.1.1"",
          ""resolved"": ""https://registry.npmjs.org/string-width/-/string-width-2.1.1.tgz"",
          ""integrity"": ""sha512-nOqH59deCq9SRHlxq1Aw85Jnt4w6KvLKqWVik6oA9ZklXLNIOlqg4F2yrT1MVaTjAqvVwdfeZ7w7aCvJD7ugkw=="",
          ""dev"": true,
          ""requires"": {{
            ""is-fullwidth-code-point"": ""2.0.0"",
            ""strip-ansi"": ""4.0.0""
          }}
        }},
        ""strip-ansi"": {{
          ""version"": ""4.0.0"",
          ""resolved"": ""https://registry.npmjs.org/strip-ansi/-/strip-ansi-4.0.0.tgz"",
          ""integrity"": ""sha1-qEeQIusaw2iocTibY1JixQXuNo8="",
          ""dev"": true,
          ""requires"": {{
            ""ansi-regex"": ""3.0.0""
          }}
        }},
        ""strip-bom"": {{
          ""version"": ""3.0.0"",
          ""resolved"": ""https://registry.npmjs.org/strip-bom/-/strip-bom-3.0.0.tgz"",
          ""integrity"": ""sha1-IzTBjpx1n3vdVv3vfprj1YjmjtM="",
          ""dev"": true
        }},
        ""supports-color"": {{
          ""version"": ""4.5.0"",
          ""resolved"": ""https://registry.npmjs.org/supports-color/-/supports-color-4.5.0.tgz"",
          ""integrity"": ""sha1-vnoN5ITexcXN34s9WRJQRJEvY1s="",
          ""dev"": true,
          ""requires"": {{
            ""has-flag"": ""2.0.0""
          }}
        }},
        ""which-module"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/which-module/-/which-module-2.0.0.tgz"",
          ""integrity"": ""sha1-2e8H3Od7mQK4o6j6SzHD4/fm6Ho="",
          ""dev"": true
        }},
        ""yargs"": {{
          ""version"": ""9.0.1"",
          ""resolved"": ""https://registry.npmjs.org/yargs/-/yargs-9.0.1.tgz"",
          ""integrity"": ""sha1-UqzCP+7Kw0BCB47njAwAf1CF20w="",
          ""dev"": true,
          ""requires"": {{
            ""camelcase"": ""4.1.0"",
            ""cliui"": ""3.2.0"",
            ""decamelize"": ""1.2.0"",
            ""get-caller-file"": ""1.0.2"",
            ""os-locale"": ""2.1.0"",
            ""read-pkg-up"": ""2.0.0"",
            ""require-directory"": ""2.1.1"",
            ""require-main-filename"": ""1.0.1"",
            ""set-blocking"": ""2.0.0"",
            ""string-width"": ""2.1.1"",
            ""which-module"": ""2.0.0"",
            ""y18n"": ""3.2.1"",
            ""yargs-parser"": ""7.0.0""
          }}
        }},
        ""yargs-parser"": {{
          ""version"": ""7.0.0"",
          ""resolved"": ""https://registry.npmjs.org/yargs-parser/-/yargs-parser-7.0.0.tgz"",
          ""integrity"": ""sha1-jQrELxbqVd69MyyvTEA4s+P139k="",
          ""dev"": true,
          ""requires"": {{
            ""camelcase"": ""4.1.0""
          }}
        }}
      }}
    }},
    ""jest-changed-files"": {{
      ""version"": ""21.2.0"",
      ""resolved"": ""https://registry.npmjs.org/jest-changed-files/-/jest-changed-files-21.2.0.tgz"",
      ""integrity"": ""sha512-+lCNP1IZLwN1NOIvBcV5zEL6GENK6TXrDj4UxWIeLvIsIDa+gf6J7hkqsW2qVVt/wvH65rVvcPwqXdps5eclTQ=="",
      ""dev"": true,
      ""requires"": {{
        ""throat"": ""4.1.0""
      }}
    }},
    ""jest-config"": {{
      ""version"": ""21.2.1"",
      ""resolved"": ""https://registry.npmjs.org/jest-config/-/jest-config-21.2.1.tgz"",
      ""integrity"": ""sha512-fJru5HtlD/5l2o25eY9xT0doK3t2dlglrqoGpbktduyoI0T5CwuB++2YfoNZCrgZipTwPuAGonYv0q7+8yDc/A=="",
      ""dev"": true,
      ""requires"": {{
        ""chalk"": ""2.3.0"",
        ""glob"": ""7.1.2"",
        ""jest-environment-jsdom"": ""21.2.1"",
        ""jest-environment-node"": ""21.2.1"",
        ""jest-get-type"": ""21.2.0"",
        ""jest-jasmine2"": ""21.2.1"",
        ""jest-regex-util"": ""21.2.0"",
        ""jest-resolve"": ""21.2.0"",
        ""jest-util"": ""21.2.1"",
        ""jest-validate"": ""21.2.1"",
        ""pretty-format"": ""21.2.1""
      }},
      ""dependencies"": {{
        ""ansi-styles"": {{
          ""version"": ""3.2.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-styles/-/ansi-styles-3.2.0.tgz"",
          ""integrity"": ""sha512-NnSOmMEYtVR2JVMIGTzynRkkaxtiq1xnFBcdQD/DnNCYPoEPsVJhM98BDyaoNOQIi7p4okdi3E27eN7GQbsUug=="",
          ""dev"": true,
          ""requires"": {{
            ""color-convert"": ""1.9.1""
          }}
        }},
        ""chalk"": {{
          ""version"": ""2.3.0"",
          ""resolved"": ""https://registry.npmjs.org/chalk/-/chalk-2.3.0.tgz"",
          ""integrity"": ""sha512-Az5zJR2CBujap2rqXGaJKaPHyJ0IrUimvYNX+ncCy8PJP4ltOGTrHUIo097ZaL2zMeKYpiCdqDvS6zdrTFok3Q=="",
          ""dev"": true,
          ""requires"": {{
            ""ansi-styles"": ""3.2.0"",
            ""escape-string-regexp"": ""1.0.5"",
            ""supports-color"": ""4.5.0""
          }}
        }},
        ""glob"": {{
          ""version"": ""7.1.2"",
          ""resolved"": ""https://registry.npmjs.org/glob/-/glob-7.1.2.tgz"",
          ""integrity"": ""sha512-MJTUg1kjuLeQCJ+ccE4Vpa6kKVXkPYJ2mOCQyUuKLcLQsdrMCpBPUi8qVE6+YuaJkozeA9NusTAw3hLr8Xe5EQ=="",
          ""dev"": true,
          ""requires"": {{
            ""fs.realpath"": ""1.0.0"",
            ""inflight"": ""1.0.6"",
            ""inherits"": ""2.0.3"",
            ""minimatch"": ""3.0.4"",
            ""once"": ""1.4.0"",
            ""path-is-absolute"": ""1.0.1""
          }}
        }},
        ""has-flag"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/has-flag/-/has-flag-2.0.0.tgz"",
          ""integrity"": ""sha1-6CB68cx7MNRGzHC3NLXovhj4jVE="",
          ""dev"": true
        }},
        ""supports-color"": {{
          ""version"": ""4.5.0"",
          ""resolved"": ""https://registry.npmjs.org/supports-color/-/supports-color-4.5.0.tgz"",
          ""integrity"": ""sha1-vnoN5ITexcXN34s9WRJQRJEvY1s="",
          ""dev"": true,
          ""requires"": {{
            ""has-flag"": ""2.0.0""
          }}
        }}
      }}
    }},
    ""jest-diff"": {{
      ""version"": ""21.2.1"",
      ""resolved"": ""https://registry.npmjs.org/jest-diff/-/jest-diff-21.2.1.tgz"",
      ""integrity"": ""sha512-E5fu6r7PvvPr5qAWE1RaUwIh/k6Zx/3OOkZ4rk5dBJkEWRrUuSgbMt2EO8IUTPTd6DOqU3LW6uTIwX5FRvXoFA=="",
      ""dev"": true,
      ""requires"": {{
        ""chalk"": ""2.3.0"",
        ""diff"": ""3.4.0"",
        ""jest-get-type"": ""21.2.0"",
        ""pretty-format"": ""21.2.1""
      }},
      ""dependencies"": {{
        ""ansi-styles"": {{
          ""version"": ""3.2.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-styles/-/ansi-styles-3.2.0.tgz"",
          ""integrity"": ""sha512-NnSOmMEYtVR2JVMIGTzynRkkaxtiq1xnFBcdQD/DnNCYPoEPsVJhM98BDyaoNOQIi7p4okdi3E27eN7GQbsUug=="",
          ""dev"": true,
          ""requires"": {{
            ""color-convert"": ""1.9.1""
          }}
        }},
        ""chalk"": {{
          ""version"": ""2.3.0"",
          ""resolved"": ""https://registry.npmjs.org/chalk/-/chalk-2.3.0.tgz"",
          ""integrity"": ""sha512-Az5zJR2CBujap2rqXGaJKaPHyJ0IrUimvYNX+ncCy8PJP4ltOGTrHUIo097ZaL2zMeKYpiCdqDvS6zdrTFok3Q=="",
          ""dev"": true,
          ""requires"": {{
            ""ansi-styles"": ""3.2.0"",
            ""escape-string-regexp"": ""1.0.5"",
            ""supports-color"": ""4.5.0""
          }}
        }},
        ""diff"": {{
          ""version"": ""3.4.0"",
          ""resolved"": ""https://registry.npmjs.org/diff/-/diff-3.4.0.tgz"",
          ""integrity"": ""sha512-QpVuMTEoJMF7cKzi6bvWhRulU1fZqZnvyVQgNhPaxxuTYwyjn/j1v9falseQ/uXWwPnO56RBfwtg4h/EQXmucA=="",
          ""dev"": true
        }},
        ""has-flag"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/has-flag/-/has-flag-2.0.0.tgz"",
          ""integrity"": ""sha1-6CB68cx7MNRGzHC3NLXovhj4jVE="",
          ""dev"": true
        }},
        ""supports-color"": {{
          ""version"": ""4.5.0"",
          ""resolved"": ""https://registry.npmjs.org/supports-color/-/supports-color-4.5.0.tgz"",
          ""integrity"": ""sha1-vnoN5ITexcXN34s9WRJQRJEvY1s="",
          ""dev"": true,
          ""requires"": {{
            ""has-flag"": ""2.0.0""
          }}
        }}
      }}
    }},
    ""jest-docblock"": {{
      ""version"": ""21.2.0"",
      ""resolved"": ""https://registry.npmjs.org/jest-docblock/-/jest-docblock-21.2.0.tgz"",
      ""integrity"": ""sha512-5IZ7sY9dBAYSV+YjQ0Ovb540Ku7AO9Z5o2Cg789xj167iQuZ2cG+z0f3Uct6WeYLbU6aQiM2pCs7sZ+4dotydw=="",
      ""dev"": true
    }},
    ""jest-environment-jsdom"": {{
      ""version"": ""21.2.1"",
      ""resolved"": ""https://registry.npmjs.org/jest-environment-jsdom/-/jest-environment-jsdom-21.2.1.tgz"",
      ""integrity"": ""sha512-mecaeNh0eWmzNrUNMWARysc0E9R96UPBamNiOCYL28k7mksb1d0q6DD38WKP7ABffjnXyUWJPVaWRgUOivwXwg=="",
      ""dev"": true,
      ""requires"": {{
        ""jest-mock"": ""21.2.0"",
        ""jest-util"": ""21.2.1"",
        ""jsdom"": ""9.12.0""
      }}
    }},
    ""jest-environment-node"": {{
      ""version"": ""21.2.1"",
      ""resolved"": ""https://registry.npmjs.org/jest-environment-node/-/jest-environment-node-21.2.1.tgz"",
      ""integrity"": ""sha512-R211867wx9mVBVHzrjGRGTy5cd05K7eqzQl/WyZixR/VkJ4FayS8qkKXZyYnwZi6Rxo6WEV81cDbiUx/GfuLNw=="",
      ""dev"": true,
      ""requires"": {{
        ""jest-mock"": ""21.2.0"",
        ""jest-util"": ""21.2.1""
      }}
    }},
    ""jest-get-type"": {{
      ""version"": ""21.2.0"",
      ""resolved"": ""https://registry.npmjs.org/jest-get-type/-/jest-get-type-21.2.0.tgz"",
      ""integrity"": ""sha512-y2fFw3C+D0yjNSDp7ab1kcd6NUYfy3waPTlD8yWkAtiocJdBRQqNoRqVfMNxgj+IjT0V5cBIHJO0z9vuSSZ43Q=="",
      ""dev"": true
    }},
    ""jest-haste-map"": {{
      ""version"": ""21.2.0"",
      ""resolved"": ""https://registry.npmjs.org/jest-haste-map/-/jest-haste-map-21.2.0.tgz"",
      ""integrity"": ""sha512-5LhsY/loPH7wwOFRMs+PT4aIAORJ2qwgbpMFlbWbxfN0bk3ZCwxJ530vrbSiTstMkYLao6JwBkLhCJ5XbY7ZHw=="",
      ""dev"": true,
      ""requires"": {{
        ""fb-watchman"": ""2.0.0"",
        ""graceful-fs"": ""4.1.11"",
        ""jest-docblock"": ""21.2.0"",
        ""micromatch"": ""2.3.11"",
        ""sane"": ""2.2.0"",
        ""worker-farm"": ""1.5.2""
      }}
    }},
    ""jest-jasmine2"": {{
      ""version"": ""21.2.1"",
      ""resolved"": ""https://registry.npmjs.org/jest-jasmine2/-/jest-jasmine2-21.2.1.tgz"",
      ""integrity"": ""sha512-lw8FXXIEekD+jYNlStfgNsUHpfMWhWWCgHV7n0B7mA/vendH7vBFs8xybjQsDzJSduptBZJHqQX9SMssya9+3A=="",
      ""dev"": true,
      ""requires"": {{
        ""chalk"": ""2.3.0"",
        ""expect"": ""21.2.1"",
        ""graceful-fs"": ""4.1.11"",
        ""jest-diff"": ""21.2.1"",
        ""jest-matcher-utils"": ""21.2.1"",
        ""jest-message-util"": ""21.2.1"",
        ""jest-snapshot"": ""21.2.1"",
        ""p-cancelable"": ""0.3.0""
      }},
      ""dependencies"": {{
        ""ansi-styles"": {{
          ""version"": ""3.2.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-styles/-/ansi-styles-3.2.0.tgz"",
          ""integrity"": ""sha512-NnSOmMEYtVR2JVMIGTzynRkkaxtiq1xnFBcdQD/DnNCYPoEPsVJhM98BDyaoNOQIi7p4okdi3E27eN7GQbsUug=="",
          ""dev"": true,
          ""requires"": {{
            ""color-convert"": ""1.9.1""
          }}
        }},
        ""chalk"": {{
          ""version"": ""2.3.0"",
          ""resolved"": ""https://registry.npmjs.org/chalk/-/chalk-2.3.0.tgz"",
          ""integrity"": ""sha512-Az5zJR2CBujap2rqXGaJKaPHyJ0IrUimvYNX+ncCy8PJP4ltOGTrHUIo097ZaL2zMeKYpiCdqDvS6zdrTFok3Q=="",
          ""dev"": true,
          ""requires"": {{
            ""ansi-styles"": ""3.2.0"",
            ""escape-string-regexp"": ""1.0.5"",
            ""supports-color"": ""4.5.0""
          }}
        }},
        ""has-flag"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/has-flag/-/has-flag-2.0.0.tgz"",
          ""integrity"": ""sha1-6CB68cx7MNRGzHC3NLXovhj4jVE="",
          ""dev"": true
        }},
        ""supports-color"": {{
          ""version"": ""4.5.0"",
          ""resolved"": ""https://registry.npmjs.org/supports-color/-/supports-color-4.5.0.tgz"",
          ""integrity"": ""sha1-vnoN5ITexcXN34s9WRJQRJEvY1s="",
          ""dev"": true,
          ""requires"": {{
            ""has-flag"": ""2.0.0""
          }}
        }}
      }}
    }},
    ""jest-matcher-utils"": {{
      ""version"": ""21.2.1"",
      ""resolved"": ""https://registry.npmjs.org/jest-matcher-utils/-/jest-matcher-utils-21.2.1.tgz"",
      ""integrity"": ""sha512-kn56My+sekD43dwQPrXBl9Zn9tAqwoy25xxe7/iY4u+mG8P3ALj5IK7MLHZ4Mi3xW7uWVCjGY8cm4PqgbsqMCg=="",
      ""dev"": true,
      ""requires"": {{
        ""chalk"": ""2.3.0"",
        ""jest-get-type"": ""21.2.0"",
        ""pretty-format"": ""21.2.1""
      }},
      ""dependencies"": {{
        ""ansi-styles"": {{
          ""version"": ""3.2.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-styles/-/ansi-styles-3.2.0.tgz"",
          ""integrity"": ""sha512-NnSOmMEYtVR2JVMIGTzynRkkaxtiq1xnFBcdQD/DnNCYPoEPsVJhM98BDyaoNOQIi7p4okdi3E27eN7GQbsUug=="",
          ""dev"": true,
          ""requires"": {{
            ""color-convert"": ""1.9.1""
          }}
        }},
        ""chalk"": {{
          ""version"": ""2.3.0"",
          ""resolved"": ""https://registry.npmjs.org/chalk/-/chalk-2.3.0.tgz"",
          ""integrity"": ""sha512-Az5zJR2CBujap2rqXGaJKaPHyJ0IrUimvYNX+ncCy8PJP4ltOGTrHUIo097ZaL2zMeKYpiCdqDvS6zdrTFok3Q=="",
          ""dev"": true,
          ""requires"": {{
            ""ansi-styles"": ""3.2.0"",
            ""escape-string-regexp"": ""1.0.5"",
            ""supports-color"": ""4.5.0""
          }}
        }},
        ""has-flag"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/has-flag/-/has-flag-2.0.0.tgz"",
          ""integrity"": ""sha1-6CB68cx7MNRGzHC3NLXovhj4jVE="",
          ""dev"": true
        }},
        ""supports-color"": {{
          ""version"": ""4.5.0"",
          ""resolved"": ""https://registry.npmjs.org/supports-color/-/supports-color-4.5.0.tgz"",
          ""integrity"": ""sha1-vnoN5ITexcXN34s9WRJQRJEvY1s="",
          ""dev"": true,
          ""requires"": {{
            ""has-flag"": ""2.0.0""
          }}
        }}
      }}
    }},
    ""jest-message-util"": {{
      ""version"": ""21.2.1"",
      ""resolved"": ""https://registry.npmjs.org/jest-message-util/-/jest-message-util-21.2.1.tgz"",
      ""integrity"": ""sha512-EbC1X2n0t9IdeMECJn2BOg7buOGivCvVNjqKMXTzQOu7uIfLml+keUfCALDh8o4rbtndIeyGU8/BKfoTr/LVDQ=="",
      ""dev"": true,
      ""requires"": {{
        ""chalk"": ""2.3.0"",
        ""micromatch"": ""2.3.11"",
        ""slash"": ""1.0.0""
      }},
      ""dependencies"": {{
        ""ansi-styles"": {{
          ""version"": ""3.2.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-styles/-/ansi-styles-3.2.0.tgz"",
          ""integrity"": ""sha512-NnSOmMEYtVR2JVMIGTzynRkkaxtiq1xnFBcdQD/DnNCYPoEPsVJhM98BDyaoNOQIi7p4okdi3E27eN7GQbsUug=="",
          ""dev"": true,
          ""requires"": {{
            ""color-convert"": ""1.9.1""
          }}
        }},
        ""chalk"": {{
          ""version"": ""2.3.0"",
          ""resolved"": ""https://registry.npmjs.org/chalk/-/chalk-2.3.0.tgz"",
          ""integrity"": ""sha512-Az5zJR2CBujap2rqXGaJKaPHyJ0IrUimvYNX+ncCy8PJP4ltOGTrHUIo097ZaL2zMeKYpiCdqDvS6zdrTFok3Q=="",
          ""dev"": true,
          ""requires"": {{
            ""ansi-styles"": ""3.2.0"",
            ""escape-string-regexp"": ""1.0.5"",
            ""supports-color"": ""4.5.0""
          }}
        }},
        ""has-flag"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/has-flag/-/has-flag-2.0.0.tgz"",
          ""integrity"": ""sha1-6CB68cx7MNRGzHC3NLXovhj4jVE="",
          ""dev"": true
        }},
        ""supports-color"": {{
          ""version"": ""4.5.0"",
          ""resolved"": ""https://registry.npmjs.org/supports-color/-/supports-color-4.5.0.tgz"",
          ""integrity"": ""sha1-vnoN5ITexcXN34s9WRJQRJEvY1s="",
          ""dev"": true,
          ""requires"": {{
            ""has-flag"": ""2.0.0""
          }}
        }}
      }}
    }},
    ""jest-mock"": {{
      ""version"": ""21.2.0"",
      ""resolved"": ""https://registry.npmjs.org/jest-mock/-/jest-mock-21.2.0.tgz"",
      ""integrity"": ""sha512-aZDfyVf0LEoABWiY6N0d+O963dUQSyUa4qgzurHR3TBDPen0YxKCJ6l2i7lQGh1tVdsuvdrCZ4qPj+A7PievCw=="",
      ""dev"": true
    }},
    ""jest-regex-util"": {{
      ""version"": ""21.2.0"",
      ""resolved"": ""https://registry.npmjs.org/jest-regex-util/-/jest-regex-util-21.2.0.tgz"",
      ""integrity"": ""sha512-BKQ1F83EQy0d9Jen/mcVX7D+lUt2tthhK/2gDWRgLDJRNOdRgSp1iVqFxP8EN1ARuypvDflRfPzYT8fQnoBQFQ=="",
      ""dev"": true
    }},
    ""jest-resolve"": {{
      ""version"": ""21.2.0"",
      ""resolved"": ""https://registry.npmjs.org/jest-resolve/-/jest-resolve-21.2.0.tgz"",
      ""integrity"": ""sha512-vefQ/Lr+VdNvHUZFQXWtOqHX3HEdOc2MtSahBO89qXywEbUxGPB9ZLP9+BHinkxb60UT2Q/tTDOS6rYc6Mwigw=="",
      ""dev"": true,
      ""requires"": {{
        ""browser-resolve"": ""1.11.2"",
        ""chalk"": ""2.3.0"",
        ""is-builtin-module"": ""1.0.0""
      }},
      ""dependencies"": {{
        ""ansi-styles"": {{
          ""version"": ""3.2.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-styles/-/ansi-styles-3.2.0.tgz"",
          ""integrity"": ""sha512-NnSOmMEYtVR2JVMIGTzynRkkaxtiq1xnFBcdQD/DnNCYPoEPsVJhM98BDyaoNOQIi7p4okdi3E27eN7GQbsUug=="",
          ""dev"": true,
          ""requires"": {{
            ""color-convert"": ""1.9.1""
          }}
        }},
        ""chalk"": {{
          ""version"": ""2.3.0"",
          ""resolved"": ""https://registry.npmjs.org/chalk/-/chalk-2.3.0.tgz"",
          ""integrity"": ""sha512-Az5zJR2CBujap2rqXGaJKaPHyJ0IrUimvYNX+ncCy8PJP4ltOGTrHUIo097ZaL2zMeKYpiCdqDvS6zdrTFok3Q=="",
          ""dev"": true,
          ""requires"": {{
            ""ansi-styles"": ""3.2.0"",
            ""escape-string-regexp"": ""1.0.5"",
            ""supports-color"": ""4.5.0""
          }}
        }},
        ""has-flag"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/has-flag/-/has-flag-2.0.0.tgz"",
          ""integrity"": ""sha1-6CB68cx7MNRGzHC3NLXovhj4jVE="",
          ""dev"": true
        }},
        ""supports-color"": {{
          ""version"": ""4.5.0"",
          ""resolved"": ""https://registry.npmjs.org/supports-color/-/supports-color-4.5.0.tgz"",
          ""integrity"": ""sha1-vnoN5ITexcXN34s9WRJQRJEvY1s="",
          ""dev"": true,
          ""requires"": {{
            ""has-flag"": ""2.0.0""
          }}
        }}
      }}
    }},
    ""jest-resolve-dependencies"": {{
      ""version"": ""21.2.0"",
      ""resolved"": ""https://registry.npmjs.org/jest-resolve-dependencies/-/jest-resolve-dependencies-21.2.0.tgz"",
      ""integrity"": ""sha512-ok8ybRFU5ScaAcfufIQrCbdNJSRZ85mkxJ1EhUp8Bhav1W1/jv/rl1Q6QoVQHObNxmKnbHVKrfLZbCbOsXQ+bQ=="",
      ""dev"": true,
      ""requires"": {{
        ""jest-regex-util"": ""21.2.0""
      }}
    }},
    ""jest-runner"": {{
      ""version"": ""21.2.1"",
      ""resolved"": ""https://registry.npmjs.org/jest-runner/-/jest-runner-21.2.1.tgz"",
      ""integrity"": ""sha512-Anb72BOQlHqF/zETqZ2K20dbYsnqW/nZO7jV8BYENl+3c44JhMrA8zd1lt52+N7ErnsQMd2HHKiVwN9GYSXmrg=="",
      ""dev"": true,
      ""requires"": {{
        ""jest-config"": ""21.2.1"",
        ""jest-docblock"": ""21.2.0"",
        ""jest-haste-map"": ""21.2.0"",
        ""jest-jasmine2"": ""21.2.1"",
        ""jest-message-util"": ""21.2.1"",
        ""jest-runtime"": ""21.2.1"",
        ""jest-util"": ""21.2.1"",
        ""pify"": ""3.0.0"",
        ""throat"": ""4.1.0"",
        ""worker-farm"": ""1.5.2""
      }},
      ""dependencies"": {{
        ""pify"": {{
          ""version"": ""3.0.0"",
          ""resolved"": ""https://registry.npmjs.org/pify/-/pify-3.0.0.tgz"",
          ""integrity"": ""sha1-5aSs0sEB/fPZpNB/DbxNtJ3SgXY="",
          ""dev"": true
        }}
      }}
    }},
    ""jest-runtime"": {{
      ""version"": ""21.2.1"",
      ""resolved"": ""https://registry.npmjs.org/jest-runtime/-/jest-runtime-21.2.1.tgz"",
      ""integrity"": ""sha512-6omlpA3+NSE+rHwD0PQjNEjZeb2z+oRmuehMfM1tWQVum+E0WV3pFt26Am0DUfQkkPyTABvxITRjCUclYgSOsA=="",
      ""dev"": true,
      ""requires"": {{
        ""babel-core"": ""6.26.0"",
        ""babel-jest"": ""21.2.0"",
        ""babel-plugin-istanbul"": ""4.1.5"",
        ""chalk"": ""2.3.0"",
        ""convert-source-map"": ""1.5.1"",
        ""graceful-fs"": ""4.1.11"",
        ""jest-config"": ""21.2.1"",
        ""jest-haste-map"": ""21.2.0"",
        ""jest-regex-util"": ""21.2.0"",
        ""jest-resolve"": ""21.2.0"",
        ""jest-util"": ""21.2.1"",
        ""json-stable-stringify"": ""1.0.1"",
        ""micromatch"": ""2.3.11"",
        ""slash"": ""1.0.0"",
        ""strip-bom"": ""3.0.0"",
        ""write-file-atomic"": ""2.3.0"",
        ""yargs"": ""9.0.1""
      }},
      ""dependencies"": {{
        ""ansi-regex"": {{
          ""version"": ""3.0.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-regex/-/ansi-regex-3.0.0.tgz"",
          ""integrity"": ""sha1-7QMXwyIGT3lGbAKWa922Bas32Zg="",
          ""dev"": true
        }},
        ""ansi-styles"": {{
          ""version"": ""3.2.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-styles/-/ansi-styles-3.2.0.tgz"",
          ""integrity"": ""sha512-NnSOmMEYtVR2JVMIGTzynRkkaxtiq1xnFBcdQD/DnNCYPoEPsVJhM98BDyaoNOQIi7p4okdi3E27eN7GQbsUug=="",
          ""dev"": true,
          ""requires"": {{
            ""color-convert"": ""1.9.1""
          }}
        }},
        ""camelcase"": {{
          ""version"": ""4.1.0"",
          ""resolved"": ""https://registry.npmjs.org/camelcase/-/camelcase-4.1.0.tgz"",
          ""integrity"": ""sha1-1UVjW+HjPFQmScaRc+Xeas+uNN0="",
          ""dev"": true
        }},
        ""chalk"": {{
          ""version"": ""2.3.0"",
          ""resolved"": ""https://registry.npmjs.org/chalk/-/chalk-2.3.0.tgz"",
          ""integrity"": ""sha512-Az5zJR2CBujap2rqXGaJKaPHyJ0IrUimvYNX+ncCy8PJP4ltOGTrHUIo097ZaL2zMeKYpiCdqDvS6zdrTFok3Q=="",
          ""dev"": true,
          ""requires"": {{
            ""ansi-styles"": ""3.2.0"",
            ""escape-string-regexp"": ""1.0.5"",
            ""supports-color"": ""4.5.0""
          }}
        }},
        ""execa"": {{
          ""version"": ""0.7.0"",
          ""resolved"": ""https://registry.npmjs.org/execa/-/execa-0.7.0.tgz"",
          ""integrity"": ""sha1-lEvs00zEHuMqY6n68nrVpl/Fl3c="",
          ""dev"": true,
          ""requires"": {{
            ""cross-spawn"": ""5.1.0"",
            ""get-stream"": ""3.0.0"",
            ""is-stream"": ""1.1.0"",
            ""npm-run-path"": ""2.0.2"",
            ""p-finally"": ""1.0.0"",
            ""signal-exit"": ""3.0.2"",
            ""strip-eof"": ""1.0.0""
          }}
        }},
        ""find-up"": {{
          ""version"": ""2.1.0"",
          ""resolved"": ""https://registry.npmjs.org/find-up/-/find-up-2.1.0.tgz"",
          ""integrity"": ""sha1-RdG35QbHF93UgndaK3eSCjwMV6c="",
          ""dev"": true,
          ""requires"": {{
            ""locate-path"": ""2.0.0""
          }}
        }},
        ""has-flag"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/has-flag/-/has-flag-2.0.0.tgz"",
          ""integrity"": ""sha1-6CB68cx7MNRGzHC3NLXovhj4jVE="",
          ""dev"": true
        }},
        ""is-fullwidth-code-point"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/is-fullwidth-code-point/-/is-fullwidth-code-point-2.0.0.tgz"",
          ""integrity"": ""sha1-o7MKXE8ZkYMWeqq5O+764937ZU8="",
          ""dev"": true
        }},
        ""load-json-file"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/load-json-file/-/load-json-file-2.0.0.tgz"",
          ""integrity"": ""sha1-eUfkIUmvgNaWy/eXvKq8/h/inKg="",
          ""dev"": true,
          ""requires"": {{
            ""graceful-fs"": ""4.1.11"",
            ""parse-json"": ""2.2.0"",
            ""pify"": ""2.3.0"",
            ""strip-bom"": ""3.0.0""
          }}
        }},
        ""npm-run-path"": {{
          ""version"": ""2.0.2"",
          ""resolved"": ""https://registry.npmjs.org/npm-run-path/-/npm-run-path-2.0.2.tgz"",
          ""integrity"": ""sha1-NakjLfo11wZ7TLLd8jV7GHFTbF8="",
          ""dev"": true,
          ""requires"": {{
            ""path-key"": ""2.0.1""
          }}
        }},
        ""os-locale"": {{
          ""version"": ""2.1.0"",
          ""resolved"": ""https://registry.npmjs.org/os-locale/-/os-locale-2.1.0.tgz"",
          ""integrity"": ""sha512-3sslG3zJbEYcaC4YVAvDorjGxc7tv6KVATnLPZONiljsUncvihe9BQoVCEs0RZ1kmf4Hk9OBqlZfJZWI4GanKA=="",
          ""dev"": true,
          ""requires"": {{
            ""execa"": ""0.7.0"",
            ""lcid"": ""1.0.0"",
            ""mem"": ""1.1.0""
          }}
        }},
        ""path-key"": {{
          ""version"": ""2.0.1"",
          ""resolved"": ""https://registry.npmjs.org/path-key/-/path-key-2.0.1.tgz"",
          ""integrity"": ""sha1-QRyttXTFoUDTpLGRDUDYDMn0C0A="",
          ""dev"": true
        }},
        ""path-type"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/path-type/-/path-type-2.0.0.tgz"",
          ""integrity"": ""sha1-8BLMuEFbcJb8LaoQVMPXI4lZTHM="",
          ""dev"": true,
          ""requires"": {{
            ""pify"": ""2.3.0""
          }}
        }},
        ""read-pkg"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/read-pkg/-/read-pkg-2.0.0.tgz"",
          ""integrity"": ""sha1-jvHAYjxqbbDcZxPEv6xGMysjaPg="",
          ""dev"": true,
          ""requires"": {{
            ""load-json-file"": ""2.0.0"",
            ""normalize-package-data"": ""2.4.0"",
            ""path-type"": ""2.0.0""
          }}
        }},
        ""read-pkg-up"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/read-pkg-up/-/read-pkg-up-2.0.0.tgz"",
          ""integrity"": ""sha1-a3KoBImE4MQeeVEP1en6mbO1Sb4="",
          ""dev"": true,
          ""requires"": {{
            ""find-up"": ""2.1.0"",
            ""read-pkg"": ""2.0.0""
          }}
        }},
        ""string-width"": {{
          ""version"": ""2.1.1"",
          ""resolved"": ""https://registry.npmjs.org/string-width/-/string-width-2.1.1.tgz"",
          ""integrity"": ""sha512-nOqH59deCq9SRHlxq1Aw85Jnt4w6KvLKqWVik6oA9ZklXLNIOlqg4F2yrT1MVaTjAqvVwdfeZ7w7aCvJD7ugkw=="",
          ""dev"": true,
          ""requires"": {{
            ""is-fullwidth-code-point"": ""2.0.0"",
            ""strip-ansi"": ""4.0.0""
          }}
        }},
        ""strip-ansi"": {{
          ""version"": ""4.0.0"",
          ""resolved"": ""https://registry.npmjs.org/strip-ansi/-/strip-ansi-4.0.0.tgz"",
          ""integrity"": ""sha1-qEeQIusaw2iocTibY1JixQXuNo8="",
          ""dev"": true,
          ""requires"": {{
            ""ansi-regex"": ""3.0.0""
          }}
        }},
        ""strip-bom"": {{
          ""version"": ""3.0.0"",
          ""resolved"": ""https://registry.npmjs.org/strip-bom/-/strip-bom-3.0.0.tgz"",
          ""integrity"": ""sha1-IzTBjpx1n3vdVv3vfprj1YjmjtM="",
          ""dev"": true
        }},
        ""supports-color"": {{
          ""version"": ""4.5.0"",
          ""resolved"": ""https://registry.npmjs.org/supports-color/-/supports-color-4.5.0.tgz"",
          ""integrity"": ""sha1-vnoN5ITexcXN34s9WRJQRJEvY1s="",
          ""dev"": true,
          ""requires"": {{
            ""has-flag"": ""2.0.0""
          }}
        }},
        ""which-module"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/which-module/-/which-module-2.0.0.tgz"",
          ""integrity"": ""sha1-2e8H3Od7mQK4o6j6SzHD4/fm6Ho="",
          ""dev"": true
        }},
        ""write-file-atomic"": {{
          ""version"": ""2.3.0"",
          ""resolved"": ""https://registry.npmjs.org/write-file-atomic/-/write-file-atomic-2.3.0.tgz"",
          ""integrity"": ""sha512-xuPeK4OdjWqtfi59ylvVL0Yn35SF3zgcAcv7rBPFHVaEapaDr4GdGgm3j7ckTwH9wHL7fGmgfAnb0+THrHb8tA=="",
          ""dev"": true,
          ""requires"": {{
            ""graceful-fs"": ""4.1.11"",
            ""imurmurhash"": ""0.1.4"",
            ""signal-exit"": ""3.0.2""
          }}
        }},
        ""yargs"": {{
          ""version"": ""9.0.1"",
          ""resolved"": ""https://registry.npmjs.org/yargs/-/yargs-9.0.1.tgz"",
          ""integrity"": ""sha1-UqzCP+7Kw0BCB47njAwAf1CF20w="",
          ""dev"": true,
          ""requires"": {{
            ""camelcase"": ""4.1.0"",
            ""cliui"": ""3.2.0"",
            ""decamelize"": ""1.2.0"",
            ""get-caller-file"": ""1.0.2"",
            ""os-locale"": ""2.1.0"",
            ""read-pkg-up"": ""2.0.0"",
            ""require-directory"": ""2.1.1"",
            ""require-main-filename"": ""1.0.1"",
            ""set-blocking"": ""2.0.0"",
            ""string-width"": ""2.1.1"",
            ""which-module"": ""2.0.0"",
            ""y18n"": ""3.2.1"",
            ""yargs-parser"": ""7.0.0""
          }}
        }},
        ""yargs-parser"": {{
          ""version"": ""7.0.0"",
          ""resolved"": ""https://registry.npmjs.org/yargs-parser/-/yargs-parser-7.0.0.tgz"",
          ""integrity"": ""sha1-jQrELxbqVd69MyyvTEA4s+P139k="",
          ""dev"": true,
          ""requires"": {{
            ""camelcase"": ""4.1.0""
          }}
        }}
      }}
    }},
    ""jest-snapshot"": {{
      ""version"": ""21.2.1"",
      ""resolved"": ""https://registry.npmjs.org/jest-snapshot/-/jest-snapshot-21.2.1.tgz"",
      ""integrity"": ""sha512-bpaeBnDpdqaRTzN8tWg0DqOTo2DvD3StOemxn67CUd1p1Po+BUpvePAp44jdJ7Pxcjfg+42o4NHw1SxdCA2rvg=="",
      ""dev"": true,
      ""requires"": {{
        ""chalk"": ""2.3.0"",
        ""jest-diff"": ""21.2.1"",
        ""jest-matcher-utils"": ""21.2.1"",
        ""mkdirp"": ""0.5.1"",
        ""natural-compare"": ""1.4.0"",
        ""pretty-format"": ""21.2.1""
      }},
      ""dependencies"": {{
        ""ansi-styles"": {{
          ""version"": ""3.2.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-styles/-/ansi-styles-3.2.0.tgz"",
          ""integrity"": ""sha512-NnSOmMEYtVR2JVMIGTzynRkkaxtiq1xnFBcdQD/DnNCYPoEPsVJhM98BDyaoNOQIi7p4okdi3E27eN7GQbsUug=="",
          ""dev"": true,
          ""requires"": {{
            ""color-convert"": ""1.9.1""
          }}
        }},
        ""chalk"": {{
          ""version"": ""2.3.0"",
          ""resolved"": ""https://registry.npmjs.org/chalk/-/chalk-2.3.0.tgz"",
          ""integrity"": ""sha512-Az5zJR2CBujap2rqXGaJKaPHyJ0IrUimvYNX+ncCy8PJP4ltOGTrHUIo097ZaL2zMeKYpiCdqDvS6zdrTFok3Q=="",
          ""dev"": true,
          ""requires"": {{
            ""ansi-styles"": ""3.2.0"",
            ""escape-string-regexp"": ""1.0.5"",
            ""supports-color"": ""4.5.0""
          }}
        }},
        ""has-flag"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/has-flag/-/has-flag-2.0.0.tgz"",
          ""integrity"": ""sha1-6CB68cx7MNRGzHC3NLXovhj4jVE="",
          ""dev"": true
        }},
        ""supports-color"": {{
          ""version"": ""4.5.0"",
          ""resolved"": ""https://registry.npmjs.org/supports-color/-/supports-color-4.5.0.tgz"",
          ""integrity"": ""sha1-vnoN5ITexcXN34s9WRJQRJEvY1s="",
          ""dev"": true,
          ""requires"": {{
            ""has-flag"": ""2.0.0""
          }}
        }}
      }}
    }},
    ""jest-util"": {{
      ""version"": ""21.2.1"",
      ""resolved"": ""https://registry.npmjs.org/jest-util/-/jest-util-21.2.1.tgz"",
      ""integrity"": ""sha512-r20W91rmHY3fnCoO7aOAlyfC51x2yeV3xF+prGsJAUsYhKeV670ZB8NO88Lwm7ASu8SdH0S+U+eFf498kjhA4g=="",
      ""dev"": true,
      ""requires"": {{
        ""callsites"": ""2.0.0"",
        ""chalk"": ""2.3.0"",
        ""graceful-fs"": ""4.1.11"",
        ""jest-message-util"": ""21.2.1"",
        ""jest-mock"": ""21.2.0"",
        ""jest-validate"": ""21.2.1"",
        ""mkdirp"": ""0.5.1""
      }},
      ""dependencies"": {{
        ""ansi-styles"": {{
          ""version"": ""3.2.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-styles/-/ansi-styles-3.2.0.tgz"",
          ""integrity"": ""sha512-NnSOmMEYtVR2JVMIGTzynRkkaxtiq1xnFBcdQD/DnNCYPoEPsVJhM98BDyaoNOQIi7p4okdi3E27eN7GQbsUug=="",
          ""dev"": true,
          ""requires"": {{
            ""color-convert"": ""1.9.1""
          }}
        }},
        ""callsites"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/callsites/-/callsites-2.0.0.tgz"",
          ""integrity"": ""sha1-BuuE8A7qQT2oav/vrL/7Ngk7PFA="",
          ""dev"": true
        }},
        ""chalk"": {{
          ""version"": ""2.3.0"",
          ""resolved"": ""https://registry.npmjs.org/chalk/-/chalk-2.3.0.tgz"",
          ""integrity"": ""sha512-Az5zJR2CBujap2rqXGaJKaPHyJ0IrUimvYNX+ncCy8PJP4ltOGTrHUIo097ZaL2zMeKYpiCdqDvS6zdrTFok3Q=="",
          ""dev"": true,
          ""requires"": {{
            ""ansi-styles"": ""3.2.0"",
            ""escape-string-regexp"": ""1.0.5"",
            ""supports-color"": ""4.5.0""
          }}
        }},
        ""has-flag"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/has-flag/-/has-flag-2.0.0.tgz"",
          ""integrity"": ""sha1-6CB68cx7MNRGzHC3NLXovhj4jVE="",
          ""dev"": true
        }},
        ""supports-color"": {{
          ""version"": ""4.5.0"",
          ""resolved"": ""https://registry.npmjs.org/supports-color/-/supports-color-4.5.0.tgz"",
          ""integrity"": ""sha1-vnoN5ITexcXN34s9WRJQRJEvY1s="",
          ""dev"": true,
          ""requires"": {{
            ""has-flag"": ""2.0.0""
          }}
        }}
      }}
    }},
    ""jest-validate"": {{
      ""version"": ""21.2.1"",
      ""resolved"": ""https://registry.npmjs.org/jest-validate/-/jest-validate-21.2.1.tgz"",
      ""integrity"": ""sha512-k4HLI1rZQjlU+EC682RlQ6oZvLrE5SCh3brseQc24vbZTxzT/k/3urar5QMCVgjadmSO7lECeGdc6YxnM3yEGg=="",
      ""dev"": true,
      ""requires"": {{
        ""chalk"": ""2.3.0"",
        ""jest-get-type"": ""21.2.0"",
        ""leven"": ""2.1.0"",
        ""pretty-format"": ""21.2.1""
      }},
      ""dependencies"": {{
        ""ansi-styles"": {{
          ""version"": ""3.2.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-styles/-/ansi-styles-3.2.0.tgz"",
          ""integrity"": ""sha512-NnSOmMEYtVR2JVMIGTzynRkkaxtiq1xnFBcdQD/DnNCYPoEPsVJhM98BDyaoNOQIi7p4okdi3E27eN7GQbsUug=="",
          ""dev"": true,
          ""requires"": {{
            ""color-convert"": ""1.9.1""
          }}
        }},
        ""chalk"": {{
          ""version"": ""2.3.0"",
          ""resolved"": ""https://registry.npmjs.org/chalk/-/chalk-2.3.0.tgz"",
          ""integrity"": ""sha512-Az5zJR2CBujap2rqXGaJKaPHyJ0IrUimvYNX+ncCy8PJP4ltOGTrHUIo097ZaL2zMeKYpiCdqDvS6zdrTFok3Q=="",
          ""dev"": true,
          ""requires"": {{
            ""ansi-styles"": ""3.2.0"",
            ""escape-string-regexp"": ""1.0.5"",
            ""supports-color"": ""4.5.0""
          }}
        }},
        ""has-flag"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/has-flag/-/has-flag-2.0.0.tgz"",
          ""integrity"": ""sha1-6CB68cx7MNRGzHC3NLXovhj4jVE="",
          ""dev"": true
        }},
        ""supports-color"": {{
          ""version"": ""4.5.0"",
          ""resolved"": ""https://registry.npmjs.org/supports-color/-/supports-color-4.5.0.tgz"",
          ""integrity"": ""sha1-vnoN5ITexcXN34s9WRJQRJEvY1s="",
          ""dev"": true,
          ""requires"": {{
            ""has-flag"": ""2.0.0""
          }}
        }}
      }}
    }},
    ""js-base64"": {{
      ""version"": ""2.4.0"",
      ""resolved"": ""https://registry.npmjs.org/js-base64/-/js-base64-2.4.0.tgz"",
      ""integrity"": ""sha512-Wehd+7Pf9tFvGb+ydPm9TjYjV8X1YHOVyG8QyELZxEMqOhemVwGRmoG8iQ/soqI3n8v4xn59zaLxiCJiaaRzKA=="",
      ""dev"": true
    }},
    ""js-tokens"": {{
      ""version"": ""3.0.2"",
      ""resolved"": ""https://registry.npmjs.org/js-tokens/-/js-tokens-3.0.2.tgz"",
      ""integrity"": ""sha1-mGbfOVECEw449/mWvOtlRDIJwls=""
    }},
    ""js-yaml"": {{
      ""version"": ""3.7.0"",
      ""resolved"": ""https://registry.npmjs.org/js-yaml/-/js-yaml-3.7.0.tgz"",
      ""integrity"": ""sha1-XJZ93YN6m/3KXy3oQlOr6KHAO4A="",
      ""dev"": true,
      ""requires"": {{
        ""argparse"": ""1.0.9"",
        ""esprima"": ""2.7.3""
      }},
      ""dependencies"": {{
        ""esprima"": {{
          ""version"": ""2.7.3"",
          ""resolved"": ""https://registry.npmjs.org/esprima/-/esprima-2.7.3.tgz"",
          ""integrity"": ""sha1-luO3DVd59q1JzQMmc9HDEnZ7pYE="",
          ""dev"": true
        }}
      }}
    }},
    ""jsbn"": {{
      ""version"": ""0.1.1"",
      ""resolved"": ""https://registry.npmjs.org/jsbn/-/jsbn-0.1.1.tgz"",
      ""integrity"": ""sha1-peZUwuWi3rXyAdls77yoDA7y9RM="",
      ""dev"": true,
      ""optional"": true
    }},
    ""jsdom"": {{
      ""version"": ""9.12.0"",
      ""resolved"": ""https://registry.npmjs.org/jsdom/-/jsdom-9.12.0.tgz"",
      ""integrity"": ""sha1-6MVG//ywbADUgzyoRBD+1/igl9Q="",
      ""dev"": true,
      ""requires"": {{
        ""abab"": ""1.0.4"",
        ""acorn"": ""4.0.13"",
        ""acorn-globals"": ""3.1.0"",
        ""array-equal"": ""1.0.0"",
        ""content-type-parser"": ""1.0.2"",
        ""cssom"": ""0.3.2"",
        ""cssstyle"": ""0.2.37"",
        ""escodegen"": ""1.9.0"",
        ""html-encoding-sniffer"": ""1.0.2"",
        ""nwmatcher"": ""1.4.3"",
        ""parse5"": ""1.5.1"",
        ""request"": ""2.83.0"",
        ""sax"": ""1.2.4"",
        ""symbol-tree"": ""3.2.2"",
        ""tough-cookie"": ""2.3.3"",
        ""webidl-conversions"": ""4.0.2"",
        ""whatwg-encoding"": ""1.0.3"",
        ""whatwg-url"": ""4.8.0"",
        ""xml-name-validator"": ""2.0.1""
      }},
      ""dependencies"": {{
        ""acorn"": {{
          ""version"": ""4.0.13"",
          ""resolved"": ""https://registry.npmjs.org/acorn/-/acorn-4.0.13.tgz"",
          ""integrity"": ""sha1-EFSVrlNh1pe9GVyCUZLhrX8lN4c="",
          ""dev"": true
        }}
      }}
    }},
    ""jsesc"": {{
      ""version"": ""1.3.0"",
      ""resolved"": ""https://registry.npmjs.org/jsesc/-/jsesc-1.3.0.tgz"",
      ""integrity"": ""sha1-RsP+yMGJKxKwgz25vHYiF226s0s="",
      ""dev"": true
    }},
    ""json-loader"": {{
      ""version"": ""0.5.7"",
      ""resolved"": ""https://registry.npmjs.org/json-loader/-/json-loader-0.5.7.tgz"",
      ""integrity"": ""sha512-QLPs8Dj7lnf3e3QYS1zkCo+4ZwqOiF9d/nZnYozTISxXWCfNs9yuky5rJw4/W34s7POaNlbZmQGaB5NiXCbP4w=="",
      ""dev"": true
    }},
    ""json-schema"": {{
      ""version"": ""0.2.3"",
      ""resolved"": ""https://registry.npmjs.org/json-schema/-/json-schema-0.2.3.tgz"",
      ""integrity"": ""sha1-tIDIkuWaLwWVTOcnvT8qTogvnhM="",
      ""dev"": true
    }},
    ""json-schema-traverse"": {{
      ""version"": ""0.3.1"",
      ""resolved"": ""https://registry.npmjs.org/json-schema-traverse/-/json-schema-traverse-0.3.1.tgz"",
      ""integrity"": ""sha1-NJptRMU6Ud6JtAgFxdXlm0F9M0A="",
      ""dev"": true
    }},
    ""json-stable-stringify"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/json-stable-stringify/-/json-stable-stringify-1.0.1.tgz"",
      ""integrity"": ""sha1-mnWdOcXy/1A/1TAGRu1EX4jE+a8="",
      ""dev"": true,
      ""requires"": {{
        ""jsonify"": ""0.0.0""
      }}
    }},
    ""json-stringify-safe"": {{
      ""version"": ""5.0.1"",
      ""resolved"": ""https://registry.npmjs.org/json-stringify-safe/-/json-stringify-safe-5.0.1.tgz"",
      ""integrity"": ""sha1-Epai1Y/UXxmg9s4B1lcB4sc1tus="",
      ""dev"": true
    }},
    ""json3"": {{
      ""version"": ""3.3.2"",
      ""resolved"": ""https://registry.npmjs.org/json3/-/json3-3.3.2.tgz"",
      ""integrity"": ""sha1-PAQ0dD35Pi9cQq7nsZvLSDV19OE="",
      ""dev"": true
    }},
    ""json5"": {{
      ""version"": ""0.5.1"",
      ""resolved"": ""https://registry.npmjs.org/json5/-/json5-0.5.1.tgz"",
      ""integrity"": ""sha1-Hq3nrMASA0rYTiOWdn6tn6VJWCE="",
      ""dev"": true
    }},
    ""jsonfile"": {{
      ""version"": ""2.4.0"",
      ""resolved"": ""https://registry.npmjs.org/jsonfile/-/jsonfile-2.4.0.tgz"",
      ""integrity"": ""sha1-NzaitCi4e72gzIO1P6PWM6NcKug="",
      ""dev"": true,
      ""requires"": {{
        ""graceful-fs"": ""4.1.11""
      }}
    }},
    ""jsonify"": {{
      ""version"": ""0.0.0"",
      ""resolved"": ""https://registry.npmjs.org/jsonify/-/jsonify-0.0.0.tgz"",
      ""integrity"": ""sha1-LHS27kHZPKUbe1qu6PUDYx0lKnM="",
      ""dev"": true
    }},
    ""jsonpointer"": {{
      ""version"": ""4.0.1"",
      ""resolved"": ""https://registry.npmjs.org/jsonpointer/-/jsonpointer-4.0.1.tgz"",
      ""integrity"": ""sha1-T9kss04OnbPInIYi7PUfm5eMbLk="",
      ""dev"": true
    }},
    ""jsprim"": {{
      ""version"": ""1.4.1"",
      ""resolved"": ""https://registry.npmjs.org/jsprim/-/jsprim-1.4.1.tgz"",
      ""integrity"": ""sha1-MT5mvB5cwG5Di8G3SZwuXFastqI="",
      ""dev"": true,
      ""requires"": {{
        ""assert-plus"": ""1.0.0"",
        ""extsprintf"": ""1.3.0"",
        ""json-schema"": ""0.2.3"",
        ""verror"": ""1.10.0""
      }}
    }},
    ""keycode"": {{
      ""version"": ""2.1.9"",
      ""resolved"": ""https://registry.npmjs.org/keycode/-/keycode-2.1.9.tgz"",
      ""integrity"": ""sha1-lkojxU5IiUBbSGGlyfBIDUUUHfo=""
    }},
    ""keymirror"": {{
      ""version"": ""0.1.1"",
      ""resolved"": ""https://registry.npmjs.org/keymirror/-/keymirror-0.1.1.tgz"",
      ""integrity"": ""sha1-kYiJ6hP40KQufFVyUO7nE63JXDU="",
      ""dev"": true
    }},
    ""kind-of"": {{
      ""version"": ""3.2.2"",
      ""resolved"": ""https://registry.npmjs.org/kind-of/-/kind-of-3.2.2.tgz"",
      ""integrity"": ""sha1-MeohpzS6ubuw8yRm2JOupR5KPGQ="",
      ""dev"": true,
      ""requires"": {{
        ""is-buffer"": ""1.1.6""
      }}
    }},
    ""klaw"": {{
      ""version"": ""1.3.1"",
      ""resolved"": ""https://registry.npmjs.org/klaw/-/klaw-1.3.1.tgz"",
      ""integrity"": ""sha1-QIhDO0azsbolnXh4XY6W9zugJDk="",
      ""dev"": true,
      ""requires"": {{
        ""graceful-fs"": ""4.1.11""
      }}
    }},
    ""lazy-cache"": {{
      ""version"": ""0.2.7"",
      ""resolved"": ""https://registry.npmjs.org/lazy-cache/-/lazy-cache-0.2.7.tgz"",
      ""integrity"": ""sha1-f+3fLctu23fRHvHRF6tf/fCrG2U="",
      ""dev"": true
    }},
    ""lcid"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/lcid/-/lcid-1.0.0.tgz"",
      ""integrity"": ""sha1-MIrMr6C8SDo4Z7S28rlQYlHRuDU="",
      ""dev"": true,
      ""requires"": {{
        ""invert-kv"": ""1.0.0""
      }}
    }},
    ""leven"": {{
      ""version"": ""2.1.0"",
      ""resolved"": ""https://registry.npmjs.org/leven/-/leven-2.1.0.tgz"",
      ""integrity"": ""sha1-wuep93IJTe6dNCAq6KzORoeHVYA="",
      ""dev"": true
    }},
    ""levn"": {{
      ""version"": ""0.3.0"",
      ""resolved"": ""https://registry.npmjs.org/levn/-/levn-0.3.0.tgz"",
      ""integrity"": ""sha1-OwmSTt+fCDwEkP3UwLxEIeBHZO4="",
      ""dev"": true,
      ""requires"": {{
        ""prelude-ls"": ""1.1.2"",
        ""type-check"": ""0.3.2""
      }}
    }},
    ""load-json-file"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/load-json-file/-/load-json-file-1.1.0.tgz"",
      ""integrity"": ""sha1-lWkFcI1YtLq0wiYbBPWfMcmTdMA="",
      ""dev"": true,
      ""requires"": {{
        ""graceful-fs"": ""4.1.11"",
        ""parse-json"": ""2.2.0"",
        ""pify"": ""2.3.0"",
        ""pinkie-promise"": ""2.0.1"",
        ""strip-bom"": ""2.0.0""
      }}
    }},
    ""loader-runner"": {{
      ""version"": ""2.3.0"",
      ""resolved"": ""https://registry.npmjs.org/loader-runner/-/loader-runner-2.3.0.tgz"",
      ""integrity"": ""sha1-9IKuqC1UPgeSFwDVpG7yb9rGuKI="",
      ""dev"": true
    }},
    ""loader-utils"": {{
      ""version"": ""0.2.17"",
      ""resolved"": ""https://registry.npmjs.org/loader-utils/-/loader-utils-0.2.17.tgz"",
      ""integrity"": ""sha1-+G5jdNQyBabmxg6RlvF8Apm/s0g="",
      ""dev"": true,
      ""requires"": {{
        ""big.js"": ""3.2.0"",
        ""emojis-list"": ""2.1.0"",
        ""json5"": ""0.5.1"",
        ""object-assign"": ""4.1.1""
      }}
    }},
    ""localforage"": {{
      ""version"": ""1.5.6"",
      ""resolved"": ""https://registry.npmjs.org/localforage/-/localforage-1.5.6.tgz"",
      ""integrity"": ""sha1-0DTRXlNy7pfGQXPpqa65aBX13QY="",
      ""requires"": {{
        ""lie"": ""3.1.1""
      }},
      ""dependencies"": {{
        ""lie"": {{
          ""version"": ""3.1.1"",
          ""resolved"": ""https://registry.npmjs.org/lie/-/lie-3.1.1.tgz"",
          ""integrity"": ""sha1-mkNrLMd0bKWd56QfpGmz77dr2H4="",
          ""requires"": {{
            ""immediate"": ""3.0.6""
          }}
        }}
      }}
    }},
    ""locate-path"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/locate-path/-/locate-path-2.0.0.tgz"",
      ""integrity"": ""sha1-K1aLJl7slExtnA3pw9u7ygNUzY4="",
      ""dev"": true,
      ""requires"": {{
        ""p-locate"": ""2.0.0"",
        ""path-exists"": ""3.0.0""
      }},
      ""dependencies"": {{
        ""path-exists"": {{
          ""version"": ""3.0.0"",
          ""resolved"": ""https://registry.npmjs.org/path-exists/-/path-exists-3.0.0.tgz"",
          ""integrity"": ""sha1-zg6+ql94yxiSXqfYENe1mwEP1RU="",
          ""dev"": true
        }}
      }}
    }},
    ""lodash"": {{
      ""version"": ""4.17.4"",
      ""resolved"": ""https://registry.npmjs.org/lodash/-/lodash-4.17.4.tgz"",
      ""integrity"": ""sha1-eCA6TRwyiuHYbcpkYONptX9AVa4=""
    }},
    ""lodash-es"": {{
      ""version"": ""4.17.4"",
      ""resolved"": ""https://registry.npmjs.org/lodash-es/-/lodash-es-4.17.4.tgz"",
      ""integrity"": ""sha1-3MHXVS4VCgZABzupyzHXDwMpUOc=""
    }},
    ""lodash._arraycopy"": {{
      ""version"": ""3.0.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash._arraycopy/-/lodash._arraycopy-3.0.0.tgz"",
      ""integrity"": ""sha1-due3wfH7klRzdIeKVi7Qaj5Q9uE="",
      ""dev"": true
    }},
    ""lodash._arrayeach"": {{
      ""version"": ""3.0.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash._arrayeach/-/lodash._arrayeach-3.0.0.tgz"",
      ""integrity"": ""sha1-urFWsqkNPxu9XGU0AzSeXlkz754="",
      ""dev"": true
    }},
    ""lodash._baseassign"": {{
      ""version"": ""3.2.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash._baseassign/-/lodash._baseassign-3.2.0.tgz"",
      ""integrity"": ""sha1-jDigmVAPIVrQnlnxci/QxSv+Ck4="",
      ""dev"": true,
      ""requires"": {{
        ""lodash._basecopy"": ""3.0.1"",
        ""lodash.keys"": ""3.1.2""
      }}
    }},
    ""lodash._basecallback"": {{
      ""version"": ""3.3.1"",
      ""resolved"": ""https://registry.npmjs.org/lodash._basecallback/-/lodash._basecallback-3.3.1.tgz"",
      ""integrity"": ""sha1-t7K7Q9whYEJKIczybFfkQ3cqjic="",
      ""dev"": true,
      ""requires"": {{
        ""lodash._baseisequal"": ""3.0.7"",
        ""lodash._bindcallback"": ""3.0.1"",
        ""lodash.isarray"": ""3.0.4"",
        ""lodash.pairs"": ""3.0.1""
      }}
    }},
    ""lodash._baseclone"": {{
      ""version"": ""4.5.7"",
      ""resolved"": ""https://registry.npmjs.org/lodash._baseclone/-/lodash._baseclone-4.5.7.tgz"",
      ""integrity"": ""sha1-zkKt4IOE711i+nfDD2GkbmhvhDQ="",
      ""dev"": true
    }},
    ""lodash._basecopy"": {{
      ""version"": ""3.0.1"",
      ""resolved"": ""https://registry.npmjs.org/lodash._basecopy/-/lodash._basecopy-3.0.1.tgz"",
      ""integrity"": ""sha1-jaDmqHbPNEwK2KVIghEd08XHyjY="",
      ""dev"": true
    }},
    ""lodash._baseeach"": {{
      ""version"": ""3.0.4"",
      ""resolved"": ""https://registry.npmjs.org/lodash._baseeach/-/lodash._baseeach-3.0.4.tgz"",
      ""integrity"": ""sha1-z4cGVyyhROjZ11InyZDamC+TKvM="",
      ""dev"": true,
      ""requires"": {{
        ""lodash.keys"": ""3.1.2""
      }}
    }},
    ""lodash._basefind"": {{
      ""version"": ""3.0.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash._basefind/-/lodash._basefind-3.0.0.tgz"",
      ""integrity"": ""sha1-srugXMZF+XLeLPkl+iv2Og9gyK4="",
      ""dev"": true
    }},
    ""lodash._basefindindex"": {{
      ""version"": ""3.6.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash._basefindindex/-/lodash._basefindindex-3.6.0.tgz"",
      ""integrity"": ""sha1-8IM2ChsCJBjtgbyJm+sxLiHnSk8="",
      ""dev"": true
    }},
    ""lodash._basefor"": {{
      ""version"": ""3.0.3"",
      ""resolved"": ""https://registry.npmjs.org/lodash._basefor/-/lodash._basefor-3.0.3.tgz"",
      ""integrity"": ""sha1-dVC06SGO8J+tJDQ7YSAhx5tMIMI="",
      ""dev"": true
    }},
    ""lodash._baseisequal"": {{
      ""version"": ""3.0.7"",
      ""resolved"": ""https://registry.npmjs.org/lodash._baseisequal/-/lodash._baseisequal-3.0.7.tgz"",
      ""integrity"": ""sha1-2AJfdjOdKTQnZ9zIh85cuVpbUfE="",
      ""dev"": true,
      ""requires"": {{
        ""lodash.isarray"": ""3.0.4"",
        ""lodash.istypedarray"": ""3.0.6"",
        ""lodash.keys"": ""3.1.2""
      }}
    }},
    ""lodash._bindcallback"": {{
      ""version"": ""3.0.1"",
      ""resolved"": ""https://registry.npmjs.org/lodash._bindcallback/-/lodash._bindcallback-3.0.1.tgz"",
      ""integrity"": ""sha1-5THCdkTPi1epnhftlbNcdIeJOS4="",
      ""dev"": true
    }},
    ""lodash._createassigner"": {{
      ""version"": ""3.1.1"",
      ""resolved"": ""https://registry.npmjs.org/lodash._createassigner/-/lodash._createassigner-3.1.1.tgz"",
      ""integrity"": ""sha1-g4pbri/aymOsIt7o4Z+k5taXCxE="",
      ""dev"": true,
      ""requires"": {{
        ""lodash._bindcallback"": ""3.0.1"",
        ""lodash._isiterateecall"": ""3.0.9"",
        ""lodash.restparam"": ""3.6.1""
      }}
    }},
    ""lodash._getnative"": {{
      ""version"": ""3.9.1"",
      ""resolved"": ""https://registry.npmjs.org/lodash._getnative/-/lodash._getnative-3.9.1.tgz"",
      ""integrity"": ""sha1-VwvH3t5G1hzc3mh9ZdPuy6o6r/U="",
      ""dev"": true
    }},
    ""lodash._isiterateecall"": {{
      ""version"": ""3.0.9"",
      ""resolved"": ""https://registry.npmjs.org/lodash._isiterateecall/-/lodash._isiterateecall-3.0.9.tgz"",
      ""integrity"": ""sha1-UgOte6Ql+uhCRg5pbbnPPmqsBXw="",
      ""dev"": true
    }},
    ""lodash.assign"": {{
      ""version"": ""4.2.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash.assign/-/lodash.assign-4.2.0.tgz"",
      ""integrity"": ""sha1-DZnzzNem0mHRm9rrkkUAXShYCOc="",
      ""dev"": true
    }},
    ""lodash.assignin"": {{
      ""version"": ""4.2.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash.assignin/-/lodash.assignin-4.2.0.tgz"",
      ""integrity"": ""sha1-uo31+4QesKPoBEIysOJjqNxqKKI="",
      ""dev"": true
    }},
    ""lodash.bind"": {{
      ""version"": ""4.2.1"",
      ""resolved"": ""https://registry.npmjs.org/lodash.bind/-/lodash.bind-4.2.1.tgz"",
      ""integrity"": ""sha1-euMBfpOWIqwxt9fX3LGzTbFpDTU="",
      ""dev"": true
    }},
    ""lodash.camelcase"": {{
      ""version"": ""4.3.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash.camelcase/-/lodash.camelcase-4.3.0.tgz"",
      ""integrity"": ""sha1-soqmKIorn8ZRA1x3EfZathkDMaY="",
      ""dev"": true
    }},
    ""lodash.clone"": {{
      ""version"": ""4.3.2"",
      ""resolved"": ""https://registry.npmjs.org/lodash.clone/-/lodash.clone-4.3.2.tgz"",
      ""integrity"": ""sha1-5WsXa2gjp93jj38r9Y3n1ZcSAOk="",
      ""dev"": true,
      ""requires"": {{
        ""lodash._baseclone"": ""4.5.7""
      }}
    }},
    ""lodash.clonedeep"": {{
      ""version"": ""4.5.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash.clonedeep/-/lodash.clonedeep-4.5.0.tgz"",
      ""integrity"": ""sha1-4j8/nE+Pvd6HJSnBBxhXoIblzO8="",
      ""dev"": true
    }},
    ""lodash.defaults"": {{
      ""version"": ""4.2.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash.defaults/-/lodash.defaults-4.2.0.tgz"",
      ""integrity"": ""sha1-0JF4cW/+pN3p5ft7N/bwgCJ0WAw="",
      ""dev"": true
    }},
    ""lodash.filter"": {{
      ""version"": ""4.6.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash.filter/-/lodash.filter-4.6.0.tgz"",
      ""integrity"": ""sha1-ZosdSYFgOuHMWm+nYBQ+SAtMSs4="",
      ""dev"": true
    }},
    ""lodash.find"": {{
      ""version"": ""3.2.1"",
      ""resolved"": ""https://registry.npmjs.org/lodash.find/-/lodash.find-3.2.1.tgz"",
      ""integrity"": ""sha1-BG4xnzrOkSrGySRsf2g8XsB7Nq0="",
      ""dev"": true,
      ""requires"": {{
        ""lodash._basecallback"": ""3.3.1"",
        ""lodash._baseeach"": ""3.0.4"",
        ""lodash._basefind"": ""3.0.0"",
        ""lodash._basefindindex"": ""3.6.0"",
        ""lodash.isarray"": ""3.0.4"",
        ""lodash.keys"": ""3.1.2""
      }}
    }},
    ""lodash.flatten"": {{
      ""version"": ""4.4.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash.flatten/-/lodash.flatten-4.4.0.tgz"",
      ""integrity"": ""sha1-8xwiIlqWMtK7+OSt2+8kCqdlph8="",
      ""dev"": true
    }},
    ""lodash.foreach"": {{
      ""version"": ""4.5.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash.foreach/-/lodash.foreach-4.5.0.tgz"",
      ""integrity"": ""sha1-Gmo16s5AEoDH8G3d7DUWWrJ+PlM="",
      ""dev"": true
    }},
    ""lodash.isarguments"": {{
      ""version"": ""3.1.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash.isarguments/-/lodash.isarguments-3.1.0.tgz"",
      ""integrity"": ""sha1-L1c9hcaiQon/AGY7SRwdM4/zRYo="",
      ""dev"": true
    }},
    ""lodash.isarray"": {{
      ""version"": ""3.0.4"",
      ""resolved"": ""https://registry.npmjs.org/lodash.isarray/-/lodash.isarray-3.0.4.tgz"",
      ""integrity"": ""sha1-eeTriMNqgSKvhvhEqpvNhRtfu1U="",
      ""dev"": true
    }},
    ""lodash.isplainobject"": {{
      ""version"": ""3.2.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash.isplainobject/-/lodash.isplainobject-3.2.0.tgz"",
      ""integrity"": ""sha1-moI4rhayAEMpYM1zRlEtASP79MU="",
      ""dev"": true,
      ""requires"": {{
        ""lodash._basefor"": ""3.0.3"",
        ""lodash.isarguments"": ""3.1.0"",
        ""lodash.keysin"": ""3.0.8""
      }}
    }},
    ""lodash.istypedarray"": {{
      ""version"": ""3.0.6"",
      ""resolved"": ""https://registry.npmjs.org/lodash.istypedarray/-/lodash.istypedarray-3.0.6.tgz"",
      ""integrity"": ""sha1-yaR3SYYHUB2OhJTSg7h8OSgc72I="",
      ""dev"": true
    }},
    ""lodash.keys"": {{
      ""version"": ""3.1.2"",
      ""resolved"": ""https://registry.npmjs.org/lodash.keys/-/lodash.keys-3.1.2.tgz"",
      ""integrity"": ""sha1-TbwEcrFWvlCgsoaFXRvQsMZWCYo="",
      ""dev"": true,
      ""requires"": {{
        ""lodash._getnative"": ""3.9.1"",
        ""lodash.isarguments"": ""3.1.0"",
        ""lodash.isarray"": ""3.0.4""
      }}
    }},
    ""lodash.keysin"": {{
      ""version"": ""3.0.8"",
      ""resolved"": ""https://registry.npmjs.org/lodash.keysin/-/lodash.keysin-3.0.8.tgz"",
      ""integrity"": ""sha1-IsRJPrvtsUJ5YqVLRFssinZ/tH8="",
      ""dev"": true,
      ""requires"": {{
        ""lodash.isarguments"": ""3.1.0"",
        ""lodash.isarray"": ""3.0.4""
      }}
    }},
    ""lodash.map"": {{
      ""version"": ""4.6.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash.map/-/lodash.map-4.6.0.tgz"",
      ""integrity"": ""sha1-dx7Hg540c9nEzeKLGTlMNWL09tM="",
      ""dev"": true
    }},
    ""lodash.memoize"": {{
      ""version"": ""4.1.2"",
      ""resolved"": ""https://registry.npmjs.org/lodash.memoize/-/lodash.memoize-4.1.2.tgz"",
      ""integrity"": ""sha1-vMbEmkKihA7Zl/Mj6tpezRguC/4="",
      ""dev"": true
    }},
    ""lodash.merge"": {{
      ""version"": ""4.6.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash.merge/-/lodash.merge-4.6.0.tgz"",
      ""integrity"": ""sha1-aYhLoUSsM/5plzemCG3v+t0PicU=""
    }},
    ""lodash.mergewith"": {{
      ""version"": ""4.6.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash.mergewith/-/lodash.mergewith-4.6.0.tgz"",
      ""integrity"": ""sha1-FQzwoWeR9ZA7iJHqsVRgknS96lU="",
      ""dev"": true
    }},
    ""lodash.pairs"": {{
      ""version"": ""3.0.1"",
      ""resolved"": ""https://registry.npmjs.org/lodash.pairs/-/lodash.pairs-3.0.1.tgz"",
      ""integrity"": ""sha1-u+CNV4bu6qCaFckevw3LfSvjJqk="",
      ""dev"": true,
      ""requires"": {{
        ""lodash.keys"": ""3.1.2""
      }}
    }},
    ""lodash.pick"": {{
      ""version"": ""4.4.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash.pick/-/lodash.pick-4.4.0.tgz"",
      ""integrity"": ""sha1-UvBWEP/53tQiYRRB7R/BI6AwAbM="",
      ""dev"": true
    }},
    ""lodash.pickby"": {{
      ""version"": ""4.6.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash.pickby/-/lodash.pickby-4.6.0.tgz"",
      ""integrity"": ""sha1-feoh2MGNdwOifHBMFdO4SmfjOv8="",
      ""dev"": true
    }},
    ""lodash.reduce"": {{
      ""version"": ""4.6.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash.reduce/-/lodash.reduce-4.6.0.tgz"",
      ""integrity"": ""sha1-8atrg5KZrUj3hKu/R2WW8DuRTTs="",
      ""dev"": true
    }},
    ""lodash.reject"": {{
      ""version"": ""4.6.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash.reject/-/lodash.reject-4.6.0.tgz"",
      ""integrity"": ""sha1-gNZJLcFHCGS79YNTO2UfQqn1JBU="",
      ""dev"": true
    }},
    ""lodash.restparam"": {{
      ""version"": ""3.6.1"",
      ""resolved"": ""https://registry.npmjs.org/lodash.restparam/-/lodash.restparam-3.6.1.tgz"",
      ""integrity"": ""sha1-k2pOMJ7zMKdkXtQUWYbIWuWyCAU="",
      ""dev"": true
    }},
    ""lodash.some"": {{
      ""version"": ""4.6.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash.some/-/lodash.some-4.6.0.tgz"",
      ""integrity"": ""sha1-G7nzFO9ri63tE7VJFpsqlF62jk0="",
      ""dev"": true
    }},
    ""lodash.tail"": {{
      ""version"": ""4.1.1"",
      ""resolved"": ""https://registry.npmjs.org/lodash.tail/-/lodash.tail-4.1.1.tgz"",
      ""integrity"": ""sha1-0jM6NtnncXyK0vfKyv7HwytERmQ="",
      ""dev"": true
    }},
    ""lodash.throttle"": {{
      ""version"": ""4.1.1"",
      ""resolved"": ""https://registry.npmjs.org/lodash.throttle/-/lodash.throttle-4.1.1.tgz"",
      ""integrity"": ""sha1-wj6RtxAkKscMN/HhzaknTMOb8vQ=""
    }},
    ""lodash.toplainobject"": {{
      ""version"": ""3.0.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash.toplainobject/-/lodash.toplainobject-3.0.0.tgz"",
      ""integrity"": ""sha1-KHkK2ULSk9eKpmOgfs9/UsoEGY0="",
      ""dev"": true,
      ""requires"": {{
        ""lodash._basecopy"": ""3.0.1"",
        ""lodash.keysin"": ""3.0.8""
      }}
    }},
    ""lodash.uniq"": {{
      ""version"": ""4.5.0"",
      ""resolved"": ""https://registry.npmjs.org/lodash.uniq/-/lodash.uniq-4.5.0.tgz"",
      ""integrity"": ""sha1-0CJTc662Uq3BvILklFM5qEJ1R3M="",
      ""dev"": true
    }},
    ""longest"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/longest/-/longest-1.0.1.tgz"",
      ""integrity"": ""sha1-MKCy2jj3N3DoKUoNIuZiXtd9AJc="",
      ""dev"": true
    }},
    ""loose-envify"": {{
      ""version"": ""1.3.1"",
      ""resolved"": ""https://registry.npmjs.org/loose-envify/-/loose-envify-1.3.1.tgz"",
      ""integrity"": ""sha1-0aitM/qc4OcT1l/dCsi3SNR4yEg="",
      ""requires"": {{
        ""js-tokens"": ""3.0.2""
      }}
    }},
    ""loud-rejection"": {{
      ""version"": ""1.6.0"",
      ""resolved"": ""https://registry.npmjs.org/loud-rejection/-/loud-rejection-1.6.0.tgz"",
      ""integrity"": ""sha1-W0b4AUft7leIcPCG0Eghz5mOVR8="",
      ""dev"": true,
      ""requires"": {{
        ""currently-unhandled"": ""0.4.1"",
        ""signal-exit"": ""3.0.2""
      }}
    }},
    ""lower-case"": {{
      ""version"": ""1.1.4"",
      ""resolved"": ""https://registry.npmjs.org/lower-case/-/lower-case-1.1.4.tgz"",
      ""integrity"": ""sha1-miyr0bno4K6ZOkv31YdcOcQujqw="",
      ""dev"": true
    }},
    ""lru-cache"": {{
      ""version"": ""4.1.1"",
      ""resolved"": ""https://registry.npmjs.org/lru-cache/-/lru-cache-4.1.1.tgz"",
      ""integrity"": ""sha512-q4spe4KTfsAS1SUHLO0wz8Qiyf1+vMIAgpRYioFYDMNqKfHQbg+AVDH3i4fvpl71/P1L0dBl+fQi+P37UYf0ew=="",
      ""dev"": true,
      ""requires"": {{
        ""pseudomap"": ""1.0.2"",
        ""yallist"": ""2.1.2""
      }}
    }},
    ""macaddress"": {{
      ""version"": ""0.2.8"",
      ""resolved"": ""https://registry.npmjs.org/macaddress/-/macaddress-0.2.8.tgz"",
      ""integrity"": ""sha1-WQTcU3w57G2+/q6QIycTX6hRHxI="",
      ""dev"": true
    }},
    ""makeerror"": {{
      ""version"": ""1.0.11"",
      ""resolved"": ""https://registry.npmjs.org/makeerror/-/makeerror-1.0.11.tgz"",
      ""integrity"": ""sha1-4BpckQnyr3lmDk6LlYd5AYT1qWw="",
      ""dev"": true,
      ""requires"": {{
        ""tmpl"": ""1.0.4""
      }}
    }},
    ""manage-path"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/manage-path/-/manage-path-2.0.0.tgz"",
      ""integrity"": ""sha1-9M+EV7km7u4qg7FzUBQUvHbrlZc="",
      ""dev"": true
    }},
    ""map-obj"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/map-obj/-/map-obj-1.0.1.tgz"",
      ""integrity"": ""sha1-2TPOuSBdgr3PSIb2dCvcK03qFG0="",
      ""dev"": true
    }},
    ""material-ui"": {{
      ""version"": ""0.20.0"",
      ""resolved"": ""https://registry.npmjs.org/material-ui/-/material-ui-0.20.0.tgz"",
      ""integrity"": ""sha512-wkHkeU1SaGfCrtwIzBOl5vynNNNzVGW27ql0Ue5HZLB4WyRQ3YohJBdKa5lBrH5JD/Cgae7IzrP7cVWDyKpeLQ=="",
      ""requires"": {{
        ""babel-runtime"": ""6.26.0"",
        ""inline-style-prefixer"": ""3.0.8"",
        ""keycode"": ""2.1.9"",
        ""lodash.merge"": ""4.6.0"",
        ""lodash.throttle"": ""4.1.1"",
        ""prop-types"": ""15.6.0"",
        ""react-event-listener"": ""0.5.3"",
        ""react-transition-group"": ""1.2.1"",
        ""recompose"": ""0.26.0"",
        ""simple-assign"": ""0.1.0"",
        ""warning"": ""3.0.0""
      }}
    }},
    ""math-expression-evaluator"": {{
      ""version"": ""1.2.17"",
      ""resolved"": ""https://registry.npmjs.org/math-expression-evaluator/-/math-expression-evaluator-1.2.17.tgz"",
      ""integrity"": ""sha1-3oGf282E3M2PrlnGrreWFbnSZqw="",
      ""dev"": true
    }},
    ""md5.js"": {{
      ""version"": ""1.3.4"",
      ""resolved"": ""https://registry.npmjs.org/md5.js/-/md5.js-1.3.4.tgz"",
      ""integrity"": ""sha1-6b296UogpawYsENA/Fdk1bCdkB0="",
      ""dev"": true,
      ""requires"": {{
        ""hash-base"": ""3.0.4"",
        ""inherits"": ""2.0.3""
      }},
      ""dependencies"": {{
        ""hash-base"": {{
          ""version"": ""3.0.4"",
          ""resolved"": ""https://registry.npmjs.org/hash-base/-/hash-base-3.0.4.tgz"",
          ""integrity"": ""sha1-X8hoaEfs1zSZQDMZprCj8/auSRg="",
          ""dev"": true,
          ""requires"": {{
            ""inherits"": ""2.0.3"",
            ""safe-buffer"": ""5.1.1""
          }}
        }}
      }}
    }},
    ""media-typer"": {{
      ""version"": ""0.3.0"",
      ""resolved"": ""https://registry.npmjs.org/media-typer/-/media-typer-0.3.0.tgz"",
      ""integrity"": ""sha1-hxDXrwqmJvj/+hzgAWhUUmMlV0g="",
      ""dev"": true
    }},
    ""mem"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/mem/-/mem-1.1.0.tgz"",
      ""integrity"": ""sha1-Xt1StIXKHZAP5kiVUFOZoN+kX3Y="",
      ""dev"": true,
      ""requires"": {{
        ""mimic-fn"": ""1.1.0""
      }}
    }},
    ""memory-fs"": {{
      ""version"": ""0.4.1"",
      ""resolved"": ""https://registry.npmjs.org/memory-fs/-/memory-fs-0.4.1.tgz"",
      ""integrity"": ""sha1-OpoguEYlI+RHz7x+i7gO1me/xVI="",
      ""dev"": true,
      ""requires"": {{
        ""errno"": ""0.1.6"",
        ""readable-stream"": ""2.3.3""
      }},
      ""dependencies"": {{
        ""isarray"": {{
          ""version"": ""1.0.0"",
          ""resolved"": ""https://registry.npmjs.org/isarray/-/isarray-1.0.0.tgz"",
          ""integrity"": ""sha1-u5NdSFgsuhaMBoNJV6VKPgcSTxE="",
          ""dev"": true
        }},
        ""readable-stream"": {{
          ""version"": ""2.3.3"",
          ""resolved"": ""https://registry.npmjs.org/readable-stream/-/readable-stream-2.3.3.tgz"",
          ""integrity"": ""sha512-m+qzzcn7KUxEmd1gMbchF+Y2eIUbieUaxkWtptyHywrX0rE8QEYqPC07Vuy4Wm32/xE16NcdBctb8S0Xe/5IeQ=="",
          ""dev"": true,
          ""requires"": {{
            ""core-util-is"": ""1.0.2"",
            ""inherits"": ""2.0.3"",
            ""isarray"": ""1.0.0"",
            ""process-nextick-args"": ""1.0.7"",
            ""safe-buffer"": ""5.1.1"",
            ""string_decoder"": ""1.0.3"",
            ""util-deprecate"": ""1.0.2""
          }}
        }},
        ""string_decoder"": {{
          ""version"": ""1.0.3"",
          ""resolved"": ""https://registry.npmjs.org/string_decoder/-/string_decoder-1.0.3.tgz"",
          ""integrity"": ""sha512-4AH6Z5fzNNBcH+6XDMfA/BTt87skxqJlO0lAh3Dker5zThcAxG6mKz+iGu308UKoPPQ8Dcqx/4JhujzltRa+hQ=="",
          ""dev"": true,
          ""requires"": {{
            ""safe-buffer"": ""5.1.1""
          }}
        }}
      }}
    }},
    ""meow"": {{
      ""version"": ""3.7.0"",
      ""resolved"": ""https://registry.npmjs.org/meow/-/meow-3.7.0.tgz"",
      ""integrity"": ""sha1-cstmi0JSKCkKu/qFaJJYcwioAfs="",
      ""dev"": true,
      ""requires"": {{
        ""camelcase-keys"": ""2.1.0"",
        ""decamelize"": ""1.2.0"",
        ""loud-rejection"": ""1.6.0"",
        ""map-obj"": ""1.0.1"",
        ""minimist"": ""1.2.0"",
        ""normalize-package-data"": ""2.4.0"",
        ""object-assign"": ""4.1.1"",
        ""read-pkg-up"": ""1.0.1"",
        ""redent"": ""1.0.0"",
        ""trim-newlines"": ""1.0.0""
      }},
      ""dependencies"": {{
        ""minimist"": {{
          ""version"": ""1.2.0"",
          ""resolved"": ""https://registry.npmjs.org/minimist/-/minimist-1.2.0.tgz"",
          ""integrity"": ""sha1-o1AIsg9BOD7sH7kU9M1d95omQoQ="",
          ""dev"": true
        }}
      }}
    }},
    ""merge"": {{
      ""version"": ""1.2.0"",
      ""resolved"": ""https://registry.npmjs.org/merge/-/merge-1.2.0.tgz"",
      ""integrity"": ""sha1-dTHjnUlJwoGma4xabgJl6LBYlNo="",
      ""dev"": true
    }},
    ""merge-descriptors"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/merge-descriptors/-/merge-descriptors-1.0.1.tgz"",
      ""integrity"": ""sha1-sAqqVW3YtEVoFQ7J0blT8/kMu2E="",
      ""dev"": true
    }},
    ""methods"": {{
      ""version"": ""1.1.2"",
      ""resolved"": ""https://registry.npmjs.org/methods/-/methods-1.1.2.tgz"",
      ""integrity"": ""sha1-VSmk1nZUE07cxSZmVoNbD4Ua/O4="",
      ""dev"": true
    }},
    ""micromatch"": {{
      ""version"": ""2.3.11"",
      ""resolved"": ""https://registry.npmjs.org/micromatch/-/micromatch-2.3.11.tgz"",
      ""integrity"": ""sha1-hmd8l9FyCzY0MdBNDRUpO9OMFWU="",
      ""dev"": true,
      ""requires"": {{
        ""arr-diff"": ""2.0.0"",
        ""array-unique"": ""0.2.1"",
        ""braces"": ""1.8.5"",
        ""expand-brackets"": ""0.1.5"",
        ""extglob"": ""0.3.2"",
        ""filename-regex"": ""2.0.1"",
        ""is-extglob"": ""1.0.0"",
        ""is-glob"": ""2.0.1"",
        ""kind-of"": ""3.2.2"",
        ""normalize-path"": ""2.1.1"",
        ""object.omit"": ""2.0.1"",
        ""parse-glob"": ""3.0.4"",
        ""regex-cache"": ""0.4.4""
      }}
    }},
    ""miller-rabin"": {{
      ""version"": ""4.0.1"",
      ""resolved"": ""https://registry.npmjs.org/miller-rabin/-/miller-rabin-4.0.1.tgz"",
      ""integrity"": ""sha512-115fLhvZVqWwHPbClyntxEVfVDfl9DLLTuJvq3g2O/Oxi8AiNouAHvDSzHS0viUJc+V5vm3eq91Xwqn9dp4jRA=="",
      ""dev"": true,
      ""requires"": {{
        ""bn.js"": ""4.11.8"",
        ""brorand"": ""1.1.0""
      }}
    }},
    ""mime"": {{
      ""version"": ""1.4.1"",
      ""resolved"": ""https://registry.npmjs.org/mime/-/mime-1.4.1.tgz"",
      ""integrity"": ""sha512-KI1+qOZu5DcW6wayYHSzR/tXKCDC5Om4s1z2QJjDULzLcmf3DvzS7oluY4HCTrc+9FiKmWUgeNLg7W3uIQvxtQ=="",
      ""dev"": true
    }},
    ""mime-db"": {{
      ""version"": ""1.30.0"",
      ""resolved"": ""https://registry.npmjs.org/mime-db/-/mime-db-1.30.0.tgz"",
      ""integrity"": ""sha1-dMZD2i3Z1qRTmZY0ZbJtXKfXHwE="",
      ""dev"": true
    }},
    ""mime-types"": {{
      ""version"": ""2.1.17"",
      ""resolved"": ""https://registry.npmjs.org/mime-types/-/mime-types-2.1.17.tgz"",
      ""integrity"": ""sha1-Cdejk/A+mVp5+K+Fe3Cp4KsWVXo="",
      ""dev"": true,
      ""requires"": {{
        ""mime-db"": ""1.30.0""
      }}
    }},
    ""mimic-fn"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/mimic-fn/-/mimic-fn-1.1.0.tgz"",
      ""integrity"": ""sha1-5md4PZLonb00KBi1IwudYqZyrRg="",
      ""dev"": true
    }},
    ""min-document"": {{
      ""version"": ""2.19.0"",
      ""resolved"": ""https://registry.npmjs.org/min-document/-/min-document-2.19.0.tgz"",
      ""integrity"": ""sha1-e9KC4/WELtKVu3SM3Z8f+iyCRoU="",
      ""dev"": true,
      ""requires"": {{
        ""dom-walk"": ""0.1.1""
      }}
    }},
    ""minimalistic-assert"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/minimalistic-assert/-/minimalistic-assert-1.0.0.tgz"",
      ""integrity"": ""sha1-cCvi3aazf0g2vLP121ZkG2Sh09M="",
      ""dev"": true
    }},
    ""minimalistic-crypto-utils"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/minimalistic-crypto-utils/-/minimalistic-crypto-utils-1.0.1.tgz"",
      ""integrity"": ""sha1-9sAMHAsIIkblxNmd+4x8CDsrWCo="",
      ""dev"": true
    }},
    ""minimatch"": {{
      ""version"": ""3.0.4"",
      ""resolved"": ""https://registry.npmjs.org/minimatch/-/minimatch-3.0.4.tgz"",
      ""integrity"": ""sha512-yJHVQEhyqPLUTgt9B83PXu6W3rx4MvvHvSUvToogpwoGDOUQ+yDrR0HRot+yOCdCO7u4hX3pWft6kWBBcqh0UA=="",
      ""dev"": true,
      ""requires"": {{
        ""brace-expansion"": ""1.1.8""
      }}
    }},
    ""minimist"": {{
      ""version"": ""0.0.8"",
      ""resolved"": ""https://registry.npmjs.org/minimist/-/minimist-0.0.8.tgz"",
      ""integrity"": ""sha1-hX/Kv8M5fSYluCKCYuhqp6ARsF0="",
      ""dev"": true
    }},
    ""mixin-object"": {{
      ""version"": ""2.0.1"",
      ""resolved"": ""https://registry.npmjs.org/mixin-object/-/mixin-object-2.0.1.tgz"",
      ""integrity"": ""sha1-T7lJRB2rGCVA8f4DW6YOGUel5X4="",
      ""dev"": true,
      ""requires"": {{
        ""for-in"": ""0.1.8"",
        ""is-extendable"": ""0.1.1""
      }},
      ""dependencies"": {{
        ""for-in"": {{
          ""version"": ""0.1.8"",
          ""resolved"": ""https://registry.npmjs.org/for-in/-/for-in-0.1.8.tgz"",
          ""integrity"": ""sha1-2Hc5COMSVhCZUrH9ubP6hn0ndeE="",
          ""dev"": true
        }}
      }}
    }},
    ""mkdirp"": {{
      ""version"": ""0.5.1"",
      ""resolved"": ""https://registry.npmjs.org/mkdirp/-/mkdirp-0.5.1.tgz"",
      ""integrity"": ""sha1-MAV0OOrGz3+MR2fzhkjWaX11yQM="",
      ""dev"": true,
      ""requires"": {{
        ""minimist"": ""0.0.8""
      }}
    }},
    ""moment"": {{
      ""version"": ""2.20.1"",
      ""resolved"": ""https://registry.npmjs.org/moment/-/moment-2.20.1.tgz"",
      ""integrity"": ""sha512-Yh9y73JRljxW5QxN08Fner68eFLxM5ynNOAw2LbIB1YAGeQzZT8QFSUvkAz609Zf+IHhhaUxqZK8dG3W/+HEvg==""
    }},
    ""morgan"": {{
      ""version"": ""1.9.0"",
      ""resolved"": ""https://registry.npmjs.org/morgan/-/morgan-1.9.0.tgz"",
      ""integrity"": ""sha1-0B+mxlhZt2/PMbPLU6OCGjEdgFE="",
      ""dev"": true,
      ""requires"": {{
        ""basic-auth"": ""2.0.0"",
        ""debug"": ""2.6.9"",
        ""depd"": ""1.1.1"",
        ""on-finished"": ""2.3.0"",
        ""on-headers"": ""1.0.1""
      }}
    }},
    ""ms"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/ms/-/ms-2.0.0.tgz"",
      ""integrity"": ""sha1-VgiurfwAvmwpAd9fmGF4jeDVl8g=""
    }},
    ""mute-stream"": {{
      ""version"": ""0.0.5"",
      ""resolved"": ""https://registry.npmjs.org/mute-stream/-/mute-stream-0.0.5.tgz"",
      ""integrity"": ""sha1-j7+rsKmKJT0xhDMfno3rc3L6xsA="",
      ""dev"": true
    }},
    ""nan"": {{
      ""version"": ""2.8.0"",
      ""resolved"": ""https://registry.npmjs.org/nan/-/nan-2.8.0.tgz"",
      ""integrity"": ""sha1-7XFfP+neArV6XmJS2QqWZ14fCFo="",
      ""dev"": true
    }},
    ""natural-compare"": {{
      ""version"": ""1.4.0"",
      ""resolved"": ""https://registry.npmjs.org/natural-compare/-/natural-compare-1.4.0.tgz"",
      ""integrity"": ""sha1-Sr6/7tdUHywnrPspvbvRXI1bpPc="",
      ""dev"": true
    }},
    ""ncname"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/ncname/-/ncname-1.0.0.tgz"",
      ""integrity"": ""sha1-W1etGLHKCShk72Kwse2BlPODtxw="",
      ""dev"": true,
      ""requires"": {{
        ""xml-char-classes"": ""1.0.0""
      }}
    }},
    ""negotiator"": {{
      ""version"": ""0.6.1"",
      ""resolved"": ""https://registry.npmjs.org/negotiator/-/negotiator-0.6.1.tgz"",
      ""integrity"": ""sha1-KzJxhOiZIQEXeyhWP7XnECrNDKk="",
      ""dev"": true
    }},
    ""no-case"": {{
      ""version"": ""2.3.2"",
      ""resolved"": ""https://registry.npmjs.org/no-case/-/no-case-2.3.2.tgz"",
      ""integrity"": ""sha512-rmTZ9kz+f3rCvK2TD1Ue/oZlns7OGoIWP4fc3llxxRXlOkHKoWPPWJOfFYpITabSow43QJbRIoHQXtt10VldyQ=="",
      ""dev"": true,
      ""requires"": {{
        ""lower-case"": ""1.1.4""
      }}
    }},
    ""node-dir"": {{
      ""version"": ""0.1.17"",
      ""resolved"": ""https://registry.npmjs.org/node-dir/-/node-dir-0.1.17.tgz"",
      ""integrity"": ""sha1-X1Zl2TNRM1yqvvjxxVRRbPXx5OU="",
      ""dev"": true,
      ""requires"": {{
        ""minimatch"": ""3.0.4""
      }}
    }},
    ""node-fetch"": {{
      ""version"": ""1.7.3"",
      ""resolved"": ""https://registry.npmjs.org/node-fetch/-/node-fetch-1.7.3.tgz"",
      ""integrity"": ""sha512-NhZ4CsKx7cYm2vSrBAr2PvFOe6sWDf0UYLRqA6svUYg7+/TSfVAu49jYC4BvQ4Sms9SZgdqGBgroqfDhJdTyKQ=="",
      ""requires"": {{
        ""encoding"": ""0.1.12"",
        ""is-stream"": ""1.1.0""
      }}
    }},
    ""node-gyp"": {{
      ""version"": ""3.6.2"",
      ""resolved"": ""https://registry.npmjs.org/node-gyp/-/node-gyp-3.6.2.tgz"",
      ""integrity"": ""sha1-m/vlRWIoYoSDjnUOrAUpWFP6HGA="",
      ""dev"": true,
      ""requires"": {{
        ""fstream"": ""1.0.11"",
        ""glob"": ""7.1.2"",
        ""graceful-fs"": ""4.1.11"",
        ""minimatch"": ""3.0.4"",
        ""mkdirp"": ""0.5.1"",
        ""nopt"": ""3.0.6"",
        ""npmlog"": ""4.1.2"",
        ""osenv"": ""0.1.4"",
        ""request"": ""2.83.0"",
        ""rimraf"": ""2.6.2"",
        ""semver"": ""5.3.0"",
        ""tar"": ""2.2.1"",
        ""which"": ""1.3.0""
      }},
      ""dependencies"": {{
        ""glob"": {{
          ""version"": ""7.1.2"",
          ""resolved"": ""https://registry.npmjs.org/glob/-/glob-7.1.2.tgz"",
          ""integrity"": ""sha512-MJTUg1kjuLeQCJ+ccE4Vpa6kKVXkPYJ2mOCQyUuKLcLQsdrMCpBPUi8qVE6+YuaJkozeA9NusTAw3hLr8Xe5EQ=="",
          ""dev"": true,
          ""requires"": {{
            ""fs.realpath"": ""1.0.0"",
            ""inflight"": ""1.0.6"",
            ""inherits"": ""2.0.3"",
            ""minimatch"": ""3.0.4"",
            ""once"": ""1.4.0"",
            ""path-is-absolute"": ""1.0.1""
          }}
        }},
        ""semver"": {{
          ""version"": ""5.3.0"",
          ""resolved"": ""https://registry.npmjs.org/semver/-/semver-5.3.0.tgz"",
          ""integrity"": ""sha1-myzl094C0XxgEq0yaqa00M9U+U8="",
          ""dev"": true
        }}
      }}
    }},
    ""node-int64"": {{
      ""version"": ""0.4.0"",
      ""resolved"": ""https://registry.npmjs.org/node-int64/-/node-int64-0.4.0.tgz"",
      ""integrity"": ""sha1-h6kGXNs1XTGC2PlM4RGIuCXGijs="",
      ""dev"": true
    }},
    ""node-libs-browser"": {{
      ""version"": ""2.1.0"",
      ""resolved"": ""https://registry.npmjs.org/node-libs-browser/-/node-libs-browser-2.1.0.tgz"",
      ""integrity"": ""sha512-5AzFzdoIMb89hBGMZglEegffzgRg+ZFoUmisQ8HI4j1KDdpx13J0taNp2y9xPbur6W61gepGDDotGBVQ7mfUCg=="",
      ""dev"": true,
      ""requires"": {{
        ""assert"": ""1.4.1"",
        ""browserify-zlib"": ""0.2.0"",
        ""buffer"": ""4.9.1"",
        ""console-browserify"": ""1.1.0"",
        ""constants-browserify"": ""1.0.0"",
        ""crypto-browserify"": ""3.12.0"",
        ""domain-browser"": ""1.1.7"",
        ""events"": ""1.1.1"",
        ""https-browserify"": ""1.0.0"",
        ""os-browserify"": ""0.3.0"",
        ""path-browserify"": ""0.0.0"",
        ""process"": ""0.11.10"",
        ""punycode"": ""1.4.1"",
        ""querystring-es3"": ""0.2.1"",
        ""readable-stream"": ""2.3.3"",
        ""stream-browserify"": ""2.0.1"",
        ""stream-http"": ""2.7.2"",
        ""string_decoder"": ""1.0.3"",
        ""timers-browserify"": ""2.0.4"",
        ""tty-browserify"": ""0.0.0"",
        ""url"": ""0.11.0"",
        ""util"": ""0.10.3"",
        ""vm-browserify"": ""0.0.4""
      }},
      ""dependencies"": {{
        ""isarray"": {{
          ""version"": ""1.0.0"",
          ""resolved"": ""https://registry.npmjs.org/isarray/-/isarray-1.0.0.tgz"",
          ""integrity"": ""sha1-u5NdSFgsuhaMBoNJV6VKPgcSTxE="",
          ""dev"": true
        }},
        ""process"": {{
          ""version"": ""0.11.10"",
          ""resolved"": ""https://registry.npmjs.org/process/-/process-0.11.10.tgz"",
          ""integrity"": ""sha1-czIwDoQBYb2j5podHZGn1LwW8YI="",
          ""dev"": true
        }},
        ""readable-stream"": {{
          ""version"": ""2.3.3"",
          ""resolved"": ""https://registry.npmjs.org/readable-stream/-/readable-stream-2.3.3.tgz"",
          ""integrity"": ""sha512-m+qzzcn7KUxEmd1gMbchF+Y2eIUbieUaxkWtptyHywrX0rE8QEYqPC07Vuy4Wm32/xE16NcdBctb8S0Xe/5IeQ=="",
          ""dev"": true,
          ""requires"": {{
            ""core-util-is"": ""1.0.2"",
            ""inherits"": ""2.0.3"",
            ""isarray"": ""1.0.0"",
            ""process-nextick-args"": ""1.0.7"",
            ""safe-buffer"": ""5.1.1"",
            ""string_decoder"": ""1.0.3"",
            ""util-deprecate"": ""1.0.2""
          }}
        }},
        ""string_decoder"": {{
          ""version"": ""1.0.3"",
          ""resolved"": ""https://registry.npmjs.org/string_decoder/-/string_decoder-1.0.3.tgz"",
          ""integrity"": ""sha512-4AH6Z5fzNNBcH+6XDMfA/BTt87skxqJlO0lAh3Dker5zThcAxG6mKz+iGu308UKoPPQ8Dcqx/4JhujzltRa+hQ=="",
          ""dev"": true,
          ""requires"": {{
            ""safe-buffer"": ""5.1.1""
          }}
        }}
      }}
    }},
    ""node-notifier"": {{
      ""version"": ""5.2.1"",
      ""resolved"": ""https://registry.npmjs.org/node-notifier/-/node-notifier-5.2.1.tgz"",
      ""integrity"": ""sha512-MIBs+AAd6dJ2SklbbE8RUDRlIVhU8MaNLh1A9SUZDUHPiZkWLFde6UNwG41yQHZEToHgJMXqyVZ9UcS/ReOVTg=="",
      ""dev"": true,
      ""requires"": {{
        ""growly"": ""1.3.0"",
        ""semver"": ""5.4.1"",
        ""shellwords"": ""0.1.1"",
        ""which"": ""1.3.0""
      }}
    }},
    ""node-sass"": {{
      ""version"": ""4.7.2"",
      ""resolved"": ""https://registry.npmjs.org/node-sass/-/node-sass-4.7.2.tgz"",
      ""integrity"": ""sha512-CaV+wLqZ7//Jdom5aUFCpGNoECd7BbNhjuwdsX/LkXBrHl8eb1Wjw4HvWqcFvhr5KuNgAk8i/myf/MQ1YYeroA=="",
      ""dev"": true,
      ""requires"": {{
        ""async-foreach"": ""0.1.3"",
        ""chalk"": ""1.1.3"",
        ""cross-spawn"": ""3.0.1"",
        ""gaze"": ""1.1.2"",
        ""get-stdin"": ""4.0.1"",
        ""glob"": ""7.1.2"",
        ""in-publish"": ""2.0.0"",
        ""lodash.assign"": ""4.2.0"",
        ""lodash.clonedeep"": ""4.5.0"",
        ""lodash.mergewith"": ""4.6.0"",
        ""meow"": ""3.7.0"",
        ""mkdirp"": ""0.5.1"",
        ""nan"": ""2.8.0"",
        ""node-gyp"": ""3.6.2"",
        ""npmlog"": ""4.1.2"",
        ""request"": ""2.79.0"",
        ""sass-graph"": ""2.2.4"",
        ""stdout-stream"": ""1.4.0"",
        ""true-case-path"": ""1.0.2""
      }},
      ""dependencies"": {{
        ""assert-plus"": {{
          ""version"": ""0.2.0"",
          ""resolved"": ""https://registry.npmjs.org/assert-plus/-/assert-plus-0.2.0.tgz"",
          ""integrity"": ""sha1-104bh+ev/A24qttwIfP+SBAasjQ="",
          ""dev"": true
        }},
        ""aws-sign2"": {{
          ""version"": ""0.6.0"",
          ""resolved"": ""https://registry.npmjs.org/aws-sign2/-/aws-sign2-0.6.0.tgz"",
          ""integrity"": ""sha1-FDQt0428yU0OW4fXY81jYSwOeU8="",
          ""dev"": true
        }},
        ""boom"": {{
          ""version"": ""2.10.1"",
          ""resolved"": ""https://registry.npmjs.org/boom/-/boom-2.10.1.tgz"",
          ""integrity"": ""sha1-OciRjO/1eZ+D+UkqhI9iWt0Mdm8="",
          ""dev"": true,
          ""requires"": {{
            ""hoek"": ""2.16.3""
          }}
        }},
        ""caseless"": {{
          ""version"": ""0.11.0"",
          ""resolved"": ""https://registry.npmjs.org/caseless/-/caseless-0.11.0.tgz"",
          ""integrity"": ""sha1-cVuW6phBWTzDMGeSP17GDr2k99c="",
          ""dev"": true
        }},
        ""commander"": {{
          ""version"": ""2.12.2"",
          ""resolved"": ""https://registry.npmjs.org/commander/-/commander-2.12.2.tgz"",
          ""integrity"": ""sha512-BFnaq5ZOGcDN7FlrtBT4xxkgIToalIIxwjxLWVJ8bGTpe1LroqMiqQXdA7ygc7CRvaYS+9zfPGFnJqFSayx+AA=="",
          ""dev"": true
        }},
        ""cross-spawn"": {{
          ""version"": ""3.0.1"",
          ""resolved"": ""https://registry.npmjs.org/cross-spawn/-/cross-spawn-3.0.1.tgz"",
          ""integrity"": ""sha1-ElYDfsufDF9549bvE14wdwGEuYI="",
          ""dev"": true,
          ""requires"": {{
            ""lru-cache"": ""4.1.1"",
            ""which"": ""1.3.0""
          }}
        }},
        ""cryptiles"": {{
          ""version"": ""2.0.5"",
          ""resolved"": ""https://registry.npmjs.org/cryptiles/-/cryptiles-2.0.5.tgz"",
          ""integrity"": ""sha1-O9/s3GCBR8HGcgL6KR59ylnqo7g="",
          ""dev"": true,
          ""requires"": {{
            ""boom"": ""2.10.1""
          }}
        }},
        ""form-data"": {{
          ""version"": ""2.1.4"",
          ""resolved"": ""https://registry.npmjs.org/form-data/-/form-data-2.1.4.tgz"",
          ""integrity"": ""sha1-M8GDrPGTJ27KqYFDpp6Uv+4XUNE="",
          ""dev"": true,
          ""requires"": {{
            ""asynckit"": ""0.4.0"",
            ""combined-stream"": ""1.0.5"",
            ""mime-types"": ""2.1.17""
          }}
        }},
        ""glob"": {{
          ""version"": ""7.1.2"",
          ""resolved"": ""https://registry.npmjs.org/glob/-/glob-7.1.2.tgz"",
          ""integrity"": ""sha512-MJTUg1kjuLeQCJ+ccE4Vpa6kKVXkPYJ2mOCQyUuKLcLQsdrMCpBPUi8qVE6+YuaJkozeA9NusTAw3hLr8Xe5EQ=="",
          ""dev"": true,
          ""requires"": {{
            ""fs.realpath"": ""1.0.0"",
            ""inflight"": ""1.0.6"",
            ""inherits"": ""2.0.3"",
            ""minimatch"": ""3.0.4"",
            ""once"": ""1.4.0"",
            ""path-is-absolute"": ""1.0.1""
          }}
        }},
        ""har-validator"": {{
          ""version"": ""2.0.6"",
          ""resolved"": ""https://registry.npmjs.org/har-validator/-/har-validator-2.0.6.tgz"",
          ""integrity"": ""sha1-zcvAgYgmWtEZtqWnyKtw7s+10n0="",
          ""dev"": true,
          ""requires"": {{
            ""chalk"": ""1.1.3"",
            ""commander"": ""2.12.2"",
            ""is-my-json-valid"": ""2.17.1"",
            ""pinkie-promise"": ""2.0.1""
          }}
        }},
        ""hawk"": {{
          ""version"": ""3.1.3"",
          ""resolved"": ""https://registry.npmjs.org/hawk/-/hawk-3.1.3.tgz"",
          ""integrity"": ""sha1-B4REvXwWQLD+VA0sm3PVlnjo4cQ="",
          ""dev"": true,
          ""requires"": {{
            ""boom"": ""2.10.1"",
            ""cryptiles"": ""2.0.5"",
            ""hoek"": ""2.16.3"",
            ""sntp"": ""1.0.9""
          }}
        }},
        ""hoek"": {{
          ""version"": ""2.16.3"",
          ""resolved"": ""https://registry.npmjs.org/hoek/-/hoek-2.16.3.tgz"",
          ""integrity"": ""sha1-ILt0A9POo5jpHcRxCo/xuCdKJe0="",
          ""dev"": true
        }},
        ""http-signature"": {{
          ""version"": ""1.1.1"",
          ""resolved"": ""https://registry.npmjs.org/http-signature/-/http-signature-1.1.1.tgz"",
          ""integrity"": ""sha1-33LiZwZs0Kxn+3at+OE0qPvPkb8="",
          ""dev"": true,
          ""requires"": {{
            ""assert-plus"": ""0.2.0"",
            ""jsprim"": ""1.4.1"",
            ""sshpk"": ""1.13.1""
          }}
        }},
        ""qs"": {{
          ""version"": ""6.3.2"",
          ""resolved"": ""https://registry.npmjs.org/qs/-/qs-6.3.2.tgz"",
          ""integrity"": ""sha1-51vV9uJoEioqDgvaYwslUMFmUCw="",
          ""dev"": true
        }},
        ""request"": {{
          ""version"": ""2.79.0"",
          ""resolved"": ""https://registry.npmjs.org/request/-/request-2.79.0.tgz"",
          ""integrity"": ""sha1-Tf5b9r6LjNw3/Pk+BLZVd3InEN4="",
          ""dev"": true,
          ""requires"": {{
            ""aws-sign2"": ""0.6.0"",
            ""aws4"": ""1.6.0"",
            ""caseless"": ""0.11.0"",
            ""combined-stream"": ""1.0.5"",
            ""extend"": ""3.0.1"",
            ""forever-agent"": ""0.6.1"",
            ""form-data"": ""2.1.4"",
            ""har-validator"": ""2.0.6"",
            ""hawk"": ""3.1.3"",
            ""http-signature"": ""1.1.1"",
            ""is-typedarray"": ""1.0.0"",
            ""isstream"": ""0.1.2"",
            ""json-stringify-safe"": ""5.0.1"",
            ""mime-types"": ""2.1.17"",
            ""oauth-sign"": ""0.8.2"",
            ""qs"": ""6.3.2"",
            ""stringstream"": ""0.0.5"",
            ""tough-cookie"": ""2.3.3"",
            ""tunnel-agent"": ""0.4.3"",
            ""uuid"": ""3.1.0""
          }}
        }},
        ""sntp"": {{
          ""version"": ""1.0.9"",
          ""resolved"": ""https://registry.npmjs.org/sntp/-/sntp-1.0.9.tgz"",
          ""integrity"": ""sha1-ZUEYTMkK7qbG57NeJlkIJEPGYZg="",
          ""dev"": true,
          ""requires"": {{
            ""hoek"": ""2.16.3""
          }}
        }},
        ""tunnel-agent"": {{
          ""version"": ""0.4.3"",
          ""resolved"": ""https://registry.npmjs.org/tunnel-agent/-/tunnel-agent-0.4.3.tgz"",
          ""integrity"": ""sha1-Y3PbdpCf5XDgjXNYM2Xtgop07us="",
          ""dev"": true
        }}
      }}
    }},
    ""nopt"": {{
      ""version"": ""3.0.6"",
      ""resolved"": ""https://registry.npmjs.org/nopt/-/nopt-3.0.6.tgz"",
      ""integrity"": ""sha1-xkZdvwirzU2zWTF/eaxopkayj/k="",
      ""dev"": true,
      ""requires"": {{
        ""abbrev"": ""1.1.1""
      }}
    }},
    ""normalize-package-data"": {{
      ""version"": ""2.4.0"",
      ""resolved"": ""https://registry.npmjs.org/normalize-package-data/-/normalize-package-data-2.4.0.tgz"",
      ""integrity"": ""sha512-9jjUFbTPfEy3R/ad/2oNbKtW9Hgovl5O1FvFWKkKblNXoN/Oou6+9+KKohPK13Yc3/TyunyWhJp6gvRNR/PPAw=="",
      ""dev"": true,
      ""requires"": {{
        ""hosted-git-info"": ""2.5.0"",
        ""is-builtin-module"": ""1.0.0"",
        ""semver"": ""5.4.1"",
        ""validate-npm-package-license"": ""3.0.1""
      }}
    }},
    ""normalize-path"": {{
      ""version"": ""2.1.1"",
      ""resolved"": ""https://registry.npmjs.org/normalize-path/-/normalize-path-2.1.1.tgz"",
      ""integrity"": ""sha1-GrKLVW4Zg2Oowab35vogE3/mrtk="",
      ""dev"": true,
      ""requires"": {{
        ""remove-trailing-separator"": ""1.1.0""
      }}
    }},
    ""normalize-range"": {{
      ""version"": ""0.1.2"",
      ""resolved"": ""https://registry.npmjs.org/normalize-range/-/normalize-range-0.1.2.tgz"",
      ""integrity"": ""sha1-LRDAa9/TEuqXd2laTShDlFa3WUI="",
      ""dev"": true
    }},
    ""normalize-url"": {{
      ""version"": ""1.9.1"",
      ""resolved"": ""https://registry.npmjs.org/normalize-url/-/normalize-url-1.9.1.tgz"",
      ""integrity"": ""sha1-LMDWazHqIwNkWENuNiDYWVTGbDw="",
      ""dev"": true,
      ""requires"": {{
        ""object-assign"": ""4.1.1"",
        ""prepend-http"": ""1.0.4"",
        ""query-string"": ""4.3.4"",
        ""sort-keys"": ""1.1.2""
      }}
    }},
    ""npmlog"": {{
      ""version"": ""4.1.2"",
      ""resolved"": ""https://registry.npmjs.org/npmlog/-/npmlog-4.1.2.tgz"",
      ""integrity"": ""sha512-2uUqazuKlTaSI/dC8AzicUck7+IrEaOnN/e0jd3Xtt1KcGpwx30v50mL7oPyr/h9bL3E4aZccVwpwP+5W9Vjkg=="",
      ""dev"": true,
      ""requires"": {{
        ""are-we-there-yet"": ""1.1.4"",
        ""console-control-strings"": ""1.1.0"",
        ""gauge"": ""2.7.4"",
        ""set-blocking"": ""2.0.0""
      }}
    }},
    ""nth-check"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/nth-check/-/nth-check-1.0.1.tgz"",
      ""integrity"": ""sha1-mSms32KPwsQQmN6rgqxYDPFJquQ="",
      ""dev"": true,
      ""requires"": {{
        ""boolbase"": ""1.0.0""
      }}
    }},
    ""num2fraction"": {{
      ""version"": ""1.2.2"",
      ""resolved"": ""https://registry.npmjs.org/num2fraction/-/num2fraction-1.2.2.tgz"",
      ""integrity"": ""sha1-b2gragJ6Tp3fpFZM0lidHU5mnt4="",
      ""dev"": true
    }},
    ""number-is-nan"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/number-is-nan/-/number-is-nan-1.0.1.tgz"",
      ""integrity"": ""sha1-CXtgK1NCKlIsGvuHkDGDNpQaAR0="",
      ""dev"": true
    }},
    ""nwmatcher"": {{
      ""version"": ""1.4.3"",
      ""resolved"": ""https://registry.npmjs.org/nwmatcher/-/nwmatcher-1.4.3.tgz"",
      ""integrity"": ""sha512-IKdSTiDWCarf2JTS5e9e2+5tPZGdkRJ79XjYV0pzK8Q9BpsFyBq1RGKxzs7Q8UBushGw7m6TzVKz6fcY99iSWw=="",
      ""dev"": true
    }},
    ""oauth-sign"": {{
      ""version"": ""0.8.2"",
      ""resolved"": ""https://registry.npmjs.org/oauth-sign/-/oauth-sign-0.8.2.tgz"",
      ""integrity"": ""sha1-Rqarfwrq2N6unsBWV4C31O/rnUM="",
      ""dev"": true
    }},
    ""object-assign"": {{
      ""version"": ""4.1.1"",
      ""resolved"": ""https://registry.npmjs.org/object-assign/-/object-assign-4.1.1.tgz"",
      ""integrity"": ""sha1-IQmtx5ZYh8/AXLvUQsrIv7s2CGM=""
    }},
    ""object-is"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/object-is/-/object-is-1.0.1.tgz"",
      ""integrity"": ""sha1-CqYOyZiaCz7Xlc9NBvYs8a1lObY="",
      ""dev"": true
    }},
    ""object-keys"": {{
      ""version"": ""1.0.11"",
      ""resolved"": ""https://registry.npmjs.org/object-keys/-/object-keys-1.0.11.tgz"",
      ""integrity"": ""sha1-xUYBd4rVYPEULODgG8yotW0TQm0="",
      ""dev"": true
    }},
    ""object.assign"": {{
      ""version"": ""4.1.0"",
      ""resolved"": ""https://registry.npmjs.org/object.assign/-/object.assign-4.1.0.tgz"",
      ""integrity"": ""sha512-exHJeq6kBKj58mqGyTQ9DFvrZC/eR6OwxzoM9YRoGBqrXYonaFyGiFMuc9VZrXf7DarreEwMpurG3dd+CNyW5w=="",
      ""dev"": true,
      ""requires"": {{
        ""define-properties"": ""1.1.2"",
        ""function-bind"": ""1.1.1"",
        ""has-symbols"": ""1.0.0"",
        ""object-keys"": ""1.0.11""
      }}
    }},
    ""object.entries"": {{
      ""version"": ""1.0.4"",
      ""resolved"": ""https://registry.npmjs.org/object.entries/-/object.entries-1.0.4.tgz"",
      ""integrity"": ""sha1-G/mk3SKI9bM/Opk9JXZh8F0WGl8="",
      ""dev"": true,
      ""requires"": {{
        ""define-properties"": ""1.1.2"",
        ""es-abstract"": ""1.10.0"",
        ""function-bind"": ""1.1.1"",
        ""has"": ""1.0.1""
      }}
    }},
    ""object.omit"": {{
      ""version"": ""2.0.1"",
      ""resolved"": ""https://registry.npmjs.org/object.omit/-/object.omit-2.0.1.tgz"",
      ""integrity"": ""sha1-Gpx0SCnznbuFjHbKNXmuKlTr0fo="",
      ""dev"": true,
      ""requires"": {{
        ""for-own"": ""0.1.5"",
        ""is-extendable"": ""0.1.1""
      }},
      ""dependencies"": {{
        ""for-own"": {{
          ""version"": ""0.1.5"",
          ""resolved"": ""https://registry.npmjs.org/for-own/-/for-own-0.1.5.tgz"",
          ""integrity"": ""sha1-UmXGgaTylNq78XyVCbZ2OqhFEM4="",
          ""dev"": true,
          ""requires"": {{
            ""for-in"": ""1.0.2""
          }}
        }}
      }}
    }},
    ""object.values"": {{
      ""version"": ""1.0.4"",
      ""resolved"": ""https://registry.npmjs.org/object.values/-/object.values-1.0.4.tgz"",
      ""integrity"": ""sha1-5STaCbT2b/Bd9FdUbscqyZ8TBpo="",
      ""dev"": true,
      ""requires"": {{
        ""define-properties"": ""1.1.2"",
        ""es-abstract"": ""1.10.0"",
        ""function-bind"": ""1.1.1"",
        ""has"": ""1.0.1""
      }}
    }},
    ""offline-plugin"": {{
      ""version"": ""4.9.0"",
      ""resolved"": ""https://registry.npmjs.org/offline-plugin/-/offline-plugin-4.9.0.tgz"",
      ""integrity"": ""sha1-CHSWDAywwkn5a3z8Z0IXk0Zg7Vw="",
      ""dev"": true,
      ""requires"": {{
        ""deep-extend"": ""0.4.2"",
        ""ejs"": ""2.5.7"",
        ""loader-utils"": ""0.2.17"",
        ""minimatch"": ""3.0.4"",
        ""slash"": ""1.0.0""
      }}
    }},
    ""on-finished"": {{
      ""version"": ""2.3.0"",
      ""resolved"": ""https://registry.npmjs.org/on-finished/-/on-finished-2.3.0.tgz"",
      ""integrity"": ""sha1-IPEzZIGwg811M3mSoWlxqi2QaUc="",
      ""dev"": true,
      ""requires"": {{
        ""ee-first"": ""1.1.1""
      }}
    }},
    ""on-headers"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/on-headers/-/on-headers-1.0.1.tgz"",
      ""integrity"": ""sha1-ko9dD0cNSTQmUepnlLCFfBAGk/c="",
      ""dev"": true
    }},
    ""once"": {{
      ""version"": ""1.4.0"",
      ""resolved"": ""https://registry.npmjs.org/once/-/once-1.4.0.tgz"",
      ""integrity"": ""sha1-WDsap3WWHUsROsF9nFC6753Xa9E="",
      ""dev"": true,
      ""requires"": {{
        ""wrappy"": ""1.0.2""
      }}
    }},
    ""onetime"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/onetime/-/onetime-1.1.0.tgz"",
      ""integrity"": ""sha1-ofeDj4MUxRbwXs78vEzP4EtO14k="",
      ""dev"": true
    }},
    ""open"": {{
      ""version"": ""0.0.5"",
      ""resolved"": ""https://registry.npmjs.org/open/-/open-0.0.5.tgz"",
      ""integrity"": ""sha1-QsPhjslUZra/DcQvOilFw/DK2Pw="",
      ""dev"": true
    }},
    ""opt-cli"": {{
      ""version"": ""1.5.1"",
      ""resolved"": ""https://registry.npmjs.org/opt-cli/-/opt-cli-1.5.1.tgz"",
      ""integrity"": ""sha1-BNtEexPJa5kusxaFJm9O0NlzbcI="",
      ""dev"": true,
      ""requires"": {{
        ""commander"": ""2.9.0"",
        ""lodash.clone"": ""4.3.2"",
        ""manage-path"": ""2.0.0"",
        ""spawn-command"": ""0.0.2-1""
      }},
      ""dependencies"": {{
        ""commander"": {{
          ""version"": ""2.9.0"",
          ""resolved"": ""https://registry.npmjs.org/commander/-/commander-2.9.0.tgz"",
          ""integrity"": ""sha1-nJkJQXbhIkDLItbFFGCYQA/g99Q="",
          ""dev"": true,
          ""requires"": {{
            ""graceful-readlink"": ""1.0.1""
          }}
        }},
        ""spawn-command"": {{
          ""version"": ""0.0.2-1"",
          ""resolved"": ""https://registry.npmjs.org/spawn-command/-/spawn-command-0.0.2-1.tgz"",
          ""integrity"": ""sha1-YvXpRmmBwbeW3Fkpk34RycaSG9A="",
          ""dev"": true
        }}
      }}
    }},
    ""optimist"": {{
      ""version"": ""0.6.1"",
      ""resolved"": ""https://registry.npmjs.org/optimist/-/optimist-0.6.1.tgz"",
      ""integrity"": ""sha1-2j6nRob6IaGaERwybpDrFaAZZoY="",
      ""dev"": true,
      ""requires"": {{
        ""minimist"": ""0.0.8"",
        ""wordwrap"": ""0.0.3""
      }},
      ""dependencies"": {{
        ""wordwrap"": {{
          ""version"": ""0.0.3"",
          ""resolved"": ""https://registry.npmjs.org/wordwrap/-/wordwrap-0.0.3.tgz"",
          ""integrity"": ""sha1-o9XabNXAvAAI03I0u68b7WMFkQc="",
          ""dev"": true
        }}
      }}
    }},
    ""optionator"": {{
      ""version"": ""0.8.2"",
      ""resolved"": ""https://registry.npmjs.org/optionator/-/optionator-0.8.2.tgz"",
      ""integrity"": ""sha1-NkxeQJ0/TWMB1sC0wFu6UBgK62Q="",
      ""dev"": true,
      ""requires"": {{
        ""deep-is"": ""0.1.3"",
        ""fast-levenshtein"": ""2.0.6"",
        ""levn"": ""0.3.0"",
        ""prelude-ls"": ""1.1.2"",
        ""type-check"": ""0.3.2"",
        ""wordwrap"": ""1.0.0""
      }}
    }},
    ""original"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/original/-/original-1.0.0.tgz"",
      ""integrity"": ""sha1-kUf5P6FpbQS+YeAb1QuurKZWvTs="",
      ""dev"": true,
      ""requires"": {{
        ""url-parse"": ""1.0.5""
      }},
      ""dependencies"": {{
        ""url-parse"": {{
          ""version"": ""1.0.5"",
          ""resolved"": ""https://registry.npmjs.org/url-parse/-/url-parse-1.0.5.tgz"",
          ""integrity"": ""sha1-CFSGBCKv3P7+tsllxmLUgAFpkns="",
          ""dev"": true,
          ""requires"": {{
            ""querystringify"": ""0.0.4"",
            ""requires-port"": ""1.0.0""
          }}
        }}
      }}
    }},
    ""os-browserify"": {{
      ""version"": ""0.3.0"",
      ""resolved"": ""https://registry.npmjs.org/os-browserify/-/os-browserify-0.3.0.tgz"",
      ""integrity"": ""sha1-hUNzx/XCMVkU/Jv8a9gjj92h7Cc="",
      ""dev"": true
    }},
    ""os-homedir"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/os-homedir/-/os-homedir-1.0.2.tgz"",
      ""integrity"": ""sha1-/7xJiDNuDoM94MFox+8VISGqf7M="",
      ""dev"": true
    }},
    ""os-locale"": {{
      ""version"": ""1.4.0"",
      ""resolved"": ""https://registry.npmjs.org/os-locale/-/os-locale-1.4.0.tgz"",
      ""integrity"": ""sha1-IPnxeuKe00XoveWDsT0gCYA8FNk="",
      ""dev"": true,
      ""requires"": {{
        ""lcid"": ""1.0.0""
      }}
    }},
    ""os-tmpdir"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/os-tmpdir/-/os-tmpdir-1.0.2.tgz"",
      ""integrity"": ""sha1-u+Z0BseaqFxc/sdm/lc0VV36EnQ="",
      ""dev"": true
    }},
    ""osenv"": {{
      ""version"": ""0.1.4"",
      ""resolved"": ""https://registry.npmjs.org/osenv/-/osenv-0.1.4.tgz"",
      ""integrity"": ""sha1-Qv5tWVPfBsgGS+bxdsPQWqqjRkQ="",
      ""dev"": true,
      ""requires"": {{
        ""os-homedir"": ""1.0.2"",
        ""os-tmpdir"": ""1.0.2""
      }}
    }},
    ""p-cancelable"": {{
      ""version"": ""0.3.0"",
      ""resolved"": ""https://registry.npmjs.org/p-cancelable/-/p-cancelable-0.3.0.tgz"",
      ""integrity"": ""sha512-RVbZPLso8+jFeq1MfNvgXtCRED2raz/dKpacfTNxsx6pLEpEomM7gah6VeHSYV3+vo0OAi4MkArtQcWWXuQoyw=="",
      ""dev"": true
    }},
    ""p-finally"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/p-finally/-/p-finally-1.0.0.tgz"",
      ""integrity"": ""sha1-P7z7FbiZpEEjs0ttzBi3JDNqLK4="",
      ""dev"": true
    }},
    ""p-limit"": {{
      ""version"": ""1.2.0"",
      ""resolved"": ""https://registry.npmjs.org/p-limit/-/p-limit-1.2.0.tgz"",
      ""integrity"": ""sha512-Y/OtIaXtUPr4/YpMv1pCL5L5ed0rumAaAeBSj12F+bSlMdys7i8oQF/GUJmfpTS/QoaRrS/k6pma29haJpsMng=="",
      ""dev"": true,
      ""requires"": {{
        ""p-try"": ""1.0.0""
      }}
    }},
    ""p-locate"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/p-locate/-/p-locate-2.0.0.tgz"",
      ""integrity"": ""sha1-IKAQOyIqcMj9OcwuWAaA893l7EM="",
      ""dev"": true,
      ""requires"": {{
        ""p-limit"": ""1.2.0""
      }}
    }},
    ""p-try"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/p-try/-/p-try-1.0.0.tgz"",
      ""integrity"": ""sha1-y8ec26+P1CKOE/Yh8rGiN8GyB7M="",
      ""dev"": true
    }},
    ""pako"": {{
      ""version"": ""1.0.6"",
      ""resolved"": ""https://registry.npmjs.org/pako/-/pako-1.0.6.tgz"",
      ""integrity"": ""sha512-lQe48YPsMJAig+yngZ87Lus+NF+3mtu7DVOBu6b/gHO1YpKwIj5AWjZ/TOS7i46HD/UixzWb1zeWDZfGZ3iYcg=="",
      ""dev"": true
    }},
    ""param-case"": {{
      ""version"": ""2.1.1"",
      ""resolved"": ""https://registry.npmjs.org/param-case/-/param-case-2.1.1.tgz"",
      ""integrity"": ""sha1-35T9jPZTHs915r75oIWPvHK+Ikc="",
      ""dev"": true,
      ""requires"": {{
        ""no-case"": ""2.3.2""
      }}
    }},
    ""parse-asn1"": {{
      ""version"": ""5.1.0"",
      ""resolved"": ""https://registry.npmjs.org/parse-asn1/-/parse-asn1-5.1.0.tgz"",
      ""integrity"": ""sha1-N8T5t+06tlx0gXtfJICTf7+XxxI="",
      ""dev"": true,
      ""requires"": {{
        ""asn1.js"": ""4.9.2"",
        ""browserify-aes"": ""1.1.1"",
        ""create-hash"": ""1.1.3"",
        ""evp_bytestokey"": ""1.0.3"",
        ""pbkdf2"": ""3.0.14""
      }}
    }},
    ""parse-glob"": {{
      ""version"": ""3.0.4"",
      ""resolved"": ""https://registry.npmjs.org/parse-glob/-/parse-glob-3.0.4.tgz"",
      ""integrity"": ""sha1-ssN2z7EfNVE7rdFz7wu246OIORw="",
      ""dev"": true,
      ""requires"": {{
        ""glob-base"": ""0.3.0"",
        ""is-dotfile"": ""1.0.3"",
        ""is-extglob"": ""1.0.0"",
        ""is-glob"": ""2.0.1""
      }}
    }},
    ""parse-json"": {{
      ""version"": ""2.2.0"",
      ""resolved"": ""https://registry.npmjs.org/parse-json/-/parse-json-2.2.0.tgz"",
      ""integrity"": ""sha1-9ID0BDTvgHQfhGkJn43qGPVaTck="",
      ""dev"": true,
      ""requires"": {{
        ""error-ex"": ""1.3.1""
      }}
    }},
    ""parse5"": {{
      ""version"": ""1.5.1"",
      ""resolved"": ""https://registry.npmjs.org/parse5/-/parse5-1.5.1.tgz"",
      ""integrity"": ""sha1-m387DeMr543CQBsXVzzK8Pb1nZQ="",
      ""dev"": true
    }},
    ""parseurl"": {{
      ""version"": ""1.3.2"",
      ""resolved"": ""https://registry.npmjs.org/parseurl/-/parseurl-1.3.2.tgz"",
      ""integrity"": ""sha1-/CidTtiZMRlGDBViUyYs3I3mW/M="",
      ""dev"": true
    }},
    ""path-browserify"": {{
      ""version"": ""0.0.0"",
      ""resolved"": ""https://registry.npmjs.org/path-browserify/-/path-browserify-0.0.0.tgz"",
      ""integrity"": ""sha1-oLhwcpquIUAFt9UDLsLLuw+0RRo="",
      ""dev"": true
    }},
    ""path-exists"": {{
      ""version"": ""2.1.0"",
      ""resolved"": ""https://registry.npmjs.org/path-exists/-/path-exists-2.1.0.tgz"",
      ""integrity"": ""sha1-D+tsZPD8UY2adU3V77YscCJ2H0s="",
      ""dev"": true,
      ""requires"": {{
        ""pinkie-promise"": ""2.0.1""
      }}
    }},
    ""path-is-absolute"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/path-is-absolute/-/path-is-absolute-1.0.1.tgz"",
      ""integrity"": ""sha1-F0uSaHNVNP+8es5r9TpanhtcX18="",
      ""dev"": true
    }},
    ""path-is-inside"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/path-is-inside/-/path-is-inside-1.0.2.tgz"",
      ""integrity"": ""sha1-NlQX3t5EQw0cEa9hAn+s8HS9/FM="",
      ""dev"": true
    }},
    ""path-parse"": {{
      ""version"": ""1.0.5"",
      ""resolved"": ""https://registry.npmjs.org/path-parse/-/path-parse-1.0.5.tgz"",
      ""integrity"": ""sha1-PBrfhx6pzWyUMbbqK9dKD/BVxME="",
      ""dev"": true
    }},
    ""path-to-regexp"": {{
      ""version"": ""1.7.0"",
      ""resolved"": ""https://registry.npmjs.org/path-to-regexp/-/path-to-regexp-1.7.0.tgz"",
      ""integrity"": ""sha1-Wf3g9DW62suhA6hOnTvGTpa5k30="",
      ""requires"": {{
        ""isarray"": ""0.0.1""
      }}
    }},
    ""path-type"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/path-type/-/path-type-1.1.0.tgz"",
      ""integrity"": ""sha1-WcRPfuSR2nBNpBXaWkBwuk+P5EE="",
      ""dev"": true,
      ""requires"": {{
        ""graceful-fs"": ""4.1.11"",
        ""pify"": ""2.3.0"",
        ""pinkie-promise"": ""2.0.1""
      }}
    }},
    ""pbkdf2"": {{
      ""version"": ""3.0.14"",
      ""resolved"": ""https://registry.npmjs.org/pbkdf2/-/pbkdf2-3.0.14.tgz"",
      ""integrity"": ""sha512-gjsZW9O34fm0R7PaLHRJmLLVfSoesxztjPjE9o6R+qtVJij90ltg1joIovN9GKrRW3t1PzhDDG3UMEMFfZ+1wA=="",
      ""dev"": true,
      ""requires"": {{
        ""create-hash"": ""1.1.3"",
        ""create-hmac"": ""1.1.6"",
        ""ripemd160"": ""2.0.1"",
        ""safe-buffer"": ""5.1.1"",
        ""sha.js"": ""2.4.9""
      }}
    }},
    ""performance-now"": {{
      ""version"": ""2.1.0"",
      ""resolved"": ""https://registry.npmjs.org/performance-now/-/performance-now-2.1.0.tgz"",
      ""integrity"": ""sha1-Ywn04OX6kT7BxpMHrjZLSzd8nns="",
      ""dev"": true
    }},
    ""pify"": {{
      ""version"": ""2.3.0"",
      ""resolved"": ""https://registry.npmjs.org/pify/-/pify-2.3.0.tgz"",
      ""integrity"": ""sha1-7RQaasBDqEnqWISY59yosVMw6Qw="",
      ""dev"": true
    }},
    ""pinkie"": {{
      ""version"": ""2.0.4"",
      ""resolved"": ""https://registry.npmjs.org/pinkie/-/pinkie-2.0.4.tgz"",
      ""integrity"": ""sha1-clVrgM+g1IqXToDnckjoDtT3+HA="",
      ""dev"": true
    }},
    ""pinkie-promise"": {{
      ""version"": ""2.0.1"",
      ""resolved"": ""https://registry.npmjs.org/pinkie-promise/-/pinkie-promise-2.0.1.tgz"",
      ""integrity"": ""sha1-ITXW36ejWMBprJsXh3YogihFD/o="",
      ""dev"": true,
      ""requires"": {{
        ""pinkie"": ""2.0.4""
      }}
    }},
    ""pkg-dir"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/pkg-dir/-/pkg-dir-1.0.0.tgz"",
      ""integrity"": ""sha1-ektQio1bstYp1EcFb/TpyTFM89Q="",
      ""dev"": true,
      ""requires"": {{
        ""find-up"": ""1.1.2""
      }}
    }},
    ""pluralize"": {{
      ""version"": ""1.2.1"",
      ""resolved"": ""https://registry.npmjs.org/pluralize/-/pluralize-1.2.1.tgz"",
      ""integrity"": ""sha1-0aIUg/0iu0HlihL6NCGCMUCJfEU="",
      ""dev"": true
    }},
    ""postcss"": {{
      ""version"": ""5.2.18"",
      ""resolved"": ""https://registry.npmjs.org/postcss/-/postcss-5.2.18.tgz"",
      ""integrity"": ""sha512-zrUjRRe1bpXKsX1qAJNJjqZViErVuyEkMTRrwu4ud4sbTtIBRmtaYDrHmcGgmrbsW3MHfmtIf+vJumgQn+PrXg=="",
      ""dev"": true,
      ""requires"": {{
        ""chalk"": ""1.1.3"",
        ""js-base64"": ""2.4.0"",
        ""source-map"": ""0.5.7"",
        ""supports-color"": ""3.2.3""
      }},
      ""dependencies"": {{
        ""source-map"": {{
          ""version"": ""0.5.7"",
          ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.5.7.tgz"",
          ""integrity"": ""sha1-igOdLRAh0i0eoUyA2OpGi6LvP8w="",
          ""dev"": true
        }}
      }}
    }},
    ""postcss-advanced-variables"": {{
      ""version"": ""1.2.2"",
      ""resolved"": ""https://registry.npmjs.org/postcss-advanced-variables/-/postcss-advanced-variables-1.2.2.tgz"",
      ""integrity"": ""sha1-kKYhMmLmagUKNotKnF1HeNctvXQ="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""5.2.18""
      }}
    }},
    ""postcss-atroot"": {{
      ""version"": ""0.1.3"",
      ""resolved"": ""https://registry.npmjs.org/postcss-atroot/-/postcss-atroot-0.1.3.tgz"",
      ""integrity"": ""sha1-Z1LAIwx0UUBUk0WysOMOvtoBpAU="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""5.2.18""
      }}
    }},
    ""postcss-calc"": {{
      ""version"": ""5.3.1"",
      ""resolved"": ""https://registry.npmjs.org/postcss-calc/-/postcss-calc-5.3.1.tgz"",
      ""integrity"": ""sha1-d7rnypKK2FcW4v2kLyYb98HWW14="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""5.2.18"",
        ""postcss-message-helpers"": ""2.0.0"",
        ""reduce-css-calc"": ""1.3.0""
      }}
    }},
    ""postcss-color-function"": {{
      ""version"": ""2.0.1"",
      ""resolved"": ""https://registry.npmjs.org/postcss-color-function/-/postcss-color-function-2.0.1.tgz"",
      ""integrity"": ""sha1-mtIm9VDop8f4uKd4YFRbbdf1UkE="",
      ""dev"": true,
      ""requires"": {{
        ""css-color-function"": ""1.3.3"",
        ""postcss"": ""5.2.18"",
        ""postcss-message-helpers"": ""2.0.0"",
        ""postcss-value-parser"": ""3.3.0""
      }}
    }},
    ""postcss-colormin"": {{
      ""version"": ""2.2.2"",
      ""resolved"": ""https://registry.npmjs.org/postcss-colormin/-/postcss-colormin-2.2.2.tgz"",
      ""integrity"": ""sha1-ZjFBfV8OkJo9fsJrJMio0eT5bks="",
      ""dev"": true,
      ""requires"": {{
        ""colormin"": ""1.1.2"",
        ""postcss"": ""5.2.18"",
        ""postcss-value-parser"": ""3.3.0""
      }}
    }},
    ""postcss-convert-values"": {{
      ""version"": ""2.6.1"",
      ""resolved"": ""https://registry.npmjs.org/postcss-convert-values/-/postcss-convert-values-2.6.1.tgz"",
      ""integrity"": ""sha1-u9hZPFwf0uPRwyK7kl3K6Nrk1i0="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""5.2.18"",
        ""postcss-value-parser"": ""3.3.0""
      }}
    }},
    ""postcss-custom-media"": {{
      ""version"": ""5.0.1"",
      ""resolved"": ""https://registry.npmjs.org/postcss-custom-media/-/postcss-custom-media-5.0.1.tgz"",
      ""integrity"": ""sha1-E40loYS/LrVN4S1VpsAcMKnYvYE="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""5.2.18""
      }}
    }},
    ""postcss-custom-properties"": {{
      ""version"": ""5.0.2"",
      ""resolved"": ""https://registry.npmjs.org/postcss-custom-properties/-/postcss-custom-properties-5.0.2.tgz"",
      ""integrity"": ""sha1-lxnXjy2pz59TgQrrwj1GVhMKzrE="",
      ""dev"": true,
      ""requires"": {{
        ""balanced-match"": ""0.4.2"",
        ""postcss"": ""5.2.18""
      }},
      ""dependencies"": {{
        ""balanced-match"": {{
          ""version"": ""0.4.2"",
          ""resolved"": ""https://registry.npmjs.org/balanced-match/-/balanced-match-0.4.2.tgz"",
          ""integrity"": ""sha1-yz8+PHMtwPAe5wtAPzAuYddwmDg="",
          ""dev"": true
        }}
      }}
    }},
    ""postcss-custom-selectors"": {{
      ""version"": ""3.0.0"",
      ""resolved"": ""https://registry.npmjs.org/postcss-custom-selectors/-/postcss-custom-selectors-3.0.0.tgz"",
      ""integrity"": ""sha1-j4Ekn17Qeo0JF89qOf5bBWt/lqw="",
      ""dev"": true,
      ""requires"": {{
        ""balanced-match"": ""0.2.1"",
        ""postcss"": ""5.2.18"",
        ""postcss-selector-matches"": ""2.0.5""
      }},
      ""dependencies"": {{
        ""balanced-match"": {{
          ""version"": ""0.2.1"",
          ""resolved"": ""https://registry.npmjs.org/balanced-match/-/balanced-match-0.2.1.tgz"",
          ""integrity"": ""sha1-e8ZYtL7WHu5CStdPdfXD4sTfPMc="",
          ""dev"": true
        }}
      }}
    }},
    ""postcss-discard-comments"": {{
      ""version"": ""2.0.4"",
      ""resolved"": ""https://registry.npmjs.org/postcss-discard-comments/-/postcss-discard-comments-2.0.4.tgz"",
      ""integrity"": ""sha1-vv6J+v1bPazlzM5Rt2uBUUvgDj0="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""5.2.18""
      }}
    }},
    ""postcss-discard-duplicates"": {{
      ""version"": ""2.1.0"",
      ""resolved"": ""https://registry.npmjs.org/postcss-discard-duplicates/-/postcss-discard-duplicates-2.1.0.tgz"",
      ""integrity"": ""sha1-uavye4isGIFYpesSq8riAmO5GTI="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""5.2.18""
      }}
    }},
    ""postcss-discard-empty"": {{
      ""version"": ""2.1.0"",
      ""resolved"": ""https://registry.npmjs.org/postcss-discard-empty/-/postcss-discard-empty-2.1.0.tgz"",
      ""integrity"": ""sha1-0rS9nVztXr2Nyt52QMfXzX9PkrU="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""5.2.18""
      }}
    }},
    ""postcss-discard-overridden"": {{
      ""version"": ""0.1.1"",
      ""resolved"": ""https://registry.npmjs.org/postcss-discard-overridden/-/postcss-discard-overridden-0.1.1.tgz"",
      ""integrity"": ""sha1-ix6vVU9ob7KIzYdMVWZ7CqNmjVg="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""5.2.18""
      }}
    }},
    ""postcss-discard-unused"": {{
      ""version"": ""2.2.3"",
      ""resolved"": ""https://registry.npmjs.org/postcss-discard-unused/-/postcss-discard-unused-2.2.3.tgz"",
      ""integrity"": ""sha1-vOMLLMWR/8Y0Mitfs0ZLbZNPRDM="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""5.2.18"",
        ""uniqs"": ""2.0.0""
      }}
    }},
    ""postcss-extend"": {{
      ""version"": ""1.0.5"",
      ""resolved"": ""https://registry.npmjs.org/postcss-extend/-/postcss-extend-1.0.5.tgz"",
      ""integrity"": ""sha1-XqmL94e6PKz030YJdD+AqDOx0Oc="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""5.2.18""
      }}
    }},
    ""postcss-filter-plugins"": {{
      ""version"": ""2.0.2"",
      ""resolved"": ""https://registry.npmjs.org/postcss-filter-plugins/-/postcss-filter-plugins-2.0.2.tgz"",
      ""integrity"": ""sha1-bYWGJTTXNaxCDkqFgG4fXUKG2Ew="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""5.2.18"",
        ""uniqid"": ""4.1.1""
      }}
    }},
    ""postcss-load-config"": {{
      ""version"": ""1.2.0"",
      ""resolved"": ""https://registry.npmjs.org/postcss-load-config/-/postcss-load-config-1.2.0.tgz"",
      ""integrity"": ""sha1-U56a/J3chiASHr+djDZz4M5Q0oo="",
      ""dev"": true,
      ""requires"": {{
        ""cosmiconfig"": ""2.2.2"",
        ""object-assign"": ""4.1.1"",
        ""postcss-load-options"": ""1.2.0"",
        ""postcss-load-plugins"": ""2.3.0""
      }}
    }},
    ""postcss-load-options"": {{
      ""version"": ""1.2.0"",
      ""resolved"": ""https://registry.npmjs.org/postcss-load-options/-/postcss-load-options-1.2.0.tgz"",
      ""integrity"": ""sha1-sJixVZ3awt8EvAuzdfmaXP4rbYw="",
      ""dev"": true,
      ""requires"": {{
        ""cosmiconfig"": ""2.2.2"",
        ""object-assign"": ""4.1.1""
      }}
    }},
    ""postcss-load-plugins"": {{
      ""version"": ""2.3.0"",
      ""resolved"": ""https://registry.npmjs.org/postcss-load-plugins/-/postcss-load-plugins-2.3.0.tgz"",
      ""integrity"": ""sha1-dFdoEWWZrKLwCfrUJrABdQSdjZI="",
      ""dev"": true,
      ""requires"": {{
        ""cosmiconfig"": ""2.2.2"",
        ""object-assign"": ""4.1.1""
      }}
    }},
    ""postcss-loader"": {{
      ""version"": ""1.3.3"",
      ""resolved"": ""https://registry.npmjs.org/postcss-loader/-/postcss-loader-1.3.3.tgz"",
      ""integrity"": ""sha1-piHqH6KQYqg5cqRvVEhncTAZFus="",
      ""dev"": true,
      ""requires"": {{
        ""loader-utils"": ""1.1.0"",
        ""object-assign"": ""4.1.1"",
        ""postcss"": ""5.2.18"",
        ""postcss-load-config"": ""1.2.0""
      }},
      ""dependencies"": {{
        ""loader-utils"": {{
          ""version"": ""1.1.0"",
          ""resolved"": ""https://registry.npmjs.org/loader-utils/-/loader-utils-1.1.0.tgz"",
          ""integrity"": ""sha1-yYrvSIvM7aL/teLeZG1qdUQp9c0="",
          ""dev"": true,
          ""requires"": {{
            ""big.js"": ""3.2.0"",
            ""emojis-list"": ""2.1.0"",
            ""json5"": ""0.5.1""
          }}
        }}
      }}
    }},
    ""postcss-media-minmax"": {{
      ""version"": ""2.1.2"",
      ""resolved"": ""https://registry.npmjs.org/postcss-media-minmax/-/postcss-media-minmax-2.1.2.tgz"",
      ""integrity"": ""sha1-RExc+JJqteT9iiUJ6Sl+dRZJzfg="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""5.2.18""
      }}
    }},
    ""postcss-merge-idents"": {{
      ""version"": ""2.1.7"",
      ""resolved"": ""https://registry.npmjs.org/postcss-merge-idents/-/postcss-merge-idents-2.1.7.tgz"",
      ""integrity"": ""sha1-TFUwMTwI4dWzu/PSu8dH4njuonA="",
      ""dev"": true,
      ""requires"": {{
        ""has"": ""1.0.1"",
        ""postcss"": ""5.2.18"",
        ""postcss-value-parser"": ""3.3.0""
      }}
    }},
    ""postcss-merge-longhand"": {{
      ""version"": ""2.0.2"",
      ""resolved"": ""https://registry.npmjs.org/postcss-merge-longhand/-/postcss-merge-longhand-2.0.2.tgz"",
      ""integrity"": ""sha1-I9kM0Sewp3mUkVMyc5A0oaTz1lg="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""5.2.18""
      }}
    }},
    ""postcss-merge-rules"": {{
      ""version"": ""2.1.2"",
      ""resolved"": ""https://registry.npmjs.org/postcss-merge-rules/-/postcss-merge-rules-2.1.2.tgz"",
      ""integrity"": ""sha1-0d9d+qexrMO+VT8OnhDofGG19yE="",
      ""dev"": true,
      ""requires"": {{
        ""browserslist"": ""1.7.7"",
        ""caniuse-api"": ""1.6.1"",
        ""postcss"": ""5.2.18"",
        ""postcss-selector-parser"": ""2.2.3"",
        ""vendors"": ""1.0.1""
      }}
    }},
    ""postcss-message-helpers"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/postcss-message-helpers/-/postcss-message-helpers-2.0.0.tgz"",
      ""integrity"": ""sha1-pPL0+rbk/gAvCu0ABHjN9S+bpg4="",
      ""dev"": true
    }},
    ""postcss-minify-font-values"": {{
      ""version"": ""1.0.5"",
      ""resolved"": ""https://registry.npmjs.org/postcss-minify-font-values/-/postcss-minify-font-values-1.0.5.tgz"",
      ""integrity"": ""sha1-S1jttWZB66fIR0qzUmyv17vey2k="",
      ""dev"": true,
      ""requires"": {{
        ""object-assign"": ""4.1.1"",
        ""postcss"": ""5.2.18"",
        ""postcss-value-parser"": ""3.3.0""
      }}
    }},
    ""postcss-minify-gradients"": {{
      ""version"": ""1.0.5"",
      ""resolved"": ""https://registry.npmjs.org/postcss-minify-gradients/-/postcss-minify-gradients-1.0.5.tgz"",
      ""integrity"": ""sha1-Xb2hE3NwP4PPtKPqOIHY11/15uE="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""5.2.18"",
        ""postcss-value-parser"": ""3.3.0""
      }}
    }},
    ""postcss-minify-params"": {{
      ""version"": ""1.2.2"",
      ""resolved"": ""https://registry.npmjs.org/postcss-minify-params/-/postcss-minify-params-1.2.2.tgz"",
      ""integrity"": ""sha1-rSzgcTc7lDs9kwo/pZo1jCjW8fM="",
      ""dev"": true,
      ""requires"": {{
        ""alphanum-sort"": ""1.0.2"",
        ""postcss"": ""5.2.18"",
        ""postcss-value-parser"": ""3.3.0"",
        ""uniqs"": ""2.0.0""
      }}
    }},
    ""postcss-minify-selectors"": {{
      ""version"": ""2.1.1"",
      ""resolved"": ""https://registry.npmjs.org/postcss-minify-selectors/-/postcss-minify-selectors-2.1.1.tgz"",
      ""integrity"": ""sha1-ssapjAByz5G5MtGkllCBFDEXNb8="",
      ""dev"": true,
      ""requires"": {{
        ""alphanum-sort"": ""1.0.2"",
        ""has"": ""1.0.1"",
        ""postcss"": ""5.2.18"",
        ""postcss-selector-parser"": ""2.2.3""
      }}
    }},
    ""postcss-mixins"": {{
      ""version"": ""2.1.1"",
      ""resolved"": ""https://registry.npmjs.org/postcss-mixins/-/postcss-mixins-2.1.1.tgz"",
      ""integrity"": ""sha1-sUGggD76ji10SGf42RWWiQz5JBs="",
      ""dev"": true,
      ""requires"": {{
        ""globby"": ""3.0.1"",
        ""postcss"": ""5.2.18"",
        ""postcss-simple-vars"": ""1.2.0""
      }},
      ""dependencies"": {{
        ""glob"": {{
          ""version"": ""5.0.15"",
          ""resolved"": ""https://registry.npmjs.org/glob/-/glob-5.0.15.tgz"",
          ""integrity"": ""sha1-G8k2ueAvSmA/zCIuz3Yz0wuLk7E="",
          ""dev"": true,
          ""requires"": {{
            ""inflight"": ""1.0.6"",
            ""inherits"": ""2.0.3"",
            ""minimatch"": ""3.0.4"",
            ""once"": ""1.4.0"",
            ""path-is-absolute"": ""1.0.1""
          }}
        }},
        ""globby"": {{
          ""version"": ""3.0.1"",
          ""resolved"": ""https://registry.npmjs.org/globby/-/globby-3.0.1.tgz"",
          ""integrity"": ""sha1-IJSvhCHhkVIVDViT62QWsxLZoi8="",
          ""dev"": true,
          ""requires"": {{
            ""array-union"": ""1.0.2"",
            ""arrify"": ""1.0.1"",
            ""glob"": ""5.0.15"",
            ""object-assign"": ""4.1.1"",
            ""pify"": ""2.3.0"",
            ""pinkie-promise"": ""1.0.0""
          }}
        }},
        ""pinkie"": {{
          ""version"": ""1.0.0"",
          ""resolved"": ""https://registry.npmjs.org/pinkie/-/pinkie-1.0.0.tgz"",
          ""integrity"": ""sha1-Wkfyi6EBXQIBvae/DzWOR77Ix+Q="",
          ""dev"": true
        }},
        ""pinkie-promise"": {{
          ""version"": ""1.0.0"",
          ""resolved"": ""https://registry.npmjs.org/pinkie-promise/-/pinkie-promise-1.0.0.tgz"",
          ""integrity"": ""sha1-0dpn9UglY7t89X8oauKCLs+/NnA="",
          ""dev"": true,
          ""requires"": {{
            ""pinkie"": ""1.0.0""
          }}
        }}
      }}
    }},
    ""postcss-modules-extract-imports"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/postcss-modules-extract-imports/-/postcss-modules-extract-imports-1.1.0.tgz"",
      ""integrity"": ""sha1-thTJcgvmgW6u41+zpfqh26agXds="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""6.0.16""
      }},
      ""dependencies"": {{
        ""ansi-styles"": {{
          ""version"": ""3.2.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-styles/-/ansi-styles-3.2.0.tgz"",
          ""integrity"": ""sha512-NnSOmMEYtVR2JVMIGTzynRkkaxtiq1xnFBcdQD/DnNCYPoEPsVJhM98BDyaoNOQIi7p4okdi3E27eN7GQbsUug=="",
          ""dev"": true,
          ""requires"": {{
            ""color-convert"": ""1.9.1""
          }}
        }},
        ""chalk"": {{
          ""version"": ""2.3.0"",
          ""resolved"": ""https://registry.npmjs.org/chalk/-/chalk-2.3.0.tgz"",
          ""integrity"": ""sha512-Az5zJR2CBujap2rqXGaJKaPHyJ0IrUimvYNX+ncCy8PJP4ltOGTrHUIo097ZaL2zMeKYpiCdqDvS6zdrTFok3Q=="",
          ""dev"": true,
          ""requires"": {{
            ""ansi-styles"": ""3.2.0"",
            ""escape-string-regexp"": ""1.0.5"",
            ""supports-color"": ""4.5.0""
          }},
          ""dependencies"": {{
            ""supports-color"": {{
              ""version"": ""4.5.0"",
              ""resolved"": ""https://registry.npmjs.org/supports-color/-/supports-color-4.5.0.tgz"",
              ""integrity"": ""sha1-vnoN5ITexcXN34s9WRJQRJEvY1s="",
              ""dev"": true,
              ""requires"": {{
                ""has-flag"": ""2.0.0""
              }}
            }}
          }}
        }},
        ""has-flag"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/has-flag/-/has-flag-2.0.0.tgz"",
          ""integrity"": ""sha1-6CB68cx7MNRGzHC3NLXovhj4jVE="",
          ""dev"": true
        }},
        ""postcss"": {{
          ""version"": ""6.0.16"",
          ""resolved"": ""https://registry.npmjs.org/postcss/-/postcss-6.0.16.tgz"",
          ""integrity"": ""sha512-m758RWPmSjFH/2MyyG3UOW1fgYbR9rtdzz5UNJnlm7OLtu4B2h9C6gi+bE4qFKghsBRFfZT8NzoQBs6JhLotoA=="",
          ""dev"": true,
          ""requires"": {{
            ""chalk"": ""2.3.0"",
            ""source-map"": ""0.6.1"",
            ""supports-color"": ""5.1.0""
          }}
        }},
        ""source-map"": {{
          ""version"": ""0.6.1"",
          ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.6.1.tgz"",
          ""integrity"": ""sha512-UjgapumWlbMhkBgzT7Ykc5YXUT46F0iKu8SGXq0bcwP5dz/h0Plj6enJqjz1Zbq2l5WaqYnrVbwWOWMyF3F47g=="",
          ""dev"": true
        }},
        ""supports-color"": {{
          ""version"": ""5.1.0"",
          ""resolved"": ""https://registry.npmjs.org/supports-color/-/supports-color-5.1.0.tgz"",
          ""integrity"": ""sha512-Ry0AwkoKjDpVKK4sV4h6o3UJmNRbjYm2uXhwfj3J56lMVdvnUNqzQVRztOOMGQ++w1K/TjNDFvpJk0F/LoeBCQ=="",
          ""dev"": true,
          ""requires"": {{
            ""has-flag"": ""2.0.0""
          }}
        }}
      }}
    }},
    ""postcss-modules-local-by-default"": {{
      ""version"": ""1.2.0"",
      ""resolved"": ""https://registry.npmjs.org/postcss-modules-local-by-default/-/postcss-modules-local-by-default-1.2.0.tgz"",
      ""integrity"": ""sha1-99gMOYxaOT+nlkRmvRlQCn1hwGk="",
      ""dev"": true,
      ""requires"": {{
        ""css-selector-tokenizer"": ""0.7.0"",
        ""postcss"": ""6.0.16""
      }},
      ""dependencies"": {{
        ""ansi-styles"": {{
          ""version"": ""3.2.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-styles/-/ansi-styles-3.2.0.tgz"",
          ""integrity"": ""sha512-NnSOmMEYtVR2JVMIGTzynRkkaxtiq1xnFBcdQD/DnNCYPoEPsVJhM98BDyaoNOQIi7p4okdi3E27eN7GQbsUug=="",
          ""dev"": true,
          ""requires"": {{
            ""color-convert"": ""1.9.1""
          }}
        }},
        ""chalk"": {{
          ""version"": ""2.3.0"",
          ""resolved"": ""https://registry.npmjs.org/chalk/-/chalk-2.3.0.tgz"",
          ""integrity"": ""sha512-Az5zJR2CBujap2rqXGaJKaPHyJ0IrUimvYNX+ncCy8PJP4ltOGTrHUIo097ZaL2zMeKYpiCdqDvS6zdrTFok3Q=="",
          ""dev"": true,
          ""requires"": {{
            ""ansi-styles"": ""3.2.0"",
            ""escape-string-regexp"": ""1.0.5"",
            ""supports-color"": ""4.5.0""
          }},
          ""dependencies"": {{
            ""supports-color"": {{
              ""version"": ""4.5.0"",
              ""resolved"": ""https://registry.npmjs.org/supports-color/-/supports-color-4.5.0.tgz"",
              ""integrity"": ""sha1-vnoN5ITexcXN34s9WRJQRJEvY1s="",
              ""dev"": true,
              ""requires"": {{
                ""has-flag"": ""2.0.0""
              }}
            }}
          }}
        }},
        ""has-flag"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/has-flag/-/has-flag-2.0.0.tgz"",
          ""integrity"": ""sha1-6CB68cx7MNRGzHC3NLXovhj4jVE="",
          ""dev"": true
        }},
        ""postcss"": {{
          ""version"": ""6.0.16"",
          ""resolved"": ""https://registry.npmjs.org/postcss/-/postcss-6.0.16.tgz"",
          ""integrity"": ""sha512-m758RWPmSjFH/2MyyG3UOW1fgYbR9rtdzz5UNJnlm7OLtu4B2h9C6gi+bE4qFKghsBRFfZT8NzoQBs6JhLotoA=="",
          ""dev"": true,
          ""requires"": {{
            ""chalk"": ""2.3.0"",
            ""source-map"": ""0.6.1"",
            ""supports-color"": ""5.1.0""
          }}
        }},
        ""source-map"": {{
          ""version"": ""0.6.1"",
          ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.6.1.tgz"",
          ""integrity"": ""sha512-UjgapumWlbMhkBgzT7Ykc5YXUT46F0iKu8SGXq0bcwP5dz/h0Plj6enJqjz1Zbq2l5WaqYnrVbwWOWMyF3F47g=="",
          ""dev"": true
        }},
        ""supports-color"": {{
          ""version"": ""5.1.0"",
          ""resolved"": ""https://registry.npmjs.org/supports-color/-/supports-color-5.1.0.tgz"",
          ""integrity"": ""sha512-Ry0AwkoKjDpVKK4sV4h6o3UJmNRbjYm2uXhwfj3J56lMVdvnUNqzQVRztOOMGQ++w1K/TjNDFvpJk0F/LoeBCQ=="",
          ""dev"": true,
          ""requires"": {{
            ""has-flag"": ""2.0.0""
          }}
        }}
      }}
    }},
    ""postcss-modules-scope"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/postcss-modules-scope/-/postcss-modules-scope-1.1.0.tgz"",
      ""integrity"": ""sha1-1upkmUx5+XtipytCb75gVqGUu5A="",
      ""dev"": true,
      ""requires"": {{
        ""css-selector-tokenizer"": ""0.7.0"",
        ""postcss"": ""6.0.16""
      }},
      ""dependencies"": {{
        ""ansi-styles"": {{
          ""version"": ""3.2.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-styles/-/ansi-styles-3.2.0.tgz"",
          ""integrity"": ""sha512-NnSOmMEYtVR2JVMIGTzynRkkaxtiq1xnFBcdQD/DnNCYPoEPsVJhM98BDyaoNOQIi7p4okdi3E27eN7GQbsUug=="",
          ""dev"": true,
          ""requires"": {{
            ""color-convert"": ""1.9.1""
          }}
        }},
        ""chalk"": {{
          ""version"": ""2.3.0"",
          ""resolved"": ""https://registry.npmjs.org/chalk/-/chalk-2.3.0.tgz"",
          ""integrity"": ""sha512-Az5zJR2CBujap2rqXGaJKaPHyJ0IrUimvYNX+ncCy8PJP4ltOGTrHUIo097ZaL2zMeKYpiCdqDvS6zdrTFok3Q=="",
          ""dev"": true,
          ""requires"": {{
            ""ansi-styles"": ""3.2.0"",
            ""escape-string-regexp"": ""1.0.5"",
            ""supports-color"": ""4.5.0""
          }},
          ""dependencies"": {{
            ""supports-color"": {{
              ""version"": ""4.5.0"",
              ""resolved"": ""https://registry.npmjs.org/supports-color/-/supports-color-4.5.0.tgz"",
              ""integrity"": ""sha1-vnoN5ITexcXN34s9WRJQRJEvY1s="",
              ""dev"": true,
              ""requires"": {{
                ""has-flag"": ""2.0.0""
              }}
            }}
          }}
        }},
        ""has-flag"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/has-flag/-/has-flag-2.0.0.tgz"",
          ""integrity"": ""sha1-6CB68cx7MNRGzHC3NLXovhj4jVE="",
          ""dev"": true
        }},
        ""postcss"": {{
          ""version"": ""6.0.16"",
          ""resolved"": ""https://registry.npmjs.org/postcss/-/postcss-6.0.16.tgz"",
          ""integrity"": ""sha512-m758RWPmSjFH/2MyyG3UOW1fgYbR9rtdzz5UNJnlm7OLtu4B2h9C6gi+bE4qFKghsBRFfZT8NzoQBs6JhLotoA=="",
          ""dev"": true,
          ""requires"": {{
            ""chalk"": ""2.3.0"",
            ""source-map"": ""0.6.1"",
            ""supports-color"": ""5.1.0""
          }}
        }},
        ""source-map"": {{
          ""version"": ""0.6.1"",
          ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.6.1.tgz"",
          ""integrity"": ""sha512-UjgapumWlbMhkBgzT7Ykc5YXUT46F0iKu8SGXq0bcwP5dz/h0Plj6enJqjz1Zbq2l5WaqYnrVbwWOWMyF3F47g=="",
          ""dev"": true
        }},
        ""supports-color"": {{
          ""version"": ""5.1.0"",
          ""resolved"": ""https://registry.npmjs.org/supports-color/-/supports-color-5.1.0.tgz"",
          ""integrity"": ""sha512-Ry0AwkoKjDpVKK4sV4h6o3UJmNRbjYm2uXhwfj3J56lMVdvnUNqzQVRztOOMGQ++w1K/TjNDFvpJk0F/LoeBCQ=="",
          ""dev"": true,
          ""requires"": {{
            ""has-flag"": ""2.0.0""
          }}
        }}
      }}
    }},
    ""postcss-modules-values"": {{
      ""version"": ""1.3.0"",
      ""resolved"": ""https://registry.npmjs.org/postcss-modules-values/-/postcss-modules-values-1.3.0.tgz"",
      ""integrity"": ""sha1-7P+p1+GSUYOJ9CrQ6D9yrsRW6iA="",
      ""dev"": true,
      ""requires"": {{
        ""icss-replace-symbols"": ""1.1.0"",
        ""postcss"": ""6.0.16""
      }},
      ""dependencies"": {{
        ""ansi-styles"": {{
          ""version"": ""3.2.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-styles/-/ansi-styles-3.2.0.tgz"",
          ""integrity"": ""sha512-NnSOmMEYtVR2JVMIGTzynRkkaxtiq1xnFBcdQD/DnNCYPoEPsVJhM98BDyaoNOQIi7p4okdi3E27eN7GQbsUug=="",
          ""dev"": true,
          ""requires"": {{
            ""color-convert"": ""1.9.1""
          }}
        }},
        ""chalk"": {{
          ""version"": ""2.3.0"",
          ""resolved"": ""https://registry.npmjs.org/chalk/-/chalk-2.3.0.tgz"",
          ""integrity"": ""sha512-Az5zJR2CBujap2rqXGaJKaPHyJ0IrUimvYNX+ncCy8PJP4ltOGTrHUIo097ZaL2zMeKYpiCdqDvS6zdrTFok3Q=="",
          ""dev"": true,
          ""requires"": {{
            ""ansi-styles"": ""3.2.0"",
            ""escape-string-regexp"": ""1.0.5"",
            ""supports-color"": ""4.5.0""
          }},
          ""dependencies"": {{
            ""supports-color"": {{
              ""version"": ""4.5.0"",
              ""resolved"": ""https://registry.npmjs.org/supports-color/-/supports-color-4.5.0.tgz"",
              ""integrity"": ""sha1-vnoN5ITexcXN34s9WRJQRJEvY1s="",
              ""dev"": true,
              ""requires"": {{
                ""has-flag"": ""2.0.0""
              }}
            }}
          }}
        }},
        ""has-flag"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/has-flag/-/has-flag-2.0.0.tgz"",
          ""integrity"": ""sha1-6CB68cx7MNRGzHC3NLXovhj4jVE="",
          ""dev"": true
        }},
        ""postcss"": {{
          ""version"": ""6.0.16"",
          ""resolved"": ""https://registry.npmjs.org/postcss/-/postcss-6.0.16.tgz"",
          ""integrity"": ""sha512-m758RWPmSjFH/2MyyG3UOW1fgYbR9rtdzz5UNJnlm7OLtu4B2h9C6gi+bE4qFKghsBRFfZT8NzoQBs6JhLotoA=="",
          ""dev"": true,
          ""requires"": {{
            ""chalk"": ""2.3.0"",
            ""source-map"": ""0.6.1"",
            ""supports-color"": ""5.1.0""
          }}
        }},
        ""source-map"": {{
          ""version"": ""0.6.1"",
          ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.6.1.tgz"",
          ""integrity"": ""sha512-UjgapumWlbMhkBgzT7Ykc5YXUT46F0iKu8SGXq0bcwP5dz/h0Plj6enJqjz1Zbq2l5WaqYnrVbwWOWMyF3F47g=="",
          ""dev"": true
        }},
        ""supports-color"": {{
          ""version"": ""5.1.0"",
          ""resolved"": ""https://registry.npmjs.org/supports-color/-/supports-color-5.1.0.tgz"",
          ""integrity"": ""sha512-Ry0AwkoKjDpVKK4sV4h6o3UJmNRbjYm2uXhwfj3J56lMVdvnUNqzQVRztOOMGQ++w1K/TjNDFvpJk0F/LoeBCQ=="",
          ""dev"": true,
          ""requires"": {{
            ""has-flag"": ""2.0.0""
          }}
        }}
      }}
    }},
    ""postcss-nested"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/postcss-nested/-/postcss-nested-1.0.1.tgz"",
      ""integrity"": ""sha1-kfKPTm4j1WckGsFUVYoM+rTMDY8="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""5.2.18""
      }}
    }},
    ""postcss-nesting"": {{
      ""version"": ""2.3.1"",
      ""resolved"": ""https://registry.npmjs.org/postcss-nesting/-/postcss-nesting-2.3.1.tgz"",
      ""integrity"": ""sha1-lKa2pO9wf77CCof+5clXdZtOAc8="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""5.2.18""
      }}
    }},
    ""postcss-normalize-charset"": {{
      ""version"": ""1.1.1"",
      ""resolved"": ""https://registry.npmjs.org/postcss-normalize-charset/-/postcss-normalize-charset-1.1.1.tgz"",
      ""integrity"": ""sha1-757nEhLX/nWceO0WL2HtYrXLk/E="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""5.2.18""
      }}
    }},
    ""postcss-normalize-url"": {{
      ""version"": ""3.0.8"",
      ""resolved"": ""https://registry.npmjs.org/postcss-normalize-url/-/postcss-normalize-url-3.0.8.tgz"",
      ""integrity"": ""sha1-EI90s/L82viRov+j6kWSJ5/HgiI="",
      ""dev"": true,
      ""requires"": {{
        ""is-absolute-url"": ""2.1.0"",
        ""normalize-url"": ""1.9.1"",
        ""postcss"": ""5.2.18"",
        ""postcss-value-parser"": ""3.3.0""
      }}
    }},
    ""postcss-ordered-values"": {{
      ""version"": ""2.2.3"",
      ""resolved"": ""https://registry.npmjs.org/postcss-ordered-values/-/postcss-ordered-values-2.2.3.tgz"",
      ""integrity"": ""sha1-7sbCpntsQSqNsgQud/6NpD+VwR0="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""5.2.18"",
        ""postcss-value-parser"": ""3.3.0""
      }}
    }},
    ""postcss-partial-import"": {{
      ""version"": ""1.3.0"",
      ""resolved"": ""https://registry.npmjs.org/postcss-partial-import/-/postcss-partial-import-1.3.0.tgz"",
      ""integrity"": ""sha1-L0t3OnbHsKabOJ3PR1xNNi0NJXY="",
      ""dev"": true,
      ""requires"": {{
        ""fs-extra"": ""0.24.0"",
        ""fs-promise"": ""0.3.1"",
        ""object-assign"": ""4.1.1"",
        ""postcss"": ""5.2.18"",
        ""string-hash"": ""1.1.3""
      }},
      ""dependencies"": {{
        ""fs-extra"": {{
          ""version"": ""0.24.0"",
          ""resolved"": ""https://registry.npmjs.org/fs-extra/-/fs-extra-0.24.0.tgz"",
          ""integrity"": ""sha1-1OQ0KpZnXLeEZjOmCZJJMytTmVI="",
          ""dev"": true,
          ""requires"": {{
            ""graceful-fs"": ""4.1.11"",
            ""jsonfile"": ""2.4.0"",
            ""path-is-absolute"": ""1.0.1"",
            ""rimraf"": ""2.6.2""
          }}
        }}
      }}
    }},
    ""postcss-property-lookup"": {{
      ""version"": ""1.2.1"",
      ""resolved"": ""https://registry.npmjs.org/postcss-property-lookup/-/postcss-property-lookup-1.2.1.tgz"",
      ""integrity"": ""sha1-MEUKE2G3qudYu+3VIB++BXu4Jws="",
      ""dev"": true,
      ""requires"": {{
        ""object-assign"": ""4.1.1"",
        ""postcss"": ""5.2.18"",
        ""tcomb"": ""2.7.0""
      }}
    }},
    ""postcss-reduce-idents"": {{
      ""version"": ""2.4.0"",
      ""resolved"": ""https://registry.npmjs.org/postcss-reduce-idents/-/postcss-reduce-idents-2.4.0.tgz"",
      ""integrity"": ""sha1-wsbSDMlYKE9qv75j92Cb9AkFmtM="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""5.2.18"",
        ""postcss-value-parser"": ""3.3.0""
      }}
    }},
    ""postcss-reduce-initial"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/postcss-reduce-initial/-/postcss-reduce-initial-1.0.1.tgz"",
      ""integrity"": ""sha1-aPgGlfBF0IJjqHmtJA343WT2ROo="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""5.2.18""
      }}
    }},
    ""postcss-reduce-transforms"": {{
      ""version"": ""1.0.4"",
      ""resolved"": ""https://registry.npmjs.org/postcss-reduce-transforms/-/postcss-reduce-transforms-1.0.4.tgz"",
      ""integrity"": ""sha1-/3b02CEkN7McKYpC0uFEQCV3GuE="",
      ""dev"": true,
      ""requires"": {{
        ""has"": ""1.0.1"",
        ""postcss"": ""5.2.18"",
        ""postcss-value-parser"": ""3.3.0""
      }}
    }},
    ""postcss-selector-matches"": {{
      ""version"": ""2.0.5"",
      ""resolved"": ""https://registry.npmjs.org/postcss-selector-matches/-/postcss-selector-matches-2.0.5.tgz"",
      ""integrity"": ""sha1-+g9Dvle2jneqTNEYBwI0kqExAn8="",
      ""dev"": true,
      ""requires"": {{
        ""balanced-match"": ""0.4.2"",
        ""postcss"": ""5.2.18""
      }},
      ""dependencies"": {{
        ""balanced-match"": {{
          ""version"": ""0.4.2"",
          ""resolved"": ""https://registry.npmjs.org/balanced-match/-/balanced-match-0.4.2.tgz"",
          ""integrity"": ""sha1-yz8+PHMtwPAe5wtAPzAuYddwmDg="",
          ""dev"": true
        }}
      }}
    }},
    ""postcss-selector-not"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/postcss-selector-not/-/postcss-selector-not-2.0.0.tgz"",
      ""integrity"": ""sha1-xzrSGj91I0vuf+4mnhVP1qhpeY0="",
      ""dev"": true,
      ""requires"": {{
        ""balanced-match"": ""0.2.1"",
        ""postcss"": ""5.2.18""
      }},
      ""dependencies"": {{
        ""balanced-match"": {{
          ""version"": ""0.2.1"",
          ""resolved"": ""https://registry.npmjs.org/balanced-match/-/balanced-match-0.2.1.tgz"",
          ""integrity"": ""sha1-e8ZYtL7WHu5CStdPdfXD4sTfPMc="",
          ""dev"": true
        }}
      }}
    }},
    ""postcss-selector-parser"": {{
      ""version"": ""2.2.3"",
      ""resolved"": ""https://registry.npmjs.org/postcss-selector-parser/-/postcss-selector-parser-2.2.3.tgz"",
      ""integrity"": ""sha1-+UN3iGBsPJrO4W/+jYsWKX8nu5A="",
      ""dev"": true,
      ""requires"": {{
        ""flatten"": ""1.0.2"",
        ""indexes-of"": ""1.0.1"",
        ""uniq"": ""1.0.1""
      }}
    }},
    ""postcss-simple-vars"": {{
      ""version"": ""1.2.0"",
      ""resolved"": ""https://registry.npmjs.org/postcss-simple-vars/-/postcss-simple-vars-1.2.0.tgz"",
      ""integrity"": ""sha1-LmaJkhFEt0EU52U1MnWjwyFD8VA="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""5.2.18""
      }}
    }},
    ""postcss-svgo"": {{
      ""version"": ""2.1.6"",
      ""resolved"": ""https://registry.npmjs.org/postcss-svgo/-/postcss-svgo-2.1.6.tgz"",
      ""integrity"": ""sha1-tt8YqmE7Zm4TPwittSGcJoSsEI0="",
      ""dev"": true,
      ""requires"": {{
        ""is-svg"": ""2.1.0"",
        ""postcss"": ""5.2.18"",
        ""postcss-value-parser"": ""3.3.0"",
        ""svgo"": ""0.7.2""
      }}
    }},
    ""postcss-unique-selectors"": {{
      ""version"": ""2.0.2"",
      ""resolved"": ""https://registry.npmjs.org/postcss-unique-selectors/-/postcss-unique-selectors-2.0.2.tgz"",
      ""integrity"": ""sha1-mB1X0p3csz57Hf4f1DuGSfkzyh0="",
      ""dev"": true,
      ""requires"": {{
        ""alphanum-sort"": ""1.0.2"",
        ""postcss"": ""5.2.18"",
        ""uniqs"": ""2.0.0""
      }}
    }},
    ""postcss-value-parser"": {{
      ""version"": ""3.3.0"",
      ""resolved"": ""https://registry.npmjs.org/postcss-value-parser/-/postcss-value-parser-3.3.0.tgz"",
      ""integrity"": ""sha1-h/OPnxj3dKSrTIojL1xc6IcqnRU="",
      ""dev"": true
    }},
    ""postcss-zindex"": {{
      ""version"": ""2.2.0"",
      ""resolved"": ""https://registry.npmjs.org/postcss-zindex/-/postcss-zindex-2.2.0.tgz"",
      ""integrity"": ""sha1-0hCd3AVbka9n/EyzsCWUZjnSryI="",
      ""dev"": true,
      ""requires"": {{
        ""has"": ""1.0.1"",
        ""postcss"": ""5.2.18"",
        ""uniqs"": ""2.0.0""
      }}
    }},
    ""precss"": {{
      ""version"": ""1.4.0"",
      ""resolved"": ""https://registry.npmjs.org/precss/-/precss-1.4.0.tgz"",
      ""integrity"": ""sha1-jXw65w8QoAo5VSh/haZuD4sxzaM="",
      ""dev"": true,
      ""requires"": {{
        ""postcss"": ""5.2.18"",
        ""postcss-advanced-variables"": ""1.2.2"",
        ""postcss-atroot"": ""0.1.3"",
        ""postcss-color-function"": ""2.0.1"",
        ""postcss-custom-media"": ""5.0.1"",
        ""postcss-custom-properties"": ""5.0.2"",
        ""postcss-custom-selectors"": ""3.0.0"",
        ""postcss-extend"": ""1.0.5"",
        ""postcss-media-minmax"": ""2.1.2"",
        ""postcss-mixins"": ""2.1.1"",
        ""postcss-nested"": ""1.0.1"",
        ""postcss-nesting"": ""2.3.1"",
        ""postcss-partial-import"": ""1.3.0"",
        ""postcss-property-lookup"": ""1.2.1"",
        ""postcss-selector-matches"": ""2.0.5"",
        ""postcss-selector-not"": ""2.0.0""
      }}
    }},
    ""prelude-ls"": {{
      ""version"": ""1.1.2"",
      ""resolved"": ""https://registry.npmjs.org/prelude-ls/-/prelude-ls-1.1.2.tgz"",
      ""integrity"": ""sha1-IZMqVJ9eUv/ZqCf1cOBL5iqX2lQ="",
      ""dev"": true
    }},
    ""prepend-http"": {{
      ""version"": ""1.0.4"",
      ""resolved"": ""https://registry.npmjs.org/prepend-http/-/prepend-http-1.0.4.tgz"",
      ""integrity"": ""sha1-1PRWKwzjaW5BrFLQ4ALlemNdxtw="",
      ""dev"": true
    }},
    ""preserve"": {{
      ""version"": ""0.2.0"",
      ""resolved"": ""https://registry.npmjs.org/preserve/-/preserve-0.2.0.tgz"",
      ""integrity"": ""sha1-gV7R9uvGWSb4ZbMQwHE7yzMVzks="",
      ""dev"": true
    }},
    ""pretty-error"": {{
      ""version"": ""2.1.1"",
      ""resolved"": ""https://registry.npmjs.org/pretty-error/-/pretty-error-2.1.1.tgz"",
      ""integrity"": ""sha1-X0+HyPkeWuPzuoerTPXgOxoX8aM="",
      ""dev"": true,
      ""requires"": {{
        ""renderkid"": ""2.0.1"",
        ""utila"": ""0.4.0""
      }}
    }},
    ""pretty-format"": {{
      ""version"": ""21.2.1"",
      ""resolved"": ""https://registry.npmjs.org/pretty-format/-/pretty-format-21.2.1.tgz"",
      ""integrity"": ""sha512-ZdWPGYAnYfcVP8yKA3zFjCn8s4/17TeYH28MXuC8vTp0o21eXjbFGcOAXZEaDaOFJjc3h2qa7HQNHNshhvoh2A=="",
      ""dev"": true,
      ""requires"": {{
        ""ansi-regex"": ""3.0.0"",
        ""ansi-styles"": ""3.2.0""
      }},
      ""dependencies"": {{
        ""ansi-regex"": {{
          ""version"": ""3.0.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-regex/-/ansi-regex-3.0.0.tgz"",
          ""integrity"": ""sha1-7QMXwyIGT3lGbAKWa922Bas32Zg="",
          ""dev"": true
        }},
        ""ansi-styles"": {{
          ""version"": ""3.2.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-styles/-/ansi-styles-3.2.0.tgz"",
          ""integrity"": ""sha512-NnSOmMEYtVR2JVMIGTzynRkkaxtiq1xnFBcdQD/DnNCYPoEPsVJhM98BDyaoNOQIi7p4okdi3E27eN7GQbsUug=="",
          ""dev"": true,
          ""requires"": {{
            ""color-convert"": ""1.9.1""
          }}
        }}
      }}
    }},
    ""private"": {{
      ""version"": ""0.1.8"",
      ""resolved"": ""https://registry.npmjs.org/private/-/private-0.1.8.tgz"",
      ""integrity"": ""sha512-VvivMrbvd2nKkiG38qjULzlc+4Vx4wm/whI9pQD35YrARNnhxeiRktSOhSukRLFNlzg6Br/cJPet5J/u19r/mg=="",
      ""dev"": true
    }},
    ""process"": {{
      ""version"": ""0.5.2"",
      ""resolved"": ""https://registry.npmjs.org/process/-/process-0.5.2.tgz"",
      ""integrity"": ""sha1-FjjYqONML0QKkduVq5rrZ3/Bhc8="",
      ""dev"": true
    }},
    ""process-nextick-args"": {{
      ""version"": ""1.0.7"",
      ""resolved"": ""https://registry.npmjs.org/process-nextick-args/-/process-nextick-args-1.0.7.tgz"",
      ""integrity"": ""sha1-FQ4gt1ZZCtP5EJPyWk8q2L/zC6M="",
      ""dev"": true
    }},
    ""progress"": {{
      ""version"": ""1.1.8"",
      ""resolved"": ""https://registry.npmjs.org/progress/-/progress-1.1.8.tgz"",
      ""integrity"": ""sha1-4mDHj2Fhzdmw5WzD4Khd4Xx6V74="",
      ""dev"": true
    }},
    ""promise"": {{
      ""version"": ""7.3.1"",
      ""resolved"": ""https://registry.npmjs.org/promise/-/promise-7.3.1.tgz"",
      ""integrity"": ""sha512-nolQXZ/4L+bP/UGlkfaIujX9BKxGwmQ9OT4mOt5yvy8iK1h3wqTEJCijzGANTCCl9nWjY41juyAn2K3Q1hLLTg=="",
      ""requires"": {{
        ""asap"": ""2.0.6""
      }}
    }},
    ""prop-types"": {{
      ""version"": ""15.6.0"",
      ""resolved"": ""https://registry.npmjs.org/prop-types/-/prop-types-15.6.0.tgz"",
      ""integrity"": ""sha1-zq8IMCL8RrSjX2nhPvda7Q1jmFY="",
      ""requires"": {{
        ""fbjs"": ""0.8.16"",
        ""loose-envify"": ""1.3.1"",
        ""object-assign"": ""4.1.1""
      }}
    }},
    ""proxy-addr"": {{
      ""version"": ""2.0.2"",
      ""resolved"": ""https://registry.npmjs.org/proxy-addr/-/proxy-addr-2.0.2.tgz"",
      ""integrity"": ""sha1-ZXFQT0e7mI7IGAJT+F3X4UlSvew="",
      ""dev"": true,
      ""requires"": {{
        ""forwarded"": ""0.1.2"",
        ""ipaddr.js"": ""1.5.2""
      }}
    }},
    ""prr"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/prr/-/prr-1.0.1.tgz"",
      ""integrity"": ""sha1-0/wRS6BplaRexok/SEzrHXj19HY="",
      ""dev"": true
    }},
    ""pseudomap"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/pseudomap/-/pseudomap-1.0.2.tgz"",
      ""integrity"": ""sha1-8FKijacOYYkX7wqKw0wa5aaChrM="",
      ""dev"": true
    }},
    ""public-encrypt"": {{
      ""version"": ""4.0.0"",
      ""resolved"": ""https://registry.npmjs.org/public-encrypt/-/public-encrypt-4.0.0.tgz"",
      ""integrity"": ""sha1-OfaZ86RlYN1eusvKaTyvfGXBjMY="",
      ""dev"": true,
      ""requires"": {{
        ""bn.js"": ""4.11.8"",
        ""browserify-rsa"": ""4.0.1"",
        ""create-hash"": ""1.1.3"",
        ""parse-asn1"": ""5.1.0"",
        ""randombytes"": ""2.0.5""
      }}
    }},
    ""punycode"": {{
      ""version"": ""1.4.1"",
      ""resolved"": ""https://registry.npmjs.org/punycode/-/punycode-1.4.1.tgz"",
      ""integrity"": ""sha1-wNWmOycYgArY4esPpSachN1BhF4="",
      ""dev"": true
    }},
    ""q"": {{
      ""version"": ""1.5.1"",
      ""resolved"": ""https://registry.npmjs.org/q/-/q-1.5.1.tgz"",
      ""integrity"": ""sha1-fjL3W0E4EpHQRhHxvxQQmsAGUdc="",
      ""dev"": true
    }},
    ""qs"": {{
      ""version"": ""6.5.1"",
      ""resolved"": ""https://registry.npmjs.org/qs/-/qs-6.5.1.tgz"",
      ""integrity"": ""sha512-eRzhrN1WSINYCDCbrz796z37LOe3m5tmW7RQf6oBntukAG1nmovJvhnwHHRMAfeoItc1m2Hk02WER2aQ/iqs+A=="",
      ""dev"": true
    }},
    ""query-string"": {{
      ""version"": ""4.3.4"",
      ""resolved"": ""https://registry.npmjs.org/query-string/-/query-string-4.3.4.tgz"",
      ""integrity"": ""sha1-u7aTucqRXCMlFbIosaArYJBD2+s="",
      ""dev"": true,
      ""requires"": {{
        ""object-assign"": ""4.1.1"",
        ""strict-uri-encode"": ""1.1.0""
      }}
    }},
    ""querystring"": {{
      ""version"": ""0.2.0"",
      ""resolved"": ""https://registry.npmjs.org/querystring/-/querystring-0.2.0.tgz"",
      ""integrity"": ""sha1-sgmEkgO7Jd+CDadW50cAWHhSFiA="",
      ""dev"": true
    }},
    ""querystring-es3"": {{
      ""version"": ""0.2.1"",
      ""resolved"": ""https://registry.npmjs.org/querystring-es3/-/querystring-es3-0.2.1.tgz"",
      ""integrity"": ""sha1-nsYfeQSYdXB9aUFFlv2Qek1xHnM="",
      ""dev"": true
    }},
    ""querystringify"": {{
      ""version"": ""0.0.4"",
      ""resolved"": ""https://registry.npmjs.org/querystringify/-/querystringify-0.0.4.tgz"",
      ""integrity"": ""sha1-DPf4T5Rj/wrlHExLFC2VvjdyTZw="",
      ""dev"": true
    }},
    ""randomatic"": {{
      ""version"": ""1.1.7"",
      ""resolved"": ""https://registry.npmjs.org/randomatic/-/randomatic-1.1.7.tgz"",
      ""integrity"": ""sha512-D5JUjPyJbaJDkuAazpVnSfVkLlpeO3wDlPROTMLGKG1zMFNFRgrciKo1ltz/AzNTkqE0HzDx655QOL51N06how=="",
      ""dev"": true,
      ""requires"": {{
        ""is-number"": ""3.0.0"",
        ""kind-of"": ""4.0.0""
      }},
      ""dependencies"": {{
        ""is-number"": {{
          ""version"": ""3.0.0"",
          ""resolved"": ""https://registry.npmjs.org/is-number/-/is-number-3.0.0.tgz"",
          ""integrity"": ""sha1-JP1iAaR4LPUFYcgQJ2r8fRLXEZU="",
          ""dev"": true,
          ""requires"": {{
            ""kind-of"": ""3.2.2""
          }},
          ""dependencies"": {{
            ""kind-of"": {{
              ""version"": ""3.2.2"",
              ""resolved"": ""https://registry.npmjs.org/kind-of/-/kind-of-3.2.2.tgz"",
              ""integrity"": ""sha1-MeohpzS6ubuw8yRm2JOupR5KPGQ="",
              ""dev"": true,
              ""requires"": {{
                ""is-buffer"": ""1.1.6""
              }}
            }}
          }}
        }},
        ""kind-of"": {{
          ""version"": ""4.0.0"",
          ""resolved"": ""https://registry.npmjs.org/kind-of/-/kind-of-4.0.0.tgz"",
          ""integrity"": ""sha1-IIE989cSkosgc3hpGkUGb65y3Vc="",
          ""dev"": true,
          ""requires"": {{
            ""is-buffer"": ""1.1.6""
          }}
        }}
      }}
    }},
    ""randombytes"": {{
      ""version"": ""2.0.5"",
      ""resolved"": ""https://registry.npmjs.org/randombytes/-/randombytes-2.0.5.tgz"",
      ""integrity"": ""sha512-8T7Zn1AhMsQ/HI1SjcCfT/t4ii3eAqco3yOcSzS4mozsOz69lHLsoMXmF9nZgnFanYscnSlUSgs8uZyKzpE6kg=="",
      ""dev"": true,
      ""requires"": {{
        ""safe-buffer"": ""5.1.1""
      }}
    }},
    ""randomfill"": {{
      ""version"": ""1.0.3"",
      ""resolved"": ""https://registry.npmjs.org/randomfill/-/randomfill-1.0.3.tgz"",
      ""integrity"": ""sha512-YL6GrhrWoic0Eq8rXVbMptH7dAxCs0J+mh5Y0euNekPPYaxEmdVGim6GdoxoRzKW2yJoU8tueifS7mYxvcFDEQ=="",
      ""dev"": true,
      ""requires"": {{
        ""randombytes"": ""2.0.5"",
        ""safe-buffer"": ""5.1.1""
      }}
    }},
    ""range-parser"": {{
      ""version"": ""1.2.0"",
      ""resolved"": ""https://registry.npmjs.org/range-parser/-/range-parser-1.2.0.tgz"",
      ""integrity"": ""sha1-9JvmtIeJTdxA3MlKMi9hEJLgDV4="",
      ""dev"": true
    }},
    ""raw-body"": {{
      ""version"": ""2.3.2"",
      ""resolved"": ""https://registry.npmjs.org/raw-body/-/raw-body-2.3.2.tgz"",
      ""integrity"": ""sha1-vNYMd9Prk83gBQKVw/N5OJvIj4k="",
      ""dev"": true,
      ""requires"": {{
        ""bytes"": ""3.0.0"",
        ""http-errors"": ""1.6.2"",
        ""iconv-lite"": ""0.4.19"",
        ""unpipe"": ""1.0.0""
      }}
    }},
    ""react"": {{
      ""version"": ""16.2.0"",
      ""resolved"": ""https://registry.npmjs.org/react/-/react-16.2.0.tgz"",
      ""integrity"": ""sha512-ZmIomM7EE1DvPEnSFAHZn9Vs9zJl5A9H7el0EGTE6ZbW9FKe/14IYAlPbC8iH25YarEQxZL+E8VW7Mi7kfQrDQ=="",
      ""requires"": {{
        ""fbjs"": ""0.8.16"",
        ""loose-envify"": ""1.3.1"",
        ""object-assign"": ""4.1.1"",
        ""prop-types"": ""15.6.0""
      }}
    }},
    ""react-addons-test-utils"": {{
      ""version"": ""15.6.2"",
      ""resolved"": ""https://registry.npmjs.org/react-addons-test-utils/-/react-addons-test-utils-15.6.2.tgz"",
      ""integrity"": ""sha1-wStu/cIkfBDae4dw0YUICnsEcVY="",
      ""dev"": true
    }},
    ""react-deep-force-update"": {{
      ""version"": ""1.1.1"",
      ""resolved"": ""https://registry.npmjs.org/react-deep-force-update/-/react-deep-force-update-1.1.1.tgz"",
      ""integrity"": ""sha1-vNMUeAJ7ZLMznxCJIatSC0MT3Cw="",
      ""dev"": true
    }},
    ""react-dom"": {{
      ""version"": ""16.2.0"",
      ""resolved"": ""https://registry.npmjs.org/react-dom/-/react-dom-16.2.0.tgz"",
      ""integrity"": ""sha512-zpGAdwHVn9K0091d+hr+R0qrjoJ84cIBFL2uU60KvWBPfZ7LPSrfqviTxGHWN0sjPZb2hxWzMexwrvJdKePvjg=="",
      ""requires"": {{
        ""fbjs"": ""0.8.16"",
        ""loose-envify"": ""1.3.1"",
        ""object-assign"": ""4.1.1"",
        ""prop-types"": ""15.6.0""
      }}
    }},
    ""react-event-listener"": {{
      ""version"": ""0.5.3"",
      ""resolved"": ""https://registry.npmjs.org/react-event-listener/-/react-event-listener-0.5.3.tgz"",
      ""integrity"": ""sha512-fTGYvhe7eTsqq0m664Km0rxKQcqLIGZWZINmy1LU0fu312tay8Mt3Twq2P5Xj1dfDVvvzT1Ql3/FDkiMPJ1MOg=="",
      ""requires"": {{
        ""babel-runtime"": ""6.26.0"",
        ""fbjs"": ""0.8.16"",
        ""prop-types"": ""15.6.0"",
        ""warning"": ""3.0.0""
      }}
    }},
    ""react-hot-api"": {{
      ""version"": ""0.4.7"",
      ""resolved"": ""https://registry.npmjs.org/react-hot-api/-/react-hot-api-0.4.7.tgz"",
      ""integrity"": ""sha1-p+IqVtJS4Rq9k2a2EmTPRJLFgXE="",
      ""dev"": true
    }},
    ""react-hot-loader"": {{
      ""version"": ""1.3.1"",
      ""resolved"": ""https://registry.npmjs.org/react-hot-loader/-/react-hot-loader-1.3.1.tgz"",
      ""integrity"": ""sha1-yVZHrni3Pfzv9uxx/8sEGC/22vk="",
      ""dev"": true,
      ""requires"": {{
        ""react-hot-api"": ""0.4.7"",
        ""source-map"": ""0.4.4""
      }},
      ""dependencies"": {{
        ""source-map"": {{
          ""version"": ""0.4.4"",
          ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.4.4.tgz"",
          ""integrity"": ""sha1-66T12pwNyZneaAMti092FzZSA2s="",
          ""dev"": true,
          ""requires"": {{
            ""amdefine"": ""1.0.1""
          }}
        }}
      }}
    }},
    ""react-proxy"": {{
      ""version"": ""1.1.8"",
      ""resolved"": ""https://registry.npmjs.org/react-proxy/-/react-proxy-1.1.8.tgz"",
      ""integrity"": ""sha1-nb/Z2SdSjDqp9ETkVYw3gwq4wmo="",
      ""dev"": true,
      ""requires"": {{
        ""lodash"": ""4.17.4"",
        ""react-deep-force-update"": ""1.1.1""
      }}
    }},
    ""react-redux"": {{
      ""version"": ""5.0.6"",
      ""resolved"": ""https://registry.npmjs.org/react-redux/-/react-redux-5.0.6.tgz"",
      ""integrity"": ""sha512-8taaaGu+J7PMJQDJrk/xiWEYQmdo3mkXw6wPr3K3LxvXis3Fymiq7c13S+Tpls/AyNUAsoONkU81AP0RA6y6Vw=="",
      ""requires"": {{
        ""hoist-non-react-statics"": ""2.3.1"",
        ""invariant"": ""2.2.2"",
        ""lodash"": ""4.17.4"",
        ""lodash-es"": ""4.17.4"",
        ""loose-envify"": ""1.3.1"",
        ""prop-types"": ""15.6.0""
      }}
    }},
    ""react-router"": {{
      ""version"": ""4.2.0"",
      ""resolved"": ""https://registry.npmjs.org/react-router/-/react-router-4.2.0.tgz"",
      ""integrity"": ""sha512-DY6pjwRhdARE4TDw7XjxjZsbx9lKmIcyZoZ+SDO7SBJ1KUeWNxT22Kara2AC7u6/c2SYEHlEDLnzBCcNhLE8Vg=="",
      ""requires"": {{
        ""history"": ""4.7.2"",
        ""hoist-non-react-statics"": ""2.3.1"",
        ""invariant"": ""2.2.2"",
        ""loose-envify"": ""1.3.1"",
        ""path-to-regexp"": ""1.7.0"",
        ""prop-types"": ""15.6.0"",
        ""warning"": ""3.0.0""
      }}
    }},
    ""react-router-dom"": {{
      ""version"": ""4.2.2"",
      ""resolved"": ""https://registry.npmjs.org/react-router-dom/-/react-router-dom-4.2.2.tgz"",
      ""integrity"": ""sha512-cHMFC1ZoLDfEaMFoKTjN7fry/oczMgRt5BKfMAkTu5zEuJvUiPp1J8d0eXSVTnBh6pxlbdqDhozunOOLtmKfPA=="",
      ""requires"": {{
        ""history"": ""4.7.2"",
        ""invariant"": ""2.2.2"",
        ""loose-envify"": ""1.3.1"",
        ""prop-types"": ""15.6.0"",
        ""react-router"": ""4.2.0"",
        ""warning"": ""3.0.0""
      }}
    }},
    ""react-tap-event-plugin"": {{
      ""version"": ""3.0.2"",
      ""resolved"": ""https://registry.npmjs.org/react-tap-event-plugin/-/react-tap-event-plugin-3.0.2.tgz"",
      ""integrity"": ""sha1-KANxZ3uIHDE3bgAnoLhtLG3gOe4="",
      ""requires"": {{
        ""fbjs"": ""0.8.16""
      }}
    }},
    ""react-transform-catch-errors"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/react-transform-catch-errors/-/react-transform-catch-errors-1.0.2.tgz"",
      ""integrity"": ""sha1-G01KdulycYlvwW/jCGx5PsiKnus="",
      ""dev"": true
    }},
    ""react-transform-hmr"": {{
      ""version"": ""1.0.4"",
      ""resolved"": ""https://registry.npmjs.org/react-transform-hmr/-/react-transform-hmr-1.0.4.tgz"",
      ""integrity"": ""sha1-4aQL0Krvxy6N/Xp82gmvhQZjl7s="",
      ""dev"": true,
      ""requires"": {{
        ""global"": ""4.3.2"",
        ""react-proxy"": ""1.1.8""
      }}
    }},
    ""react-transition-group"": {{
      ""version"": ""1.2.1"",
      ""resolved"": ""https://registry.npmjs.org/react-transition-group/-/react-transition-group-1.2.1.tgz"",
      ""integrity"": ""sha512-CWaL3laCmgAFdxdKbhhps+c0HRGF4c+hdM4H23+FI1QBNUyx/AMeIJGWorehPNSaKnQNOAxL7PQmqMu78CDj3Q=="",
      ""requires"": {{
        ""chain-function"": ""1.0.0"",
        ""dom-helpers"": ""3.3.1"",
        ""loose-envify"": ""1.3.1"",
        ""prop-types"": ""15.6.0"",
        ""warning"": ""3.0.0""
      }}
    }},
    ""read-pkg"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/read-pkg/-/read-pkg-1.1.0.tgz"",
      ""integrity"": ""sha1-9f+qXs0pyzHAR0vKfXVra7KePyg="",
      ""dev"": true,
      ""requires"": {{
        ""load-json-file"": ""1.1.0"",
        ""normalize-package-data"": ""2.4.0"",
        ""path-type"": ""1.1.0""
      }}
    }},
    ""read-pkg-up"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/read-pkg-up/-/read-pkg-up-1.0.1.tgz"",
      ""integrity"": ""sha1-nWPBMnbAZZGNV/ACpX9AobZD+wI="",
      ""dev"": true,
      ""requires"": {{
        ""find-up"": ""1.1.2"",
        ""read-pkg"": ""1.1.0""
      }}
    }},
    ""readable-stream"": {{
      ""version"": ""1.0.34"",
      ""resolved"": ""https://registry.npmjs.org/readable-stream/-/readable-stream-1.0.34.tgz"",
      ""integrity"": ""sha1-Elgg40vIQtLyqq+v5MKRbuMsFXw="",
      ""dev"": true,
      ""requires"": {{
        ""core-util-is"": ""1.0.2"",
        ""inherits"": ""2.0.3"",
        ""isarray"": ""0.0.1"",
        ""string_decoder"": ""0.10.31""
      }}
    }},
    ""readdirp"": {{
      ""version"": ""2.1.0"",
      ""resolved"": ""https://registry.npmjs.org/readdirp/-/readdirp-2.1.0.tgz"",
      ""integrity"": ""sha1-TtCtBg3zBzMAxIRANz9y0cxkLXg="",
      ""dev"": true,
      ""requires"": {{
        ""graceful-fs"": ""4.1.11"",
        ""minimatch"": ""3.0.4"",
        ""readable-stream"": ""2.3.3"",
        ""set-immediate-shim"": ""1.0.1""
      }},
      ""dependencies"": {{
        ""isarray"": {{
          ""version"": ""1.0.0"",
          ""resolved"": ""https://registry.npmjs.org/isarray/-/isarray-1.0.0.tgz"",
          ""integrity"": ""sha1-u5NdSFgsuhaMBoNJV6VKPgcSTxE="",
          ""dev"": true
        }},
        ""readable-stream"": {{
          ""version"": ""2.3.3"",
          ""resolved"": ""https://registry.npmjs.org/readable-stream/-/readable-stream-2.3.3.tgz"",
          ""integrity"": ""sha512-m+qzzcn7KUxEmd1gMbchF+Y2eIUbieUaxkWtptyHywrX0rE8QEYqPC07Vuy4Wm32/xE16NcdBctb8S0Xe/5IeQ=="",
          ""dev"": true,
          ""requires"": {{
            ""core-util-is"": ""1.0.2"",
            ""inherits"": ""2.0.3"",
            ""isarray"": ""1.0.0"",
            ""process-nextick-args"": ""1.0.7"",
            ""safe-buffer"": ""5.1.1"",
            ""string_decoder"": ""1.0.3"",
            ""util-deprecate"": ""1.0.2""
          }}
        }},
        ""string_decoder"": {{
          ""version"": ""1.0.3"",
          ""resolved"": ""https://registry.npmjs.org/string_decoder/-/string_decoder-1.0.3.tgz"",
          ""integrity"": ""sha512-4AH6Z5fzNNBcH+6XDMfA/BTt87skxqJlO0lAh3Dker5zThcAxG6mKz+iGu308UKoPPQ8Dcqx/4JhujzltRa+hQ=="",
          ""dev"": true,
          ""requires"": {{
            ""safe-buffer"": ""5.1.1""
          }}
        }}
      }}
    }},
    ""readline2"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/readline2/-/readline2-1.0.1.tgz"",
      ""integrity"": ""sha1-QQWWCP/BVHV7cV2ZidGZ/783LjU="",
      ""dev"": true,
      ""requires"": {{
        ""code-point-at"": ""1.1.0"",
        ""is-fullwidth-code-point"": ""1.0.0"",
        ""mute-stream"": ""0.0.5""
      }}
    }},
    ""recompose"": {{
      ""version"": ""0.26.0"",
      ""resolved"": ""https://registry.npmjs.org/recompose/-/recompose-0.26.0.tgz"",
      ""integrity"": ""sha512-KwOu6ztO0mN5vy3+zDcc45lgnaUoaQse/a5yLVqtzTK13czSWnFGmXbQVmnoMgDkI5POd1EwIKSbjU1V7xdZog=="",
      ""requires"": {{
        ""change-emitter"": ""0.1.6"",
        ""fbjs"": ""0.8.16"",
        ""hoist-non-react-statics"": ""2.3.1"",
        ""symbol-observable"": ""1.1.0""
      }}
    }},
    ""redbox-react"": {{
      ""version"": ""1.5.0"",
      ""resolved"": ""https://registry.npmjs.org/redbox-react/-/redbox-react-1.5.0.tgz"",
      ""integrity"": ""sha512-mdxArOI3sF8K5Nay5NG+lv/VW516TbXjjd4h1wcV1Iy4IMDQPnCayjoQXBAycAFSME4nyXRUXCjHxsw2rYpVRw=="",
      ""dev"": true,
      ""requires"": {{
        ""error-stack-parser"": ""1.3.6"",
        ""object-assign"": ""4.1.1"",
        ""prop-types"": ""15.6.0"",
        ""sourcemapped-stacktrace"": ""1.1.8""
      }}
    }},
    ""redent"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/redent/-/redent-1.0.0.tgz"",
      ""integrity"": ""sha1-z5Fqsf1fHxbfsggi3W7H9zDCr94="",
      ""dev"": true,
      ""requires"": {{
        ""indent-string"": ""2.1.0"",
        ""strip-indent"": ""1.0.1""
      }}
    }},
    ""reduce-css-calc"": {{
      ""version"": ""1.3.0"",
      ""resolved"": ""https://registry.npmjs.org/reduce-css-calc/-/reduce-css-calc-1.3.0.tgz"",
      ""integrity"": ""sha1-dHyRTgSWFKTJz7umKYca0dKSdxY="",
      ""dev"": true,
      ""requires"": {{
        ""balanced-match"": ""0.4.2"",
        ""math-expression-evaluator"": ""1.2.17"",
        ""reduce-function-call"": ""1.0.2""
      }},
      ""dependencies"": {{
        ""balanced-match"": {{
          ""version"": ""0.4.2"",
          ""resolved"": ""https://registry.npmjs.org/balanced-match/-/balanced-match-0.4.2.tgz"",
          ""integrity"": ""sha1-yz8+PHMtwPAe5wtAPzAuYddwmDg="",
          ""dev"": true
        }}
      }}
    }},
    ""reduce-function-call"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/reduce-function-call/-/reduce-function-call-1.0.2.tgz"",
      ""integrity"": ""sha1-WiAL+S4ON3UXUv5FsKszD9S2vpk="",
      ""dev"": true,
      ""requires"": {{
        ""balanced-match"": ""0.4.2""
      }},
      ""dependencies"": {{
        ""balanced-match"": {{
          ""version"": ""0.4.2"",
          ""resolved"": ""https://registry.npmjs.org/balanced-match/-/balanced-match-0.4.2.tgz"",
          ""integrity"": ""sha1-yz8+PHMtwPAe5wtAPzAuYddwmDg="",
          ""dev"": true
        }}
      }}
    }},
    ""redux"": {{
      ""version"": ""3.7.2"",
      ""resolved"": ""https://registry.npmjs.org/redux/-/redux-3.7.2.tgz"",
      ""integrity"": ""sha512-pNqnf9q1hI5HHZRBkj3bAngGZW/JMCmexDlOxw4XagXY2o1327nHH54LoTjiPJ0gizoqPDRqWyX/00g0hD6w+A=="",
      ""requires"": {{
        ""lodash"": ""4.17.4"",
        ""lodash-es"": ""4.17.4"",
        ""loose-envify"": ""1.3.1"",
        ""symbol-observable"": ""1.1.0""
      }}
    }},
    ""redux-logger"": {{
      ""version"": ""2.4.0"",
      ""resolved"": ""https://registry.npmjs.org/redux-logger/-/redux-logger-2.4.0.tgz"",
      ""integrity"": ""sha1-JYb8/IXNA3ahSU8jV22df31Ps70="",
      ""dev"": true
    }},
    ""redux-thunk"": {{
      ""version"": ""2.2.0"",
      ""resolved"": ""https://registry.npmjs.org/redux-thunk/-/redux-thunk-2.2.0.tgz"",
      ""integrity"": ""sha1-5hWhbha0ehmlFXZhM9Hj6Zt4UuU=""
    }},
    ""regenerate"": {{
      ""version"": ""1.3.3"",
      ""resolved"": ""https://registry.npmjs.org/regenerate/-/regenerate-1.3.3.tgz"",
      ""integrity"": ""sha512-jVpo1GadrDAK59t/0jRx5VxYWQEDkkEKi6+HjE3joFVLfDOh9Xrdh0dF1eSq+BI/SwvTQ44gSscJ8N5zYL61sg=="",
      ""dev"": true
    }},
    ""regenerator-runtime"": {{
      ""version"": ""0.11.1"",
      ""resolved"": ""https://registry.npmjs.org/regenerator-runtime/-/regenerator-runtime-0.11.1.tgz"",
      ""integrity"": ""sha512-MguG95oij0fC3QV3URf4V2SDYGJhJnJGqvIIgdECeODCT98wSWDAJ94SSuVpYQUoTcGUIL6L4yNB7j1DFFHSBg==""
    }},
    ""regenerator-transform"": {{
      ""version"": ""0.10.1"",
      ""resolved"": ""https://registry.npmjs.org/regenerator-transform/-/regenerator-transform-0.10.1.tgz"",
      ""integrity"": ""sha512-PJepbvDbuK1xgIgnau7Y90cwaAmO/LCLMI2mPvaXq2heGMR3aWW5/BQvYrhJ8jgmQjXewXvBjzfqKcVOmhjZ6Q=="",
      ""dev"": true,
      ""requires"": {{
        ""babel-runtime"": ""6.26.0"",
        ""babel-types"": ""6.26.0"",
        ""private"": ""0.1.8""
      }}
    }},
    ""regex-cache"": {{
      ""version"": ""0.4.4"",
      ""resolved"": ""https://registry.npmjs.org/regex-cache/-/regex-cache-0.4.4.tgz"",
      ""integrity"": ""sha512-nVIZwtCjkC9YgvWkpM55B5rBhBYRZhAaJbgcFYXXsHnbZ9UZI9nnVWYZpBlCqv9ho2eZryPnWrZGsOdPwVWXWQ=="",
      ""dev"": true,
      ""requires"": {{
        ""is-equal-shallow"": ""0.1.3""
      }}
    }},
    ""regexpu-core"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/regexpu-core/-/regexpu-core-2.0.0.tgz"",
      ""integrity"": ""sha1-SdA4g3uNz4v6W5pCE5k45uoq4kA="",
      ""dev"": true,
      ""requires"": {{
        ""regenerate"": ""1.3.3"",
        ""regjsgen"": ""0.2.0"",
        ""regjsparser"": ""0.1.5""
      }}
    }},
    ""regjsgen"": {{
      ""version"": ""0.2.0"",
      ""resolved"": ""https://registry.npmjs.org/regjsgen/-/regjsgen-0.2.0.tgz"",
      ""integrity"": ""sha1-bAFq3qxVT3WCP+N6wFuS1aTtsfc="",
      ""dev"": true
    }},
    ""regjsparser"": {{
      ""version"": ""0.1.5"",
      ""resolved"": ""https://registry.npmjs.org/regjsparser/-/regjsparser-0.1.5.tgz"",
      ""integrity"": ""sha1-fuj4Tcb6eS0/0K4ijSS9lJ6tIFw="",
      ""dev"": true,
      ""requires"": {{
        ""jsesc"": ""0.5.0""
      }},
      ""dependencies"": {{
        ""jsesc"": {{
          ""version"": ""0.5.0"",
          ""resolved"": ""https://registry.npmjs.org/jsesc/-/jsesc-0.5.0.tgz"",
          ""integrity"": ""sha1-597mbjXW/Bb3EP6R1c9p9w8IkR0="",
          ""dev"": true
        }}
      }}
    }},
    ""relateurl"": {{
      ""version"": ""0.2.7"",
      ""resolved"": ""https://registry.npmjs.org/relateurl/-/relateurl-0.2.7.tgz"",
      ""integrity"": ""sha1-VNvzd+UUQKypCkzSdGANP/LYiKk="",
      ""dev"": true
    }},
    ""remove-trailing-separator"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/remove-trailing-separator/-/remove-trailing-separator-1.1.0.tgz"",
      ""integrity"": ""sha1-wkvOKig62tW8P1jg1IJJuSN52O8="",
      ""dev"": true
    }},
    ""renderkid"": {{
      ""version"": ""2.0.1"",
      ""resolved"": ""https://registry.npmjs.org/renderkid/-/renderkid-2.0.1.tgz"",
      ""integrity"": ""sha1-iYyr/Ivt5Le5ETWj/9Mj5YwNsxk="",
      ""dev"": true,
      ""requires"": {{
        ""css-select"": ""1.2.0"",
        ""dom-converter"": ""0.1.4"",
        ""htmlparser2"": ""3.3.0"",
        ""strip-ansi"": ""3.0.1"",
        ""utila"": ""0.3.3""
      }},
      ""dependencies"": {{
        ""domhandler"": {{
          ""version"": ""2.1.0"",
          ""resolved"": ""https://registry.npmjs.org/domhandler/-/domhandler-2.1.0.tgz"",
          ""integrity"": ""sha1-0mRvXlf2w7qxHPbLBdPArPdBJZQ="",
          ""dev"": true,
          ""requires"": {{
            ""domelementtype"": ""1.3.0""
          }}
        }},
        ""domutils"": {{
          ""version"": ""1.1.6"",
          ""resolved"": ""https://registry.npmjs.org/domutils/-/domutils-1.1.6.tgz"",
          ""integrity"": ""sha1-vdw94Jm5ou+sxRxiPyj0FuzFdIU="",
          ""dev"": true,
          ""requires"": {{
            ""domelementtype"": ""1.3.0""
          }}
        }},
        ""htmlparser2"": {{
          ""version"": ""3.3.0"",
          ""resolved"": ""https://registry.npmjs.org/htmlparser2/-/htmlparser2-3.3.0.tgz"",
          ""integrity"": ""sha1-zHDQWln2VC5D8OaFyYLhTJJKnv4="",
          ""dev"": true,
          ""requires"": {{
            ""domelementtype"": ""1.3.0"",
            ""domhandler"": ""2.1.0"",
            ""domutils"": ""1.1.6"",
            ""readable-stream"": ""1.0.34""
          }}
        }},
        ""utila"": {{
          ""version"": ""0.3.3"",
          ""resolved"": ""https://registry.npmjs.org/utila/-/utila-0.3.3.tgz"",
          ""integrity"": ""sha1-1+jn1+MJEHCSsF+NloiCTWM6QiY="",
          ""dev"": true
        }}
      }}
    }},
    ""repeat-element"": {{
      ""version"": ""1.1.2"",
      ""resolved"": ""https://registry.npmjs.org/repeat-element/-/repeat-element-1.1.2.tgz"",
      ""integrity"": ""sha1-7wiaF40Ug7quTZPrmLT55OEdmQo="",
      ""dev"": true
    }},
    ""repeat-string"": {{
      ""version"": ""1.6.1"",
      ""resolved"": ""https://registry.npmjs.org/repeat-string/-/repeat-string-1.6.1.tgz"",
      ""integrity"": ""sha1-jcrkcOHIirwtYA//Sndihtp15jc="",
      ""dev"": true
    }},
    ""repeating"": {{
      ""version"": ""2.0.1"",
      ""resolved"": ""https://registry.npmjs.org/repeating/-/repeating-2.0.1.tgz"",
      ""integrity"": ""sha1-UhTFOpJtNVJwdSf7q0FdvAjQbdo="",
      ""dev"": true,
      ""requires"": {{
        ""is-finite"": ""1.0.2""
      }}
    }},
    ""request"": {{
      ""version"": ""2.83.0"",
      ""resolved"": ""https://registry.npmjs.org/request/-/request-2.83.0.tgz"",
      ""integrity"": ""sha512-lR3gD69osqm6EYLk9wB/G1W/laGWjzH90t1vEa2xuxHD5KUrSzp9pUSfTm+YC5Nxt2T8nMPEvKlhbQayU7bgFw=="",
      ""dev"": true,
      ""requires"": {{
        ""aws-sign2"": ""0.7.0"",
        ""aws4"": ""1.6.0"",
        ""caseless"": ""0.12.0"",
        ""combined-stream"": ""1.0.5"",
        ""extend"": ""3.0.1"",
        ""forever-agent"": ""0.6.1"",
        ""form-data"": ""2.3.1"",
        ""har-validator"": ""5.0.3"",
        ""hawk"": ""6.0.2"",
        ""http-signature"": ""1.2.0"",
        ""is-typedarray"": ""1.0.0"",
        ""isstream"": ""0.1.2"",
        ""json-stringify-safe"": ""5.0.1"",
        ""mime-types"": ""2.1.17"",
        ""oauth-sign"": ""0.8.2"",
        ""performance-now"": ""2.1.0"",
        ""qs"": ""6.5.1"",
        ""safe-buffer"": ""5.1.1"",
        ""stringstream"": ""0.0.5"",
        ""tough-cookie"": ""2.3.3"",
        ""tunnel-agent"": ""0.6.0"",
        ""uuid"": ""3.1.0""
      }}
    }},
    ""require-directory"": {{
      ""version"": ""2.1.1"",
      ""resolved"": ""https://registry.npmjs.org/require-directory/-/require-directory-2.1.1.tgz"",
      ""integrity"": ""sha1-jGStX9MNqxyXbiNE/+f3kqam30I="",
      ""dev"": true
    }},
    ""require-from-string"": {{
      ""version"": ""1.2.1"",
      ""resolved"": ""https://registry.npmjs.org/require-from-string/-/require-from-string-1.2.1.tgz"",
      ""integrity"": ""sha1-UpyczvJzgK3+yaL5ZbZJu+5jZBg="",
      ""dev"": true
    }},
    ""require-main-filename"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/require-main-filename/-/require-main-filename-1.0.1.tgz"",
      ""integrity"": ""sha1-l/cXtp1IeE9fUmpsWqj/3aBVpNE="",
      ""dev"": true
    }},
    ""require-uncached"": {{
      ""version"": ""1.0.3"",
      ""resolved"": ""https://registry.npmjs.org/require-uncached/-/require-uncached-1.0.3.tgz"",
      ""integrity"": ""sha1-Tg1W1slmL9MeQwEcS5WqSZVUIdM="",
      ""dev"": true,
      ""requires"": {{
        ""caller-path"": ""0.1.0"",
        ""resolve-from"": ""1.0.1""
      }}
    }},
    ""requires-port"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/requires-port/-/requires-port-1.0.0.tgz"",
      ""integrity"": ""sha1-kl0mAdOaxIXgkc8NpcbmlNw9yv8="",
      ""dev"": true
    }},
    ""resolve"": {{
      ""version"": ""1.1.7"",
      ""resolved"": ""https://registry.npmjs.org/resolve/-/resolve-1.1.7.tgz"",
      ""integrity"": ""sha1-IDEU2CrSxe2ejgQRs5ModeiJ6Xs="",
      ""dev"": true
    }},
    ""resolve-from"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/resolve-from/-/resolve-from-1.0.1.tgz"",
      ""integrity"": ""sha1-Jsv+k10a7uq7Kbw/5a6wHpPUQiY="",
      ""dev"": true
    }},
    ""resolve-pathname"": {{
      ""version"": ""2.2.0"",
      ""resolved"": ""https://registry.npmjs.org/resolve-pathname/-/resolve-pathname-2.2.0.tgz"",
      ""integrity"": ""sha512-bAFz9ld18RzJfddgrO2e/0S2O81710++chRMUxHjXOYKF6jTAMrUNZrEZ1PvV0zlhfjidm08iRPdTLPno1FuRg==""
    }},
    ""resolve-url"": {{
      ""version"": ""0.2.1"",
      ""resolved"": ""https://registry.npmjs.org/resolve-url/-/resolve-url-0.2.1.tgz"",
      ""integrity"": ""sha1-LGN/53yJOv0qZj/iGqkIAGjiBSo="",
      ""dev"": true
    }},
    ""resolve-url-loader"": {{
      ""version"": ""1.6.1"",
      ""resolved"": ""https://registry.npmjs.org/resolve-url-loader/-/resolve-url-loader-1.6.1.tgz"",
      ""integrity"": ""sha1-Sm4Dx03TjV393w9AS0ddbpACVjU="",
      ""dev"": true,
      ""requires"": {{
        ""camelcase"": ""1.2.1"",
        ""convert-source-map"": ""1.5.1"",
        ""loader-utils"": ""0.2.17"",
        ""lodash.defaults"": ""3.1.2"",
        ""rework"": ""1.0.1"",
        ""rework-visit"": ""1.0.0"",
        ""source-map"": ""0.1.43"",
        ""urix"": ""0.1.0""
      }},
      ""dependencies"": {{
        ""camelcase"": {{
          ""version"": ""1.2.1"",
          ""resolved"": ""https://registry.npmjs.org/camelcase/-/camelcase-1.2.1.tgz"",
          ""integrity"": ""sha1-m7UwTS4LVmmLLHWLCKPqqdqlijk="",
          ""dev"": true
        }},
        ""lodash.assign"": {{
          ""version"": ""3.2.0"",
          ""resolved"": ""https://registry.npmjs.org/lodash.assign/-/lodash.assign-3.2.0.tgz"",
          ""integrity"": ""sha1-POnwI0tLIiPilrj6CsH+6OvKZPo="",
          ""dev"": true,
          ""requires"": {{
            ""lodash._baseassign"": ""3.2.0"",
            ""lodash._createassigner"": ""3.1.1"",
            ""lodash.keys"": ""3.1.2""
          }}
        }},
        ""lodash.defaults"": {{
          ""version"": ""3.1.2"",
          ""resolved"": ""https://registry.npmjs.org/lodash.defaults/-/lodash.defaults-3.1.2.tgz"",
          ""integrity"": ""sha1-xzCLGNv4vJNy1wGnNJPGEZK9Liw="",
          ""dev"": true,
          ""requires"": {{
            ""lodash.assign"": ""3.2.0"",
            ""lodash.restparam"": ""3.6.1""
          }}
        }},
        ""source-map"": {{
          ""version"": ""0.1.43"",
          ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.1.43.tgz"",
          ""integrity"": ""sha1-wkvBRspRfBRx9drL4lcbK3+eM0Y="",
          ""dev"": true,
          ""requires"": {{
            ""amdefine"": ""1.0.1""
          }}
        }}
      }}
    }},
    ""restore-cursor"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/restore-cursor/-/restore-cursor-1.0.1.tgz"",
      ""integrity"": ""sha1-NGYfRohjJ/7SmRR5FSJS35LapUE="",
      ""dev"": true,
      ""requires"": {{
        ""exit-hook"": ""1.1.1"",
        ""onetime"": ""1.1.0""
      }}
    }},
    ""rework"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/rework/-/rework-1.0.1.tgz"",
      ""integrity"": ""sha1-MIBqhBNCtUUQqkEQhQzUhTQUSqc="",
      ""dev"": true,
      ""requires"": {{
        ""convert-source-map"": ""0.3.5"",
        ""css"": ""2.2.1""
      }},
      ""dependencies"": {{
        ""convert-source-map"": {{
          ""version"": ""0.3.5"",
          ""resolved"": ""https://registry.npmjs.org/convert-source-map/-/convert-source-map-0.3.5.tgz"",
          ""integrity"": ""sha1-8dgClQr33SYxof6+BZZVDIarMZA="",
          ""dev"": true
        }}
      }}
    }},
    ""rework-visit"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/rework-visit/-/rework-visit-1.0.0.tgz"",
      ""integrity"": ""sha1-mUWygD8hni96ygCtuLyfZA+ELJo="",
      ""dev"": true
    }},
    ""rgb"": {{
      ""version"": ""0.1.0"",
      ""resolved"": ""https://registry.npmjs.org/rgb/-/rgb-0.1.0.tgz"",
      ""integrity"": ""sha1-vieykej+/+rBvZlylyG/pA/AN7U="",
      ""dev"": true
    }},
    ""right-align"": {{
      ""version"": ""0.1.3"",
      ""resolved"": ""https://registry.npmjs.org/right-align/-/right-align-0.1.3.tgz"",
      ""integrity"": ""sha1-YTObci/mo1FWiSENJOFMlhSGE+8="",
      ""dev"": true,
      ""requires"": {{
        ""align-text"": ""0.1.4""
      }}
    }},
    ""rimraf"": {{
      ""version"": ""2.6.2"",
      ""resolved"": ""https://registry.npmjs.org/rimraf/-/rimraf-2.6.2.tgz"",
      ""integrity"": ""sha512-lreewLK/BlghmxtfH36YYVg1i8IAce4TI7oao75I1g245+6BctqTVQiBP3YUJ9C6DQOXJmkYR9X9fCLtCOJc5w=="",
      ""dev"": true,
      ""requires"": {{
        ""glob"": ""7.1.2""
      }},
      ""dependencies"": {{
        ""glob"": {{
          ""version"": ""7.1.2"",
          ""resolved"": ""https://registry.npmjs.org/glob/-/glob-7.1.2.tgz"",
          ""integrity"": ""sha512-MJTUg1kjuLeQCJ+ccE4Vpa6kKVXkPYJ2mOCQyUuKLcLQsdrMCpBPUi8qVE6+YuaJkozeA9NusTAw3hLr8Xe5EQ=="",
          ""dev"": true,
          ""requires"": {{
            ""fs.realpath"": ""1.0.0"",
            ""inflight"": ""1.0.6"",
            ""inherits"": ""2.0.3"",
            ""minimatch"": ""3.0.4"",
            ""once"": ""1.4.0"",
            ""path-is-absolute"": ""1.0.1""
          }}
        }}
      }}
    }},
    ""ripemd160"": {{
      ""version"": ""2.0.1"",
      ""resolved"": ""https://registry.npmjs.org/ripemd160/-/ripemd160-2.0.1.tgz"",
      ""integrity"": ""sha1-D0WEKVxTo2KK9+bXmsohzlfRxuc="",
      ""dev"": true,
      ""requires"": {{
        ""hash-base"": ""2.0.2"",
        ""inherits"": ""2.0.3""
      }}
    }},
    ""run-async"": {{
      ""version"": ""0.1.0"",
      ""resolved"": ""https://registry.npmjs.org/run-async/-/run-async-0.1.0.tgz"",
      ""integrity"": ""sha1-yK1KXhEGYeQCp9IbUw4AnyX444k="",
      ""dev"": true,
      ""requires"": {{
        ""once"": ""1.4.0""
      }}
    }},
    ""rx-lite"": {{
      ""version"": ""3.1.2"",
      ""resolved"": ""https://registry.npmjs.org/rx-lite/-/rx-lite-3.1.2.tgz"",
      ""integrity"": ""sha1-Gc5QLKVyZl87ZHsQk5+X/RYV8QI="",
      ""dev"": true
    }},
    ""safe-buffer"": {{
      ""version"": ""5.1.1"",
      ""resolved"": ""https://registry.npmjs.org/safe-buffer/-/safe-buffer-5.1.1.tgz"",
      ""integrity"": ""sha512-kKvNJn6Mm93gAczWVJg7wH+wGYWNrDHdWvpUmHyEsgCtIwwo3bqPtV4tR5tuPaUhTOo/kvhVwd8XwwOllGYkbg=="",
      ""dev"": true
    }},
    ""sane"": {{
      ""version"": ""2.2.0"",
      ""resolved"": ""https://registry.npmjs.org/sane/-/sane-2.2.0.tgz"",
      ""integrity"": ""sha512-OSJxhHO0CgPUw3lUm3GhfREAfza45smvEI9ozuFrxKG10GHVo0ryW9FK5VYlLvxj0SV7HVKHW0voYJIRu27GWg=="",
      ""dev"": true,
      ""requires"": {{
        ""anymatch"": ""1.3.2"",
        ""exec-sh"": ""0.2.1"",
        ""fb-watchman"": ""2.0.0"",
        ""fsevents"": ""1.1.3"",
        ""minimatch"": ""3.0.4"",
        ""minimist"": ""1.2.0"",
        ""walker"": ""1.0.7"",
        ""watch"": ""0.18.0""
      }},
      ""dependencies"": {{
        ""minimist"": {{
          ""version"": ""1.2.0"",
          ""resolved"": ""https://registry.npmjs.org/minimist/-/minimist-1.2.0.tgz"",
          ""integrity"": ""sha1-o1AIsg9BOD7sH7kU9M1d95omQoQ="",
          ""dev"": true
        }}
      }}
    }},
    ""sass-extract-loader"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/sass-extract-loader/-/sass-extract-loader-1.1.0.tgz"",
      ""integrity"": ""sha1-rU5xI7glM/jLvegU40L0SryyEFQ="",
      ""dev"": true,
      ""requires"": {{
        ""loader-utils"": ""1.1.0""
      }},
      ""dependencies"": {{
        ""loader-utils"": {{
          ""version"": ""1.1.0"",
          ""resolved"": ""https://registry.npmjs.org/loader-utils/-/loader-utils-1.1.0.tgz"",
          ""integrity"": ""sha1-yYrvSIvM7aL/teLeZG1qdUQp9c0="",
          ""dev"": true,
          ""requires"": {{
            ""big.js"": ""3.2.0"",
            ""emojis-list"": ""2.1.0"",
            ""json5"": ""0.5.1""
          }}
        }}
      }}
    }},
    ""sass-graph"": {{
      ""version"": ""2.2.4"",
      ""resolved"": ""https://registry.npmjs.org/sass-graph/-/sass-graph-2.2.4.tgz"",
      ""integrity"": ""sha1-E/vWPNHK8JCLn9k0dq1DpR0eC0k="",
      ""dev"": true,
      ""requires"": {{
        ""glob"": ""7.1.2"",
        ""lodash"": ""4.17.4"",
        ""scss-tokenizer"": ""0.2.3"",
        ""yargs"": ""7.1.0""
      }},
      ""dependencies"": {{
        ""glob"": {{
          ""version"": ""7.1.2"",
          ""resolved"": ""https://registry.npmjs.org/glob/-/glob-7.1.2.tgz"",
          ""integrity"": ""sha512-MJTUg1kjuLeQCJ+ccE4Vpa6kKVXkPYJ2mOCQyUuKLcLQsdrMCpBPUi8qVE6+YuaJkozeA9NusTAw3hLr8Xe5EQ=="",
          ""dev"": true,
          ""requires"": {{
            ""fs.realpath"": ""1.0.0"",
            ""inflight"": ""1.0.6"",
            ""inherits"": ""2.0.3"",
            ""minimatch"": ""3.0.4"",
            ""once"": ""1.4.0"",
            ""path-is-absolute"": ""1.0.1""
          }}
        }}
      }}
    }},
    ""sass-loader"": {{
      ""version"": ""6.0.6"",
      ""resolved"": ""https://registry.npmjs.org/sass-loader/-/sass-loader-6.0.6.tgz"",
      ""integrity"": ""sha512-c3/Zc+iW+qqDip6kXPYLEgsAu2lf4xz0EZDplB7EmSUMda12U1sGJPetH55B/j9eu0bTtKzKlNPWWyYC7wFNyQ=="",
      ""dev"": true,
      ""requires"": {{
        ""async"": ""2.6.0"",
        ""clone-deep"": ""0.3.0"",
        ""loader-utils"": ""1.1.0"",
        ""lodash.tail"": ""4.1.1"",
        ""pify"": ""3.0.0""
      }},
      ""dependencies"": {{
        ""loader-utils"": {{
          ""version"": ""1.1.0"",
          ""resolved"": ""https://registry.npmjs.org/loader-utils/-/loader-utils-1.1.0.tgz"",
          ""integrity"": ""sha1-yYrvSIvM7aL/teLeZG1qdUQp9c0="",
          ""dev"": true,
          ""requires"": {{
            ""big.js"": ""3.2.0"",
            ""emojis-list"": ""2.1.0"",
            ""json5"": ""0.5.1""
          }}
        }},
        ""pify"": {{
          ""version"": ""3.0.0"",
          ""resolved"": ""https://registry.npmjs.org/pify/-/pify-3.0.0.tgz"",
          ""integrity"": ""sha1-5aSs0sEB/fPZpNB/DbxNtJ3SgXY="",
          ""dev"": true
        }}
      }}
    }},
    ""sax"": {{
      ""version"": ""1.2.4"",
      ""resolved"": ""https://registry.npmjs.org/sax/-/sax-1.2.4.tgz"",
      ""integrity"": ""sha512-NqVDv9TpANUjFm0N8uM5GxL36UgKi9/atZw+x7YFnQ8ckwFGKrl4xX4yWtrey3UJm5nP1kUbnYgLopqWNSRhWw=="",
      ""dev"": true
    }},
    ""schema-utils"": {{
      ""version"": ""0.3.0"",
      ""resolved"": ""https://registry.npmjs.org/schema-utils/-/schema-utils-0.3.0.tgz"",
      ""integrity"": ""sha1-9YdyIs4+kx7a4DnxfrNxbnE3+M8="",
      ""dev"": true,
      ""requires"": {{
        ""ajv"": ""5.5.2""
      }},
      ""dependencies"": {{
        ""ajv"": {{
          ""version"": ""5.5.2"",
          ""resolved"": ""https://registry.npmjs.org/ajv/-/ajv-5.5.2.tgz"",
          ""integrity"": ""sha1-c7Xuyj+rZT49P5Qis0GtQiBdyWU="",
          ""dev"": true,
          ""requires"": {{
            ""co"": ""4.6.0"",
            ""fast-deep-equal"": ""1.0.0"",
            ""fast-json-stable-stringify"": ""2.0.0"",
            ""json-schema-traverse"": ""0.3.1""
          }}
        }}
      }}
    }},
    ""scss-tokenizer"": {{
      ""version"": ""0.2.3"",
      ""resolved"": ""https://registry.npmjs.org/scss-tokenizer/-/scss-tokenizer-0.2.3.tgz"",
      ""integrity"": ""sha1-jrBtualyMzOCTT9VMGQRSYR85dE="",
      ""dev"": true,
      ""requires"": {{
        ""js-base64"": ""2.4.0"",
        ""source-map"": ""0.4.4""
      }},
      ""dependencies"": {{
        ""source-map"": {{
          ""version"": ""0.4.4"",
          ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.4.4.tgz"",
          ""integrity"": ""sha1-66T12pwNyZneaAMti092FzZSA2s="",
          ""dev"": true,
          ""requires"": {{
            ""amdefine"": ""1.0.1""
          }}
        }}
      }}
    }},
    ""semver"": {{
      ""version"": ""5.4.1"",
      ""resolved"": ""https://registry.npmjs.org/semver/-/semver-5.4.1.tgz"",
      ""integrity"": ""sha512-WfG/X9+oATh81XtllIo/I8gOiY9EXRdv1cQdyykeXK17YcUW3EXUAi2To4pcH6nZtJPr7ZOpM5OMyWJZm+8Rsg=="",
      ""dev"": true
    }},
    ""send"": {{
      ""version"": ""0.16.1"",
      ""resolved"": ""https://registry.npmjs.org/send/-/send-0.16.1.tgz"",
      ""integrity"": ""sha512-ElCLJdJIKPk6ux/Hocwhk7NFHpI3pVm/IZOYWqUmoxcgeyM+MpxHHKhb8QmlJDX1pU6WrgaHBkVNm73Sv7uc2A=="",
      ""dev"": true,
      ""requires"": {{
        ""debug"": ""2.6.9"",
        ""depd"": ""1.1.1"",
        ""destroy"": ""1.0.4"",
        ""encodeurl"": ""1.0.1"",
        ""escape-html"": ""1.0.3"",
        ""etag"": ""1.8.1"",
        ""fresh"": ""0.5.2"",
        ""http-errors"": ""1.6.2"",
        ""mime"": ""1.4.1"",
        ""ms"": ""2.0.0"",
        ""on-finished"": ""2.3.0"",
        ""range-parser"": ""1.2.0"",
        ""statuses"": ""1.3.1""
      }}
    }},
    ""serve-index"": {{
      ""version"": ""1.9.1"",
      ""resolved"": ""https://registry.npmjs.org/serve-index/-/serve-index-1.9.1.tgz"",
      ""integrity"": ""sha1-03aNabHn2C5c4FD/9bRTvqEqkjk="",
      ""dev"": true,
      ""requires"": {{
        ""accepts"": ""1.3.4"",
        ""batch"": ""0.6.1"",
        ""debug"": ""2.6.9"",
        ""escape-html"": ""1.0.3"",
        ""http-errors"": ""1.6.2"",
        ""mime-types"": ""2.1.17"",
        ""parseurl"": ""1.3.2""
      }}
    }},
    ""serve-static"": {{
      ""version"": ""1.13.1"",
      ""resolved"": ""https://registry.npmjs.org/serve-static/-/serve-static-1.13.1.tgz"",
      ""integrity"": ""sha512-hSMUZrsPa/I09VYFJwa627JJkNs0NrfL1Uzuup+GqHfToR2KcsXFymXSV90hoyw3M+msjFuQly+YzIH/q0MGlQ=="",
      ""dev"": true,
      ""requires"": {{
        ""encodeurl"": ""1.0.1"",
        ""escape-html"": ""1.0.3"",
        ""parseurl"": ""1.3.2"",
        ""send"": ""0.16.1""
      }}
    }},
    ""set-blocking"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/set-blocking/-/set-blocking-2.0.0.tgz"",
      ""integrity"": ""sha1-BF+XgtARrppoA93TgrJDkrPYkPc="",
      ""dev"": true
    }},
    ""set-immediate-shim"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/set-immediate-shim/-/set-immediate-shim-1.0.1.tgz"",
      ""integrity"": ""sha1-SysbJ+uAip+NzEgaWOXlb1mfP2E="",
      ""dev"": true
    }},
    ""setimmediate"": {{
      ""version"": ""1.0.5"",
      ""resolved"": ""https://registry.npmjs.org/setimmediate/-/setimmediate-1.0.5.tgz"",
      ""integrity"": ""sha1-KQy7Iy4waULX1+qbg3Mqt4VvgoU=""
    }},
    ""setprototypeof"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/setprototypeof/-/setprototypeof-1.1.0.tgz"",
      ""integrity"": ""sha512-BvE/TwpZX4FXExxOxZyRGQQv651MSwmWKZGqvmPcRIjDqWub67kTKuIMx43cZZrS/cBBzwBcNDWoFxt2XEFIpQ=="",
      ""dev"": true
    }},
    ""sha.js"": {{
      ""version"": ""2.4.9"",
      ""resolved"": ""https://registry.npmjs.org/sha.js/-/sha.js-2.4.9.tgz"",
      ""integrity"": ""sha512-G8zektVqbiPHrylgew9Zg1VRB1L/DtXNUVAM6q4QLy8NE3qtHlFXTf8VLL4k1Yl6c7NMjtZUTdXV+X44nFaT6A=="",
      ""dev"": true,
      ""requires"": {{
        ""inherits"": ""2.0.3"",
        ""safe-buffer"": ""5.1.1""
      }}
    }},
    ""shallow-clone"": {{
      ""version"": ""0.1.2"",
      ""resolved"": ""https://registry.npmjs.org/shallow-clone/-/shallow-clone-0.1.2.tgz"",
      ""integrity"": ""sha1-WQnodLp3EG1zrEFM/sH/yofZcGA="",
      ""dev"": true,
      ""requires"": {{
        ""is-extendable"": ""0.1.1"",
        ""kind-of"": ""2.0.1"",
        ""lazy-cache"": ""0.2.7"",
        ""mixin-object"": ""2.0.1""
      }},
      ""dependencies"": {{
        ""kind-of"": {{
          ""version"": ""2.0.1"",
          ""resolved"": ""https://registry.npmjs.org/kind-of/-/kind-of-2.0.1.tgz"",
          ""integrity"": ""sha1-AY7HpM5+OobLkUG+UZ0kyPqpgbU="",
          ""dev"": true,
          ""requires"": {{
            ""is-buffer"": ""1.1.6""
          }}
        }}
      }}
    }},
    ""shebang-command"": {{
      ""version"": ""1.2.0"",
      ""resolved"": ""https://registry.npmjs.org/shebang-command/-/shebang-command-1.2.0.tgz"",
      ""integrity"": ""sha1-RKrGW2lbAzmJaMOfNj/uXer98eo="",
      ""dev"": true,
      ""requires"": {{
        ""shebang-regex"": ""1.0.0""
      }}
    }},
    ""shebang-regex"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/shebang-regex/-/shebang-regex-1.0.0.tgz"",
      ""integrity"": ""sha1-2kL0l0DAtC2yypcoVxyxkMmO/qM="",
      ""dev"": true
    }},
    ""shelljs"": {{
      ""version"": ""0.6.1"",
      ""resolved"": ""https://registry.npmjs.org/shelljs/-/shelljs-0.6.1.tgz"",
      ""integrity"": ""sha1-7GIRvtGSBEIIj+D3Cyg3Iy7SyKg="",
      ""dev"": true
    }},
    ""shellwords"": {{
      ""version"": ""0.1.1"",
      ""resolved"": ""https://registry.npmjs.org/shellwords/-/shellwords-0.1.1.tgz"",
      ""integrity"": ""sha512-vFwSUfQvqybiICwZY5+DAWIPLKsWO31Q91JSKl3UYv+K5c2QRPzn0qzec6QPu1Qc9eHYItiP3NdJqNVqetYAww=="",
      ""dev"": true
    }},
    ""signal-exit"": {{
      ""version"": ""3.0.2"",
      ""resolved"": ""https://registry.npmjs.org/signal-exit/-/signal-exit-3.0.2.tgz"",
      ""integrity"": ""sha1-tf3AjxKH6hF4Yo5BXiUTK3NkbG0="",
      ""dev"": true
    }},
    ""simple-assign"": {{
      ""version"": ""0.1.0"",
      ""resolved"": ""https://registry.npmjs.org/simple-assign/-/simple-assign-0.1.0.tgz"",
      ""integrity"": ""sha1-F/0wZqXz13OPUDIbsPFMooHMS6o=""
    }},
    ""slash"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/slash/-/slash-1.0.0.tgz"",
      ""integrity"": ""sha1-xB8vbDn8FtHNF61LXYlhFK5HDVU="",
      ""dev"": true
    }},
    ""slice-ansi"": {{
      ""version"": ""0.0.4"",
      ""resolved"": ""https://registry.npmjs.org/slice-ansi/-/slice-ansi-0.0.4.tgz"",
      ""integrity"": ""sha1-7b+JA/ZvfOL46v1s7tZeJkyDGzU="",
      ""dev"": true
    }},
    ""sntp"": {{
      ""version"": ""2.1.0"",
      ""resolved"": ""https://registry.npmjs.org/sntp/-/sntp-2.1.0.tgz"",
      ""integrity"": ""sha512-FL1b58BDrqS3A11lJ0zEdnJ3UOKqVxawAkF3k7F0CVN7VQ34aZrV+G8BZ1WC9ZL7NyrwsW0oviwsWDgRuVYtJg=="",
      ""dev"": true,
      ""requires"": {{
        ""hoek"": ""4.2.0""
      }}
    }},
    ""sockjs"": {{
      ""version"": ""0.3.19"",
      ""resolved"": ""https://registry.npmjs.org/sockjs/-/sockjs-0.3.19.tgz"",
      ""integrity"": ""sha512-V48klKZl8T6MzatbLlzzRNhMepEys9Y4oGFpypBFFn1gLI/QQ9HtLLyWJNbPlwGLelOVOEijUbTTJeLLI59jLw=="",
      ""dev"": true,
      ""requires"": {{
        ""faye-websocket"": ""0.10.0"",
        ""uuid"": ""3.1.0""
      }}
    }},
    ""sockjs-client"": {{
      ""version"": ""1.1.4"",
      ""resolved"": ""https://registry.npmjs.org/sockjs-client/-/sockjs-client-1.1.4.tgz"",
      ""integrity"": ""sha1-W6vjhrd15M8U51IJEUUmVAFsixI="",
      ""dev"": true,
      ""requires"": {{
        ""debug"": ""2.6.9"",
        ""eventsource"": ""0.1.6"",
        ""faye-websocket"": ""0.11.1"",
        ""inherits"": ""2.0.3"",
        ""json3"": ""3.3.2"",
        ""url-parse"": ""1.2.0""
      }},
      ""dependencies"": {{
        ""faye-websocket"": {{
          ""version"": ""0.11.1"",
          ""resolved"": ""https://registry.npmjs.org/faye-websocket/-/faye-websocket-0.11.1.tgz"",
          ""integrity"": ""sha1-8O/hjE9W5PQK/H4Gxxn9XuYYjzg="",
          ""dev"": true,
          ""requires"": {{
            ""websocket-driver"": ""0.7.0""
          }}
        }}
      }}
    }},
    ""sort-keys"": {{
      ""version"": ""1.1.2"",
      ""resolved"": ""https://registry.npmjs.org/sort-keys/-/sort-keys-1.1.2.tgz"",
      ""integrity"": ""sha1-RBttTTRnmPG05J6JIK37oOVD+a0="",
      ""dev"": true,
      ""requires"": {{
        ""is-plain-obj"": ""1.1.0""
      }}
    }},
    ""source-list-map"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/source-list-map/-/source-list-map-2.0.0.tgz"",
      ""integrity"": ""sha512-I2UmuJSRr/T8jisiROLU3A3ltr+swpniSmNPI4Ml3ZCX6tVnDsuZzK7F2hl5jTqbZBWCEKlj5HRQiPExXLgE8A=="",
      ""dev"": true
    }},
    ""source-map"": {{
      ""version"": ""0.1.31"",
      ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.1.31.tgz"",
      ""integrity"": ""sha1-n3BNDWnZ4TioG63267T94z0VHGE="",
      ""dev"": true,
      ""requires"": {{
        ""amdefine"": ""1.0.1""
      }}
    }},
    ""source-map-resolve"": {{
      ""version"": ""0.3.1"",
      ""resolved"": ""https://registry.npmjs.org/source-map-resolve/-/source-map-resolve-0.3.1.tgz"",
      ""integrity"": ""sha1-YQ9hIqRFuN1RU1oqcbeD38Ekh2E="",
      ""dev"": true,
      ""requires"": {{
        ""atob"": ""1.1.3"",
        ""resolve-url"": ""0.2.1"",
        ""source-map-url"": ""0.3.0"",
        ""urix"": ""0.1.0""
      }}
    }},
    ""source-map-support"": {{
      ""version"": ""0.4.18"",
      ""resolved"": ""https://registry.npmjs.org/source-map-support/-/source-map-support-0.4.18.tgz"",
      ""integrity"": ""sha512-try0/JqxPLF9nOjvSta7tVondkP5dwgyLDjVoyMDlmjugT2lRZ1OfsrYTkCd2hkDnJTKRbO/Rl3orm8vlsUzbA=="",
      ""dev"": true,
      ""requires"": {{
        ""source-map"": ""0.5.7""
      }},
      ""dependencies"": {{
        ""source-map"": {{
          ""version"": ""0.5.7"",
          ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.5.7.tgz"",
          ""integrity"": ""sha1-igOdLRAh0i0eoUyA2OpGi6LvP8w="",
          ""dev"": true
        }}
      }}
    }},
    ""source-map-url"": {{
      ""version"": ""0.3.0"",
      ""resolved"": ""https://registry.npmjs.org/source-map-url/-/source-map-url-0.3.0.tgz"",
      ""integrity"": ""sha1-fsrxO1e80J2opAxdJp2zN5nUqvk="",
      ""dev"": true
    }},
    ""sourcemapped-stacktrace"": {{
      ""version"": ""1.1.8"",
      ""resolved"": ""https://registry.npmjs.org/sourcemapped-stacktrace/-/sourcemapped-stacktrace-1.1.8.tgz"",
      ""integrity"": ""sha512-OkVoI7GQOLl/laR1qsSo1c87tS8kF2VXhQq2SrQCDdXufBAcm8FgXogWso96ciMYoDtTw1Dn70CVdwYzoYs6Pg=="",
      ""dev"": true,
      ""requires"": {{
        ""source-map"": ""0.5.6""
      }},
      ""dependencies"": {{
        ""source-map"": {{
          ""version"": ""0.5.6"",
          ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.5.6.tgz"",
          ""integrity"": ""sha1-dc449SvwczxafwwRjYEzSiu19BI="",
          ""dev"": true
        }}
      }}
    }},
    ""spawn-command"": {{
      ""version"": ""0.0.2"",
      ""resolved"": ""https://registry.npmjs.org/spawn-command/-/spawn-command-0.0.2.tgz"",
      ""integrity"": ""sha1-lUThpDygRfhTGqwaSMspva5iM44="",
      ""dev"": true
    }},
    ""spdx-correct"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/spdx-correct/-/spdx-correct-1.0.2.tgz"",
      ""integrity"": ""sha1-SzBz2TP/UfORLwOsVRlJikFQ20A="",
      ""dev"": true,
      ""requires"": {{
        ""spdx-license-ids"": ""1.2.2""
      }}
    }},
    ""spdx-expression-parse"": {{
      ""version"": ""1.0.4"",
      ""resolved"": ""https://registry.npmjs.org/spdx-expression-parse/-/spdx-expression-parse-1.0.4.tgz"",
      ""integrity"": ""sha1-m98vIOH0DtRH++JzJmGR/O1RYmw="",
      ""dev"": true
    }},
    ""spdx-license-ids"": {{
      ""version"": ""1.2.2"",
      ""resolved"": ""https://registry.npmjs.org/spdx-license-ids/-/spdx-license-ids-1.2.2.tgz"",
      ""integrity"": ""sha1-yd96NCRZSt5r0RkA1ZZpbcBrrFc="",
      ""dev"": true
    }},
    ""sprintf-js"": {{
      ""version"": ""1.0.3"",
      ""resolved"": ""https://registry.npmjs.org/sprintf-js/-/sprintf-js-1.0.3.tgz"",
      ""integrity"": ""sha1-BOaSb2YolTVPPdAVIDYzuFcpfiw="",
      ""dev"": true
    }},
    ""sshpk"": {{
      ""version"": ""1.13.1"",
      ""resolved"": ""https://registry.npmjs.org/sshpk/-/sshpk-1.13.1.tgz"",
      ""integrity"": ""sha1-US322mKHFEMW3EwY/hzx2UBzm+M="",
      ""dev"": true,
      ""requires"": {{
        ""asn1"": ""0.2.3"",
        ""assert-plus"": ""1.0.0"",
        ""bcrypt-pbkdf"": ""1.0.1"",
        ""dashdash"": ""1.14.1"",
        ""ecc-jsbn"": ""0.1.1"",
        ""getpass"": ""0.1.7"",
        ""jsbn"": ""0.1.1"",
        ""tweetnacl"": ""0.14.5""
      }}
    }},
    ""stackframe"": {{
      ""version"": ""0.3.1"",
      ""resolved"": ""https://registry.npmjs.org/stackframe/-/stackframe-0.3.1.tgz"",
      ""integrity"": ""sha1-M6qE8Rd6VUjIk1Uzy/6zQgl19aQ="",
      ""dev"": true
    }},
    ""statuses"": {{
      ""version"": ""1.3.1"",
      ""resolved"": ""https://registry.npmjs.org/statuses/-/statuses-1.3.1.tgz"",
      ""integrity"": ""sha1-+vUbnrdKrvOzrPStX2Gr8ky3uT4="",
      ""dev"": true
    }},
    ""stdout-stream"": {{
      ""version"": ""1.4.0"",
      ""resolved"": ""https://registry.npmjs.org/stdout-stream/-/stdout-stream-1.4.0.tgz"",
      ""integrity"": ""sha1-osfIWH5U2UJ+qe2zrD8s1SLfN4s="",
      ""dev"": true,
      ""requires"": {{
        ""readable-stream"": ""2.3.3""
      }},
      ""dependencies"": {{
        ""isarray"": {{
          ""version"": ""1.0.0"",
          ""resolved"": ""https://registry.npmjs.org/isarray/-/isarray-1.0.0.tgz"",
          ""integrity"": ""sha1-u5NdSFgsuhaMBoNJV6VKPgcSTxE="",
          ""dev"": true
        }},
        ""readable-stream"": {{
          ""version"": ""2.3.3"",
          ""resolved"": ""https://registry.npmjs.org/readable-stream/-/readable-stream-2.3.3.tgz"",
          ""integrity"": ""sha512-m+qzzcn7KUxEmd1gMbchF+Y2eIUbieUaxkWtptyHywrX0rE8QEYqPC07Vuy4Wm32/xE16NcdBctb8S0Xe/5IeQ=="",
          ""dev"": true,
          ""requires"": {{
            ""core-util-is"": ""1.0.2"",
            ""inherits"": ""2.0.3"",
            ""isarray"": ""1.0.0"",
            ""process-nextick-args"": ""1.0.7"",
            ""safe-buffer"": ""5.1.1"",
            ""string_decoder"": ""1.0.3"",
            ""util-deprecate"": ""1.0.2""
          }}
        }},
        ""string_decoder"": {{
          ""version"": ""1.0.3"",
          ""resolved"": ""https://registry.npmjs.org/string_decoder/-/string_decoder-1.0.3.tgz"",
          ""integrity"": ""sha512-4AH6Z5fzNNBcH+6XDMfA/BTt87skxqJlO0lAh3Dker5zThcAxG6mKz+iGu308UKoPPQ8Dcqx/4JhujzltRa+hQ=="",
          ""dev"": true,
          ""requires"": {{
            ""safe-buffer"": ""5.1.1""
          }}
        }}
      }}
    }},
    ""stream-browserify"": {{
      ""version"": ""2.0.1"",
      ""resolved"": ""https://registry.npmjs.org/stream-browserify/-/stream-browserify-2.0.1.tgz"",
      ""integrity"": ""sha1-ZiZu5fm9uZQKTkUUyvtDu3Hlyds="",
      ""dev"": true,
      ""requires"": {{
        ""inherits"": ""2.0.3"",
        ""readable-stream"": ""2.3.3""
      }},
      ""dependencies"": {{
        ""isarray"": {{
          ""version"": ""1.0.0"",
          ""resolved"": ""https://registry.npmjs.org/isarray/-/isarray-1.0.0.tgz"",
          ""integrity"": ""sha1-u5NdSFgsuhaMBoNJV6VKPgcSTxE="",
          ""dev"": true
        }},
        ""readable-stream"": {{
          ""version"": ""2.3.3"",
          ""resolved"": ""https://registry.npmjs.org/readable-stream/-/readable-stream-2.3.3.tgz"",
          ""integrity"": ""sha512-m+qzzcn7KUxEmd1gMbchF+Y2eIUbieUaxkWtptyHywrX0rE8QEYqPC07Vuy4Wm32/xE16NcdBctb8S0Xe/5IeQ=="",
          ""dev"": true,
          ""requires"": {{
            ""core-util-is"": ""1.0.2"",
            ""inherits"": ""2.0.3"",
            ""isarray"": ""1.0.0"",
            ""process-nextick-args"": ""1.0.7"",
            ""safe-buffer"": ""5.1.1"",
            ""string_decoder"": ""1.0.3"",
            ""util-deprecate"": ""1.0.2""
          }}
        }},
        ""string_decoder"": {{
          ""version"": ""1.0.3"",
          ""resolved"": ""https://registry.npmjs.org/string_decoder/-/string_decoder-1.0.3.tgz"",
          ""integrity"": ""sha512-4AH6Z5fzNNBcH+6XDMfA/BTt87skxqJlO0lAh3Dker5zThcAxG6mKz+iGu308UKoPPQ8Dcqx/4JhujzltRa+hQ=="",
          ""dev"": true,
          ""requires"": {{
            ""safe-buffer"": ""5.1.1""
          }}
        }}
      }}
    }},
    ""stream-cache"": {{
      ""version"": ""0.0.2"",
      ""resolved"": ""https://registry.npmjs.org/stream-cache/-/stream-cache-0.0.2.tgz"",
      ""integrity"": ""sha1-GsWtaDJCjKVWZ9ve45Xa1ObbEY8="",
      ""dev"": true
    }},
    ""stream-http"": {{
      ""version"": ""2.7.2"",
      ""resolved"": ""https://registry.npmjs.org/stream-http/-/stream-http-2.7.2.tgz"",
      ""integrity"": ""sha512-c0yTD2rbQzXtSsFSVhtpvY/vS6u066PcXOX9kBB3mSO76RiUQzL340uJkGBWnlBg4/HZzqiUXtaVA7wcRcJgEw=="",
      ""dev"": true,
      ""requires"": {{
        ""builtin-status-codes"": ""3.0.0"",
        ""inherits"": ""2.0.3"",
        ""readable-stream"": ""2.3.3"",
        ""to-arraybuffer"": ""1.0.1"",
        ""xtend"": ""4.0.1""
      }},
      ""dependencies"": {{
        ""isarray"": {{
          ""version"": ""1.0.0"",
          ""resolved"": ""https://registry.npmjs.org/isarray/-/isarray-1.0.0.tgz"",
          ""integrity"": ""sha1-u5NdSFgsuhaMBoNJV6VKPgcSTxE="",
          ""dev"": true
        }},
        ""readable-stream"": {{
          ""version"": ""2.3.3"",
          ""resolved"": ""https://registry.npmjs.org/readable-stream/-/readable-stream-2.3.3.tgz"",
          ""integrity"": ""sha512-m+qzzcn7KUxEmd1gMbchF+Y2eIUbieUaxkWtptyHywrX0rE8QEYqPC07Vuy4Wm32/xE16NcdBctb8S0Xe/5IeQ=="",
          ""dev"": true,
          ""requires"": {{
            ""core-util-is"": ""1.0.2"",
            ""inherits"": ""2.0.3"",
            ""isarray"": ""1.0.0"",
            ""process-nextick-args"": ""1.0.7"",
            ""safe-buffer"": ""5.1.1"",
            ""string_decoder"": ""1.0.3"",
            ""util-deprecate"": ""1.0.2""
          }}
        }},
        ""string_decoder"": {{
          ""version"": ""1.0.3"",
          ""resolved"": ""https://registry.npmjs.org/string_decoder/-/string_decoder-1.0.3.tgz"",
          ""integrity"": ""sha512-4AH6Z5fzNNBcH+6XDMfA/BTt87skxqJlO0lAh3Dker5zThcAxG6mKz+iGu308UKoPPQ8Dcqx/4JhujzltRa+hQ=="",
          ""dev"": true,
          ""requires"": {{
            ""safe-buffer"": ""5.1.1""
          }}
        }}
      }}
    }},
    ""strict-uri-encode"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/strict-uri-encode/-/strict-uri-encode-1.1.0.tgz"",
      ""integrity"": ""sha1-J5siXfHVgrH1TmWt3UNS4Y+qBxM="",
      ""dev"": true
    }},
    ""string-hash"": {{
      ""version"": ""1.1.3"",
      ""resolved"": ""https://registry.npmjs.org/string-hash/-/string-hash-1.1.3.tgz"",
      ""integrity"": ""sha1-6Kr8CsGFW0Zmkp7X3RJ1311sgRs="",
      ""dev"": true
    }},
    ""string-length"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/string-length/-/string-length-2.0.0.tgz"",
      ""integrity"": ""sha1-1A27aGo6zpYMHP/KVivyxF+DY+0="",
      ""dev"": true,
      ""requires"": {{
        ""astral-regex"": ""1.0.0"",
        ""strip-ansi"": ""4.0.0""
      }},
      ""dependencies"": {{
        ""ansi-regex"": {{
          ""version"": ""3.0.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-regex/-/ansi-regex-3.0.0.tgz"",
          ""integrity"": ""sha1-7QMXwyIGT3lGbAKWa922Bas32Zg="",
          ""dev"": true
        }},
        ""strip-ansi"": {{
          ""version"": ""4.0.0"",
          ""resolved"": ""https://registry.npmjs.org/strip-ansi/-/strip-ansi-4.0.0.tgz"",
          ""integrity"": ""sha1-qEeQIusaw2iocTibY1JixQXuNo8="",
          ""dev"": true,
          ""requires"": {{
            ""ansi-regex"": ""3.0.0""
          }}
        }}
      }}
    }},
    ""string-width"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/string-width/-/string-width-1.0.2.tgz"",
      ""integrity"": ""sha1-EYvfW4zcUaKn5w0hHgfisLmxB9M="",
      ""dev"": true,
      ""requires"": {{
        ""code-point-at"": ""1.1.0"",
        ""is-fullwidth-code-point"": ""1.0.0"",
        ""strip-ansi"": ""3.0.1""
      }}
    }},
    ""string_decoder"": {{
      ""version"": ""0.10.31"",
      ""resolved"": ""https://registry.npmjs.org/string_decoder/-/string_decoder-0.10.31.tgz"",
      ""integrity"": ""sha1-YuIDvEF2bGwoyfyEMB2rHFMQ+pQ="",
      ""dev"": true
    }},
    ""stringstream"": {{
      ""version"": ""0.0.5"",
      ""resolved"": ""https://registry.npmjs.org/stringstream/-/stringstream-0.0.5.tgz"",
      ""integrity"": ""sha1-TkhM1N5aC7vuGORjB3EKioFiGHg="",
      ""dev"": true
    }},
    ""strip-ansi"": {{
      ""version"": ""3.0.1"",
      ""resolved"": ""https://registry.npmjs.org/strip-ansi/-/strip-ansi-3.0.1.tgz"",
      ""integrity"": ""sha1-ajhfuIU9lS1f8F0Oiq+UJ43GPc8="",
      ""dev"": true,
      ""requires"": {{
        ""ansi-regex"": ""2.1.1""
      }}
    }},
    ""strip-bom"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/strip-bom/-/strip-bom-2.0.0.tgz"",
      ""integrity"": ""sha1-YhmoVhZSBJHzV4i9vxRHqZx+aw4="",
      ""dev"": true,
      ""requires"": {{
        ""is-utf8"": ""0.2.1""
      }}
    }},
    ""strip-eof"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/strip-eof/-/strip-eof-1.0.0.tgz"",
      ""integrity"": ""sha1-u0P/VZim6wXYm1n80SnJgzE2Br8="",
      ""dev"": true
    }},
    ""strip-indent"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/strip-indent/-/strip-indent-1.0.1.tgz"",
      ""integrity"": ""sha1-DHlipq3vp7vUrDZkYKY4VSrhoKI="",
      ""dev"": true,
      ""requires"": {{
        ""get-stdin"": ""4.0.1""
      }}
    }},
    ""strip-json-comments"": {{
      ""version"": ""1.0.4"",
      ""resolved"": ""https://registry.npmjs.org/strip-json-comments/-/strip-json-comments-1.0.4.tgz"",
      ""integrity"": ""sha1-HhX7ysl9Pumb8tc7TGVrCCu6+5E="",
      ""dev"": true
    }},
    ""style-loader"": {{
      ""version"": ""0.13.2"",
      ""resolved"": ""https://registry.npmjs.org/style-loader/-/style-loader-0.13.2.tgz"",
      ""integrity"": ""sha1-dFMzhM9pjHEEx5URULSXF63C87s="",
      ""dev"": true,
      ""requires"": {{
        ""loader-utils"": ""1.1.0""
      }},
      ""dependencies"": {{
        ""loader-utils"": {{
          ""version"": ""1.1.0"",
          ""resolved"": ""https://registry.npmjs.org/loader-utils/-/loader-utils-1.1.0.tgz"",
          ""integrity"": ""sha1-yYrvSIvM7aL/teLeZG1qdUQp9c0="",
          ""dev"": true,
          ""requires"": {{
            ""big.js"": ""3.2.0"",
            ""emojis-list"": ""2.1.0"",
            ""json5"": ""0.5.1""
          }}
        }}
      }}
    }},
    ""supports-color"": {{
      ""version"": ""3.2.3"",
      ""resolved"": ""https://registry.npmjs.org/supports-color/-/supports-color-3.2.3.tgz"",
      ""integrity"": ""sha1-ZawFBLOVQXHYpklGsq48u4pfVPY="",
      ""dev"": true,
      ""requires"": {{
        ""has-flag"": ""1.0.0""
      }}
    }},
    ""svgo"": {{
      ""version"": ""0.7.2"",
      ""resolved"": ""https://registry.npmjs.org/svgo/-/svgo-0.7.2.tgz"",
      ""integrity"": ""sha1-n1dyQTlSE1xv779Ar+ak+qiLS7U="",
      ""dev"": true,
      ""requires"": {{
        ""coa"": ""1.0.4"",
        ""colors"": ""1.1.2"",
        ""csso"": ""2.3.2"",
        ""js-yaml"": ""3.7.0"",
        ""mkdirp"": ""0.5.1"",
        ""sax"": ""1.2.4"",
        ""whet.extend"": ""0.9.9""
      }}
    }},
    ""symbol-observable"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/symbol-observable/-/symbol-observable-1.1.0.tgz"",
      ""integrity"": ""sha512-dQoid9tqQ+uotGhuTKEY11X4xhyYePVnqGSoSm3OGKh2E8LZ6RPULp1uXTctk33IeERlrRJYoVSBglsL05F5Uw==""
    }},
    ""symbol-tree"": {{
      ""version"": ""3.2.2"",
      ""resolved"": ""https://registry.npmjs.org/symbol-tree/-/symbol-tree-3.2.2.tgz"",
      ""integrity"": ""sha1-rifbOPZgp64uHDt9G8KQgZuFGeY="",
      ""dev"": true
    }},
    ""table"": {{
      ""version"": ""3.8.3"",
      ""resolved"": ""https://registry.npmjs.org/table/-/table-3.8.3.tgz"",
      ""integrity"": ""sha1-K7xULw/amGGnVdOUf+/Ys/UThV8="",
      ""dev"": true,
      ""requires"": {{
        ""ajv"": ""4.11.8"",
        ""ajv-keywords"": ""1.5.1"",
        ""chalk"": ""1.1.3"",
        ""lodash"": ""4.17.4"",
        ""slice-ansi"": ""0.0.4"",
        ""string-width"": ""2.1.1""
      }},
      ""dependencies"": {{
        ""ansi-regex"": {{
          ""version"": ""3.0.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-regex/-/ansi-regex-3.0.0.tgz"",
          ""integrity"": ""sha1-7QMXwyIGT3lGbAKWa922Bas32Zg="",
          ""dev"": true
        }},
        ""is-fullwidth-code-point"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/is-fullwidth-code-point/-/is-fullwidth-code-point-2.0.0.tgz"",
          ""integrity"": ""sha1-o7MKXE8ZkYMWeqq5O+764937ZU8="",
          ""dev"": true
        }},
        ""string-width"": {{
          ""version"": ""2.1.1"",
          ""resolved"": ""https://registry.npmjs.org/string-width/-/string-width-2.1.1.tgz"",
          ""integrity"": ""sha512-nOqH59deCq9SRHlxq1Aw85Jnt4w6KvLKqWVik6oA9ZklXLNIOlqg4F2yrT1MVaTjAqvVwdfeZ7w7aCvJD7ugkw=="",
          ""dev"": true,
          ""requires"": {{
            ""is-fullwidth-code-point"": ""2.0.0"",
            ""strip-ansi"": ""4.0.0""
          }}
        }},
        ""strip-ansi"": {{
          ""version"": ""4.0.0"",
          ""resolved"": ""https://registry.npmjs.org/strip-ansi/-/strip-ansi-4.0.0.tgz"",
          ""integrity"": ""sha1-qEeQIusaw2iocTibY1JixQXuNo8="",
          ""dev"": true,
          ""requires"": {{
            ""ansi-regex"": ""3.0.0""
          }}
        }}
      }}
    }},
    ""tapable"": {{
      ""version"": ""0.2.8"",
      ""resolved"": ""https://registry.npmjs.org/tapable/-/tapable-0.2.8.tgz"",
      ""integrity"": ""sha1-mTcqXJmb8t8WCvwNdL7U9HlIzSI="",
      ""dev"": true
    }},
    ""tar"": {{
      ""version"": ""2.2.1"",
      ""resolved"": ""https://registry.npmjs.org/tar/-/tar-2.2.1.tgz"",
      ""integrity"": ""sha1-jk0qJWwOIYXGsYrWlK7JaLg8sdE="",
      ""dev"": true,
      ""requires"": {{
        ""block-stream"": ""0.0.9"",
        ""fstream"": ""1.0.11"",
        ""inherits"": ""2.0.3""
      }}
    }},
    ""tcomb"": {{
      ""version"": ""2.7.0"",
      ""resolved"": ""https://registry.npmjs.org/tcomb/-/tcomb-2.7.0.tgz"",
      ""integrity"": ""sha1-ENYpWAQWaaXVNWe5pO6M3iKxwrA="",
      ""dev"": true
    }},
    ""test-exclude"": {{
      ""version"": ""4.1.1"",
      ""resolved"": ""https://registry.npmjs.org/test-exclude/-/test-exclude-4.1.1.tgz"",
      ""integrity"": ""sha512-35+Asrsk3XHJDBgf/VRFexPgh3UyETv8IAn/LRTiZjVy6rjPVqdEk8dJcJYBzl1w0XCJM48lvTy8SfEsCWS4nA=="",
      ""dev"": true,
      ""requires"": {{
        ""arrify"": ""1.0.1"",
        ""micromatch"": ""2.3.11"",
        ""object-assign"": ""4.1.1"",
        ""read-pkg-up"": ""1.0.1"",
        ""require-main-filename"": ""1.0.1""
      }}
    }},
    ""text-table"": {{
      ""version"": ""0.2.0"",
      ""resolved"": ""https://registry.npmjs.org/text-table/-/text-table-0.2.0.tgz"",
      ""integrity"": ""sha1-f17oI66AUgfACvLfSoTsP8+lcLQ="",
      ""dev"": true
    }},
    ""throat"": {{
      ""version"": ""4.1.0"",
      ""resolved"": ""https://registry.npmjs.org/throat/-/throat-4.1.0.tgz"",
      ""integrity"": ""sha1-iQN8vJLFarGJJua6TLsgDhVnKmo="",
      ""dev"": true
    }},
    ""through"": {{
      ""version"": ""2.3.8"",
      ""resolved"": ""https://registry.npmjs.org/through/-/through-2.3.8.tgz"",
      ""integrity"": ""sha1-DdTJ/6q8NXlgsbckEV1+Doai4fU="",
      ""dev"": true
    }},
    ""time-stamp"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/time-stamp/-/time-stamp-2.0.0.tgz"",
      ""integrity"": ""sha1-lcakRTDhW6jW9KPsuMOj+sRto1c="",
      ""dev"": true
    }},
    ""timers-browserify"": {{
      ""version"": ""2.0.4"",
      ""resolved"": ""https://registry.npmjs.org/timers-browserify/-/timers-browserify-2.0.4.tgz"",
      ""integrity"": ""sha512-uZYhyU3EX8O7HQP+J9fTVYwsq90Vr68xPEFo7yrVImIxYvHgukBEgOB/SgGoorWVTzGM/3Z+wUNnboA4M8jWrg=="",
      ""dev"": true,
      ""requires"": {{
        ""setimmediate"": ""1.0.5""
      }}
    }},
    ""tmpl"": {{
      ""version"": ""1.0.4"",
      ""resolved"": ""https://registry.npmjs.org/tmpl/-/tmpl-1.0.4.tgz"",
      ""integrity"": ""sha1-I2QN17QtAEM5ERQIIOXPRA5SHdE="",
      ""dev"": true
    }},
    ""to-arraybuffer"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/to-arraybuffer/-/to-arraybuffer-1.0.1.tgz"",
      ""integrity"": ""sha1-fSKbH8xjfkZsoIEYCDanqr/4P0M="",
      ""dev"": true
    }},
    ""to-fast-properties"": {{
      ""version"": ""1.0.3"",
      ""resolved"": ""https://registry.npmjs.org/to-fast-properties/-/to-fast-properties-1.0.3.tgz"",
      ""integrity"": ""sha1-uDVx+k2MJbguIxsG46MFXeTKGkc="",
      ""dev"": true
    }},
    ""toposort"": {{
      ""version"": ""1.0.6"",
      ""resolved"": ""https://registry.npmjs.org/toposort/-/toposort-1.0.6.tgz"",
      ""integrity"": ""sha1-wxdI5V0hDv/AD9zcfW5o19e7nOw="",
      ""dev"": true
    }},
    ""tough-cookie"": {{
      ""version"": ""2.3.3"",
      ""resolved"": ""https://registry.npmjs.org/tough-cookie/-/tough-cookie-2.3.3.tgz"",
      ""integrity"": ""sha1-C2GKVWW23qkL80JdBNVe3EdadWE="",
      ""dev"": true,
      ""requires"": {{
        ""punycode"": ""1.4.1""
      }}
    }},
    ""tr46"": {{
      ""version"": ""0.0.3"",
      ""resolved"": ""https://registry.npmjs.org/tr46/-/tr46-0.0.3.tgz"",
      ""integrity"": ""sha1-gYT9NH2snNwYWZLzpmIuFLnZq2o="",
      ""dev"": true
    }},
    ""trim-newlines"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/trim-newlines/-/trim-newlines-1.0.0.tgz"",
      ""integrity"": ""sha1-WIeWa7WCpFA6QetST301ARgVphM="",
      ""dev"": true
    }},
    ""trim-right"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/trim-right/-/trim-right-1.0.1.tgz"",
      ""integrity"": ""sha1-yy4SAwZ+DI3h9hQJS5/kVwTqYAM="",
      ""dev"": true
    }},
    ""true-case-path"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/true-case-path/-/true-case-path-1.0.2.tgz"",
      ""integrity"": ""sha1-fskRMJJHZsf1c74wIMNPj9/QDWI="",
      ""dev"": true,
      ""requires"": {{
        ""glob"": ""6.0.4""
      }}
    }},
    ""tty-browserify"": {{
      ""version"": ""0.0.0"",
      ""resolved"": ""https://registry.npmjs.org/tty-browserify/-/tty-browserify-0.0.0.tgz"",
      ""integrity"": ""sha1-oVe6QC2iTpv5V/mqadUk7tQpAaY="",
      ""dev"": true
    }},
    ""tunnel-agent"": {{
      ""version"": ""0.6.0"",
      ""resolved"": ""https://registry.npmjs.org/tunnel-agent/-/tunnel-agent-0.6.0.tgz"",
      ""integrity"": ""sha1-J6XeoGs2sEoKmWZ3SykIaPD8QP0="",
      ""dev"": true,
      ""requires"": {{
        ""safe-buffer"": ""5.1.1""
      }}
    }},
    ""tweetnacl"": {{
      ""version"": ""0.14.5"",
      ""resolved"": ""https://registry.npmjs.org/tweetnacl/-/tweetnacl-0.14.5.tgz"",
      ""integrity"": ""sha1-WuaBd/GS1EViadEIr6k/+HQ/T2Q="",
      ""dev"": true,
      ""optional"": true
    }},
    ""type-check"": {{
      ""version"": ""0.3.2"",
      ""resolved"": ""https://registry.npmjs.org/type-check/-/type-check-0.3.2.tgz"",
      ""integrity"": ""sha1-WITKtRLPHTVeP7eE8wgEsrUg23I="",
      ""dev"": true,
      ""requires"": {{
        ""prelude-ls"": ""1.1.2""
      }}
    }},
    ""type-is"": {{
      ""version"": ""1.6.15"",
      ""resolved"": ""https://registry.npmjs.org/type-is/-/type-is-1.6.15.tgz"",
      ""integrity"": ""sha1-yrEPtJCeRByChC6v4a1kbIGARBA="",
      ""dev"": true,
      ""requires"": {{
        ""media-typer"": ""0.3.0"",
        ""mime-types"": ""2.1.17""
      }}
    }},
    ""typedarray"": {{
      ""version"": ""0.0.6"",
      ""resolved"": ""https://registry.npmjs.org/typedarray/-/typedarray-0.0.6.tgz"",
      ""integrity"": ""sha1-hnrHTjhkGHsdPUfZlqeOxciDB3c="",
      ""dev"": true
    }},
    ""ua-parser-js"": {{
      ""version"": ""0.7.17"",
      ""resolved"": ""https://registry.npmjs.org/ua-parser-js/-/ua-parser-js-0.7.17.tgz"",
      ""integrity"": ""sha512-uRdSdu1oA1rncCQL7sCj8vSyZkgtL7faaw9Tc9rZ3mGgraQ7+Pdx7w5mnOSF3gw9ZNG6oc+KXfkon3bKuROm0g==""
    }},
    ""uglify-js"": {{
      ""version"": ""3.3.4"",
      ""resolved"": ""https://registry.npmjs.org/uglify-js/-/uglify-js-3.3.4.tgz"",
      ""integrity"": ""sha512-hfIwuAQI5dlXP30UtdmWoYF9k+ypVqBXIdmd6ZKBiaNHHvA8ty7ZloMe3+7S5AEKVkxHbjByl4DfRHQ7QpZquw=="",
      ""dev"": true,
      ""requires"": {{
        ""commander"": ""2.12.2"",
        ""source-map"": ""0.6.1""
      }},
      ""dependencies"": {{
        ""commander"": {{
          ""version"": ""2.12.2"",
          ""resolved"": ""https://registry.npmjs.org/commander/-/commander-2.12.2.tgz"",
          ""integrity"": ""sha512-BFnaq5ZOGcDN7FlrtBT4xxkgIToalIIxwjxLWVJ8bGTpe1LroqMiqQXdA7ygc7CRvaYS+9zfPGFnJqFSayx+AA=="",
          ""dev"": true
        }},
        ""source-map"": {{
          ""version"": ""0.6.1"",
          ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.6.1.tgz"",
          ""integrity"": ""sha512-UjgapumWlbMhkBgzT7Ykc5YXUT46F0iKu8SGXq0bcwP5dz/h0Plj6enJqjz1Zbq2l5WaqYnrVbwWOWMyF3F47g=="",
          ""dev"": true
        }}
      }}
    }},
    ""uglify-to-browserify"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/uglify-to-browserify/-/uglify-to-browserify-1.0.2.tgz"",
      ""integrity"": ""sha1-bgkk1r2mta/jSeOabWMoUKD4grc="",
      ""dev"": true,
      ""optional"": true
    }},
    ""uglifyjs-webpack-plugin"": {{
      ""version"": ""0.4.6"",
      ""resolved"": ""https://registry.npmjs.org/uglifyjs-webpack-plugin/-/uglifyjs-webpack-plugin-0.4.6.tgz"",
      ""integrity"": ""sha1-uVH0q7a9YX5m9j64kUmOORdj4wk="",
      ""dev"": true,
      ""requires"": {{
        ""source-map"": ""0.5.7"",
        ""uglify-js"": ""2.8.29"",
        ""webpack-sources"": ""1.1.0""
      }},
      ""dependencies"": {{
        ""camelcase"": {{
          ""version"": ""1.2.1"",
          ""resolved"": ""https://registry.npmjs.org/camelcase/-/camelcase-1.2.1.tgz"",
          ""integrity"": ""sha1-m7UwTS4LVmmLLHWLCKPqqdqlijk="",
          ""dev"": true
        }},
        ""cliui"": {{
          ""version"": ""2.1.0"",
          ""resolved"": ""https://registry.npmjs.org/cliui/-/cliui-2.1.0.tgz"",
          ""integrity"": ""sha1-S0dXYP+AJkx2LDoXGQMukcf+oNE="",
          ""dev"": true,
          ""requires"": {{
            ""center-align"": ""0.1.3"",
            ""right-align"": ""0.1.3"",
            ""wordwrap"": ""0.0.2""
          }}
        }},
        ""source-map"": {{
          ""version"": ""0.5.7"",
          ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.5.7.tgz"",
          ""integrity"": ""sha1-igOdLRAh0i0eoUyA2OpGi6LvP8w="",
          ""dev"": true
        }},
        ""uglify-js"": {{
          ""version"": ""2.8.29"",
          ""resolved"": ""https://registry.npmjs.org/uglify-js/-/uglify-js-2.8.29.tgz"",
          ""integrity"": ""sha1-KcVzMUgFe7Th913zW3qcty5qWd0="",
          ""dev"": true,
          ""requires"": {{
            ""source-map"": ""0.5.7"",
            ""uglify-to-browserify"": ""1.0.2"",
            ""yargs"": ""3.10.0""
          }}
        }},
        ""wordwrap"": {{
          ""version"": ""0.0.2"",
          ""resolved"": ""https://registry.npmjs.org/wordwrap/-/wordwrap-0.0.2.tgz"",
          ""integrity"": ""sha1-t5Zpu0LstAn4PVg8rVLKF+qhZD8="",
          ""dev"": true
        }},
        ""yargs"": {{
          ""version"": ""3.10.0"",
          ""resolved"": ""https://registry.npmjs.org/yargs/-/yargs-3.10.0.tgz"",
          ""integrity"": ""sha1-9+572FfdfB0tOMDnTvvWgdFDH9E="",
          ""dev"": true,
          ""requires"": {{
            ""camelcase"": ""1.2.1"",
            ""cliui"": ""2.1.0"",
            ""decamelize"": ""1.2.0"",
            ""window-size"": ""0.1.0""
          }}
        }}
      }}
    }},
    ""uniq"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/uniq/-/uniq-1.0.1.tgz"",
      ""integrity"": ""sha1-sxxa6CVIRKOoKBVBzisEuGWnNP8="",
      ""dev"": true
    }},
    ""uniqid"": {{
      ""version"": ""4.1.1"",
      ""resolved"": ""https://registry.npmjs.org/uniqid/-/uniqid-4.1.1.tgz"",
      ""integrity"": ""sha1-iSIN32t1GuUrX3JISGNShZa7hME="",
      ""dev"": true,
      ""requires"": {{
        ""macaddress"": ""0.2.8""
      }}
    }},
    ""uniqs"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/uniqs/-/uniqs-2.0.0.tgz"",
      ""integrity"": ""sha1-/+3ks2slKQaW5uFl1KWe25mOawI="",
      ""dev"": true
    }},
    ""unpipe"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/unpipe/-/unpipe-1.0.0.tgz"",
      ""integrity"": ""sha1-sr9O6FFKrmFltIF4KdIbLvSZBOw="",
      ""dev"": true
    }},
    ""upper-case"": {{
      ""version"": ""1.1.3"",
      ""resolved"": ""https://registry.npmjs.org/upper-case/-/upper-case-1.1.3.tgz"",
      ""integrity"": ""sha1-9rRQHC7EzdJrp4vnIilh3ndiFZg="",
      ""dev"": true
    }},
    ""urix"": {{
      ""version"": ""0.1.0"",
      ""resolved"": ""https://registry.npmjs.org/urix/-/urix-0.1.0.tgz"",
      ""integrity"": ""sha1-2pN/emLiH+wf0Y1Js1wpNQZ6bHI="",
      ""dev"": true
    }},
    ""url"": {{
      ""version"": ""0.11.0"",
      ""resolved"": ""https://registry.npmjs.org/url/-/url-0.11.0.tgz"",
      ""integrity"": ""sha1-ODjpfPxgUh63PFJajlW/3Z4uKPE="",
      ""dev"": true,
      ""requires"": {{
        ""punycode"": ""1.3.2"",
        ""querystring"": ""0.2.0""
      }},
      ""dependencies"": {{
        ""punycode"": {{
          ""version"": ""1.3.2"",
          ""resolved"": ""https://registry.npmjs.org/punycode/-/punycode-1.3.2.tgz"",
          ""integrity"": ""sha1-llOgNvt8HuQjQvIyXM7v6jkmxI0="",
          ""dev"": true
        }}
      }}
    }},
    ""url-loader"": {{
      ""version"": ""0.5.9"",
      ""resolved"": ""https://registry.npmjs.org/url-loader/-/url-loader-0.5.9.tgz"",
      ""integrity"": ""sha512-B7QYFyvv+fOBqBVeefsxv6koWWtjmHaMFT6KZWti4KRw8YUD/hOU+3AECvXuzyVawIBx3z7zQRejXCDSO5kk1Q=="",
      ""dev"": true,
      ""requires"": {{
        ""loader-utils"": ""1.1.0"",
        ""mime"": ""1.3.6""
      }},
      ""dependencies"": {{
        ""loader-utils"": {{
          ""version"": ""1.1.0"",
          ""resolved"": ""https://registry.npmjs.org/loader-utils/-/loader-utils-1.1.0.tgz"",
          ""integrity"": ""sha1-yYrvSIvM7aL/teLeZG1qdUQp9c0="",
          ""dev"": true,
          ""requires"": {{
            ""big.js"": ""3.2.0"",
            ""emojis-list"": ""2.1.0"",
            ""json5"": ""0.5.1""
          }}
        }},
        ""mime"": {{
          ""version"": ""1.3.6"",
          ""resolved"": ""https://registry.npmjs.org/mime/-/mime-1.3.6.tgz"",
          ""integrity"": ""sha1-WR2E02U6awtKO5343lqoEI5y5eA="",
          ""dev"": true
        }}
      }}
    }},
    ""url-parse"": {{
      ""version"": ""1.2.0"",
      ""resolved"": ""https://registry.npmjs.org/url-parse/-/url-parse-1.2.0.tgz"",
      ""integrity"": ""sha512-DT1XbYAfmQP65M/mE6OALxmXzZ/z1+e5zk2TcSKe/KiYbNGZxgtttzC0mR/sjopbpOXcbniq7eIKmocJnUWlEw=="",
      ""dev"": true,
      ""requires"": {{
        ""querystringify"": ""1.0.0"",
        ""requires-port"": ""1.0.0""
      }},
      ""dependencies"": {{
        ""querystringify"": {{
          ""version"": ""1.0.0"",
          ""resolved"": ""https://registry.npmjs.org/querystringify/-/querystringify-1.0.0.tgz"",
          ""integrity"": ""sha1-YoYkIRLFtxL6ZU5SZlK/ahP/Bcs="",
          ""dev"": true
        }}
      }}
    }},
    ""user-home"": {{
      ""version"": ""2.0.0"",
      ""resolved"": ""https://registry.npmjs.org/user-home/-/user-home-2.0.0.tgz"",
      ""integrity"": ""sha1-nHC/2Babwdy/SGBODwS4tJzenp8="",
      ""dev"": true,
      ""requires"": {{
        ""os-homedir"": ""1.0.2""
      }}
    }},
    ""util"": {{
      ""version"": ""0.10.3"",
      ""resolved"": ""https://registry.npmjs.org/util/-/util-0.10.3.tgz"",
      ""integrity"": ""sha1-evsa/lCAUkZInj23/g7TeTNqwPk="",
      ""dev"": true,
      ""requires"": {{
        ""inherits"": ""2.0.1""
      }},
      ""dependencies"": {{
        ""inherits"": {{
          ""version"": ""2.0.1"",
          ""resolved"": ""https://registry.npmjs.org/inherits/-/inherits-2.0.1.tgz"",
          ""integrity"": ""sha1-sX0I0ya0Qj5Wjv9xn5GwscvfafE="",
          ""dev"": true
        }}
      }}
    }},
    ""util-deprecate"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/util-deprecate/-/util-deprecate-1.0.2.tgz"",
      ""integrity"": ""sha1-RQ1Nyfpw3nMnYvvS1KKJgUGaDM8="",
      ""dev"": true
    }},
    ""utila"": {{
      ""version"": ""0.4.0"",
      ""resolved"": ""https://registry.npmjs.org/utila/-/utila-0.4.0.tgz"",
      ""integrity"": ""sha1-ihagXURWV6Oupe7MWxKk+lN5dyw="",
      ""dev"": true
    }},
    ""utils-merge"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/utils-merge/-/utils-merge-1.0.1.tgz"",
      ""integrity"": ""sha1-n5VxD1CiZ5R7LMwSR0HBAoQn5xM="",
      ""dev"": true
    }},
    ""uuid"": {{
      ""version"": ""3.1.0"",
      ""resolved"": ""https://registry.npmjs.org/uuid/-/uuid-3.1.0.tgz"",
      ""integrity"": ""sha512-DIWtzUkw04M4k3bf1IcpS2tngXEL26YUD2M0tMDUpnUrz2hgzUBlD55a4FjdLGPvfHxS6uluGWvaVEqgBcVa+g=="",
      ""dev"": true
    }},
    ""validate-npm-package-license"": {{
      ""version"": ""3.0.1"",
      ""resolved"": ""https://registry.npmjs.org/validate-npm-package-license/-/validate-npm-package-license-3.0.1.tgz"",
      ""integrity"": ""sha1-KAS6vnEq0zeUWaz74kdGqywwP7w="",
      ""dev"": true,
      ""requires"": {{
        ""spdx-correct"": ""1.0.2"",
        ""spdx-expression-parse"": ""1.0.4""
      }}
    }},
    ""value-equal"": {{
      ""version"": ""0.4.0"",
      ""resolved"": ""https://registry.npmjs.org/value-equal/-/value-equal-0.4.0.tgz"",
      ""integrity"": ""sha512-x+cYdNnaA3CxvMaTX0INdTCN8m8aF2uY9BvEqmxuYp8bL09cs/kWVQPVGcA35fMktdOsP69IgU7wFj/61dJHEw==""
    }},
    ""vary"": {{
      ""version"": ""1.1.2"",
      ""resolved"": ""https://registry.npmjs.org/vary/-/vary-1.1.2.tgz"",
      ""integrity"": ""sha1-IpnwLG3tMNSllhsLn3RSShj2NPw="",
      ""dev"": true
    }},
    ""vendors"": {{
      ""version"": ""1.0.1"",
      ""resolved"": ""https://registry.npmjs.org/vendors/-/vendors-1.0.1.tgz"",
      ""integrity"": ""sha1-N61zyO5Bf7PVgOeFMSMH0nSEfyI="",
      ""dev"": true
    }},
    ""verror"": {{
      ""version"": ""1.10.0"",
      ""resolved"": ""https://registry.npmjs.org/verror/-/verror-1.10.0.tgz"",
      ""integrity"": ""sha1-OhBcoXBTr1XW4nDB+CiGguGNpAA="",
      ""dev"": true,
      ""requires"": {{
        ""assert-plus"": ""1.0.0"",
        ""core-util-is"": ""1.0.2"",
        ""extsprintf"": ""1.3.0""
      }}
    }},
    ""vm-browserify"": {{
      ""version"": ""0.0.4"",
      ""resolved"": ""https://registry.npmjs.org/vm-browserify/-/vm-browserify-0.0.4.tgz"",
      ""integrity"": ""sha1-XX6kW7755Kb/ZflUOOCofDV9WnM="",
      ""dev"": true,
      ""requires"": {{
        ""indexof"": ""0.0.1""
      }}
    }},
    ""walker"": {{
      ""version"": ""1.0.7"",
      ""resolved"": ""https://registry.npmjs.org/walker/-/walker-1.0.7.tgz"",
      ""integrity"": ""sha1-L3+bj9ENZ3JisYqITijRlhjgKPs="",
      ""dev"": true,
      ""requires"": {{
        ""makeerror"": ""1.0.11""
      }}
    }},
    ""warning"": {{
      ""version"": ""3.0.0"",
      ""resolved"": ""https://registry.npmjs.org/warning/-/warning-3.0.0.tgz"",
      ""integrity"": ""sha1-MuU3fLVy3kqwR1O9+IIcAe1gW3w="",
      ""requires"": {{
        ""loose-envify"": ""1.3.1""
      }}
    }},
    ""watch"": {{
      ""version"": ""0.18.0"",
      ""resolved"": ""https://registry.npmjs.org/watch/-/watch-0.18.0.tgz"",
      ""integrity"": ""sha1-KAlUdsbffJDJYxOJkMClQj60uYY="",
      ""dev"": true,
      ""requires"": {{
        ""exec-sh"": ""0.2.1"",
        ""minimist"": ""1.2.0""
      }},
      ""dependencies"": {{
        ""minimist"": {{
          ""version"": ""1.2.0"",
          ""resolved"": ""https://registry.npmjs.org/minimist/-/minimist-1.2.0.tgz"",
          ""integrity"": ""sha1-o1AIsg9BOD7sH7kU9M1d95omQoQ="",
          ""dev"": true
        }}
      }}
    }},
    ""watchpack"": {{
      ""version"": ""1.4.0"",
      ""resolved"": ""https://registry.npmjs.org/watchpack/-/watchpack-1.4.0.tgz"",
      ""integrity"": ""sha1-ShRyvLuVK9Cpu0A2gB+VTfs5+qw="",
      ""dev"": true,
      ""requires"": {{
        ""async"": ""2.6.0"",
        ""chokidar"": ""1.7.0"",
        ""graceful-fs"": ""4.1.11""
      }}
    }},
    ""webidl-conversions"": {{
      ""version"": ""4.0.2"",
      ""resolved"": ""https://registry.npmjs.org/webidl-conversions/-/webidl-conversions-4.0.2.tgz"",
      ""integrity"": ""sha512-YQ+BmxuTgd6UXZW3+ICGfyqRyHXVlD5GtQr5+qjiNW7bF0cqrzX500HVXPBOvgXb5YnzDd+h0zqyv61KUD7+Sg=="",
      ""dev"": true
    }},
    ""webpack"": {{
      ""version"": ""3.10.0"",
      ""resolved"": ""https://registry.npmjs.org/webpack/-/webpack-3.10.0.tgz"",
      ""integrity"": ""sha512-fxxKXoicjdXNUMY7LIdY89tkJJJ0m1Oo8PQutZ5rLgWbV5QVKI15Cn7+/IHnRTd3vfKfiwBx6SBqlorAuNA8LA=="",
      ""dev"": true,
      ""requires"": {{
        ""acorn"": ""5.3.0"",
        ""acorn-dynamic-import"": ""2.0.2"",
        ""ajv"": ""5.5.2"",
        ""ajv-keywords"": ""2.1.1"",
        ""async"": ""2.6.0"",
        ""enhanced-resolve"": ""3.4.1"",
        ""escope"": ""3.6.0"",
        ""interpret"": ""1.1.0"",
        ""json-loader"": ""0.5.7"",
        ""json5"": ""0.5.1"",
        ""loader-runner"": ""2.3.0"",
        ""loader-utils"": ""1.1.0"",
        ""memory-fs"": ""0.4.1"",
        ""mkdirp"": ""0.5.1"",
        ""node-libs-browser"": ""2.1.0"",
        ""source-map"": ""0.5.7"",
        ""supports-color"": ""4.5.0"",
        ""tapable"": ""0.2.8"",
        ""uglifyjs-webpack-plugin"": ""0.4.6"",
        ""watchpack"": ""1.4.0"",
        ""webpack-sources"": ""1.1.0"",
        ""yargs"": ""8.0.2""
      }},
      ""dependencies"": {{
        ""acorn"": {{
          ""version"": ""5.3.0"",
          ""resolved"": ""https://registry.npmjs.org/acorn/-/acorn-5.3.0.tgz"",
          ""integrity"": ""sha512-Yej+zOJ1Dm/IMZzzj78OntP/r3zHEaKcyNoU2lAaxPtrseM6rF0xwqoz5Q5ysAiED9hTjI2hgtvLXitlCN1/Ug=="",
          ""dev"": true
        }},
        ""ajv"": {{
          ""version"": ""5.5.2"",
          ""resolved"": ""https://registry.npmjs.org/ajv/-/ajv-5.5.2.tgz"",
          ""integrity"": ""sha1-c7Xuyj+rZT49P5Qis0GtQiBdyWU="",
          ""dev"": true,
          ""requires"": {{
            ""co"": ""4.6.0"",
            ""fast-deep-equal"": ""1.0.0"",
            ""fast-json-stable-stringify"": ""2.0.0"",
            ""json-schema-traverse"": ""0.3.1""
          }}
        }},
        ""ajv-keywords"": {{
          ""version"": ""2.1.1"",
          ""resolved"": ""https://registry.npmjs.org/ajv-keywords/-/ajv-keywords-2.1.1.tgz"",
          ""integrity"": ""sha1-YXmX/F9gV2iUxDX5QNgZ4TW4B2I="",
          ""dev"": true
        }},
        ""ansi-regex"": {{
          ""version"": ""3.0.0"",
          ""resolved"": ""https://registry.npmjs.org/ansi-regex/-/ansi-regex-3.0.0.tgz"",
          ""integrity"": ""sha1-7QMXwyIGT3lGbAKWa922Bas32Zg="",
          ""dev"": true
        }},
        ""camelcase"": {{
          ""version"": ""4.1.0"",
          ""resolved"": ""https://registry.npmjs.org/camelcase/-/camelcase-4.1.0.tgz"",
          ""integrity"": ""sha1-1UVjW+HjPFQmScaRc+Xeas+uNN0="",
          ""dev"": true
        }},
        ""execa"": {{
          ""version"": ""0.7.0"",
          ""resolved"": ""https://registry.npmjs.org/execa/-/execa-0.7.0.tgz"",
          ""integrity"": ""sha1-lEvs00zEHuMqY6n68nrVpl/Fl3c="",
          ""dev"": true,
          ""requires"": {{
            ""cross-spawn"": ""5.1.0"",
            ""get-stream"": ""3.0.0"",
            ""is-stream"": ""1.1.0"",
            ""npm-run-path"": ""2.0.2"",
            ""p-finally"": ""1.0.0"",
            ""signal-exit"": ""3.0.2"",
            ""strip-eof"": ""1.0.0""
          }}
        }},
        ""find-up"": {{
          ""version"": ""2.1.0"",
          ""resolved"": ""https://registry.npmjs.org/find-up/-/find-up-2.1.0.tgz"",
          ""integrity"": ""sha1-RdG35QbHF93UgndaK3eSCjwMV6c="",
          ""dev"": true,
          ""requires"": {{
            ""locate-path"": ""2.0.0""
          }}
        }},
        ""has-flag"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/has-flag/-/has-flag-2.0.0.tgz"",
          ""integrity"": ""sha1-6CB68cx7MNRGzHC3NLXovhj4jVE="",
          ""dev"": true
        }},
        ""is-fullwidth-code-point"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/is-fullwidth-code-point/-/is-fullwidth-code-point-2.0.0.tgz"",
          ""integrity"": ""sha1-o7MKXE8ZkYMWeqq5O+764937ZU8="",
          ""dev"": true
        }},
        ""load-json-file"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/load-json-file/-/load-json-file-2.0.0.tgz"",
          ""integrity"": ""sha1-eUfkIUmvgNaWy/eXvKq8/h/inKg="",
          ""dev"": true,
          ""requires"": {{
            ""graceful-fs"": ""4.1.11"",
            ""parse-json"": ""2.2.0"",
            ""pify"": ""2.3.0"",
            ""strip-bom"": ""3.0.0""
          }}
        }},
        ""loader-utils"": {{
          ""version"": ""1.1.0"",
          ""resolved"": ""https://registry.npmjs.org/loader-utils/-/loader-utils-1.1.0.tgz"",
          ""integrity"": ""sha1-yYrvSIvM7aL/teLeZG1qdUQp9c0="",
          ""dev"": true,
          ""requires"": {{
            ""big.js"": ""3.2.0"",
            ""emojis-list"": ""2.1.0"",
            ""json5"": ""0.5.1""
          }}
        }},
        ""npm-run-path"": {{
          ""version"": ""2.0.2"",
          ""resolved"": ""https://registry.npmjs.org/npm-run-path/-/npm-run-path-2.0.2.tgz"",
          ""integrity"": ""sha1-NakjLfo11wZ7TLLd8jV7GHFTbF8="",
          ""dev"": true,
          ""requires"": {{
            ""path-key"": ""2.0.1""
          }}
        }},
        ""os-locale"": {{
          ""version"": ""2.1.0"",
          ""resolved"": ""https://registry.npmjs.org/os-locale/-/os-locale-2.1.0.tgz"",
          ""integrity"": ""sha512-3sslG3zJbEYcaC4YVAvDorjGxc7tv6KVATnLPZONiljsUncvihe9BQoVCEs0RZ1kmf4Hk9OBqlZfJZWI4GanKA=="",
          ""dev"": true,
          ""requires"": {{
            ""execa"": ""0.7.0"",
            ""lcid"": ""1.0.0"",
            ""mem"": ""1.1.0""
          }}
        }},
        ""path-key"": {{
          ""version"": ""2.0.1"",
          ""resolved"": ""https://registry.npmjs.org/path-key/-/path-key-2.0.1.tgz"",
          ""integrity"": ""sha1-QRyttXTFoUDTpLGRDUDYDMn0C0A="",
          ""dev"": true
        }},
        ""path-type"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/path-type/-/path-type-2.0.0.tgz"",
          ""integrity"": ""sha1-8BLMuEFbcJb8LaoQVMPXI4lZTHM="",
          ""dev"": true,
          ""requires"": {{
            ""pify"": ""2.3.0""
          }}
        }},
        ""read-pkg"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/read-pkg/-/read-pkg-2.0.0.tgz"",
          ""integrity"": ""sha1-jvHAYjxqbbDcZxPEv6xGMysjaPg="",
          ""dev"": true,
          ""requires"": {{
            ""load-json-file"": ""2.0.0"",
            ""normalize-package-data"": ""2.4.0"",
            ""path-type"": ""2.0.0""
          }}
        }},
        ""read-pkg-up"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/read-pkg-up/-/read-pkg-up-2.0.0.tgz"",
          ""integrity"": ""sha1-a3KoBImE4MQeeVEP1en6mbO1Sb4="",
          ""dev"": true,
          ""requires"": {{
            ""find-up"": ""2.1.0"",
            ""read-pkg"": ""2.0.0""
          }}
        }},
        ""source-map"": {{
          ""version"": ""0.5.7"",
          ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.5.7.tgz"",
          ""integrity"": ""sha1-igOdLRAh0i0eoUyA2OpGi6LvP8w="",
          ""dev"": true
        }},
        ""string-width"": {{
          ""version"": ""2.1.1"",
          ""resolved"": ""https://registry.npmjs.org/string-width/-/string-width-2.1.1.tgz"",
          ""integrity"": ""sha512-nOqH59deCq9SRHlxq1Aw85Jnt4w6KvLKqWVik6oA9ZklXLNIOlqg4F2yrT1MVaTjAqvVwdfeZ7w7aCvJD7ugkw=="",
          ""dev"": true,
          ""requires"": {{
            ""is-fullwidth-code-point"": ""2.0.0"",
            ""strip-ansi"": ""4.0.0""
          }}
        }},
        ""strip-ansi"": {{
          ""version"": ""4.0.0"",
          ""resolved"": ""https://registry.npmjs.org/strip-ansi/-/strip-ansi-4.0.0.tgz"",
          ""integrity"": ""sha1-qEeQIusaw2iocTibY1JixQXuNo8="",
          ""dev"": true,
          ""requires"": {{
            ""ansi-regex"": ""3.0.0""
          }}
        }},
        ""strip-bom"": {{
          ""version"": ""3.0.0"",
          ""resolved"": ""https://registry.npmjs.org/strip-bom/-/strip-bom-3.0.0.tgz"",
          ""integrity"": ""sha1-IzTBjpx1n3vdVv3vfprj1YjmjtM="",
          ""dev"": true
        }},
        ""supports-color"": {{
          ""version"": ""4.5.0"",
          ""resolved"": ""https://registry.npmjs.org/supports-color/-/supports-color-4.5.0.tgz"",
          ""integrity"": ""sha1-vnoN5ITexcXN34s9WRJQRJEvY1s="",
          ""dev"": true,
          ""requires"": {{
            ""has-flag"": ""2.0.0""
          }}
        }},
        ""which-module"": {{
          ""version"": ""2.0.0"",
          ""resolved"": ""https://registry.npmjs.org/which-module/-/which-module-2.0.0.tgz"",
          ""integrity"": ""sha1-2e8H3Od7mQK4o6j6SzHD4/fm6Ho="",
          ""dev"": true
        }},
        ""yargs"": {{
          ""version"": ""8.0.2"",
          ""resolved"": ""https://registry.npmjs.org/yargs/-/yargs-8.0.2.tgz"",
          ""integrity"": ""sha1-YpmpBVsc78lp/355wdkY3Osiw2A="",
          ""dev"": true,
          ""requires"": {{
            ""camelcase"": ""4.1.0"",
            ""cliui"": ""3.2.0"",
            ""decamelize"": ""1.2.0"",
            ""get-caller-file"": ""1.0.2"",
            ""os-locale"": ""2.1.0"",
            ""read-pkg-up"": ""2.0.0"",
            ""require-directory"": ""2.1.1"",
            ""require-main-filename"": ""1.0.1"",
            ""set-blocking"": ""2.0.0"",
            ""string-width"": ""2.1.1"",
            ""which-module"": ""2.0.0"",
            ""y18n"": ""3.2.1"",
            ""yargs-parser"": ""7.0.0""
          }}
        }},
        ""yargs-parser"": {{
          ""version"": ""7.0.0"",
          ""resolved"": ""https://registry.npmjs.org/yargs-parser/-/yargs-parser-7.0.0.tgz"",
          ""integrity"": ""sha1-jQrELxbqVd69MyyvTEA4s+P139k="",
          ""dev"": true,
          ""requires"": {{
            ""camelcase"": ""4.1.0""
          }}
        }}
      }}
    }},
    ""webpack-dev-middleware"": {{
      ""version"": ""1.12.2"",
      ""resolved"": ""https://registry.npmjs.org/webpack-dev-middleware/-/webpack-dev-middleware-1.12.2.tgz"",
      ""integrity"": ""sha512-FCrqPy1yy/sN6U/SaEZcHKRXGlqU0DUaEBL45jkUYoB8foVb6wCnbIJ1HKIx+qUFTW+3JpVcCJCxZ8VATL4e+A=="",
      ""dev"": true,
      ""requires"": {{
        ""memory-fs"": ""0.4.1"",
        ""mime"": ""1.6.0"",
        ""path-is-absolute"": ""1.0.1"",
        ""range-parser"": ""1.2.0"",
        ""time-stamp"": ""2.0.0""
      }},
      ""dependencies"": {{
        ""mime"": {{
          ""version"": ""1.6.0"",
          ""resolved"": ""https://registry.npmjs.org/mime/-/mime-1.6.0.tgz"",
          ""integrity"": ""sha512-x0Vn8spI+wuJ1O6S7gnbaQg8Pxh4NNHb7KSINmEWKiPE4RKOplvijn+NkmYmmRgP68mc70j2EbeTFRsrswaQeg=="",
          ""dev"": true
        }}
      }}
    }},
    ""webpack-dev-server"": {{
      ""version"": ""1.16.5"",
      ""resolved"": ""https://registry.npmjs.org/webpack-dev-server/-/webpack-dev-server-1.16.5.tgz"",
      ""integrity"": ""sha1-DL1fLSrI1OWTqs1clwLnu9XlmJI="",
      ""dev"": true,
      ""requires"": {{
        ""compression"": ""1.7.1"",
        ""connect-history-api-fallback"": ""1.5.0"",
        ""express"": ""4.16.2"",
        ""http-proxy-middleware"": ""0.17.4"",
        ""open"": ""0.0.5"",
        ""optimist"": ""0.6.1"",
        ""serve-index"": ""1.9.1"",
        ""sockjs"": ""0.3.19"",
        ""sockjs-client"": ""1.1.4"",
        ""stream-cache"": ""0.0.2"",
        ""strip-ansi"": ""3.0.1"",
        ""supports-color"": ""3.2.3"",
        ""webpack-dev-middleware"": ""1.12.2""
      }}
    }},
    ""webpack-hot-middleware"": {{
      ""version"": ""2.21.0"",
      ""resolved"": ""https://registry.npmjs.org/webpack-hot-middleware/-/webpack-hot-middleware-2.21.0.tgz"",
      ""integrity"": ""sha512-P6xiOLy10QlSVSO7GanU9PLxN6zLLQ7RG16MPTvmFwf2KUG7jMp6m+fmdgsR7xoaVVLA7OlX3YO6JjoZEKjCuA=="",
      ""dev"": true,
      ""requires"": {{
        ""ansi-html"": ""0.0.7"",
        ""html-entities"": ""1.2.1"",
        ""querystring"": ""0.2.0"",
        ""strip-ansi"": ""3.0.1""
      }}
    }},
    ""webpack-merge"": {{
      ""version"": ""0.7.3"",
      ""resolved"": ""https://registry.npmjs.org/webpack-merge/-/webpack-merge-0.7.3.tgz"",
      ""integrity"": ""sha1-9jbgpDcMeYc0U3IpKnlSLlxlonw="",
      ""dev"": true,
      ""requires"": {{
        ""lodash.find"": ""3.2.1"",
        ""lodash.isplainobject"": ""3.2.0"",
        ""lodash.merge"": ""3.3.2""
      }},
      ""dependencies"": {{
        ""lodash.merge"": {{
          ""version"": ""3.3.2"",
          ""resolved"": ""https://registry.npmjs.org/lodash.merge/-/lodash.merge-3.3.2.tgz"",
          ""integrity"": ""sha1-DZDZPtY3sYeEN7s+IWASYNev6ZQ="",
          ""dev"": true,
          ""requires"": {{
            ""lodash._arraycopy"": ""3.0.0"",
            ""lodash._arrayeach"": ""3.0.0"",
            ""lodash._createassigner"": ""3.1.1"",
            ""lodash._getnative"": ""3.9.1"",
            ""lodash.isarguments"": ""3.1.0"",
            ""lodash.isarray"": ""3.0.4"",
            ""lodash.isplainobject"": ""3.2.0"",
            ""lodash.istypedarray"": ""3.0.6"",
            ""lodash.keys"": ""3.1.2"",
            ""lodash.keysin"": ""3.0.8"",
            ""lodash.toplainobject"": ""3.0.0""
          }}
        }}
      }}
    }},
    ""webpack-sources"": {{
      ""version"": ""1.1.0"",
      ""resolved"": ""https://registry.npmjs.org/webpack-sources/-/webpack-sources-1.1.0.tgz"",
      ""integrity"": ""sha512-aqYp18kPphgoO5c/+NaUvEeACtZjMESmDChuD3NBciVpah3XpMEU9VAAtIaB1BsfJWWTSdv8Vv1m3T0aRk2dUw=="",
      ""dev"": true,
      ""requires"": {{
        ""source-list-map"": ""2.0.0"",
        ""source-map"": ""0.6.1""
      }},
      ""dependencies"": {{
        ""source-map"": {{
          ""version"": ""0.6.1"",
          ""resolved"": ""https://registry.npmjs.org/source-map/-/source-map-0.6.1.tgz"",
          ""integrity"": ""sha512-UjgapumWlbMhkBgzT7Ykc5YXUT46F0iKu8SGXq0bcwP5dz/h0Plj6enJqjz1Zbq2l5WaqYnrVbwWOWMyF3F47g=="",
          ""dev"": true
        }}
      }}
    }},
    ""websocket-driver"": {{
      ""version"": ""0.7.0"",
      ""resolved"": ""https://registry.npmjs.org/websocket-driver/-/websocket-driver-0.7.0.tgz"",
      ""integrity"": ""sha1-DK+dLXVdk67gSdS90NP+LMoqJOs="",
      ""dev"": true,
      ""requires"": {{
        ""http-parser-js"": ""0.4.9"",
        ""websocket-extensions"": ""0.1.3""
      }}
    }},
    ""websocket-extensions"": {{
      ""version"": ""0.1.3"",
      ""resolved"": ""https://registry.npmjs.org/websocket-extensions/-/websocket-extensions-0.1.3.tgz"",
      ""integrity"": ""sha512-nqHUnMXmBzT0w570r2JpJxfiSD1IzoI+HGVdd3aZ0yNi3ngvQ4jv1dtHt5VGxfI2yj5yqImPhOK4vmIh2xMbGg=="",
      ""dev"": true
    }},
    ""whatwg-encoding"": {{
      ""version"": ""1.0.3"",
      ""resolved"": ""https://registry.npmjs.org/whatwg-encoding/-/whatwg-encoding-1.0.3.tgz"",
      ""integrity"": ""sha512-jLBwwKUhi8WtBfsMQlL4bUUcT8sMkAtQinscJAe/M4KHCkHuUJAF6vuB0tueNIw4c8ziO6AkRmgY+jL3a0iiPw=="",
      ""dev"": true,
      ""requires"": {{
        ""iconv-lite"": ""0.4.19""
      }}
    }},
    ""whatwg-fetch"": {{
      ""version"": ""2.0.3"",
      ""resolved"": ""https://registry.npmjs.org/whatwg-fetch/-/whatwg-fetch-2.0.3.tgz"",
      ""integrity"": ""sha1-nITsLc9oGH/wC8ZOEnS0QhduHIQ=""
    }},
    ""whatwg-url"": {{
      ""version"": ""4.8.0"",
      ""resolved"": ""https://registry.npmjs.org/whatwg-url/-/whatwg-url-4.8.0.tgz"",
      ""integrity"": ""sha1-0pgaqRSMHgCkHFphMRZqtGg7vMA="",
      ""dev"": true,
      ""requires"": {{
        ""tr46"": ""0.0.3"",
        ""webidl-conversions"": ""3.0.1""
      }},
      ""dependencies"": {{
        ""webidl-conversions"": {{
          ""version"": ""3.0.1"",
          ""resolved"": ""https://registry.npmjs.org/webidl-conversions/-/webidl-conversions-3.0.1.tgz"",
          ""integrity"": ""sha1-JFNCdeKnvGvnvIZhHMFq4KVlSHE="",
          ""dev"": true
        }}
      }}
    }},
    ""whet.extend"": {{
      ""version"": ""0.9.9"",
      ""resolved"": ""https://registry.npmjs.org/whet.extend/-/whet.extend-0.9.9.tgz"",
      ""integrity"": ""sha1-+HfVv2SMl+WqVC+twW1qJZucEaE="",
      ""dev"": true
    }},
    ""which"": {{
      ""version"": ""1.3.0"",
      ""resolved"": ""https://registry.npmjs.org/which/-/which-1.3.0.tgz"",
      ""integrity"": ""sha512-xcJpopdamTuY5duC/KnTTNBraPK54YwpenP4lzxU8H91GudWpFv38u0CKjclE1Wi2EH2EDz5LRcHcKbCIzqGyg=="",
      ""dev"": true,
      ""requires"": {{
        ""isexe"": ""2.0.0""
      }}
    }},
    ""which-module"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/which-module/-/which-module-1.0.0.tgz"",
      ""integrity"": ""sha1-u6Y8qGGUiZT/MHc2CJ47lgJsKk8="",
      ""dev"": true
    }},
    ""wide-align"": {{
      ""version"": ""1.1.2"",
      ""resolved"": ""https://registry.npmjs.org/wide-align/-/wide-align-1.1.2.tgz"",
      ""integrity"": ""sha512-ijDLlyQ7s6x1JgCLur53osjm/UXUYD9+0PbYKrBsYisYXzCxN+HC3mYDNy/dWdmf3AwqwU3CXwDCvsNgGK1S0w=="",
      ""dev"": true,
      ""requires"": {{
        ""string-width"": ""1.0.2""
      }}
    }},
    ""window-size"": {{
      ""version"": ""0.1.0"",
      ""resolved"": ""https://registry.npmjs.org/window-size/-/window-size-0.1.0.tgz"",
      ""integrity"": ""sha1-VDjNLqk7IC76Ohn+iIeu58lPnJ0="",
      ""dev"": true
    }},
    ""wordwrap"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/wordwrap/-/wordwrap-1.0.0.tgz"",
      ""integrity"": ""sha1-J1hIEIkUVqQXHI0CJkQa3pDLyus="",
      ""dev"": true
    }},
    ""worker-farm"": {{
      ""version"": ""1.5.2"",
      ""resolved"": ""https://registry.npmjs.org/worker-farm/-/worker-farm-1.5.2.tgz"",
      ""integrity"": ""sha512-XxiQ9kZN5n6mmnW+mFJ+wXjNNI/Nx4DIdaAKLX1Bn6LYBWlN/zaBhu34DQYPZ1AJobQuu67S2OfDdNSVULvXkQ=="",
      ""dev"": true,
      ""requires"": {{
        ""errno"": ""0.1.6"",
        ""xtend"": ""4.0.1""
      }}
    }},
    ""wrap-ansi"": {{
      ""version"": ""2.1.0"",
      ""resolved"": ""https://registry.npmjs.org/wrap-ansi/-/wrap-ansi-2.1.0.tgz"",
      ""integrity"": ""sha1-2Pw9KE3QV5T+hJc8rs3Rz4JP3YU="",
      ""dev"": true,
      ""requires"": {{
        ""string-width"": ""1.0.2"",
        ""strip-ansi"": ""3.0.1""
      }}
    }},
    ""wrappy"": {{
      ""version"": ""1.0.2"",
      ""resolved"": ""https://registry.npmjs.org/wrappy/-/wrappy-1.0.2.tgz"",
      ""integrity"": ""sha1-tSQ9jz7BqjXxNkYFvA0QNuMKtp8="",
      ""dev"": true
    }},
    ""write"": {{
      ""version"": ""0.2.1"",
      ""resolved"": ""https://registry.npmjs.org/write/-/write-0.2.1.tgz"",
      ""integrity"": ""sha1-X8A4KOJkzqP+kUVUdvejxWbLB1c="",
      ""dev"": true,
      ""requires"": {{
        ""mkdirp"": ""0.5.1""
      }}
    }},
    ""xml-char-classes"": {{
      ""version"": ""1.0.0"",
      ""resolved"": ""https://registry.npmjs.org/xml-char-classes/-/xml-char-classes-1.0.0.tgz"",
      ""integrity"": ""sha1-ZGV4SKIP/F31g6Qq2KJ3tFErvE0="",
      ""dev"": true
    }},
    ""xml-name-validator"": {{
      ""version"": ""2.0.1"",
      ""resolved"": ""https://registry.npmjs.org/xml-name-validator/-/xml-name-validator-2.0.1.tgz"",
      ""integrity"": ""sha1-TYuPHszTQZqjYgYb7O9RXh5VljU="",
      ""dev"": true
    }},
    ""xtend"": {{
      ""version"": ""4.0.1"",
      ""resolved"": ""https://registry.npmjs.org/xtend/-/xtend-4.0.1.tgz"",
      ""integrity"": ""sha1-pcbVMr5lbiPbgg77lDofBJmNY68="",
      ""dev"": true
    }},
    ""y18n"": {{
      ""version"": ""3.2.1"",
      ""resolved"": ""https://registry.npmjs.org/y18n/-/y18n-3.2.1.tgz"",
      ""integrity"": ""sha1-bRX7qITAhnnA136I53WegR4H+kE="",
      ""dev"": true
    }},
    ""yallist"": {{
      ""version"": ""2.1.2"",
      ""resolved"": ""https://registry.npmjs.org/yallist/-/yallist-2.1.2.tgz"",
      ""integrity"": ""sha1-HBH5IY8HYImkfdUS+TxmmaaoHVI="",
      ""dev"": true
    }},
    ""yargs"": {{
      ""version"": ""7.1.0"",
      ""resolved"": ""https://registry.npmjs.org/yargs/-/yargs-7.1.0.tgz"",
      ""integrity"": ""sha1-a6MY6xaWFyf10oT46gA+jWFU0Mg="",
      ""dev"": true,
      ""requires"": {{
        ""camelcase"": ""3.0.0"",
        ""cliui"": ""3.2.0"",
        ""decamelize"": ""1.2.0"",
        ""get-caller-file"": ""1.0.2"",
        ""os-locale"": ""1.4.0"",
        ""read-pkg-up"": ""1.0.1"",
        ""require-directory"": ""2.1.1"",
        ""require-main-filename"": ""1.0.1"",
        ""set-blocking"": ""2.0.0"",
        ""string-width"": ""1.0.2"",
        ""which-module"": ""1.0.0"",
        ""y18n"": ""3.2.1"",
        ""yargs-parser"": ""5.0.0""
      }},
      ""dependencies"": {{
        ""camelcase"": {{
          ""version"": ""3.0.0"",
          ""resolved"": ""https://registry.npmjs.org/camelcase/-/camelcase-3.0.0.tgz"",
          ""integrity"": ""sha1-MvxLn82vhF/N9+c7uXysImHwqwo="",
          ""dev"": true
        }}
      }}
    }},
    ""yargs-parser"": {{
      ""version"": ""5.0.0"",
      ""resolved"": ""https://registry.npmjs.org/yargs-parser/-/yargs-parser-5.0.0.tgz"",
      ""integrity"": ""sha1-J17PDX/+Bcd+ZOfIbkzZS/DhIoo="",
      ""dev"": true,
      ""requires"": {{
        ""camelcase"": ""3.0.0""
      }},
      ""dependencies"": {{
        ""camelcase"": {{
          ""version"": ""3.0.0"",
          ""resolved"": ""https://registry.npmjs.org/camelcase/-/camelcase-3.0.0.tgz"",
          ""integrity"": ""sha1-MvxLn82vhF/N9+c7uXysImHwqwo="",
          ""dev"": true
        }}
      }}
    }}
  }}
}}";
        }
        
    }
}
