#pragma checksum "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\AddAdult\AddAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9aff4e651812cd1fa0b4ba410f6ded62739a4f7c"
// <auto-generated/>
#pragma warning disable 1591
namespace Family.Pages.AddAdult
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
#line 3 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\AddAdult\AddAdult.razor"
using Family.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\AddAdult\AddAdult.razor"
using Family.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\AddAdult\AddAdult.razor"
using Family.Persistence;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\AddAdult\AddAdult.razor"
using global::Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addAdult")]
    public partial class AddAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Add Adult</h3>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "form-group");
            __builder.AddMarkupContent(5, "<label class=\"label\" for=\"fname\">First name</label>\r\n            ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "class", "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "id", "fname");
            __builder.AddAttribute(10, "name", "fname");
            __builder.AddAttribute(11, "placeholder", "First name");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\AddAdult\AddAdult.razor"
                                 fname

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fname = __value, fname));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label class=\"label\" for=\"lname\">Last name</label>\r\n            ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "class", "input");
            __builder.AddAttribute(20, "type", "text");
            __builder.AddAttribute(21, "id", "lname");
            __builder.AddAttribute(22, "name", "lname");
            __builder.AddAttribute(23, "placeholder", "Last name");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\AddAdult\AddAdult.razor"
                                 lname

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lname = __value, lname));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "form-group");
            __builder.AddMarkupContent(29, "<label class=\"label\" for=\"age\">Age</label>\r\n            ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "class", "input");
            __builder.AddAttribute(32, "type", "number");
            __builder.AddAttribute(33, "id", "age");
            __builder.AddAttribute(34, "name", "age");
            __builder.AddAttribute(35, "placeholder", "Age");
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\AddAdult\AddAdult.razor"
                                                                                                   age

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => age = __value, age, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "form-group");
            __builder.AddMarkupContent(41, "<label class=\"label\" for=\"sex\">Sex</label>\r\n            ");
            __builder.OpenElement(42, "select");
            __builder.AddAttribute(43, "class", "input");
            __builder.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\AddAdult\AddAdult.razor"
                                          sex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sex = __value, sex));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(46, "option");
            __builder.AddAttribute(47, "value");
            __builder.AddMarkupContent(48, "\r\n                    Select gender\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "option");
            __builder.AddAttribute(51, "value", "M");
            __builder.AddMarkupContent(52, "\r\n                    M\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.OpenElement(54, "option");
            __builder.AddAttribute(55, "value", "F");
            __builder.AddMarkupContent(56, "\r\n                    F\r\n                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n\r\n        ");
            __builder.OpenElement(58, "div");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "form-group");
            __builder.AddMarkupContent(61, "<label class=\"label\" for=\"hair-color\">Hair color</label>\r\n                ");
            __builder.OpenElement(62, "input");
            __builder.AddAttribute(63, "class", "input");
            __builder.AddAttribute(64, "type", "text");
            __builder.AddAttribute(65, "id", "hair-color");
            __builder.AddAttribute(66, "name", "hair-color");
            __builder.AddAttribute(67, "placeholder", "Hair color");
            __builder.AddAttribute(68, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\AddAdult\AddAdult.razor"
                                     hairColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => hairColor = __value, hairColor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n            ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "form-group");
            __builder.AddMarkupContent(73, "<label class=\"label\" for=\"eye-color\">Eye color</label>\r\n                ");
            __builder.OpenElement(74, "input");
            __builder.AddAttribute(75, "class", "input");
            __builder.AddAttribute(76, "type", "text");
            __builder.AddAttribute(77, "id", "eye-color");
            __builder.AddAttribute(78, "name", "eye-color");
            __builder.AddAttribute(79, "placeholder", "Eye color");
            __builder.AddAttribute(80, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\AddAdult\AddAdult.razor"
                                     eyeColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => eyeColor = __value, eyeColor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n            ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "form-group");
            __builder.AddMarkupContent(85, "<label class=\"label\" for=\"height\">Height</label>\r\n                ");
            __builder.OpenElement(86, "input");
            __builder.AddAttribute(87, "class", "input");
            __builder.AddAttribute(88, "type", "text");
            __builder.AddAttribute(89, "id", "height");
            __builder.AddAttribute(90, "name", "height");
            __builder.AddAttribute(91, "placeholder", "Height");
            __builder.AddAttribute(92, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 59 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\AddAdult\AddAdult.razor"
                                     height

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(93, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => height = __value, height));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n            ");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "form-group");
            __builder.AddMarkupContent(97, "<label class=\"label\" for=\"weight\">Weight</label>\r\n                ");
            __builder.OpenElement(98, "input");
            __builder.AddAttribute(99, "class", "input");
            __builder.AddAttribute(100, "type", "text");
            __builder.AddAttribute(101, "id", "weight");
            __builder.AddAttribute(102, "name", "weight");
            __builder.AddAttribute(103, "placeholder", "Weight");
            __builder.AddAttribute(104, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 64 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\AddAdult\AddAdult.razor"
                                     weight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(105, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => weight = __value, weight));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n        ");
            __builder.OpenElement(107, "div");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "form-group");
            __builder.AddMarkupContent(110, "<label class=\"label\" for=\"job\">Job</label>\r\n                ");
            __builder.OpenElement(111, "input");
            __builder.AddAttribute(112, "class", "input");
            __builder.AddAttribute(113, "type", "text");
            __builder.AddAttribute(114, "id", "job");
            __builder.AddAttribute(115, "name", "job");
            __builder.AddAttribute(116, "placeholder", "Job");
            __builder.AddAttribute(117, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\AddAdult\AddAdult.razor"
                                                                                                     job

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(118, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => job = __value, job));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n            ");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "form-group");
            __builder.AddMarkupContent(122, "<label class=\"label\" for=\"salary\">Salary</label>\r\n                ");
            __builder.OpenElement(123, "input");
            __builder.AddAttribute(124, "class", "input");
            __builder.AddAttribute(125, "type", "text");
            __builder.AddAttribute(126, "id", "salary");
            __builder.AddAttribute(127, "name", "salary");
            __builder.AddAttribute(128, "placeholder", "Salary");
            __builder.AddAttribute(129, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\AddAdult\AddAdult.razor"
                                     salary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(130, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => salary = __value, salary));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n    ");
            __builder.OpenElement(132, "button");
            __builder.AddAttribute(133, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 79 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\AddAdult\AddAdult.razor"
                      Submit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(134, "onclick", 
#nullable restore
#line 79 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\AddAdult\AddAdult.razor"
                                                       true

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(135, "Submit");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\AddAdult\AddAdult.razor"
      
    private string fname;
    private string lname;
    private string age;
    private string hairColor;
    private string eyeColor;
    private string weight;
    private string height;
    private string sex;
    private string job;
    private string salary;
    private string street;
    private string houseNr;

    public void Submit()
    {
        var Adult = new Adult();
        Adult.FirstName = fname;
        Adult.LastName = lname;
        Adult.HairColor = hairColor;
        Adult.EyeColor = eyeColor;
        Adult.Age = Int32.Parse(age);
        Adult.Weight = float.Parse(weight);
        Adult.Height = Int32.Parse(height);
        Adult.Sex = sex;
        var Job = new Job();
        Job.JobTitle = job;
        Job.Salary = Int32.Parse(salary);
        Adult.JobTitle = Job;

        var id = FileContext.Adults.Last<Adult>().Id;
        Adult.Id = id + 1;

        adultData.AddAdult(Adult);

        NavigationManager.NavigateTo("/adults");
    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FileContext FileContext { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService adultData { get; set; }
    }
}
#pragma warning restore 1591
