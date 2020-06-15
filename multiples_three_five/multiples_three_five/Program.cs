using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace multiples_three_five
{
    class Program
    {               
        static void Main(string[] args)
        {
            int result = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;                    
                }
            }

            Console.WriteLine(result);
        }    
    }
}
