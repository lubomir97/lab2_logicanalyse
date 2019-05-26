using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_logicanalyse
{
    class Calculate
    {
        int a, b;
        public double ElasedSeconds => stopwatch.Elapsed.TotalSeconds;

            private Stopwatch stopwatch = new Stopwatch();
        public void XOR(int length, int min_a, int max_a, int min_b, int max_b)
        {
            var sw = Stopwatch.StartNew();
            for(int i = 0; i < length; i++)
            {
                Random rand = new Random();
                a = rand.Next(min_a, max_a);
                b = rand.Next(min_b, max_b);

                var result = a ^ b;
                //Console.WriteLine(" {0} ^ {1} = {2} ",a, b, result.ToString());

            }
            sw.Stop();
            Console.WriteLine(" Operation total time ---> " + sw.Elapsed.TotalSeconds.ToString() + " seconds");
        }
    }
}
