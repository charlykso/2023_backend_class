using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using TallComponents.PDF.Rasterizer;
using Aspose.Words;

namespace ReadingPdf
{
    internal class Example
    {
        public static void readPdf()
        {
            //string file = @"C:/ASP_DOTNETCORE/2023_backend_class/ReadingPdf/ReadingPdf/files/SocialMedia.pdf";
            //string readText = File.ReadAllText(file);
            //Console.WriteLine(readText);
            Document document;
            try
            {
                string newDate = DateTime.Now.ToString("d");
                Console.WriteLine(newDate);
                using (FileStream file = new
                    FileStream(@"C:/ASP_DOTNETCORE/2023_backend_class/ReadingPdf/ReadingPdf/files/SocialMedia.pdf",
                    FileMode.Open, FileAccess.Read))
                {
                    document = new Document(file);
                    //Console.WriteLine(value: document.ExtractPages(1, 1));
                    foreach(var word in document.ExtractPages(1, 4))
                    {
                        
                         Console.WriteLine(word);
                    
                        //Console.WriteLine(word);
                    }
                }

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void readPDFExample()
        {
            Document doc = new Document(@"C:/ASP_DOTNETCORE/2023_backend_class/ReadingPdf/ReadingPdf/files/SocialMedia.pdf");
            DocumentBuilder builder = new DocumentBuilder(doc);

        }
    }
}
