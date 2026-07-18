using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace MiniStore.Global
{
    internal class clsInvoice
    {
        string _pathFile;
        public clsInvoice(string pathFile)
        {
            _pathFile = pathFile;
        }

        public bool DownloadInvoiceAsWordFile(string invoiceText)
        {
            Word.Application wordApp = new Word.Application();
            try
            {
                wordApp.Visible = false;


                Word.Document doc = wordApp.Documents.Add();
                Word.Paragraph paragraph = doc.Paragraphs.Add();
                paragraph.Range.Text = invoiceText;

                string pathfile = _pathFile + "\\";
                doc.SaveAs2(pathfile);
                doc.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
