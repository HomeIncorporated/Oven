﻿using MasterBuilder.Request;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MasterBuilder.Templates.ClientApp.Components.Screen
{
    public class ScreenComponentTsTemplate
    {
        public static string FileName(string folder, Request.Screen screen)
        {
            return Path.Combine(FileHelper.CreateFolder(folder, Path.Combine("app", "components", screen.InternalName.ToLowerInvariant())), $"{screen.InternalName.ToLowerInvariant()}.component.ts");
        }

        public static string Evaluate(Project project, Request.Screen screen)
        {
            var imports = new List<string>();
            var classProperties = new List<string>();
            var classes = new List<string>();
            var functions = new List<string>();

            switch (screen.ScreenType)
            {
                case ScreenTypeEnum.Search:
                    imports.AddRange(ScreenTypeSearchTsTemplate.Imports(project, screen));
                    classProperties.AddRange(ScreenTypeSearchTsTemplate.ClassProperties(project, screen));
                    classes.AddRange(ScreenTypeSearchTsTemplate.Classes(project, screen));
                    functions.Add(ScreenTypeSearchTsTemplate.Evaluate(project, screen));
                    break;
                case ScreenTypeEnum.Edit:
                    imports.AddRange(ScreenTypeEditTsTemplate.Imports(project, screen));
                    classProperties.AddRange(ScreenTypeEditTsTemplate.ClassProperties(project, screen));
                    classes.AddRange(ScreenTypeEditTsTemplate.Classes(project, screen));
                    functions.Add(ScreenTypeEditTsTemplate.Evaluate(project, screen));
                    break;
                case ScreenTypeEnum.View:
                    break;
                case ScreenTypeEnum.Html:
                    break;
                default:
                    break;
            }

            string cssFile = null;
            if (!string.IsNullOrEmpty(screen.Css))
            {
                cssFile = $@",
    styleUrls: ['./{screen.InternalName.ToLowerInvariant()}.component.css']";
            }

            return $@"import {{ Http }} from '@angular/http';
import {{ Component, Inject, OnInit }} from '@angular/core';
import {{ Router, ActivatedRoute }} from '@angular/router';
{string.Join(Environment.NewLine, imports.Distinct())}

@Component({{
    selector: '{screen.InternalName.ToLowerInvariant()}',
    templateUrl: './{screen.InternalName.ToLowerInvariant()}.component.html'{cssFile}
}})
export class {screen.InternalName}Component implements OnInit {{
{string.Join(string.Concat(Environment.NewLine, "    "), classProperties)}

{string.Join(Environment.NewLine, functions)}
}}

{string.Join(Environment.NewLine, classes)}";
        }
    }
}