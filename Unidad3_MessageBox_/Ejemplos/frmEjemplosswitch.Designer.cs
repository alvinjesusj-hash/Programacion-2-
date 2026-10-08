namespace Unidad3_MessageBox_
{
    partial class frmEjemploswitch
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
            this.lblDiadesemana = new System.Windows.Forms.Label();
            this.txtDiadesemana = new System.Windows.Forms.TextBox();
            this.btnDiadesemana = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDiadesemana
            // 
            this.lblDiadesemana.AutoSize = true;
            this.lblDiadesemana.Location = new System.Drawing.Point(-1, 78);
            this.lblDiadesemana.Name = "lblDiadesemana";
            this.lblDiadesemana.Size = new System.Drawing.Size(237, 16);
            this.lblDiadesemana.TabIndex = 0;
            this.lblDiadesemana.Text = "Digite El Numero del dia de la semana";
            // 
            // txtDiadesemana
            // 
            this.txtDiadesemana.Location = new System.Drawing.Point(242, 72);
            this.txtDiadesemana.Name = "txtDiadesemana";
            this.txtDiadesemana.Size = new System.Drawing.Size(100, 22);
            this.txtDiadesemana.TabIndex = 1;
            this.txtDiadesemana.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDiadesemana
            // 
            this.btnDiadesemana.Location = new System.Drawing.Point(360, 72);
            this.btnDiadesemana.Name = "btnDiadesemana";
            this.btnDiadesemana.Size = new System.Drawing.Size(75, 23);
            this.btnDiadesemana.TabIndex = 2;
            this.btnDiadesemana.Text = "Mostrar";
            this.btnDiadesemana.UseVisualStyleBackColor = true;
            this.btnDiadesemana.Click += new System.EventHandler(this.btnDiadesemana_Click);
            // 
            // frmEjemploswitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 192);
            this.Controls.Add(this.btnDiadesemana);
            this.Controls.Add(this.txtDiadesemana);
            this.Controls.Add(this.lblDiadesemana);
            this.Name = "frmEjemploswitch";
            this.Text = "EjemploSwitch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiadesemana;
        private System.Windows.Forms.TextBox txtDiadesemana;
        private System.Windows.Forms.Button btnDiadesemana;
    }
}

