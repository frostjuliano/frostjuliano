using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Course7
{
    internal class Program
    {
        public static object MessageBox { get; private set; }

        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error! " + e.Message);
            }
            catch (FormatException f)
            {
                Console.WriteLine("Error! "+ f.Message);
            }
        }
    }
}
