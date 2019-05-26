using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_logicanalyse
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();
            //easy data test
            calc.XOR(1000000, 0, 50, 10,90);
            calc.XOR(1000001, 0, 50, 10, 90);
            //middle data test
            calc.XOR(1000000, 0, 50, 1000, 50000);
            calc.XOR(1000001, 0, 50, 1000, 50000);
            //hard data test
            calc.XOR(1000000, 0, 50, 50000, 1000000);
            calc.XOR(1000001, 0, 50, 50000, 1000000);

            Console.ReadKey();
        }
    }
}
