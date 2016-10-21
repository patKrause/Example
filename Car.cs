using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Car
    {
        public string marka;
        public int rok;
        private string model, iloscDrzwi, pojemnoscSilnika;
        public double srednieSpalanie;
        public void opiszTyp(int x)
        {
            Console.WriteLine(x);
        }
        public void opiszTyp(string y)
        {
            Console.WriteLine(y);
        }
        private double ObliczSpalanie(double dlugoscTrasy)
            {
            double spalanie = ((srednieSpalanie/100) * dlugoscTrasy);
            return spalanie;
            }
            public double ObliczKosztPrzejazdu(double dlugoscTrasy, double CenaPaliwa)
            {
            double kosztPrzejazdu = (ObliczSpalanie(dlugoscTrasy) * CenaPaliwa);
            return kosztPrzejazdu;
            }
    }
  }
