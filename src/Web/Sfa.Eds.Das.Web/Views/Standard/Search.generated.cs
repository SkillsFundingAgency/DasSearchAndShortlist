﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sfa.Eds.Das.Web.Views.Standard
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
    using Sfa.Eds.Das.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Standard/Search.cshtml")]
    public partial class Search : System.Web.Mvc.WebViewPage<Sfa.Eds.Das.Web.Models.StandardCriteria>
    {
        public Search()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Standard\Search.cshtml"
  
    ViewBag.Title = "Home Page";

            
            #line default
            #line hidden
WriteLiteral("\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" role=\"main\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" href=\"appBrowseSearch.html\"");

WriteLiteral(" class=\"link-back\"");

WriteLiteral(">Back</a>\r\n\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n\r\n            <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n                Find an apprenticeship standard\r\n            </h1>\r\n\r\n");

            
            #line 15 "..\..\Views\Standard\Search.cshtml"
            
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Standard\Search.cshtml"
             using (Html.BeginForm("SearchResults", "Standard", FormMethod.Get, new {@class = "search-box" }))
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <legend>\r\n                        <label");

WriteLiteral(" for=\"input-keywords\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"form-hint\"");

WriteLiteral(">\r\n                            Enter a job role or keyword (eg \'accountant\' or \'e" +
"ngineering\')\r\n                        </span>\r\n                        </label>\r" +
"\n\r\n                        <span");

WriteLiteral(" class=\"error-message\"");

WriteLiteral("></span>\r\n                    </legend>\r\n                    <input");

WriteLiteral(" type=\"search\"");

WriteLiteral(" id=\"keywords\"");

WriteLiteral(" name=\"Keywords\"");

WriteLiteral(" class=\"text-box form-control\"");

WriteLiteral(" maxlength=\"200\"");

WriteLiteral(" style=\"width: 100%;\"");

WriteLiteral(" placeholder=\"\"");

WriteLiteral(">\r\n                </div>                       \r\n");

WriteLiteral("                <input");

WriteLiteral(" class=\"button margin-top-x2\"");

WriteLiteral(" id=\"submit-keywords\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Search\"");

WriteLiteral(" />\r\n");

            
            #line 30 "..\..\Views\Standard\Search.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("           \r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"column-third\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"related-container\"");

WriteLiteral(">\r\n                <aside");

WriteLiteral(" class=\"related\"");

WriteLiteral(" id=\"related\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"inner group related-subsection\"");

WriteLiteral(">\r\n                        <h2");

WriteLiteral(" id=\"parent-subsection\"");

WriteLiteral(">Employers</h2>\r\n                        <nav");

WriteLiteral(" role=\"navigation\"");

WriteLiteral(" aria-labelledby=\"parent-subsection\"");

WriteLiteral(">\r\n                            <a");

WriteLiteral(" href=\"\"");

WriteLiteral(">\r\n                                Employ an apprentice\r\n                        " +
"    </a>\r\n                        </nav>\r\n                    </div>\r\n\r\n        " +
"            <div");

WriteLiteral(" class=\"inner group\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" class=\"return-to-top\"");

WriteLiteral(" href=\"#content\"");

WriteLiteral(">Return to top ↑</a>\r\n                    </div>\r\n\r\n                </aside>\r\n   " +
"         </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</main>");

        }
    }
}
#pragma warning restore 1591
