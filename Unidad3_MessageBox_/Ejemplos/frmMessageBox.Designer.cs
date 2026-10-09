namespace Unidad3_MessageBox_.Ejemplos
{
    partial class frmMessageBox
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.txtOpcion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(49, 12);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(99, 47);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar info";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(49, 74);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(99, 40);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(49, 120);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(99, 36);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(49, 215);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(99, 34);
            this.btnSwitch.TabIndex = 3;
            this.btnSwitch.Text = "Switch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // txtOpcion
            // 
            this.txtOpcion.Location = new System.Drawing.Point(22, 187);
            this.txtOpcion.Name = "txtOpcion";
            this.txtOpcion.Size = new System.Drawing.Size(151, 22);
            this.txtOpcion.TabIndex = 4;
            // 
            // frmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 278);
            this.Controls.Add(this.txtOpcion);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMostrar);
            this.Name = "frmMessageBox";
            this.Text = "Ejemplos de uso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.TextBox txtOpcion;
    }
}