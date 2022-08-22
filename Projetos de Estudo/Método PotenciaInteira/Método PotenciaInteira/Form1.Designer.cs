namespace Método_PotenciaInteira
{
    partial class Potencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Potencia));
            this.lblbase = new System.Windows.Forms.Label();
            this.lblexpoente = new System.Windows.Forms.Label();
            this.txtbase = new System.Windows.Forms.TextBox();
            this.txtexpoente = new System.Windows.Forms.TextBox();
            this.btnchecar = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblbase
            // 
            this.lblbase.AutoSize = true;
            this.lblbase.BackColor = System.Drawing.Color.Transparent;
            this.lblbase.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblbase.Location = new System.Drawing.Point(2, 58);
            this.lblbase.MinimumSize = new System.Drawing.Size(80, 10);
            this.lblbase.Name = "lblbase";
            this.lblbase.Size = new System.Drawing.Size(80, 21);
            this.lblbase.TabIndex = 0;
            this.lblbase.Text = "BASE:";
            // 
            // lblexpoente
            // 
            this.lblexpoente.AutoSize = true;
            this.lblexpoente.BackColor = System.Drawing.Color.Transparent;
            this.lblexpoente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblexpoente.Location = new System.Drawing.Point(2, 98);
            this.lblexpoente.MinimumSize = new System.Drawing.Size(80, 10);
            this.lblexpoente.Name = "lblexpoente";
            this.lblexpoente.Size = new System.Drawing.Size(90, 21);
            this.lblexpoente.TabIndex = 1;
            this.lblexpoente.Text = "EXPOENTE:";
            // 
            // txtbase
            // 
            this.txtbase.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbase.Location = new System.Drawing.Point(98, 55);
            this.txtbase.MinimumSize = new System.Drawing.Size(80, 10);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(100, 29);
            this.txtbase.TabIndex = 2;
            // 
            // txtexpoente
            // 
            this.txtexpoente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtexpoente.Location = new System.Drawing.Point(98, 95);
            this.txtexpoente.MinimumSize = new System.Drawing.Size(80, 10);
            this.txtexpoente.Name = "txtexpoente";
            this.txtexpoente.Size = new System.Drawing.Size(100, 29);
            this.txtexpoente.TabIndex = 3;
            // 
            // btnchecar
            // 
            this.btnchecar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnchecar.Location = new System.Drawing.Point(2, 140);
            this.btnchecar.Name = "btnchecar";
            this.btnchecar.Size = new System.Drawing.Size(196, 42);
            this.btnchecar.TabIndex = 4;
            this.btnchecar.Text = "CALCULAR";
            this.btnchecar.UseVisualStyleBackColor = true;
            this.btnchecar.Click += new System.EventHandler(this.btnchecar_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtresultado.Location = new System.Drawing.Point(2, 200);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(196, 44);
            this.txtresultado.TabIndex = 5;
            // 
            // Potencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(444, 327);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.btnchecar);
            this.Controls.Add(this.txtexpoente);
            this.Controls.Add(this.txtbase);
            this.Controls.Add(this.lblexpoente);
            this.Controls.Add(this.lblbase);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Potencia";
            this.Text = "Potencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblbase;
        private Label lblexpoente;
        private TextBox txtbase;
        private TextBox txtexpoente;
        private Button btnchecar;
        private TextBox txtresultado;
    }
}