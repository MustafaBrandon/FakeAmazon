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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/purchases")]
    public partial class Purchases : OwningComponentBase<IPurchasheRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\brand\source\repos\TheAmazon\TheAmazon\Pages\Admin\Purchases.razor"
       

    public IPurchasheRepository repo => Service;

    public IEnumerable<Purchase> AllPurchases { get; set; }
    public IEnumerable<Purchase> UncollectedPurchases { get; set; }
    public IEnumerable<Purchase> CollectedPurchases { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        AllPurchases = await repo.Purchases.ToListAsync();
        UncollectedPurchases = AllPurchases.Where(x => !x.Received);
        CollectedPurchases = AllPurchases.Where(x => x.Received);

    }

    public void CollectPurchase(int id) => UpdatePurchase(id, true);
    public void ResetPurchase(int id) => UpdatePurchase(id, false);

    private void UpdatePurchase (int id, bool collected)
    {
        Purchase p = repo.Purchases.FirstOrDefault(x => x.PurchaseID == id);
        p.Received = collected;
        repo.SavePurchase(p);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
