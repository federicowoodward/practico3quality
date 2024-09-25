namespace WindowsFormsApp1
{
    partial class frmListarNoDocentes
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
            this.PanelRenderNoDocentes = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelRenderNoDocentes
            // 
            this.PanelRenderNoDocentes.AutoScroll = true;
            this.PanelRenderNoDocentes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelRenderNoDocentes.Location = new System.Drawing.Point(75, 33);
            this.PanelRenderNoDocentes.Name = "PanelRenderNoDocentes";
            this.PanelRenderNoDocentes.Size = new System.Drawing.Size(560, 359);
            this.PanelRenderNoDocentes.TabIndex = 2;
            // 
            // frmListarNoDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 424);
            this.Controls.Add(this.PanelRenderNoDocentes);
            this.Name = "frmListarNoDocentes";
            this.Text = "frmListarNoDocentes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelRenderNoDocentes;
    }
}