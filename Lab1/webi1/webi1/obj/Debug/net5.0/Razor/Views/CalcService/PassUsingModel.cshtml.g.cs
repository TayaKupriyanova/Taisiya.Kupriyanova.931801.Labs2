#pragma checksum "C:\Users\Denis\Desktop\webi1\webi1\Views\CalcService\PassUsingModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "130e51c5597d5d58cbabb4f8b1a6eb5bcf963182"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CalcService_PassUsingModel), @"mvc.1.0.view", @"/Views/CalcService/PassUsingModel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"130e51c5597d5d58cbabb4f8b1a6eb5bcf963182", @"/Views/CalcService/PassUsingModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_CalcService_PassUsingModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<lab1.Models.CalcModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Denis\Desktop\webi1\webi1\Views\CalcService\PassUsingModel.cshtml"
  
    ViewBag.Title = "PassUsingModel - Backend1";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>PassUsingModel</h1>\n<b>Rand value first:</b> ");
#nullable restore
#line 6 "C:\Users\Denis\Desktop\webi1\webi1\Views\CalcService\PassUsingModel.cshtml"
                    Write(Model.X);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n<b>Rand value second:</b> ");
#nullable restore
#line 7 "C:\Users\Denis\Desktop\webi1\webi1\Views\CalcService\PassUsingModel.cshtml"
                     Write(Model.Y);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n\n<b>Add:</b><br />\n");
#nullable restore
#line 10 "C:\Users\Denis\Desktop\webi1\webi1\Views\CalcService\PassUsingModel.cshtml"
Write(Model.Sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n\n<b>Dif:</b><br />\n");
#nullable restore
#line 13 "C:\Users\Denis\Desktop\webi1\webi1\Views\CalcService\PassUsingModel.cshtml"
Write(Model.Dif);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n\n<b>Mult:</b><br />\n");
#nullable restore
#line 16 "C:\Users\Denis\Desktop\webi1\webi1\Views\CalcService\PassUsingModel.cshtml"
Write(Model.Mult);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n\n<b>Div:</b><br />\n");
#nullable restore
#line 19 "C:\Users\Denis\Desktop\webi1\webi1\Views\CalcService\PassUsingModel.cshtml"
Write(Model.Div);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<lab1.Models.CalcModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
