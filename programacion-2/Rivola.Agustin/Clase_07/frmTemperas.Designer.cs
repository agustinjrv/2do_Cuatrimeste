namespace Clase_07
{
    partial class frmTemperas
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Color = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.Label();
            this.Marca = new System.Windows.Forms.Label();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Location = new System.Drawing.Point(37, 137);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(31, 13);
            this.Color.TabIndex = 2;
            this.Color.Text = "Color";
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Location = new System.Drawing.Point(37, 74);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(49, 13);
            this.Cantidad.TabIndex = 3;
            this.Cantidad.Text = "Cantidad";
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Location = new System.Drawing.Point(37, 11);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(37, 13);
            this.Marca.TabIndex = 4;
            this.Marca.Text = "Marca";
            this.Marca.Click += new System.EventHandler(this.label3_Click);
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(40, 90);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(297, 20);
            this.textCantidad.TabIndex = 6;
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(40, 37);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(297, 20);
            this.textMarca.TabIndex = 5;
            this.textMarca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(40, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(297, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmTemperas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 290);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.textMarca);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmTemperas";
            this.Text = "frmTemperas";
            this.Load += new System.EventHandler(this.frmTemperas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}