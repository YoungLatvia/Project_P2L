#pragma checksum "C:\Users\bruger\RiderProjects\Project_P2L\WebApplication\Pages\Resources.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d02510304107dd07ecacd4b4e835de98adfc2fe"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bruger\RiderProjects\Project_P2L\WebApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bruger\RiderProjects\Project_P2L\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bruger\RiderProjects\Project_P2L\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bruger\RiderProjects\Project_P2L\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bruger\RiderProjects\Project_P2L\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bruger\RiderProjects\Project_P2L\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bruger\RiderProjects\Project_P2L\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bruger\RiderProjects\Project_P2L\WebApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bruger\RiderProjects\Project_P2L\WebApplication\_Imports.razor"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bruger\RiderProjects\Project_P2L\WebApplication\_Imports.razor"
using WebApplication.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Resources : ResourcesBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Resources</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.OpenElement(2, "table");
            __builder.AddMarkupContent(3, "<thead><tr><th>ID</th>\r\n            <th>Name</th>\r\n            <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 15 "C:\Users\bruger\RiderProjects\Project_P2L\WebApplication\Pages\Resources.razor"
         if (Resources == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<div class=\"spinner\"></div>");
#nullable restore
#line 20 "C:\Users\bruger\RiderProjects\Project_P2L\WebApplication\Pages\Resources.razor"
              
        }
        else if (!Resources.Any())
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p><em>No resource items exist. Please add some.</em></p>");
#nullable restore
#line 27 "C:\Users\bruger\RiderProjects\Project_P2L\WebApplication\Pages\Resources.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\bruger\RiderProjects\Project_P2L\WebApplication\Pages\Resources.razor"
             foreach (var resource in Resources)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 33 "C:\Users\bruger\RiderProjects\Project_P2L\WebApplication\Pages\Resources.razor"
                         resource.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 34 "C:\Users\bruger\RiderProjects\Project_P2L\WebApplication\Pages\Resources.razor"
                         resource.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    <td></td>\r\n                    <td></td>");
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\bruger\RiderProjects\Project_P2L\WebApplication\Pages\Resources.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\bruger\RiderProjects\Project_P2L\WebApplication\Pages\Resources.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
