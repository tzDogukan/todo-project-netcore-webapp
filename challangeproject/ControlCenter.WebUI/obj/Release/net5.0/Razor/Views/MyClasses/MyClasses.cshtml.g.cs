#pragma checksum "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\MyClasses\MyClasses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b63a21a8e4b4e921f0fba3b7895d70e4ade05b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyClasses_MyClasses), @"mvc.1.0.view", @"/Views/MyClasses/MyClasses.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b63a21a8e4b4e921f0fba3b7895d70e4ade05b0", @"/Views/MyClasses/MyClasses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87b2a70599c224344c10ce9d23bac692ab469ec6", @"/Views/_ViewImports.cshtml")]
    public class Views_MyClasses_MyClasses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyClassesMasterModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "tr", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "usd", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MyClasses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateSystemPaymentClass", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Partials/RolePaymentClass/_rolepaymentclass.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateRolePaymentClass", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\MyClasses\MyClasses.cshtml"
  
    ViewData["Title"] = "MyClasses";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""card"">

    <div class=""card-header header-elements-inline"">
        <h5 class=""card-title"">Admin Sınıf Kontrolleri</h5>
        <div class=""header-elements"">
            <div class=""list-icons"">
                <a class=""list-icons-item"" data-action=""collapse""></a>
                <a class=""list-icons-item"" data-action=""reload""></a>
                <a class=""list-icons-item"" data-action=""remove""></a>
            </div>
        </div>
    </div>
    <div class=""col-12"">
        <div class=""card-body"">
            <div class=""form-group"">
                <!-- Sidebar content -->
                <div class=""sidebar-content col-md-4"" style=""float:left"">
                    <div class=""card-body p-0"">
                        <ul class=""nav nav-sidebar mb-2"">
                            <li class=""nav-item"">
                                <a href=""#mydropbox"" class=""nav-link"" data-toggle=""tab"">
                                    <i class=""icon-file-download""></i>
         ");
            WriteLiteral(@"                           Dosyalarım
                                    <span class=""badge bg-primary badge-pill ml-auto"">29</span>
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a href=""#myfile"" class=""nav-link"" data-toggle=""tab"">
                                    <i class=""icon-file-pdf""></i>
                                    Belgelerim
                                    <span class=""badge bg-warning badge-pill ml-auto"">29</span>
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a href=""#myadress"" class=""nav-link"" data-toggle=""tab"">
                                    <i class=""icon-file-text""></i>
                                    Adreslerim
                                    <span class=""badge bg-info badge-pill ml-auto"">16</span>
                                </a>
    ");
            WriteLiteral(@"                        </li>
                            <li class=""nav-item"">
                                <a href=""#mycomment"" class=""nav-link"" data-toggle=""tab"">
                                    <i class=""icon-comment""></i>
                                    Yorumlarım
                                    <span class=""badge bg-danger badge-pill ml-auto"">16</span>
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a href=""#mytask"" class=""nav-link"" data-toggle=""tab"">
                                    <i class=""icon-task""></i>
                                    Görevlerim
                                    <span class=""badge bg-success badge-pill ml-auto"">16</span>
                                </a>
                            </li>
                            <li class=""nav-item-divider""></li>
                        </ul>
                    </div>
                    <!-- /n");
            WriteLiteral(@"avigation -->
                </div>

                <!-- Admin My Class -->
                <div class=""card card-collapsed"">
                    <div class=""card-header bg-primary header-elements-inline"">
                        <span class=""card-title font-weight-semibold"">Sistem Sınıfları</span>
                        <div class=""header-elements"">
                            <div class=""list-icons"">
                                <a class=""list-icons-item"" data-action=""collapse""></a>
                            </div>
                        </div>
                    </div>

                    <div class=""card-body"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b63a21a8e4b4e921f0fba3b7895d70e4ade05b011183", async() => {
                WriteLiteral(@"
                            <ul class=""media-list"">

                                <!--Forach Buraya Gelicek-->
                                <li class=""media"">
                                    <div class=""media-body"">
                                        <input type=""text"" class=""form-control"" value=""Free Sınıf "" />
                                    </div>
                                    <div class=""ml-3 align-self-center"">
                                        <a href=""#""><i class=""icon-cog5"">Değişikliği Kaydet</i></a>
                                    </div>
                                </li>
                                <!--Forach Buraya Gelicek-->
                            </ul>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>

                    <div class=""card-footer d-flex justify-content-between align-items-center"">
                        <div class=""card card-collapsed"">
                            <div class=""card-header bg-transparent header-elements-inline"">
                                <span class=""card-title font-weight-semibold"">Yeni Sınıf Ekle</span>
                                <div class=""header-elements"">
                                    <div class=""list-icons"">
                                        <a class=""list-icons-item"" data-action=""collapse""></a>
                                    </div>
                                </div>
                            </div>
                            <div class=""card-body"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b63a21a8e4b4e921f0fba3b7895d70e4ade05b014014", async() => {
                WriteLiteral(@"
                                    <br />
                                    <input type=""text"" class=""form-control"" name=""SystemClassName"" placeholder=""Yeni Sınıf İsmi Gir"" />
                                    <br />
                                    <input type=""text"" class=""form-control"" name=""SystemClassTıme"" placeholder=""Süre Gir(Ay) Ör:1"" value=""1"" />
                                    <br />
                                    <div class=""form-group"">
                                        <label>Ödeme Türü Seç</label>
                                        <select class=""custom-select"" onchange=""mySelect3(event)"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b63a21a8e4b4e921f0fba3b7895d70e4ade05b014987", async() => {
                    WriteLiteral("Select");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b63a21a8e4b4e921f0fba3b7895d70e4ade05b016255", async() => {
                    WriteLiteral("TR");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b63a21a8e4b4e921f0fba3b7895d70e4ade05b017519", async() => {
                    WriteLiteral("USD");
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
                WriteLiteral(@"
                                        </select>
                                        <input name=""SystemClassCurrency"" type=""hidden"" id=""select3"" class=""form-control"" />
                                    </div>
                                    <br />
                                    <input type=""text"" class=""form-control"" name=""TotalPaid"" placeholder=""Toplam Ücret"" value=""150"" />
                                    <br />
                                    <div class=""clearfix"">
                                        <div class=""form-group pull-left"">
                                            <button type=""submit"" class=""btn btn-raised btn-primary""><i class=""icon-floppy-disk""></i> Kaydet</button>
                                            <button type=""reset"" class=""btn btn-raised btn-danger""><i class=""icon-reset""></i> Sıfırla</button>
                                        </div>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
                </div>
                <!-- admin My Class -->
                <!-- user My Class -->
                <div class=""card card-collapsed"">
                    <div class=""card-header bg-primary header-elements-inline"">
                        <span class=""card-title font-weight-semibold"">Sınıflarım</span>
                        <div class=""header-elements"">
                            <div class=""list-icons"">
                                <a class=""list-icons-item"" data-action=""collapse""></a>
                            </div>
                        </div>
                    </div>

                    <div class=""card-body"">
                        <table class=""table datatable"">
                            <thead>
                                <tr>
                                    <th>Sınıf İsmi</th>
                                    <th><span class=""fa fa-edit""></span");
            WriteLiteral("></th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n\r\n");
#nullable restore
#line 162 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\MyClasses\MyClasses.cshtml"
                                 foreach (var rolepaymentclass in Model.RolePaymentClasses)
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1b63a21a8e4b4e921f0fba3b7895d70e4ade05b023004", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 165 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\MyClasses\MyClasses.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => rolepaymentclass);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 166 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\MyClasses\MyClasses.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                    <div class=""card-footer d-flex justify-content-between align-items-center"">
                        <div class=""card card-collapsed"">
                            <div class=""card-header bg-transparent header-elements-inline"">
                                <span class=""card-title font-weight-semibold"">Yeni Sınıf Ekle</span>
                                <div class=""header-elements"">
                                    <div class=""list-icons"">
                                        <a class=""list-icons-item"" data-action=""collapse""></a>
                                    </div>
                                </div>
                            </div>
                            <div class=""card-body"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b63a21a8e4b4e921f0fba3b7895d70e4ade05b025782", async() => {
                WriteLiteral(@"
                                    <br />
                                    <input type=""text"" class=""form-control"" name=""RoleClassName"" placeholder=""Yeni Sınıf İsmi Gir"" />
                                    <br />
                                    <input type=""text"" class=""form-control"" name=""RoleClassTıme"" placeholder=""Süre Gir(Ay) Ör:1"" value=""1"" />
                                    <br />
                                    <div class=""form-group"">
                                        <label>Ödeme Türü Seç</label>
                                        <select class=""custom-select"" onchange=""mySelect4(event)"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b63a21a8e4b4e921f0fba3b7895d70e4ade05b026751", async() => {
                    WriteLiteral("Select");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b63a21a8e4b4e921f0fba3b7895d70e4ade05b028019", async() => {
                    WriteLiteral("TR");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b63a21a8e4b4e921f0fba3b7895d70e4ade05b029283", async() => {
                    WriteLiteral("USD");
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
                WriteLiteral(@"
                                        </select>
                                        <input name=""RoleClassCurrency"" type=""hidden"" id=""select4"" class=""form-control"" />
                                    </div>
                                    <br />
                                    <input type=""text"" class=""form-control"" name=""TotalPaid"" placeholder=""Toplam Ücret"" value=""150"" />
                                    <br />
                                    <div class=""clearfix"">
                                        <div class=""form-group pull-left"">
                                            <button type=""submit"" class=""btn btn-raised btn-primary""><i class=""icon-floppy-disk""></i> Kaydet</button>
                                            <button type=""reset"" class=""btn btn-raised btn-danger""><i class=""icon-reset""></i> Sıfırla</button>
                                        </div>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
                </div>
                <!-- user My Class -->

            </div>
            <!-- /sidebar content -->
            <!-- Right content -->
            <div class=""sidebar-content col-md-8"" style=""float:left"">
                <div class=""tab-content w-100 overflow-auto"">
                    <!-- My Dropbox -->

                    <div class=""tab-pane fade active show"" id=""mydropbox"">
                        <div class=""card"">
                            <div class=""card-header bg-transparent header-elements-inline"">
                                <h6 class=""card-title"">Dosyalarım</h6>
                                <div class=""header-elements"">
                                    <span class=""badge bg-blue"">test</span>
                                </div>
                            </div>
                            <div class=""table-responsive"">

                         ");
            WriteLiteral(@"   </div>
                        </div>
                    </div>

                    <!-- My File -->
                    <div class=""tab-pane fade"" id=""myfile"">
                        <div class=""card"">
                            <div class=""card-header bg-transparent header-elements-inline"">
                                <h6 class=""card-title"">Belgelerim</h6>
                                <div class=""header-elements"">
                                    <span class=""badge bg-blue"">test</span>
                                </div>
                            </div>

                            <div class=""table-responsive"">

                            </div>
                        </div>
                    </div>
                    <!-- My Adress -->
                    <div class=""tab-pane fade"" id=""myadress"">
                        <div class=""card"">
                            <div class=""card-header bg-transparent header-elements-inline"">
                           ");
            WriteLiteral(@"     <h6 class=""card-title"">Adreslerim</h6>
                                <div class=""header-elements"">
                                    <span class=""badge bg-blue"">test</span>
                                </div>
                            </div>

                            <div class=""table-responsive"">

                            </div>
                        </div>
                    </div>
                    <!-- My Comments -->
                    <div class=""tab-pane fade"" id=""mycomment"">
                        <div class=""card"">
                            <div class=""card-header bg-transparent header-elements-inline"">
                                <h6 class=""card-title"">Yorumlarım</h6>
                                <div class=""header-elements"">
                                    <span class=""badge bg-blue"">test</span>
                                </div>
                            </div>

                            <div class=""table-responsive"">

        ");
            WriteLiteral(@"                    </div>
                        </div>
                    </div>
                    <!-- My Task -->
                    <div class=""tab-pane fade"" id=""mytask"">
                        <div class=""card"">
                            <div class=""card-header bg-transparent header-elements-inline"">
                                <h6 class=""card-title"">Görevlerim</h6>
                                <div class=""header-elements"">
                                    <span class=""badge bg-blue"">test</span>
                                </div>
                            </div>

                            <div class=""table-responsive"">

                            </div>
                        </div>
                    </div>
                </div>
                <!-- /right content -->
            </div>

        </div>
        <!-- /inner container -->

    </div>
    <!-- /content area -->
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 307 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\MyClasses\MyClasses.cshtml"
     if (TempData["SystemPaymentClass"] != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\r\n            $(document).ready(function () {\r\n                Swal.fire(\'Success\', \'success\');\r\n            });\r\n\r\n        </script>\r\n");
#nullable restore
#line 315 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\MyClasses\MyClasses.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyClassesMasterModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
