#pragma checksum "C:\Users\myrta\source\repos\testNdoc\testNdoc\Views\Admin\TableDocument.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9c56b63ae950aab0f869d82b58f0edbe7a5cf39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_TableDocument), @"mvc.1.0.view", @"/Views/Admin/TableDocument.cshtml")]
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
#line 1 "C:\Users\myrta\source\repos\testNdoc\testNdoc\Views\_ViewImports.cshtml"
using testNdoc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\myrta\source\repos\testNdoc\testNdoc\Views\_ViewImports.cshtml"
using testNdoc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9c56b63ae950aab0f869d82b58f0edbe7a5cf39", @"/Views/Admin/TableDocument.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e93b8b1548dfbd2d369b6e6bc9d6efbbaad31285", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_TableDocument : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Documents>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\myrta\source\repos\testNdoc\testNdoc\Views\Admin\TableDocument.cshtml"
  
    ViewBag.Title = "Каталог компонентов";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-sm\">\r\n    <tr>\r\n        <th>Имя компонента</th>\r\n\r\n    </tr>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\myrta\source\repos\testNdoc\testNdoc\Views\Admin\TableDocument.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td style=\"cursor:pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 266, "\"", 298, 3);
            WriteAttributeValue("", 276, "GetDocuments(", 276, 13, true);
#nullable restore
#line 14 "C:\Users\myrta\source\repos\testNdoc\testNdoc\Views\Admin\TableDocument.cshtml"
WriteAttributeValue("", 289, item.Id, 289, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 297, ")", 297, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n                ");
#nullable restore
#line 17 "C:\Users\myrta\source\repos\testNdoc\testNdoc\Views\Admin\TableDocument.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 18 "C:\Users\myrta\source\repos\testNdoc\testNdoc\Views\Admin\TableDocument.cshtml"
           Write(Html.DisplayFor(modelItem => item.FileName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 22 "C:\Users\myrta\source\repos\testNdoc\testNdoc\Views\Admin\TableDocument.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Documents>> Html { get; private set; }
    }
}
#pragma warning restore 1591