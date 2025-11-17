using ProyectoArbolGrafo.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoArbolGrafo
{
    public partial class ArbolForm : Form
    {
        private ArbolGeneral arbol;
        public ArbolForm()
        {
            InitializeComponent();
            arbol = new ArbolGeneral("RAIZ", "Nodo raíz");
            ActualizarTreeView();
        }

        private void ActualizarTreeView()
        {
            tvArbol.Nodes.Clear();

            TreeNode nodoVisual = CrearNodoVisual(arbol.Raiz);
            tvArbol.Nodes.Add(nodoVisual);

            tvArbol.ExpandAll();
        }

        private TreeNode CrearNodoVisual(RegistroArbol nodo)
        {
            TreeNode n = new TreeNode($"{nodo.Id} ({nodo.Info})");

            foreach (var hijo in nodo.Hijos)
            {
                n.Nodes.Add(CrearNodoVisual(hijo));
            }

            return n;
        }


        private void tvArbol_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void ArbolForm_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string padre = tbPadre.Text.Trim();
            string nuevo = tbNuevo.Text.Trim();
            string info = tbInfo.Text.Trim();

            if (string.IsNullOrWhiteSpace(padre) || string.IsNullOrWhiteSpace(nuevo))
            {
                MessageBox.Show("Debe ingresar ID del padre y del nuevo nodo.");
                return;
            }

            bool insertado = arbol.Insertar(padre, nuevo, info);

            if (insertado)
            {
                MessageBox.Show("Nodo insertado correctamente.");
                ActualizarTreeView();
            }
            else
            {
                MessageBox.Show("No se encontró el nodo padre.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = tbBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Ingrese el ID del nodo a buscar.");
                return;
            }

            var encontrado = arbol.Buscar(arbol.Raiz, id);

            if (encontrado != null)
            {
                MessageBox.Show($"Nodo encontrado: {encontrado.Id} - {encontrado.Info}");
            }
            else
            {
                MessageBox.Show("Nodo no encontrado.");
            }
        }

        private void btnRecorridoBFS_Click(object sender, EventArgs e)
        {
            lbRecorrido.Items.Clear();

            var lista = arbol.RecorridoBFS();

            foreach (var id in lista)
                lbRecorrido.Items.Add(id);
        }

        private void btnPreorden_Click(object sender, EventArgs e)
        {
            lbRecorrido.Items.Clear();

            var lista = arbol.RecorridoPreorden();

            foreach (var id in lista)
                lbRecorrido.Items.Add(id);
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int cantidad = arbol.ContarNodos();
            MessageBox.Show($"El árbol tiene {cantidad} nodos en total.");
        }
    }
}
