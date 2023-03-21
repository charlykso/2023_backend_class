using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ReadingPdf
{
    internal class NewExample
    {
        public static void newExample()
        {
            // Load the PDF file
            PdfReader reader = new PdfReader(@"C:/ASP_DOTNETCORE/2023_backend_class/ReadingPdf/ReadingPdf/files/malloc.pdf");

            // Create a PDF stamper object to edit the PDF file
            //PdfStamper stamper = new PdfStamper(reader, new FileStream("output.pdf", FileMode.Create));

            // Get the PDF form fields
            //AcroFields formFields = stamper.AcroFields;

            // Set the value of a form field
            //formFields.SetField("FieldName", "New Value");

            //get the number of pages
            int numOfPages = reader.NumberOfPages;

            //Loop through each page of the PDF file
            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                //Get the page object
                PdfDictionary pageDictionary = reader.GetPageN(page);

                //Get the content stream of the page
                PdfStream pageContentStream = pageDictionary.GetAsStream(PdfName.CONTENTS);

                //Create a reader for the content stream
                 PRTokeniser tokenizer = new PRTokeniser(new RandomAccessFileOrArray(pageContentStream.GetBytes()));

                //Loop through each token in the content stream
                while (tokenizer.NextToken())
                {
                    //Do something with the token, such as printing it to the console
                    Console.WriteLine(tokenizer.GetStartxref());
                }
            }

            // Close the stamper object
            reader.Close();

            Console.WriteLine(numOfPages);
        }
    }
}
