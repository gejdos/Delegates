using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Stroj
    {
        private string nazovStroja;

        public Stroj(string nazovStroja)
        {
            this.nazovStroja = nazovStroja;
        }

        public void ZapniStroj()
        {
            Console.WriteLine("Zapinam {0}", nazovStroja);
        }

        public void VypniStroj()
        {
            Console.WriteLine("Vypinam {0}", nazovStroja);
        }

        
    }
}
