namespace FrmEmpleado
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
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.comboBox_manejador = new System.Windows.Forms.ComboBox();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.textBox_Legajo = new System.Windows.Forms.TextBox();
            this.lbl_Legajo = new System.Windows.Forms.Label();
            this.lbl_sueldo = new System.Windows.Forms.Label();
            this.textBox_Sueldo = new System.Windows.Forms.TextBox();
            this.lbl_Manejador = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(9, 9);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(12, 25);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(222, 20);
            this.textBox_nombre.TabIndex = 1;
            // 
            // comboBox_manejador
            // 
            this.comboBox_manejador.FormattingEnabled = true;
            this.comboBox_manejador.Location = new System.Drawing.Point(12, 193);
            this.comboBox_manejador.Name = "comboBox_manejador";
            this.comboBox_manejador.Size = new System.Drawing.Size(222, 21);
            this.comboBox_manejador.TabIndex = 2;
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(12, 74);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(222, 20);
            this.textBox_Apellido.TabIndex = 4;
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(9, 58);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_Apellido.TabIndex = 3;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // textBox_Legajo
            // 
            this.textBox_Legajo.Location = new System.Drawing.Point(12, 115);
            this.textBox_Legajo.Name = "textBox_Legajo";
            this.textBox_Legajo.Size = new System.Drawing.Size(222, 20);
            this.textBox_Legajo.TabIndex = 6;
            // 
            // lbl_Legajo
            // 
            this.lbl_Legajo.AutoSize = true;
            this.lbl_Legajo.Location = new System.Drawing.Point(9, 99);
            this.lbl_Legajo.Name = "lbl_Legajo";
            this.lbl_Legajo.Size = new System.Drawing.Size(39, 13);
            this.lbl_Legajo.TabIndex = 5;
            this.lbl_Legajo.Text = "Legajo";
            // 
            // lbl_sueldo
            // 
            this.lbl_sueldo.AutoSize = true;
            this.lbl_sueldo.Location = new System.Drawing.Point(9, 138);
            this.lbl_sueldo.Name = "lbl_sueldo";
            this.lbl_sueldo.Size = new System.Drawing.Size(40, 13);
            this.lbl_sueldo.TabIndex = 7;
            this.lbl_sueldo.Text = "Sueldo";
            // 
            // textBox_Sueldo
            // 
            this.textBox_Sueldo.Location = new System.Drawing.Point(12, 154);
            this.textBox_Sueldo.Name = "textBox_Sueldo";
            this.textBox_Sueldo.Size = new System.Drawing.Size(222, 20);
            this.textBox_Sueldo.TabIndex = 8;
            // 
            // lbl_Manejador
            // 
            this.lbl_Manejador.AutoSize = true;
            this.lbl_Manejador.Location = new System.Drawing.Point(9, 177);
            this.lbl_Manejador.Name = "lbl_Manejador";
            this.lbl_Manejador.Size = new System.Drawing.Size(57, 13);
            this.lbl_Manejador.TabIndex = 9;
            this.lbl_Manejador.Text = "Manejador";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(24, 235);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 10;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(149, 235);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 280);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lbl_Manejador);
            this.Controls.Add(this.textBox_Sueldo);
            this.Controls.Add(this.lbl_sueldo);
            this.Controls.Add(this.textBox_Legajo);
            this.Controls.Add(this.lbl_Legajo);
            this.Controls.Add(this.textBox_Apellido);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.comboBox_manejador);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.lbl_Nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.ComboBox comboBox_manejador;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.TextBox textBox_Legajo;
        private System.Windows.Forms.Label lbl_Legajo;
        private System.Windows.Forms.Label lbl_sueldo;
        private System.Windows.Forms.TextBox textBox_Sueldo;
        private System.Windows.Forms.Label lbl_Manejador;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}

