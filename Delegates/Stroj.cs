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
        private Teplomer teplomer = new Teplomer();

        public Stroj(string nazovStroja)
        {
            teplomer.Prehriatie
            
            this.nazovStroja = nazovStroja;
        }

        private void onPrehriatieStroja()
        {
            VypniStroj();
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
