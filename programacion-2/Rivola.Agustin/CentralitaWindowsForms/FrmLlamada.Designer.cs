namespace CentralitaWindowsForms
{
    partial class FrmLlamada
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
            this.label_numeroOrigen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_NumeroOrigen = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.textBox_numeroDestino = new System.Windows.Forms.TextBox();
            this.textBox_Duracion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_numeroOrigen
            // 
            this.label_numeroOrigen.AutoSize = true;
            this.label_numeroOrigen.Location = new System.Drawing.Point(16, 20);
            this.label_numeroOrigen.Name = "label_numeroOrigen";
            this.label_numeroOrigen.Size = new System.Drawing.Size(78, 13);
            this.label_numeroOrigen.TabIndex = 0;
            this.label_numeroOrigen.Text = "Numero Origen";
//            this.label_numeroOrigen.Click += new System.EventHandler(this.label_numeroOrigen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero Destino";
           // this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duracion";
          //  this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_NumeroOrigen
            // 
            this.textBox_NumeroOrigen.Location = new System.Drawing.Point(19, 36);
            this.textBox_NumeroOrigen.Name = "textBox_NumeroOrigen";
            this.textBox_NumeroOrigen.Size = new System.Drawing.Size(174, 20);
            this.textBox_NumeroOrigen.TabIndex = 3;
         //   this.textBox_NumeroOrigen.TextChanged += new System.EventHandler(this.textBox_NumeroOrigen_TextChanged);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(19, 227);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 4;
            this.btn_aceptar.Text = "&Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.Btn_aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(118, 227);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "&Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // textBox_numeroDestino
            // 
            this.textBox_numeroDestino.Location = new System.Drawing.Point(19, 84);
            this.textBox_numeroDestino.Name = "textBox_numeroDestino";
            this.textBox_numeroDestino.Size = new System.Drawing.Size(174, 20);
            this.textBox_numeroDestino.TabIndex = 6;
          //  this.textBox_numeroDestino.TextChanged += new System.EventHandler(this.textBox_numeroDestino_TextChanged);
            // 
            // textBox_Duracion
            // 
            this.textBox_Duracion.Location = new System.Drawing.Point(19, 132);
            this.textBox_Duracion.Name = "textBox_Duracion";
            this.textBox_Duracion.Size = new System.Drawing.Size(174, 20);
            this.textBox_Duracion.TabIndex = 7;
           // this.textBox_Duracion.TextChanged += new System.EventHandler(this.textBox_Duracion_TextChanged);
            // 
            // FrmLlamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 262);
            this.Controls.Add(this.textBox_Duracion);
            this.Controls.Add(this.textBox_numeroDestino);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.textBox_NumeroOrigen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_numeroOrigen);
            this.Name = "FrmLlamada";
            this.Text = "Llamada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Button btn_aceptar;
        protected System.Windows.Forms.Label label_numeroOrigen;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox textBox_NumeroOrigen;
        protected System.Windows.Forms.Button btn_Cancelar;
        protected System.Windows.Forms.TextBox textBox_numeroDestino;
        protected System.Windows.Forms.TextBox textBox_Duracion;
    }
}