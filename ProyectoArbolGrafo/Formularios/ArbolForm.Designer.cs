namespace ProyectoArbolGrafo
{
    partial class ArbolForm
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
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.tbPadre = new System.Windows.Forms.TextBox();
            this.tbNuevo = new System.Windows.Forms.TextBox();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbRecorrido = new System.Windows.Forms.ListBox();
            this.btnRecorridoBFS = new System.Windows.Forms.Button();
            this.btnPreorden = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.lblPadre = new System.Windows.Forms.Label();
            this.lblNuevo = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(49, 40);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(307, 661);
            this.tvArbol.TabIndex = 0;
            this.tvArbol.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvArbol_AfterSelect);
            // 
            // tbPadre
            // 
            this.tbPadre.Location = new System.Drawing.Point(603, 46);
            this.tbPadre.Name = "tbPadre";
            this.tbPadre.Size = new System.Drawing.Size(115, 22);
            this.tbPadre.TabIndex = 1;
            // 
            // tbNuevo
            // 
            this.tbNuevo.Location = new System.Drawing.Point(603, 101);
            this.tbNuevo.Name = "tbNuevo";
            this.tbNuevo.Size = new System.Drawing.Size(115, 22);
            this.tbNuevo.TabIndex = 2;
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(603, 160);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(115, 22);
            this.tbInfo.TabIndex = 3;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(618, 211);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(100, 49);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(603, 326);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(115, 22);
            this.tbBuscar.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(618, 373);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 38);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lbRecorrido
            // 
            this.lbRecorrido.FormattingEnabled = true;
            this.lbRecorrido.ItemHeight = 16;
            this.lbRecorrido.Location = new System.Drawing.Point(539, 465);
            this.lbRecorrido.Name = "lbRecorrido";
            this.lbRecorrido.Size = new System.Drawing.Size(203, 116);
            this.lbRecorrido.TabIndex = 7;
            // 
            // btnRecorridoBFS
            // 
            this.btnRecorridoBFS.Location = new System.Drawing.Point(583, 599);
            this.btnRecorridoBFS.Name = "btnRecorridoBFS";
            this.btnRecorridoBFS.Size = new System.Drawing.Size(135, 33);
            this.btnRecorridoBFS.TabIndex = 8;
            this.btnRecorridoBFS.Text = "Recorrido BFS";
            this.btnRecorridoBFS.UseVisualStyleBackColor = true;
            // 
            // btnPreorden
            // 
            this.btnPreorden.Location = new System.Drawing.Point(583, 638);
            this.btnPreorden.Name = "btnPreorden";
            this.btnPreorden.Size = new System.Drawing.Size(135, 36);
            this.btnPreorden.TabIndex = 9;
            this.btnPreorden.Text = "Recorrido Preorden";
            this.btnPreorden.UseVisualStyleBackColor = true;
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(583, 680);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(135, 34);
            this.btnContar.TabIndex = 10;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            // 
            // lblPadre
            // 
            this.lblPadre.AutoSize = true;
            this.lblPadre.Location = new System.Drawing.Point(525, 52);
            this.lblPadre.Name = "lblPadre";
            this.lblPadre.Size = new System.Drawing.Size(47, 16);
            this.lblPadre.TabIndex = 11;
            this.lblPadre.Text = "Padre:";
            // 
            // lblNuevo
            // 
            this.lblNuevo.AutoSize = true;
            this.lblNuevo.Location = new System.Drawing.Point(522, 104);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(50, 16);
            this.lblNuevo.TabIndex = 12;
            this.lblNuevo.Text = "Nuevo:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(525, 166);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(45, 16);
            this.lblInfo.TabIndex = 13;
            this.lblInfo.Text = "lblInfo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Buscar ID:";
            // 
            // ArbolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 756);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblNuevo);
            this.Controls.Add(this.lblPadre);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.btnPreorden);
            this.Controls.Add(this.btnRecorridoBFS);
            this.Controls.Add(this.lbRecorrido);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.tbNuevo);
            this.Controls.Add(this.tbPadre);
            this.Controls.Add(this.tvArbol);
            this.Name = "ArbolForm";
            this.Text = "ArbolForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.TextBox tbPadre;
        private System.Windows.Forms.TextBox tbNuevo;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox lbRecorrido;
        private System.Windows.Forms.Button btnRecorridoBFS;
        private System.Windows.Forms.Button btnPreorden;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Label lblPadre;
        private System.Windows.Forms.Label lblNuevo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label1;
    }
}