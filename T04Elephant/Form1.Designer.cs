namespace T04Elephant
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDumbo = new System.Windows.Forms.Button();
            this.btnEli = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDumbo
            // 
            this.btnDumbo.Location = new System.Drawing.Point(74, 12);
            this.btnDumbo.Name = "btnDumbo";
            this.btnDumbo.Size = new System.Drawing.Size(105, 39);
            this.btnDumbo.TabIndex = 0;
            this.btnDumbo.Text = "Dumbo";
            this.btnDumbo.UseVisualStyleBackColor = true;
            this.btnDumbo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEli
            // 
            this.btnEli.Location = new System.Drawing.Point(74, 68);
            this.btnEli.Name = "btnEli";
            this.btnEli.Size = new System.Drawing.Size(105, 39);
            this.btnEli.TabIndex = 1;
            this.btnEli.Text = "Eli";
            this.btnEli.UseVisualStyleBackColor = true;
            this.btnEli.Click += new System.EventHandler(this.btnEli_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(74, 129);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(105, 37);
            this.btnSwap.TabIndex = 2;
            this.btnSwap.Text = "SWAP";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Iguala";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 239);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btnEli);
            this.Controls.Add(this.btnDumbo);
            this.Name = "Form1";
            this.Text = "T04P04 Swap Elephants";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDumbo;
        private System.Windows.Forms.Button btnEli;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button button1;
    }
}

