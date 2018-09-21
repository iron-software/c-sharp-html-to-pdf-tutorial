using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IronPdf;

namespace HtmlToPdfTutorial
{
    public partial class Examples
    {
        public static void PDFSettingsExample()
        {
            // Create a PDF from a web page
            var Renderer = new HtmlToPdf();
            Renderer.PrintOptions.PrintHtmlBackgrounds = true;
            Renderer.PrintOptions.PaperSize = PdfPrintOptions.PdfPaperSize.A4;
            Renderer.PrintOptions.PaperOrientation = PdfPrintOptions.PdfPaperOrientation.Landscape;
            Renderer.PrintOptions.Header = new SimpleHeaderFooter() { CenterText = "{url}" };
            Renderer.PrintOptions.Footer = new HtmlHeaderFooter() { HtmlFragment = "<div style='text-align:right'><em style='color:pink'>page {page} of {total-pages}</em></div>" };

            var PDF = Renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf/");
            var OutputPath = "nuget.pdf";
            PDF.SaveAs(OutputPath);

            // This neat trick opens our PDF file so we can see the result
            System.Diagnostics.Process.Start(OutputPath);
        }
    }
}
