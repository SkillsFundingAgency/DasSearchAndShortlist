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

namespace Sfa.Das.Sas.Web.Views.Provider
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
    
    #line 1 "..\..\Views\Provider\SearchResults.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Provider/SearchResults.cshtml")]
    public partial class SearchResults : System.Web.Mvc.WebViewPage<Sfa.Das.Sas.Web.ViewModels.ProviderNameSearchResultViewModel>
    {

#line 118 "..\..\Views\Provider\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetProviderDetailItem(string title, List<string> aliases, string ukprn)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 119 "..\..\Views\Provider\SearchResults.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 4240), Tuple.Create("\"", 4291)
, Tuple.Create(Tuple.Create("", 4247), Tuple.Create("../Provider/", 4247), true)

#line 120 "..\..\Views\Provider\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4259), Tuple.Create<System.Object, System.Int32>(ukprn

#line default
#line hidden
, 4259), false)
, Tuple.Create(Tuple.Create("", 4265), Tuple.Create("?keyword=", 4265), true)

#line 120 "..\..\Views\Provider\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4274), Tuple.Create<System.Object, System.Int32>(Model.SearchTerm

#line default
#line hidden
, 4274), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 120 "..\..\Views\Provider\SearchResults.cshtml"
                             WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a> \r\n");


#line 121 "..\..\Views\Provider\SearchResults.cshtml"

    if (aliases != null && aliases.Count > 0)
    {

        foreach (var alias in aliases)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <span");

WriteLiteralTo(__razor_helper_writer, " class=\"sublist\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                ...<a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 4472), Tuple.Create("\"", 4523)
, Tuple.Create(Tuple.Create("", 4479), Tuple.Create("../Provider/", 4479), true)

#line 128 "..\..\Views\Provider\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4491), Tuple.Create<System.Object, System.Int32>(ukprn

#line default
#line hidden
, 4491), false)
, Tuple.Create(Tuple.Create("", 4497), Tuple.Create("?keyword=", 4497), true)

#line 128 "..\..\Views\Provider\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4506), Tuple.Create<System.Object, System.Int32>(Model.SearchTerm

#line default
#line hidden
, 4506), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 128 "..\..\Views\Provider\SearchResults.cshtml"
                                            WriteTo(__razor_helper_writer, alias);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n            </span>\r\n");


#line 130 "..\..\Views\Provider\SearchResults.cshtml"
        }

    }
      


#line default
#line hidden
});

#line 134 "..\..\Views\Provider\SearchResults.cshtml"
}
#line default
#line hidden

        public SearchResults()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Provider\SearchResults.cshtml"
  
    ViewBag.Title = "Search Results";
    ViewBag.PageID = "search-provider-results";

            
            #line default
            #line hidden
WriteLiteral("\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" role=\"main\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"breadcrumbs\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" href=\"/Provider/Search\"");

WriteLiteral(" class=\"link-back\"");

WriteLiteral(">Back</a>\r\n    </div>\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 364), Tuple.Create("\"", 389)
            
            #line 12 "..\..\Views\Provider\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 372), Tuple.Create<System.Object, System.Int32>(Model.SearchTerm
            
            #line default
            #line hidden
, 372), false)
);

WriteLiteral(" id=\"ga-search-term\"");

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 439), Tuple.Create("\"", 488)
            
            #line 13 "..\..\Views\Provider\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 447), Tuple.Create<System.Object, System.Int32>(Model.Results.IsNullOrEmpty().ToString()
            
            #line default
            #line hidden
, 447), false)
);

WriteLiteral(" id=\"ga-no-result\"");

WriteLiteral(" />\r\n\r\n    <div");

WriteLiteral(" class=\"grid-row notification-wrapper\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n");

            
            #line 17 "..\..\Views\Provider\SearchResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Provider\SearchResults.cshtml"
              
                if (Model != null && Model.ShortSearchTerm)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" role=\"group\"");

WriteLiteral(" class=\"error-summary\"");

WriteLiteral(">\r\n                        <h1");

WriteLiteral(" id=\"error-summary\"");

WriteLiteral(" class=\"heading-medium error-summary-heading\"");

WriteLiteral(">\r\n                            Errors to fix\r\n                        </h1>\r\n    " +
"                    <p>Check the following details:</p>\r\n                       " +
" <ul");

WriteLiteral(" class=\"error-summary-list\"");

WriteLiteral(">\r\n                            <li><a");

WriteLiteral(" href=\"#searchTerm\"");

WriteLiteral(">Type at least 3 characters</a></li>\r\n                        </ul>\r\n            " +
"        </div>\r\n");

            
            #line 29 "..\..\Views\Provider\SearchResults.cshtml"
                }
            
            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n                Find a training provider by name\r\n            </h1>\r\n\r\n\r\n\r\n");

            
            #line 42 "..\..\Views\Provider\SearchResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 42 "..\..\Views\Provider\SearchResults.cshtml"
             if (Model.TotalResults == 0)
            {
                Html.RenderPartial("_SearchProviderName");
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n");

            
            #line 51 "..\..\Views\Provider\SearchResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Provider\SearchResults.cshtml"
             if (Model.TotalResults > 0)
            {
                Html.RenderPartial("_SearchProviderName");
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n\r\n\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n");

            
            #line 61 "..\..\Views\Provider\SearchResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 61 "..\..\Views\Provider\SearchResults.cshtml"
             if (!Model.HasError && !Model.ShortSearchTerm && Model.TotalResults > 0)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" id=\"provider-search-results\"");

WriteLiteral(">\r\n\r\n                    <p");

WriteLiteral(" class=\"form-label-bold\"");

WriteLiteral("> ");

            
            #line 65 "..\..\Views\Provider\SearchResults.cshtml"
                                           Write(Model.TotalResults);

            
            #line default
            #line hidden
WriteLiteral(" results found</p>\r\n                    <ul>\r\n");

            
            #line 67 "..\..\Views\Provider\SearchResults.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 67 "..\..\Views\Provider\SearchResults.cshtml"
                         foreach (var item in Model.Results)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li");

WriteLiteral(" class=\"results\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 70 "..\..\Views\Provider\SearchResults.cshtml"
                           Write(GetProviderDetailItem(item.ProviderName, item.Aliases, item.UkPrn.ToString()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </li>\r\n");

            
            #line 72 "..\..\Views\Provider\SearchResults.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </ul>\r\n                </div>\r\n");

            
            #line 75 "..\..\Views\Provider\SearchResults.cshtml"
            }
            else
            {
                Html.RenderPartial("_SearchResultMessage");
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <nav");

WriteLiteral(" role=\"navigation\"");

WriteLiteral(">\r\n                <ul");

WriteLiteral(" class=\"previous-next-navigation\"");

WriteLiteral(">\r\n");

            
            #line 87 "..\..\Views\Provider\SearchResults.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 87 "..\..\Views\Provider\SearchResults.cshtml"
                     if (Model.ActualPage > 1)
                    {
                        var pageBefore = Model.ActualPage - 1;


            
            #line default
            #line hidden
WriteLiteral("                        <li");

WriteLiteral(" class=\"previous\"");

WriteLiteral(" id=\"previous-nav\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3106), Tuple.Create("\"", 3184)
, Tuple.Create(Tuple.Create("", 3113), Tuple.Create("../provider/searchResults?SearchTerm=", 3113), true)
            
            #line 92 "..\..\Views\Provider\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3150), Tuple.Create<System.Object, System.Int32>(Model.SearchTerm
            
            #line default
            #line hidden
, 3150), false)
, Tuple.Create(Tuple.Create("", 3167), Tuple.Create("&Page=", 3167), true)
            
            #line 92 "..\..\Views\Provider\SearchResults.cshtml"
                 , Tuple.Create(Tuple.Create("", 3173), Tuple.Create<System.Object, System.Int32>(pageBefore
            
            #line default
            #line hidden
, 3173), false)
);

WriteLiteral(">\r\n                                Previous <span");

WriteLiteral(" class=\"visuallyhidden\"");

WriteLiteral(">page</span>\r\n                                <span");

WriteLiteral(" class=\"page-numbers\"");

WriteLiteral(">Previous page ");

            
            #line 94 "..\..\Views\Provider\SearchResults.cshtml"
                                                                    Write(pageBefore);

            
            #line default
            #line hidden
WriteLiteral(" of ");

            
            #line 94 "..\..\Views\Provider\SearchResults.cshtml"
                                                                                   Write(Model.LastPage);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            </a>\r\n                        </li>\r\n");

            
            #line 97 "..\..\Views\Provider\SearchResults.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 98 "..\..\Views\Provider\SearchResults.cshtml"
                     if (Model.ActualPage < Model.LastPage)
                    {
                        var pageAfter = Model.ActualPage + 1;


            
            #line default
            #line hidden
WriteLiteral("                        <li");

WriteLiteral(" class=\"next\"");

WriteLiteral(" id=\"next-nav\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3707), Tuple.Create("\"", 3784)
, Tuple.Create(Tuple.Create("", 3714), Tuple.Create("../provider/searchResults?SearchTerm=", 3714), true)
            
            #line 103 "..\..\Views\Provider\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3751), Tuple.Create<System.Object, System.Int32>(Model.SearchTerm
            
            #line default
            #line hidden
, 3751), false)
, Tuple.Create(Tuple.Create("", 3768), Tuple.Create("&Page=", 3768), true)
            
            #line 103 "..\..\Views\Provider\SearchResults.cshtml"
                 , Tuple.Create(Tuple.Create("", 3774), Tuple.Create<System.Object, System.Int32>(pageAfter
            
            #line default
            #line hidden
, 3774), false)
);

WriteLiteral(">\r\n                                Next <span");

WriteLiteral(" class=\"visuallyhidden\"");

WriteLiteral(">page</span>\r\n                                <span");

WriteLiteral(" class=\"page-numbers\"");

WriteLiteral(">Next page ");

            
            #line 105 "..\..\Views\Provider\SearchResults.cshtml"
                                                                Write(pageAfter);

            
            #line default
            #line hidden
WriteLiteral(" of ");

            
            #line 105 "..\..\Views\Provider\SearchResults.cshtml"
                                                                              Write(Model.LastPage);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            </a>\r\n                        </li>\r\n");

            
            #line 108 "..\..\Views\Provider\SearchResults.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </ul>\r\n            </nav>\r\n        </div>\r\n    </div>\r\n</main>\r\n\r" +
"\n\r\n\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
