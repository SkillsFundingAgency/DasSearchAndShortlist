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
    
    #line 1 "..\..\Views\Standard\Detail.cshtml"
    using Sfa.Eds.Das.Web.Extensions;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Standard/Detail.cshtml")]
    public partial class Detail : System.Web.Mvc.WebViewPage<Sfa.Eds.Das.Web.ViewModels.StandardViewModel>
    {

#line 88 "..\..\Views\Standard\Detail.cshtml"
public System.Web.WebPages.HelperResult GetStandardDetailItem(string title, string item, string unit = "")
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 89 "..\..\Views\Standard\Detail.cshtml"
 
    if (!string.IsNullOrEmpty(item))
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <dt");

WriteLiteralTo(__razor_helper_writer, " class=\"minLength\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 92 "..\..\Views\Standard\Detail.cshtml"
    WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "            <dd");

WriteLiteralTo(__razor_helper_writer, " class=\"minLength\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 93 "..\..\Views\Standard\Detail.cshtml"
    WriteTo(__razor_helper_writer, item);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 93 "..\..\Views\Standard\Detail.cshtml"
          WriteTo(__razor_helper_writer, unit);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 94 "..\..\Views\Standard\Detail.cshtml"
    }


#line default
#line hidden
});

#line 95 "..\..\Views\Standard\Detail.cshtml"
}
#line default
#line hidden

#line 98 "..\..\Views\Standard\Detail.cshtml"
public System.Web.WebPages.HelperResult GetStandardProperty(string title, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 99 "..\..\Views\Standard\Detail.cshtml"
 
    if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
    {



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <div");

WriteLiteralTo(__razor_helper_writer, " class=\"row\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"left\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 105 "..\..\Views\Standard\Detail.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n            </div>\r\n            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"right\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 108 "..\..\Views\Standard\Detail.cshtml"
WriteTo(__razor_helper_writer, Html.Raw(item));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n            </div>\r\n        </div>\r\n");


#line 111 "..\..\Views\Standard\Detail.cshtml"
    }


#line default
#line hidden
});

#line 112 "..\..\Views\Standard\Detail.cshtml"
}
#line default
#line hidden

#line 114 "..\..\Views\Standard\Detail.cshtml"
public System.Web.WebPages.HelperResult GetDocumentItem(string pdfUrl, string title)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 115 "..\..\Views\Standard\Detail.cshtml"
 
    if (!string.IsNullOrEmpty(title))
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <li>\r\n            <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 4718), Tuple.Create("\"", 4732)

#line 119 "..\..\Views\Standard\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 4725), Tuple.Create<System.Object, System.Int32>(pdfUrl

#line default
#line hidden
, 4725), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 120 "..\..\Views\Standard\Detail.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n            </a>\r\n            <p>\r\n                PDF, 268KB, 2 pages\r\n       " +
"     </p>\r\n        </li>\r\n");


#line 126 "..\..\Views\Standard\Detail.cshtml"
    }


#line default
#line hidden
});

#line 127 "..\..\Views\Standard\Detail.cshtml"
}
#line default
#line hidden

        public Detail()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Standard\Detail.cshtml"
  
    ViewBag.Title = "Standard - " + @Model.Title;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" role=\"main\"");

WriteLiteral(">\r\n\r\n    <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 11 "..\..\Views\Standard\Detail.cshtml"
   Write(Html.RenderAIfExists(@Model.SearchResultLink?.Title, @Model.SearchResultLink?.Url, "link-back"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"hgroup\"");

WriteLiteral(">\r\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 18 "..\..\Views\Standard\Detail.cshtml"
               Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </h1>\r\n                <div");

WriteLiteral(" class=\"standard-result-summary\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 21 "..\..\Views\Standard\Detail.cshtml"
               Write(Html.Raw(@Model.IntroductoryTextHtml));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <section>\r\n");

            
            #line 26 "..\..\Views\Standard\Detail.cshtml"
                
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Standard\Detail.cshtml"
                 if (!string.IsNullOrEmpty($"{Model.AssessmentPlanPdfUrlTitle}{Model.StandardPdfUrlTitle}"))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"panel-indent panel-indent-info\"");

WriteLiteral(">\r\n                        <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">\r\n                            Documents\r\n                        </h2>\r\n        " +
"                <ul>\r\n");

WriteLiteral("                            ");

            
            #line 33 "..\..\Views\Standard\Detail.cshtml"
                       Write(GetDocumentItem(@Model.StandardPdfUrl, @Model.StandardPdfUrlTitle));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 34 "..\..\Views\Standard\Detail.cshtml"
                       Write(GetDocumentItem(@Model.AssessmentPlanPdfUrl, @Model.AssessmentPlanPdfUrlTitle));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n");

            
            #line 37 "..\..\Views\Standard\Detail.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"summary\"");

WriteLiteral(">\r\n                    <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">\r\n                        Summary of apprenticeship standard\r\n                  " +
"  </h2>\r\n");

WriteLiteral("                    ");

            
            #line 42 "..\..\Views\Standard\Detail.cshtml"
               Write(GetStandardProperty("Overview of role", Model.OverviewOfRoleHtml));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 43 "..\..\Views\Standard\Detail.cshtml"
               Write(GetStandardProperty("Level", @Model.NotionalEndLevel.ToString()));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 44 "..\..\Views\Standard\Detail.cshtml"
               Write(GetStandardProperty("Typical length", @Model.TypicalLengthMessage));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 45 "..\..\Views\Standard\Detail.cshtml"
               Write(GetStandardProperty("Entry requirements", Model.EntryRequirementsHtml));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 46 "..\..\Views\Standard\Detail.cshtml"
               Write(GetStandardProperty("What apprentices will learn", Model.WhatApprenticesWillLearnHtml));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 47 "..\..\Views\Standard\Detail.cshtml"
               Write(GetStandardProperty("Qualifications", Model.QualificationsHtml));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 48 "..\..\Views\Standard\Detail.cshtml"
               Write(GetStandardProperty("Professional registration", Model.ProfessionalRegistrationHtml, true));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </section>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"column-third\"");

WriteLiteral(">\r\n");

            
            #line 53 "..\..\Views\Standard\Detail.cshtml"
            
            
            #line default
            #line hidden
            
            #line 53 "..\..\Views\Standard\Detail.cshtml"
             using (Html.BeginForm("SearchResults", "Provider", FormMethod.Get, new { @class = "search-box" }))
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"related-container\"");

WriteLiteral(">\r\n                    <aside");

WriteLiteral(" class=\"related\"");

WriteLiteral(">\r\n\r\n                        <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">Find training providers</h2>\r\n                        <form");

WriteLiteral(" action=\"/g-cloud/search\"");

WriteLiteral(" method=\"get\"");

WriteLiteral(" class=\"search-box\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                                <label");

WriteLiteral(" class=\"form-label\"");

WriteLiteral(" for=\"q\"");

WriteLiteral(">\r\n                                    Postcode (mandatory)\r\n                    " +
"                <span");

WriteLiteral(" class=\"form-hint\"");

WriteLiteral(">\r\n                                        See all training providers in a given " +
"location.\r\n                                    </span>\r\n                        " +
"            <p>\r\n");

            
            #line 67 "..\..\Views\Standard\Detail.cshtml"
                                        
            
            #line default
            #line hidden
            
            #line 67 "..\..\Views\Standard\Detail.cshtml"
                                          
                                            Html.RenderPartial("_BlankFieldErrorMessage");
                                        
            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </p>\r\n                                </lab" +
"el>\r\n                                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"standardid\"");

WriteLiteral(" name=\"standardid\"");

WriteLiteral(" class=\"text-box form-control\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3486), Tuple.Create("\"", 3511)
            
            #line 72 "..\..\Views\Standard\Detail.cshtml"
                                            , Tuple.Create(Tuple.Create("", 3494), Tuple.Create<System.Object, System.Int32>(Model.StandardId
            
            #line default
            #line hidden
, 3494), false)
);

WriteLiteral(">\r\n                                <input");

WriteLiteral(" type=\"search\"");

WriteLiteral(" id=\"postcode\"");

WriteLiteral(" name=\"PostCode\"");

WriteLiteral(" class=\"text-box form-control\"");

WriteLiteral(" maxlength=\"200\"");

WriteLiteral(" style=\"width: 100%;\"");

WriteLiteral(" placeholder=\"\"");

WriteLiteral(">\r\n                            </div>\r\n                            <input");

WriteLiteral(" class=\"button margin-top-x2\"");

WriteLiteral(" id=\"submit-keywords\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Search\"");

WriteLiteral(" />\r\n                        </form>\r\n\r\n                    </aside>\r\n           " +
"     </div>\r\n");

            
            #line 80 "..\..\Views\Standard\Detail.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n</main>\r\n\r\n\r\n");

WriteLiteral("\r\n\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
