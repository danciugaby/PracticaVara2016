using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    public class LEinDelegates
    {
        delegate int del(int i);
       public static void ExampleLE ()
        {
            del myDelegate = y => y * y;
            int j = myDelegate(5);
           
        }

        public static void QueryOperator()
        {
            int[] fibo = { 1, 1, 2, 3, 5, 8, 13, 21 };
            IEnumerable<int> enumerator = fibo.Where(num => num%2 == 1);
            List<int> allvals = enumerator.ToList();
            //we can go trough the list and compute the average or...
            double averageValue = fibo.Where(num => num % 2 == 1).Average();
            Console.WriteLine(averageValue);
        }

        public static void MoreQueries()
        {
            int[] source = new[] { 3, 8, 4, 6, 1, 7, 9, 2, 4, 8 };

            foreach (int i in source.Where(
                x =>
                {
                    if (x <= 3)
                        return true;
                    else if (x >= 7)
                        return true;
                    return false;
                }
                )) 
            Console.WriteLine(i);
        }
    }
}
