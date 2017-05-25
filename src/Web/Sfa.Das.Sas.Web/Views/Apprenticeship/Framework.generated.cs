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
    
    #line 1 "..\..\Views\Apprenticeship\Framework.cshtml"
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
    
    #line 2 "..\..\Views\Apprenticeship\Framework.cshtml"
    using Sfa.Das.Sas.Resources;
    
    #line default
    #line hidden
    using Sfa.Das.Sas.Web;
    
    #line 3 "..\..\Views\Apprenticeship\Framework.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Apprenticeship/Framework.cshtml")]
    public partial class Framework : System.Web.Mvc.WebViewPage<Sfa.Das.Sas.Web.ViewModels.FrameworkViewModel>
    {

#line 186 "..\..\Views\Apprenticeship\Framework.cshtml"
public System.Web.WebPages.HelperResult GetStandardProperty(string title, string id, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 187 "..\..\Views\Apprenticeship\Framework.cshtml"
 
    if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>");


#line 190 "..\..\Views\Apprenticeship\Framework.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 8673), Tuple.Create("\"", 8681)

#line 191 "..\..\Views\Apprenticeship\Framework.cshtml"
, Tuple.Create(Tuple.Create("", 8678), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 8678), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 191 "..\..\Views\Apprenticeship\Framework.cshtml"
WriteTo(__razor_helper_writer, item);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 192 "..\..\Views\Apprenticeship\Framework.cshtml"
    }


#line default
#line hidden
});

#line 193 "..\..\Views\Apprenticeship\Framework.cshtml"
}
#line default
#line hidden

#line 195 "..\..\Views\Apprenticeship\Framework.cshtml"
public System.Web.WebPages.HelperResult GetDurationProperty(string title, string id, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 196 "..\..\Views\Apprenticeship\Framework.cshtml"
 
    if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>");


#line 199 "..\..\Views\Apprenticeship\Framework.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 8900), Tuple.Create("\"", 8908)

#line 200 "..\..\Views\Apprenticeship\Framework.cshtml"
, Tuple.Create(Tuple.Create("", 8905), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 8905), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 200 "..\..\Views\Apprenticeship\Framework.cshtml"
WriteTo(__razor_helper_writer, item);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " months</dd>\r\n");


#line 201 "..\..\Views\Apprenticeship\Framework.cshtml"
    }


#line default
#line hidden
});

#line 202 "..\..\Views\Apprenticeship\Framework.cshtml"
}
#line default
#line hidden

#line 204 "..\..\Views\Apprenticeship\Framework.cshtml"
public System.Web.WebPages.HelperResult GetFundingBandProperty(int value)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 205 "..\..\Views\Apprenticeship\Framework.cshtml"
 
    var fundingCapFormatted = value.ToString("C0", new CultureInfo("en-GB"));



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <dt>Funding cap<br />(from 1 May 2017)</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dd");

WriteLiteralTo(__razor_helper_writer, " id=\"funding-cap\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        Up to ");


#line 210 "..\..\Views\Apprenticeship\Framework.cshtml"
WriteTo(__razor_helper_writer, fundingCapFormatted);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " per apprentice.<br />\r\n        <a");

WriteLiteralTo(__razor_helper_writer, " href=\"https://www.gov.uk/government/publications/apprenticeship-levy-how-it-will" +
"-work/apprenticeship-levy-how-it-will-work\"");

WriteLiteralTo(__razor_helper_writer, " target=\"_blank\"");

WriteLiteralTo(__razor_helper_writer, ">More information about funding</a>\r\n    </dd>\r\n");


#line 213 "..\..\Views\Apprenticeship\Framework.cshtml"


#line default
#line hidden
});

#line 213 "..\..\Views\Apprenticeship\Framework.cshtml"
}
#line default
#line hidden

        public Framework()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..\Views\Apprenticeship\Framework.cshtml"
  
    ViewBag.Title = @Model.Title + " - Apprenticeship Framework";
    ViewBag.Description = "The Find Apprenticeship Training service is for employers in England who want to find training courses for their apprentices and search for training providers.";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 15 "..\..\Views\Apprenticeship\Framework.cshtml"
           Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </h1>\r\n            <p>\r\n                This information is taken f" +
"rom an apprenticeship framework. It sets out what qualifications the apprentice " +
"can achieve.\r\n            </p>\r\n");

            
            #line 20 "..\..\Views\Apprenticeship\Framework.cshtml"
            
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Apprenticeship\Framework.cshtml"
             if (Model.ExpiryDateString != null)
            {


            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"notice\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"icon icon-important\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"visuallyhidden\"");

WriteLiteral(">Warning</span>\r\n                    </i>\r\n                    <strong");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">\r\n                        This apprenticeship is closed to new starters from ");

            
            #line 28 "..\..\Views\Apprenticeship\Framework.cshtml"
                                                                      Write(Model.ExpiryDateString);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </strong>\r\n                </div>\r\n");

            
            #line 31 "..\..\Views\Apprenticeship\Framework.cshtml"

            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"column-third\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"related-container\"");

WriteLiteral(">\r\n                <aside");

WriteLiteral(" class=\"hidden-for-mobile-tablet\"");

WriteLiteral(">\r\n\r\n                    <a");

WriteLiteral(" class=\"button ui-find-training-providers\"");

WriteLiteral(" rel=\"nofollow\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1480), Tuple.Create("\"", 1615)
            
            #line 39 "..\..\Views\Apprenticeship\Framework.cshtml"
      , Tuple.Create(Tuple.Create("", 1487), Tuple.Create<System.Object, System.Int32>(Url.Action("SearchForFrameworkProviders", "Apprenticeship", new {frameworkId = Model.FrameworkId, keywords = Model.SearchTerm})
            
            #line default
            #line hidden
, 1487), false)
);

WriteLiteral(">\r\n                        Find training providers\r\n                    </a>\r\n   " +
"             </aside>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n    <" +
"section>\r\n        <header>\r\n            <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">\r\n                Summary of this apprenticeship framework\r\n            </h2>\r\n " +
"       </header>\r\n\r\n        <dl");

WriteLiteral(" class=\"data-list\"");

WriteLiteral(">\r\n");

            
            #line 56 "..\..\Views\Apprenticeship\Framework.cshtml"
            
            
            #line default
            #line hidden
            
            #line 56 "..\..\Views\Apprenticeship\Framework.cshtml"
             if (!string.IsNullOrEmpty(Model.FrameworkOverview))
            {

            
            #line default
            #line hidden
WriteLiteral("                <dt");

WriteLiteral(" class=\"overviewTitle\"");

WriteLiteral(">Overview of role</dt>\r\n");

WriteLiteral("                <dd");

WriteLiteral(" class=\"overviewText\"");

WriteLiteral(">");

            
            #line 59 "..\..\Views\Apprenticeship\Framework.cshtml"
                                    Write(Model.FrameworkOverview);

            
            #line default
            #line hidden
WriteLiteral(" </dd>\r\n");

            
            #line 60 "..\..\Views\Apprenticeship\Framework.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 61 "..\..\Views\Apprenticeship\Framework.cshtml"
       Write(GetStandardProperty("Level", "level", $"{Model.Level} (equivalent to {EquivalenceLevelService.GetApprenticeshipLevel(Model.Level.ToString())})"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 62 "..\..\Views\Apprenticeship\Framework.cshtml"
       Write(GetDurationProperty("Typical length", "length", Model.Duration.ToString()));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 63 "..\..\Views\Apprenticeship\Framework.cshtml"
       Write(GetFundingBandProperty(Model.MaxFunding));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <dt>Entry requirements</dt>\r\n            <dd");

WriteLiteral(" class=\"entry-requirements\"");

WriteLiteral(">\r\n");

            
            #line 66 "..\..\Views\Apprenticeship\Framework.cshtml"
                
            
            #line default
            #line hidden
            
            #line 66 "..\..\Views\Apprenticeship\Framework.cshtml"
                 if (!string.IsNullOrEmpty(Model.EntryRequirements))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div>");

            
            #line 68 "..\..\Views\Apprenticeship\Framework.cshtml"
                    Write(Model.EntryRequirements);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 69 "..\..\Views\Apprenticeship\Framework.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <div>Your chosen training provider can advise you about entry req" +
"uirements for apprentices.</div>\r\n            </dd>\r\n\r\n            <dt>Suitable " +
"roles for apprentices</dt>\r\n            <dd");

WriteLiteral(" class=\"job-roles\"");

WriteLiteral(">\r\n");

            
            #line 75 "..\..\Views\Apprenticeship\Framework.cshtml"
                
            
            #line default
            #line hidden
            
            #line 75 "..\..\Views\Apprenticeship\Framework.cshtml"
                 if (Model.JobRoles != null && Model.JobRoles.Any())
                {

            
            #line default
            #line hidden
WriteLiteral("                    <ul>\r\n");

            
            #line 78 "..\..\Views\Apprenticeship\Framework.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 78 "..\..\Views\Apprenticeship\Framework.cshtml"
                         foreach (var jobRole in Model.JobRoles.Take(5))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>");

            
            #line 80 "..\..\Views\Apprenticeship\Framework.cshtml"
                           Write(jobRole);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 81 "..\..\Views\Apprenticeship\Framework.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        ");

            
            #line 82 "..\..\Views\Apprenticeship\Framework.cshtml"
                         if (Model.JobRoles.Count() > 5)
                        {
                            foreach (var jobRole in Model.JobRoles.Skip(5))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li");

WriteLiteral(" class=\"default-hidden\"");

WriteLiteral(">");

            
            #line 86 "..\..\Views\Apprenticeship\Framework.cshtml"
                                                      Write(jobRole);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 87 "..\..\Views\Apprenticeship\Framework.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"showmore hidden\"");

WriteLiteral(">Show more</a>\r\n");

            
            #line 89 "..\..\Views\Apprenticeship\Framework.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </ul>\r\n");

            
            #line 91 "..\..\Views\Apprenticeship\Framework.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral(@"
                <div>
                    Your chosen training provider can advise you about the kinds of skills apprentices will learn.
                </div>
            </dd>
            <dt>Qualifications</dt>
            <dd>
                <div");

WriteLiteral(" class=\"qualifications\"");

WriteLiteral(">\r\n");

            
            #line 100 "..\..\Views\Apprenticeship\Framework.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 100 "..\..\Views\Apprenticeship\Framework.cshtml"
                     if (Model.CompetencyQualification != null && Model.CompetencyQualification.Any())
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"competencyQualifications\"");

WriteLiteral(">\r\n                            <p>Apprentices will achieve a practical (or \'compe" +
"tence\') qualification:</p>\r\n                            <ul>\r\n");

            
            #line 105 "..\..\Views\Apprenticeship\Framework.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 105 "..\..\Views\Apprenticeship\Framework.cshtml"
                                 foreach (var qualification in Model.CompetencyQualification.Take(3))
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <li>");

            
            #line 107 "..\..\Views\Apprenticeship\Framework.cshtml"
                                   Write(qualification);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 108 "..\..\Views\Apprenticeship\Framework.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 110 "..\..\Views\Apprenticeship\Framework.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 110 "..\..\Views\Apprenticeship\Framework.cshtml"
                                 if (Model.CompetencyQualification.Count() > 3)
                                {
                                    foreach (var qualification in Model.CompetencyQualification.Skip(3))
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <li");

WriteLiteral(" class=\"default-hidden\"");

WriteLiteral(">");

            
            #line 114 "..\..\Views\Apprenticeship\Framework.cshtml"
                                                              Write(qualification);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 115 "..\..\Views\Apprenticeship\Framework.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"showmore hidden\"");

WriteLiteral(">Show more</a>\r\n");

            
            #line 117 "..\..\Views\Apprenticeship\Framework.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </ul>\r\n                        </div>\r\n");

            
            #line 120 "..\..\Views\Apprenticeship\Framework.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 122 "..\..\Views\Apprenticeship\Framework.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 122 "..\..\Views\Apprenticeship\Framework.cshtml"
                     if (Model.KnowledgeQualification != null && Model.KnowledgeQualification.Any())
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"knowledgeQualifications\"");

WriteLiteral(">\r\n                            <p>Apprentices will also achieve a theory-based (o" +
"r \'knowledge\') qualification:</p>\r\n                            <ul>\r\n");

            
            #line 127 "..\..\Views\Apprenticeship\Framework.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 127 "..\..\Views\Apprenticeship\Framework.cshtml"
                                 foreach (var qualification in Model.KnowledgeQualification.Take(3))
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <li>");

            
            #line 129 "..\..\Views\Apprenticeship\Framework.cshtml"
                                   Write(qualification);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 130 "..\..\Views\Apprenticeship\Framework.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 132 "..\..\Views\Apprenticeship\Framework.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 132 "..\..\Views\Apprenticeship\Framework.cshtml"
                                 if (Model.KnowledgeQualification.Count() > 3)
                                {
                                    foreach (var qualification in Model.KnowledgeQualification.Skip(3))
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <li");

WriteLiteral(" class=\"default-hidden\"");

WriteLiteral(">");

            
            #line 136 "..\..\Views\Apprenticeship\Framework.cshtml"
                                                              Write(qualification);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 137 "..\..\Views\Apprenticeship\Framework.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"showmore hidden\"");

WriteLiteral(">Show more</a>\r\n");

            
            #line 139 "..\..\Views\Apprenticeship\Framework.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </ul>\r\n                        </div>\r\n");

            
            #line 142 "..\..\Views\Apprenticeship\Framework.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 144 "..\..\Views\Apprenticeship\Framework.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 144 "..\..\Views\Apprenticeship\Framework.cshtml"
                     if (Model.CombinedQualificiation != null && Model.CombinedQualificiation.Any())
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"combinedQualification\"");

WriteLiteral(">\r\n                            <p>Apprentices will achieve a practical and theory" +
"-based (or \'combined\') qualification:</p>\r\n                            <ul>\r\n");

            
            #line 149 "..\..\Views\Apprenticeship\Framework.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 149 "..\..\Views\Apprenticeship\Framework.cshtml"
                                 foreach (var qualification in Model.CombinedQualificiation.Take(3))
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <li>");

            
            #line 151 "..\..\Views\Apprenticeship\Framework.cshtml"
                                   Write(qualification);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 152 "..\..\Views\Apprenticeship\Framework.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 154 "..\..\Views\Apprenticeship\Framework.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 154 "..\..\Views\Apprenticeship\Framework.cshtml"
                                 if (Model.CombinedQualificiation.Count() > 3)
                                {
                                    foreach (var qualification in Model.CombinedQualificiation.Skip(3))
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <li");

WriteLiteral(" class=\"default-hidden\"");

WriteLiteral(">");

            
            #line 158 "..\..\Views\Apprenticeship\Framework.cshtml"
                                                              Write(qualification);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 159 "..\..\Views\Apprenticeship\Framework.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"showmore hidden\"");

WriteLiteral(">Show more</a>\r\n");

            
            #line 161 "..\..\Views\Apprenticeship\Framework.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </ul>\r\n                        </div>\r\n");

            
            #line 164 "..\..\Views\Apprenticeship\Framework.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n\r\n");

            
            #line 167 "..\..\Views\Apprenticeship\Framework.cshtml"
                
            
            #line default
            #line hidden
            
            #line 167 "..\..\Views\Apprenticeship\Framework.cshtml"
                 if (Model.CompletionQualifications != string.Empty)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <p");

WriteLiteral(" class=\"completionQualifications\"");

WriteLiteral(">");

            
            #line 169 "..\..\Views\Apprenticeship\Framework.cshtml"
                                                   Write(Model.CompletionQualifications);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 170 "..\..\Views\Apprenticeship\Framework.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <p");

WriteLiteral(" class=\"qualificationsStatic\"");

WriteLiteral(">Your chosen training provider can advise you about the qualifications open to ap" +
"prentices as they can change depending on individual and other circumstances.</p" +
">\r\n            </dd>\r\n\r\n            <dt>Professional registration</dt>\r\n        " +
"    <dd>");

            
            #line 175 "..\..\Views\Apprenticeship\Framework.cshtml"
           Write(Model.ProfessionalRegistration);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n        </dl>\r\n\r\n        <div");

WriteLiteral(" id=\"bottom-actions\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" class=\"button ui-find-training-providers\"");

WriteLiteral(" rel=\"nofollow\"");

WriteLiteral(" id=\"ga-find-provider-bottom\"");

WriteAttribute("href", Tuple.Create(" href=\"", 8239), Tuple.Create("\"", 8374)
            
            #line 179 "..\..\Views\Apprenticeship\Framework.cshtml"
                           , Tuple.Create(Tuple.Create("", 8246), Tuple.Create<System.Object, System.Int32>(Url.Action("SearchForFrameworkProviders", "Apprenticeship", new {frameworkId = Model.FrameworkId, keywords = Model.SearchTerm})
            
            #line default
            #line hidden
, 8246), false)
);

WriteLiteral(">\r\n                Find training providers\r\n            </a>\r\n        </div>\r\n   " +
" </section>\r\n</main>\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
