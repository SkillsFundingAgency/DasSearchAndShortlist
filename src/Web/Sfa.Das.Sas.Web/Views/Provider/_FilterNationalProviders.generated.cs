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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Provider/_FilterNationalProviders.cshtml")]
    public partial class FilterNationalProviders : System.Web.Mvc.WebViewPage<Sfa.Das.Sas.Web.ViewModels.NationalProviderViewModel>
    {
        public FilterNationalProviders()
        {
        }
        public override void Execute()
        {
WriteLiteral("<fieldset");

WriteLiteral(" class=\"filters filters-accordion\"");

WriteLiteral(">\r\n    <h2");

WriteLiteral(" class=\"toggler heading-small\"");

WriteLiteral(">National training providers</h2>\r\n    <div");

WriteLiteral(" class=\"toggled-content\"");

WriteLiteral(">\r\n        <ul>\r\n            <li>\r\n                <input");

WriteLiteral(" value=\"true\"");

WriteLiteral(" name=\"NationalProvidersOnly\"");

WriteAttribute("id", Tuple.Create(" id=\"", 312), Tuple.Create("\"", 351)
, Tuple.Create(Tuple.Create("", 317), Tuple.Create("NationalProvidersOnly_", 317), true)
            
            #line 8 "..\..\Views\Provider\_FilterNationalProviders.cshtml"
            , Tuple.Create(Tuple.Create("", 339), Tuple.Create<System.Object, System.Int32>(Model.Value
            
            #line default
            #line hidden
, 339), false)
);

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" ");

            
            #line 8 "..\..\Views\Provider\_FilterNationalProviders.cshtml"
                                                                                                                    Write(Html.Raw(Model.Checked ? "checked" : ""));

            
            #line default
            #line hidden
WriteLiteral("  ");

            
            #line 8 "..\..\Views\Provider\_FilterNationalProviders.cshtml"
                                                                                                                                                               Write(Html.Raw(Model.Count == 0 ? "disabled" : ""));

            
            #line default
            #line hidden
WriteLiteral("/>\r\n                <label");

WriteAttribute("for", Tuple.Create(" for=\"", 483), Tuple.Create("\"", 523)
, Tuple.Create(Tuple.Create("", 489), Tuple.Create("NationalProvidersOnly_", 489), true)
            
            #line 9 "..\..\Views\Provider\_FilterNationalProviders.cshtml"
, Tuple.Create(Tuple.Create("", 511), Tuple.Create<System.Object, System.Int32>(Model.Value
            
            #line default
            #line hidden
, 511), false)
);

WriteLiteral(">national providers (");

            
            #line 9 "..\..\Views\Provider\_FilterNationalProviders.cshtml"
                                                                               Write(Model.Count);

            
            #line default
            #line hidden
WriteLiteral(")</label>\r\n            </li>   \r\n        </ul>\r\n    </div>\r\n</fieldset>");

        }
    }
}
#pragma warning restore 1591
