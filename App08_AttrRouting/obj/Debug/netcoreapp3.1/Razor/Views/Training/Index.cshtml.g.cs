#pragma checksum "D:\WorkSpace\BITM9_ASPNETCore\Projects\App08_AttrRouting\App08_AttrRouting\Views\Training\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fe16ff5aa5f1ee5c7e641281488be268fa02330"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Training_Index), @"mvc.1.0.view", @"/Views/Training/Index.cshtml")]
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
#line 1 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App08_AttrRouting\App08_AttrRouting\Views\_ViewImports.cshtml"
using App08_AttrRouting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App08_AttrRouting\App08_AttrRouting\Views\_ViewImports.cshtml"
using App08_AttrRouting.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fe16ff5aa5f1ee5c7e641281488be268fa02330", @"/Views/Training/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db754bc95097ebc835cfc6887eea78a8e9ea2fb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Training_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App08_AttrRouting\App08_AttrRouting\Views\Training\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"alert alert-info\">Index of Training</h1>\r\n\r\n");
#nullable restore
#line 8 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App08_AttrRouting\App08_AttrRouting\Views\Training\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 class=\"alert alert-success\">");
#nullable restore
#line 10 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App08_AttrRouting\App08_AttrRouting\Views\Training\Index.cshtml"
                               Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 11 "D:\WorkSpace\BITM9_ASPNETCore\Projects\App08_AttrRouting\App08_AttrRouting\Views\Training\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
