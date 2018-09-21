using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IronPdf;

namespace HtmlToPdfTutorial
{
    class Program
    {
        static void Main(string[] args)
        {


            // Render any HTML fragment or document to HTML
            var Renderer = new HtmlToPdf();
            
            // Settings 
            Renderer.PrintOptions.PaperSize = PdfPrintOptions.PdfPaperSize.A4;
            Renderer.PrintOptions.PaperOrientation = PdfPrintOptions.PdfPaperOrientation.Portrait;
            Renderer.PrintOptions.Header = new SimpleHeaderFooter() { CenterText = "Iron PDf C# Html to PDF Example", FontSize=10, FontFamily="Arial" };
            Renderer.PrintOptions.Footer = new HtmlHeaderFooter() { HtmlFragment = "<div style='text-align:right'><em style='color:#333'>page {page} of {total-pages}</em></div>" };

            // Render the HTML as a PDF
            var PDF = Renderer.RenderHtmlAsPdf("<h1 style='padding-top:150px'>This PDF is generated from HTML using C#</h1>");

            //  Editing the PDF by adding a watermark
            PDF.WatermarkAllPages( "<span style='color:red; font-size:44px; font-family:Arial'>Sample</example>", PdfDocument.WaterMarkLocation.MiddleCenter, 20, -45, "http://ironpdf.com");

            //  Save the PDF to a file
            var OutputPath = "IronPdfExample.pdf";
            PDF.SaveAs(OutputPath);

            // This neat trick opens our PDF file so we can see the result
            System.Diagnostics.Process.Start(OutputPath);


            // For detailed examples please check the "Code Examples" Folder or uncomment below
            // Examples.HtmlToPdfExample();
            // Examples.UrlToPdfExample();
            // Examples.HtmlFileToPdfExample();
            // Examples.PDFSettingsExample();
            // Examples.JavaScriptChartsExample();
        }
    }
}
