using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Osoba
    {
        public string imie, nazwisko;
        public int rokUrodzenia, waga, wzrost;
        public bool okulary;
        public enum plec{K=1,M=0};
        public int obliczWiek() 
        { 
            return DateTime.Now.Year-rokUrodzenia;
        }
            
        }

    }

