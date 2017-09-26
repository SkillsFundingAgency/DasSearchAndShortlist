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

#line 145 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetStandardProperty(string title, string id, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 146 "..\..\Views\Apprenticeship\Standard.cshtml"
 
    if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>");


#line 149 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 7741), Tuple.Create("\"", 7749)

#line 150 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 7746), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 7746), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 150 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, Html.MarkdownToHtml(item));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 151 "..\..\Views\Apprenticeship\Standard.cshtml"
    }


#line default
#line hidden
});

#line 152 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

#line 154 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetDurationProperty(string title, string id, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 155 "..\..\Views\Apprenticeship\Standard.cshtml"
 
    if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>");


#line 158 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 7989), Tuple.Create("\"", 7997)

#line 159 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 7994), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 7994), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 159 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, item);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " months</dd>\r\n");


#line 160 "..\..\Views\Apprenticeship\Standard.cshtml"
    }


#line default
#line hidden
});

#line 161 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

#line 163 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetFundingBandProperty(int value)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 164 "..\..\Views\Apprenticeship\Standard.cshtml"
 
    var fundingCapFormatted = value.ToString("C0", new CultureInfo("en-GB"));



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <dt>Current funding band</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dd");

WriteLiteralTo(__razor_helper_writer, " id=\"funding-cap\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        Up to ");


#line 169 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, fundingCapFormatted);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " per apprentice.<br />\r\n        <a");

WriteLiteralTo(__razor_helper_writer, " href=\"https://www.gov.uk/guidance/employing-an-apprentice-technical-guide-for-em" +
"ployers#funding-for-your-apprenticeship\"");

WriteLiteralTo(__razor_helper_writer, " target=\"_blank\"");

WriteLiteralTo(__razor_helper_writer, ">More information about funding</a>\r\n    </dd>\r\n");


#line 172 "..\..\Views\Apprenticeship\Standard.cshtml"


#line default
#line hidden
});

#line 172 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

#line 174 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetDocumentItem(string pdfUrl, string title)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 175 "..\..\Views\Apprenticeship\Standard.cshtml"
 
    if (!string.IsNullOrEmpty(title))
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <li>\r\n            <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 8608), Tuple.Create("\"", 8622)

#line 179 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 8615), Tuple.Create<System.Object, System.Int32>(pdfUrl

#line default
#line hidden
, 8615), false)
);

WriteLiteralTo(__razor_helper_writer, " target=\"_blank\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 180 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n            </a>\r\n        </li>\r\n");


#line 183 "..\..\Views\Apprenticeship\Standard.cshtml"
    }


#line default
#line hidden
});

#line 184 "..\..\Views\Apprenticeship\Standard.cshtml"
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

            
            #line default
            #line hidden
WriteLiteral("\r\n<main");

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

            
            #line 14 "..\..\Views\Apprenticeship\Standard.cshtml"
               Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </h1>\r\n                <p");

WriteLiteral(" class=\"lede\"");

WriteLiteral(">");

            
            #line 16 "..\..\Views\Apprenticeship\Standard.cshtml"
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

WriteAttribute("href", Tuple.Create(" href=\"", 842), Tuple.Create("\"", 976)
            
            #line 22 "..\..\Views\Apprenticeship\Standard.cshtml"
                                 , Tuple.Create(Tuple.Create("", 849), Tuple.Create<System.Object, System.Int32>(Url.Action("SearchForStandardProviders", "Apprenticeship", new { standardId = Model.StandardId, keywords = Model.SearchTerm })
            
            #line default
            #line hidden
, 849), false)
);

WriteLiteral(">\r\n                        Find training providers\r\n                    </a>\r\n   " +
"             </aside>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <sect" +
"ion>\r\n        <header>\r\n            <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">\r\n                Summary of this apprenticeship standard\r\n            </h2>\r\n  " +
"      </header>\r\n        <dl");

WriteLiteral(" class=\"data-list\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 36 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetStandardProperty("Level", "level", $"{@Model.Level} (equivalent to {EquivalenceLevelService.GetApprenticeshipLevel(Model.Level.ToString())})"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 37 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetDurationProperty("Typical length", "length", Model.Duration.ToString()));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 38 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetFundingBandProperty(Model.MaxFunding));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 39 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetStandardProperty("Entry requirements", "entry-requirements", Model.EntryRequirements));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 40 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetStandardProperty("What apprentices will learn", "will-learn", Model.WhatApprenticesWillLearn));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 41 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetStandardProperty("Qualifications", "qualifications", Model.Qualifications));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 42 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetStandardProperty("Professional registration", "professional-registration", Model.ProfessionalRegistration, true));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <dt>Documents</dt>\r\n            <dd>\r\n                <div");

WriteLiteral(" class=\"panel-indent panel-indent-info document-list\"");

WriteLiteral(">\r\n                    <ul>\r\n");

WriteLiteral("                        ");

            
            #line 47 "..\..\Views\Apprenticeship\Standard.cshtml"
                   Write(GetDocumentItem(Model.StandardPdf, "Standard"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 48 "..\..\Views\Apprenticeship\Standard.cshtml"
                   Write(GetDocumentItem(Model.AssessmentPlanPdf, "Assessment Plan"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </ul>\r\n                </div>\r\n            </dd>\r\n      \r\n " +
"           <dt>End Point Assessment</dt>\r\n\r\n");

            
            #line 55 "..\..\Views\Apprenticeship\Standard.cshtml"
            
            
            #line default
            #line hidden
            
            #line 55 "..\..\Views\Apprenticeship\Standard.cshtml"
             if (Model.AssessmentOrganisations.Any())
            {

            
            #line default
            #line hidden
WriteLiteral("                <dd>\r\n                    <details>\r\n                        <sum" +
"mary>View a list of end point assessment organisations for this standard</summar" +
"y>\r\n                        <table");

WriteLiteral(" class=\"responsive\"");

WriteLiteral(">\r\n                            <thead>\r\n                            <tr>\r\n       " +
"                         <th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">Organisation</th>\r\n                                <th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">Phone Number</th>\r\n                                <th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">Email</th>\r\n                            </tr>\r\n                            </the" +
"ad>\r\n                            <tbody>\r\n");

            
            #line 69 "..\..\Views\Apprenticeship\Standard.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 69 "..\..\Views\Apprenticeship\Standard.cshtml"
                             foreach (var organisation in Model.AssessmentOrganisations)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <tr>\r\n                                    <td");

WriteLiteral(" class=\"\"");

WriteLiteral(" data-label=\"organisation\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 3401), Tuple.Create("\"", 3429)
            
            #line 72 "..\..\Views\Apprenticeship\Standard.cshtml"
    , Tuple.Create(Tuple.Create("", 3408), Tuple.Create<System.Object, System.Int32>(organisation.Website
            
            #line default
            #line hidden
, 3408), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 72 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                                                                                      Write(organisation.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n                                    <td");

WriteLiteral(" class=\"\"");

WriteLiteral(" data-label=\"phone-number\"");

WriteLiteral(">");

            
            #line 73 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                                      Write(organisation.Phone);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                    <td");

WriteLiteral(" class=\"\"");

WriteLiteral(" data-label=\"email\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 3647), Tuple.Create("\"", 3680)
, Tuple.Create(Tuple.Create("", 3654), Tuple.Create("mailto:", 3654), true)
            
            #line 74 "..\..\Views\Apprenticeship\Standard.cshtml"
    , Tuple.Create(Tuple.Create("", 3661), Tuple.Create<System.Object, System.Int32>(organisation.Email
            
            #line default
            #line hidden
, 3661), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 74 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                                                                                    Write(organisation.Email);

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n                                </tr>\r\n");

            
            #line 76 "..\..\Views\Apprenticeship\Standard.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                            </tbody>\r\n                        </table>\r\n         " +
"           </details>\r\n                </dd>\r\n");

            
            #line 81 "..\..\Views\Apprenticeship\Standard.cshtml"
            } 
            else
            {

            
            #line default
            #line hidden
WriteLiteral(@"                <dd>There are no end point assessment organisations for this standard yet. There is a monthly application process for organisations interested in delivering end-point assessment. New organisations are added regularly.<br/><br/>
                    If you have an urgent need to select an assessment organisation for this standard, please email <a");

WriteLiteral(" href=\"mailto:apprentice.assessment@education.gov.uk\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">apprentice.assessment@education.gov.uk</a> with details.\r\n                </dd>\r" +
"\n");

            
            #line 87 "..\..\Views\Apprenticeship\Standard.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("       \r\n        </dl>\r\n        <div");

WriteLiteral(" id=\"grid-row\"");

WriteLiteral("> \r\n            <div");

WriteLiteral(" class=\"column-full\"");

WriteLiteral(">\r\n                <p");

WriteLiteral(" style=\"font-weight: bold; position: relative; left: -15px; float:left;width:29%;" +
"\"");

WriteLiteral(">End Point Assessment </p>\r\n");

            
            #line 93 "..\..\Views\Apprenticeship\Standard.cshtml"
            
            
            #line default
            #line hidden
            
            #line 93 "..\..\Views\Apprenticeship\Standard.cshtml"
             if (Model.AssessmentOrganisations.Any())
            {

            
            #line default
            #line hidden
WriteLiteral("                <details");

WriteLiteral(" style=\"clear:none;\"");

WriteLiteral(">\r\n               \r\n                    <summary><span");

WriteLiteral(" class=\"summary\"");

WriteLiteral(" style=\"text-decoration:none\"");

WriteLiteral(">View a list of end point assessment organisations for this standard</span></summ" +
"ary>\r\n\r\n                    <table");

WriteLiteral(" class=\"responsive\"");

WriteLiteral(">\r\n                        <thead>\r\n                        <tr>\r\n               " +
"             <th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">Organisation</th>\r\n                            <th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">Phone Number</th>\r\n                            <th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">Email</th>\r\n                        </tr>\r\n                        </thead>\r\n   " +
"                     <tbody>\r\n");

            
            #line 108 "..\..\Views\Apprenticeship\Standard.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 108 "..\..\Views\Apprenticeship\Standard.cshtml"
                         foreach (var organisation in Model.AssessmentOrganisations)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <tr>\r\n                                <td");

WriteLiteral(" class=\"\"");

WriteLiteral(" data-label=\"organisation\"");

WriteLiteral(">\r\n");

            
            #line 112 "..\..\Views\Apprenticeship\Standard.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 112 "..\..\Views\Apprenticeship\Standard.cshtml"
                                     if (string.IsNullOrEmpty(organisation.Website))
                                    {
                                        
            
            #line default
            #line hidden
            
            #line 114 "..\..\Views\Apprenticeship\Standard.cshtml"
                                   Write(organisation.Name);

            
            #line default
            #line hidden
            
            #line 114 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                          
                                    }
                                    else
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5984), Tuple.Create("\"", 6012)
            
            #line 118 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 5991), Tuple.Create<System.Object, System.Int32>(organisation.Website
            
            #line default
            #line hidden
, 5991), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 118 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                                                   Write(organisation.Name);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 119 "..\..\Views\Apprenticeship\Standard.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </td>\r\n                                <td");

WriteLiteral(" class=\"\"");

WriteLiteral(" data-label=\"phone-number\"");

WriteLiteral(">");

            
            #line 121 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                                  Write(organisation.Phone);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                <td");

WriteLiteral(" class=\"\"");

WriteLiteral(" data-label=\"email\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 6295), Tuple.Create("\"", 6328)
, Tuple.Create(Tuple.Create("", 6302), Tuple.Create("mailto:", 6302), true)
            
            #line 122 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 6309), Tuple.Create<System.Object, System.Int32>(organisation.Email
            
            #line default
            #line hidden
, 6309), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 122 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                                                                                Write(organisation.Email);

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n                            </tr>\r\n");

            
            #line 124 "..\..\Views\Apprenticeship\Standard.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        </tbody>\r\n                    </table>\r\n\r\n               " +
" </details>\r\n");

            
            #line 129 "..\..\Views\Apprenticeship\Standard.cshtml"
            } 
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <p");

WriteLiteral(" style=\"float: right;width:71%\"");

WriteLiteral(@">There are no end point assessment organisations for this standard yet. There is a monthly application process for organisations interested in delivering end-point assessment. New organisations are added regularly.<br/><br/>
                    If you have an urgent need to select an assessment organisation for this standard, please email <a");

WriteLiteral(" href=\"mailto:apprentice.assessment@education.gov.uk\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">apprentice.assessment@education.gov.uk</a> with details.\r\n                </p>\r\n" +
"");

            
            #line 135 "..\..\Views\Apprenticeship\Standard.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" id=\"bottom-actions\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" class=\"button ui-find-training-providers\"");

WriteLiteral(" rel=\"nofollow\"");

WriteLiteral(" id=\"ga-find-provider-bottom\"");

WriteAttribute("href", Tuple.Create(" href=\"", 7310), Tuple.Create("\"", 7444)
            
            #line 139 "..\..\Views\Apprenticeship\Standard.cshtml"
                           , Tuple.Create(Tuple.Create("", 7317), Tuple.Create<System.Object, System.Int32>(Url.Action("SearchForStandardProviders", "Apprenticeship", new { standardId = Model.StandardId, keywords = Model.SearchTerm })
            
            #line default
            #line hidden
, 7317), false)
);

WriteLiteral(">\r\n                Find training providers\r\n            </a>\r\n        </div>\r\n   " +
" </section>\r\n</main>\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
