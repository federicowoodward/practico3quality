namespace WindowsFormsApp1
{
    partial class frmListarAlumnos
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
            this.PanelRenderAlumnos = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelRenderAlumnos
            // 
            this.PanelRenderAlumnos.AutoScroll = true;
            this.PanelRenderAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelRenderAlumnos.Location = new System.Drawing.Point(74, 24);
            this.PanelRenderAlumnos.Name = "PanelRenderAlumnos";
            this.PanelRenderAlumnos.Size = new System.Drawing.Size(560, 359);
            this.PanelRenderAlumnos.TabIndex = 1;
            // 
            // frmListarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 424);
            this.Controls.Add(this.PanelRenderAlumnos);
            this.Name = "frmListarAlumnos";
            this.Text = "ListarAlumnos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelRenderAlumnos;
    }
}