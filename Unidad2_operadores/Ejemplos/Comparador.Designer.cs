namespace Unidad2_operadores.Ejemplos
{
    partial class Comparador
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
            this.lblNumeroUno = new System.Windows.Forms.Label();
            this.lblNumerodos = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnComparar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroUno
            // 
            this.lblNumeroUno.AutoSize = true;
            this.lblNumeroUno.Location = new System.Drawing.Point(41, 28);
            this.lblNumeroUno.Name = "lblNumeroUno";
            this.lblNumeroUno.Size = new System.Drawing.Size(155, 16);
            this.lblNumeroUno.TabIndex = 0;
            this.lblNumeroUno.Text = "Ingrese el primer numero";
            this.lblNumeroUno.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNumerodos
            // 
            this.lblNumerodos.AutoSize = true;
            this.lblNumerodos.Location = new System.Drawing.Point(44, 69);
            this.lblNumerodos.Name = "lblNumerodos";
            this.lblNumerodos.Size = new System.Drawing.Size(170, 16);
            this.lblNumerodos.TabIndex = 1;
            this.lblNumerodos.Text = "Ingrese el segundo numero";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(220, 28);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 22);
            this.txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(220, 63);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 22);
            this.txtNum2.TabIndex = 3;
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(343, 49);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(75, 23);
            this.btnComparar.TabIndex = 4;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // Comparador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 130);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNumerodos);
            this.Controls.Add(this.lblNumeroUno);
            this.Name = "Comparador";
            this.Text = "Comparador";
            this.Load += new System.EventHandler(this.Comparador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroUno;
        private System.Windows.Forms.Label lblNumerodos;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnComparar;
    }
}