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
    
    #line 1 "..\..\Views\Provider\StandardResults.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Provider\StandardResults.cshtml"
    using Sfa.Das.Sas.Web.ViewModels;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Provider/StandardResults.cshtml")]
    public partial class StandardResults : System.Web.Mvc.WebViewPage<ProviderStandardSearchResultViewModel>
    {

#line 96 "..\..\Views\Provider\StandardResults.cshtml"
public System.Web.WebPages.HelperResult GetPaginationBackLink()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 97 "..\..\Views\Provider\StandardResults.cshtml"
 
if (Model.ActualPage > 1)
{
    var previousPage = @Model.ActualPage - 1;
    var url = @Url.Action("StandardResults", "Provider", GetNavigationRouteValues(previousPage, Model.DeliveryModes), null);

        

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 4208), Tuple.Create("\"", 4219)

#line 103 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 4215), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 4215), false)
);

WriteLiteralTo(__razor_helper_writer, " style=\"visibility: visible\"");

WriteLiteralTo(__razor_helper_writer, " class=\"page-navigation__btn prev\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <i");

WriteLiteralTo(__razor_helper_writer, " class=\"arrow-button fa fa-angle-left\"");

WriteLiteralTo(__razor_helper_writer, "></i>\r\n            <span");

WriteLiteralTo(__razor_helper_writer, " class=\"description\"");

WriteLiteralTo(__razor_helper_writer, ">Previous <span");

WriteLiteralTo(__razor_helper_writer, " class=\"hide-mob\"");

WriteLiteralTo(__razor_helper_writer, ">page</span></span>\r\n            <span");

WriteLiteralTo(__razor_helper_writer, " class=\"counter\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 106 "..\..\Views\Provider\StandardResults.cshtml"
    WriteTo(__razor_helper_writer, previousPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " of ");


#line 106 "..\..\Views\Provider\StandardResults.cshtml"
                     WriteTo(__razor_helper_writer, Model.LastPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\r\n        </a>\r\n");


#line 108 "..\..\Views\Provider\StandardResults.cshtml"
}


#line default
#line hidden
});

#line 109 "..\..\Views\Provider\StandardResults.cshtml"
}
#line default
#line hidden

#line 111 "..\..\Views\Provider\StandardResults.cshtml"
public System.Web.WebPages.HelperResult GetPaginationNextLink()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 112 "..\..\Views\Provider\StandardResults.cshtml"
 
if (Model.ActualPage < Model.LastPage)
{
    var nextPage = @Model.ActualPage + 1;

    var url = @Url.Action("StandardResults", "Provider", GetNavigationRouteValues(nextPage, Model.DeliveryModes), null);
        

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 4787), Tuple.Create("\"", 4798)

#line 118 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 4794), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 4794), false)
);

WriteLiteralTo(__razor_helper_writer, " style=\"visibility: visible\"");

WriteLiteralTo(__razor_helper_writer, " class=\"page-navigation__btn next\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <i");

WriteLiteralTo(__razor_helper_writer, " class=\"arrow-button fa fa-angle-right\"");

WriteLiteralTo(__razor_helper_writer, "></i>\r\n            <span");

WriteLiteralTo(__razor_helper_writer, " class=\"description\"");

WriteLiteralTo(__razor_helper_writer, ">Next <span");

WriteLiteralTo(__razor_helper_writer, " class=\"hide-mob\"");

WriteLiteralTo(__razor_helper_writer, ">page</span></span>\r\n            <span");

WriteLiteralTo(__razor_helper_writer, " class=\"counter\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 121 "..\..\Views\Provider\StandardResults.cshtml"
    WriteTo(__razor_helper_writer, nextPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " of ");


#line 121 "..\..\Views\Provider\StandardResults.cshtml"
                 WriteTo(__razor_helper_writer, Model.LastPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\r\n        </a>\r\n");


#line 123 "..\..\Views\Provider\StandardResults.cshtml"
}


#line default
#line hidden
});

#line 124 "..\..\Views\Provider\StandardResults.cshtml"
}
#line default
#line hidden

#line 126 "..\..\Views\Provider\StandardResults.cshtml"
public System.Web.WebPages.HelperResult FilterForm(string cssClass)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 127 "..\..\Views\Provider\StandardResults.cshtml"
 
if (!Model.DeliveryModes.IsNullOrEmpty())
{
    var hideMenu = Model.DeliveryModes.All(deliveryMode => deliveryMode.Count == 0);

    if (@Model.TotalResults != 0 || !hideMenu)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 5348), Tuple.Create("\"", 5365)

#line 134 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 5356), Tuple.Create<System.Object, System.Int32>(cssClass

#line default
#line hidden
, 5356), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n                <form");

WriteLiteralTo(__razor_helper_writer, " method=\"get\"");

WriteLiteralTo(__razor_helper_writer, " autocomplete=\"off\"");

WriteAttributeTo(__razor_helper_writer, "action", Tuple.Create(" action=\"", 5422), Tuple.Create("\"", 5450)

#line 135 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 5431), Tuple.Create<System.Object, System.Int32>(Model.AbsolutePath

#line default
#line hidden
, 5431), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n                    <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"PostCode\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 5510), Tuple.Create("\"", 5533)

#line 136 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 5518), Tuple.Create<System.Object, System.Int32>(Model.PostCode

#line default
#line hidden
, 5518), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n                    <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"apprenticeshipid\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 5603), Tuple.Create("\"", 5628)

#line 137 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 5611), Tuple.Create<System.Object, System.Int32>(Model.StandardId

#line default
#line hidden
, 5611), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n                    <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"showAll\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 5689), Tuple.Create("\"", 5722)

#line 138 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 5697), Tuple.Create<System.Object, System.Int32>(Model.ShowAll.ToString()

#line default
#line hidden
, 5697), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n                    <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"keywords\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 5784), Tuple.Create("\"", 5810)

#line 139 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 5792), Tuple.Create<System.Object, System.Int32>(Model.SearchTerms

#line default
#line hidden
, 5792), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n");


#line 140 "..\..\Views\Provider\StandardResults.cshtml"
                    

#line default
#line hidden

#line 140 "..\..\Views\Provider\StandardResults.cshtml"
                      
                        Html.RenderPartial("_FilterProviders", Model.DeliveryModes);
                    

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 143 "..\..\Views\Provider\StandardResults.cshtml"
                    

#line default
#line hidden

#line 143 "..\..\Views\Provider\StandardResults.cshtml"
                      
                        Html.RenderPartial("_FilterNationalProviders", Model.NationalProviders);
                    

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                    <input");

WriteLiteralTo(__razor_helper_writer, " type=\"submit\"");

WriteLiteralTo(__razor_helper_writer, " value=\"Update results\"");

WriteLiteralTo(__razor_helper_writer, " class=\"button margin-top-x2 postcode-search-button\"");

WriteLiteralTo(__razor_helper_writer, " />\r\n                </form>\r\n            </div>\r\n");


#line 149 "..\..\Views\Provider\StandardResults.cshtml"
                            }
                        }


#line default
#line hidden
});

#line 151 "..\..\Views\Provider\StandardResults.cshtml"
}
#line default
#line hidden

        #line 154 "..\..\Views\Provider\StandardResults.cshtml"
 
    RouteValueDictionary GetNavigationRouteValues(int page, IEnumerable<DeliveryModeViewModel> deliveryModes)
    {

        var rv = new RouteValueDictionary { { "apprenticeshipid", Model.StandardId }, { "postcode", Model.PostCode }, { "page", page }, { "showall", Model.ShowAll } };
        int i = 0;
        foreach (var deliveryMode in deliveryModes.Where(m => m.Checked))
        {
            rv.Add("DeliveryModes[" + i + "]", deliveryMode.Value);
            i++;
        }
        return rv;
    }

        #line default
        #line hidden
        
        public StandardResults()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Provider\StandardResults.cshtml"
  
    ViewBag.Title = "Provider Search Results";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" role=\"main\"");

WriteLiteral(">\r\n");

            
            #line 10 "..\..\Views\Provider\StandardResults.cshtml"
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Provider\StandardResults.cshtml"
     if (Model.Hits.Count() != 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 13 "..\..\Views\Provider\StandardResults.cshtml"
       Write(Html.ActionLink("Find providers for a different postcode", "SearchForStandardProviders", "Apprenticeship", new { @standardId = Model.StandardId, @keywords = Model.SearchTerms }, new { @class = "link-back new-postcode-search" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </p>\r\n");

            
            #line 15 "..\..\Views\Provider\StandardResults.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div>\r\n        <div>\r\n            <hgroup");

WriteLiteral(" class=\"hgroup\"");

WriteLiteral(">\r\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n                    Search results\r\n                </h1>\r\n");

            
            #line 22 "..\..\Views\Provider\StandardResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Provider\StandardResults.cshtml"
                  
                    Html.RenderPartial("_StandardSearchResultMessage");
                
            
            #line default
            #line hidden
WriteLiteral("\r\n            </hgroup>\r\n        </div>\r\n    </div>\r\n\r\n");

            
            #line 29 "..\..\Views\Provider\StandardResults.cshtml"
    
            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\Provider\StandardResults.cshtml"
     if (Model.ShowNationalProviders && Model.TotalResults == 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" id=\"standard-provider-search-message\"");

WriteLiteral(">\r\n            Sorry, there are currently no results for the filters you applied\'" +
".\r\n        </p>\r\n");

WriteLiteral("        <div>\r\n            <p>You can:</p>\r\n            <ul");

WriteLiteral(" class=\"list list-bullet\"");

WriteLiteral(">\r\n                <li");

WriteLiteral(" class=\"return-search-results\"");

WriteLiteral(">");

            
            #line 37 "..\..\Views\Provider\StandardResults.cshtml"
                                             Write(Html.ActionLink("return to your apprenticeship training search results", "StandardResults", "Provider", new { @apprenticeshipid = @Model.StandardId, @postcode = @Model.PostCode, @keywords = @Model.SearchTerms }, new { }));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                <li");

WriteLiteral(" class=\"start-again\"");

WriteLiteral(">");

            
            #line 38 "..\..\Views\Provider\StandardResults.cshtml"
                                   Write(Html.ActionLink("start your job role or keyword search again", "Search", "Apprenticeship"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n");

            
            #line 41 "..\..\Views\Provider\StandardResults.cshtml"
    }
    else if (Model.TotalResults == 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" id=\"standard-provider-search-message\"");

WriteLiteral(">\r\n            Sorry, there are currently no training providers for <b>");

            
            #line 45 "..\..\Views\Provider\StandardResults.cshtml"
                                                               Write(Model.StandardName);

            
            #line default
            #line hidden
WriteLiteral(", level ");

            
            #line 45 "..\..\Views\Provider\StandardResults.cshtml"
                                                                                          Write(Model.StandardLevel);

            
            #line default
            #line hidden
WriteLiteral("</b> for \'<b");

WriteLiteral(" id=\"postalcode\"");

WriteLiteral(">");

            
            #line 45 "..\..\Views\Provider\StandardResults.cshtml"
                                                                                                                                           Write(Model.PostCode);

            
            #line default
            #line hidden
WriteLiteral("</b>\' apprenticeship.\r\n        </p>\r\n");

WriteLiteral("        <div>\r\n            <p>You can:</p>\r\n            <ul");

WriteLiteral(" class=\"list list-bullet\"");

WriteLiteral(">\r\n");

            
            #line 50 "..\..\Views\Provider\StandardResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 50 "..\..\Views\Provider\StandardResults.cshtml"
                 if (Model.TotalResultsForCountry > 0)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteLiteral(" class=\"total-providers-country\"");

WriteLiteral(">");

            
            #line 52 "..\..\Views\Provider\StandardResults.cshtml"
                                                   Write(Html.ActionLink(string.Format("view all ({0}) training providers", @Model.TotalResultsForCountry), "StandardResults", "Provider", new { @apprenticeshipId = @Model.StandardId, @postcode = Model.PostCode, @showAll = true }, new { @class = "" }));

            
            #line default
            #line hidden
WriteLiteral(" for <b>");

            
            #line 52 "..\..\Views\Provider\StandardResults.cshtml"
                                                                                                                                                                                                                                                                                                              Write(Model.StandardName);

            
            #line default
            #line hidden
WriteLiteral(", level ");

            
            #line 52 "..\..\Views\Provider\StandardResults.cshtml"
                                                                                                                                                                                                                                                                                                                                         Write(Model.StandardLevel);

            
            #line default
            #line hidden
WriteLiteral("</b> in England</li>\r\n");

            
            #line 53 "..\..\Views\Provider\StandardResults.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" class=\"return-search-results\"");

WriteLiteral(">");

            
            #line 54 "..\..\Views\Provider\StandardResults.cshtml"
                                             Write(Html.ActionLink("return to your apprenticeship training search results", "SearchResults", "Apprenticeship", new { @keywords = @Model.SearchTerms }, new { }));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                <li");

WriteLiteral(" class=\"start-again\"");

WriteLiteral(">");

            
            #line 55 "..\..\Views\Provider\StandardResults.cshtml"
                                   Write(Html.ActionLink("start your job role or keyword search again", "Search", "Apprenticeship"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n");

            
            #line 58 "..\..\Views\Provider\StandardResults.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-third\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"editSearch\"");

WriteLiteral(">\r\n");

            
            #line 63 "..\..\Views\Provider\StandardResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 63 "..\..\Views\Provider\StandardResults.cshtml"
                 if (Model.Hits.Any() && !Model.HasError)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\"#EditSearch\"");

WriteLiteral(">Filter results</a>\r\n                    </h2>\r\n");

WriteLiteral("                    <div");

WriteLiteral(" id=\"EditSearch\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 69 "..\..\Views\Provider\StandardResults.cshtml"
                   Write(FilterForm("filter-box"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n");

            
            #line 71 "..\..\Views\Provider\StandardResults.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" id=\"provider-results\"");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n");

            
            #line 76 "..\..\Views\Provider\StandardResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 76 "..\..\Views\Provider\StandardResults.cshtml"
              
                Html.RenderPartial("_StandardProviderInformation");
            
            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"page-navigation\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 80 "..\..\Views\Provider\StandardResults.cshtml"
           Write(GetPaginationBackLink());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 81 "..\..\Views\Provider\StandardResults.cshtml"
           Write(GetPaginationNextLink());

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n");

            
            #line 87 "..\..\Views\Provider\StandardResults.cshtml"
 if (Model.TotalResults == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <script>\r\n        window.onload = function () {\r\n            SearchAndShortli" +
"st.analytics.pushEvent(\"Provider Search\", \"No results\", \"Search\");\r\n        }\r\n " +
"   </script>\r\n");

            
            #line 94 "..\..\Views\Provider\StandardResults.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
