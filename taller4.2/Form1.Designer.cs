namespace taller4._2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnir = new System.Windows.Forms.Button();
            this.lbxnumeros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primeros 20 números negativos pares";
            // 
            // btnir
            // 
            this.btnir.Location = new System.Drawing.Point(244, 344);
            this.btnir.Name = "btnir";
            this.btnir.Size = new System.Drawing.Size(81, 32);
            this.btnir.TabIndex = 1;
            this.btnir.Text = "Ir";
            this.btnir.UseVisualStyleBackColor = true;
            this.btnir.Click += new System.EventHandler(this.btnir_Click);
            // 
            // lbxnumeros
            // 
            this.lbxnumeros.FormattingEnabled = true;
            this.lbxnumeros.Location = new System.Drawing.Point(142, 74);
            this.lbxnumeros.Name = "lbxnumeros";
            this.lbxnumeros.Size = new System.Drawing.Size(291, 264);
            this.lbxnumeros.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 427);
            this.Controls.Add(this.lbxnumeros);
            this.Controls.Add(this.btnir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnir;
        private System.Windows.Forms.ListBox lbxnumeros;
    }
}

