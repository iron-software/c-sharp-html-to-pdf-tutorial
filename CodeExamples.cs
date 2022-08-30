using IronPdf;

namespace IronPDF_Sample_Project
{
    public class CodeExamples
    {
        public static void HtmlToPdfBasic()
        {
            var Renderer = new ChromePdfRenderer();
            
            // Create a PDF from a HTML string using C#
            var pdf = Renderer.RenderHtmlAsPdf("<h1>Hello World</h1>");

            // Export to a file or Stream
            pdf.SaveAs("output.pdf");
        }

        public static void HtmlToPdfAdvanced()
        {
            var Renderer = new ChromePdfRenderer();
            
            // Advanced Example with HTML Assets
            // Load external html assets: Images, CSS and JavaScript.
            // An optional BasePath 'C:\site\assets\' is set as the file location to load assets from 
            var myAdvancedPdf = Renderer.RenderHtmlAsPdf("<img src='icons/iron.png'>", @"C:\site\assets\");

            myAdvancedPdf.SaveAs("html-with-assets.pdf");
        }

        public static void UrlToPdf()
        {
            var Renderer = new ChromePdfRenderer();

            var myUrlPdf = Renderer.RenderUrlAsPdf("https://www.google.com/");

            myUrlPdf.SaveAs("url-to-pdf.pdf");
        }
    }
}