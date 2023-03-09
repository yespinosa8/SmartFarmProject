namespace SmartFarmProyect
{
    partial class FrmPlantas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlantas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblHumedad = new System.Windows.Forms.Label();
            this.Plant1 = new System.Windows.Forms.Button();
            this.Plant2 = new System.Windows.Forms.Button();
            this.plant3 = new System.Windows.Forms.Button();
            this.Plant4 = new System.Windows.Forms.Button();
            this.Plant5 = new System.Windows.Forms.Button();
            this.Plant7 = new System.Windows.Forms.Button();
            this.Plant6 = new System.Windows.Forms.Button();
            this.Plant8 = new System.Windows.Forms.Button();
            this.LblCantTemperatura = new System.Windows.Forms.Label();
            this.lblCantHumedad = new System.Windows.Forms.Label();
            this.btnSimulaClima = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(706, 519);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCantHumedad);
            this.panel1.Controls.Add(this.LblCantTemperatura);
            this.panel1.Controls.Add(this.lblHumedad);
            this.panel1.Controls.Add(this.lblTemperatura);
            this.panel1.Location = new System.Drawing.Point(768, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 482);
            this.panel1.TabIndex = 3;
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Segoe UI Historic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.Location = new System.Drawing.Point(58, 43);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(179, 37);
            this.lblTemperatura.TabIndex = 0;
            this.lblTemperatura.Text = "Temperatura";
            // 
            // lblHumedad
            // 
            this.lblHumedad.AutoSize = true;
            this.lblHumedad.Font = new System.Drawing.Font("Segoe UI Historic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumedad.Location = new System.Drawing.Point(81, 249);
            this.lblHumedad.Name = "lblHumedad";
            this.lblHumedad.Size = new System.Drawing.Size(141, 37);
            this.lblHumedad.TabIndex = 1;
            this.lblHumedad.Text = "Humedad";
            // 
            // Plant1
            // 
            this.Plant1.BackColor = System.Drawing.Color.White;
            this.Plant1.Location = new System.Drawing.Point(148, 74);
            this.Plant1.Name = "Plant1";
            this.Plant1.Size = new System.Drawing.Size(17, 18);
            this.Plant1.TabIndex = 4;
            this.Plant1.UseVisualStyleBackColor = false;
            this.Plant1.Click += new System.EventHandler(this.Plant1_Click);
            // 
            // Plant2
            // 
            this.Plant2.BackColor = System.Drawing.Color.White;
            this.Plant2.Location = new System.Drawing.Point(148, 136);
            this.Plant2.Name = "Plant2";
            this.Plant2.Size = new System.Drawing.Size(17, 18);
            this.Plant2.TabIndex = 5;
            this.Plant2.UseVisualStyleBackColor = false;
            // 
            // plant3
            // 
            this.plant3.BackColor = System.Drawing.Color.White;
            this.plant3.Location = new System.Drawing.Point(148, 192);
            this.plant3.Name = "plant3";
            this.plant3.Size = new System.Drawing.Size(17, 18);
            this.plant3.TabIndex = 6;
            this.plant3.UseVisualStyleBackColor = false;
            // 
            // Plant4
            // 
            this.Plant4.BackColor = System.Drawing.Color.White;
            this.Plant4.Location = new System.Drawing.Point(148, 259);
            this.Plant4.Name = "Plant4";
            this.Plant4.Size = new System.Drawing.Size(17, 18);
            this.Plant4.TabIndex = 7;
            this.Plant4.UseVisualStyleBackColor = false;
            // 
            // Plant5
            // 
            this.Plant5.BackColor = System.Drawing.Color.White;
            this.Plant5.Location = new System.Drawing.Point(148, 323);
            this.Plant5.Name = "Plant5";
            this.Plant5.Size = new System.Drawing.Size(17, 18);
            this.Plant5.TabIndex = 8;
            this.Plant5.UseVisualStyleBackColor = false;
            // 
            // Plant7
            // 
            this.Plant7.BackColor = System.Drawing.Color.White;
            this.Plant7.Location = new System.Drawing.Point(148, 439);
            this.Plant7.Name = "Plant7";
            this.Plant7.Size = new System.Drawing.Size(17, 18);
            this.Plant7.TabIndex = 9;
            this.Plant7.UseVisualStyleBackColor = false;
            // 
            // Plant6
            // 
            this.Plant6.BackColor = System.Drawing.Color.White;
            this.Plant6.Location = new System.Drawing.Point(148, 377);
            this.Plant6.Name = "Plant6";
            this.Plant6.Size = new System.Drawing.Size(17, 18);
            this.Plant6.TabIndex = 10;
            this.Plant6.UseVisualStyleBackColor = false;
            // 
            // Plant8
            // 
            this.Plant8.BackColor = System.Drawing.Color.White;
            this.Plant8.Location = new System.Drawing.Point(148, 504);
            this.Plant8.Name = "Plant8";
            this.Plant8.Size = new System.Drawing.Size(17, 18);
            this.Plant8.TabIndex = 12;
            this.Plant8.UseVisualStyleBackColor = false;
            // 
            // LblCantTemperatura
            // 
            this.LblCantTemperatura.AutoSize = true;
            this.LblCantTemperatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCantTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantTemperatura.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblCantTemperatura.Location = new System.Drawing.Point(113, 101);
            this.LblCantTemperatura.Name = "LblCantTemperatura";
            this.LblCantTemperatura.Size = new System.Drawing.Size(66, 27);
            this.LblCantTemperatura.TabIndex = 2;
            this.LblCantTemperatura.Text = "label3";
            // 
            // lblCantHumedad
            // 
            this.lblCantHumedad.AutoSize = true;
            this.lblCantHumedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCantHumedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantHumedad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCantHumedad.Location = new System.Drawing.Point(113, 310);
            this.lblCantHumedad.Name = "lblCantHumedad";
            this.lblCantHumedad.Size = new System.Drawing.Size(66, 27);
            this.lblCantHumedad.TabIndex = 3;
            this.lblCantHumedad.Text = "label3";
            // 
            // btnSimulaClima
            // 
            this.btnSimulaClima.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulaClima.Location = new System.Drawing.Point(938, 20);
            this.btnSimulaClima.Name = "btnSimulaClima";
            this.btnSimulaClima.Size = new System.Drawing.Size(142, 32);
            this.btnSimulaClima.TabIndex = 13;
            this.btnSimulaClima.Text = "Simular Clima";
            this.btnSimulaClima.UseVisualStyleBackColor = true;
            this.btnSimulaClima.Click += new System.EventHandler(this.btnSimulaClima_Click);
            // 
            // FrmPlantas
            // 
            this.ClientSize = new System.Drawing.Size(1092, 569);
            this.Controls.Add(this.btnSimulaClima);
            this.Controls.Add(this.Plant8);
            this.Controls.Add(this.Plant6);
            this.Controls.Add(this.Plant7);
            this.Controls.Add(this.Plant5);
            this.Controls.Add(this.Plant4);
            this.Controls.Add(this.plant3);
            this.Controls.Add(this.Plant2);
            this.Controls.Add(this.Plant1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmPlantas";
            this.Text = "Plantas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHumedad;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Button Plant1;
        private System.Windows.Forms.Button Plant2;
        private System.Windows.Forms.Button plant3;
        private System.Windows.Forms.Button Plant4;
        private System.Windows.Forms.Button Plant5;
        private System.Windows.Forms.Button Plant7;
        private System.Windows.Forms.Button Plant6;
        private System.Windows.Forms.Button Plant8;
        private System.Windows.Forms.Label lblCantHumedad;
        private System.Windows.Forms.Label LblCantTemperatura;
        private System.Windows.Forms.Button btnSimulaClima;
    }
}

