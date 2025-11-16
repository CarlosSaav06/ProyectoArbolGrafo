namespace ProyectoArbolGrafo
{
    partial class Form1
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
            this.btnARBOL = new System.Windows.Forms.Button();
            this.btnGRAFO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnARBOL
            // 
            this.btnARBOL.Location = new System.Drawing.Point(90, 130);
            this.btnARBOL.Name = "btnARBOL";
            this.btnARBOL.Size = new System.Drawing.Size(156, 139);
            this.btnARBOL.TabIndex = 0;
            this.btnARBOL.Text = "ÁRBOL";
            this.btnARBOL.UseVisualStyleBackColor = true;
            // 
            // btnGRAFO
            // 
            this.btnGRAFO.Location = new System.Drawing.Point(308, 130);
            this.btnGRAFO.Name = "btnGRAFO";
            this.btnGRAFO.Size = new System.Drawing.Size(156, 139);
            this.btnGRAFO.TabIndex = 1;
            this.btnGRAFO.Text = "GRAFO";
            this.btnGRAFO.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.btnGRAFO);
            this.Controls.Add(this.btnARBOL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnARBOL;
        private System.Windows.Forms.Button btnGRAFO;
    }
}

