using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IronPdf;

namespace HtmlToPdfTutorial
{
    public partial class Examples
    {
        public static void HtmlToPdfExample()
        {

            // Render any HTML fragment or document to HTML
            var Renderer = new HtmlToPdf();
            var PDF = Renderer.RenderHtmlAsPdf("<h1>Hello IronPdf</h1>");
            var OutputPath = "HtmlToPDF.pdf";
            PDF.SaveAs(OutputPath);

            // This neat trick opens our PDF file so we can see the result
            System.Diagnostics.Process.Start(OutputPath);
        }
    }
}
