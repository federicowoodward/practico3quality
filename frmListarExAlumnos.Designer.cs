namespace WindowsFormsApp1
{
    partial class frmListarExAlumnos
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
            this.panelRendeExAlumnos = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelRendeExAlumnos
            // 
            this.panelRendeExAlumnos.Location = new System.Drawing.Point(12, 12);
            this.panelRendeExAlumnos.Name = "panelRendeExAlumnos";
            this.panelRendeExAlumnos.Size = new System.Drawing.Size(776, 426);
            this.panelRendeExAlumnos.TabIndex = 0;
            // 
            // frmListarExAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRendeExAlumnos);
            this.Name = "frmListarExAlumnos";
            this.Text = "frmListarExAlumnos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRendeExAlumnos;
    }
}