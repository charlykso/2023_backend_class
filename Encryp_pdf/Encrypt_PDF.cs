using System;
// using ceTe.DynamicPDF;
// using ceTe.DynamicPDF.Cryptography;
// using System.Text;
// using System.IO;
// using System.Collections.Generic;
using ExpressEncription;

namespace Encryp_pdf
{
    public class Encrypt_PDF
    {
        public static void Run()
        {
            Decrypt();
        }

        public static void Generate()
        {
            var filePath = @"C:\Users\Ikenna Remigius\Downloads\Theory Innerrrr[295].pdf";
            ExpressEncription.AESEncription.AES_Encrypt(filePath, "password@123");
        }

        public static void Decrypt()
        {
            var filePath = @"C:\Users\Ikenna Remigius\Downloads\Theory Innerrrr2.pdf";
            // var filePath = @"./file/Theory Inner.pdf.aes";
            ExpressEncription.AESEncription.AES_Decrypt(filePath, "password@123");
        }
    }
}
