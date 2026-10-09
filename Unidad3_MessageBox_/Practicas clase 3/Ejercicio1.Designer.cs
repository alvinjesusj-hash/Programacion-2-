namespace Unidad3_MessageBox_.Practicas_clase_3
{
    partial class Ejercicio1
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
            this.txtOpcion1 = new System.Windows.Forms.TextBox();
            this.btnSeleccionar1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOpcion1
            // 
            this.txtOpcion1.Location = new System.Drawing.Point(194, 72);
            this.txtOpcion1.Name = "txtOpcion1";
            this.txtOpcion1.Size = new System.Drawing.Size(100, 22);
            this.txtOpcion1.TabIndex = 0;
            // 
            // btnSeleccionar1
            // 
            this.btnSeleccionar1.Location = new System.Drawing.Point(205, 110);
            this.btnSeleccionar1.Name = "btnSeleccionar1";
            this.btnSeleccionar1.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar1.TabIndex = 1;
            this.btnSeleccionar1.Text = "Mostrar";
            this.btnSeleccionar1.UseVisualStyleBackColor = true;
            this.btnSeleccionar1.Click += new System.EventHandler(this.btnSeleccionar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione una opcion  del 1 al 3";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 267);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeleccionar1);
            this.Controls.Add(this.txtOpcion1);
            this.Name = "Ejercicio1";
            this.Text = "Ejercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOpcion1;
        private System.Windows.Forms.Button btnSeleccionar1;
        private System.Windows.Forms.Label label1;
    }
}