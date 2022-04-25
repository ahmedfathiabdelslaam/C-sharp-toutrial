using System; // The using System line means that you are using the System library in your project
using System.Collections.Generic;

namespace variables // namespaces are used to logically arrange classes
{
    class Program
    {
        static void Main (string[] args)
        {
            /*
            var number = 2;
            var count = 10;
            var total_price = 20.9f;
            var charcter = 'A';
            var firstname = "ahmed fathi";
            var isworking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(total_price);
            Console.WriteLine(charcter);
            Console.WriteLine(firstname);
            Console.WriteLine(isworking);
            */
            // Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            // Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            ///const float pi = 3.14f;
            //pi = 17;
            //int i = 1;
            //byte b = (byte) i;
            try
            {
                var number = "1234";
                //int i = Convert.ToInt32 (number);
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("canot convert from string to byte");
            }

        }
    }
}

