namespace Lab8_José_Carlos_Girón_1064718
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.N = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SumaWhile = new System.Windows.Forms.Button();
            this.SumaDoWhile = new System.Windows.Forms.Button();
            this.SumaFor = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.buttonFibonacci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(111, 35);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(115, 20);
            this.N.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "N:";
            // 
            // SumaWhile
            // 
            this.SumaWhile.Location = new System.Drawing.Point(40, 80);
            this.SumaWhile.Name = "SumaWhile";
            this.SumaWhile.Size = new System.Drawing.Size(108, 23);
            this.SumaWhile.TabIndex = 2;
            this.SumaWhile.Text = "Suma -While";
            this.SumaWhile.UseVisualStyleBackColor = true;
            this.SumaWhile.Click += new System.EventHandler(this.SumaWhile_Click);
            // 
            // SumaDoWhile
            // 
            this.SumaDoWhile.Location = new System.Drawing.Point(40, 109);
            this.SumaDoWhile.Name = "SumaDoWhile";
            this.SumaDoWhile.Size = new System.Drawing.Size(108, 23);
            this.SumaDoWhile.TabIndex = 3;
            this.SumaDoWhile.Text = "Suma - Do While";
            this.SumaDoWhile.UseVisualStyleBackColor = true;
            this.SumaDoWhile.Click += new System.EventHandler(this.SumaDoWhile_Click);
            // 
            // SumaFor
            // 
            this.SumaFor.Location = new System.Drawing.Point(40, 138);
            this.SumaFor.Name = "SumaFor";
            this.SumaFor.Size = new System.Drawing.Size(108, 23);
            this.SumaFor.TabIndex = 4;
            this.SumaFor.Text = "Suma - For";
            this.SumaFor.UseVisualStyleBackColor = true;
            this.SumaFor.Click += new System.EventHandler(this.SumaFor_Click);
            // 
            // factorial
            // 
            this.factorial.Location = new System.Drawing.Point(177, 93);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(101, 23);
            this.factorial.TabIndex = 5;
            this.factorial.Text = "Factorial";
            this.factorial.UseVisualStyleBackColor = true;
            this.factorial.Click += new System.EventHandler(this.factorial_Click);
            // 
            // buttonFibonacci
            // 
            this.buttonFibonacci.Location = new System.Drawing.Point(177, 122);
            this.buttonFibonacci.Name = "buttonFibonacci";
            this.buttonFibonacci.Size = new System.Drawing.Size(101, 23);
            this.buttonFibonacci.TabIndex = 6;
            this.buttonFibonacci.Text = "Fibonacci";
            this.buttonFibonacci.UseVisualStyleBackColor = true;
            this.buttonFibonacci.Click += new System.EventHandler(this.buttonFibonacci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 187);
            this.Controls.Add(this.buttonFibonacci);
            this.Controls.Add(this.factorial);
            this.Controls.Add(this.SumaFor);
            this.Controls.Add(this.SumaDoWhile);
            this.Controls.Add(this.SumaWhile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.N);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SumaWhile;
        private System.Windows.Forms.Button SumaDoWhile;
        private System.Windows.Forms.Button SumaFor;
        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Button buttonFibonacci;
    }
}

