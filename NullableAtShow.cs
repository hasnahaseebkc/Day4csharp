using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class NullableAtShow
    {
        static void Main(string[] args)
        {


            //shorthand syntax for nullable types
            Nullable<int> i = null;
            if (i.HasValue)     //HasValue is a property
                Console.WriteLine(i);
            else
                Console.WriteLine("Null");

            Console.WriteLine();

            int? num1 = null;
            int? num2 = 45;

            double? num3 = new double?();
            double? num4 = 3.14157;

            bool? boolval = new bool?();

            //display the values
            Console.WriteLine("Nullables at show: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("A Nullable boolean value: {0}", boolval);



            //************* COALESCING OPERATOR NULLABLE ****************


            Console.WriteLine();

            double? n1 = null;
            double? n2 = 3.14157;
            double n3;

            n3 = n1 ?? 5.34;
            Console.WriteLine("Value of n3: {0}", n3);

            n3 = n2 ?? 5.34;
            Console.WriteLine("Value of n3: {0}", n3);


            //************************ NULLABLE HELPER CLASS **************88

            int? l = null;
            int m = 10;

            if (l < m)
                Console.WriteLine("l < m");
            else if (l > 10)
                Console.WriteLine("l > m");
            else if (l == 10)
                Console.WriteLine("i==j");
            else
                Console.WriteLine("Could not compare");


            Console.ReadLine();


        }


    }
}
