using ExceptionHandling;
using System.IO;

namespace ExceptionHandling111

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your problrm number");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    new ExceptionHandling().trycatch();
                    break;

                case 2:
                    new ExceptionHandlingfinally().finaly();
                    break;

                case 3:
                    new EHapplicationexception().applicationexception();
                    break;
                case 4:
                    new CustomException().customexception1456();
                        break;
                case 5:
                    new FileIOCreate().Create();
                    break;
                case 6:
                    new FileIOWrite().Append();
                    break;
                case 7:
                    new FileIORead().Read();
                    break;
                case 8:
                    new Write().Writee();
                    break;
                case 9:
                    Filetxt a =new Filetxt(); 
                    a.Create();
                    a.Read();   
                    a.Write();
                    a.Read();
                    a.Append();
                    a.Read();
                    break;
                case 10:
                    Filecsv b = new Filecsv();
                    b.Create();
                    b.Read();
                    b.Write();
                    b.Read();
                    b.Append();
                    b.Read();
                    b.Append();
                    b.Read();
                  //  b.Write();
                    break;
                case 11:
                    FileJson J = new FileJson();
                    J.Create();
                    J.Read();
                    J.Write();
                    

                    break;

            }

        }
    }
}