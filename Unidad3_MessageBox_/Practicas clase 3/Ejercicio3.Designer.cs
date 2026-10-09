namespace Unidad3_MessageBox_.Practicas_clase_3
{
    partial class Ejercicio3
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.btnMostrar1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(279, 76);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 22);
            this.txtNumero1.TabIndex = 0;
            this.txtNumero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnMostrar1
            // 
            this.btnMostrar1.Location = new System.Drawing.Point(294, 117);
            this.btnMostrar1.Name = "btnMostrar1";
            this.btnMostrar1.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar1.TabIndex = 1;
            this.btnMostrar1.Text = "Mostrar";
            this.btnMostrar1.UseVisualStyleBackColor = true;
            this.btnMostrar1.Click += new System.EventHandler(this.btnMostrar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione un valor del 1 al 4";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 176);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrar1);
            this.Controls.Add(this.txtNumero1);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Button btnMostrar1;
        private System.Windows.Forms.Label label1;
    }
}