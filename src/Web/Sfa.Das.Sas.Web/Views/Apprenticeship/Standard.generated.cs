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
    
    #line 1 "..\..\Views\Apprenticeship\Standard.cshtml"
    using Sfa.Das.Sas.Resources;
    
    #line default
    #line hidden
    using Sfa.Das.Sas.Web;
    
    #line 2 "..\..\Views\Apprenticeship\Standard.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Apprenticeship\Standard.cshtml"
    using StructureMap.Query;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Apprenticeship/Standard.cshtml")]
    public partial class Standard : System.Web.Mvc.WebViewPage<Sfa.Das.Sas.Web.ViewModels.StandardViewModel>
    {

#line 77 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult CreateSearchForm(string cssClasses, string inputId, string searchBoxIdentifier)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 78 "..\..\Views\Apprenticeship\Standard.cshtml"
 
    using (Html.BeginForm("StandardResults", "Provider", FormMethod.Get, new { @class = $"postcode-form search-box {cssClasses}", @id = inputId }))
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <h2");

WriteLiteralTo(__razor_helper_writer, " class=\"heading-medium\"");

WriteLiteralTo(__razor_helper_writer, ">Find training providers for this apprenticeship</h2>\r\n");

WriteLiteralTo(__razor_helper_writer, "                <div");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 3333), Tuple.Create("\"", 3386)
, Tuple.Create(Tuple.Create("", 3341), Tuple.Create("form-group", 3341), true)

#line 82 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create(" ", 3351), Tuple.Create<System.Object, System.Int32>(@Model.HasError ? " error" : ""

#line default
#line hidden
, 3352), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n                    <label");

WriteLiteralTo(__razor_helper_writer, " class=\"form-label\"");

WriteAttributeTo(__razor_helper_writer, "for", Tuple.Create(" for=\"", 3435), Tuple.Create("\"", 3461)

#line 83 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 3441), Tuple.Create<System.Object, System.Int32>(searchBoxIdentifier

#line default
#line hidden
, 3441), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n                        Enter a full postcode.\r\n                        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"error-message\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                            This field can\'t be blank\r\n                       " +
" </span>\r\n                    </label>\r\n                    <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"apprenticeshipid\"");

WriteLiteralTo(__razor_helper_writer, " class=\"text-box form-control\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 3779), Tuple.Create("\"", 3804)

#line 89 "..\..\Views\Apprenticeship\Standard.cshtml"
                      , Tuple.Create(Tuple.Create("", 3787), Tuple.Create<System.Object, System.Int32>(Model.StandardId

#line default
#line hidden
, 3787), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n                    <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"Inputid\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 3863), Tuple.Create("\"", 3879)

#line 90 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 3871), Tuple.Create<System.Object, System.Int32>(inputId

#line default
#line hidden
, 3871), false)
);

WriteLiteralTo(__razor_helper_writer, "/>\r\n                    <input");

WriteLiteralTo(__razor_helper_writer, " type=\"search\"");

WriteLiteralTo(__razor_helper_writer, " name=\"PostCode\"");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 3940), Tuple.Create("\"", 3965)

#line 91 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 3945), Tuple.Create<System.Object, System.Int32>(searchBoxIdentifier

#line default
#line hidden
, 3945), false)
);

WriteLiteralTo(__razor_helper_writer, " class=\"text-box form-control postcode-search-box\"");

WriteLiteralTo(__razor_helper_writer, " maxlength=\"200\"");

WriteLiteralTo(__razor_helper_writer, " placeholder=\"\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                </div>\r\n");

WriteLiteralTo(__razor_helper_writer, "                <input");

WriteLiteralTo(__razor_helper_writer, " class=\"button margin-top-x2 postcode-search-button\"");

WriteLiteralTo(__razor_helper_writer, " type=\"submit\"");

WriteLiteralTo(__razor_helper_writer, " value=\"Search\"");

WriteLiteralTo(__razor_helper_writer, " />\r\n");


#line 94 "..\..\Views\Apprenticeship\Standard.cshtml"
    }
    

#line default
#line hidden

#line 95 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, GetShortlistLink(@Model.StandardId, @Model.IsShortlisted));


#line default
#line hidden

#line 95 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                              


#line default
#line hidden
});

#line 96 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

#line 98 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetStandardProperty(string title, string id, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 99 "..\..\Views\Apprenticeship\Standard.cshtml"
 
    if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>");


#line 102 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 4451), Tuple.Create("\"", 4459)

#line 103 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 4456), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 4456), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 103 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, Html.MarkdownToHtml(item));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 104 "..\..\Views\Apprenticeship\Standard.cshtml"
    }


#line default
#line hidden
});

#line 105 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

#line 107 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetDocumentItem(string pdfUrl, string title)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 108 "..\..\Views\Apprenticeship\Standard.cshtml"
 
    if (!string.IsNullOrEmpty(title))
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <li>\r\n            <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 4637), Tuple.Create("\"", 4651)

#line 112 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 4644), Tuple.Create<System.Object, System.Int32>(pdfUrl

#line default
#line hidden
, 4644), false)
);

WriteLiteralTo(__razor_helper_writer, " target=\"_blank\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 113 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n            </a>\r\n        </li>\r\n");


#line 116 "..\..\Views\Apprenticeship\Standard.cshtml"
    }


#line default
#line hidden
});

#line 117 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

#line 119 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetShortlistLink(int id, bool isShortlisted)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 120 "..\..\Views\Apprenticeship\Standard.cshtml"
 
    if (isShortlisted)
    {
        

#line default
#line hidden

#line 123 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink("Remove from shortlist", "RemoveStandard", "ShortList", new { id=@id }, new {@class="link", rel="nofollow"}));


#line default
#line hidden

#line 123 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                                                                                                     
    }
    else
    {
        

#line default
#line hidden

#line 127 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink("Shortlist apprenticeship", "AddStandard", "ShortList", new { id=@id }, new { @class = "link", rel="nofollow" }));


#line default
#line hidden

#line 127 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                                                                                                         
    }


#line default
#line hidden
});

#line 129 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

        public Standard()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..\Views\Apprenticeship\Standard.cshtml"
  
    ViewBag.Title = "Standard - " + @Model.Title;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" class=\"standard-detail\"");

WriteLiteral(">\r\n\r\n    <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 13 "..\..\Views\Apprenticeship\Standard.cshtml"
   Write(Html.RenderAIfExists(@Model.SearchResultLink?.Title, @Model.SearchResultLink?.Url, "link-back"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <div>\r\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 21 "..\..\Views\Apprenticeship\Standard.cshtml"
               Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </h1>\r\n                    <div");

WriteLiteral(" class=\"standard-result-summary\"");

WriteLiteral(@">
                        This is an apprenticeship standard developed by a group of employers. It sets out what the apprentice needs to achieve and how they will be assessed.
                    </div>
            </div>
        </div>


        <div");

WriteLiteral(" class=\"column-third\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"related-container\"");

WriteLiteral(">\r\n                <aside");

WriteLiteral(" class=\"related\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 33 "..\..\Views\Apprenticeship\Standard.cshtml"
               Write(CreateSearchForm("hidden-for-mobile", "postcode-form-aside", "search-box-aside"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </aside>\r\n                 </div>\r\n\r\n            </div>\r\n      " +
"  </div>\r\n\r\n        <section>\r\n            <header>\r\n                <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">\r\n                    Summary of this apprenticeship standard\r\n                <" +
"/h2>\r\n            </header>\r\n            <dl");

WriteLiteral(" class=\"data-list\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 47 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(GetStandardProperty("Overview of role", "overview", Model.OverviewOfRole));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 48 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(GetStandardProperty("Level", "level", $"{@Model.NotionalEndLevel} (equivalent to {@EquivalenveLevelService.GetApprenticeshipLevel(Model.NotionalEndLevel.ToString())})"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 49 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(GetStandardProperty("Typical length", "length", @Model.TypicalLengthMessage));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 50 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(GetStandardProperty("Entry requirements", "entry-requirements", Model.EntryRequirements));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 51 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(GetStandardProperty("What apprentices will learn", "will-learn", Model.WhatApprenticesWillLearn));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 52 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(GetStandardProperty("Qualifications", "qualifications", Model.Qualifications));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 53 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(GetStandardProperty("Professional registration", "professional-registration", Model.ProfessionalRegistration, true));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dl>\r\n\r\n");

            
            #line 56 "..\..\Views\Apprenticeship\Standard.cshtml"
            
            
            #line default
            #line hidden
            
            #line 56 "..\..\Views\Apprenticeship\Standard.cshtml"
             if (!string.IsNullOrEmpty($"{Model.AssessmentPlanPdfUrlTitle}{Model.StandardPdfUrlTitle}"))
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"panel-indent panel-indent-info\"");

WriteLiteral(">\r\n                    <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">\r\n                        Documents\r\n                    </h2>\r\n                " +
"    <ul>\r\n");

WriteLiteral("                        ");

            
            #line 63 "..\..\Views\Apprenticeship\Standard.cshtml"
                   Write(GetDocumentItem(@Model.StandardPdf, "Standard"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 64 "..\..\Views\Apprenticeship\Standard.cshtml"
                   Write(GetDocumentItem(@Model.AssessmentPlanPdf, "Assessment Plan"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </ul>\r\n                </div>\r\n");

            
            #line 67 "..\..\Views\Apprenticeship\Standard.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n            <hr />\r\n\r\n");

WriteLiteral("            ");

            
            #line 71 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(CreateSearchForm("", "postcode-form-bottom", "search-box-bottom"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        </section>\r\n\r\n</main>\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
