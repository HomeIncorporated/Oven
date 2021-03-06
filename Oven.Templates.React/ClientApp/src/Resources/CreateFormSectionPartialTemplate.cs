﻿using Humanizer;
using Oven.Request;
using Oven.Templates.React.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oven.Templates.React.ClientApp.Src.Resources
{
    /// <summary>
    /// Input Field Template
    /// </summary>
    public class CreateFormSectionPartialTemplate
    {
        private readonly Screen Screen;
        private readonly ScreenSection ScreenSection;
        public IEnumerable<string> Imports { get; private set; }
        public IEnumerable<string> Constants { get; private set; }
        public string Content { get; private set; }
        public bool Blank { get; private set; } = true;

        /// <summary>
        /// Constructor
        /// </summary>
        public CreateFormSectionPartialTemplate(Screen screen, ScreenSection screenSection)
        {
            Screen = screen;
            ScreenSection = screenSection;

            Evaluate();
        }

        private void Evaluate()
        {
            var fields = new List<string>();
            var imports = new List<string>();
            var constants = new List<string>();

            var source = "";
            if (ScreenSection.ParentScreenSectionId.HasValue)
            {
                source = $@"{ScreenSection.Entity.InternalName.Camelize()}.";
            }

            foreach (var field in ScreenSection.FormSection.FormFields)
            {
                if (field.PropertyType == PropertyType.PrimaryKey)
                {
                    // dont render primary key
                    continue;
                }
                else if (field.PropertyType == PropertyType.ParentRelationshipOneToMany)
                {
                    // dont render parent relationship
                    continue;
                }
                else if (field.IsHiddenFromUi)
                {
                    // dont render hidden fields
                    continue;
                }
                var template = new CreateEditInputPartialTemplate(Screen, field, source);
                fields.Add(template.Content());
                imports.AddRange(template.ReactAdminImports());
                constants.AddRange(template.Constants);

                if (template.WrapInFormDataConsumer)
                {
                    imports.Add("FormDataConsumer");
                }
            }
            if (fields.Any())
            {
                Content = string.Join(Environment.NewLine, fields);
                Blank = false;
            }

            Imports = imports;
            Constants = constants;
        }
    }
}
