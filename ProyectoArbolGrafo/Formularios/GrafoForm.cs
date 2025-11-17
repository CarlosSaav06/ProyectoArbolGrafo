using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoArbolGrafo.Modelos;


namespace ProyectoArbolGrafo.Formularios
{
    public partial class GrafoForm : Form
    {
        public GrafoForm(object miGrafoForm1)
        {
            InitializeComponent();
        }

        private void GrafoForm_Load(object sender, EventArgs e)
        {

        }

        // Clases internas para grafo
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

        public class Grafo
        {
            public List<NodoGrafo> Nodos { get; set; }

            public Grafo()
            {
                Nodos = new List<NodoGrafo>();
            }

            public void AgregarNodo(string nombre)
            {
                if (!Nodos.Any(n => n.Nombre == nombre))
                    Nodos.Add(new NodoGrafo(nombre));
            }

            public void AgregarArista(string origen, string destino, int peso)
            {
                NodoGrafo nodoOrigen = Nodos.Find(n => n.Nombre == origen);
                NodoGrafo nodoDestino = Nodos.Find(n => n.Nombre == destino);

                if (nodoOrigen != null && nodoDestino != null)
                {
                    nodoOrigen.Conexiones.Add(new Arista(nodoDestino, peso));
                    // Grafo no dirigido, agregamos también la conexión inversa
                    nodoDestino.Conexiones.Add(new Arista(nodoOrigen, peso));
                }
            }
        }

        private Grafo miGrafo;

      

        // la seccion de nodos
        private void btnAgregarNodo_Click(object sender, EventArgs e)
        {
            string nombre = tbNodo.Text.Trim();
            if (!string.IsNullOrEmpty(nombre))
            {
                miGrafo.AgregarNodo(nombre);
                tbNodo.Clear();
                tbNodo.Focus();
                ActualizarAdyacencias();
            }
            else
            {
                MessageBox.Show("Ingrese un nombre válido para el nodo.");
            }
        }

        // la seccion de aristas
        private void btnAgregarArista_Click(object sender, EventArgs e)
        {
            string origen = tbOrigen.Text.Trim();
            string destino = tbDestino.Text.Trim();

            if (int.TryParse(tbPeso.Text, out int peso) && !string.IsNullOrEmpty(origen) && !string.IsNullOrEmpty(destino))
            {
                miGrafo.AgregarArista(origen, destino, peso);
                tbOrigen.Clear();
                tbDestino.Clear();
                tbPeso.Clear();
                tbOrigen.Focus();
                ActualizarAdyacencias();
            }
            else
            {
                MessageBox.Show("Verifique los datos: nombres de nodos y peso numérico.");
            }
        }

        // la seccion de adyacencias
        private void ActualizarAdyacencias()
        {
            lbAdyacencias.Items.Clear();
            foreach (var nodo in miGrafo.Nodos)
            {
                foreach (var arista in nodo.Conexiones)
                {
                    // Mostrar cada conexión solo una vez para no duplicar en grafo no dirigido
                    if (string.Compare(nodo.Nombre, arista.Destino.Nombre) <= 0)
                        lbAdyacencias.Items.Add($"{nodo.Nombre} → {arista.Destino.Nombre} ({arista.Peso})");
                }
            }
        }

        // la seccion de recorridos
        private void btnBFS_Click(object sender, EventArgs e)
        {
            lbRecorrido.Items.Clear();
            string inicio = tbInicio.Text.Trim();
            NodoGrafo nodoInicio = miGrafo.Nodos.Find(n => n.Nombre == inicio);
            if (nodoInicio == null)
            {
                MessageBox.Show("Nodo de inicio no existe.");
                return;
            }

            List<string> recorrido = BFS(nodoInicio);
            foreach (var nombre in recorrido)
                lbRecorrido.Items.Add(nombre);
        }

        private List<string> BFS(NodoGrafo inicio)
        {
            List<string> visitados = new List<string>();
            Queue<NodoGrafo> cola = new Queue<NodoGrafo>();
            cola.Enqueue(inicio);
            visitados.Add(inicio.Nombre);

            while (cola.Count > 0)
            {
                NodoGrafo actual = cola.Dequeue();
                foreach (var arista in actual.Conexiones)
                {
                    if (!visitados.Contains(arista.Destino.Nombre))
                    {
                        visitados.Add(arista.Destino.Nombre);
                        cola.Enqueue(arista.Destino);
                    }
                }
            }
            return visitados;
        }

        private void btnDijkstra_Click(object sender, EventArgs e)
        {
            lbRecorrido.Items.Clear();
            string inicio = tbInicio.Text.Trim();
            string fin = tbFin.Text.Trim();

            NodoGrafo nodoInicio = miGrafo.Nodos.Find(n => n.Nombre == inicio);
            NodoGrafo nodoFin = miGrafo.Nodos.Find(n => n.Nombre == fin);

            if (nodoInicio == null || nodoFin == null)
            {
                MessageBox.Show("Nodo de inicio o fin no existe.");
                return;
            }

            List<string> ruta = Dijkstra(nodoInicio, nodoFin);
            if (ruta.Count == 0)
            {
                lbRecorrido.Items.Add("No hay ruta disponible");
            }
            else
            {
                foreach (var nombre in ruta)
                    lbRecorrido.Items.Add(nombre);
            }
        }

        private List<string> Dijkstra(NodoGrafo inicio, NodoGrafo fin)
        {
            var dist = new Dictionary<NodoGrafo, int>();
            var prev = new Dictionary<NodoGrafo, NodoGrafo>();
            var nodos = new List<NodoGrafo>(miGrafo.Nodos);

            foreach (var nodo in nodos)
                dist[nodo] = int.MaxValue;
            dist[inicio] = 0;

            while (nodos.Count > 0)
            {
                nodos.Sort((x, y) => dist[x] - dist[y]);
                NodoGrafo u = nodos[0];
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
            List<string> ruta = new List<string>();
            NodoGrafo nodoActual = fin;
            while (prev.ContainsKey(nodoActual))
            {
                ruta.Insert(0, nodoActual.Nombre);
                nodoActual = prev[nodoActual];
            }
            if (ruta.Count > 0)
                ruta.Insert(0, inicio.Nombre);
            return ruta;
        }

        private void btnDijkstra_Click_1(object sender, EventArgs e)
        {
            lbRecorrido.Items.Clear();
            string inicio = tbInicio.Text.Trim();
            string fin = tbFin.Text.Trim();

            List<string> ruta = Dijkstra.CalcularRuta(miGrafo, tbInicio.Text.Trim(), tbFin.Text.Trim());

            if (ruta.Count == 0)
                lbRecorrido.Items.Add("No hay ruta disponible");
            else
                ruta.ForEach(n => lbRecorrido.Items.Add(n));
        }
    }
}

