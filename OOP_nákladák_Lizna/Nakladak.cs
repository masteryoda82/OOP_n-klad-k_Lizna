using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_nákladák_Lizna
{
    internal class Nakladak
    {
        public string Nazev = "";
        private int palivo;
        public int Palivo { get => palivo; }
        public string Nosnost = "";
        public  string Objem_nadrzre = "";
        private int naklad;
        public int Naklad { get => naklad; }
        public string Spotreba_nadrze = "";
        private int celkova_vzdalenost;
        public int Celkova_vzdalenost { get => celkova_vzdalenost; }

    }
    public  Nakladak()
    {

    }
    
        
    
}
