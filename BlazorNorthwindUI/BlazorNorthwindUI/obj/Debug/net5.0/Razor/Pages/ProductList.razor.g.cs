#pragma checksum "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51164e62c33e4e989b724211e96f5c64771a3ccb"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorNorthwindUI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using BlazorNorthwindUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using BlazorNorthwindUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductList.razor"
using BlazorNorthwindUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductList.razor"
using BlazorNorthwindUI.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/productlist")]
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ProductList</h3>");
#nullable restore
#line 9 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductList.razor"
 if (productListViewModel == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 12 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>Product Id</th>\r\n                <th>Product Name</th>\r\n                <th>Category Id</th>\r\n                <th>Quantity Per Unit</th>\r\n                <th>Unit Price</th>\r\n                <th>Unıts In Stock</th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 28 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductList.razor"
             foreach(var item in productListViewModel)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 31 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductList.razor"
                     item.ProductId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 32 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductList.razor"
                     item.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 33 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductList.razor"
                     item.CategoryId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 34 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductList.razor"
                     item.QuantityPerUnit

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 35 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductList.razor"
                     item.UnitPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 36 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductList.razor"
                     item.UnitsInStock

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "th");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "btn btn-primary btn-sm");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductList.razor"
                                                                        ()=>GoToDetail(item.ProductId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, "Güncelle");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductList.razor"
                   
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductList.razor"
       
    ProductListViewModel[] productListViewModel;
    protected override async Task OnInitializedAsync()
    {
        productListViewModel = await ProductService.GetProducts();
    }

    void GoToDetail(int productId)
    {
        NavigationManager.NavigateTo("/productdetail/" + productId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
