﻿using MasterBuilder.Request;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MasterBuilder.Templates.ClientApp.app
{
    public class AppModuleSharedTsTemplate
    {
        public static string FileName(string folder)
        {
            return Path.Combine(FileHelper.CreateFolder(folder, "app"), "app.module.shared.ts");
        }

        public static string Evaluate(Project project)
        {
            var defaultScreen = project.Screens.Where(s => s.Id == project.DefaultScreenId).FirstOrDefault();
            var menuItems = new List<string>
            {
                $"           {{ path: '', redirectTo: '{defaultScreen.Path}', pathMatch: 'full' }}"
            };
            

            var componentImports = new List<string>();
            var declarations = new List<string>
            {
                "AppComponent",
                "NavMenuComponent",
                "CounterComponent",
                "FetchDataComponent",
                "HomeComponent"
            };
            foreach (var screen in project.Screens) //.Where(s => s.ScreenType == ScreenTypeEnum.Search || s.ScreenType == ScreenTypeEnum.Edit))
            {
                componentImports.Add($"import {{ {screen.InternalName}Component }} from './components/{screen.InternalName.ToCamlCase()}/{screen.InternalName.ToCamlCase()}.component';");
                declarations.Add($"{screen.InternalName}Component");

                if (!string.IsNullOrEmpty(screen.Path))
                {
                    if (screen.ScreenType == ScreenTypeEnum.Edit)
                    {
                        menuItems.Add($"            {{ path: '{screen.Path}/:id', component: {screen.InternalName}Component }}");

                        // TODO make optional
                        menuItems.Add($"            {{ path: '{screen.Path}', component: {screen.InternalName}Component }}");
                    }
                    else
                    {
                        menuItems.Add($"            {{ path: '{screen.Path}', component: {screen.InternalName}Component }}");
                    }
                }
            }

            menuItems.Add($"            {{ path: '**', redirectTo: '{defaultScreen.Path}' }}");

            return $@"import {{ NgModule }} from '@angular/core';
import {{ CommonModule }} from '@angular/common';
import {{ FormsModule }} from '@angular/forms';
import {{ HttpModule }} from '@angular/http';
import {{ RouterModule }} from '@angular/router';

import {{ AppComponent }} from './components/app/app.component';
import {{ NavMenuComponent }} from './components/navmenu/navmenu.component';
{string.Join(Environment.NewLine, componentImports)}

@NgModule({{
    declarations: [
{string.Join(string.Concat(",", Environment.NewLine, "        "), declarations)}
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
{string.Join(string.Concat(",", Environment.NewLine), menuItems)}
        ])
    ]
}})
export class AppModuleShared {{
}}
";
        }
    }
}