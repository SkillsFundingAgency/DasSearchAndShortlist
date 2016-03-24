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

namespace Sfa.Eds.Das.Web.Views.Provider
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
    
    #line 1 "..\..\Views\Provider\Detail.cshtml"
    using Sfa.Eds.Das.Web.Extensions;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Provider/Detail.cshtml")]
    public partial class Detail : System.Web.Mvc.WebViewPage<Sfa.Eds.Das.Web.ViewModels.ProviderViewModel>
    {

#line 65 "..\..\Views\Provider\Detail.cshtml"
public System.Web.WebPages.HelperResult ShowTrainingLocation(string title)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 66 "..\..\Views\Provider\Detail.cshtml"
 
if (@Model != null)
{
    if (@Model.DeliveryModes.Count == 1 && @Model.DeliveryModes.Contains("100PercentEmployer"))
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <dt>");


#line 71 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "                <dd>Training will take place at your location</dd>\r\n");


#line 73 "..\..\Views\Provider\Detail.cshtml"
    }
    else
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <dt>");


#line 76 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "                <dd>");


#line 77 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, Model.Location.LocationName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 77 "..\..\Views\Provider\Detail.cshtml"
                   WriteTo(__razor_helper_writer, Model.Address.Address1);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 77 "..\..\Views\Provider\Detail.cshtml"
                                           WriteTo(__razor_helper_writer, Model.Address.Address2);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 77 "..\..\Views\Provider\Detail.cshtml"
                                                                   WriteTo(__razor_helper_writer, Model.Address.Postcode);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 78 "..\..\Views\Provider\Detail.cshtml"
    }
}


#line default
#line hidden
});

#line 80 "..\..\Views\Provider\Detail.cshtml"
}
#line default
#line hidden

#line 82 "..\..\Views\Provider\Detail.cshtml"
public System.Web.WebPages.HelperResult GetStandardPropertyHtml(string title, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 83 "..\..\Views\Provider\Detail.cshtml"
 
if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>");


#line 86 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "            <dd>");


#line 87 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, Html.Raw(item));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 88 "..\..\Views\Provider\Detail.cshtml"
}


#line default
#line hidden
});

#line 89 "..\..\Views\Provider\Detail.cshtml"
}
#line default
#line hidden

#line 91 "..\..\Views\Provider\Detail.cshtml"
public System.Web.WebPages.HelperResult GetStandardPropertyAsLinkHtml(string title, string url, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 92 "..\..\Views\Provider\Detail.cshtml"
 
if (!string.IsNullOrEmpty(url) || !hideIfEmpty)
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>");


#line 95 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "            <dd><a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 3183), Tuple.Create("\"", 3194)

#line 96 "..\..\Views\Provider\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 3190), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 3190), false)
);

WriteLiteralTo(__razor_helper_writer, " target=\"_blank\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 96 "..\..\Views\Provider\Detail.cshtml"
                 WriteTo(__razor_helper_writer, url);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a></dd>\r\n");


#line 97 "..\..\Views\Provider\Detail.cshtml"
}


#line default
#line hidden
});

#line 98 "..\..\Views\Provider\Detail.cshtml"
}
#line default
#line hidden

#line 100 "..\..\Views\Provider\Detail.cshtml"
public System.Web.WebPages.HelperResult GetDeliveryModesHtml(string title, List<string> items, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 101 "..\..\Views\Provider\Detail.cshtml"
 
if (items != null)
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>");


#line 104 "..\..\Views\Provider\Detail.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "            <dd>\r\n                <ul>\r\n");


#line 107 "..\..\Views\Provider\Detail.cshtml"
                    

#line default
#line hidden

#line 107 "..\..\Views\Provider\Detail.cshtml"
                     foreach (var item in items)
                    {
                        switch (item)
                        {
                            case "100PercentEmployer":


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                                <li>");


#line 112 "..\..\Views\Provider\Detail.cshtml"
      WriteTo(__razor_helper_writer, Html.Raw("at your location"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</li>\r\n");


#line 113 "..\..\Views\Provider\Detail.cshtml"
                                break;
                            case "BlockRelease":


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                                <li>");


#line 115 "..\..\Views\Provider\Detail.cshtml"
      WriteTo(__razor_helper_writer, Html.Raw("block release"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</li>\r\n");


#line 116 "..\..\Views\Provider\Detail.cshtml"
                                break;
                            case "DayRelease":


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                                <li>");


#line 118 "..\..\Views\Provider\Detail.cshtml"
      WriteTo(__razor_helper_writer, Html.Raw("day release"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</li>\r\n");


#line 119 "..\..\Views\Provider\Detail.cshtml"
                                break;
                            default:
                                break;
                        }
                    }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                </ul>\r\n            </dd>\r\n");


#line 126 "..\..\Views\Provider\Detail.cshtml"
}


#line default
#line hidden
});

#line 127 "..\..\Views\Provider\Detail.cshtml"
}
#line default
#line hidden

        public Detail()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Provider\Detail.cshtml"
  
    ViewBag.Title = "Provider - " + @Model.Name;

            
            #line default
            #line hidden
WriteLiteral("\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(">\r\n\r\n    <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 10 "..\..\Views\Provider\Detail.cshtml"
   Write(Html.RenderAIfExists(@Model.SearchResultLink?.Title, @Model.SearchResultLink?.Url, "link-back"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"hgroup\"");

WriteLiteral(">\r\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 18 "..\..\Views\Provider\Detail.cshtml"
               Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </h1>\r\n                <p>");

            
            #line 20 "..\..\Views\Provider\Detail.cshtml"
              Write(Model.ProviderMarketingInfo);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"column-third\"");

WriteLiteral(">\r\n");

            
            #line 26 "..\..\Views\Provider\Detail.cshtml"
            
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Provider\Detail.cshtml"
             using (Html.BeginForm("SearchResults", "Provider", FormMethod.Get, new { @class = "search-box" }))
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"related-container\"");

WriteLiteral(">\r\n                    <aside");

WriteLiteral(" class=\"related\"");

WriteLiteral(">\r\n                        <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">Training provider quality assessment</h2>\r\n                        <p>\r\n        " +
"                    <b>Learner satisfaction:</b>\r\n                            <b" +
"r />\r\n                            <span");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">");

            
            #line 34 "..\..\Views\Provider\Detail.cshtml"
                                                   Write(Model.LearnerSatisfaction);

            
            #line default
            #line hidden
WriteLiteral("%</span>\r\n                        </p>\r\n                        <p>\r\n            " +
"                <b>Employer satisfaction:</b>\r\n                            <br/>" +
"\r\n                            <span");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">");

            
            #line 39 "..\..\Views\Provider\Detail.cshtml"
                                                   Write(Model.EmployerSatisfaction);

            
            #line default
            #line hidden
WriteLiteral("%</span>\r\n                        </p>\r\n                    </aside>\r\n           " +
"     </div>\r\n");

            
            #line 43 "..\..\Views\Provider\Detail.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <section>\r\n        <header>\r\n            <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 50 "..\..\Views\Provider\Detail.cshtml"
           Write(Model.ApprenticeshipNameWithLevel);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </h2>\r\n        </header>\r\n        <dl");

WriteLiteral(" class=\"data-list\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 54 "..\..\Views\Provider\Detail.cshtml"
       Write(GetStandardPropertyAsLinkHtml("Website course page", @Model.Apprenticeship.ApprenticeshipInfoUrl));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 55 "..\..\Views\Provider\Detail.cshtml"
       Write(GetStandardPropertyAsLinkHtml("Website contact page", @Model.ContactInformation.ContactUsUrl));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 56 "..\..\Views\Provider\Detail.cshtml"
       Write(GetStandardPropertyHtml("Phone", Model.ContactInformation.Phone));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 57 "..\..\Views\Provider\Detail.cshtml"
       Write(GetStandardPropertyHtml("Email", Model.ContactInformation.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 58 "..\..\Views\Provider\Detail.cshtml"
       Write(GetDeliveryModesHtml("Training structure", Model.DeliveryModes));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 59 "..\..\Views\Provider\Detail.cshtml"
       Write(ShowTrainingLocation("Training location"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dl>\r\n    </section>\r\n</main>\r\n\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
