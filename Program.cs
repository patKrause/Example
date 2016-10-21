using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string CarName = "Mój samochód";
            Console.WriteLine(CarName);
            Car car1 = new Car();
            car1.marka = "Opel";
            car1.rok = 1996;
            car1.srednieSpalanie = 5.5;

            car1.opiszTyp(15);
            car1.opiszTyp("ładny");
            Console.WriteLine(car1.marka + " rocznik " + car1.rok);
            Console.WriteLine(car1.ObliczKosztPrzejazdu(100, 4.2));
    
           /* Car car2 = new Car();
            car2.marka = "Ford";
            car2.rok = 2002;
            Console.WriteLine(car2.marka + " rocznik " + car2.rok);
            car1 = car2;
            Console.WriteLine(car1.marka + " rocznik " + car1.rok);
            Console.WriteLine(car2.marka + " rocznik " + car2.rok);*/
    
            

            Console.ReadKey();
        }
}
}
        


