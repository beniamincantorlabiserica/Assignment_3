#pragma checksum "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\SecurityLevel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "326422ba1981a173237aeb1c48d77b3a3ab5e749"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment_1_.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\_Imports.razor"
using Assignment_1_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\_Imports.razor"
using Assignment_1_.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\SecurityLevel.razor"
using Assignment_1_.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\SecurityLevel.razor"
using DefaultNamespace;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Security")]
    public partial class SecurityLevel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>SecurityLevel</h3>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(3, "h3");
                __builder2.AddContent(4, "Hello ");
                __builder2.AddContent(5, 
#nullable restore
#line 10 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\SecurityLevel.razor"
               context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(6, "\n\n    ");
                __builder2.OpenElement(7, "h5");
                __builder2.AddContent(8, "Your security level is ");
                __builder2.AddContent(9, 
#nullable restore
#line 12 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\SecurityLevel.razor"
                                context.User.FindFirst(claim => claim.Type.Equals("Level")).Value

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\n\n");
            __builder.OpenElement(11, "AuthozizeView");
            __builder.AddAttribute(12, "Policy", "SecurityLevel2");
            __builder.AddMarkupContent(13, "<p style=\"display: none\">This piece is visible for level 2 and above</p>");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n\n");
            __builder.OpenElement(15, "AuthozizeView");
            __builder.AddAttribute(16, "Policy", "SecurityLevel4");
            __builder.AddMarkupContent(17, "<p style=\"display: none\">This piece is visible for level 4 boss</p>");
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\SecurityLevel.razor"
 if (adults == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, "<p><em>Loading...</em></p>");
#nullable restore
#line 29 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\SecurityLevel.razor"
} else if (!adults.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "<p><em>No adults...</em></p>");
#nullable restore
#line 34 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\SecurityLevel.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "table");
            __builder.AddAttribute(21, "class", "table");
            __builder.AddMarkupContent(22, "<thead><tr><th>ID</th>\n            <th>First Name</th>\n            <th>Last Name</th></tr></thead>\n        ");
            __builder.OpenElement(23, "tbody");
#nullable restore
#line 46 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\SecurityLevel.razor"
         foreach (var item in adults)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "tr");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 49 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\SecurityLevel.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 50 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\SecurityLevel.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n                ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 51 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\SecurityLevel.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\SecurityLevel.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\SecurityLevel.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\SecurityLevel.razor"
       
    private IList<Adult> adults;
    
    protected override async Task OnInitializedAsync()
    {
        adults = FileContext.GetAdults();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FileContextService FileContext { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
