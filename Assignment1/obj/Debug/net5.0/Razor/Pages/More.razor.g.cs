#pragma checksum "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\Pages\More.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7234d74bf400b52fd5b40f8dc65bac511b77d41a"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\Pages\More.razor"
using Assignment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\Pages\More.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/More/{Id:int}")]
    public partial class More : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#nullable restore
#line 7 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\Pages\More.razor"
     Adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(2, " ");
            __builder.AddContent(3, 
#nullable restore
#line 7 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\Pages\More.razor"
                      Adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 9 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\Pages\More.razor"
 if (Adult == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<em>The person is not found!</em>");
#nullable restore
#line 12 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\Pages\More.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, "ID: ");
            __builder.AddContent(7, 
#nullable restore
#line 15 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\Pages\More.razor"
            Adult.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "p");
            __builder.AddContent(10, "Hair Color: ");
            __builder.AddContent(11, 
#nullable restore
#line 16 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\Pages\More.razor"
                    Adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "p");
            __builder.AddContent(14, "Eye Color: ");
            __builder.AddContent(15, 
#nullable restore
#line 17 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\Pages\More.razor"
                   Adult.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "p");
            __builder.AddContent(18, "Age: ");
            __builder.AddContent(19, 
#nullable restore
#line 18 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\Pages\More.razor"
             Adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "p");
            __builder.AddContent(22, "Weight: ");
            __builder.AddContent(23, 
#nullable restore
#line 19 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\Pages\More.razor"
                Adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(24, " kg");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.OpenElement(26, "p");
            __builder.AddContent(27, "Height: ");
            __builder.AddContent(28, 
#nullable restore
#line 20 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\Pages\More.razor"
                Adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(29, " cm");
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\Pages\More.razor"
     if (Adult.Sex.Equals("M"))
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "<p>Sex: Male</p>");
#nullable restore
#line 24 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\Pages\More.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "<p>Sex: Female</p>");
#nullable restore
#line 28 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\Pages\More.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "p");
            __builder.AddContent(33, "Job Title: ");
            __builder.AddContent(34, 
#nullable restore
#line 29 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\Pages\More.razor"
                   Adult.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.OpenElement(36, "p");
            __builder.AddContent(37, "Salary: ");
            __builder.AddContent(38, 
#nullable restore
#line 30 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\Pages\More.razor"
                Adult.JobTitle.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(39, " Eur");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.OpenElement(41, "p");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "class", "btn-outline-dark");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\Pages\More.razor"
                                                     () => goToAdults()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "Go Back");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\Pages\More.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\ljusk\RiderProjects\Exercises1\Assignments\Assignment1\Pages\More.razor"
       

    [Parameter]
    public int Id { get; set; }

    private Adult Adult;

    //Fetching adult
    protected override async Task OnInitializedAsync()
    {
        Adult = AdultData.get(Id);
    }

    private void goToAdults()
    {
        NavMgr.NavigateTo("/Adults");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultData AdultData { get; set; }
    }
}
#pragma warning restore 1591
