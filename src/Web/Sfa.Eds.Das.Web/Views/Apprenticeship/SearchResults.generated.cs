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

namespace Sfa.Eds.Das.Web.Views.Apprenticeship
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
    
    #line 1 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    using Sfa.Eds.Das.Web.ViewModels;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Apprenticeship/SearchResults.cshtml")]
    public partial class SearchResults : System.Web.Mvc.WebViewPage<ApprenticeshipSearchResultViewModel>
    {

#line 59 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetStandardTitle(ApprenticeshipSearchResultItemViewModel item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 60 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <h2");

WriteLiteralTo(__razor_helper_writer, " class=\"result-title\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 62 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink(item.Title, "Standard", "Apprenticeship", new { @id = item.StandardId }, null));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " \r\n        <span>new</span>\r\n    </h2>    \r\n");


#line 65 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 65 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

#line 67 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetFrameworkTitle(ApprenticeshipSearchResultItemViewModel item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 68 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <h2");

WriteLiteralTo(__razor_helper_writer, " class=\"result-title\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 70 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink(item.Title, "Framework", "Apprenticeship", new { @id = item.FrameworkId }, null));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n    </h2>\r\n");


#line 72 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 72 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

#line 74 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetApprenticeshipDetailItem(string title, string id, string item, string unit = "")
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 75 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    if (!string.IsNullOrEmpty(item))
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>");


#line 78 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 2466), Tuple.Create("\"", 2477)

#line 79 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 2474), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 2474), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 79 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, item);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 79 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, unit);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 80 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    }


#line default
#line hidden
});

#line 81 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

        public SearchResults()
        {
        }
        public override void Execute()
        {
WriteLiteral("﻿\r\n");

            
            #line 4 "..\..\Views\Apprenticeship\SearchResults.cshtml"
  
    ViewBag.Title = "Search Results";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" role=\"main\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 9 "..\..\Views\Apprenticeship\SearchResults.cshtml"
Write(Html.ActionLink("Back", "Search", null, new { @class = "link-back" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" id=\"apprenticeship-results\"");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n\r\n            <div");

WriteLiteral(" class=\"hgroup\"");

WriteLiteral(">\r\n\r\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n                    Search results\r\n                </h1>\r\n\r\n            </div" +
">\r\n            <p>\r\n");

            
            #line 22 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                  
                    Html.RenderPartial("_SearchResultMessage");
                
            
            #line default
            #line hidden
WriteLiteral("\r\n            </p>\r\n\r\n");

            
            #line 27 "..\..\Views\Apprenticeship\SearchResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\Apprenticeship\SearchResults.cshtml"
             foreach (var item in Model.Results)
            {

            
            #line default
            #line hidden
WriteLiteral("                <article");

WriteAttribute("class", Tuple.Create(" class=\"", 732), Tuple.Create("\"", 780)
, Tuple.Create(Tuple.Create("", 740), Tuple.Create("result", 740), true)
            
            #line 29 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create(" ", 746), Tuple.Create<System.Object, System.Int32>(item.ApprenticeshipType
            
            #line default
            #line hidden
, 747), false)
, Tuple.Create(Tuple.Create("", 773), Tuple.Create("-result", 773), true)
);

WriteAttribute("id", Tuple.Create(" id=\"", 781), Tuple.Create("\"", 867)
            
            #line 29 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 786), Tuple.Create<System.Object, System.Int32>(item.ApprenticeshipType
            
            #line default
            #line hidden
, 786), false)
, Tuple.Create(Tuple.Create("", 812), Tuple.Create("-", 812), true)
            
            #line 29 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                           , Tuple.Create(Tuple.Create("", 813), Tuple.Create<System.Object, System.Int32>(item.StandardId!=0?item.StandardId:item.FrameworkId
            
            #line default
            #line hidden
, 813), false)
);

WriteLiteral(">\r\n                    <header>\r\n");

            
            #line 31 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                         if (item.StandardId != 0)
                        {
                            
            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                       Write(GetStandardTitle(item));

            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                   
                        }
                        else
                        {
                            
            
            #line default
            #line hidden
            
            #line 37 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                       Write(GetFrameworkTitle(item));

            
            #line default
            #line hidden
            
            #line 37 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                    
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </header>\r\n                    <dl");

WriteLiteral(" class=\"result-data-list\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 41 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                   Write(GetApprenticeshipDetailItem("Level", "level", item.Level));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 42 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                   Write(GetApprenticeshipDetailItem("Typical length:","length", item.TypicalLengthMessage));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </dl>\r\n                </article>\r\n");

            
            #line 45 "..\..\Views\Apprenticeship\SearchResults.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n</main>\r\n\r\n");

            
            #line 50 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 if (Model.TotalResults == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <script>\r\n        window.onload = function() {\r\n            SearchAndShortlis" +
"t.analytics.pushEvent(\"Apprenticeship Search\", \"No results\", \"Search\");\r\n       " +
" }\r\n    </script>\r\n");

            
            #line 57 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
