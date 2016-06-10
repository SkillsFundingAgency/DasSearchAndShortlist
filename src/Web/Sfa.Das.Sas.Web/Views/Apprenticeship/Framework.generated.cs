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
    
    #line 1 "..\..\Views\Apprenticeship\Framework.cshtml"
    using Sfa.Das.Sas.Resources;
    
    #line default
    #line hidden
    using Sfa.Das.Sas.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Apprenticeship/Framework.cshtml")]
    public partial class Framework : System.Web.Mvc.WebViewPage<Sfa.Das.Sas.Web.ViewModels.FrameworkViewModel>
    {

#line 53 "..\..\Views\Apprenticeship\Framework.cshtml"
public System.Web.WebPages.HelperResult GetShortlistLink(int id, bool isShortlisted)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 54 "..\..\Views\Apprenticeship\Framework.cshtml"
 
if (isShortlisted)
{
        

#line default
#line hidden

#line 57 "..\..\Views\Apprenticeship\Framework.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink("Remove from shortlist", "RemoveFramework", "ShortList",
            new { id },
            new { @class = "link shortlist-link framework-shortlist-link", rel = "nofollow", data_framework = id, data_action = "remove" }));


#line default
#line hidden

#line 59 "..\..\Views\Apprenticeship\Framework.cshtml"
                                                                                                                                           
}
else
{
        

#line default
#line hidden

#line 63 "..\..\Views\Apprenticeship\Framework.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink("Shortlist apprenticeship", "AddFramework", "ShortList",
            new { id },
            new { @class = "link shortlist-link framework-shortlist-link", rel = "nofollow", data_framework = id, data_action = "add" }));


#line default
#line hidden

#line 65 "..\..\Views\Apprenticeship\Framework.cshtml"
                                                                                                                                        
}


#line default
#line hidden
});

#line 67 "..\..\Views\Apprenticeship\Framework.cshtml"
}
#line default
#line hidden

        public Framework()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Apprenticeship\Framework.cshtml"
  
    ViewBag.Title = "Framework - " + @Model.Title;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <header>\r\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 14 "..\..\Views\Apprenticeship\Framework.cshtml"
               Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </h1>\r\n                <dl");

WriteLiteral(" class=\"data-list\"");

WriteLiteral(">\r\n                    <dt>Level:</dt>\r\n                    <dd>\r\n");

WriteLiteral("                        ");

            
            #line 19 "..\..\Views\Apprenticeship\Framework.cshtml"
                   Write(Model.Level);

            
            #line default
            #line hidden
WriteLiteral(" (equivalent to ");

            
            #line 19 "..\..\Views\Apprenticeship\Framework.cshtml"
                                               Write(EquivalenveLevelService.GetApprenticeshipLevel(Model.Level.ToString()));

            
            #line default
            #line hidden
WriteLiteral(" )\r\n                    </dd>\r\n");

            
            #line 21 "..\..\Views\Apprenticeship\Framework.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\Apprenticeship\Framework.cshtml"
                     if (!string.IsNullOrEmpty(Model.TypicalLengthMessage))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <dt>Typical length:</dt>\r\n");

WriteLiteral("                        <dd>");

            
            #line 24 "..\..\Views\Apprenticeship\Framework.cshtml"
                       Write(Model.TypicalLengthMessage);

            
            #line default
            #line hidden
WriteLiteral(" </dd>\r\n");

            
            #line 25 "..\..\Views\Apprenticeship\Framework.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral(@"                </dl>
            </header>

            <p>This is an apprenticeship framework. Frameworks set out training requirements for apprentices in a specific work sector.</p>

            <p>If you are an employer, an apprenticeship training provider can give you more details about this framework, including: </p>

            <ul");

WriteLiteral(" class=\"list list-bullet\"");

WriteLiteral(">\r\n\r\n                <li>qualifications</li>\r\n                <li>entry requireme" +
"nts</li>\r\n                <li>career paths</li>\r\n\r\n            </ul>\r\n\r\n        " +
"    <div");

WriteLiteral(" id=\"bottom-actions\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 42 "..\..\Views\Apprenticeship\Framework.cshtml"
           Write(GetShortlistLink(@Model.FrameworkId, @Model.IsShortlisted));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                <a");

WriteLiteral(" class=\"button ui-find-training-providers\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1560), Tuple.Create("\"", 1687)
            
            #line 44 "..\..\Views\Apprenticeship\Framework.cshtml"
, Tuple.Create(Tuple.Create("", 1567), Tuple.Create<System.Object, System.Int32>(Url.Action("SearchForProviders", "Apprenticeship", new { frameworkId = Model.FrameworkId, keywords = Model.SearchTerm})
            
            #line default
            #line hidden
, 1567), false)
);

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-search\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></i>\r\n                    Find training Providers\r\n                </a>\r\n       " +
"     </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
