#pragma checksum "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f811aa9469f3c414fcfaca177d4122088b689cfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ControlCenter_DynamicContentList), @"mvc.1.0.view", @"/Views/ControlCenter/DynamicContentList.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\_ViewImports.cshtml"
using General.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\_ViewImports.cshtml"
using General.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\_ViewImports.cshtml"
using General.Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\_ViewImports.cshtml"
using ControlCenter.WebUI.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\_ViewImports.cshtml"
using ControlCenter.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f811aa9469f3c414fcfaca177d4122088b689cfe", @"/Views/ControlCenter/DynamicContentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87b2a70599c224344c10ce9d23bac692ab469ec6", @"/Views/_ViewImports.cshtml")]
    public class Views_ControlCenter_DynamicContentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GeneralDynamicContent1>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "true", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "false", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ControlCenter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateDynamicContent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-validate-jquery"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteDynamicContent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
  
    ViewData["Title"] = "DynamicContentList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""card col-md-12 float-left"">

    <div class=""card-header header-elements-inline"">
        <h5 class=""card-title"">Eğitim Kartları</h5>
        <div class=""header-elements"">
            <div class=""list-icons"">
                <a class=""list-icons-item"" data-action=""collapse""></a>
                <a class=""list-icons-item"" data-action=""reload""></a>
                <a class=""list-icons-item"" data-action=""remove""></a>
            </div>
        </div>
    </div>

    <div class=""col-12"">
        <div class=""sidebar-content col-md-4"" style=""float:left"">
            <div class=""card card"">
                <div class=""card-header bg-transparent header-elements-inline"">
                    <span class=""card-title font-weight-semibold"">Yemi Eğitim Kartı Oluştur</span>
                    <div class=""header-elements"">
                        <div class=""list-icons"">
                            <a class=""list-icons-item"" data-action=""collapse""></a>
                        </div>
   ");
            WriteLiteral("                 </div>\r\n                </div>\r\n                <div class=\"card-body\">\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f811aa9469f3c414fcfaca177d4122088b689cfe9224", async() => {
                WriteLiteral("\r\n                        <label>Eğitim Başlığı</label>\r\n                        <textarea name=\"Subject\"");
                BeginWriteAttribute("value", " value=\"", 1517, "\"", 1539, 1);
#nullable restore
#line 36 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
WriteAttributeValue("", 1525, Model.Subject, 1525, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" class=\"form-control summernote\"></textarea>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f811aa9469f3c414fcfaca177d4122088b689cfe10075", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 37 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Subject);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <br />\r\n                        <label>Eğitim Kısa İçeriği</label>\r\n                        <textarea name=\"Descriptions\"");
                BeginWriteAttribute("value", " value=\"", 1840, "\"", 1867, 1);
#nullable restore
#line 40 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
WriteAttributeValue("", 1848, Model.Descriptions, 1848, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" class=\"form-control summernote\"></textarea>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f811aa9469f3c414fcfaca177d4122088b689cfe12473", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 41 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Descriptions);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <br />\r\n                        <label>Url Başlığı</label>\r\n                        <input type=\"text\" name=\"UrlName\"");
                BeginWriteAttribute("value", " value=\"", 2169, "\"", 2191, 1);
#nullable restore
#line 44 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
WriteAttributeValue("", 2177, Model.UrlName, 2177, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control \" />\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f811aa9469f3c414fcfaca177d4122088b689cfe14836", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 45 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UrlName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <br />\r\n                        <label>Url</label>\r\n                        <input type=\"text\" name=\"Url\"");
                BeginWriteAttribute("value", " value=\"", 2445, "\"", 2463, 1);
#nullable restore
#line 48 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
WriteAttributeValue("", 2453, Model.Url, 2453, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control url\" />\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f811aa9469f3c414fcfaca177d4122088b689cfe17181", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 49 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Url);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        <br />
                        <div class=""form-group"">
                            <div class=""row"">
                                <div class=""col-md-12"" style=""float:left"">
                                    <label>Durumu</label>
                                    <select class=""custom-select"" onchange=""mySelect3(event)"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f811aa9469f3c414fcfaca177d4122088b689cfe19344", async() => {
                    WriteLiteral("Seç");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f811aa9469f3c414fcfaca177d4122088b689cfe20605", async() => {
                    WriteLiteral("Aktif");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f811aa9469f3c414fcfaca177d4122088b689cfe21868", async() => {
                    WriteLiteral("DeAktif");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </select>\r\n                                    <input name=\"Status\" type=\"hidden\" id=\"select3\"");
                BeginWriteAttribute("value", " value=\"", 3305, "\"", 3326, 1);
#nullable restore
#line 60 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
WriteAttributeValue("", 3313, Model.Status, 3313, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f811aa9469f3c414fcfaca177d4122088b689cfe23694", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 61 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Status);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>


                            </div>
                        </div>
                        <br />
                        <button type=""submit"" class=""btn btn-raised btn-primary"" id=""form3Submit""><i class=""icon-plus2""></i> Oluştur</button>
                        <button type=""reset"" class=""btn btn-raised btn-danger""><i class=""icon-reset""></i> Sıfırla</button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
              
                </div>
            </div>
        </div>


        <div class=""sidebar-content col-md-8"" style=""float:left"">
            <div class=""card card"">
                <div class=""card-header bg-transparent header-elements-inline"">
                    <span class=""card-title font-weight-semibold"">Eğitim Kartları</span>
                    <div class=""header-elements"">
                        <div class=""list-icons"">
                            <a class=""list-icons-item"" data-action=""collapse""></a>
                        </div>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""form-group"">

                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f811aa9469f3c414fcfaca177d4122088b689cfe28394", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 91 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
                             if (Model.DynamicContent1s.Count() > 0)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <table class=""table table-responsive datatable-column-search-selects"">
                                    <thead>
                                        <tr>
                                            <th><input type=""checkbox"" id=""checkAll"" />&nbsp;<input type=""submit"" class=""btn btn-dark"" value=""Sil"" onclick=""return confirm('Silmek İşlemine Devam Edilsin mi?')"" /></th>
                                            <th>Eğitim</th>
                                            <th>Tarih</th>
                                            <th>Url Başlığı</th>
                                            <th>Url</th>
                                            <td>Durum</td>
                                            <th class=""text-center"">Düzenle</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 106 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
                                         foreach (var Model in Model.DynamicContent1s)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <tr>\r\n                                            <td><input type=\"checkbox\" name=\"Id\" class=\"cb-element\"");
                BeginWriteAttribute("value", " value=\"", 6099, "\"", 6116, 1);
#nullable restore
#line 109 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
WriteAttributeValue("", 6107, Model.Id, 6107, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n                                            <td>");
#nullable restore
#line 110 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
                                           Write(Model.Subject);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 111 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
                                           Write(Model.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 112 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
                                           Write(Model.UrlName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 113 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
                                           Write(Model.Url);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 114 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
                                             if (Model.Status == "true")
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <td><span class=\"badge badge-info\">Aktif</span></td>\r\n");
#nullable restore
#line 117 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
                                            }
                                            else if (Model.Status == "false")
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <td><span class=\"badge badge-danger\">DeAktif</span></td>\r\n");
#nullable restore
#line 121 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
                                            }
                                            else if (Model.Status == null)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <td><span class=\"badge badge-warning\">Seçilmemiş</span></td>\r\n");
#nullable restore
#line 125 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            <td class=""text-center"">
                                                <div class=""list-icons"">
                                                    <div class=""dropdown"">
                                                        <a href=""#"" class=""list-icons-item"" data-toggle=""dropdown"">
                                                            <i class=""icon-menu9""></i>
                                                        </a>
                                                        <div class=""dropdown-menu dropdown-menu-right"">

                                                            <a");
                BeginWriteAttribute("href", " href=\"", 7881, "\"", 7931, 2);
                WriteAttributeValue("", 7888, "/ControlCenter/EditDynamicContent/", 7888, 34, true);
#nullable restore
#line 134 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
WriteAttributeValue("", 7922, Model.Id, 7922, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""dropdown-item""><i class=""fa fa-edit""></i> Düzenle</a>

                                                        </div>
                                                    </div>
                                                </div>
                                            </td>
                                        </tr>
");
#nullable restore
#line 141 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </tbody>\r\n\r\n                                </table>\r\n");
#nullable restore
#line 146 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"alert alert-warning\">\r\n                                    <h4>Listenizde Eğitim Bulunmuyor</h4>\r\n                                    <br />\r\n                                </div>\r\n");
#nullable restore
#line 154 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 168 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
             if (TempData["DynamicContentSuccess"] != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <script>\r\n                    $(document).ready(function () {\r\n                        Swal.fire(\'Success\', \'success\');\r\n                    });\r\n\r\n                </script>\r\n");
#nullable restore
#line 176 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\ControlCenter\DynamicContentList.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        ");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GeneralDynamicContent1> Html { get; private set; }
    }
}
#pragma warning restore 1591
