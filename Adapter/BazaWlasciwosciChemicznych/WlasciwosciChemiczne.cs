using System;
using System.Collections.Generic;

namespace BazaWlasciwosciChemicznych
{
    public class WlasciwosciChemiczne
    {
       private readonly List<Wlasciwosci.WlasciwoscTekstowa> _nazwaKomponentu = new List<Wlasciwosci.WlasciwoscTekstowa>
        {
            new Wlasciwosci.WlasciwoscTekstowa{ID = (int)Komponent.Woda, Wartosc="Woda"},
            new Wlasciwosci.WlasciwoscTekstowa{ID = (int)Komponent.Metanol, Wartosc="Metanol"},
            new Wlasciwosci.WlasciwoscTekstowa{ID = (int)Komponent.Etanol, Wartosc="Etanol"},
            new Wlasciwosci.WlasciwoscTekstowa{ID = (int)Komponent.Benzen, Wartosc="Benzen"}
        };
        private readonly List<Wlasciwosci.WlasciwoscTekstowa> _wzorKomponentu = new List<Wlasciwosci.WlasciwoscTekstowa>
        {
            new Wlasciwosci.WlasciwoscTekstowa{ID = (int)Komponent.Woda, Wartosc="H2O"},
            new Wlasciwosci.WlasciwoscTekstowa{ID = (int)Komponent.Metanol, Wartosc="CH3OH"},
            new Wlasciwosci.WlasciwoscTekstowa{ID = (int)Komponent.Etanol, Wartosc="C2H5OH"},
            new Wlasciwosci.WlasciwoscTekstowa{ID = (int)Komponent.Benzen, Wartosc="C6H6"}
        };
        private readonly List<Wlasciwosci.WlasciwoscLiczbowa> _temperaturaTopnieniaKomponentu = new List<Wlasciwosci.WlasciwoscLiczbowa>
        {
            new Wlasciwosci.WlasciwoscLiczbowa{ID = (int)Komponent.Woda, Wartosc= 0.0},
            new Wlasciwosci.WlasciwoscLiczbowa{ID = (int)Komponent.Metanol, Wartosc= -97.6},
            new Wlasciwosci.WlasciwoscLiczbowa{ID = (int)Komponent.Etanol, Wartosc=-144.1},
            new Wlasciwosci.WlasciwoscLiczbowa{ID = (int)Komponent.Benzen, Wartosc=5.5}
        };
        private readonly List<Wlasciwosci.WlasciwoscLiczbowa> _temperaturaWrzeniaKomponentu = new List<Wlasciwosci.WlasciwoscLiczbowa>
        {
            new Wlasciwosci.WlasciwoscLiczbowa{ID = (int)Komponent.Woda, Wartosc= 100.0},
            new Wlasciwosci.WlasciwoscLiczbowa{ID = (int)Komponent.Metanol, Wartosc=64.7},
            new Wlasciwosci.WlasciwoscLiczbowa{ID = (int)Komponent.Etanol, Wartosc= 78.37},
            new Wlasciwosci.WlasciwoscLiczbowa{ID = (int)Komponent.Benzen, Wartosc=80.1}
        };

        public string PobierzNazweKomponentu(Komponent komponent)
        {
            try {
                return _nazwaKomponentu.Find(elem => elem.ID == (int)komponent).Wartosc;
            }
            catch { return "Nieznana"; }
        }
        public string PobierzWzorKomponentu(Komponent komponent)
        {
            try
            {
                return _wzorKomponentu.Find(elem => elem.ID == (int)komponent).Wartosc;
            }
            catch { return "Nieznana"; }
        }
        public double PobierzTemperatureTopnieniaKomponentu(Komponent komponent)
        {
            try
            {
                return _temperaturaTopnieniaKomponentu.Find(elem => elem.ID == (int)komponent).Wartosc;
            }
            catch { return 0; }
        }
        public double PobierzTemperatureWrzeniaKomponentu(Komponent komponent)
        {
            try
            {
                return _temperaturaWrzeniaKomponentu.Find(elem => elem.ID == (int)komponent).Wartosc;
            }
            catch { return 0; }
        }
    }
}
