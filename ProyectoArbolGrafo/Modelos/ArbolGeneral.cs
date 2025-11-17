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

        public List<string> RecorridoBFS()
        {
            List<string> resultado = new List<string>();
            Queue<RegistroArbol> cola = new Queue<RegistroArbol>();

            cola.Enqueue(Raiz);

            while (cola.Count > 0)
            {
                var actual = cola.Dequeue();
                resultado.Add(actual.Id);

                foreach (var hijo in actual.Hijos)
                    cola.Enqueue(hijo);
            }

            return resultado;
        }

        // -------------------------
        // RECORRIDO PREORDEN
        // -------------------------
        public List<string> RecorridoPreorden()
        {
            List<string> lista = new List<string>();
            PreordenRecursivo(Raiz, lista);
            return lista;
        }

        private void PreordenRecursivo(RegistroArbol actual, List<string> lista)
        {
            if (actual == null)
                return;

            lista.Add(actual.Id); // visitar nodo

            foreach (var hijo in actual.Hijos)
                PreordenRecursivo(hijo, lista);
        }

        // -------------------------
        // CONTAR NODOS
        // -------------------------
        public int ContarNodos()
        {
            return ContarRecursivo(Raiz);
        }

        private int ContarRecursivo(RegistroArbol actual)
        {
            if (actual == null)
                return 0;

            int cantidad = 1; // este nodo

            foreach (var hijo in actual.Hijos)
                cantidad += ContarRecursivo(hijo);

            return cantidad;
        }
    }

}
