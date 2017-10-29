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
                $"          {{ path: '', redirectTo: '{defaultScreen.Path}', pathMatch: 'full' }}"
            };

            if (project.MenuItems != null)
            {
                foreach (var item in project.MenuItems)
                {
                    var screen = project.Screens.Where(s => s.Id == item.ScreenId.Value).FirstOrDefault();
                    // todo if screen is null error
                    
                    menuItems.Add($"            {{ path: '{screen.Path}', component: {screen.InternalName}Component }}");
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
import {{ HomeComponent }} from './components/home/home.component';
import {{ FetchDataComponent }} from './components/fetchdata/fetchdata.component';
import {{ CounterComponent }} from './components/counter/counter.component';

@NgModule({{
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        FetchDataComponent,
        HomeComponent
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