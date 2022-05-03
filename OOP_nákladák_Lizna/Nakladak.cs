using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_nákladák_Lizna
{
    public class Nakladak
    {
        public string Nazev = "";
        private int palivo;
        public int Palivo { get => palivo; }
        public int Nosnost { get; set; }
        public  int Objem_nadrzre { get; }
        private int naklad;
        public int Naklad { get => naklad; }
        public int Spotreba_nadrze { get; }
        private int celkova_vzdalenost;
        public int Celkova_vzdalenost { get => celkova_vzdalenost; }

        public void Nakladak()
        {
            Nazev = "";
            naklad = 0;
            Nosnost = 10000;
        }
    }
  
    

    
    
        
    
}
