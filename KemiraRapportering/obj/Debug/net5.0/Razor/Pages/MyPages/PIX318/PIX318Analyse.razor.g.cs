#pragma checksum "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\PIX318Analyse.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "901c0df59a4c068ffaa55eaee98b4503397a3015"
// <auto-generated/>
#pragma warning disable 1591
namespace KemiraRapportering.Pages.MyPages.PIX318
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\_Imports.razor"
using KemiraRapportering.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\_Imports.razor"
using KemiraRapportering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\_Imports.razor"
using KemiraRapportering.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\PIX318Analyse.razor"
using DataAccesLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\PIX318Analyse.razor"
using DataAccesLib.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\PIX318Analyse.razor"
using BlazorDateRangePicker;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PIX318Analyse")]
    public partial class PIX318Analyse : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Resept: PIX-318 Analyse</h1>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<h5 class=\"mx-5\">&nbsp;&nbsp;&nbsp; Dato &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Antall Rader</h5>");
#nullable restore
#line 16 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\PIX318Analyse.razor"
 if (recipes is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading....</em></p>");
#nullable restore
#line 19 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\PIX318Analyse.razor"
}
else
{


    

   



 


#line default
#line hidden
#nullable disable
            __builder.OpenComponent<KemiraRapportering.Pages.MyPages.PIX318.AnalyseTables>(3);
            __builder.AddAttribute(4, "FilterSort", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DataAccesLib.Models.filtering[]>(
#nullable restore
#line 32 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\PIX318Analyse.razor"
                            filter

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<KemiraRapportering.Pages.MyPages.PIX318.FilterButtons>(6);
            __builder.AddAttribute(7, "FilterSort", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DataAccesLib.Models.filtering[]>(
#nullable restore
#line 33 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\PIX318Analyse.razor"
                           filter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "FilterSortUpdate", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<DataAccesLib.Models.filtering[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<DataAccesLib.Models.filtering[]>(this, 
#nullable restore
#line 33 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\PIX318Analyse.razor"
                                                     UpdateFilter

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 34 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\PIX318Analyse.razor"



}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\isak.skeie\source\repos\Kemira\KemiraRapportering\Pages\MyPages\PIX318\PIX318Analyse.razor"
       


    private string value { get; set; }

    private string batch { get; set; }

    private int TableLen = Queries.TableLen;

    private List<RecipeModels> recipes;
    private RecipeModels RecipeEdit = new RecipeModels();

     public filtering[] filter = new filtering[10];




    DateTimeOffset? StartDate { get; set; } = DateTime.Today.AddDays(-7);
    DateTimeOffset? EndDate { get; set; } = DateTime.Today.AddDays(1).AddTicks(-1);


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
        
        //Shorten this down
        filter[0] = new filtering();
        filter[0].variable = FilterModel.StringFilter[0];

        filter[1] = new filtering();
        filter[1].variable = FilterModel.StringFilter[1];

        filter[2] = new filtering();
        filter[2].variable = FilterModel.StringFilter[3];

        filter[3] = new filtering();
        filter[3].variable = FilterModel.StringFilter[30];

        filter[4] = new filtering();
        filter[4].variable = FilterModel.StringFilter[31];

        filter[5] = new filtering();
        filter[5].variable = FilterModel.StringFilter[32];

        filter[6] = new filtering();
        filter[6].variable = FilterModel.StringFilter[33];

        filter[7] = new filtering();
        filter[7].variable = FilterModel.StringFilter[34];

        filter[8] = new filtering();
        filter[8].variable = FilterModel.StringFilter[35];

        filter[9] = new filtering();
        filter[9].variable = FilterModel.StringFilter[36];


        recipes = await _db.GetRecipes(sql);


    }

    public async void TableUpdate()
    {

        recipes = await _db.GetRecipes(Queries.sql);
        RecipeRead.Table = recipes;
        
        //StateHasChanged();
    }

    public async Task resetTable()
    {
        string sql = $"SELECT top ({ Queries.TableLen }) * FROM PIX318_ReseptData ORDER BY BatchNr DESC";
        recipes = await _db.GetRecipes(sql);
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

   
    private void UpdateFilter(filtering[] _filter)
    {
        filter = _filter;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRecipeData _db { get; set; }
    }
}
#pragma warning restore 1591
