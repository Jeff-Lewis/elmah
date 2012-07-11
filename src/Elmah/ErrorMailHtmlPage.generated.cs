﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elmah
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 2 "..\..\ErrorMailHtmlPage.cshtml"
    using System.Web;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ErrorMailHtmlPage.cshtml"
    using Elmah;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.3.2.0")]
    internal partial class ErrorMailHtmlPage : RazorTemplateBase
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");





            
            #line 5 "..\..\ErrorMailHtmlPage.cshtml"
  
    // NB cast is not really required, but aids with intellisense!
    var error = (Error) this.Error;

    var about = PoweredBy.GetAbout(HttpRuntime.Cache, (version, fileVersion, product, copyright) => new
    {
        Version = version != null
                ? version.ToString()
                : fileVersion != null
                ? fileVersion.ToString()
                : "?.?.?.?",
        Product = Mask.EmptyString(product, "(product)"),
        Copyright = copyright,
    });


            
            #line default
            #line hidden
WriteLiteral("<html>\r\n    <head>\r\n        <title>Error: ");


            
            #line 22 "..\..\ErrorMailHtmlPage.cshtml"
                 Write(error.Message);

            
            #line default
            #line hidden
WriteLiteral(@"</title>
        <style type=""text/css"">
            body { font-family: verdana, arial, helvetic; font-size: x-small; }
            table.collection { border-collapse: collapse; border-spacing: 0; border: 1px solid black; width: 100% }
            table.collection tr { vertical-align: top; }
            table.collection th { text-align: left; border: 1px solid black; padding: 4px; font-weight: bold; }
            table.collection td { border: 1px solid black; padding: 4px; }
            td, th, pre { font-size: x-small; } 
            #errorDetail { padding: 1em; background-color: #FFFFCC; } 
            #errorMessage { font-size: medium; font-style: italic; color: maroon; }
            h1 { font-size: small; }
        </style>
    </head>
    <body>
        <p id=""errorMessage"">");


            
            #line 36 "..\..\ErrorMailHtmlPage.cshtml"
                        Write(error.Type);

            
            #line default
            #line hidden
WriteLiteral(": ");


            
            #line 36 "..\..\ErrorMailHtmlPage.cshtml"
                                     Write(error.Message);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");


            
            #line 37 "..\..\ErrorMailHtmlPage.cshtml"
         if (error.Time != DateTime.MinValue)
        {

            
            #line default
            #line hidden
WriteLiteral("            <p>Generated: ");


            
            #line 39 "..\..\ErrorMailHtmlPage.cshtml"
                     Write(error.Time.ToUniversalTime().ToString("r"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");


            
            #line 40 "..\..\ErrorMailHtmlPage.cshtml"
        }

            
            #line default
            #line hidden

            
            #line 41 "..\..\ErrorMailHtmlPage.cshtml"
         if (error.Detail.Length != 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <pre id=\"errorDetail\">");


            
            #line 43 "..\..\ErrorMailHtmlPage.cshtml"
                             Write(error.Detail);

            
            #line default
            #line hidden
WriteLiteral("</pre>\r\n");


            
            #line 44 "..\..\ErrorMailHtmlPage.cshtml"
        }

            
            #line default
            #line hidden

            
            #line 45 "..\..\ErrorMailHtmlPage.cshtml"
          
            var collection = new
            {
                Data  = error.ServerVariables,
                Id    = "ServerVariables",
                Title = "Server Variables",
            };
        

            
            #line default
            #line hidden

            
            #line 53 "..\..\ErrorMailHtmlPage.cshtml"
         if (collection.Data != null && collection.Data.Count > 0)
        {
            var items = 
                from i in Enumerable.Range(0, collection.Data.Count)
                select KeyValuePair.Create(collection.Data.GetKey(i), 
                                           collection.Data[i]);
            
            items = items.OrderBy(e => e.Key, StringComparer.OrdinalIgnoreCase);


            
            #line default
            #line hidden
WriteLiteral("            <div id=\"");


            
            #line 62 "..\..\ErrorMailHtmlPage.cshtml"
                Write(collection.Id);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                <h1>");


            
            #line 63 "..\..\ErrorMailHtmlPage.cshtml"
               Write(collection.Title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n                <table class=\"collection\">\r\n                    <tr><th>Na" +
"me</th>            \r\n                        <th>Value</th></tr>\r\n");


            
            #line 67 "..\..\ErrorMailHtmlPage.cshtml"
                     foreach (var item in items)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <tr><td>");


            
            #line 69 "..\..\ErrorMailHtmlPage.cshtml"
                           Write(item.Key);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td>");


            
            #line 70 "..\..\ErrorMailHtmlPage.cshtml"
                           Write(item.Value);

            
            #line default
            #line hidden
WriteLiteral("</td></tr>\r\n");


            
            #line 71 "..\..\ErrorMailHtmlPage.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </table>\r\n            </div>\r\n");


            
            #line 74 "..\..\ErrorMailHtmlPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <p>Powered by <a href=\"http://elmah.googlecode.com/\">");


            
            #line 75 "..\..\ErrorMailHtmlPage.cshtml"
                                                        Write(about.Product);

            
            #line default
            #line hidden
WriteLiteral("</a>, \r\n            version ");


            
            #line 76 "..\..\ErrorMailHtmlPage.cshtml"
               Write(about.Version);

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 77 "..\..\ErrorMailHtmlPage.cshtml"
       Write(about.Copyright);

            
            #line default
            #line hidden
WriteLiteral(" \r\n            Licensed under <a href=\"http://www.apache.org/licenses/LICENSE-2.0" +
"\">Apache License, Version 2.0</a>. \r\n        </p>\r\n    </body>\r\n</html>\r\n");


        }
    }
}
#pragma warning restore 1591
