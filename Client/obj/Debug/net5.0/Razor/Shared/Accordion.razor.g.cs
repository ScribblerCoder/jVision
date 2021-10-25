#pragma checksum "C:\Users\natha\source\repos\jVision\Client\Shared\Accordion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "624caa0e282a5c9c175422693cb456533489d8dc"
// <auto-generated/>
#pragma warning disable 1591
namespace jVision.Client.Shared
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
    public partial class Accordion : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "accordionPanel");
            __builder.AddAttribute(2, "disabled", 
#nullable restore
#line 1 "C:\Users\natha\source\repos\jVision\Client\Shared\Accordion.razor"
                                                        Disabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "tabindex", "200");
            __builder.AddMultipleAttributes(4, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 1 "C:\Users\natha\source\repos\jVision\Client\Shared\Accordion.razor"
                                                                                             AllOtherAttributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "b-daov7waiux");
            __builder.AddElementReferenceCapture(6, (__value) => {
#nullable restore
#line 1 "C:\Users\natha\source\repos\jVision\Client\Shared\Accordion.razor"
           _inputRef = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __Blazor.jVision.Client.Shared.Accordion.TypeInference.CreateCascadingValue_0(__builder, 7, 8, 
#nullable restore
#line 2 "C:\Users\natha\source\repos\jVision\Client\Shared\Accordion.razor"
                           this

#line default
#line hidden
#nullable disable
            , 9, (__builder2) => {
                __builder2.AddContent(10, 
#nullable restore
#line 3 "C:\Users\natha\source\repos\jVision\Client\Shared\Accordion.razor"
         CollapsePanels

#line default
#line hidden
#nullable disable
                );
            }
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\natha\source\repos\jVision\Client\Shared\Accordion.razor"
       
    protected ElementReference _inputRef;
    /// <summary>
    /// Exposes a Blazor <see cref="ElementReference"/> of the wrapped around HTML element. It can be used e.g. for JS interop, etc.
    /// </summary>
    public ElementReference InnerElementReference => _inputRef;

    /// <summary>
    /// Required HTML content to set CollapsePanel as <see cref="RenderFragment"/>.
    /// </summary>
    [Parameter] public RenderFragment CollapsePanels { get; set; }

    /// <summary>
    /// Determines whether all the rendered HTML elements should be disabled or not.
    /// </summary>
    [Parameter] public bool Disabled { get; set; } = false;

    private IList<CollapsePanel> _collapsePanels = new List<CollapsePanel>();
    /// <summary>
    /// Returns the number of <see cref="CollapsePanel"/> int the given `Accordion`.
    /// </summary>
    public int CollapsePanelCount => _collapsePanels.Count;
    /// <summary>
    /// Returns all the <see cref="CollapsePanel"/> reference added to the group. It can be used for activating any of the panels.
    /// </summary>
    public IEnumerable<CollapsePanel> CollapsePanelItems => _collapsePanels;

    private CollapsePanel? _activeCollapsePanel;
    /// <summary>
    /// Returns currently active <see cref="CollapsePanel"/> element ref also can be used to set which panel should be Expanded "active".
    /// </summary>
    [Parameter]
    public CollapsePanel? ActiveCollapsePanel
    {
        get => _activeCollapsePanel;
        set => ActivateCollapsePanel(value);
    }

    /// <summary>
    /// Callback function called when other CollapsePanel activated. Active CollapsePanel is the callback parameter.
    /// </summary>
    [Parameter] public EventCallback<CollapsePanel> OnCollapsePanelChanged { get; set; }

    /// <summary>
    /// Blazor capture for any unmatched HTML attributes.
    /// </summary>
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> AllOtherAttributes { get; set; }

    internal void AddCollapsePanel(CollapsePanel collapsePanel)
    {

        _collapsePanels.Add(collapsePanel);
        collapsePanel.Collapsed = true;
    }
    private bool _activateInProgress = false;
    internal async Task ActivateCollapsePanel(CollapsePanel? collapsePanel)
    {
        if (_activateInProgress)
            return;

        _activateInProgress = true;

        if (_activeCollapsePanel != collapsePanel) //Activate only 1 panel
        {
            if (_activeCollapsePanel is not null)
            {
                _activeCollapsePanel.Collapsed = true; //collapse current
            }

            _activeCollapsePanel = collapsePanel;

            if (_activeCollapsePanel is not null)
            {
                _activeCollapsePanel.Collapsed = false; //expand new
            }
            StateHasChanged();

            if (OnCollapsePanelChanged.HasDelegate)
            {
                await OnCollapsePanelChanged.InvokeAsync(ActiveCollapsePanel);
            }
        }
        _activateInProgress = false;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.jVision.Client.Shared.Accordion
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591