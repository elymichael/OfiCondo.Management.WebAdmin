#pragma checksum "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce2703d036fa35db195e5f7400dfbf4d54bc69d9"
// <auto-generated/>
#pragma warning disable 1591
namespace Oficondo.Management.Web.App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\_Imports.razor"
using Oficondo.Management.Web.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\_Imports.razor"
using Oficondo.Management.Web.App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "mt-5 row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card col-12 col-lg-6 mr-auto ml-auto p-3");
            __builder.AddMarkupContent(4, "<h3 class=\"card-title\">Ingreso a Oficondo</h3>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\Pages\Login.razor"
                              LoginViewModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\Pages\Login.razor"
                                                             HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "input-group row mt-2");
                __builder2.AddMarkupContent(13, "<label class=\"col-12 col-md-4 p-0\" for=\"userName\">Correo:</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "id", "userName");
                __builder2.AddAttribute(16, "class", "col-12 col-md-8 login-field");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\Pages\Login.razor"
                                                                                              LoginViewModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LoginViewModel.Email = __value, LoginViewModel.Email))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => LoginViewModel.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "input-group row mt-2");
                __builder2.AddMarkupContent(23, "<label class=\"col-12 col-md-4 p-0\" for=\"password\">Contraseña:</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "type", "password");
                __builder2.AddAttribute(26, "id", "password");
                __builder2.AddAttribute(27, "class", "col-12 col-md-8 login-field");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\Pages\Login.razor"
                                                                                                               LoginViewModel.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LoginViewModel.Password = __value, LoginViewModel.Password))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => LoginViewModel.Password));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                ");
                __builder2.AddMarkupContent(32, "<div class=\"input-group row mt-2\"><div class=\"offset-md-4\"><button class=\"m-2 p-2\">Ingresar</button></div></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
            __builder.OpenElement(34, "span");
            __builder.AddAttribute(35, "class", "label label-error");
            __builder.AddContent(36, 
#nullable restore
#line 25 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\Pages\Login.razor"
                                 Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591