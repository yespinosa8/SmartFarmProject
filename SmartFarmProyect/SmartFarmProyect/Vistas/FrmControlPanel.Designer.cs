namespace SmartFarmProyect
{
    partial class FrmControlPanel
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAnimales = new System.Windows.Forms.Button();
            this.btnPlantas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnimales
            // 
            this.btnAnimales.Location = new System.Drawing.Point(70, 75);
            this.btnAnimales.Name = "btnAnimales";
            this.btnAnimales.Size = new System.Drawing.Size(142, 111);
            this.btnAnimales.TabIndex = 0;
            this.btnAnimales.Text = "Animales";
            this.btnAnimales.UseVisualStyleBackColor = true;
            this.btnAnimales.Click += new System.EventHandler(this.btnAnimales_Click);
            // 
            // btnPlantas
            // 
            this.btnPlantas.Location = new System.Drawing.Point(271, 75);
            this.btnPlantas.Name = "btnPlantas";
            this.btnPlantas.Size = new System.Drawing.Size(142, 111);
            this.btnPlantas.TabIndex = 1;
            this.btnPlantas.Text = "Plantas";
            this.btnPlantas.UseVisualStyleBackColor = true;
            this.btnPlantas.Click += new System.EventHandler(this.btnPlantas_Click);
            // 
            // FrmControlPanel
            // 
            this.AccessibleDescription = "";
            this.ClientSize = new System.Drawing.Size(496, 249);
            this.Controls.Add(this.btnPlantas);
            this.Controls.Add(this.btnAnimales);
            this.Name = "FrmControlPanel";
            this.Text = "Smart Farm Control Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnimales;
        private System.Windows.Forms.Button btnPlantas;
    }
}

