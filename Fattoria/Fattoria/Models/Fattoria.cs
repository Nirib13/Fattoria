using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria.Models
{
    class Fattoria
    {
        List<Animale> listaAnimali = new List<Animale>();
        public Fattoria()
        {
            listaAnimali.Add(new Mucca());
            listaAnimali[0].IdAnimale = 1;
            listaAnimali[0].Nome = "Carolina";
            listaAnimali[0].spazioOccupato = 4;
        }

        internal List<Animale> ListaAnimali { get => ListaAnimali1; set => ListaAnimali1 = value; }
        internal List<Animale> ListaAnimali1 { get => listaAnimali; set => listaAnimali = value; }
    }
}
