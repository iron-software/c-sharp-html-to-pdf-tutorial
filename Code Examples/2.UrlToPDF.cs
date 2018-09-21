using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IronPdf;

namespace HtmlToPdfTutorial
{
    public partial class Examples
    {
        public static void UrlToPdfExample()
        {

            // Create a PDF from a web page
            var Renderer = new HtmlToPdf();
            var PDF = Renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Portable_Document_Format");
            PDF.SaveAs("wikipedia.pdf");

            // This neat trick opens our PDF file so we can see the result
            System.Diagnostics.Process.Start("wikipedia.pdf");

        }
    }
}
