#pragma checksum "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "100f7eb85b11313a28d723f8588ed1f2ffeba40e"
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
#line 6 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
using BlazorNorthwindUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
using BlazorNorthwindUI.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
using BlazorNorthwindUI.Utilities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/productdetail/{productid:int}")]
    public partial class ProductDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 13 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
 if (product != null) 
{ 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Product Detail for ");
            __builder.AddContent(2, 
#nullable restore
#line 15 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                            product.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                      product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                                               HandleSave

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "placeHolder", "Ürün Adı");
                __builder2.AddAttribute(16, "Class", "form-control");
                __builder2.AddAttribute(17, "Id", "productName");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                                                                                                 product.ProductName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.ProductName = __value, product.ProductName))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => product.ProductName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __Blazor.BlazorNorthwindUI.Pages.ProductDetail.TypeInference.CreateInputNumber_0(__builder2, 24, 25, "Ürün Fiyatı", 26, "form-control", 27, "unitPrice", 28, 
#nullable restore
#line 24 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                                                                                                    product.UnitPrice

#line default
#line hidden
#nullable disable
                , 29, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.UnitPrice = __value, product.UnitPrice)), 30, () => product.UnitPrice);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(34);
                __builder2.AddAttribute(35, "placeHolder", "Ürün Açıklaması");
                __builder2.AddAttribute(36, "Class", "form-control");
                __builder2.AddAttribute(37, "Id", "quantityPerUnit");
                __builder2.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                                                                                                                product.QuantityPerUnit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.QuantityPerUnit = __value, product.QuantityPerUnit))));
                __builder2.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => product.QuantityPerUnit));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group");
                __Blazor.BlazorNorthwindUI.Pages.ProductDetail.TypeInference.CreateInputNumber_1(__builder2, 44, 45, "Stok Adedi", 46, "form-control", 47, "unitsInStock", 48, 
#nullable restore
#line 30 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                                                                                                      product.UnitsInStock

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.UnitsInStock = __value, product.UnitsInStock)), 50, () => product.UnitsInStock);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group");
#nullable restore
#line 33 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
             if(categories!= null) 
            { 

#line default
#line hidden
#nullable disable
                __Blazor.BlazorNorthwindUI.Pages.ProductDetail.TypeInference.CreateInputSelectNumber_2(__builder2, 54, 55, "form-control", 56, "categoryId", 57, 
#nullable restore
#line 35 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                                                                                      product.CategoryId

#line default
#line hidden
#nullable disable
                , 58, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.CategoryId = __value, product.CategoryId)), 59, () => product.CategoryId, 60, (__builder3) => {
#nullable restore
#line 36 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                     foreach(var category in categories)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(61, "option");
                    __builder3.AddAttribute(62, "value", 
#nullable restore
#line 38 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                                        category.CategoryId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(63, 
#nullable restore
#line 38 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                                                              category.CategoryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 39 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
#nullable restore
#line 41 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n        ");
                __builder2.AddMarkupContent(65, "<button class=\"btn btn-primary\" type=\"submit\">Kaydet</button>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 45 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\Hakan\Desktop\WebTasarım\Blazor\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
       
    [Parameter]
    public int ProductId { get; set; }
    ProductViewModel product;
    CategoryListViewModel[] categories;

    protected override async Task OnInitializedAsync()
    {
        product = await ProductService.GetProductById(ProductId);
        categories = await CategoryService.GetCategories();
    }

    private void HandleSave()
    {
        ProductService.Save(product);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService CategoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
namespace __Blazor.BlazorNorthwindUI.Pages.ProductDetail
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "placeHolder", __arg0);
        __builder.AddAttribute(__seq1, "Class", __arg1);
        __builder.AddAttribute(__seq2, "Id", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "placeHolder", __arg0);
        __builder.AddAttribute(__seq1, "Class", __arg1);
        __builder.AddAttribute(__seq2, "Id", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelectNumber_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::BlazorNorthwindUI.Utilities.InputSelectNumber<T>>(seq);
        __builder.AddAttribute(__seq0, "Class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
