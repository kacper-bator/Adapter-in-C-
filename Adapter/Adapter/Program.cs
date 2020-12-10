using Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komponenty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KomponentChemiczny> listaKomponentow = new List<KomponentChemiczny>()
            {
                new KomponentChemiczny(6, "Propanol","C3H8O", 97, -126),
                new KomponentChemicznyZBazy(BazaWlasciwosciChemicznych.Komponent.Woda),
                new KomponentChemicznyZBazy(BazaWlasciwosciChemicznych.Komponent.Etanol),
                new KomponentChemicznyZBazy(BazaWlasciwosciChemicznych.Komponent.Metanol),
                new KomponentChemicznyZBazy(BazaWlasciwosciChemicznych.Komponent.Benzen),
            };

            listaKomponentow.ForEach(komponent => komponent.WyswietlInformacje());
            Console.ReadKey();
        }
    }
}
