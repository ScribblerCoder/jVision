#pragma checksum "C:\Users\natha\source\repos\jVision\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1311be78911ae5312afb9471627428113850a4db"
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
                __builder2.AddMarkupContent(5, "\r\n\r\n        ");
                __builder2.OpenElement(6, "button");
                __builder2.AddAttribute(7, "class", "btn btn-success");
                __builder2.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\natha\source\repos\jVision\Client\Pages\Index.razor"
                                                  AddBox

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(9, "Click me!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "button");
                __builder2.AddAttribute(12, "class", "btn btn-success");
                __builder2.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\natha\source\repos\jVision\Client\Pages\Index.razor"
                                                  DeleteBox

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(14, "dclcisdf");
                __builder2.CloseElement();
#nullable restore
#line 10 "C:\Users\natha\source\repos\jVision\Client\Pages\Index.razor"
         if (boxes == null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(15, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "C:\Users\natha\source\repos\jVision\Client\Pages\Index.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\natha\source\repos\jVision\Client\Pages\Index.razor"
             foreach (var box in boxes)
            {
               
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(16, 
#nullable restore
#line 20 "C:\Users\natha\source\repos\jVision\Client\Pages\Index.razor"
             error

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 20 "C:\Users\natha\source\repos\jVision\Client\Pages\Index.razor"
                  
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(17, "Authorizing", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(18, "<h1>Loading ...</h1>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\natha\source\repos\jVision\Client\Pages\Index.razor"
       
    [Inject] public HttpClient Http { get; set; }

    private IList<BoxDTO> boxes = new List<BoxDTO>();
    private IList<ServiceDTO> services = new List<ServiceDTO>();
    private IList<BoxDTO> boxesAdded = new List<BoxDTO>();
    private IList<ServiceDTO> servicesAdded = new List<ServiceDTO>();
    public string hello = "hello";
    private string error;
    private string requestUri = "Box";
    protected override async Task OnInitializedAsync()
    {
        try
        {
            boxes = await Http.GetFromJsonAsync<IList<BoxDTO>>(requestUri);
        } catch (Exception)
        {
            error = "Error Encountered";
        };
    }

    private async Task AddBox()
    {
        Console.WriteLine("anyuthing");
        ServiceDTO newService = new ServiceDTO
        {
            Port = 22
        };
        servicesAdded.Add(newService);
        BoxDTO newBox = new BoxDTO
        {
            Ip = "192.168.1.1",
            UserName = "jbrick123",
            Hostname = "Hostname",
            State = false,
            Comments = "none",
            Active = false,
            Pwned = false,
            Unrelated = false,
            Comeback = false,
            Os = "Linux",
            Cidr = "/24",
            Services = servicesAdded
        };
        boxesAdded.Add(newBox);
        var response = await Http.PostAsJsonAsync(requestUri, boxesAdded);
        Console.WriteLine(response);

    }

    private async Task DeleteBox()
    {
        await Http.DeleteAsync(requestUri);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
