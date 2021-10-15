#pragma checksum "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\Components\Pager.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66954aa5040693403de38da0200dec4417afb31d"
// <auto-generated/>
#pragma warning disable 1591
namespace Oficondo.Management.Web.App.Components
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
    public partial class Pager : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\Components\Pager.razor"
 if (TotalPages > 0)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "float-left pager mt-3");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "type", "button");
            __builder.AddAttribute(4, "class", 
#nullable restore
#line 4 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\Components\Pager.razor"
                                   (PageIndex == 1) ? "pager-btn-disabled" : "pager-btn"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\Components\Pager.razor"
                                                                                                       () => OnClick.InvokeAsync(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(6, "<i class=\"fa fa-angle-double-left\" aria-hidden=\"true\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "type", "button");
            __builder.AddAttribute(10, "class", 
#nullable restore
#line 7 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\Components\Pager.razor"
                                   HasPreviousPage ? "pager-btn" : "pager-btn-disabled"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\Components\Pager.razor"
                                                                                                      () => OnClick.InvokeAsync(PageIndex - 1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(12, "<i class=\"fa fa-angle-left\" aria-hidden=\"true\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "span");
            __builder.AddContent(15, 
#nullable restore
#line 10 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\Components\Pager.razor"
           PageIndex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "class", 
#nullable restore
#line 11 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\Components\Pager.razor"
                                   HasNextPage ? "pager-btn" : "pager-btn-disabled"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\Components\Pager.razor"
                                                                                                  () => OnClick.InvokeAsync(PageIndex + 1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(21, "<i class=\"fa fa-angle-right\" aria-hidden=\"true\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "type", "button");
            __builder.AddAttribute(25, "class", 
#nullable restore
#line 14 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\Components\Pager.razor"
                                   (PageIndex == TotalPages) ? "pager-btn-disabled" : "pager-btn"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\Components\Pager.razor"
                                                                                                                () => OnClick.InvokeAsync(TotalPages)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(27, "<i class=\"fa fa-angle-double-right\" aria-hidden=\"true\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "C:\sitcs\Projects\OfiCondo.Management\Oficondo.Management.Web.App\Components\Pager.razor"
            }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
