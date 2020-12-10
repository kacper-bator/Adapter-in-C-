using Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komponenty
{
    /// <summary>
    /// Adapter BazaWlasciwosciChemicznych.WlasciwosciChemiczne
    /// </summary>
    class KomponentChemicznyZBazy : KomponentChemiczny
    {
        BazaWlasciwosciChemicznych.WlasciwosciChemiczne wlasciwosciChemiczne = new BazaWlasciwosciChemicznych.WlasciwosciChemiczne();
        public KomponentChemicznyZBazy(BazaWlasciwosciChemicznych.Komponent komponent)
        :base((int)komponent)
        {
            this.Nazwa = wlasciwosciChemiczne.PobierzNazweKomponentu(komponent);
            this.Wzor = wlasciwosciChemiczne.PobierzWzorKomponentu(komponent);
            this.TemperaturaTopnienia = wlasciwosciChemiczne.PobierzTemperatureTopnieniaKomponentu(komponent);
            this.TemperaturaWrzenia = wlasciwosciChemiczne.PobierzTemperatureWrzeniaKomponentu(komponent);
        }

    }
}
