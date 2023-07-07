using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Write
    {
        public void Writee()
        {
            //Set the File Path where your File is Exist
            string FilePath = @"C:\Users\admin\Desktop\YASHWANTH\Mytext.txt";


            string textToWrite = "Hello, world!";
            File.WriteAllText(FilePath, textToWrite);
            Console.WriteLine("Text written to the file.");
            // Console.WriteLine("Successfully saved file with data ");
            Console.ReadKey();
        }
        
    }
}
