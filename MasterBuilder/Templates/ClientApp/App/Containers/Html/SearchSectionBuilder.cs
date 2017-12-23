using Humanizer;
using MasterBuilder.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterBuilder.Templates.ClientApp.App.Containers.Html
{
    public class SearchSectionBuilder
    {
        private readonly Project Project;
        private readonly Screen Screen;
        private readonly ScreenSection ScreenSection;

        public SearchSectionBuilder(Project project, Screen screen, ScreenSection screenSection)
        {
            Project = project;
            Screen = screen;
            ScreenSection = screenSection;
        }

        public string Evaluate()
        {
            var headings = new List<string>();
            var bindings = new List<string>();
            var menuItems = new List<string>();

            var entity = Project.Entities.SingleOrDefault(p => p.Id == ScreenSection.EntityId);

            foreach (var property in entity.Properties)
            {
                if (property.PropertyTemplate == PropertyTemplateEnum.PrimaryKey)
                {
                    continue;
                }
                else if (property.Type == PropertyTypeEnum.ParentRelationship)
                {
                    continue;
                }
                headings.Add($@"             <th data-property-id=""{property.Id}"" >{property.Title}</th>");
                bindings.Add($"             <td>{{{{ {Screen.InternalName.Camelize()}Item.{property.InternalName.Camelize()} }}}}</td>");
            }

            string navigateToScreen = null;
            Request.Screen foundParentScreen = null;
            if (ScreenSection.NavigateToScreenId.HasValue)
            {
                var navigateScreen = (from s in Project.Screens
                                      where s.Id == ScreenSection.NavigateToScreenId
                                      select s).FirstOrDefault();


                var parentProperty = (from p in entity.Properties
                                      where p.Type == PropertyTypeEnum.ParentRelationship
                                      select p).SingleOrDefault();
                if (parentProperty != null)
                {
                    foundParentScreen = (from s in Project.Screens
                                         where s.EntityId == parentProperty.ParentEntityId &&
                                         s.ScreenType == ScreenTypeEnum.Edit
                                         select s).SingleOrDefault();
                }

                if (navigateScreen != null)
                {
                    navigateToScreen = $@"[routerLink]=""['{(foundParentScreen != null ? "." : string.Empty)}/{navigateScreen.Path}', {Screen.InternalName.Camelize()}Item.id]""";
                }
            }

            if (ScreenSection.MenuItems != null)
            {
                foreach (var menuItem in ScreenSection.MenuItems)
                {
                    var screenTo = Project.Screens.SingleOrDefault(s => s.Id == menuItem.ScreenId);
                    menuItems.Add($@"<a [routerLink]=""['{(foundParentScreen != null ? "." : string.Empty)}/{screenTo.Path}']"">
                        <span class='{menuItem.Icon}'></span> {menuItem.Title}
                     </a>");
                }
            }

            var navigateToScreenPath = (from s in Project.Screens
                                        where s.Id == Screen.NavigateToScreenId
                                        select s.Path).FirstOrDefault();
            if (!string.IsNullOrWhiteSpace(navigateToScreenPath))
            {
                menuItems.Add($@"<a [routerLink]=""['/{navigateToScreenPath}']"">New</a>");
            }
            return $@"<div class=""screen-type-search"">
<nav>
    
{string.Join(Environment.NewLine, menuItems)}
</nav>
<div>
<p *ngIf=""!{ScreenSection.InternalName.Camelize()}Response""><em>Loading...</em></p>

<table class='table' *ngIf=""{ScreenSection.InternalName.Camelize()}Response && {ScreenSection.InternalName.Camelize()}Response.items"">
    <thead>
        <tr>
{string.Join(Environment.NewLine, headings)}
        </tr>
    </thead>
    <tbody>
        <tr [attr.data-id]=""{Screen.InternalName.Camelize()}Item.id"" *ngFor=""let {Screen.InternalName.Camelize()}Item of {ScreenSection.InternalName.Camelize()}Response.items"" {navigateToScreen}>
{string.Join(Environment.NewLine, bindings)}
        </tr>
    </tbody>
</table>
</div>
</div>";
        }
        }
}
