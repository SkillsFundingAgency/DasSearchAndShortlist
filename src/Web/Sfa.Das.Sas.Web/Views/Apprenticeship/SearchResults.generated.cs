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
    
    #line 1 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    using Sfa.Das.Sas.Web.ViewModels;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Apprenticeship/SearchResults.cshtml")]
    public partial class SearchResults : System.Web.Mvc.WebViewPage<ApprenticeshipSearchResultViewModel>
    {

#line 96 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetPaginationBackLink()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 97 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    if (Model.ActualPage > 1)
    {
        var previousPage = @Model.ActualPage - 1;
        var title = $"Previous page {@previousPage} of {@Model.LastPage}";
        var url = @Url.Action("SearchResults", "Apprenticeship", GetNavigationRouteValues(previousPage, Model.AggregationLevel, Model.SortOrder), null);
            

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 4013), Tuple.Create("\"", 4024)

#line 103 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4020), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 4020), false)
);

WriteLiteralTo(__razor_helper_writer, " style=\"visibility: visible\"");

WriteLiteralTo(__razor_helper_writer, " class=\"page-navigation__btn prev\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                <i");

WriteLiteralTo(__razor_helper_writer, " class=\"arrow-button fa fa-angle-left\"");

WriteLiteralTo(__razor_helper_writer, "></i>\r\n                <span");

WriteLiteralTo(__razor_helper_writer, " class=\"description\"");

WriteLiteralTo(__razor_helper_writer, ">Previous <span");

WriteLiteralTo(__razor_helper_writer, " class=\"hide-mob\"");

WriteLiteralTo(__razor_helper_writer, ">page</span></span>\r\n                <span");

WriteLiteralTo(__razor_helper_writer, " class=\"counter\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 106 "..\..\Views\Apprenticeship\SearchResults.cshtml"
        WriteTo(__razor_helper_writer, previousPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " of ");


#line 106 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                         WriteTo(__razor_helper_writer, Model.LastPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\r\n            </a>\r\n");


#line 108 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    }


#line default
#line hidden
});

#line 109 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

#line 112 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetPaginationNextLink()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 113 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    if (Model.ActualPage < Model.LastPage)
    {
        var nextPage = @Model.ActualPage + 1;
        var title = $"Next page {@nextPage} of {@Model.LastPage}";

        //var url = $"Apprenticeship/SearchResults/keywords={Model.SearchTerm}&page={nextPage}";
        var url = @Url.Action("SearchResults", "Apprenticeship", GetNavigationRouteValues(nextPage, Model.AggregationLevel, Model.SortOrder), null);
            

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 4824), Tuple.Create("\"", 4835)

#line 121 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4831), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 4831), false)
);

WriteLiteralTo(__razor_helper_writer, " style=\"visibility: visible\"");

WriteLiteralTo(__razor_helper_writer, " class=\"page-navigation__btn next\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                <i");

WriteLiteralTo(__razor_helper_writer, " class=\"arrow-button fa fa-angle-right\"");

WriteLiteralTo(__razor_helper_writer, "></i>\r\n                <span");

WriteLiteralTo(__razor_helper_writer, " class=\"description\"");

WriteLiteralTo(__razor_helper_writer, ">Next <span");

WriteLiteralTo(__razor_helper_writer, " class=\"hide-mob\"");

WriteLiteralTo(__razor_helper_writer, ">page</span></span>\r\n                <span");

WriteLiteralTo(__razor_helper_writer, " class=\"counter\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 124 "..\..\Views\Apprenticeship\SearchResults.cshtml"
        WriteTo(__razor_helper_writer, nextPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " of ");


#line 124 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                     WriteTo(__razor_helper_writer, Model.LastPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\r\n            </a>\r\n");


#line 126 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    }


#line default
#line hidden
});

#line 127 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

        #line 131 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    RouteValueDictionary GetNavigationRouteValues(int page, IEnumerable<LevelAggregationViewModel> selectedLevels, string order)
    {

        var rv = new RouteValueDictionary { { "keywords", Model.SearchTerm }, { "page", page }, { "order", order }, { "take", Model.ResultsToTake } };
        int i = 0;
        foreach (var level in selectedLevels.Where(m => m.Checked))
        {
            rv.Add("SelectedLevels[" + i + "]", level.Value);
            i++;
        }
        return rv;
    }

        #line default
        #line hidden

#line 147 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetStandardTitle(ApprenticeshipSearchResultItemViewModel item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 148 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <h2");

WriteLiteralTo(__razor_helper_writer, " class=\"result-title\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 150 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink(item.Title, "Standard", "Apprenticeship", new { @id = item.StandardId }, null));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " \r\n        <span>new</span>\r\n    </h2>\r\n");


#line 153 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 153 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

#line 155 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetFrameworkTitle(ApprenticeshipSearchResultItemViewModel item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 156 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <h2");

WriteLiteralTo(__razor_helper_writer, " class=\"result-title\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 158 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink(item.Title, "Framework", "Apprenticeship", new { @id = item.FrameworkId }, null));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n    </h2>\r\n");


#line 160 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 160 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

#line 162 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetApprenticeshipDetailItem(string title, string id, string item, string unit = "")
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 163 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    if (!string.IsNullOrEmpty(item))
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>");


#line 166 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 6355), Tuple.Create("\"", 6366)

#line 167 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6363), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 6363), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 167 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, item);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 167 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, unit);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 168 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    }


#line default
#line hidden
});

#line 169 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

#line 171 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult FilterForm(string className)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 172 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    if (Model.TotalResults > 0)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <div");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 6491), Tuple.Create("\"", 6523)
, Tuple.Create(Tuple.Create("", 6499), Tuple.Create("filters-block", 6499), true)

#line 175 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create(" ", 6512), Tuple.Create<System.Object, System.Int32>(className

#line default
#line hidden
, 6513), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n            <form");

WriteLiteralTo(__razor_helper_writer, " method=\"get\"");

WriteLiteralTo(__razor_helper_writer, " autocomplete=\"off\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"Keywords\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 6631), Tuple.Create("\"", 6656)

#line 177 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6639), Tuple.Create<System.Object, System.Int32>(Model.SearchTerm

#line default
#line hidden
, 6639), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n                <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"Page\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 6710), Tuple.Create("\"", 6735)

#line 178 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6718), Tuple.Create<System.Object, System.Int32>(Model.ActualPage

#line default
#line hidden
, 6718), false)
);

WriteLiteralTo(__razor_helper_writer, "/>\r\n                <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"order\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 6789), Tuple.Create("\"", 6813)

#line 179 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6797), Tuple.Create<System.Object, System.Int32>(Model.SortOrder

#line default
#line hidden
, 6797), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n                <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"take\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 6867), Tuple.Create("\"", 6895)

#line 180 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6875), Tuple.Create<System.Object, System.Int32>(Model.ResultsToTake

#line default
#line hidden
, 6875), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n\r\n                <fieldset");

WriteLiteralTo(__razor_helper_writer, " class=\"filters filters-accordion\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                    <h3");

WriteLiteralTo(__razor_helper_writer, " class=\"toggler heading-small\"");

WriteLiteralTo(__razor_helper_writer, ">Apprenticeship Level</h3>\r\n                    <div");

WriteLiteralTo(__razor_helper_writer, " class=\"toggled-content\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                        <ul");

WriteLiteralTo(__razor_helper_writer, " name=\"alist22\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 186 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                            

#line default
#line hidden

#line 186 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                             foreach (var item in Model.AggregationLevel.OrderBy(m => m.Value))
                            {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                                <li>\r\n                                    <input");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 7350), Tuple.Create("\"", 7369)

#line 189 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7358), Tuple.Create<System.Object, System.Int32>(item.Value

#line default
#line hidden
, 7358), false)
);

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 7370), Tuple.Create("\"", 7401)
, Tuple.Create(Tuple.Create("", 7375), Tuple.Create("SelectedLevels_", 7375), true)

#line 189 "..\..\Views\Apprenticeship\SearchResults.cshtml"
  , Tuple.Create(Tuple.Create("", 7390), Tuple.Create<System.Object, System.Int32>(item.Value

#line default
#line hidden
, 7390), false)
);

WriteLiteralTo(__razor_helper_writer, " name=\"SelectedLevels\"");

WriteLiteralTo(__razor_helper_writer, " type=\"checkbox\"");

WriteLiteralTo(__razor_helper_writer, " ");


#line 189 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                                                                       WriteTo(__razor_helper_writer, Html.Raw(item.Checked ? "checked" : ""));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 189 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                                                                                                                WriteTo(__razor_helper_writer, Html.Raw(item.Count == 0 ? "disabled" : ""));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " />\r\n                                    <label");

WriteAttributeTo(__razor_helper_writer, "for", Tuple.Create(" for=\"", 7573), Tuple.Create("\"", 7605)
, Tuple.Create(Tuple.Create("", 7579), Tuple.Create("SelectedLevels_", 7579), true)

#line 190 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7594), Tuple.Create<System.Object, System.Int32>(item.Value

#line default
#line hidden
, 7594), false)
);

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 7606), Tuple.Create("\"", 7658)

#line 190 "..\..\Views\Apprenticeship\SearchResults.cshtml"
   , Tuple.Create(Tuple.Create("", 7614), Tuple.Create<System.Object, System.Int32>(Html.Raw(item.Count == 0 ? "disabled" : "")

#line default
#line hidden
, 7614), false)
);

WriteLiteralTo(__razor_helper_writer, ">Level ");


#line 190 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                                                                         WriteTo(__razor_helper_writer, item.Value);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " (");


#line 190 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                                                                                      WriteTo(__razor_helper_writer, item.Count);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ")</label>\r\n                                </li>\r\n");


#line 192 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                            }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                        </ul>\r\n                    </div>\r\n                </fiel" +
"dset>\r\n                <input");

WriteLiteralTo(__razor_helper_writer, " type=\"submit\"");

WriteLiteralTo(__razor_helper_writer, " class=\"button\"");

WriteLiteralTo(__razor_helper_writer, " value=\"Update results\"");

WriteLiteralTo(__razor_helper_writer, " />\r\n            </form>\r\n        </div>\r\n");


#line 199 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    }


#line default
#line hidden
});

#line 200 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

        public SearchResults()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Apprenticeship\SearchResults.cshtml"
  
    ViewBag.Title = "Search Results";

            
            #line default
            #line hidden
WriteLiteral("\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" role=\"main\"");

WriteLiteral(">\r\n    <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 8 "..\..\Views\Apprenticeship\SearchResults.cshtml"
   Write(Html.ActionLink("Back", "Search", null, new { @class = "link-back" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n    <div");

WriteLiteral(" id=\"apprenticeship-results\"");

WriteLiteral(" class=\"grid-row column-two-third\"");

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n\r\n            <div");

WriteLiteral(" class=\"hgroup\"");

WriteLiteral(">\r\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n                    Search results\r\n                </h1>\r\n                <p>" +
"\r\n");

            
            #line 19 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                      
                        Html.RenderPartial("_SearchResultMessage");
                    
            
            #line default
            #line hidden
WriteLiteral("\r\n                </p>\r\n            </div>\r\n");

            
            #line 24 "..\..\Views\Apprenticeship\SearchResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Apprenticeship\SearchResults.cshtml"
             if (!Model.HasError && Model.TotalResults > 0)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div>\r\n                    <form");

WriteLiteral(" method=\"GET\"");

WriteLiteral(" id=\"search-results-order\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"Keywords\"");

WriteAttribute("value", Tuple.Create(" value=\"", 943), Tuple.Create("\"", 968)
            
            #line 28 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 951), Tuple.Create<System.Object, System.Int32>(Model.SearchTerm
            
            #line default
            #line hidden
, 951), false)
);

WriteLiteral(" />\r\n                        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"page\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1030), Tuple.Create("\"", 1055)
            
            #line 29 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1038), Tuple.Create<System.Object, System.Int32>(Model.ActualPage
            
            #line default
            #line hidden
, 1038), false)
);

WriteLiteral(" />\r\n                        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"take\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1117), Tuple.Create("\"", 1145)
            
            #line 30 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1125), Tuple.Create<System.Object, System.Int32>(Model.ResultsToTake
            
            #line default
            #line hidden
, 1125), false)
);

WriteLiteral(" />\r\n");

            
            #line 31 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                         foreach (var level in Model.AggregationLevel.Where(level => level.Checked))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"SelectedLevels\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1350), Tuple.Create("\"", 1370)
            
            #line 33 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1358), Tuple.Create<System.Object, System.Int32>(level.Value
            
            #line default
            #line hidden
, 1358), false)
);

WriteLiteral(" />\r\n");

            
            #line 34 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"form-block\"");

WriteLiteral(">\r\n                            Sort by\r\n                            <select");

WriteLiteral(" name=\"order\"");

WriteLiteral(" class=\"form-control form-control-1-3\"");

WriteLiteral(">\r\n                                <option");

WriteAttribute("selected", Tuple.Create(" selected=\"", 1618), Tuple.Create("\"", 1652)
            
            #line 38 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1629), Tuple.Create<System.Object, System.Int32>(Model.SortOrder=="1"
            
            #line default
            #line hidden
, 1629), false)
);

WriteLiteral(" value=\"1\"");

WriteLiteral(">Best match</option>\r\n                                <option");

WriteAttribute("selected", Tuple.Create(" selected=\"", 1724), Tuple.Create("\"", 1758)
            
            #line 39 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1735), Tuple.Create<System.Object, System.Int32>(Model.SortOrder=="2"
            
            #line default
            #line hidden
, 1735), false)
);

WriteLiteral(" value=\"2\"");

WriteLiteral(">Level (high to low)</option>\r\n                                <option");

WriteAttribute("selected", Tuple.Create(" selected=\"", 1839), Tuple.Create("\"", 1873)
            
            #line 40 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1850), Tuple.Create<System.Object, System.Int32>(Model.SortOrder=="3"
            
            #line default
            #line hidden
, 1850), false)
);

WriteLiteral(" value=\"3\"");

WriteLiteral(">Level (low to high)</option>\r\n                            </select>\r\n           " +
"                 <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Sort\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(">Sort</button>\r\n                        </div>\r\n                    </form>\r\n    " +
"            </div>\r\n");

            
            #line 46 "..\..\Views\Apprenticeship\SearchResults.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"column-one-third\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 51 "..\..\Views\Apprenticeship\SearchResults.cshtml"
       Write(FilterForm("filter-box"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            \r\n");

            
            #line 56 "..\..\Views\Apprenticeship\SearchResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 56 "..\..\Views\Apprenticeship\SearchResults.cshtml"
             foreach (var item in Model.Results)
                {

            
            #line default
            #line hidden
WriteLiteral("                <article");

WriteAttribute("class", Tuple.Create(" class=\"", 2412), Tuple.Create("\"", 2460)
, Tuple.Create(Tuple.Create("", 2420), Tuple.Create("result", 2420), true)
            
            #line 58 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create(" ", 2426), Tuple.Create<System.Object, System.Int32>(item.ApprenticeshipType
            
            #line default
            #line hidden
, 2427), false)
, Tuple.Create(Tuple.Create("", 2453), Tuple.Create("-result", 2453), true)
);

WriteAttribute("id", Tuple.Create(" id=\"", 2461), Tuple.Create("\"", 2553)
            
            #line 58 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 2466), Tuple.Create<System.Object, System.Int32>(item.ApprenticeshipType
            
            #line default
            #line hidden
, 2466), false)
, Tuple.Create(Tuple.Create("", 2492), Tuple.Create("-", 2492), true)
            
            #line 58 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                          , Tuple.Create(Tuple.Create("", 2493), Tuple.Create<System.Object, System.Int32>(item.StandardId != 0 ? item.StandardId : item.FrameworkId
            
            #line default
            #line hidden
, 2493), false)
);

WriteLiteral(">\r\n                    <header>\r\n");

            
            #line 60 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 60 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                         if (item.StandardId != 0)
                        {
                            
            
            #line default
            #line hidden
            
            #line 62 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                       Write(GetStandardTitle(item));

            
            #line default
            #line hidden
            
            #line 62 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                   
                        }
                        else
                        {
                            
            
            #line default
            #line hidden
            
            #line 66 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                       Write(GetFrameworkTitle(item));

            
            #line default
            #line hidden
            
            #line 66 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                    
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </header>\r\n                    <dl");

WriteLiteral(" class=\"result-data-list\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 70 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                   Write(GetApprenticeshipDetailItem("Level:", "level", item.Level));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 71 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                   Write(GetApprenticeshipDetailItem("Typical length:", "length", item.TypicalLengthMessage));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </dl>\r\n                </article>\r\n");

            
            #line 74 "..\..\Views\Apprenticeship\SearchResults.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"page-navigation\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 77 "..\..\Views\Apprenticeship\SearchResults.cshtml"
           Write(GetPaginationBackLink());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 78 "..\..\Views\Apprenticeship\SearchResults.cshtml"
           Write(GetPaginationNextLink());

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n    </div>\r\n</main>\r\n\r\n");

            
            #line 87 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 if (Model.TotalResults == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <script>\r\n        window.onload = function() {\r\n            SearchAndShortlis" +
"t.analytics.pushEvent(\"Apprenticeship Search\", \"No results\", \"Search\");\r\n       " +
" }\r\n    </script>\r\n");

            
            #line 94 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\r\n\r\n");

WriteLiteral("\r\n\r\n");

WriteLiteral("\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
