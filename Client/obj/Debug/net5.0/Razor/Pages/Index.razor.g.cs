#pragma checksum "C:\Users\natha\source\repos\jVision\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb192db601d1e4195f36504ad3937887d4208cd1"
// <auto-generated/>
#pragma warning disable 1591
namespace jVision.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using jVision.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\natha\source\repos\jVision\Client\_Imports.razor"
using jVision.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\natha\source\repos\jVision\Client\Pages\Index.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\natha\source\repos\jVision\Client\Pages\Index.razor"
using jVision.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "h1");
                __builder2.AddContent(3, "Hello ");
                __builder2.AddContent(4, 
#nullable restore
#line 6 "C:\Users\natha\source\repos\jVision\Client\Pages\Index.razor"
                   context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.AddMarkupContent(6, "<p>Welcome to Blazor Learner.</p>\r\n        ");
                __builder2.AddMarkupContent(7, "<button class=\"btn\">Click me!</button>\r\n        ");
                __builder2.AddContent(8, 
#nullable restore
#line 9 "C:\Users\natha\source\repos\jVision\Client\Pages\Index.razor"
         error

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.AddAttribute(9, "Authorizing", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "<h1>Loading ...</h1>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\natha\source\repos\jVision\Client\Pages\Index.razor"
       
    [Inject] public HttpClient Http { get; set; }

    private IList<BoxDTO> boxes;
    private string error;
    
    protected override async Task OnInitializedAsync()
    {
        try
        {
            string requestUri = "Box";
            boxes = await Http.GetFromJsonAsync<IList<BoxDTO>>(requestUri);
        } catch (Exception)
        {
            error = "Error Encountered";
        };
    }
    //private async Task AddBox()
        //{
            //BoxDTO = newBox = new BoxDTO
            //{

            //}
      //  }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
