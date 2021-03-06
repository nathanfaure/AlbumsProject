#pragma checksum "C:\Users\Nathan\Documents\Projets\AlbumsProject\AlbumsProject.Web\Views\Chat\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76f501cc1644ffdd6212702edfae66a572f687fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_Index), @"mvc.1.0.view", @"/Views/Chat/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chat/Index.cshtml", typeof(AspNetCore.Views_Chat_Index))]
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
#line 1 "C:\Users\Nathan\Documents\Projets\AlbumsProject\AlbumsProject.Web\Views\_ViewImports.cshtml"
using AlbumsProject.Web;

#line default
#line hidden
#line 2 "C:\Users\Nathan\Documents\Projets\AlbumsProject\AlbumsProject.Web\Views\_ViewImports.cshtml"
using AlbumsProject.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76f501cc1644ffdd6212702edfae66a572f687fc", @"/Views/Chat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa3f98bc0c4b128b6395561871c745378cbbf455", @"/Views/_ViewImports.cshtml")]
    public class Views_Chat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Nathan\Documents\Projets\AlbumsProject\AlbumsProject.Web\Views\Chat\Index.cshtml"
  
    ViewBag.Title = "Chat";

#line default
#line hidden
            BeginContext(108, 807, true);
            WriteLiteral(@"
<div class=""chat-container"">
    <h2>Chat</h2>
    <div class=""row"">
        <div class=""col-md-6 pull-left"">
            <section>
                <div class=""row"">
                    <div class=""form-group"">
                        <label class=""col-md-3 control-label"">Message : </label>
                        <div class=""col-md-9"">
                            <textarea id=""message"" class=""form-control""></textarea>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""form-group"">
                        <label class=""col-md-3 control-label"">Send to: </label>
                        <div class=""col-md-9"">
                            <div id=""users"">
                                ");
            EndContext();
            BeginContext(916, 202, false);
#line 24 "C:\Users\Nathan\Documents\Projets\AlbumsProject\AlbumsProject.Web\Views\Chat\Index.cshtml"
                           Write(Html.DropDownList("choose", new List<SelectListItem>() { new SelectListItem() { Text="User", Value= "User" }, new SelectListItem() { Text = "Group", Value = "Group" } }, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1118, 408, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""form-group"">
                        <label class=""col-md-3 control-label"">Users: </label>
                        <div class=""col-md-9"">
                            <div id=""users"">
                                ");
            EndContext();
            BeginContext(1527, 71, false);
#line 34 "C:\Users\Nathan\Documents\Projets\AlbumsProject\AlbumsProject.Web\Views\Chat\Index.cshtml"
                           Write(Html.DropDownList("user", Model.Item1, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1598, 409, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""form-group"">
                        <label class=""col-md-3 control-label"">Groups: </label>
                        <div class=""col-md-9"">
                            <div id=""users"">
                                ");
            EndContext();
            BeginContext(2008, 76, false);
#line 44 "C:\Users\Nathan\Documents\Projets\AlbumsProject\AlbumsProject.Web\Views\Chat\Index.cshtml"
                           Write(Html.DropDownList("chatGroup", Model.Item2, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2084, 882, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""form-group"">
                        <div class=""col-md-9"">
                            <input type=""button"" id=""sendmessage"" value=""Send"" class=""btn btn-default"" />
                        </div>
                    </div>
                </div>
            </section>
        </div>
        <div class=""col-md-6 pull-right"">
            <div class=""form-group"">
                <div class=""row"">
                    <label class=""col-md-2 control-label"">Messages: </label></div>
                    <div class=""row"">
                            <ul id=""discussion""></ul>                    
                    </div>
                </div>
        </div>
    </div>
</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
