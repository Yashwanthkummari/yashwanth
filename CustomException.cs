using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling111
{
    internal class CustomException
    {
        public class DivideByOddNumberExcption : ApplicationException
        {
            public override string Message
            {
                get
                {
                    return "Attempted to divide by odd number ";
                }
            }
        }
        public void customexception1456()
        {
            try
            {
                Console.WriteLine(" enter 1st number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter 2nd number");
                int num2 = int.Parse(Console.ReadLine());
                if (num2 % 2 > 0)
                {
                    // throw new ApplicationException("num2 cannot be odd number");
                    throw new DivideByOddNumberExcption();
                }
                int result = num1 / num2;
                Console.WriteLine(" The result is :" + result);
            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (FormatException ex2)
            {
                Console.WriteLine("input must be a number");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("over flow ocurred due to  large integer " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(" end of program");
        }
    }
}
