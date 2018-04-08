using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoria.Models
{
    class Animale : IAnimale
    {
        public int IdAnimale { get; set; }
        public string Nome { get; set; }
        public int spazioOccupato { get; set; }
        public void EmettiVerso(IAnimale animale)
        {
            throw new NotImplementedException();
        }
    }
}
