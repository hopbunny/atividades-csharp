namespace Hipotenusa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbltriangulo = new System.Windows.Forms.Label();
            this.txtlado1 = new System.Windows.Forms.TextBox();
            this.txtlado2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbltriangulo
            // 
            this.lbltriangulo.AutoSize = true;
            this.lbltriangulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltriangulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltriangulo.Location = new System.Drawing.Point(12, 40);
            this.lbltriangulo.MinimumSize = new System.Drawing.Size(80, 20);
            this.lbltriangulo.Name = "lbltriangulo";
            this.lbltriangulo.Size = new System.Drawing.Size(99, 21);
            this.lbltriangulo.TabIndex = 0;
            this.lbltriangulo.Text = "TRIANGULO";
            // 
            // txtlado1
            // 
            this.txtlado1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtlado1.Location = new System.Drawing.Point(98, 80);
            this.txtlado1.Name = "txtlado1";
            this.txtlado1.Size = new System.Drawing.Size(100, 25);
            this.txtlado1.TabIndex = 1;
            // 
            // txtlado2
            // 
            this.txtlado2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtlado2.Location = new System.Drawing.Point(98, 120);
            this.txtlado2.Name = "txtlado2";
            this.txtlado2.Size = new System.Drawing.Size(100, 25);
            this.txtlado2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.MinimumSize = new System.Drawing.Size(80, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "LADO 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.MinimumSize = new System.Drawing.Size(80, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "LADO 2";
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncalcular.Location = new System.Drawing.Point(12, 160);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(186, 50);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "CALCULAR";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtresultado.Location = new System.Drawing.Point(14, 220);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(184, 32);
            this.txtresultado.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(476, 337);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlado2);
            this.Controls.Add(this.txtlado1);
            this.Controls.Add(this.lbltriangulo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hipotenusa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbltriangulo;
        private TextBox txtlado1;
        private TextBox txtlado2;
        private Label label1;
        private Label label2;
        private Button btncalcular;
        private TextBox txtresultado;
    }
}