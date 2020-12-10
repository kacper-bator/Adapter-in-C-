using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    //klasa docelowa//
    public class KomponentChemiczny
    {

        public int ID { get; set; }
        public string Nazwa { get; set; }
        public string Wzor {get; set;}
        public double TemperaturaWrzenia { get; set; }
        public double TemperaturaTopnienia { get; set; }

        public void WyswietlInformacje()
        {
            Console.WriteLine("{0}-{1}-{0}", new String('-', 5), this.Nazwa);
            Console.WriteLine("ID: {0}", this.ID);
            Console.WriteLine("Nazwa: {0}", this.Nazwa);

            Console.WriteLine("Wzor: {0}", this.Wzor);
            Console.WriteLine("Temperatura Wrzenia: {0}", this.TemperaturaWrzenia);
            Console.WriteLine("Temperatura Topnienia: {0}", this.TemperaturaWrzenia);
            Console.WriteLine();

        }

        public KomponentChemiczny(
            int id,
            string nazwa,
            string wzor,
            double temperaturawrzenia,
            double temperaturaTopnienia)
        {
            this.ID = id;
            this.Nazwa = nazwa;
            this.Wzor = wzor;
            this.TemperaturaWrzenia = temperaturawrzenia;
            this.TemperaturaTopnienia = temperaturaTopnienia;

        }
        protected KomponentChemiczny(int id)
        {
            this.ID = id;
        }
    }
}
