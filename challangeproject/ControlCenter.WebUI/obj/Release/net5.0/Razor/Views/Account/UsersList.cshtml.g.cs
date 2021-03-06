#pragma checksum "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\Account\UsersList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0ccb31db80e59726a608667608deecbd2253ae1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_UsersList), @"mvc.1.0.view", @"/Views/Account/UsersList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0ccb31db80e59726a608667608deecbd2253ae1", @"/Views/Account/UsersList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87b2a70599c224344c10ce9d23bac692ab469ec6", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_UsersList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ControlCenter.Identity.ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\Account\UsersList.cshtml"
  
    ViewData["Title"] = "UsersList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">

    <div class=""card-header header-elements-inline"">
        <h5 class=""card-title"">Kullanıcı Listesi</h5>
        <div class=""header-elements"">
            <div class=""list-icons"">
                <a class=""list-icons-item"" data-action=""collapse""></a>
                <a class=""list-icons-item"" data-action=""reload""></a>
                <a class=""list-icons-item"" data-action=""remove""></a>
            </div>
        </div>
    </div>


    <div class=""card-body"">

        <div class=""alert alert-success"">
            <p>Sisteminizde bulunan aktif kullanıcıların listesine buradan ulaşabilirsiniz.</p>
        </div>

                        <table class=""table datatable-column-search-selects"">
            <thead>
                <tr>
                    <th>İsim Soyisim</th>
                    <th>Kullancı Adı</th>
                    <th>Doğum Tarihi</th>
                    <th>Email</th>
                    <th>Telefon</th>
                    <th>Referans Num");
            WriteLiteral("arası</th>\r\n                    <th>Durum</th>\r\n                    <th class=\"text-center\">Düzenle</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 42 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\Account\UsersList.cshtml"
                 foreach (var user in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\Account\UsersList.cshtml"
                   Write(user.NameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\Account\UsersList.cshtml"
                   Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 47 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\Account\UsersList.cshtml"
                   Write(user.BirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 48 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\Account\UsersList.cshtml"
                   Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\Account\UsersList.cshtml"
                   Write(user.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 50 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\Account\UsersList.cshtml"
                   Write(user.ReferanceNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 51 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\Account\UsersList.cshtml"
                     if (user.AdminActivated == "true")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><span class=\"badge badge-info\">Aktif</span></td>\r\n");
#nullable restore
#line 54 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\Account\UsersList.cshtml"
                    }
                    else if (user.AdminActivated == "new")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><span class=\"badge badge-warning\">Yeni</span></td>\r\n");
#nullable restore
#line 58 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\Account\UsersList.cshtml"
                    }
                    else if (user.AdminActivated == "waiting")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><span class=\"badge badge-danger\">Bekliyor</span></td>\r\n");
#nullable restore
#line 62 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\Account\UsersList.cshtml"
                    }
                    else if (user.AdminActivated == "null")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><span class=\"badge badge-danger\">Yeni</span></td>\r\n");
#nullable restore
#line 66 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\Account\UsersList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <td class=""text-center"">
                        <div class=""list-icons"">
                            <div class=""dropdown"">
                                <a href=""#"" class=""list-icons-item"" data-toggle=""dropdown"">
                                    <i class=""icon-menu9""></i>
                                </a>
                                <div class=""dropdown-menu dropdown-menu-right"">
                                    <button class=""dropdown-item""");
            BeginWriteAttribute("onclick", " onclick=\"", 2953, "\"", 3007, 3);
            WriteAttributeValue("", 2963, "window.location=\'/Account/EditUser/", 2963, 35, true);
#nullable restore
#line 74 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\Account\UsersList.cshtml"
WriteAttributeValue("", 2998, user.Id, 2998, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3006, "\'", 3006, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"icon-pencil3\"></i> Düzenle</button>\r\n                                    <button class=\"dropdown-item\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3121, "\"", 3186, 3);
            WriteAttributeValue("", 3131, "window.location=\'/UserFunctions/UserDashboard/", 3131, 46, true);
#nullable restore
#line 75 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\Account\UsersList.cshtml"
WriteAttributeValue("", 3177, user.Id, 3177, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3185, "\'", 3185, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"icon-folder-open2\"></i> Kullanıcı Dosyaları</button>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 81 "C:\Users\OSX\Desktop\PSO AKADEMİ\ControlCenter.WebUI\Views\Account\UsersList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n\r\n\r\n\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ControlCenter.Identity.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
