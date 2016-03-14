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
    
    #line 1 "..\..\Views\Provider\_ProviderInformation.cshtml"
    using Sfa.Das.ApplicationServices.Models;
    
    #line default
    #line hidden
    using Sfa.Eds.Das.Web;
    
    #line 2 "..\..\Views\Provider\_ProviderInformation.cshtml"
    using Sfa.Eds.Das.Web.ViewModels;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Provider/_ProviderInformation.cshtml")]
    public partial class ProviderInformation : System.Web.Mvc.WebViewPage<Sfa.Eds.Das.Web.ViewModels.ProviderSearchResultViewModel>
    {

#line 32 "..\..\Views\Provider\_ProviderInformation.cshtml"
public System.Web.WebPages.HelperResult  RenderEmployersLocationProviderDetails(ProviderResultItemViewModel item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 33 "..\..\Views\Provider\_ProviderInformation.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <dt>Distance:</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dd>Training can take place at your location.</dd>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dt>Website:</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dd><a");

WriteLiteralTo(__razor_helper_writer, " class=\"link\"");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1302), Tuple.Create("\"", 1322)

#line 37 "..\..\Views\Provider\_ProviderInformation.cshtml"
, Tuple.Create(Tuple.Create("", 1309), Tuple.Create<System.Object, System.Int32>(item.Website

#line default
#line hidden
, 1309), false)
);

WriteLiteralTo(__razor_helper_writer, "> ");


#line 37 "..\..\Views\Provider\_ProviderInformation.cshtml"
                WriteTo(__razor_helper_writer, item.Website);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a></dd>\r\n");


#line 38 "..\..\Views\Provider\_ProviderInformation.cshtml"


#line default
#line hidden
});

#line 38 "..\..\Views\Provider\_ProviderInformation.cshtml"
}
#line default
#line hidden

#line 40 "..\..\Views\Provider\_ProviderInformation.cshtml"
public System.Web.WebPages.HelperResult  RenderProviderDetails(ProviderResultItemViewModel item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 41 "..\..\Views\Provider\_ProviderInformation.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <dt>Distance:</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dd>");


#line 43 "..\..\Views\Provider\_ProviderInformation.cshtml"
WriteTo(__razor_helper_writer, item.Distance);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " miles away</dd>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dd");

WriteLiteralTo(__razor_helper_writer, " class=\"address\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 44 "..\..\Views\Provider\_ProviderInformation.cshtml"
WriteTo(__razor_helper_writer, item.LocationName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 44 "..\..\Views\Provider\_ProviderInformation.cshtml"
             WriteTo(__razor_helper_writer, item.Address.Address1);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 44 "..\..\Views\Provider\_ProviderInformation.cshtml"
                                    WriteTo(__razor_helper_writer, item.Address.Address2);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 44 "..\..\Views\Provider\_ProviderInformation.cshtml"
                                                           WriteTo(__razor_helper_writer, item.Address.County);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dt>Website:</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dd><a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1636), Tuple.Create("\"", 1656)

#line 46 "..\..\Views\Provider\_ProviderInformation.cshtml"
, Tuple.Create(Tuple.Create("", 1643), Tuple.Create<System.Object, System.Int32>(item.Website

#line default
#line hidden
, 1643), false)
);

WriteLiteralTo(__razor_helper_writer, "> ");


#line 46 "..\..\Views\Provider\_ProviderInformation.cshtml"
   WriteTo(__razor_helper_writer, item.Website);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a></dd>\r\n");


#line 47 "..\..\Views\Provider\_ProviderInformation.cshtml"


#line default
#line hidden
});

#line 47 "..\..\Views\Provider\_ProviderInformation.cshtml"
}
#line default
#line hidden

        public ProviderInformation()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div>\r\n");

            
            #line 6 "..\..\Views\Provider\_ProviderInformation.cshtml"
    
            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\Provider\_ProviderInformation.cshtml"
     foreach (var item in Model.Hits)
    {

            
            #line default
            #line hidden
WriteLiteral("        <li");

WriteLiteral(" class=\"result\"");

WriteLiteral(">\r\n            <h2");

WriteLiteral(" class=\"result-title\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 10 "..\..\Views\Provider\_ProviderInformation.cshtml"
           Write(Html.ActionLink(item.Name, "Detail", "Provider", new {@providerId = item.Id, @locationId = item.LocationId, @standardCode = item.StandardCode}, null));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </h2>\r\n\r\n            <dl");

WriteLiteral(" class=\"reult-data-list\"");

WriteLiteral(">\r\n");

            
            #line 14 "..\..\Views\Provider\_ProviderInformation.cshtml"
                
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Provider\_ProviderInformation.cshtml"
                 if (item.DeliveryModes != null && item.DeliveryModes.Contains("100PercentEmployer"))
                {
                    
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Provider\_ProviderInformation.cshtml"
               Write(RenderEmployersLocationProviderDetails(item));

            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Provider\_ProviderInformation.cshtml"
                                                                 
                }
                else
                {
                    
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Provider\_ProviderInformation.cshtml"
               Write(RenderProviderDetails(item));

            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Provider\_ProviderInformation.cshtml"
                                                
                }

            
            #line default
            #line hidden
WriteLiteral("                \r\n                <dt>Employer satisfaction:</dt>\r\n              " +
"  <dd>");

            
            #line 24 "..\..\Views\Provider\_ProviderInformation.cshtml"
               Write(item.EmployerSatisfaction);

            
            #line default
            #line hidden
WriteLiteral(" %</dd>\r\n                <dt>Learner satisfaction:</dt>\r\n                <dd>");

            
            #line 26 "..\..\Views\Provider\_ProviderInformation.cshtml"
               Write(item.LearnerSatisfaction);

            
            #line default
            #line hidden
WriteLiteral(" %</dd>\r\n            </dl>\r\n        </li>\r\n");

            
            #line 29 "..\..\Views\Provider\_ProviderInformation.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
