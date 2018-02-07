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
    
    #line 1 "..\..\Views\Provider\ProviderDetail.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Provider\ProviderDetail.cshtml"
    using Sfa.Das.Sas.Web.ViewModels;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Provider/ProviderDetail.cshtml")]
    public partial class ProviderDetail : System.Web.Mvc.WebViewPage<ProviderDetailViewModel>
    {

#line 212 "..\..\Views\Provider\ProviderDetail.cshtml"
public System.Web.WebPages.HelperResult CreateProgressBar(string message, int progress)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 213 "..\..\Views\Provider\ProviderDetail.cshtml"
 
if (progress > 0)
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <div");

WriteLiteralTo(__razor_helper_writer, " class=\"progress-container\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"progressbar\"");

WriteAttributeTo(__razor_helper_writer, "style", Tuple.Create(" style=\"", 8938), Tuple.Create("\"", 8963)
, Tuple.Create(Tuple.Create("", 8946), Tuple.Create("width:", 8946), true)

#line 217 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create(" ", 8952), Tuple.Create<System.Object, System.Int32>(progress

#line default
#line hidden
, 8953), false)
, Tuple.Create(Tuple.Create("", 8962), Tuple.Create("%", 8962), true)
);

WriteLiteralTo(__razor_helper_writer, "></div>\r\n        </div>\r\n");


#line 219 "..\..\Views\Provider\ProviderDetail.cshtml"
}


#line default
#line hidden
});

#line 220 "..\..\Views\Provider\ProviderDetail.cshtml"
}
#line default
#line hidden

        public ProviderDetail()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Provider\ProviderDetail.cshtml"
  
    ViewBag.PageID = "provider-detail-view";
    ViewBag.Title = "Provider Details for " + Model.ProviderName;
    ViewBag.Description = "";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" class=\"provider-detail\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(" id=\"provider-name\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 15 "..\..\Views\Provider\ProviderDetail.cshtml"
           Write(Model.ProviderName);

            
            #line default
            #line hidden
WriteLiteral(" \r\n");

            
            #line 16 "..\..\Views\Provider\ProviderDetail.cshtml"
                
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Provider\ProviderDetail.cshtml"
                 if (@Model.NationalProvider)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <span");

WriteLiteral(" class=\"tag-national\"");

WriteLiteral("><span");

WriteLiteral(" class=\"font-adjust\"");

WriteLiteral(">National</span></span>\r\n");

            
            #line 19 "..\..\Views\Provider\ProviderDetail.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </h1>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <dl");

WriteLiteral(" class=\"data-list--provider data-list--compact\"");

WriteLiteral(">\r\n");

            
            #line 26 "..\..\Views\Provider\ProviderDetail.cshtml"
                
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Provider\ProviderDetail.cshtml"
                 if (!string.IsNullOrEmpty(Model.TradingNames))
        {

            
            #line default
            #line hidden
WriteLiteral("            <dt>Trading names:</dt>\r\n");

WriteLiteral("            <dd");

WriteLiteral(" id=\"trading-names\"");

WriteLiteral(">");

            
            #line 29 "..\..\Views\Provider\ProviderDetail.cshtml"
                              Write(Model.TradingNames);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n");

            
            #line 30 "..\..\Views\Provider\ProviderDetail.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("                <dt>UKPRN:</dt>\r\n                <dd>");

            
            #line 32 "..\..\Views\Provider\ProviderDetail.cshtml"
               Write(Model.UkPrn);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n            </dl>\r\n");

            
            #line 34 "..\..\Views\Provider\ProviderDetail.cshtml"
            
            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\Provider\ProviderDetail.cshtml"
              
        if (Model.IsLevyPayerOnly)
        {

            
            #line default
            #line hidden
WriteLiteral("            <p");

WriteLiteral(" id=\"levy-payer-only\"");

WriteLiteral(" class=\"detail-highlight\"");

WriteLiteral(">\r\n                Only levy paying employers can work with this provider\r\n      " +
"      </p>\r\n");

            
            #line 40 "..\..\Views\Provider\ProviderDetail.cshtml"
}
if (Model.HasParentCompanyGuarantee)
{

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" id=\"parent-company-guarantee\"");

WriteLiteral(" class=\"detail-highlight\"");

WriteLiteral(">\r\n            Provider is supported by a parent company guarantee\r\n        </p>\r" +
"\n");

            
            #line 46 "..\..\Views\Provider\ProviderDetail.cshtml"
}

if (Model.IsNew)
{

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" id=\"is-new-provider\"");

WriteLiteral(" class=\"detail-highlight\"");

WriteLiteral(">\r\n            New organisation with no financial track record\r\n        </p>\r\n");

            
            #line 53 "..\..\Views\Provider\ProviderDetail.cshtml"
}
            
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 56 "..\..\Views\Provider\ProviderDetail.cshtml"
            
            
            #line default
            #line hidden
            
            #line 56 "..\..\Views\Provider\ProviderDetail.cshtml"
             if (!Model.HasMoreThanOneTradingName)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" id=\"about-this-provider\"");

WriteLiteral(" class=\"markdown-header-text\"");

WriteLiteral(">About this Provider</p>\r\n");

            
            #line 59 "..\..\Views\Provider\ProviderDetail.cshtml"
if (string.IsNullOrEmpty(Model.MarketingInfo))
{

            
            #line default
            #line hidden
WriteLiteral("        <span>There is no marketing information available about this provider.</s" +
"pan>\r\n");

            
            #line 62 "..\..\Views\Provider\ProviderDetail.cshtml"
}
else
{
        
            
            #line default
            #line hidden
            
            #line 65 "..\..\Views\Provider\ProviderDetail.cshtml"
   Write(Html.MarkdownToHtml(Model.MarketingInfo));

            
            #line default
            #line hidden
            
            #line 65 "..\..\Views\Provider\ProviderDetail.cshtml"
                                                 
}
}

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 68 "..\..\Views\Provider\ProviderDetail.cshtml"
             if (Model.ApprenticeshipTrainingSummary != null && Model.ApprenticeshipTrainingSummary.Count > 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" id=\"search-app-offered\"");

WriteLiteral(">\r\n            <h2");

WriteLiteral(" class=\"heading-medium app-offered\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 72 "..\..\Views\Provider\ProviderDetail.cshtml"
           Write(Model.ApprenticeshipTrainingSummary.Count);

            
            #line default
            #line hidden
WriteLiteral(" Apprenticeships offered\r\n            </h2>\r\n        </div>\r\n");

WriteLiteral("        <table");

WriteLiteral(" class=\"app-details\"");

WriteLiteral(">\r\n            <thead>\r\n                <tr>\r\n                    <th>Apprentices" +
"hip</th>\r\n                    <th>Type</th>\r\n                    <th>Level</th>\r" +
"\n                    <th><span");

WriteLiteral(" class=\"visibility-hidden\"");

WriteLiteral(">View details</span></th>\r\n                </tr>\r\n            </thead>\r\n         " +
"   <tbody>\r\n");

            
            #line 85 "..\..\Views\Provider\ProviderDetail.cshtml"
                
            
            #line default
            #line hidden
            
            #line 85 "..\..\Views\Provider\ProviderDetail.cshtml"
                 foreach (var item in Model.ApprenticeshipTrainingSummary.ApprenticeshipTrainingItems)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td>");

            
            #line 88 "..\..\Views\Provider\ProviderDetail.cshtml"
               Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 89 "..\..\Views\Provider\ProviderDetail.cshtml"
               Write(item.Type);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 90 "..\..\Views\Provider\ProviderDetail.cshtml"
               Write(item.Level);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2984), Tuple.Create("\"", 3034)
, Tuple.Create(Tuple.Create("", 2991), Tuple.Create("/Apprenticeship/", 2991), true)
            
            #line 91 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create("", 3007), Tuple.Create<System.Object, System.Int32>(item.Type
            
            #line default
            #line hidden
, 3007), false)
, Tuple.Create(Tuple.Create("", 3017), Tuple.Create("/", 3017), true)
            
            #line 91 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create("", 3018), Tuple.Create<System.Object, System.Int32>(item.Identifier
            
            #line default
            #line hidden
, 3018), false)
);

WriteLiteral(">Details</a></td>\r\n            </tr>\r\n");

            
            #line 93 "..\..\Views\Provider\ProviderDetail.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("            </tbody>\r\n        </table>\r\n");

            
            #line 96 "..\..\Views\Provider\ProviderDetail.cshtml"
}
        
            
            #line default
            #line hidden
            
            #line 108 "..\..\Views\Provider\ProviderDetail.cshtml"
            

            
            #line default
            #line hidden
WriteLiteral("\r\n            <nav");

WriteLiteral(" role=\"navigation\"");

WriteLiteral(">\r\n                <ul");

WriteLiteral(" class=\"previous-next-navigation\"");

WriteLiteral(">\r\n                 \r\n                <li");

WriteLiteral(" class=\"previous\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">\r\n                        Previous <span");

WriteLiteral(" class=\"visuallyhidden\"");

WriteLiteral(">page</span>\r\n                        <span");

WriteLiteral(" class=\"page-numbers\"");

WriteLiteral(">Previous page 1 of 10</span>\r\n                    </a>\r\n                </li>\r\n " +
"           \r\n                <li");

WriteLiteral(" class=\"next\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">\r\n                        Next <span");

WriteLiteral(" class=\"visuallyhidden\"");

WriteLiteral(">page</span>\r\n                        <span");

WriteLiteral(" class=\"page-numbers\"");

WriteLiteral(">Next page 2 of 10 </span>\r\n                    </a>\r\n                </li>\r\n    " +
"            </ul>\r\n            </nav>\r\n\r\n\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"column-one-third\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"panel--contact\"");

WriteLiteral(">\r\n                <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">Contact details</h2>\r\n                <dl>\r\n");

            
            #line 136 "..\..\Views\Provider\ProviderDetail.cshtml"
                     
            
            #line default
            #line hidden
            
            #line 136 "..\..\Views\Provider\ProviderDetail.cshtml"
                       var linkProtocol = Model.Website.StartsWith("http") ? string.Empty : "http://";
            
            #line default
            #line hidden
WriteLiteral("\r\n                    <dt");

WriteLiteral(" class=\"apprenticeshipContactTitle\"");

WriteLiteral(">Website:</dt>\r\n                    <dd>\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4940), Tuple.Create("\"", 4974)
            
            #line 139 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create("", 4947), Tuple.Create<System.Object, System.Int32>(linkProtocol
            
            #line default
            #line hidden
, 4947), false)
            
            #line 139 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create("", 4960), Tuple.Create<System.Object, System.Int32>(Model.Website
            
            #line default
            #line hidden
, 4960), false)
);

WriteLiteral(" rel=\"external\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" class=\"course-link apprenticeshipContact\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 140 "..\..\Views\Provider\ProviderDetail.cshtml"
                       Write(Html.Raw(Model.ProviderName + " website"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </a>\r\n                    </dd>\r\n\r\n");

            
            #line 144 "..\..\Views\Provider\ProviderDetail.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 144 "..\..\Views\Provider\ProviderDetail.cshtml"
                      
                    if (!string.IsNullOrEmpty(Model.Phone))
                        {

            
            #line default
            #line hidden
WriteLiteral("                        <dt");

WriteLiteral(" class=\"phone-title\"");

WriteLiteral(">Phone number:</dt>\r\n");

WriteLiteral("                        <dd");

WriteLiteral(" id=\"phone\"");

WriteLiteral(" class=\"phone\"");

WriteLiteral(">");

            
            #line 148 "..\..\Views\Provider\ProviderDetail.cshtml"
                                                Write(Html.Raw(Model.Phone));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n");

            
            #line 149 "..\..\Views\Provider\ProviderDetail.cshtml"
                        }
                    
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 151 "..\..\Views\Provider\ProviderDetail.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 151 "..\..\Views\Provider\ProviderDetail.cshtml"
                      
                    if (!string.IsNullOrEmpty(Model.Email))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <dt");

WriteLiteral(" class=\"email-title\"");

WriteLiteral(">Email:</dt>\r\n");

WriteLiteral("                            <dd");

WriteLiteral(" id=\"email\"");

WriteLiteral(" class=\"email\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 5730), Tuple.Create("\"", 5766)
, Tuple.Create(Tuple.Create("", 5737), Tuple.Create("mailto:", 5737), true)
            
            #line 155 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create("", 5744), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.Email)
            
            #line default
            #line hidden
, 5744), false)
);

WriteLiteral(">");

            
            #line 155 "..\..\Views\Provider\ProviderDetail.cshtml"
                                                                                            Write(Html.Raw(Model.Email));

            
            #line default
            #line hidden
WriteLiteral("</a></dd>\r\n");

            
            #line 156 "..\..\Views\Provider\ProviderDetail.cshtml"
                        }
                    
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                </dl>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"panel--contact panel--satisfaction\"");

WriteLiteral(">\r\n                <dl>\r\n                    <dt>Employer satisfaction:</dt>\r\n   " +
"                 <dd>\r\n                        <div");

WriteLiteral(" class=\"rating rating--inline\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" id=\"employer-satisfaction\"");

WriteAttribute("class", Tuple.Create(" class=\"", 6180), Tuple.Create("\"", 6222)
, Tuple.Create(Tuple.Create("", 6188), Tuple.Create("rating-", 6188), true)
            
            #line 166 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create("", 6195), Tuple.Create<System.Object, System.Int32>(Model.EmployerSatisfaction
            
            #line default
            #line hidden
, 6195), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 167 "..\..\Views\Provider\ProviderDetail.cshtml"
                           Write(Model.EmployerSatisfactionMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n");

WriteLiteral("                            ");

            
            #line 169 "..\..\Views\Provider\ProviderDetail.cshtml"
                       Write(CreateProgressBar(Model.EmployerSatisfactionMessage, (int)Model.EmployerSatisfaction));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </dd>\r\n                    " +
"<dt>Learner satisfaction:</dt>\r\n                    <dd>\r\n                      " +
"  <div");

WriteLiteral(" class=\"rating rating--inline\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" id=\"learner-satisfaction\"");

WriteAttribute("class", Tuple.Create(" class=\"", 6704), Tuple.Create("\"", 6745)
, Tuple.Create(Tuple.Create("", 6712), Tuple.Create("rating-", 6712), true)
            
            #line 175 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create("", 6719), Tuple.Create<System.Object, System.Int32>(Model.LearnerSatisfaction
            
            #line default
            #line hidden
, 6719), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 176 "..\..\Views\Provider\ProviderDetail.cshtml"
                           Write(Model.LearnerSatisfactionMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n");

WriteLiteral("                            ");

            
            #line 178 "..\..\Views\Provider\ProviderDetail.cshtml"
                       Write(CreateProgressBar(Model.LearnerSatisfactionMessage, (int)Model.LearnerSatisfaction));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n");

            
            #line 180 "..\..\Views\Provider\ProviderDetail.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 180 "..\..\Views\Provider\ProviderDetail.cshtml"
                         if (!(Model.EmployerSatisfactionMessage == "no data available" && Model.LearnerSatisfactionMessage == "no data available"))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <span");

WriteLiteral(" class=\"satisfaction-source font-small\"");

WriteLiteral(">\r\n                                Source: <a");

WriteLiteral(" href=\"https://www.gov.uk/government/statistical-data-sets/fe-choices-performance" +
"-indicators\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">Skills Funding Agency FE Choices</a>\r\n                            </span>\r\n");

            
            #line 185 "..\..\Views\Provider\ProviderDetail.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </dd>\r\n                </dl>\r\n            </div>\r\n           " +
" <div");

WriteLiteral(" class=\"panel-disclaimer\"");

WriteLiteral(@">
                <h4>Content disclaimer</h4>
                <p>
                    Education and Skills Funding Agency cannot guarantee the accuracy of course information on this site and makes 
                    no representations about the quality of any courses which appear on the site. Education and Skills Funding Agency 
                    is not liable for any losses suffered as a result of any party relying on the course information 
                    provided.
                </p>
            </div>
            <div");

WriteLiteral(" id=\"expand-collapse\"");

WriteLiteral(">\r\n               <details>\r\n                    <summary>Explain levels</summary" +
">\r\n                    <div");

WriteLiteral(" class=\"panel panel-border-narrow\"");

WriteLiteral(">\r\n                        <p>Apprenticeships are set at different levels of diff" +
"iculty from the equivalent of GCSE (level 2) up to postgraduate (level 7)</p>\r\n " +
"                       <p><a");

WriteLiteral(" href=\"https://www.gov.uk/what-different-qualification-levels-mean/overview\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" rel=\"external\"");

WriteLiteral(">More about levels</a></p>\r\n                    </div>\r\n                </details" +
">\r\n            </div>\r\n        </div>       \r\n    </div>\r\n</main>\r\n     \r\n\r\n");

        }
    }
}
#pragma warning restore 1591
