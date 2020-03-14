using Microsoft.Office.Interop.Word;
using System;
using System.Text;

namespace WordDocumentToPDF
{
    class Program
    {
        private const string filePath = @"D:\Docs\text.docx";

        static void Main(string[] args)
        {
            ReadWordDocAndMakeChangeAndSaveAsPDF();

            ReadWordDocLineByLine();
        }

        private static void ReadWordDocAndMakeChangeAndSaveAsPDF()
        {
            Application app = null;
            Document doc = null;
            try
            {
                app = new Application();
                doc = app.Documents.Open(filePath);

                //  var textToFind = "vipin kumar";
                //var textToReplace = "ojas yadav";
                var textToReplace = "vipin kumar";
                var textToFind = "ojas yadav";
                var matchCase = true;
                var matchWholeWord = true;
                var matchWildcards = false;
                var matchSoundsLike = false;
                var matchAllWordForms = false;
                var forward = true;
                var wrap = 1;
                var format = false;
                var replace = 2;

                app.Selection.Find.Execute(
                    textToFind,
                    matchCase,
                    matchWholeWord,
                    matchWildcards,
                    matchSoundsLike,
                    matchAllWordForms,
                    forward,
                    wrap,
                    format,
                    textToReplace,
                    replace);

                doc.SaveAs2(@"D:\ojas.pdf", WdSaveFormat.wdFormatPDF);
              
                // OR
                // doc.ExportAsFixedFormat(tmpFile, WdExportFormat.wdExportFormatPDF);

                doc.Close();
                app.Quit();

            }
            catch (Exception e)
            {
                if (doc != null) doc.Close();
                if (app != null) app.Quit();
            }
        }

        private static void ReadWordDocLineByLine()
        {
            Application app = null;
            Document doc = null;

            StringBuilder text = new StringBuilder();

            try
            {
                app = new Application();

                object miss = System.Reflection.Missing.Value;
                object path = filePath;
                object readOnly = true;

                doc = app.Documents.Open(ref path, ref miss, ref readOnly, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss);

                for (int i = 0; i < doc.Paragraphs.Count; i++)
                {
                    text.Append(" \r\n " + doc.Paragraphs[i + 1].Range.Text.ToString());
                }

                doc.Close();
                app.Quit();
            }
            catch (Exception e)
            {
                if (doc != null) doc.Close();
                if (app != null) app.Quit();
            }

        }
    }
}
