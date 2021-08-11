#pragma checksum "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57cd76b951b6197d7e51ca3add8943a18adf5b7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ControlCenter_Importants), @"mvc.1.0.view", @"/Views/ControlCenter/Importants.cshtml")]
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
#line 1 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\_ViewImports.cshtml"
using General.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\_ViewImports.cshtml"
using General.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\_ViewImports.cshtml"
using General.Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\_ViewImports.cshtml"
using ControlCenter.WebUI.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\_ViewImports.cshtml"
using ControlCenter.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57cd76b951b6197d7e51ca3add8943a18adf5b7f", @"/Views/ControlCenter/Importants.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87b2a70599c224344c10ce9d23bac692ab469ec6", @"/Views/_ViewImports.cshtml")]
    public class Views_ControlCenter_Importants : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<userTaskModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-default  letter-icon-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ControlCenter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteDo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
  
    ViewData["Title"] = "Importants";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<table id=""example"" class=""table datatable-column-search-selects"">
    <thead>
        <tr>
            <th>Tarih</th>
            <th>Öncelik</th>
            <th>Başlık</th>
            <th>İçerik</th>
            <th>Durum</th>
            <th class=""text-center"">Düzenle</th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 21 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
         if (Model.userTasks != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
             foreach (var item in Model.userTasks)
            {
                int pastTime = Convert.ToInt32((DateTime.Now - item.Date).TotalDays);

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"text-center\">\r\n");
#nullable restore
#line 28 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
                         if (pastTime == 0 || pastTime < 1)
                        {
                            pastTime = Convert.ToInt32((DateTime.Now - item.Date).TotalHours);

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h6 class=\"mb-0\">");
#nullable restore
#line 31 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
                                        Write(pastTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <div class=\"font-size-sm text-muted line-height-1\">saat önce</div>\r\n");
#nullable restore
#line 33 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h6 class=\"mb-0\">");
#nullable restore
#line 36 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
                                        Write(pastTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <div class=\"font-size-sm text-muted line-height-1\">gün önce</div>\r\n");
#nullable restore
#line 38 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 41 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
                     if (item.Priority == "0")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <td>
                            <div class=""d-flex align-items-center"">
                                <div class=""mr-3"">
                                    <a href=""#"" class=""btn bg-grey-400 rounded-round btn-icon btn-sm"">
                                        <span class=""letter-icon""></span>
                                    </a>
                                </div>
                                <div>
                                    <a href=""#"" class=""text-default font-weight-semibold letter-icon-title"">Düşük</a>
                                </div>
                            </div>
                        </td>
");
#nullable restore
#line 55 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
                    }
                    else if (item.Priority == "1")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <td>
                            <div class=""d-flex align-items-center"">
                                <div class=""mr-3"">
                                    <a href=""#"" class=""btn bg-success-400 rounded-round btn-icon btn-sm"">
                                        <span class=""letter-icon""></span>
                                    </a>
                                </div>
                                <div>
                                    <a href=""#"" class=""text-default font-weight-semibold letter-icon-title"">Normal</a>
                                </div>
                            </div>
                        </td>
");
#nullable restore
#line 70 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
                    }
                    else if (item.Priority == "2")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <td>
                            <div class=""d-flex align-items-center"">
                                <div class=""mr-3"">
                                    <a href=""#"" class=""btn bg-danger-400 rounded-round btn-icon btn-sm"">
                                        <span class=""letter-icon""></span>
                                    </a>
                                </div>
                                <div>
                                    <a href=""#"" class=""text-default font-weight-semibold letter-icon-title"">Yüksek</a>
                                </div>
                            </div>
                        </td>
");
#nullable restore
#line 85 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <td>
                            <div class=""d-flex align-items-center"">
                                <div class=""mr-3"">
                                    <a href=""#"" class=""btn bg-warning-400 rounded-round btn-icon btn-sm"">
                                        <span class=""letter-icon""></span>
                                    </a>
                                </div>
                                <div>
                                    <a href=""#"" class=""text-default font-weight-semibold letter-icon-title"">Bilinmiyor</a>
                                </div>
                            </div>
                        </td>
");
#nullable restore
#line 100 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <td>\r\n                        <div class=\"d-flex align-items-center\">\r\n\r\n                            <div>\r\n                                <a href=\"#\" class=\"text-default font-weight-semibold letter-icon-title\">");
#nullable restore
#line 106 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
                                                                                                   Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n                    <td>\r\n                        <div class=\"font-weight-semibold\">");
#nullable restore
#line 112 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
                                                     Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <span class=\"text-muted\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57cd76b951b6197d7e51ca3add8943a18adf5b7f14188", async() => {
                WriteLiteral("Dosyayı görüntülemek için tıklayın.");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4999, "~/doFiles/", 4999, 10, true);
#nullable restore
#line 113 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
AddHtmlAttributeValue("", 5009, item.fileUrl, 5009, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n                    </td>\r\n");
#nullable restore
#line 115 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
                     if (item.Status == "Active")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            <div class=\"text-muted font-size-sm\"><span class=\"badge badge-mark border-blue mr-1\"></span> Aktif</div>\r\n                        </td>\r\n");
#nullable restore
#line 120 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
                    }
                    else if (item.Status == "Complated")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            <div class=\"text-muted font-size-sm\"><span class=\"badge badge-mark border-success mr-1\"></span> Tamamlandı</div>\r\n                        </td>\r\n");
#nullable restore
#line 126 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
                    }
                    else if (item.Status == "Cancelled")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            <div class=\"text-muted font-size-sm\"><span class=\"badge badge-mark border-danger mr-1\"></span> Tamamlandı</div>\r\n                        </td>\r\n");
#nullable restore
#line 132 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            <div class=\"text-muted font-size-sm\"><span class=\"badge badge-mark border-blue mr-1\"></span> Aktif</div>\r\n                        </td>\r\n");
#nullable restore
#line 138 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <td class=""text-center"">
                        <div class=""list-icons"">
                            <div class=""list-icons-item dropdown"">
                                <a href=""#"" class=""list-icons-item dropdown-toggle caret-0"" data-toggle=""dropdown""><i class=""icon-menu7""></i></a>
                                <div class=""dropdown-menu dropdown-menu-right"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 6701, "\"", 6738, 2);
            WriteAttributeValue("", 6708, "/ControlCenter/EditDo/", 6708, 22, true);
#nullable restore
#line 144 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
WriteAttributeValue("", 6730, item.Id, 6730, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"dropdown-item\"><i class=\"icon-undo\"></i> Düzenle</a>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57cd76b951b6197d7e51ca3add8943a18adf5b7f19306", async() => {
                WriteLiteral("\r\n                                        <input type=\"hidden\" name=\"doId\"");
                BeginWriteAttribute("value", " value=\"", 6984, "\"", 7000, 1);
#nullable restore
#line 146 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
WriteAttributeValue("", 6992, item.Id, 6992, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <button class=\"dropdown-item\" type=\"submit\"><i class=\"icon-cross2 text-danger\"></i>Sil</button>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 157 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 157 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Importants.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<userTaskModel> Html { get; private set; }
    }
}
#pragma warning restore 1591