using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandling
{
    internal class FileIORead
   
        {
            public void Read()
            {
                //Set the File Path where your File is Exist
                string FilePath = @"C:\Users\admin\Desktop\YASHWANTH\Mytext.txt";

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

                Console.ReadKey();
            }
        }
    }

