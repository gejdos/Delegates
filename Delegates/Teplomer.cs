using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Delegates
{
    class Teplomer
    {

        private Timer timer;
        private Random randomizer = new Random();

        public Teplomer()
        {
            timer = new Timer(randomizer.Next(2000, 10000));
            timer.Start();
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            //timer.Elapsed -= Timer_Elapsed;
            if (Prehriatie != null)
            {
                Prehriatie(100);
            }

        }

        public delegate void PrehriatieHandler(int teplota);
        public event PrehriatieHandler Prehriatie;
    }
}
