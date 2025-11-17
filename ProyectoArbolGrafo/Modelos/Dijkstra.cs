using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoArbolGrafo.Modelos
{
    public static class Dijkstra
    {
        // esto calcula la ruta más corta desde inicio hasta fin
        public static List<string> CalcularRuta(Grafo grafo, string inicioNombre, string finNombre)
        {
            var inicio = grafo.Nodos.Find(n => n.Nombre == inicioNombre);
            var fin = grafo.Nodos.Find(n => n.Nombre == finNombre);

            if (inicio == null || fin == null)
                return new List<string>(); // nodo inexistente

            var dist = new Dictionary<Grafo.NodoGrafo, int>();
            var prev = new Dictionary<Grafo.NodoGrafo, Grafo.NodoGrafo>();
            var nodos = new List<Grafo.NodoGrafo>(grafo.Nodos);

            foreach (var nodo in nodos)
                dist[nodo] = int.MaxValue;

            dist[inicio] = 0;

            while (nodos.Count > 0)
            {
                // nodo con la distancia mínima
                nodos.Sort((x, y) => dist[x] - dist[y]);
                var u = nodos[0];
                nodos.RemoveAt(0);

                if (u == fin) break;

                foreach (var arista in u.Conexiones)
                {
                    int alt = dist[u] + arista.Peso;
                    if (alt < dist[arista.Destino])
                    {
                        dist[arista.Destino] = alt;
                        prev[arista.Destino] = u;
                    }
                }
            }

            // para reconstruir la ruta
            var ruta = new List<string>();
            var nodoActual = fin;

            while (prev.ContainsKey(nodoActual))
            {
                ruta.Insert(0, nodoActual.Nombre);
                nodoActual = prev[nodoActual];
            }

            if (ruta.Count > 0)
                ruta.Insert(0, inicio.Nombre);

            return ruta;
        }
    }
}
