// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace KemiraRapportering.Pages.MyPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using KemiraRapportering.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using KemiraRapportering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using KemiraRapportering.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
using DataAccesLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
using DataAccesLib.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
using BlazorDateRangePicker;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PIX-318")]
    public partial class PIX318 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 200 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
       


    private string value { get; set; }

    private string batch { get; set; }

    private int TableLen = Queries.TableLen;

    private List<RecipeModels> recipes;

    public  List<string> RecipeVariables = new List<string>()
        {
        "Batch",
        "Dato",
        "SAP",
        "ID",
        "Reaktor",
        "Satsvolum",
        "Forventet Fe",
        "Onsket Fe",
        "Onsket Syre",
        "Onsket Fe2",
        "HCL type",
        "Forv. Damp",
        "Vann Overordnet",
        "Varmt Vann",
        "Spill Vann",
        "Scrubber Væske",
        "HCL",
        "Jernsulfat",
        "Temp",
        "Modningstid",
        "Damp Ventil",
        "Etter spyling",
        "O2 Trykk",
        "O2 Reaksjonstid",
        "DeltaTemp",
        "Analysert Fe3",
        "Analysert FeTot",
        "VannSlutt justering",
        "Virkelig Mengde Vann",
        "Tot til lager"
    };



    public filtering[] filter = new filtering[30];

   
   
    DateTimeOffset? StartDate { get; set; } = DateTime.Today.AddDays(-7);
    DateTimeOffset? EndDate { get; set; } = DateTime.Today.AddDays(0).AddTicks(-1);


    Queries query = new Queries();

    public void OnRangeSelect(DateRange range)
    {

        string sql = query.DateQuery(range);
        TableUpdate();
    }




    protected override async Task OnInitializedAsync()
    {
        string sql = query.pix318();
        
        
        recipes = await _db.GetRecipes(sql);
        

        
        RecipeRead.Table = recipes;
        TableUpdate();

        for(int i = 0; i < 30; i++)
        {
            filter[i] = new filtering();
            filter[i].variable = RecipeVariables[i];
        }

        //Make this part of initialization
        filter[5].sort = true;
        filter[19].sort = true;
        filter[20].sort = true;
        filter[21].sort = true;
        filter[22].sort = true;
        filter[24].sort = true;

        

    }

    public async void TableUpdate()
    {

        recipes = await _db.GetRecipes(Queries.sql);
        RecipeRead.Table = recipes;
        //await InvokeAsync(StateHasChanged);
    }

    public async Task resetTable()
    {
        
        recipes = await _db.GetRecipes(Queries.sql);
        RecipeRead.Table = recipes;
        

    }

    public void ResetDropDown()
    {
        StateHasChanged();
    }

  


    
    public void WriteCSV(filtering[] filter)
    {
        DataWrite ToCSV = new DataWrite(filter);

        ToCSV.dataWriteToCSV();

    }

    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRecipeData _db { get; set; }
    }
}
#pragma warning restore 1591
