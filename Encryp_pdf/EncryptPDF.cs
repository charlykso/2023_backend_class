using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Generic;
// using Syncfusion.Pdf;
// using Syncfusion.Pdf.Security;
// using Spire.Pdf;
// using Spire.Pdf.Security;

namespace Encryp_pdf
{
    public class EncryptPDF
    {
        // public static void Main()
        // {
            // Create a new PDF document
            // PdfDocument document = new PdfDocument();

            // //Load the PDF document
            // document.LoadFromFile(@"./file/Sample-Template-of-ID.pdf");

            // // Set encryption settings for the document
            // document.Security.Encrypt("open", "permission", PdfPermissionsFlags.Print | PdfPermissionsFlags.CopyContent, PdfEncryptionKeySize.Key128Bit);

            // // Save and close the document
            // document.Save("./file/output.pdf");
            // document.Close(true);

            // Encrypt();
        // }


        // public static decrypt()
        // {
        //     //Create a PdfDocument instance
        //     PdfDocument pdf = new PdfDocument();

        //     //Load the encrypted PDF document with password
        //     pdf.LoadFromFile(@"Encrypt.pdf", "open");

        //     //Set the open and permissions passwords as empty to decrypt the PDF
        //     pdf.Security.Encrypt(string.Empty, string.Empty, PdfPermissionsFlags.Default, PdfEncryptionKeySize.Key128Bit, "permission");

        //     //Save the result document
        //     pdf.SaveToFile("Decrypt.pdf", FileFormat.PDF);
        // }


        // public static void Encrypt()
        // {
        //     //Create a PdfDocument instance
        //     PdfDocument pdf = new PdfDocument();

        //     //Load the PDF document
        //     pdf.LoadFromFile(@"./file/transcript-letter-Ij-2.pdf");

        //     //Encrypt the PDF with open and permissions passwords
        //     pdf.Security.Encrypt("open", "permission", PdfPermissionsFlags.Print | PdfPermissionsFlags.CopyContent, PdfEncryptionKeySize.Key128Bit);

        //     //Save the result file
        //     pdf.SaveToFile("./file/Encrypt.pdf", FileFormat.PDF);
        // }
    }
}
