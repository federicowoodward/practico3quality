namespace WindowsFormsApp1
{
    partial class frmListarDocentes
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
            this.PanelRenderDocentes = new System.Windows.Forms.Panel();
            this.cargar = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelRenderDocentes
            // 
            this.PanelRenderDocentes.Location = new System.Drawing.Point(32, 79);
            this.PanelRenderDocentes.Name = "PanelRenderDocentes";
            this.PanelRenderDocentes.Size = new System.Drawing.Size(582, 347);
            this.PanelRenderDocentes.TabIndex = 0;
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(153, 26);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(178, 23);
            this.cargar.TabIndex = 1;
            this.cargar.Text = "Cargar a la base de datos";
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(390, 26);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(119, 23);
            this.borrar.TabIndex = 2;
            this.borrar.Text = "Borrar datos locales";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // frmListarDocentes
            // 
            this.ClientSize = new System.Drawing.Size(640, 438);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.cargar);
            this.Controls.Add(this.PanelRenderDocentes);
            this.Name = "frmListarDocentes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelRenderDocentes;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.Button borrar;
    }
}