#pragma checksum "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1ea9c2837cff2f06dc23ab98da9bb9162c3befa"
// <auto-generated/>
#pragma warning disable 1591
namespace Family.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Family;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Family.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\Shared\MainLayout.razor"
using Family.Shared.Components.NavMenu;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-dy4wxczd3d");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "main");
            __builder.AddAttribute(5, "b-dy4wxczd3d");
            __builder.OpenComponent<Family.Shared.Components.NavMenu.NavMenu>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "style", "min-height: 100vh");
            __builder.AddAttribute(10, "class", "content px-4");
            __builder.AddAttribute(11, "b-dy4wxczd3d");
            __builder.AddContent(12, 
#nullable restore
#line 11 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
