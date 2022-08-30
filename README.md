# C# HTML to PDF Tutorial
Source code tutorial showing basic and advanced Html to PDF conversions in C# using the IronPDF library.

## Basic HTML to PDF Code Example
```csharp
using IronPdf;

var Renderer = new IronPdf.ChromePdfRenderer();

// Create a PDF from a HTML string using C#
var pdf = Renderer.RenderHtmlAsPdf("<h1>Hello World</h1>");

// Export to a file or Stream
pdf.SaveAs("output.pdf");
```
## Advanced Code Example with HTML Assets
```csharp
using IronPdf;

var Renderer = new IronPdf.ChromePdfRenderer();

// Advanced Example with HTML Assets
// Load external html assets: Images, CSS and JavaScript.
// An optional BasePath 'C:\site\assets\' is set as the file location to load assets from 
var myAdvancedPdf = Renderer.RenderHtmlAsPdf("<img src='icons/iron.png'>", @"C:\site\assets\");

myAdvancedPdf.SaveAs("html-with-assets.pdf");
```

Further Reading: https://ironpdf.com/tutorials/html-to-pdf/
