namespace Clase_09_WindowsForms
{
    partial class FrmCatedra
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
            this.groupBoxAlumnos = new System.Windows.Forms.GroupBox();
            this.comboBox_deOrdenamiento = new System.Windows.Forms.ComboBox();
            this.listBox_alumnos = new System.Windows.Forms.ListBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_calificar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.groupBoxALumnosCalificados = new System.Windows.Forms.GroupBox();
            this.listBox_alumnosCalificados = new System.Windows.Forms.ListBox();
            this.groupBoxAlumnos.SuspendLayout();
            this.groupBoxALumnosCalificados.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAlumnos
            // 
            this.groupBoxAlumnos.Controls.Add(this.comboBox_deOrdenamiento);
            this.groupBoxAlumnos.Controls.Add(this.listBox_alumnos);
            this.groupBoxAlumnos.Controls.Add(this.btn_agregar);
            this.groupBoxAlumnos.Controls.Add(this.btn_calificar);
            this.groupBoxAlumnos.Controls.Add(this.btn_modificar);
            this.groupBoxAlumnos.Location = new System.Drawing.Point(36, 23);
            this.groupBoxAlumnos.Name = "groupBoxAlumnos";
            this.groupBoxAlumnos.Size = new System.Drawing.Size(670, 278);
            this.groupBoxAlumnos.TabIndex = 0;
            this.groupBoxAlumnos.TabStop = false;
            this.groupBoxAlumnos.Text = "Alumnos";
            // 
            // comboBox_deOrdenamiento
            // 
            this.comboBox_deOrdenamiento.FormattingEnabled = true;
            this.comboBox_deOrdenamiento.Location = new System.Drawing.Point(20, 242);
            this.comboBox_deOrdenamiento.Name = "comboBox_deOrdenamiento";
            this.comboBox_deOrdenamiento.Size = new System.Drawing.Size(633, 21);
            this.comboBox_deOrdenamiento.TabIndex = 5;
            this.comboBox_deOrdenamiento.SelectedIndexChanged += new System.EventHandler(this.ComboBox_deOrdenamiento_SelectedIndexChanged);
            // 
            // listBox_alumnos
            // 
            this.listBox_alumnos.FormattingEnabled = true;
            this.listBox_alumnos.Location = new System.Drawing.Point(20, 62);
            this.listBox_alumnos.Name = "listBox_alumnos";
            this.listBox_alumnos.Size = new System.Drawing.Size(633, 173);
            this.listBox_alumnos.TabIndex = 4;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(19, 19);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // btn_calificar
            // 
            this.btn_calificar.Location = new System.Drawing.Point(281, 19);
            this.btn_calificar.Name = "btn_calificar";
            this.btn_calificar.Size = new System.Drawing.Size(75, 23);
            this.btn_calificar.TabIndex = 2;
            this.btn_calificar.Text = "Calificar";
            this.btn_calificar.UseVisualStyleBackColor = true;
            this.btn_calificar.Click += new System.EventHandler(this.btn_calificar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(578, 19);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 3;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // groupBoxALumnosCalificados
            // 
            this.groupBoxALumnosCalificados.Controls.Add(this.listBox_alumnosCalificados);
            this.groupBoxALumnosCalificados.Location = new System.Drawing.Point(36, 321);
            this.groupBoxALumnosCalificados.Name = "groupBoxALumnosCalificados";
            this.groupBoxALumnosCalificados.Size = new System.Drawing.Size(670, 271);
            this.groupBoxALumnosCalificados.TabIndex = 1;
            this.groupBoxALumnosCalificados.TabStop = false;
            this.groupBoxALumnosCalificados.Text = "Alumnos Calificados";
            // 
            // listBox_alumnosCalificados
            // 
            this.listBox_alumnosCalificados.FormattingEnabled = true;
            this.listBox_alumnosCalificados.Location = new System.Drawing.Point(20, 33);
            this.listBox_alumnosCalificados.Name = "listBox_alumnosCalificados";
            this.listBox_alumnosCalificados.Size = new System.Drawing.Size(633, 225);
            this.listBox_alumnosCalificados.TabIndex = 0;
            // 
            // FrmCatedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 604);
            this.Controls.Add(this.groupBoxALumnosCalificados);
            this.Controls.Add(this.groupBoxAlumnos);
            this.Name = "FrmCatedra";
            this.Text = "FrmCatedra";
            this.groupBoxAlumnos.ResumeLayout(false);
            this.groupBoxALumnosCalificados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAlumnos;
        private System.Windows.Forms.ComboBox comboBox_deOrdenamiento;
        private System.Windows.Forms.ListBox listBox_alumnos;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_calificar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.GroupBox groupBoxALumnosCalificados;
        private System.Windows.Forms.ListBox listBox_alumnosCalificados;
    }
}