// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TheAmazon.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\brand\source\repos\TheAmazon\TheAmazon\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\brand\source\repos\TheAmazon\TheAmazon\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\brand\source\repos\TheAmazon\TheAmazon\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\brand\source\repos\TheAmazon\TheAmazon\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\brand\source\repos\TheAmazon\TheAmazon\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\brand\source\repos\TheAmazon\TheAmazon\Pages\Admin\_Imports.razor"
using TheAmazon.Models;

#line default
#line hidden
#nullable disable
    public partial class OrderTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\brand\source\repos\TheAmazon\TheAmazon\Pages\Admin\OrderTable.razor"
       

    [Parameter]
    public string TableTitle { get; set; } = "Purchases";

    [Parameter]
    public IEnumerable<Purchase> Purchases { get; set; }

    [Parameter]
    public string ButtonLabel { get; set; } = "Collected";

    [Parameter]
    public EventCallback<int> PurchaseSelected { get; set; }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
