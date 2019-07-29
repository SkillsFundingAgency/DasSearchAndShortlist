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

namespace Sfa.Das.Sas.Web.Views.Apprenticeship
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
    using Sfa.Das.Sas.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Apprenticeship/Search.cshtml")]
    public partial class Search : System.Web.Mvc.WebViewPage<Sfa.Das.Sas.Web.ViewModels.ApprenticeshipSearchViewModel>
    {
        public Search()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Apprenticeship\Search.cshtml"
  
    ViewBag.Title = "Home Page";
    ViewBag.Description = "The Find Apprenticeship Training service is for employers in England who want to find training courses for their apprentices and search for training providers.";
    ViewBag.PageID = "search-provider-home";

            
            #line default
            #line hidden
WriteLiteral("\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" role=\"main\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"grid-row apprenticeship-search\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" class=\"link-back\"");

WriteLiteral(" href=\"/\"");

WriteLiteral(">Back</a>\r\n            <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n                Find apprenticeship training\r\n            </h1>\r\n");

            
            #line 14 "..\..\Views\Apprenticeship\Search.cshtml"
            
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Apprenticeship\Search.cshtml"
             using (Html.BeginForm("SearchResults", "Apprenticeship", FormMethod.Get, new { @class = "search-box apprenticeship-search-form" }))
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"keywords\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(">Apprenticeship name or job role</span>\r\n                        <span");

WriteLiteral(" class=\"form-hint\"");

WriteLiteral(">Start typing the apprenticeship name</span>\r\n                    </label>\r\n     " +
"               <span");

WriteLiteral(" class=\"error-message\"");

WriteLiteral("></span>\r\n                    <div");

WriteLiteral(" id=\"apprenticeships-container\"");

WriteLiteral(" data-api-url=\"");

            
            #line 22 "..\..\Views\Apprenticeship\Search.cshtml"
                                                                  Write($"{Model.ApprenticeshipInfoApiBaseUrl}/v3/apprenticeship-programmes/autocomplete");

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"search\"");

WriteLiteral(" id=\"keywords\"");

WriteLiteral(" name=\"Keywords\"");

WriteLiteral(" class=\"text-box form-control\"");

WriteLiteral(" maxlength=\"200\"");

WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n");

WriteLiteral("                <input");

WriteLiteral(" class=\"button\"");

WriteLiteral(" id=\"submit-keywords\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Search apprenticeship training\"");

WriteLiteral(" />\r\n");

            
            #line 27 "..\..\Views\Apprenticeship\Search.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span");

WriteLiteral(" id=\"search-training-provider\"");

WriteLiteral(">You can also ");

            
            #line 29 "..\..\Views\Apprenticeship\Search.cshtml"
                                                        Write(Html.ActionLink("search for a training provider", "Search", "Provider"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n</main>\r\n");

        }
    }
}
#pragma warning restore 1591
