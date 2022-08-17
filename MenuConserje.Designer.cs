namespace Sistema_Gestor_de_Condominio
{
    partial class MenuConserje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuConserje));
            this.btnResidente = new System.Windows.Forms.Button();
            this.RegistrarVisi = new System.Windows.Forms.Button();
            this.btnRegistrarS = new System.Windows.Forms.Button();
            this.RegistrarSalida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnResidente
            // 
            this.btnResidente.BackColor = System.Drawing.Color.Moccasin;
            this.btnResidente.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResidente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnResidente.Location = new System.Drawing.Point(39, 40);
            this.btnResidente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.btnResidente.Name = "btnResidente";
            this.btnResidente.Size = new System.Drawing.Size(110, 56);
            this.btnResidente.TabIndex = 0;
            this.btnResidente.Text = "Registar Residente";
            this.btnResidente.UseVisualStyleBackColor = false;
            this.btnResidente.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistrarVisi
            // 
            this.RegistrarVisi.BackColor = System.Drawing.Color.Moccasin;
            this.RegistrarVisi.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarVisi.Location = new System.Drawing.Point(39, 131);
            this.RegistrarVisi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.RegistrarVisi.Name = "RegistrarVisi";
            this.RegistrarVisi.Size = new System.Drawing.Size(110, 59);
            this.RegistrarVisi.TabIndex = 1;
            this.RegistrarVisi.Text = "Registrar Visitantes";
            this.RegistrarVisi.UseVisualStyleBackColor = false;
            this.RegistrarVisi.Click += new System.EventHandler(this.RegistrarVisi_Click);
            // 
            // btnRegistrarS
            // 
            this.btnRegistrarS.BackColor = System.Drawing.Color.Moccasin;
            this.btnRegistrarS.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarS.Location = new System.Drawing.Point(177, 40);
            this.btnRegistrarS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.btnRegistrarS.Name = "btnRegistrarS";
            this.btnRegistrarS.Size = new System.Drawing.Size(118, 56);
            this.btnRegistrarS.TabIndex = 2;
            this.btnRegistrarS.Text = "Registrar Servicio";
            this.btnRegistrarS.UseVisualStyleBackColor = false;
            this.btnRegistrarS.Click += new System.EventHandler(this.btnRegistrarS_Click);
            // 
            // RegistrarSalida
            // 
            this.RegistrarSalida.BackColor = System.Drawing.Color.Moccasin;
            this.RegistrarSalida.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarSalida.Location = new System.Drawing.Point(177, 131);
            this.RegistrarSalida.Name = "RegistrarSalida";
            this.RegistrarSalida.Size = new System.Drawing.Size(118, 59);
            this.RegistrarSalida.TabIndex = 3;
            this.RegistrarSalida.Text = "Cerrar Sesiòn";
            this.RegistrarSalida.UseVisualStyleBackColor = false;
            this.RegistrarSalida.Click += new System.EventHandler(this.RegistrarSalida_Click);
            // 
            // MenuConserje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_Gestor_de_Condominio.Properties.Resources._8fbd20b6d223538368511d90d5260818__2_;
            this.ClientSize = new System.Drawing.Size(312, 234);
            this.Controls.Add(this.RegistrarSalida);
            this.Controls.Add(this.btnRegistrarS);
            this.Controls.Add(this.RegistrarVisi);
            this.Controls.Add(this.btnResidente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuConserje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSERJE";
            this.Load += new System.EventHandler(this.MenuConserje_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResidente;
        private System.Windows.Forms.Button RegistrarVisi;
        private System.Windows.Forms.Button btnRegistrarS;
        private System.Windows.Forms.Button RegistrarSalida;
    }
}