#pragma checksum "D:\Asp.net web applications\exploreCalifornia\exploreCalifornia\Views\Blog\CreateForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "336299803f6e95a8c0a4b8850f7489db0d0ed87f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_CreateForm), @"mvc.1.0.view", @"/Views/Blog/CreateForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"336299803f6e95a8c0a4b8850f7489db0d0ed87f", @"/Views/Blog/CreateForm.cshtml")]
    public class Views_Blog_CreateForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<exploreCalifornia.Models.Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Asp.net web applications\exploreCalifornia\exploreCalifornia\Views\Blog\CreateForm.cshtml"
   

    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create Blog Post</h1>\r\n\r\n<fieldset>\r\n\r\n");
#nullable restore
#line 12 "D:\Asp.net web applications\exploreCalifornia\exploreCalifornia\Views\Blog\CreateForm.cshtml"
     using (Html.BeginForm()) {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Asp.net web applications\exploreCalifornia\exploreCalifornia\Views\Blog\CreateForm.cshtml"
   Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
#nullable restore
#line 17 "D:\Asp.net web applications\exploreCalifornia\exploreCalifornia\Views\Blog\CreateForm.cshtml"
   Write(Html.LabelFor(x => x.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 19 "D:\Asp.net web applications\exploreCalifornia\exploreCalifornia\Views\Blog\CreateForm.cshtml"
   Write(Html.EditorFor(x => x.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        ");
#nullable restore
#line 22 "D:\Asp.net web applications\exploreCalifornia\exploreCalifornia\Views\Blog\CreateForm.cshtml"
   Write(Html.ValidationMessageFor(x => x.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
            WriteLiteral("    <p>\r\n        ");
#nullable restore
#line 26 "D:\Asp.net web applications\exploreCalifornia\exploreCalifornia\Views\Blog\CreateForm.cshtml"
   Write(Html.LabelFor(x => x.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 28 "D:\Asp.net web applications\exploreCalifornia\exploreCalifornia\Views\Blog\CreateForm.cshtml"
   Write(Html.TextAreaFor(x => x.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 30 "D:\Asp.net web applications\exploreCalifornia\exploreCalifornia\Views\Blog\CreateForm.cshtml"
   Write(Html.ValidationMessageFor(x => x.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
            WriteLiteral("    <p>\r\n        <button type=\"submit\">Create a post</button>\r\n    </p>\r\n");
#nullable restore
#line 36 "D:\Asp.net web applications\exploreCalifornia\exploreCalifornia\Views\Blog\CreateForm.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</fieldset>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<exploreCalifornia.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
