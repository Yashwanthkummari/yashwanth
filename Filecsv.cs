using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ExceptionHandling
{
    internal class Filecsv
    {
        string FilePath = @"C:\Users\admin\Desktop\YASHWANTH\Myfilee.csv";

        public void Create()
        {
            //Create an Instance of FileStream Class By specifying the File Path and File Mode
            //FileMode is going to be Create as we are going to create a New File
            FileStream fileStream = new FileStream(FilePath, FileMode.Create);



            //Finally close the fileStream Object
            fileStream.Close();

            Console.WriteLine("File has been created and the Path is E:\\Myfileee.csv");
            Console.WriteLine("--------------------------------------------------------------------------------------");

            Console.ReadKey();
        }
        public void Write()
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                writer.WriteLine("Name, Age,Address, Department,Designation,Salary");
                writer.WriteLine("Yashwanth,23,Hyderabad,Developer,Associate software,25000");
                writer.WriteLine("Srikanth,25,Shamshabad,Developer,Associate Software,25000");
                writer.WriteLine("Ram,25,Secundrebad,Developer,Associate software,25000");
            }

            Console.WriteLine("CSV file created successfully.");
            Console.WriteLine("--------------------------------------------------------------------------------------");

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
            // Finally Print the data in the Console
            Console.WriteLine(data);
            Console.WriteLine("---------------------------------------------------------------");

        }
        public void Append()
        {
            string[] Name = { "Arun", "Kiran", "sai", "Nikihl", "Vishal", "karthik", "raghu" };
            int[] Age = { 28, 28, 29, 33, 34, 35, 40 };
            string[] Address = { "Warangal", "Delhi", "Mumbai", "Banglore", "chennai", "Vizag", "Ooty" };
            string[] Department = { "It", "IT", "IT", "IT", "IT", "IT", "IT", "ITandProduction" };
            string[] Designation = { " Software", "Software", "Software", "senoir Software", "senoir Software", "Asistant Manager", "Manager", "Senior Manager" };
            int[] Salary = { 35000, 35000, 35000, 45000, 45000, 60000, 80000, 100000 };
            using (StreamWriter writer = File.AppendText(FilePath))
            {
                for (int i = 0; i < Name.Length; i++)
                {
                    writer.WriteLine($"{Name[i]},{Age[i]},{Address[i]},{Department[i]},{Designation[i]},{Salary[i]}");
                }

                Console.WriteLine("Successfully saved file with data ");
            Console.WriteLine("--------------------------------------------------------------------------------");
        }

    }
}
    }