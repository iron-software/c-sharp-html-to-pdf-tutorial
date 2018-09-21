using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IronPdf;

namespace HtmlToPdfTutorial
{
    public partial class Examples
    {
        public static void JavaScriptChartsExample()
        {
            // Create a PDF Chart a live rendered dataset using d3.js and javascript
            var Renderer = new HtmlToPdf();
            var PDF = Renderer.RenderUrlAsPdf("https://bl.ocks.org/mbostock/4062006");
            PDF.SaveAs("chart.pdf");

            // This neat trick opens our PDF file so we can see the result
            System.Diagnostics.Process.Start("chart.pdf");
        }
    }
}
