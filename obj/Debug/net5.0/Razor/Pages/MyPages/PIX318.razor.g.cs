#pragma checksum "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1500e3e36592dd8050bc9d0e5de5fe490632abb"
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
            __builder.AddMarkupContent(0, "<h1>Resept: PIX-318</h1>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<h5 class=\"mx-5\">&nbsp;&nbsp;&nbsp; Dato &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Antall Rader</h5>");
#nullable restore
#line 15 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
 if (recipes is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading....</em></p>");
#nullable restore
#line 18 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
}
else
{


    

   


#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "btn-group");
            __builder.OpenComponent<BlazorDateRangePicker.DateRangePicker>(5);
            __builder.AddAttribute(6, "placeholder", "Velg Dato");
            __builder.AddAttribute(7, "OnRangeSelect", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorDateRangePicker.DateRange>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorDateRangePicker.DateRange>(this, 
#nullable restore
#line 28 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                                                                                                    OnRangeSelect

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "StartDate", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTimeOffset?>(
#nullable restore
#line 28 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                                                  StartDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "StartDateChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTimeOffset?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTimeOffset?>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => StartDate = __value, StartDate))));
            __builder.AddAttribute(10, "EndDate", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTimeOffset?>(
#nullable restore
#line 28 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                                                                            EndDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "EndDateChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTimeOffset?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTimeOffset?>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EndDate = __value, EndDate))));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "type", "number");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                      Queries.TableLen

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(16, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Queries.TableLen = __value, Queries.TableLen, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.OpenElement(17, "table");
            __builder.AddAttribute(18, "class", "table table-striped");
            __builder.OpenElement(19, "thead");
            __builder.OpenElement(20, "tr");
#nullable restore
#line 41 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                 foreach(var Var in filter)
                    {
                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                        if(!Var.sort)
                       {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "th");
#nullable restore
#line 44 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(22, Var.variable);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                              }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                               
                        
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "tbody");
#nullable restore
#line 52 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
             foreach (var recipe in RecipeRead.Table)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "tr");
            __builder.SetKey(
#nullable restore
#line 54 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                          recipe

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 56 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[0].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "td");
#nullable restore
#line 57 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(27, recipe.BatchNr);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[1].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "td");
#nullable restore
#line 59 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(29, recipe.Dato);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 59 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[2].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "td");
#nullable restore
#line 61 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(31, recipe.SAP);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                         }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[3].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "td");
#nullable restore
#line 64 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(33, recipe.ID);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[4].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "td");
#nullable restore
#line 67 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(35, recipe.Reaktor);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 67 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[5].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "td");
#nullable restore
#line 70 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(37, recipe.SatsVolum);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 70 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                               }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[6].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "td");
#nullable restore
#line 73 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(39, recipe.ForvFe);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 73 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[7].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(40, "td");
#nullable restore
#line 76 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(41, recipe.OnsketFe);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 76 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                              }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[8].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(42, "td");
#nullable restore
#line 79 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(43, recipe.OnsketSyre);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 79 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[9].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(44, "td");
#nullable restore
#line 82 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(45, recipe.OnsketFe2);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 82 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                               }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[10].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(46, "td");
#nullable restore
#line 85 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(47, recipe.HCLType);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 85 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[11].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(48, "td");
#nullable restore
#line 88 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(49, recipe.ForvDamp);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 88 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                              }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[12].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "td");
#nullable restore
#line 91 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(51, recipe.VannOverordnet);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 91 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[13].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(52, "td");
#nullable restore
#line 94 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(53, recipe.VarmtVann);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 94 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                               }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[14].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(54, "td");
#nullable restore
#line 97 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(55, recipe.SpillVann);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 97 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                               }

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[15].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(56, "td");
#nullable restore
#line 100 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(57, recipe.ScrubberVaeske);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 100 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[16].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(58, "th");
#nullable restore
#line 103 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(59, recipe.HCL);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 103 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                         }

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[17].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(60, "th");
#nullable restore
#line 106 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(61, recipe.Jernsulfat);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 106 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[18].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(62, "th");
#nullable restore
#line 109 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(63, recipe.Temp);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 109 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[19].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(64, "th");
#nullable restore
#line 112 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(65, recipe.Modningstid);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 112 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                                 }

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[20].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(66, "th");
#nullable restore
#line 115 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(67, recipe.DampVentil);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 115 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[21].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(68, "th");
#nullable restore
#line 118 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(69, recipe.Etterspyling);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 118 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                                  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[22].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(70, "th");
#nullable restore
#line 121 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(71, recipe.O2Trykk);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 121 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[23].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(72, "th");
#nullable restore
#line 124 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(73, recipe.O2Reaksjonstid);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 124 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[24].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(74, "th");
#nullable restore
#line 127 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(75, recipe.DeltaTemp);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 127 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                               }

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[25].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(76, "th");
#nullable restore
#line 130 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(77, recipe.AnalysertFe3);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 130 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                                  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[26].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(78, "th");
#nullable restore
#line 133 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(79, recipe.AnalysertFeTot);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 133 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[27].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(80, "th");
#nullable restore
#line 136 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(81, recipe.VannSluttJustering);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 136 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 138 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[28].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(82, "th");
#nullable restore
#line 139 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(83, recipe.VirkeligMVann);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 139 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                                   }

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                     if(!filter[29].sort)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(84, "th");
#nullable restore
#line 142 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(85, recipe.TotTilLager);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 142 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                                 }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 147 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "btn-group  text-rt");
            __builder.AddAttribute(88, "role", "group");
            __builder.AddAttribute(89, "aria-label", "Reset");
            __builder.OpenElement(90, "button");
            __builder.AddAttribute(91, "type", "button");
            __builder.AddAttribute(92, "class", "btn btn-success btn-lg mx-3");
            __builder.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 159 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                                                            () => WriteCSV(filter)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(94, "Eksporter til Excel");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n        ");
            __builder.OpenElement(96, "button");
            __builder.AddAttribute(97, "type", "button");
            __builder.AddAttribute(98, "class", "btn btn-secondary btn-lg text-right");
            __builder.AddAttribute(99, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 160 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                                                                                    () => resetTable()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(100, "Reset Tabell");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "<div class=\"my-5\"></div>");
            __builder.AddMarkupContent(102, "<h4>Fjerne/Legge til kolonner</h4>");
            __builder.OpenElement(103, "ul");
            __builder.AddAttribute(104, "class", "list-group d-inline-block");
#nullable restore
#line 168 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
    foreach(var variable in filter)
    {


            

#line default
#line hidden
#nullable disable
#nullable restore
#line 172 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
             if (!variable.sort)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(105, "li");
            __builder.AddAttribute(106, "class", "list-group-item list-group-item-primary");
            __builder.AddAttribute(107, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 175 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                          (() => {variable.sort = !variable.sort; StateHasChanged();})

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 177 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(108, variable.variable);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 179 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
            }
        else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(109, "li");
            __builder.AddAttribute(110, "class", "list-group-item list-group-item-secondary");
            __builder.AddAttribute(111, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 183 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
                          (() => {variable.sort = !variable.sort; StateHasChanged();})

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(112, "del");
#nullable restore
#line 184 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
__builder.AddContent(113, variable.variable);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 186 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 186 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"
             
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 195 "C:\Users\isak.skeie\source\repos\KemiraRapportering\Pages\MyPages\PIX318.razor"

}

#line default
#line hidden
#nullable disable
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
