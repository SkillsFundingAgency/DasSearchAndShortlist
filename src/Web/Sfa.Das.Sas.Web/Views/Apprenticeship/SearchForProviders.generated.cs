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
    
    #line 2 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
    using SFA.DAS.Apprenticeships.Api.Types;
    
    #line default
    #line hidden
    using Sfa.Das.Sas.Web;
    
    #line 1 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Apprenticeship/SearchForProviders.cshtml")]
    public partial class SearchForProviders : System.Web.Mvc.WebViewPage<Sfa.Das.Sas.Web.ViewModels.ProviderSearchViewModel>
    {
        public SearchForProviders()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
  
    ViewBag.Title = "Search for providers";
    ViewBag.Description = "The Find Apprenticeship Training service is for employers in England who want to find training courses for their apprentices and search for training providers.";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <main");

WriteLiteral(" id=\"content\"");

WriteLiteral(">\r\n");

            
            #line 10 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
        
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
         switch (Model.ApprenticeshipType)
        {
            case ApprenticeshipTrainingType.Framework:
                
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
           Write(Html.ActionLink("Back", "Framework", new { @keywords = Model.SearchTerms, @id = Model.ApprenticeshipId, @ukprn = Model.Ukprn }, new { @class = "link-back" }));

            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
                                                                                                                                                                              
                break;
            case ApprenticeshipTrainingType.Standard:
                
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
           Write(Html.ActionLink("Back", "Standard", new { @keywords = Model.SearchTerms, @id = Model.ApprenticeshipId, @ukprn = Model.Ukprn }, new { @class = "link-back" }));

            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
                                                                                                                                                                             
                break;
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteAttribute("class", Tuple.Create(" class=\"", 995), Tuple.Create("\"", 1050)
, Tuple.Create(Tuple.Create("", 1003), Tuple.Create("error-summary", 1003), true)
            
            #line 20 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
, Tuple.Create(Tuple.Create(" ", 1016), Tuple.Create<System.Object, System.Int32>(Model.HasError ? "" : "hidden"
            
            #line default
            #line hidden
, 1017), false)
);

WriteLiteral(" id=\"error-summary\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-labelledby=\"error-summary-heading\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(">\r\n            <h2");

WriteLiteral(" class=\"heading-medium error-summary-heading\"");

WriteLiteral(" id=\"error-summary-heading\"");

WriteLiteral(">\r\n                There is a problem\r\n            </h2>\r\n\r\n            <ul");

WriteLiteral(" class=\"error-summary-list\"");

WriteLiteral(">\r\n                <li><a");

WriteLiteral(" href=\"#error-postcode-service\"");

WriteLiteral(" id=\"error-postcode-link\"");

WriteLiteral(">");

            
            #line 26 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
                                                                          Write(Html.Raw(@Model.ErrorMessage));

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            </ul>\r\n        </div>\r\n\r\n        <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"heading-secondary\"");

WriteLiteral(">");

            
            #line 31 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
                                       Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            Find a training provider\r\n        </h1>\r\n\r\n        <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n                <form");

WriteAttribute("action", Tuple.Create(" action=\"", 1744), Tuple.Create("\"", 1767)
            
            #line 37 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
, Tuple.Create(Tuple.Create("", 1753), Tuple.Create<System.Object, System.Int32>(Model.PostUrl
            
            #line default
            #line hidden
, 1753), false)
);

WriteLiteral(" method=\"get\"");

WriteLiteral(" class=\"postcode-form\"");

WriteLiteral(">\r\n                    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 1830), Tuple.Create("\"", 1881)
, Tuple.Create(Tuple.Create("", 1838), Tuple.Create("form-group", 1838), true)
            
            #line 38 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
, Tuple.Create(Tuple.Create(" ", 1848), Tuple.Create<System.Object, System.Int32>(Model.HasError ? "error" : ""
            
            #line default
            #line hidden
, 1849), false)
);

WriteLiteral(" data-validation=\"Enter the postcode of your apprentice’s workplace\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"search-box\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"form-label-bold\"");

WriteLiteral(">Enter the postcode of your apprentice’s workplace</span>\r\n                      " +
"      <span");

WriteLiteral(" class=\"form-hint\"");

WriteLiteral(">For example: \'SW1A 2AA\'</span>\r\n\r\n                            <span");

WriteLiteral(" class=\"error-message\"");

WriteLiteral(">\r\n                                <span");

WriteLiteral(" id=\"error-postcode-service\"");

WriteLiteral(">\r\n");

WriteLiteral("                                    ");

            
            #line 45 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
                               Write(Html.Raw(@Model.ErrorMessage));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </span>\r\n                            </span>\r\n\r" +
"\n                        </label>\r\n                        <input");

WriteLiteral(" type=\"search\"");

WriteLiteral(" name=\"PostCode\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2573), Tuple.Create("\"", 2613)
            
            #line 50 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
, Tuple.Create(Tuple.Create("", 2581), Tuple.Create<System.Object, System.Int32>(Model.PostCode.FormatPostcode()
            
            #line default
            #line hidden
, 2581), false)
);

WriteLiteral(" id=\"search-box\"");

WriteLiteral(" class=\"form-control postcode-search-box\"");

WriteLiteral(" maxlength=\"200\"");

WriteLiteral(" placeholder=\"\"");

WriteLiteral(" />\r\n                    </div>\r\n\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"apprenticeshipid\"");

WriteLiteral(" class=\"text-box form-control\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2881), Tuple.Create("\"", 2912)
            
            #line 54 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
                          , Tuple.Create(Tuple.Create("", 2889), Tuple.Create<System.Object, System.Int32>(Model.ApprenticeshipId
            
            #line default
            #line hidden
, 2889), false)
);

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"keywords\"");

WriteLiteral(" class=\"text-box form-control\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3006), Tuple.Create("\"", 3032)
            
            #line 55 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
                  , Tuple.Create(Tuple.Create("", 3014), Tuple.Create<System.Object, System.Int32>(Model.SearchTerms
            
            #line default
            #line hidden
, 3014), false)
);

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"ukprn\"");

WriteLiteral(" class=\"text-box form-control\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3123), Tuple.Create("\"", 3143)
            
            #line 56 "..\..\Views\Apprenticeship\SearchForProviders.cshtml"
               , Tuple.Create(Tuple.Create("", 3131), Tuple.Create<System.Object, System.Int32>(Model.Ukprn
            
            #line default
            #line hidden
, 3131), false)
);

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"IsLevyPayingEmployer\"");

WriteLiteral(" value=\"true\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" class=\"button postcode-search-button\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Search\"");

WriteLiteral(">\r\n                    </div>\r\n                </form>\r\n            </div>\r\n     " +
"   </div>\r\n    </main>");

        }
    }
}
#pragma warning restore 1591
