using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elektronski_Parking_Sistem.Podaci
{
    public class ParkingServis
    {
        private List<Garaza> listaGaraza;

        public ParkingServis()
        {
            ListaGaraza = new List<Garaza>();
            ListaGaraza.Add(new Garaza("Garaža 1", 1));
            ListaGaraza.Add(new Garaza("Garaža 2", 2));
            ListaGaraza.Add(new Garaza("Garaža 3", 3));

        }

        public void dodajGarazu(Garaza g)
        {
            listaGaraza.Add(g);
        }

        public List<Garaza> ListaGaraza { get => listaGaraza; set => listaGaraza = value; }
    }
}
