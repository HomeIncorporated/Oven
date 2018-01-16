using Humanizer;
using MasterBuilder.Interfaces;
using MasterBuilder.Request;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterBuilder.Templates.Controllers
{
    /// <summary>
    /// Controller Template
    /// </summary>
    public class ControllerTemplate : ITemplate
    {
        private readonly Project Project;
        private readonly Screen Screen;

        /// <summary>
        /// Constructor
        /// </summary>
        public ControllerTemplate(Project project, Screen screen)
        {
            Project = project;
            Screen = screen;
        }

        /// <summary>
        /// Get file name
        /// </summary>
        public string GetFileName()
        {
            return $"{Screen.InternalName}Controller.cs";
        }

        /// <summary>
        /// Get file path
        /// </summary>
        public string[] GetFilePath()
        {
            return new string[] { "Controllers" };
        }

        /// <summary>
        /// Get file content
        /// </summary>
        public string GetFileContent()
        {
            var usings = new List<string>();
            var methods = new List<string>();
            var classAttributes = @"[Route(""api/[controller]"")]";
            var hasServerFunction = false;

            var privateFields = new List<string>
            {
                $@"        /// <summary>
        /// Database Context
        /// </summary>
        private readonly {Project.InternalName}Context _context;"
            };
            var constructorParameters = new List<string>
            {
                $"{Project.InternalName}Context context"
            };
            var constructorFieldMappings = new List<string>
            {
                "_context = context;"
            };


            // TODO: put this back in
            /*var lookupMethod = ControllerReferenceMethodTemplate.Evaluate(Project, Entity);
            if (!string.IsNullOrEmpty(lookupMethod))
            {
                methods.Add(lookupMethod);
            }*/
            var referenceFormFields = new List<FormField>();
            foreach (var screenSection in Screen.ScreenSections)
            {
                switch (screenSection.ScreenSectionType)
                {
                    case ScreenSectionTypeEnum.Search:
                        usings.Add("using Microsoft.AspNetCore.JsonPatch;");
                        methods.Add(ControllerSearchMethodTemplate.Evaluate(Project, Screen, screenSection));
                        break;
                    case ScreenSectionTypeEnum.Form:
                        methods.Add(ControllerEditMethodTemplate.Evaluate(Project, Screen, screenSection));

                        referenceFormFields.AddRange(screenSection.FormSection.FormFields.Where(a => a.PropertyType == PropertyTypeEnum.ReferenceRelationship));
                        break;
                    default:
                        break;
                }

                if (screenSection.MenuItems != null)
                {
                    foreach (var menuItem in screenSection.MenuItems)
                    {
                        switch (menuItem.MenuItemType)
                        {
                            case MenuItemTypeEnum.ServerFunction:
                                hasServerFunction = true;
                                methods.Add($@"        /// <summary>
        /// Menu Item {menuItem.Title} called function
        /// </summary>
        [HttpGet(""{Screen.InternalName}{screenSection.InternalName}{menuItem.InternalName}/{{id}}"")]
        public async Task<IActionResult> {Screen.InternalName}{screenSection.InternalName}{menuItem.InternalName}(Guid id)
        {{
            {menuItem.ServerCode}
        }}");
                                break;
                        }
                    }
                }
            }

            foreach (var referenceFormField in referenceFormFields)
            {

            }


            if (hasServerFunction)
            {
                var serviceNames = new Services.ServiceTemplateBuilder(Project).GetServiceNames();
                foreach (var serviceName in serviceNames)
                {
                    privateFields.Add($@"        /// <summary>
        /// {serviceName}
        /// </summary>
        private readonly I{serviceName} _{serviceName.Camelize()};");

                    constructorParameters.Add($"I{serviceName} {serviceName.Camelize()}");
                    constructorFieldMappings.Add($"_{serviceName.Camelize()} = {serviceName.Camelize()};");
                }
            }

            // TODO: Build site map
            if (Screen != null)
            {
                if (Screen.Template == ScreenTemplateEnum.Home)
                {
                    methods.Add($@"                /// <summary>
    /// Home Index
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> Index()
    {{
        var prerenderResult = await Request.BuildPrerender();

        ViewData[""SpaHtml""] = prerenderResult.Html; // our <app-root /> from Angular
        ViewData[""Styles""] = prerenderResult.Globals[""styles""]; // put styles in the correct place
        ViewData[""Scripts""] = prerenderResult.Globals[""scripts""]; // scripts (that were in our header)
        ViewData[""Meta""] = prerenderResult.Globals[""meta""]; // set our <meta> SEO tags
        ViewData[""Links""] = prerenderResult.Globals[""links""]; // set our <link rel=""canonical""> etc SEO tags
        ViewData[""TransferData""] = prerenderResult.Globals[""transferData""]; // our transfer data set to window.TRANSFER_CACHE = {{}};
        ViewData[""Title""] = prerenderResult.Globals[""title""]; // set our <title> from Angular
        
        return View();
    }}

    /// <summary>
    /// Sitemap Xml
    /// </summary>
    [HttpGet]
    [Route(""sitemap.xml"")]
    public IActionResult SitemapXml()
    {{
        var xml = $@""<?xml version=\""""1.0\"""" encoding=\""""utf-8\""""?>
<sitemapindex xmlns=\""""http://www.sitemaps.org/schemas/sitemap/0.9\"""">
    <sitemap>
        <loc>http://localhost:4251/home</loc>
        <lastmod>{{DateTime.Now.ToString(""yyyy-MM-dd"")}}</lastmod>
    </sitemap>
    <sitemap>
        <loc>http://localhost:4251/counter</loc>
        <lastmod>{{DateTime.Now.ToString(""yyyy-MM-dd"")}}</lastmod>
    </sitemap>
</sitemapindex>"";

        return Content(xml, ""text/xml"");

    }}

    /// <summary>
    /// Error page
    /// </summary>
    public IActionResult Error()
    {{
        return View();
    }}");
                    usings.Add($"using {Project.InternalName}.CoreModels;");
                    usings.Add($"using {Project.InternalName}.Extensions;");
                    classAttributes = null;
                }
            } 

            return $@"using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using {Project.InternalName}.Models;
using {Project.InternalName}.Entities;
using {Project.InternalName}.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
{string.Join(Environment.NewLine, usings.Distinct())}

namespace {Project.InternalName}.Controllers
{{

    /// <summary>
    /// Controller for the {Screen.Title} Screen
    /// </summary>
    {classAttributes}
    public class {Screen.InternalName}Controller : Controller
    {{
{string.Join(Environment.NewLine, privateFields)}

        /// <summary>
        /// Constructor
        /// </summary>
        public {Screen.InternalName}Controller({string.Join(string.Concat(",", Environment.NewLine, "          "), constructorParameters)})
        {{
            {string.Join(string.Concat(Environment.NewLine, "            "), constructorFieldMappings)}
        }}
{string.Join(Environment.NewLine, methods)}
    }}
}}";
        }
    }
}
