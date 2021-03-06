#pragma checksum "D:\Tutorials\Paging\Client\Pages\DataGrid.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d8afe775032b29948c5d32720e3dcb01d95f048"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "D:\Tutorials\Paging\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Tutorials\Paging\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Tutorials\Paging\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Tutorials\Paging\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Tutorials\Paging\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Tutorials\Paging\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Tutorials\Paging\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Tutorials\Paging\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Tutorials\Paging\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
using Common.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
using static Common.GLB;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/datagrid")]
    public partial class DataGrid : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Client.Shared.TopBanner>(0);
            __builder.AddAttribute(1, "BannerTxt", "Registro de Amigos");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(3, " Admin only");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 11 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
 if ( Amigos.Count == 0 & InitialLoad)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<h1> Loading ......</h1>");
#nullable restore
#line 14 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
    // Avoids Loading message for empty search results
    InitialLoad = false;
}
else
{        

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container");
            __builder.AddMarkupContent(7, "<div class=\"row mt-3 mb-2 justify-content-center\"><div class=\"col-12 d-flex flex-row align-items-center justify-content-center m-0 p-0\"><h2>Amigos List</h2></div></div>\r\n\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.AddMarkupContent(10, "<div class=\"col-md-12 d-flex flex-row justify-content-end\"><button class=\"btn btn-labeled btn-primary  btn-sm mb-1\"> Add New </button></div>\r\n\r\n            \r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-md-12 d-flex flex-row justify-contents-center");
            __builder.AddAttribute(13, "style", "border-color:green; border-width:thick");
            __builder.OpenElement(14, "table");
            __builder.AddAttribute(15, "class", "table table-striped table-bordered table-secondary");
            __builder.AddMarkupContent(16, @"<thead><tr><th>Id</th>
                            <th>Name</th>
                            <th>Address</th>
                            <th>Email</th>
                            <th>Phone</th>
                            <th style=""text-align:center"">Action</th></tr></thead>
                    ");
            __builder.OpenElement(17, "tbody");
#nullable restore
#line 47 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
                         foreach ( AmigoModel a in Amigos)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "tr");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 50 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
                                     a.RowId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 51 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
                                     a.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 52 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
                                     a.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 53 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
                                     a.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                                ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 54 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
                                     a.Phone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                                ");
            __builder.AddMarkupContent(34, "<td style=\"text-align:center\"><button type=\"button\" class=\"btn btn-labeled btn-primary btn-sm\"> Update </button>\r\n                                    <button type=\"button\" class=\"btn btn-labeled btn-primary btn-sm\"> Delete </button></td>");
            __builder.CloseElement();
#nullable restore
#line 61 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n         ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "row");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "col-md-2 d-flex flex-column justify-content-end");
            __builder.AddMarkupContent(40, "<label style=\"font-size:12px;margin-bottom:0;margin-top:16px\">Current page number</label>\r\n                ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "class", "form-control InBox");
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
                                                              CurrentPageNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CurrentPageNumber = __value, CurrentPageNumber));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "         \r\n            ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "col-md-2 d-flex flex-column justify-content-end");
            __builder.AddMarkupContent(48, "<label style=\"font-size:12px;margin-bottom:0;margin-top:16px\">Number of Rows Per Page</label>          \r\n                ");
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "type", "number");
            __builder.AddAttribute(51, "class", "form-control Inbox");
            __builder.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 74 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
                                                                            RecsPerPage

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => RecsPerPage = __value, RecsPerPage, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n            <div class=\"col-md-4 d-flex flex-column justify-content-end\"></div>\r\n\r\n            ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "col-md-2 d-flex flex-column justify-content-end");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 79 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
                                                                                  GetPreviousPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(58, "<button type=\"button\" class=\"btn btn-labeled btn-primary btn-sm\"> Previous </button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "col-md-2 d-flex flex-column justify-content-end");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
                                                                                  GetNextPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(63, "<button type=\"button\" class=\"btn btn-labeled btn-primary btn-sm\">   Next   </button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "       \r\n        \r\n            ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "col-md-12 mt-3");
            __builder.OpenElement(67, "textarea");
            __builder.AddAttribute(68, "rows", "1");
            __builder.AddAttribute(69, "style", "width:100%");
            __builder.AddContent(70, 
#nullable restore
#line 87 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
                                                        Msg

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 91 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "D:\Tutorials\Paging\Client\Pages\DataGrid.razor"
       
    bool InitialLoad = true;
    int CurrentPageNumber = 1;
    int RecsPerPage = 5;
    string Msg = "";

    List<AmigoModel> Amigos = new();

    protected async override Task OnInitializedAsync()
    {   
        Amigos = await GetAllAmigosAsync( CurrentPageNumber, RecsPerPage);
        await base.OnInitializedAsync().ConfigureAwait(false);        
    }

    public async void GetPreviousPage()
    {
        if ( CurrentPageNumber > 1) { CurrentPageNumber--;}
        Amigos = await GetAllAmigosAsync( CurrentPageNumber, RecsPerPage);
        this.StateHasChanged();
    }

    public async void GetNextPage()
    {        
        Amigos = await GetAllAmigosAsync( ++CurrentPageNumber, RecsPerPage);   
        this.StateHasChanged();
    }

    private async void RecsPerPageChange()
    {
        Amigos = await GetAllAmigosAsync( CurrentPageNumber, RecsPerPage);
        this.StateHasChanged();
    }

    protected async Task<List<AmigoModel>> GetAllAmigosAsync( int curPageNumber, int recsPerPage)
    {    
        List<AmigoModel> amg = new();
        try
        {            
            using ( HttpClient h = new())
            {
                h.DefaultRequestHeaders.Clear();
                h.DefaultRequestHeaders.ConnectionClose = true;
                //  Define o modo de recebimento dos dados (JSON) . Poderia ser XML por ex;
                h.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //  Informa o endere??o base (parte fixa) da API
                h.BaseAddress = new Uri( BaseAddress); // Exemplo : https://localhost:44301/

                //  Envia o request (getasync) com o URI universal resource identifier
                using (HttpResponseMessage m = await h.GetAsync($"api/Amigos/Gumbo/{curPageNumber}&{recsPerPage}"))
                {
                    if (m.IsSuccessStatusCode)
                    {
                        //  Recebe a resposta com os dados requisitados e converte no Amigos Model
                        var dados = await m.Content.ReadAsStringAsync();
                        amg = Newtonsoft.Json.JsonConvert.DeserializeObject<List<AmigoModel>>(dados);
                            
                        Msg = (amg.Count == 0) ? "Status " + $"{m.StatusCode} - " +"No records found"  
                                               : "Status " + $"{m.StatusCode} - {amg.Count} record(s) to show";
                    }
                    else
                        Msg = "Status " + $"{m.StatusCode} - " + m.ReasonPhrase;                        
                }
            }
        }
        catch (Exception ex) { Msg = ex.Message; }  

        //  Send result back
        return amg;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
