// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ScyLab.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\_Imports.razor"
using ScyLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\_Imports.razor"
using ScyLab.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\Pages\AddAll.razor"
using EFDataAccess.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\Pages\AddAll.razor"
using EFDataAccess.DataAccess;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/add_all")]
    public partial class AddAll : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 137 "C:\Users\elimens\Desktop\Projects\Scylab\__ScyLab\Pages\AddAll.razor"
      
    List<ItemModel> itemList = null;


    protected override async Task OnInitializedAsync()
    {
        itemList = await Task.Run(() => itemservice.GetAllItemsAsync());
    }

    protected async void DeleteItem(Guid Id)
    {
        await itemservice.DeleteAsync(Id);
        NavManager.NavigateTo("/add_all");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Scylab.DataItems.IRepository _irepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ItemService itemservice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
