#pragma checksum "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Profile\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2dab08f227236c8625d407d041e8b0575a18577"
// <auto-generated/>
#pragma warning disable 1591
namespace Family.Pages.Profile
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Family;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Family.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Profile\Profile.razor"
using Family.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Profile")]
    public partial class Profile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "inputininininininiinininfoermonSubin\r\n");
            __builder.OpenElement(1, "section");
            __builder.AddAttribute(2, "class", "profile");
            __builder.AddAttribute(3, "b-j15f2hbp8y");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "profile-info");
            __builder.AddAttribute(6, "b-j15f2hbp8y");
            __builder.OpenElement(7, "h2");
            __builder.AddAttribute(8, "class", "heading");
            __builder.AddAttribute(9, "b-j15f2hbp8y");
            __builder.AddContent(10, "Hello, ");
            __builder.AddContent(11, 
#nullable restore
#line 8 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Profile\Profile.razor"
                                    username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "form");
            __builder.AddAttribute(14, "name", "profile");
            __builder.AddAttribute(15, "class", "form");
            __builder.AddAttribute(16, "b-j15f2hbp8y");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "form-data__group");
            __builder.AddAttribute(19, "b-j15f2hbp8y");
            __builder.AddMarkupContent(20, "<label b-j15f2hbp8y>Username:</label>\r\n                ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "class", "input");
            __builder.AddAttribute(23, "value", 
#nullable restore
#line 14 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Profile\Profile.razor"
                            username

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "disabled", "disabled");
            __builder.AddAttribute(25, "b-j15f2hbp8y");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "form-data__group");
            __builder.AddAttribute(29, "b-j15f2hbp8y");
            __builder.AddMarkupContent(30, "<label b-j15f2hbp8y>Role:</label>\r\n                ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "class", "input");
            __builder.AddAttribute(33, "value", 
#nullable restore
#line 21 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Profile\Profile.razor"
                            role

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(34, "disabled", "disabled");
            __builder.AddAttribute(35, "b-j15f2hbp8y");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form-data__group");
            __builder.AddAttribute(39, "b-j15f2hbp8y");
            __builder.AddMarkupContent(40, "<label b-j15f2hbp8y>City:</label>\r\n                ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "class", "input");
            __builder.AddAttribute(43, "disabled", "disabled");
            __builder.AddAttribute(44, "value", 
#nullable restore
#line 29 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Profile\Profile.razor"
                            city

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(45, "b-j15f2hbp8y");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "button-wrapper");
            __builder.AddAttribute(49, "b-j15f2hbp8y");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "type", "button");
            __builder.AddAttribute(52, "class", "logout-button");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Profile\Profile.razor"
                                                                  Logout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "b-j15f2hbp8y");
            __builder.AddContent(55, "Log Out");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Profile\Profile.razor"
      
    private string username;
    private string city;
    private string role;


    protected override void OnInitialized()
    {
        base.OnInitialized();
        username = ((CustomAuthenticationStateProvider) AuthenticationStateProvider).GetCachedUser().UserName;
        city = ((CustomAuthenticationStateProvider) AuthenticationStateProvider).GetCachedUser().City;
        role = ((CustomAuthenticationStateProvider) AuthenticationStateProvider).GetCachedUser().Role;
    }

    public void Logout()
    {
        ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
        NavigationManager.NavigateTo("/login");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
