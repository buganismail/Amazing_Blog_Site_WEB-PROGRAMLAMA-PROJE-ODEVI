#pragma checksum "C:\Users\user-PC\Downloads\g201210304\g201210304\Blog\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d65ec3628d774b1331c62594fd5d3e46de88217"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
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
#line 1 "C:\Users\user-PC\Downloads\g201210304\g201210304\Blog\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user-PC\Downloads\g201210304\g201210304\Blog\Views\_ViewImports.cshtml"
using Blog.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d65ec3628d774b1331c62594fd5d3e46de88217", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f4e97fb14d0dcd1463699284d14324e9e810018", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("<div class=\"container\">\n    <h2>");
#nullable restore
#line 7 "C:\Users\user-PC\Downloads\g201210304\g201210304\Blog\Views\Home\Post.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n    <p>");
#nullable restore
#line 8 "C:\Users\user-PC\Downloads\g201210304\g201210304\Blog\Views\Home\Post.cshtml"
  Write(Model.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <div class=\"post no-shadow\">\n");
#nullable restore
#line 10 "C:\Users\user-PC\Downloads\g201210304\g201210304\Blog\Views\Home\Post.cshtml"
         if (!string.IsNullOrEmpty(Model.Image))
        {
            var image_path = $"/Image/{Model.Image}";

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img");
            BeginWriteAttribute("src", " src=\"", 254, "\"", 271, 1);
#nullable restore
#line 13 "C:\Users\user-PC\Downloads\g201210304\g201210304\Blog\Views\Home\Post.cshtml"
WriteAttributeValue("", 260, image_path, 260, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"500\"/>\n            <span class=\"title\">");
#nullable restore
#line 14 "C:\Users\user-PC\Downloads\g201210304\g201210304\Blog\Views\Home\Post.cshtml"
                           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 15 "C:\Users\user-PC\Downloads\g201210304\g201210304\Blog\Views\Home\Post.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n    <div class=\"post-body\">\n        ");
#nullable restore
#line 18 "C:\Users\user-PC\Downloads\g201210304\g201210304\Blog\Views\Home\Post.cshtml"
   Write(Model.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
