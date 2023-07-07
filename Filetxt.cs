using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Filetxt
    {
        string FilePath = @"C:\Users\admin\Desktop\YASHWANTH\Myfile.txt";

        public void Create()
        {

            //Create an Instance of FileStream Class By specifying the File Path and File Mode
            //FileMode is going to be Create as we are going to create a New File
            FileStream fileStream = new FileStream(FilePath, FileMode.Create);
            fileStream.Close();  //Finally close the fileStream Object

            Console.Write("File has been created and the Path is E:\\MyFile.txt");
            Console.WriteLine("---------------------------------------------------------------");

        }
        public void Read()
        {
            //Create a string variable to hold the file data
            string data;

            //Create an Instance of FileStream Class By specifying the File Path, File Mode, FileAccess
            //FileMode is going to be Open as we are going to read the data from the file
            //To Read the File, we are providing Read Access
            FileStream fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);

            //Create an Instance of StreamReader Object to Read the Data from the Stream
            //To the Constructor of StreamReader, pass the fileStream Object i.e. the stream to be read.
            using (StreamReader streamReader = new StreamReader(fileStream))
            {
                //ReadToEnd method reads all characters from the current position to the end of the stream. 
                //It will return the rest of the stream as a string, from the current position to the end. 
                //If the current position is at the end of the stream, returns an empty string ("").
                data = streamReader.ReadToEnd();
            }

            //Finally Print the data in the Console
            Console.WriteLine(data);
            Console.WriteLine("---------------------------------------------------------------");

        }
        public void Write()
        {

            string textToWrite = "Hello, world!";
            File.WriteAllText(FilePath, textToWrite);
            Console.WriteLine("Text written to the file.");
            // Console.WriteLine("Successfully saved file with data ");
            Console.WriteLine("---------------------------------------------------------------");

            Console.ReadKey();
        }
        public void Append()
        {

            //Create an Instance of FileStream Class By specifying the File Path and File Mode
            //FileMode is going to be Append as we are going to append some text in the file
            FileStream fileStream = new FileStream(FilePath, FileMode.Append);

            //Create the byte array which contains the string data to be appended in the File
            byte[] bytedata = Encoding.Default.GetBytes("C# Is an Object Oriented Programming Language");

            //Write the Byte Array into the File Stream Object using the Write Method
            //array (bytedata): The buffer containing data to write to the stream.
            //offset (0): The zero-based byte offset in the array from which to begin copying bytes to the stream.
            // count (bytedata.Length): The maximum number of bytes to write.
            fileStream.Write(bytedata, 0, bytedata.Length);

            //Finally close the fileStream Object
            fileStream.Close();
            Console.WriteLine("Successfully saved file with data : C# Is an Object Oriented Programming Language");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------");

            Console.ReadKey();
        }
        

           
        }
 
}
    


