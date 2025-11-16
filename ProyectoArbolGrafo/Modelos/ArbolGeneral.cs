using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArbolGrafo.Modelos
{
    public class ArbolGeneral
    {
        public RegistroArbol Raiz { get; private set; }

        public ArbolGeneral(string idRaiz)
        {
            Raiz = new RegistroArbol(idRaiz);
        }

        public RegistroArbol Buscar(RegistroArbol actual, string id)
        {
            if (actual == null) return null;
            if (actual.Id == id) return actual;

            foreach (var hijo in actual.Hijos)
            {
                var encontrado = Buscar(hijo, id);
                if (encontrado != null)
                    return encontrado;
            }

            return null;
        }

        public bool Insertar(string idPadre, string idNuevo, string info = "")
        {
            var padre = Buscar(Raiz, idPadre);
            if (padre == null)
                return false;

            padre.Hijos.Add(new RegistroArbol(idNuevo, info));
            return true;
        }
    }

}
