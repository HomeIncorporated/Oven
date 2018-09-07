using MasterBuilder.Interfaces;
using MasterBuilder.Request;
using System.Collections.Generic;
using System;
using System.Linq;
using MasterBuilder.Templates.React.Src.Containers.Sections;
using Humanizer;

namespace MasterBuilder.Templates.React.Src.Resources
{
    /// <summary>
    /// xList.jsx Template
    /// </summary>
    public class ListTemplate : ITemplate
    {
        private readonly Project Project;
        private readonly Screen Screen;

        /// <summary>
        /// Constructor
        /// </summary>
        public ListTemplate(Project project, Screen screen)
        {
            Project = project;
            Screen = screen;
        }

        /// <summary>
        /// Get file name
        /// </summary>
        public string GetFileName() => $"{Screen.Entity.InternalName}List.js";

        /// <summary>
        /// Get file path
        /// </summary>
        public string[] GetFilePath() => new string[] { "src", "resources", Screen.Entity.InternalNamePlural.Camelize() };

        /// <summary>
        /// Get file content
        /// </summary>
        public string GetFileContent()
        {
            var searchColumns = (from screenSection in Screen.ScreenSections
                                 where screenSection.ScreenSectionType == ScreenSectionType.Search
                                 select screenSection).First().SearchSection.SearchColumns;

            var fields = new List<string>();
            foreach (var searchColumn in searchColumns)
            {
                fields.Add($@"<TextField source=""{searchColumn.InternalNameJavascript}""/>");
            }

            return $@"import React from 'react';
import {{ List, Datagrid, TextField }} from 'react-admin';

export const {Screen.Entity.InternalName}List = (props) => (
    <List {{...props}} title=""{Screen.Title}"">
        <Datagrid>
{string.Join(Environment.NewLine, fields).IndentLines(12)}
        </Datagrid>
    </List>
);";
        }
    }
}