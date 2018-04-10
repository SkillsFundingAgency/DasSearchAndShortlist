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
    
    #line 1 "..\..\Views\Apprenticeship\Standard.cshtml"
    using System.Globalization;
    
    #line default
    #line hidden
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
    
    #line 2 "..\..\Views\Apprenticeship\Standard.cshtml"
    using Sfa.Das.Sas.Resources;
    
    #line default
    #line hidden
    using Sfa.Das.Sas.Web;
    
    #line 3 "..\..\Views\Apprenticeship\Standard.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Apprenticeship/Standard.cshtml")]
    public partial class Standard : System.Web.Mvc.WebViewPage<Sfa.Das.Sas.Web.ViewModels.StandardViewModel>
    {

#line 108 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetStandardProperty(string title, string id, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 109 "..\..\Views\Apprenticeship\Standard.cshtml"
 
    if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>");


#line 112 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 6100), Tuple.Create("\"", 6108)

#line 113 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 6105), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 6105), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 113 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, Html.MarkdownToHtml(item));


#line default
#line hidden

#line 113 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                if (item == null){ 

#line default
#line hidden

#line 113 "..\..\Views\Apprenticeship\Standard.cshtml"
                                     WriteTo(__razor_helper_writer, Html.Raw("&nbsp;"));


#line default
#line hidden

#line 113 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                                                       }

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 114 "..\..\Views\Apprenticeship\Standard.cshtml"
    }


#line default
#line hidden
});

#line 115 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

#line 117 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetMoreInformationProperty(string link)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 118 "..\..\Views\Apprenticeship\Standard.cshtml"
 
    {
        var details = "The Institute for Apprenticeships has more detailed information about this apprenticeship.";
        if (link!=null && link.Trim() != string.Empty)
        {
            details = @"The Institute for Apprenticeships has more <a href='" + link + "' target='_blank'>detailed information</a> about this apprenticeship.";
        }



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>More Information</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteLiteralTo(__razor_helper_writer, " id=\"more-information\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 127 "..\..\Views\Apprenticeship\Standard.cshtml"
    WriteTo(__razor_helper_writer, Html.MarkdownToHtml(details));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 128 "..\..\Views\Apprenticeship\Standard.cshtml"
    }


#line default
#line hidden
});

#line 129 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

#line 131 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetDurationProperty(string title, string id, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 132 "..\..\Views\Apprenticeship\Standard.cshtml"
 
    if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>");


#line 135 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 6923), Tuple.Create("\"", 6931)

#line 136 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 6928), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 6928), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 136 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, item);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " months</dd>\r\n");


#line 137 "..\..\Views\Apprenticeship\Standard.cshtml"
    }


#line default
#line hidden
});

#line 138 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

#line 140 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetFundingBandProperty(int value)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 141 "..\..\Views\Apprenticeship\Standard.cshtml"
 
    var fundingCapFormatted = value.ToString("C0", new CultureInfo("en-GB"));



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <dt>Current funding band</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dd");

WriteLiteralTo(__razor_helper_writer, " id=\"funding-cap\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        Up to ");


#line 146 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, fundingCapFormatted);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " per apprentice.<br />\r\n        <a");

WriteLiteralTo(__razor_helper_writer, " href=\"https://www.gov.uk/guidance/employing-an-apprentice-technical-guide-for-em" +
"ployers#funding-for-your-apprenticeship\"");

WriteLiteralTo(__razor_helper_writer, " target=\"_blank\"");

WriteLiteralTo(__razor_helper_writer, " rel=\"external\"");

WriteLiteralTo(__razor_helper_writer, ">More information about funding</a>\r\n    </dd>\r\n");


#line 149 "..\..\Views\Apprenticeship\Standard.cshtml"


#line default
#line hidden
});

#line 149 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

#line 151 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetDocumentItem(string pdfUrl, string title)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 152 "..\..\Views\Apprenticeship\Standard.cshtml"
 
    if (!string.IsNullOrEmpty(title))
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <li>\r\n            <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 7557), Tuple.Create("\"", 7571)

#line 156 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 7564), Tuple.Create<System.Object, System.Int32>(pdfUrl

#line default
#line hidden
, 7564), false)
);

WriteLiteralTo(__razor_helper_writer, " target=\"_blank\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 157 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n            </a>\r\n        </li>\r\n");


#line 160 "..\..\Views\Apprenticeship\Standard.cshtml"
    }


#line default
#line hidden
});

#line 161 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

        public Standard()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Apprenticeship\Standard.cshtml"
  
    ViewBag.Title = Model.Title + " - Apprenticeship Standard";
    ViewBag.Description = Model.OverviewOfRole;
    var areOrganisationsPresent = Model.AssessmentOrganisations != null && Model.AssessmentOrganisations.Any();


            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" class=\"standard-detail\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <div>\r\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 17 "..\..\Views\Apprenticeship\Standard.cshtml"
               Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </h1>\r\n                <p");

WriteLiteral(" class=\"lede\"");

WriteLiteral(">");

            
            #line 19 "..\..\Views\Apprenticeship\Standard.cshtml"
                           Write(Model.OverviewOfRole);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"column-third\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"related-container\"");

WriteLiteral(">\r\n                <aside");

WriteLiteral(" class=\"hidden-for-mobile-tablet\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" class=\"button ui-find-training-providers\"");

WriteLiteral(" rel=\"nofollow\"");

WriteLiteral(" id=\"ga-find-provider-top\"");

WriteAttribute("href", Tuple.Create(" href=\"", 959), Tuple.Create("\"", 1093)
            
            #line 25 "..\..\Views\Apprenticeship\Standard.cshtml"
                                 , Tuple.Create(Tuple.Create("", 966), Tuple.Create<System.Object, System.Int32>(Url.Action("SearchForStandardProviders", "Apprenticeship", new { standardId = Model.StandardId, keywords = Model.SearchTerm })
            
            #line default
            #line hidden
, 966), false)
);

WriteLiteral(">\r\n                        Find training providers who offer this apprenticeship\r" +
"\n                    </a>\r\n                </aside>\r\n            </div>\r\n       " +
" </div>\r\n    </div>\r\n    <section>\r\n        <header>\r\n            <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">\r\n                Summary of this apprenticeship standard\r\n            </h2>\r\n  " +
"      </header>\r\n        <dl");

WriteLiteral(" class=\"data-list\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 39 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetStandardProperty("Level", "level", $"{@Model.Level} (equivalent to {EquivalenceLevelService.GetApprenticeshipLevel(Model.Level.ToString())})"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 40 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetDurationProperty("Typical length", "length", Model.Duration.ToString()));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 41 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetFundingBandProperty(Model.MaxFunding));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 42 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetStandardProperty("Entry requirements", "entry-requirements", Model.EntryRequirements));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 43 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetStandardProperty("What apprentices will learn", "will-learn", Model.WhatApprenticesWillLearn));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 44 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetStandardProperty("Qualifications", "qualifications", Model.Qualifications));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 45 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetStandardProperty("Professional registration", "professional-registration", Model.ProfessionalRegistration, true));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 47 "..\..\Views\Apprenticeship\Standard.cshtml"
            
            
            #line default
            #line hidden
            
            #line 47 "..\..\Views\Apprenticeship\Standard.cshtml"
             if (areOrganisationsPresent == false)
            {
                const string noDetails = @"A government-approved organisation must assess apprentices towards the end of their apprenticeship.<br/><br/> " +
                                    "This end-point assessment ensures apprentices achieve the skills, training and any qualifications necessary to complete their apprenticeship. <br/><br/>" +
                                    "You can download the assessment plan from the Institute for Apprenticeships. " +
                                    "There are no end-point assessment organisations for this apprenticeship yet. " +
                                    "Please email <a href='mailto:apprentice.assessment@education.gov.uk' target='_blank'>apprentice.assessment@education.gov.uk</a> if you urgently need an end-point assessment organisation.";
                
            
            #line default
            #line hidden
            
            #line 54 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(GetStandardProperty("How apprentices are assessed", "no-assessment-organisations", noDetails));

            
            #line default
            #line hidden
            
            #line 54 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                                                                              
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 57 "..\..\Views\Apprenticeship\Standard.cshtml"
            
            
            #line default
            #line hidden
            
            #line 57 "..\..\Views\Apprenticeship\Standard.cshtml"
             if (areOrganisationsPresent)
            {

            
            #line default
            #line hidden
WriteLiteral("                <dt>End Point Assessment</dt>\r\n");

WriteLiteral("                <dd>\r\n                    <details>\r\n                        <sum" +
"mary><span");

WriteLiteral(" class=\"summary\"");

WriteLiteral(" style=\"text-decoration: none\"");

WriteLiteral(">View a list of end point assessment organisations for this standard</span></summ" +
"ary>\r\n                        <table");

WriteLiteral(" class=\"responsive\"");

WriteLiteral(">\r\n                            <thead>\r\n                                <tr>\r\n   " +
"                                 <th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">Organisation</th>\r\n                                    <th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">Phone Number</th>\r\n                                    <th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">Email</th>\r\n                                </tr>\r\n                            <" +
"/thead>\r\n                            <tbody>\r\n");

            
            #line 72 "..\..\Views\Apprenticeship\Standard.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 72 "..\..\Views\Apprenticeship\Standard.cshtml"
                             foreach (var organisation in Model.AssessmentOrganisations)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <tr>\r\n                                    <td");

WriteLiteral(" class=\"organisation-name\"");

WriteLiteral(" data-label=\"organisation\"");

WriteLiteral(">\r\n");

            
            #line 76 "..\..\Views\Apprenticeship\Standard.cshtml"
                                        
            
            #line default
            #line hidden
            
            #line 76 "..\..\Views\Apprenticeship\Standard.cshtml"
                                         if (string.IsNullOrEmpty(organisation.Website))
                                        {
                                            
            
            #line default
            #line hidden
            
            #line 78 "..\..\Views\Apprenticeship\Standard.cshtml"
                                       Write(organisation.Name);

            
            #line default
            #line hidden
            
            #line 78 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                              
                                        }
                                        else
                                        {
                                            var linkProtocol = organisation.Website.StartsWith("http") ? string.Empty : "http://";

            
            #line default
            #line hidden
WriteLiteral("                                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4767), Tuple.Create("\"", 4808)
            
            #line 83 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 4774), Tuple.Create<System.Object, System.Int32>(linkProtocol
            
            #line default
            #line hidden
, 4774), false)
            
            #line 83 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 4787), Tuple.Create<System.Object, System.Int32>(organisation.Website
            
            #line default
            #line hidden
, 4787), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 83 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                                                                    Write(organisation.Name);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 84 "..\..\Views\Apprenticeship\Standard.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n                                    <t" +
"d");

WriteLiteral(" class=\"phone-number\"");

WriteLiteral(" data-label=\"phone-number\"");

WriteLiteral(">");

            
            #line 86 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                                                  Write(organisation.Phone);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                    <td");

WriteLiteral(" class=\"email\"");

WriteLiteral(" data-label=\"email\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 5124), Tuple.Create("\"", 5157)
, Tuple.Create(Tuple.Create("", 5131), Tuple.Create("mailto:", 5131), true)
            
            #line 87 "..\..\Views\Apprenticeship\Standard.cshtml"
         , Tuple.Create(Tuple.Create("", 5138), Tuple.Create<System.Object, System.Int32>(organisation.Email
            
            #line default
            #line hidden
, 5138), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 87 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                                                                                         Write(organisation.Email);

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n                                </tr>\r\n");

            
            #line 89 "..\..\Views\Apprenticeship\Standard.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                            </tbody>\r\n                        </table>\r\n         " +
"           </details>\r\n                </dd>\r\n");

            
            #line 94 "..\..\Views\Apprenticeship\Standard.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 96 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetMoreInformationProperty(Model.StandardPageUri));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dl>\r\n        \r\n\r\n        <div");

WriteLiteral(" id=\"bottom-actions\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" class=\"button btn-find-trng-prov\"");

WriteLiteral(" rel=\"nofollow\"");

WriteLiteral(" id=\"ga-find-provider-bottom\"");

WriteAttribute("href", Tuple.Create(" href=\"", 5637), Tuple.Create("\"", 5771)
            
            #line 101 "..\..\Views\Apprenticeship\Standard.cshtml"
                   , Tuple.Create(Tuple.Create("", 5644), Tuple.Create<System.Object, System.Int32>(Url.Action("SearchForStandardProviders", "Apprenticeship", new { standardId = Model.StandardId, keywords = Model.SearchTerm })
            
            #line default
            #line hidden
, 5644), false)
);

WriteLiteral(">\r\n                Find training providers who offer this apprenticeship\r\n       " +
"     </a>\r\n        </div>\r\n    </section>\r\n</main>\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
