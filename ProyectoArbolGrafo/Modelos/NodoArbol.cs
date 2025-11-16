using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArbolGrafo.Modelos
{
    public class RegistroArbol
    {
        public string Id { get; set; }
        public string Info { get; set; }
        public List<RegistroArbol> Hijos { get; set; }

        public RegistroArbol(string id, string info = "")
        {
            Id = id;
            Info = info;
            Hijos = new List<RegistroArbol>();
        }
    }
}
