using System;
using IronPdf;
using IronPdf.Engines.Chrome;
using IronPdf.Rendering;

namespace IronPDF_Sample_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeExamples.HtmlToPdfBasic();
            CodeExamples.HtmlToPdfAdvanced();
            CodeExamples.UrlToPdf();
        }
    }
}