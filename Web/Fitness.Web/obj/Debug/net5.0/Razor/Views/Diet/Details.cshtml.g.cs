#pragma checksum "D:\Desktop\ASP.Net-Core-Project\Web\Fitness.Web\Views\Diet\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc7072da439d71d08d087158e130057f08ddf84f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Diet_Details), @"mvc.1.0.view", @"/Views/Diet/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Desktop\ASP.Net-Core-Project\Web\Fitness.Web\Views\_ViewImports.cshtml"
using Fitness.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Desktop\ASP.Net-Core-Project\Web\Fitness.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Desktop\ASP.Net-Core-Project\Web\Fitness.Web\Views\_ViewImports.cshtml"
using Fitness.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc7072da439d71d08d087158e130057f08ddf84f", @"/Views/Diet/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6964fbbb389fc7498a12e97a49464751318f074f", @"/Views/_ViewImports.cshtml")]
    public class Views_Diet_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fitness.Web.ViewModels.Diet.DetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link btn btn-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-contact comment_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("commentForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Desktop\ASP.Net-Core-Project\Web\Fitness.Web\Views\Diet\Details.cshtml"
  
    this.ViewData["Title"] = "Diet Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "D:\Desktop\ASP.Net-Core-Project\Web\Fitness.Web\Views\Diet\Details.cshtml"
Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<br />\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-lg-8 posts-list\">\r\n        <div class=\"single-post\">\r\n            <h2 style=\"color: #2d2d2d;\">\r\n                ");
#nullable restore
#line 14 "D:\Desktop\ASP.Net-Core-Project\Web\Fitness.Web\Views\Diet\Details.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n            <ul class=\"blog-info-link mt-3 mb-4\">\r\n                <li><i class=\"fa fa-user\"></i>");
#nullable restore
#line 17 "D:\Desktop\ASP.Net-Core-Project\Web\Fitness.Web\Views\Diet\Details.cshtml"
                                         Write(Model.UserEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li><i class=\"fa fa-comments\"></i> 03 Comments</li>\r\n            </ul>\r\n            <p class=\"excert\">");
#nullable restore
#line 20 "D:\Desktop\ASP.Net-Core-Project\Web\Fitness.Web\Views\Diet\Details.cshtml"
                         Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc7072da439d71d08d087158e130057f08ddf84f7256", async() => {
                WriteLiteral("Edit diet");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc7072da439d71d08d087158e130057f08ddf84f8505", async() => {
                WriteLiteral("Delete diet");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>
<div class=""comments-area"">
    <h4>05 Comments</h4>
    <div class=""comment-list"">
        <div class=""single-comment justify-content-between d-flex"">
            <div class=""user justify-content-between d-flex"">
                <div class=""thumb"">
                    <img src=""https://bootdey.com/img/Content/avatar/avatar7.png""");
            BeginWriteAttribute("alt", " alt=\"", 1150, "\"", 1156, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
                <div class=""desc"">
                    <p class=""comment"">
                        Multiply sea night grass fourth day sea lesser rule open subdue female fill which them
                        Blessed, give fill lesser bearing multiply sea night grass fourth day sea lesser
                    </p>
                    <div class=""d-flex justify-content-between"">
                        <div class=""d-flex align-items-center"">
                            <h5>
                                <a href=""#"">Emilly Blunt</a>
                            </h5>
                            <p class=""date"">December 4, 2017 at 3:12 pm </p>
                        </div>
                        <div class=""reply-btn"">
                            <a href=""#"" class=""btn-reply text-uppercase"">reply</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""comment-list"">
       ");
            WriteLiteral(" <div class=\"single-comment justify-content-between d-flex\">\r\n            <div class=\"user justify-content-between d-flex\">\r\n                <div class=\"thumb\">\r\n                    <img src=\"assets/img/comment/comment_2.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2406, "\"", 2412, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
                <div class=""desc"">
                    <p class=""comment"">
                        Multiply sea night grass fourth day sea lesser rule open subdue female fill which them
                        Blessed, give fill lesser bearing multiply sea night grass fourth day sea lesser
                    </p>
                    <div class=""d-flex justify-content-between"">
                        <div class=""d-flex align-items-center"">
                            <h5>
                                <a href=""#"">Emilly Blunt</a>
                            </h5>
                            <p class=""date"">December 4, 2017 at 3:12 pm </p>
                        </div>
                        <div class=""reply-btn"">
                            <a href=""#"" class=""btn-reply text-uppercase"">reply</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""comment-list"">
       ");
            WriteLiteral(" <div class=\"single-comment justify-content-between d-flex\">\r\n            <div class=\"user justify-content-between d-flex\">\r\n                <div class=\"thumb\">\r\n                    <img src=\"assets/img/comment/comment_3.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3662, "\"", 3668, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
                <div class=""desc"">
                    <p class=""comment"">
                        Multiply sea night grass fourth day sea lesser rule open subdue female fill which them
                        Blessed, give fill lesser bearing multiply sea night grass fourth day sea lesser
                    </p>
                    <div class=""d-flex justify-content-between"">
                        <div class=""d-flex align-items-center"">
                            <h5>
                                <a href=""#"">Emilly Blunt</a>
                            </h5>
                            <p class=""date"">December 4, 2017 at 3:12 pm </p>
                        </div>
                        <div class=""reply-btn"">
                            <a href=""#"" class=""btn-reply text-uppercase"">reply</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""comment-form"">
   ");
            WriteLiteral(" <h4>Leave a Reply</h4>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc7072da439d71d08d087158e130057f08ddf84f14267", async() => {
                WriteLiteral(@"
        <div class=""row"">
            <div class=""col-12"">
                <div class=""form-group"">
                    <textarea class=""form-control w-100"" name=""comment"" id=""comment"" cols=""30"" rows=""9""
                              placeholder=""Write Comment""></textarea>
                </div>
            </div>
            <div class=""col-sm-6"">
                <div class=""form-group"">
                    <input class=""form-control"" name=""name"" id=""name"" type=""text"" placeholder=""Name"">
                </div>
            </div>
            <div class=""col-sm-6"">
                <div class=""form-group"">
                    <input class=""form-control"" name=""email"" id=""email"" type=""email"" placeholder=""Email"">
                </div>
            </div>
            <div class=""col-12"">
                <div class=""form-group"">
                    <input class=""form-control"" name=""website"" id=""website"" type=""text"" placeholder=""Website"">
                </div>
            </div>
        </div");
                WriteLiteral(">\r\n        <div class=\"form-group\">\r\n            <button type=\"submit\" class=\"button button-contactForm btn_1 boxed-btn\">Post Comment</button>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fitness.Web.ViewModels.Diet.DetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591