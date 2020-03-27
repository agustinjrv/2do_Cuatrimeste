namespace Clase_09_WindowsForms
{
    partial class FrmAlumno
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
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_apellido = new System.Windows.Forms.Label();
            this.label_legajo = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.textBox_legajo = new System.Windows.Forms.TextBox();
            this.comboBox_TipoExamen = new System.Windows.Forms.ComboBox();
            this.label_tipoExamen = new System.Windows.Forms.Label();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(23, 11);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(44, 13);
            this.label_nombre.TabIndex = 0;
            this.label_nombre.Text = "Nombre";
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Location = new System.Drawing.Point(23, 64);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(44, 13);
            this.label_apellido.TabIndex = 1;
            this.label_apellido.Text = "Apellido";
            // 
            // label_legajo
            // 
            this.label_legajo.AutoSize = true;
            this.label_legajo.Location = new System.Drawing.Point(23, 115);
            this.label_legajo.Name = "label_legajo";
            this.label_legajo.Size = new System.Drawing.Size(39, 13);
            this.label_legajo.TabIndex = 2;
            this.label_legajo.Text = "Legajo";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(26, 28);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(192, 20);
            this.textBox_nombre.TabIndex = 3;
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.Location = new System.Drawing.Point(26, 80);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(192, 20);
            this.textBox_apellido.TabIndex = 4;
            // 
            // textBox_legajo
            // 
            this.textBox_legajo.Location = new System.Drawing.Point(26, 131);
            this.textBox_legajo.Name = "textBox_legajo";
            this.textBox_legajo.Size = new System.Drawing.Size(192, 20);
            this.textBox_legajo.TabIndex = 5;
            // 
            // comboBox_TipoExamen
            // 
            this.comboBox_TipoExamen.FormattingEnabled = true;
            this.comboBox_TipoExamen.Location = new System.Drawing.Point(26, 183);
            this.comboBox_TipoExamen.Name = "comboBox_TipoExamen";
            this.comboBox_TipoExamen.Size = new System.Drawing.Size(192, 21);
            this.comboBox_TipoExamen.TabIndex = 6;
            // 
            // label_tipoExamen
            // 
            this.label_tipoExamen.AutoSize = true;
            this.label_tipoExamen.Location = new System.Drawing.Point(23, 167);
            this.label_tipoExamen.Name = "label_tipoExamen";
            this.label_tipoExamen.Size = new System.Drawing.Size(87, 13);
            this.label_tipoExamen.TabIndex = 7;
            this.label_tipoExamen.Text = "Tipo de Examen:";
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Location = new System.Drawing.Point(26, 258);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Aceptar.TabIndex = 8;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(143, 258);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // FrmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 303);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.label_tipoExamen);
            this.Controls.Add(this.comboBox_TipoExamen);
            this.Controls.Add(this.textBox_legajo);
            this.Controls.Add(this.textBox_apellido);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label_legajo);
            this.Controls.Add(this.label_apellido);
            this.Controls.Add(this.label_nombre);
            this.Name = "FrmAlumno";
            this.Text = "FrmAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_apellido;
        private System.Windows.Forms.Label label_legajo;
        private System.Windows.Forms.Label label_tipoExamen;
        private System.Windows.Forms.Button btn_cancelar;
        protected System.Windows.Forms.TextBox textBox_nombre;
        protected System.Windows.Forms.TextBox textBox_apellido;
        protected System.Windows.Forms.TextBox textBox_legajo;
        protected System.Windows.Forms.ComboBox comboBox_TipoExamen;
        protected System.Windows.Forms.Button Btn_Aceptar;
    }
}