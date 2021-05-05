using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice26_3
{
    class Program
    {
        static int Divide(int dividend, int divisor)
        {
            try
            {
                Console.WriteLine("Divide Method Start");
                return dividend / divisor;
            }
            catch (Exception)
            {
                Console.WriteLine("Divide Method  Exception Occurred");
                throw;
            }
            finally
            {
                Console.WriteLine("Divide Method End");
            }
        }

        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Please enter a dividend");
                string temp = Console.ReadLine();
                int dividend = Convert.ToInt32(temp);

                Console.WriteLine("Please enter a divisor");
                temp = Console.ReadLine();
                int divisor = Convert.ToInt32(temp);



                Console.WriteLine("{0}/{1} = {2}", dividend, divisor, Divide(dividend, divisor));
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error" + e.Message);
            }
            finally
            {
                Console.WriteLine("End");
            }
        }
    }
}
