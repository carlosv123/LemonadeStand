using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lemonade
{
     public class Customer
    {
        private double thirst;

        public Customer()
        {
            
        }

        public void GetTimer()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Thread.Sleep(50);
            stopwatch.Stop();
            Random random = new Random();
            

        }
        

    }
}
