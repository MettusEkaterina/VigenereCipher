#pragma checksum "C:\Users\mettu\source\repos\BlazorApp3\BlazorApp3\Pages\HandleInput.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cb21db39d15009aedb3e86d850313789c569931"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mettu\source\repos\BlazorApp3\BlazorApp3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mettu\source\repos\BlazorApp3\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mettu\source\repos\BlazorApp3\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mettu\source\repos\BlazorApp3\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mettu\source\repos\BlazorApp3\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mettu\source\repos\BlazorApp3\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mettu\source\repos\BlazorApp3\BlazorApp3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mettu\source\repos\BlazorApp3\BlazorApp3\_Imports.razor"
using BlazorApp3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mettu\source\repos\BlazorApp3\BlazorApp3\_Imports.razor"
using BlazorApp3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mettu\source\repos\BlazorApp3\BlazorApp3\Pages\HandleInput.razor"
using BlazorApp3.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class HandleInput : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Шифр Виженера</h1>\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row align-items-start");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-6 col-sm-12");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "param_block");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<h3>Исходный текст</h3>\r\n            ");
            __builder.OpenElement(11, "textarea");
            __builder.AddAttribute(12, "class", "form-control-file");
            __builder.AddAttribute(13, "id", "input");
            __builder.AddAttribute(14, "rows", "10");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\mettu\source\repos\BlazorApp3\BlazorApp3\Pages\HandleInput.razor"
                                                                             InputText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => InputText = __value, InputText));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-md-6 col-sm-12");
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "param_block");
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.AddMarkupContent(26, "<h3>Результат</h3>\r\n            ");
            __builder.OpenElement(27, "textarea");
            __builder.AddAttribute(28, "readonly", "readonly");
            __builder.AddAttribute(29, "class", "form-control-file");
            __builder.AddAttribute(30, "id", "result");
            __builder.AddAttribute(31, "rows", "10");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\mettu\source\repos\BlazorApp3\BlazorApp3\Pages\HandleInput.razor"
                                                                                                  ResultText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ResultText = __value, ResultText));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n<br>\r\n\r\n");
            __builder.AddMarkupContent(38, "<h5>Ключевое слово</h5>\r\n\r\n");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "row align-items-start");
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col-md-4 col-sm-12");
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "param_block");
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.OpenElement(48, "input");
            __builder.AddAttribute(49, "type", "text");
            __builder.AddAttribute(50, "class", "form-control");
            __builder.AddAttribute(51, "id", "keyWord");
            __builder.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\mettu\source\repos\BlazorApp3\BlazorApp3\Pages\HandleInput.razor"
                                                                         KeyWord

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => KeyWord = __value, KeyWord));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n    ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "col-md-4 col-sm-12");
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "param_block");
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "input-group mb-3");
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.OpenElement(66, "select");
            __builder.AddAttribute(67, "class", "custom-select");
            __builder.AddAttribute(68, "id", "actionSelect");
            __builder.AddAttribute(69, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Users\mettu\source\repos\BlazorApp3\BlazorApp3\Pages\HandleInput.razor"
                                                                        ChosenAction

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ChosenAction = __value, ChosenAction));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(71, "\r\n                    ");
            __builder.OpenElement(72, "option");
            __builder.AddAttribute(73, "selected", true);
            __builder.AddAttribute(74, "value", "1");
            __builder.AddMarkupContent(75, "Расшифровать");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.OpenElement(77, "option");
            __builder.AddAttribute(78, "value", "2");
            __builder.AddMarkupContent(79, "Зашифровать");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n    ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "col-md-4 col-sm-12");
            __builder.AddMarkupContent(87, "\r\n        ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "param_block");
            __builder.AddMarkupContent(90, "\r\n            ");
            __builder.OpenElement(91, "button");
            __builder.AddAttribute(92, "type", "button");
            __builder.AddAttribute(93, "class", "btn btn-primary");
            __builder.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\mettu\source\repos\BlazorApp3\BlazorApp3\Pages\HandleInput.razor"
                                                                    Run

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(95, "Преобразовать");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n\r\n");
#nullable restore
#line 49 "C:\Users\mettu\source\repos\BlazorApp3\BlazorApp3\Pages\HandleInput.razor"
 if (error != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(100, "    ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "style", "color: orangered");
            __builder.AddContent(103, 
#nullable restore
#line 51 "C:\Users\mettu\source\repos\BlazorApp3\BlazorApp3\Pages\HandleInput.razor"
                                   error

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n");
#nullable restore
#line 52 "C:\Users\mettu\source\repos\BlazorApp3\BlazorApp3\Pages\HandleInput.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\mettu\source\repos\BlazorApp3\BlazorApp3\Pages\HandleInput.razor"
 
    string ChosenAction { get; set; }
    string KeyWord { get; set; }    
    string InputText = "";
    string ResultText = "";
    string error;

    public async void Run()
    {
        try
        {
            bool encrypting;

            if (ChosenAction.Equals("1"))
            {
                encrypting = false;
            }
            else
            {
                encrypting = true;
            }

            ResultText = await vigenereService.GetResultTextAsync(InputText, KeyWord, encrypting);
            error = null;
        }
        catch (Exception e)
        {
            error = e.Message;
        }
        finally
        {
            this.StateHasChanged();
        }
    }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            InputText = await inputService.GetInputExampleAsync();
        }
        catch
        {
            InputText = "";
        }
        finally
        {
            KeyWord = @"скорпион";
            ChosenAction = @"1";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private InputService inputService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private VigenereCipherService vigenereService { get; set; }
    }
}
#pragma warning restore 1591
