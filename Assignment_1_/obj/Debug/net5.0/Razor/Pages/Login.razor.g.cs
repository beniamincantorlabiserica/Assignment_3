#pragma checksum "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdd64716725e14671f8d709f9c345522aad79c2a"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginComponent
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
#line 3 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\Login.razor"
using Assignment_1_.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Login</h3>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "form-group");
                __builder2.AddMarkupContent(5, "<label>User name:</label>\n            ");
                __builder2.OpenElement(6, "input");
                __builder2.AddAttribute(7, "type", "text");
                __builder2.AddAttribute(8, "placeholder", "username");
                __builder2.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\Login.razor"
                                                                   username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.AddMarkupContent(14, "<label>Password:</label>\n            ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "type", "text");
                __builder2.AddAttribute(17, "placeholder", "password");
                __builder2.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\Login.razor"
                                                                   password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n        ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "style", "color: red");
                __builder2.AddContent(23, 
#nullable restore
#line 20 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\Login.razor"
                                 errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\n        \n        ");
                __builder2.OpenElement(25, "a");
                __builder2.AddAttribute(26, "href", "");
                __builder2.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\Login.razor"
                             PerformLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(28, "\n            Login\n        ");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(29, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(30, "a");
                __builder2.AddAttribute(31, "href", "");
                __builder2.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\Login.razor"
                             PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(33, "\n            Log out\n        ");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\Beniamin\Desktop\DNP_Assignment_2-master\Assignment_1_\Pages\Login.razor"
       
    private string username;
    private string password;
    private string errorMessage;

    public async Task PerformLogin()
    {
        errorMessage = "";
        try
        {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(username, password);
            username = "";
            password = "";
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }

    public async Task PerformLogout()
    {
        errorMessage = "";
        username = "";
        password = "";
        try
        {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591