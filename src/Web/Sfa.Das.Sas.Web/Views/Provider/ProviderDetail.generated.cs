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

#line 104 "..\..\Views\Provider\ProviderDetail.cshtml"
public System.Web.WebPages.HelperResult CreateProgressBar(string message, int progress)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 105 "..\..\Views\Provider\ProviderDetail.cshtml"
 
if (progress > 0)
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <div");

WriteLiteralTo(__razor_helper_writer, " class=\"progress-container\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"progressbar\"");

WriteAttributeTo(__razor_helper_writer, "style", Tuple.Create(" style=\"", 4865), Tuple.Create("\"", 4890)
, Tuple.Create(Tuple.Create("", 4873), Tuple.Create("width:", 4873), true)

#line 109 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create(" ", 4879), Tuple.Create<System.Object, System.Int32>(progress

#line default
#line hidden
, 4880), false)
, Tuple.Create(Tuple.Create("", 4889), Tuple.Create("%", 4889), true)
);

WriteLiteralTo(__razor_helper_writer, "></div>\r\n        </div>\r\n");


#line 111 "..\..\Views\Provider\ProviderDetail.cshtml"
}


#line default
#line hidden
});

#line 112 "..\..\Views\Provider\ProviderDetail.cshtml"
}
#line default
#line hidden

        public ProviderDetail()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Provider\ProviderDetail.cshtml"
  
    ViewBag.Title = "Provider Details";
    ViewBag.Description = "";

            
            #line default
            #line hidden
WriteLiteral("\r\n<main");

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

            
            #line 13 "..\..\Views\Provider\ProviderDetail.cshtml"
           Write(Model.ProviderName);

            
            #line default
            #line hidden
WriteLiteral(" \r\n");

            
            #line 14 "..\..\Views\Provider\ProviderDetail.cshtml"
                
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Provider\ProviderDetail.cshtml"
                 if (@Model.NationalProvider)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <span");

WriteLiteral(" class=\"tag tag-national\"");

WriteLiteral(">National</span>\r\n");

            
            #line 17 "..\..\Views\Provider\ProviderDetail.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </h1>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <dl");

WriteLiteral(" class=\"data-list--provider data-list--compact\"");

WriteLiteral(">\r\n                <dt>Trading names:</dt>\r\n");

            
            #line 25 "..\..\Views\Provider\ProviderDetail.cshtml"
                
            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\Provider\ProviderDetail.cshtml"
                 if (!string.IsNullOrEmpty(Model.TradingNames))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <dd");

WriteLiteral(" id=\"trading-names\"");

WriteLiteral(">");

            
            #line 27 "..\..\Views\Provider\ProviderDetail.cshtml"
                                      Write(Model.TradingNames);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n");

            
            #line 28 "..\..\Views\Provider\ProviderDetail.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <dt>UKPRN:</dt>\r\n                <dd>");

            
            #line 30 "..\..\Views\Provider\ProviderDetail.cshtml"
               Write(Model.UkPrn);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n            </dl>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"column-one-third\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"panel--contact\"");

WriteLiteral(">\r\n                <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">Contact details</h2>\r\n                <dl>\r\n");

            
            #line 37 "..\..\Views\Provider\ProviderDetail.cshtml"
                     
            
            #line default
            #line hidden
            
            #line 37 "..\..\Views\Provider\ProviderDetail.cshtml"
                       var linkProtocol = Model.Website.StartsWith("http") ? string.Empty : "http://";
            
            #line default
            #line hidden
WriteLiteral("\r\n                    <dt");

WriteLiteral(" class=\"apprenticeshipContactTitle\"");

WriteLiteral(">Website:</dt>\r\n                    <dd>\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1449), Tuple.Create("\"", 1483)
            
            #line 40 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create("", 1456), Tuple.Create<System.Object, System.Int32>(linkProtocol
            
            #line default
            #line hidden
, 1456), false)
            
            #line 40 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create("", 1469), Tuple.Create<System.Object, System.Int32>(Model.Website
            
            #line default
            #line hidden
, 1469), false)
);

WriteLiteral(" rel=\"external\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" class=\"course-link apprenticeshipContact\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 41 "..\..\Views\Provider\ProviderDetail.cshtml"
                       Write(Html.Raw(Model.ProviderName + " website"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </a>\r\n                    </dd>\r\n\r\n");

            
            #line 45 "..\..\Views\Provider\ProviderDetail.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Provider\ProviderDetail.cshtml"
                      
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

            
            #line 49 "..\..\Views\Provider\ProviderDetail.cshtml"
                                                Write(Html.Raw(Model.Phone));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n");

            
            #line 50 "..\..\Views\Provider\ProviderDetail.cshtml"
                        }
                    
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 52 "..\..\Views\Provider\ProviderDetail.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\Provider\ProviderDetail.cshtml"
                      
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

WriteAttribute("href", Tuple.Create(" href=\"", 2239), Tuple.Create("\"", 2275)
, Tuple.Create(Tuple.Create("", 2246), Tuple.Create("mailto:", 2246), true)
            
            #line 56 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create("", 2253), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.Email)
            
            #line default
            #line hidden
, 2253), false)
);

WriteLiteral(">");

            
            #line 56 "..\..\Views\Provider\ProviderDetail.cshtml"
                                                                                            Write(Html.Raw(Model.Email));

            
            #line default
            #line hidden
WriteLiteral("</a></dd>\r\n");

            
            #line 57 "..\..\Views\Provider\ProviderDetail.cshtml"
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

WriteAttribute("class", Tuple.Create(" class=\"", 2689), Tuple.Create("\"", 2731)
, Tuple.Create(Tuple.Create("", 2697), Tuple.Create("rating-", 2697), true)
            
            #line 67 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create("", 2704), Tuple.Create<System.Object, System.Int32>(Model.EmployerSatisfaction
            
            #line default
            #line hidden
, 2704), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 68 "..\..\Views\Provider\ProviderDetail.cshtml"
                           Write(Model.EmployerSatisfactionMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n");

WriteLiteral("                            ");

            
            #line 70 "..\..\Views\Provider\ProviderDetail.cshtml"
                       Write(CreateProgressBar(Model.EmployerSatisfactionMessage, (int)Model.EmployerSatisfaction));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </dd>\r\n                    " +
"<dt>Learner satisfaction:</dt>\r\n                    <dd>\r\n                      " +
"  <div");

WriteLiteral(" class=\"rating rating--inline\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" id=\"learner-satisfaction\"");

WriteAttribute("class", Tuple.Create(" class=\"", 3213), Tuple.Create("\"", 3254)
, Tuple.Create(Tuple.Create("", 3221), Tuple.Create("rating-", 3221), true)
            
            #line 76 "..\..\Views\Provider\ProviderDetail.cshtml"
, Tuple.Create(Tuple.Create("", 3228), Tuple.Create<System.Object, System.Int32>(Model.LearnerSatisfaction
            
            #line default
            #line hidden
, 3228), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 77 "..\..\Views\Provider\ProviderDetail.cshtml"
                           Write(Model.LearnerSatisfactionMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n");

WriteLiteral("                            ");

            
            #line 79 "..\..\Views\Provider\ProviderDetail.cshtml"
                       Write(CreateProgressBar(Model.LearnerSatisfactionMessage, (int)Model.LearnerSatisfaction));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n");

            
            #line 81 "..\..\Views\Provider\ProviderDetail.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 81 "..\..\Views\Provider\ProviderDetail.cshtml"
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

            
            #line 86 "..\..\Views\Provider\ProviderDetail.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </dd>\r\n                </dl>\r\n            </div>\r\n           " +
" <div");

WriteLiteral(" class=\"panel--disclaimer\"");

WriteLiteral(@">
                <h4>Content disclaimer</h4>
                <p>
                    Education & Skills Funding Agency cannot guarantee the accuracy of course information on this site and makes 
                    no representations about the quality of any courses which appear on the site. Education & Skills Funding Agency 
                    is not liable for any losses suffered as a result of any party relying on the course information 
                    provided.
                </p>
            </div>
        </div>       
    </div>
</main>
     

");

        }
    }
}
#pragma warning restore 1591
