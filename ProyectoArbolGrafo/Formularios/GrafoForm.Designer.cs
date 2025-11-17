namespace ProyectoArbolGrafo.Formularios
{
    partial class GrafoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombreNodo = new System.Windows.Forms.Label();
            this.tbNodo = new System.Windows.Forms.TextBox();
            this.btnAgregarNodo = new System.Windows.Forms.Button();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.tbOrigen = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.tbDestino = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAgregarArista = new System.Windows.Forms.Button();
            this.lblInicioBFS = new System.Windows.Forms.Label();
            this.tbInicio = new System.Windows.Forms.TextBox();
            this.lblDestinoDijkstra = new System.Windows.Forms.Label();
            this.tbFin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRecorrido = new System.Windows.Forms.ListBox();
            this.btnBFS = new System.Windows.Forms.Button();
            this.btnDijkstra = new System.Windows.Forms.Button();
            this.gbNodos = new System.Windows.Forms.GroupBox();
            this.gbConexiones = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbAdyacencias = new System.Windows.Forms.GroupBox();
            this.lbAdyacencias = new System.Windows.Forms.ListBox();
            this.gbNodos.SuspendLayout();
            this.gbConexiones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbAdyacencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreNodo
            // 
            this.lblNombreNodo.AutoSize = true;
            this.lblNombreNodo.Location = new System.Drawing.Point(9, 28);
            this.lblNombreNodo.Name = "lblNombreNodo";
            this.lblNombreNodo.Size = new System.Drawing.Size(59, 16);
            this.lblNombreNodo.TabIndex = 0;
            this.lblNombreNodo.Text = "Nombre:";
            // 
            // tbNodo
            // 
            this.tbNodo.Location = new System.Drawing.Point(74, 28);
            this.tbNodo.Name = "tbNodo";
            this.tbNodo.Size = new System.Drawing.Size(110, 22);
            this.tbNodo.TabIndex = 1;
            // 
            // btnAgregarNodo
            // 
            this.btnAgregarNodo.Location = new System.Drawing.Point(34, 77);
            this.btnAgregarNodo.Name = "btnAgregarNodo";
            this.btnAgregarNodo.Size = new System.Drawing.Size(110, 31);
            this.btnAgregarNodo.TabIndex = 2;
            this.btnAgregarNodo.Text = "Agregar ";
            this.btnAgregarNodo.UseVisualStyleBackColor = true;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(15, 28);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(50, 16);
            this.lblOrigen.TabIndex = 3;
            this.lblOrigen.Text = "Origen:";
            // 
            // tbOrigen
            // 
            this.tbOrigen.Location = new System.Drawing.Point(71, 25);
            this.tbOrigen.Name = "tbOrigen";
            this.tbOrigen.Size = new System.Drawing.Size(127, 22);
            this.tbOrigen.TabIndex = 4;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(9, 67);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(56, 16);
            this.lblDestino.TabIndex = 5;
            this.lblDestino.Text = "Destino:";
            // 
            // tbDestino
            // 
            this.tbDestino.Location = new System.Drawing.Point(71, 61);
            this.tbDestino.Name = "tbDestino";
            this.tbDestino.Size = new System.Drawing.Size(126, 22);
            this.tbDestino.TabIndex = 6;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(23, 98);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(42, 16);
            this.lblPeso.TabIndex = 7;
            this.lblPeso.Text = "Peso:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 22);
            this.textBox1.TabIndex = 8;
            // 
            // btnAgregarArista
            // 
            this.btnAgregarArista.Location = new System.Drawing.Point(72, 130);
            this.btnAgregarArista.Name = "btnAgregarArista";
            this.btnAgregarArista.Size = new System.Drawing.Size(126, 33);
            this.btnAgregarArista.TabIndex = 9;
            this.btnAgregarArista.Text = "Agregar ";
            this.btnAgregarArista.UseVisualStyleBackColor = true;
            // 
            // lblInicioBFS
            // 
            this.lblInicioBFS.AutoSize = true;
            this.lblInicioBFS.Location = new System.Drawing.Point(29, 32);
            this.lblInicioBFS.Name = "lblInicioBFS";
            this.lblInicioBFS.Size = new System.Drawing.Size(41, 16);
            this.lblInicioBFS.TabIndex = 10;
            this.lblInicioBFS.Text = "Inicio:";
            // 
            // tbInicio
            // 
            this.tbInicio.Location = new System.Drawing.Point(76, 26);
            this.tbInicio.Name = "tbInicio";
            this.tbInicio.Size = new System.Drawing.Size(132, 22);
            this.tbInicio.TabIndex = 11;
            // 
            // lblDestinoDijkstra
            // 
            this.lblDestinoDijkstra.AutoSize = true;
            this.lblDestinoDijkstra.Location = new System.Drawing.Point(14, 69);
            this.lblDestinoDijkstra.Name = "lblDestinoDijkstra";
            this.lblDestinoDijkstra.Size = new System.Drawing.Size(56, 16);
            this.lblDestinoDijkstra.TabIndex = 12;
            this.lblDestinoDijkstra.Text = "Destino:";
            // 
            // tbFin
            // 
            this.tbFin.Location = new System.Drawing.Point(76, 66);
            this.tbFin.Name = "tbFin";
            this.tbFin.Size = new System.Drawing.Size(132, 22);
            this.tbFin.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Resultados:";
            // 
            // lbRecorrido
            // 
            this.lbRecorrido.FormattingEnabled = true;
            this.lbRecorrido.ItemHeight = 16;
            this.lbRecorrido.Location = new System.Drawing.Point(50, 128);
            this.lbRecorrido.Name = "lbRecorrido";
            this.lbRecorrido.Size = new System.Drawing.Size(191, 100);
            this.lbRecorrido.TabIndex = 15;
            // 
            // btnBFS
            // 
            this.btnBFS.Location = new System.Drawing.Point(50, 244);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(83, 36);
            this.btnBFS.TabIndex = 16;
            this.btnBFS.Text = "BFS";
            this.btnBFS.UseVisualStyleBackColor = true;
            // 
            // btnDijkstra
            // 
            this.btnDijkstra.Location = new System.Drawing.Point(153, 244);
            this.btnDijkstra.Name = "btnDijkstra";
            this.btnDijkstra.Size = new System.Drawing.Size(88, 36);
            this.btnDijkstra.TabIndex = 17;
            this.btnDijkstra.Text = "Dijkstra";
            this.btnDijkstra.UseVisualStyleBackColor = true;
            // 
            // gbNodos
            // 
            this.gbNodos.Controls.Add(this.lblNombreNodo);
            this.gbNodos.Controls.Add(this.tbNodo);
            this.gbNodos.Controls.Add(this.btnAgregarNodo);
            this.gbNodos.Location = new System.Drawing.Point(27, 26);
            this.gbNodos.Name = "gbNodos";
            this.gbNodos.Size = new System.Drawing.Size(200, 152);
            this.gbNodos.TabIndex = 18;
            this.gbNodos.TabStop = false;
            this.gbNodos.Text = "Agregar Nodos";
            // 
            // gbConexiones
            // 
            this.gbConexiones.Controls.Add(this.lblOrigen);
            this.gbConexiones.Controls.Add(this.lblDestino);
            this.gbConexiones.Controls.Add(this.lblPeso);
            this.gbConexiones.Controls.Add(this.tbOrigen);
            this.gbConexiones.Controls.Add(this.tbDestino);
            this.gbConexiones.Controls.Add(this.textBox1);
            this.gbConexiones.Controls.Add(this.btnAgregarArista);
            this.gbConexiones.Location = new System.Drawing.Point(370, 26);
            this.gbConexiones.Name = "gbConexiones";
            this.gbConexiones.Size = new System.Drawing.Size(296, 169);
            this.gbConexiones.TabIndex = 19;
            this.gbConexiones.TabStop = false;
            this.gbConexiones.Text = "Agregar Conexiones";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInicioBFS);
            this.groupBox1.Controls.Add(this.lblDestinoDijkstra);
            this.groupBox1.Controls.Add(this.tbInicio);
            this.groupBox1.Controls.Add(this.btnDijkstra);
            this.groupBox1.Controls.Add(this.tbFin);
            this.groupBox1.Controls.Add(this.btnBFS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbRecorrido);
            this.groupBox1.Location = new System.Drawing.Point(101, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 298);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // gbAdyacencias
            // 
            this.gbAdyacencias.Controls.Add(this.lbAdyacencias);
            this.gbAdyacencias.Location = new System.Drawing.Point(101, 585);
            this.gbAdyacencias.Name = "gbAdyacencias";
            this.gbAdyacencias.Size = new System.Drawing.Size(380, 346);
            this.gbAdyacencias.TabIndex = 21;
            this.gbAdyacencias.TabStop = false;
            this.gbAdyacencias.Text = "Adyacencias del Grafo";
            // 
            // lbAdyacencias
            // 
            this.lbAdyacencias.FormattingEnabled = true;
            this.lbAdyacencias.ItemHeight = 16;
            this.lbAdyacencias.Location = new System.Drawing.Point(17, 39);
            this.lbAdyacencias.Name = "lbAdyacencias";
            this.lbAdyacencias.Size = new System.Drawing.Size(344, 292);
            this.lbAdyacencias.TabIndex = 0;
            // 
            // GrafoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 943);
            this.Controls.Add(this.gbAdyacencias);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbConexiones);
            this.Controls.Add(this.gbNodos);
            this.Name = "GrafoForm";
            this.Text = "GrafoForm";
            this.Load += new System.EventHandler(this.GrafoForm_Load);
            this.gbNodos.ResumeLayout(false);
            this.gbNodos.PerformLayout();
            this.gbConexiones.ResumeLayout(false);
            this.gbConexiones.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbAdyacencias.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombreNodo;
        private System.Windows.Forms.TextBox tbNodo;
        private System.Windows.Forms.Button btnAgregarNodo;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.TextBox tbOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox tbDestino;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAgregarArista;
        private System.Windows.Forms.Label lblInicioBFS;
        private System.Windows.Forms.TextBox tbInicio;
        private System.Windows.Forms.Label lblDestinoDijkstra;
        private System.Windows.Forms.TextBox tbFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbRecorrido;
        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.Button btnDijkstra;
        private System.Windows.Forms.GroupBox gbNodos;
        private System.Windows.Forms.GroupBox gbConexiones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbAdyacencias;
        private System.Windows.Forms.ListBox lbAdyacencias;
    }
}