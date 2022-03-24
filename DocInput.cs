using System;
using System.IO;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Packaging;

namespace DefeatBot
{
    public class DocInput
    {
        private string _exeption;
        private string _document;

        public DocInput()
        {
            try
            {
                using (WordprocessingDocument doc = WordprocessingDocument.Open("/Users/he6echblu/Desktop/Глава 0.docx" as string, true))
                {
                    _document = doc.MainDocumentPart.Document.Body.InnerText;
                }
            }
            catch (FileFormatException)
            {
                _exeption = "Неверно указан формат, или файл пуст";
            }
        }

        public string GetDocument()
        {
            if (_document != null)
                return _document;
            else
                return _exeption;
        }
    }
}
