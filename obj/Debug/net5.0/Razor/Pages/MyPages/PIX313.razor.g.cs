#pragma checksum "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "674dc96180783b0db3c8b3e2bec52d4ccb82741a"
// <auto-generated/>
#pragma warning disable 1591
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
using KemiraRapportering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using KemiraRapportering.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\isak.skeie\source\repos\KemiraRapportering\_Imports.razor"
using DataAccesLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
using BlazorDateRangePicker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
using KemiraRapportering.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PIX-313")]
    public partial class PIX313 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Resept: PIX-318</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Resepttabell for PIX-318</p>");
#nullable restore
#line 13 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
 if ("temp" == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 16 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
}
else

{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "btn-group");
            __builder.AddAttribute(5, "role", "toolbar");
            __builder.AddAttribute(6, "aria-label", "Basic example");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "dropdown show");
            __builder.OpenElement(9, "a");
            __builder.AddAttribute(10, "class", "btn btn-primary dropdown-toggle");
            __builder.AddAttribute(11, "href", "#");
            __builder.AddAttribute(12, "role", "button");
            __builder.AddAttribute(13, "id", "dropdownMenuLink");
            __builder.AddAttribute(14, "data-toggle", "dropdown");
            __builder.AddAttribute(15, "aria-haspopup", "true");
            __builder.AddAttribute(16, "aria-expanded", "false");
#nullable restore
#line 24 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(17, BatchDrop);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n            ");
            __builder.AddMarkupContent(19, "<div class=\"dropdown-menu\" aria-labelledby=\"dropdownMenuLink\"><a class=\"dropdown-item\">Batch1</a>\r\n                <a class=\"dropdown-item\" href=\"#\">Batch2</a>\r\n                <a class=\"dropdown-item\" href=\"#\">Batch3</a></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n        ");
            __builder.AddMarkupContent(21, @"<div class=""dropdown show""><a class=""btn btn-primary dropdown-toggle"" href=""#"" role=""button"" id=""dropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                Dato
            </a>

            <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuLink""><a class=""dropdown-item"">23.01.2022</a>
                <a class=""dropdown-item"">24.01.2022</a>
                <a class=""dropdown-item"" href=""#"">25.01.2022</a></div></div>");
            __builder.CloseElement();
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "class", "table table-striped");
            __builder.AddMarkupContent(24, @"<thead><tr><th>batch</th>
                <th>Dato</th>
                <th>SAP</th>
                <th>ID</th>
                <th>Reaktor</th>
                <th>Satsvolum</th>
                <th>Forventet Fe</th>
                <th>Ønsket Fe</th>
                <th>Ønsket Syre</th>
                <th>Ønsket Fe2</th>
                <th>HCL Type</th>
                <th>Forv. Damp</th>
                <th>Vann Overordnet</th>
                <th>VarmtVann</th>
                <th>SpillVann</th>
                <th>ScrubberVæske</th>
                <th>HCL</th>
                <th>Jernsulfat</th>
                <th>Temperatur</th>
                <th>Modningstid</th>
                <th>DampVentil</th>
                <th>Etterspyling</th>
                <th>O2 Trykk</th>
                <th>O2 Reaksjonstid</th>
                <th>DeltaTemp</th>
                <th>Analysert Fe3</th>
                <th>Analysert FeTot</th>
                <th>VannSluttjustering</th>
                <th>Virkelig mengde vann</th>
                <th>Tot til Lager</th></tr></thead>
        ");
            __builder.OpenElement(25, "tbody");
#nullable restore
#line 85 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
             foreach (var recipe in RecipeRead.Table)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "tr");
            __builder.SetKey(
#nullable restore
#line 87 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
                          recipe

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(27, "td");
#nullable restore
#line 88 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(28, recipe.BatchNr);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "td");
#nullable restore
#line 89 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(31, recipe.Dato);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "td");
#nullable restore
#line 90 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(34, recipe.SAP);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "td");
#nullable restore
#line 91 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(37, recipe.ID);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "td");
#nullable restore
#line 92 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(40, recipe.Reaktor);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "td");
#nullable restore
#line 93 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(43, recipe.SatsVolum);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.OpenElement(45, "td");
#nullable restore
#line 94 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(46, recipe.ForvFe);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "td");
#nullable restore
#line 95 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(49, recipe.OnsketFe);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.OpenElement(51, "td");
#nullable restore
#line 96 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(52, recipe.OnsketSyre);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenElement(54, "td");
#nullable restore
#line 97 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(55, recipe.OnsketFe2);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.OpenElement(57, "td");
#nullable restore
#line 98 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(58, recipe.HCLType);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.OpenElement(60, "td");
#nullable restore
#line 99 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(61, recipe.ForvDamp);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.OpenElement(63, "td");
#nullable restore
#line 100 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(64, recipe.VannOverordnet);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.OpenElement(66, "td");
#nullable restore
#line 101 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(67, recipe.VarmtVann);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                    ");
            __builder.OpenElement(69, "td");
#nullable restore
#line 102 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(70, recipe.SpillVann);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                    ");
            __builder.OpenElement(72, "td");
#nullable restore
#line 103 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(73, recipe.ScrubberVaeske);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                    ");
            __builder.OpenElement(75, "th");
#nullable restore
#line 104 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(76, recipe.HCL);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.OpenElement(78, "th");
#nullable restore
#line 105 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(79, recipe.Jernsulfat);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                    ");
            __builder.OpenElement(81, "th");
#nullable restore
#line 106 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(82, recipe.Temp);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                    ");
            __builder.OpenElement(84, "th");
#nullable restore
#line 107 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(85, recipe.Modningstid);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                    ");
            __builder.OpenElement(87, "th");
#nullable restore
#line 108 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(88, recipe.DampVentil);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                    ");
            __builder.OpenElement(90, "th");
#nullable restore
#line 109 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(91, recipe.Etterspyling);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                    ");
            __builder.OpenElement(93, "th");
#nullable restore
#line 110 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(94, recipe.O2Trykk);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                    ");
            __builder.OpenElement(96, "th");
#nullable restore
#line 111 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(97, recipe.O2Reaksjonstid);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                    ");
            __builder.OpenElement(99, "th");
#nullable restore
#line 112 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(100, recipe.DeltaTemp);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                    ");
            __builder.OpenElement(102, "th");
#nullable restore
#line 113 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(103, recipe.AnalysertFe3);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                    ");
            __builder.OpenElement(105, "th");
#nullable restore
#line 114 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(106, recipe.AnalysertFeTot);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                    ");
            __builder.OpenElement(108, "th");
#nullable restore
#line 115 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(109, recipe.VannSluttJustering);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                    ");
            __builder.OpenElement(111, "th");
#nullable restore
#line 116 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(112, recipe.VirkeligMVann);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                    ");
            __builder.OpenElement(114, "th");
#nullable restore
#line 117 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
__builder.AddContent(115, recipe.TotTilLager);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 121 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n        ");
            __builder.OpenComponent<BlazorDateRangePicker.DateRangePicker>(117);
            __builder.AddAttribute(118, "SingleDatePicker", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 123 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
                                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 126 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 129 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX313.razor"
       
    public int batch = 1;
    public int SAP = 2;
    public int ID = 3;
    public int Reaktor = 4;
    public double Satsv = 5.5;
    public string dato = "20.01.22";
    public double ForvFeKonm = 6.6;
    public double OnskFeKons = 7.7;


    public string BatchDrop = "Batch";





    //private WeatherForecast[] forecasts;

    //protected override async Task OnInitializedAsync()
    //{
    //    forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    //}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
