#pragma checksum "C:\Users\kelly\OneDrive\Desktop\Claires_Salon.Solution\Claires_Salon\Views\Clients\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa98007d3c8f08538f563fd3d24fc6b8f9904964"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Delete), @"mvc.1.0.view", @"/Views/Clients/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa98007d3c8f08538f563fd3d24fc6b8f9904964", @"/Views/Clients/Delete.cshtml")]
    public class Views_Clients_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Claires_Salon.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\kelly\OneDrive\Desktop\Claires_Salon.Solution\Claires_Salon\Views\Clients\Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Are you sure you want to delete this?</h2>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\kelly\OneDrive\Desktop\Claires_Salon.Solution\Claires_Salon\Views\Clients\Delete.cshtml"
Write(Html.DisplayNameFor(model => model.ClientName));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 10 "C:\Users\kelly\OneDrive\Desktop\Claires_Salon.Solution\Claires_Salon\Views\Clients\Delete.cshtml"
                                            Write(Html.DisplayFor(model => model.ClientName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\kelly\OneDrive\Desktop\Claires_Salon.Solution\Claires_Salon\Views\Clients\Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Delete\" />\r\n");
#nullable restore
#line 14 "C:\Users\kelly\OneDrive\Desktop\Claires_Salon.Solution\Claires_Salon\Views\Clients\Delete.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\kelly\OneDrive\Desktop\Claires_Salon.Solution\Claires_Salon\Views\Clients\Delete.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Claires_Salon.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
