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
    
    #line 2 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
    using FeatureToggle.Core.Fluent;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
    using Sfa.Das.Sas.ApplicationServices.FeatureToggles;
    
    #line default
    #line hidden
    using Sfa.Das.Sas.Web;
    
    #line 3 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
    using Sfa.Das.Sas.Web.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
    using Sfa.Das.Sas.Web.ViewModels;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Provider/_FrameworkProviderInformation.cshtml")]
    public partial class FrameworkProviderInformation : System.Web.Mvc.WebViewPage<Sfa.Das.Sas.Web.ViewModels.ProviderFrameworkSearchResultViewModel>
    {

#line 61 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
public System.Web.WebPages.HelperResult RenderDeliveryOptions(FrameworkProviderResultItemViewModel item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 62 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <dt><b>Training options:</b></dt>\r\n");


#line 64 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <dd");

WriteLiteralTo(__razor_helper_writer, " class=\"deliveryOptions\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 65 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
  WriteTo(__razor_helper_writer, Html.Raw(item.DeliveryOptionsMessage));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 66 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"


#line default
#line hidden
});

#line 66 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
}
#line default
#line hidden

        public FrameworkProviderInformation()
        {
        }
        public override void Execute()
        {
            
            #line 7 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
   var index = (Model.ActualPage * Model.ResultsToTake) - Model.ResultsToTake; 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 8 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
 foreach (var item in Model.Hits)
{
    index += 1;

            
            #line default
            #line hidden
WriteLiteral("        <article");

WriteLiteral(" class=\"result\"");

WriteLiteral(">\r\n            <header>\r\n                <h2");

WriteLiteral(" class=\"result-title\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 14 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
               Write(Html.ActionLink(item.ProviderName, "Detail", "Provider", 
                        new { @ukprn = item.UkPrn, @locationId = item.LocationId, @frameworkId = item.FrameworkId, isLevyPayingEmployer = Model.IsLevyPayingEmployer },
                        new { @attr_ga_result_interval = @ViewHelper.GetGaIndexAttrbute(index) }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 17 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
                     if (item.NationalProvider)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <span");

WriteLiteral(" class=\"tag tag-new\"");

WriteLiteral(">National</span>\r\n");

            
            #line 20 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </h2>\r\n            </header>\r\n\r\n");

            
            #line 24 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
            
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
             if (item.CurrentlyNotStartingNewApprentices)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"error-summary warning\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"error-message\"");

WriteLiteral(">This provider is not currently starting new apprentices</p>\r\n                </d" +
"iv>\r\n");

            
            #line 29 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n            <dl");

WriteLiteral(" class=\"result-data-list\"");

WriteLiteral(">\r\n\r\n                <dt><b>Distance:</b></dt>\r\n                <dd");

WriteLiteral(" class=\"distance\"");

WriteLiteral(">");

            
            #line 34 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
                                Write(item.Distance);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 34 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
                                                Write(item.Distance == 1 ? "mile" : "miles");

            
            #line default
            #line hidden
WriteLiteral(" away</dd>\r\n");

            
            #line 35 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
                
            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
                 if (item.DeliveryModes != null && (item.DeliveryModes.Contains("BlockRelease") || item.DeliveryModes.Contains("DayRelease")))
                {
                    if (@item.Address != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <dd");

WriteLiteral(" class=\"address\"");

WriteLiteral(">");

            
            #line 39 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
                                       Write(item.LocationAddressLine);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n");

            
            #line 40 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
                    }
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 43 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
           Write(RenderDeliveryOptions(item));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                <dt><b>Employer satisfaction:</b></dt>\r\n                <dd");

WriteLiteral(" class=\"employer-satisfaction\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 47 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
               Write(item.EmployerSatisfactionMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </dd>\r\n                <dt><b>Learner satisfaction:</b></dt>\r\n " +
"               <dd");

WriteLiteral(" class=\"learner-satisfaction\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 51 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
               Write(item.LearnerSatisfactionMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </dd>\r\n                <dt><b>Achievement rate:</b></dt>\r\n     " +
"           <dd");

WriteLiteral(" class=\"achievement-rate\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 55 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
               Write(item.AchievementRateMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </article>\r\n");

            
            #line 59 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
