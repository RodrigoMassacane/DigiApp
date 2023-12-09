using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Elemento
    {
        public int Id {  get; set; }
        public string Descripcion { get; set; }

        public string Digimon { get; set; }
        public string Tipe { get; set; }
        public string Atack { get; set; }

        public string Images { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
