using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_nákladák_Lizna
{
    public class Nakladak
    {
        public string Nazev { get; set; }
        private int palivo;
        public int Palivo { get => palivo; }
        public int Nosnost { get; set; }
        public  int Objem_nadrzre { get; }
        private int naklad;
        public int Naklad { get => naklad; }
        public int Spotreba_nadrze { get; }
        private int celkova_vzdalenost;
        public int Celkova_vzdalenost { get => celkova_vzdalenost; }

        private int penize;
        public int Penize { get => penize; }

        public Nakladak()
        {
            Nazev = "";
            naklad = 0;
            Nosnost = 12000;
            palivo = 180;
            celkova_vzdalenost = 0;
            Objem_nadrzre = 500;
            Spotreba_nadrze = 20;
            penize = 2000 ;
        }

        public void nalozit()
        {
            if (naklad == 12000)
            {
               
                naklad += 0;
                
            }
            else
            {
              
              naklad += 1000;
            }
           
        }
        public void vylozit()
        {
            if (naklad == 0)
            {
                naklad -= 0;
                
            }
            else
            {
                
                naklad -= 1000;
            }
        }

        public void natankovat()
        {
            if (palivo == 500)
            {
                palivo += 0;
                penize -= 0;
            }
            else
            {
                penize -= 780;
                palivo += 20;
            }
        }

        public void jet()
        {
            if (palivo == 0)
            {
                palivo -= 0;
                celkova_vzdalenost += 0;
            }

            else
            {
                palivo -= 2;
                celkova_vzdalenost += 10;
            }
            

        }   
        public void výplata()
        {
            if (penize < 10000)
            {
                penize += 90000;
            }
            else
            {
                penize += 0;
            }
        }
    }
  
    

    
    
        
    
}
