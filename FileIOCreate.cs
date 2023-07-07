using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class FileIOCreate
    {
        public void Create()
        {
            

            string FilePath = @"C:\Users\admin\Desktop\YASHWANTH\Mytext.txt";
            string FillePath = @"C:\Users\admin\Desktop\YASHWANTH\Myyuytext.txt";


            //Create an Instance of FileStream Class By specifying the File Path and File Mode
            //FileMode is going to be Create as we are going to create a New File
            FileStream fileStream = new FileStream(FilePath, FileMode.Create);
            FileStream filleStream = new FileStream(FillePath, FileMode.Create);


            //Finally close the fileStream Object
            fileStream.Close();

            Console.Write("File has been created and the Path is E:\\MyFile.txt");
            Console.Write("File has been created and the Path is C:\\Users\\admin\\Desktop\\YASHWANTH\\Myyuytext.txt");

            Console.ReadKey();
        }
    }
}
