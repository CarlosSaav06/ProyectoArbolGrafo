using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoArbolGrafo.Modelos
{
    public class Grafo
    {
        // Nodo del grafo
        public class NodoGrafo
        {
            public string Nombre { get; set; }
            public List<Arista> Conexiones { get; set; }

            public NodoGrafo(string nombre)
            {
                Nombre = nombre;
                Conexiones = new List<Arista>();
            }
        }

        // Arista entre nodos
        public class Arista
        {
            public NodoGrafo Destino { get; set; }
            public int Peso { get; set; }

            public Arista(NodoGrafo destino, int peso)
            {
                Destino = destino;
                Peso = peso;
            }
        }

        // lista de todos los nodos del grafo
        public List<NodoGrafo> Nodos { get; private set; }

        public Grafo()
        {
            Nodos = new List<NodoGrafo>();
        }

        // para agregar un nodo al grafo
        public void AgregarNodo(string nombre)
        {
            if (!Nodos.Any(n => n.Nombre == nombre))
                Nodos.Add(new NodoGrafo(nombre));
        }

        // para agregar una arista entre dos nodos existentes
        public void AgregarArista(string origen, string destino, int peso)
        {
            NodoGrafo nodoOrigen = Nodos.Find(n => n.Nombre == origen);
            NodoGrafo nodoDestino = Nodos.Find(n => n.Nombre == destino);

            if (nodoOrigen != null && nodoDestino != null)
            {
                // Grafo no dirigido
                if (!nodoOrigen.Conexiones.Any(a => a.Destino == nodoDestino))
                    nodoOrigen.Conexiones.Add(new Arista(nodoDestino, peso));

                if (!nodoDestino.Conexiones.Any(a => a.Destino == nodoOrigen))
                    nodoDestino.Conexiones.Add(new Arista(nodoOrigen, peso));
            }
        }

        // para obtener adyacencias para mostrar en ListBox
        public List<string> ObtenerAdyacencias()
        {
            List<string> lista = new List<string>();
            foreach (var nodo in Nodos)
            {
                foreach (var arista in nodo.Conexiones)
                {
                    // Evitar duplicados en grafo no dirigido
                    if (string.Compare(nodo.Nombre, arista.Destino.Nombre) <= 0)
                        lista.Add($"{nodo.Nombre} → {arista.Destino.Nombre} ({arista.Peso})");
                }
            }
            return lista;
        }
    }
}
