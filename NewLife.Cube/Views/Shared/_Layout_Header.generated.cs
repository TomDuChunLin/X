﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Layout_Header.cshtml")]
    public partial class _Views_Shared__Layout_Header_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Layout_Header_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Shared\_Layout_Header.cshtml"
 if (ViewBag.HeaderTitle + "" != "" || ViewBag.HeaderContent + "" != "")
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"page-header\"");

WriteLiteral(">\r\n        <h1>\r\n");

WriteLiteral("            ");

            
            #line 5 "..\..\Views\Shared\_Layout_Header.cshtml"
       Write(ViewBag.HeaderTitle);

            
            #line default
            #line hidden
WriteLiteral("\r\n            <small>\r\n                <i");

WriteLiteral(" class=\"ace-icon fa fa-angle-double-right\"");

WriteLiteral("></i>\r\n");

WriteLiteral("                ");

            
            #line 8 "..\..\Views\Shared\_Layout_Header.cshtml"
           Write(ViewBag.HeaderContent);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </small>\r\n        </h1>\r\n    </div>\r\n");

            
            #line 12 "..\..\Views\Shared\_Layout_Header.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
