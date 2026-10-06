namespace Unidad2_operadores.Ejemplos
{
    partial class EjemploOperadore
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
            this.btnOperaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOperaciones
            // 
            this.btnOperaciones.Location = new System.Drawing.Point(205, 73);
            this.btnOperaciones.Name = "btnOperaciones";
            this.btnOperaciones.Size = new System.Drawing.Size(75, 23);
            this.btnOperaciones.TabIndex = 0;
            this.btnOperaciones.Text = "Mostrar";
            this.btnOperaciones.UseVisualStyleBackColor = true;
            this.btnOperaciones.Click += new System.EventHandler(this.btnOperaciones_Click);
            // 
            // EjemploOperadore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 138);
            this.Controls.Add(this.btnOperaciones);
            this.Name = "EjemploOperadore";
            this.Text = "EjemploOperadore";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOperaciones;
    }
}