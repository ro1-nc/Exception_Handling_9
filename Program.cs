using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int temp=0;
                List<int> counter = new List<int>();
                Console.WriteLine("Demonstration of various exception occur during simple division calculation");
                Console.WriteLine("{0}.FormatException-Enter anything other than numbers ",temp+=1);
                counter.Add(temp);
                Console.WriteLine("{0}.DivideByZeroException-Enter 2nd number zero", temp+=1);
                counter.Add(temp);
                Console.WriteLine("{0}.OverflowException-Enter very large value", temp += 1);
                counter.Add(temp);
                //Console.WriteLine("{0}.FormatException", temp += 1);
                //counter.Add(temp);
                wr:
                Console.WriteLine("Select which exception you want program to demonstrate(eg select 1 for FormatException)");
                int selection=Convert.ToInt16( Console.ReadLine());
                if(!counter.Contains(selection))
                {
                    Console.WriteLine("Choose appropriate option");
                    goto wr;
                }
                Console.WriteLine("Enter 1st number");
                int a= Convert.ToInt16( Console.ReadLine());
                Console.WriteLine("Enter 2nd number");
                int b=Convert.ToInt16(Console.ReadLine());

                Console.WriteLine(a / b);
                Console.WriteLine("No exceptions found. Code Run succesfully");

            }
            catch(FormatException  ex)
            {
                Console.WriteLine("FormatException type occurs when user enters different data type");
                Console.WriteLine("Error message is {0}",ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException type occurs when user tries to divide number by zero");
                Console.WriteLine("Error message is {0}", ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("OverflowException type occurs when user tries to add larger value than assign");
                Console.WriteLine("Error message is {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occured other than listed exceptions");
                Console.WriteLine(ex);
                Console.WriteLine("Error message is {0}", ex.Message);
            }
           
            Console.ReadKey();
        }
    }
}
