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
    
    #line 1 "..\..\Views\Shared\_List_Data.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 2 "..\..\Views\Shared\_List_Data.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Shared\_List_Data.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Shared\_List_Data.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_List_Data.cshtml")]
    public partial class _Views_Shared__List_Data_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__List_Data_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Shared\_List_Data.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;
    var fields = ViewBag.Fields as FieldItem[];

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n");

            
            #line 13 "..\..\Views\Shared\_List_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Shared\_List_Data.cshtml"
             foreach (var item in fields)
            {

            
            #line default
            #line hidden
WriteLiteral("                <th><a");

WriteAttribute("href", Tuple.Create(" href=\"", 415), Tuple.Create("\"", 459)
            
            #line 15 "..\..\Views\Shared\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 422), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl(item.Name))
            
            #line default
            #line hidden
, 422), false)
);

WriteLiteral(">");

            
            #line 15 "..\..\Views\Shared\_List_Data.cshtml"
                                                               Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a></th>\r\n");

            
            #line 16 "..\..\Views\Shared\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <th>操作</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");

            
            #line 21 "..\..\Views\Shared\_List_Data.cshtml"
        
            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\Shared\_List_Data.cshtml"
         foreach (var entity in Model)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n");

            
            #line 24 "..\..\Views\Shared\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Shared\_List_Data.cshtml"
                 foreach (var item in fields)
                {
                    
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Shared\_List_Data.cshtml"
               Write(Html.Partial("_List_Data_Item", new Pair(entity, item)));

            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Shared\_List_Data.cshtml"
                                                                            
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 28 "..\..\Views\Shared\_List_Data.cshtml"
                 if (ManageProvider.User.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 31 "..\..\Views\Shared\_List_Data.cshtml"
                   Write(Html.Partial("_List_Data_Action", (Object)entity[fact.Unique]));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n");

            
            #line 33 "..\..\Views\Shared\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n");

            
            #line 35 "..\..\Views\Shared\_List_Data.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>\r\n");

        }
    }
}
#pragma warning restore 1591