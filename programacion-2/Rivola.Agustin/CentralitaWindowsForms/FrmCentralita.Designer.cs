namespace CentralitaWindowsForms
{
    partial class FrmCentralita
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
            this.lst_llamada = new System.Windows.Forms.ListBox();
            this.btn_llamadaLocal = new System.Windows.Forms.Button();
            this.btn_llamadaProvincial = new System.Windows.Forms.Button();
            this.comboBox_ordenamiento = new System.Windows.Forms.ComboBox();
            this.label_ordenar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_llamada
            // 
            this.lst_llamada.FormattingEnabled = true;
            this.lst_llamada.Location = new System.Drawing.Point(12, 12);
            this.lst_llamada.Name = "lst_llamada";
            this.lst_llamada.Size = new System.Drawing.Size(616, 160);
            this.lst_llamada.TabIndex = 0;
            // 
            // btn_llamadaLocal
            // 
            this.btn_llamadaLocal.Location = new System.Drawing.Point(12, 178);
            this.btn_llamadaLocal.Name = "btn_llamadaLocal";
            this.btn_llamadaLocal.Size = new System.Drawing.Size(135, 23);
            this.btn_llamadaLocal.TabIndex = 1;
            this.btn_llamadaLocal.Text = "Llamada Local";
            this.btn_llamadaLocal.UseVisualStyleBackColor = true;
            this.btn_llamadaLocal.Click += new System.EventHandler(this.Btn_llamadaLocal_Click);
            // 
            // btn_llamadaProvincial
            // 
            this.btn_llamadaProvincial.Location = new System.Drawing.Point(153, 178);
            this.btn_llamadaProvincial.Name = "btn_llamadaProvincial";
            this.btn_llamadaProvincial.Size = new System.Drawing.Size(135, 23);
            this.btn_llamadaProvincial.TabIndex = 2;
            this.btn_llamadaProvincial.Text = "Llamada Provincial";
            this.btn_llamadaProvincial.UseVisualStyleBackColor = true;
            this.btn_llamadaProvincial.Click += new System.EventHandler(this.Btn_llamadaProvincial_Click);
            // 
            // comboBox_ordenamiento
            // 
            this.comboBox_ordenamiento.FormattingEnabled = true;
            this.comboBox_ordenamiento.Location = new System.Drawing.Point(482, 178);
            this.comboBox_ordenamiento.Name = "comboBox_ordenamiento";
            this.comboBox_ordenamiento.Size = new System.Drawing.Size(146, 21);
            this.comboBox_ordenamiento.TabIndex = 3;
            this.comboBox_ordenamiento.SelectedIndexChanged += new System.EventHandler(this.comboBox_ordenamiento_SelectedIndexChanged);
            // 
            // label_ordenar
            // 
            this.label_ordenar.AutoSize = true;
            this.label_ordenar.Location = new System.Drawing.Point(412, 183);
            this.label_ordenar.Name = "label_ordenar";
            this.label_ordenar.Size = new System.Drawing.Size(64, 13);
            this.label_ordenar.TabIndex = 4;
            this.label_ordenar.Text = "Ordenar Por";
            // 
            // FrmCentralita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 218);
            this.Controls.Add(this.label_ordenar);
            this.Controls.Add(this.comboBox_ordenamiento);
            this.Controls.Add(this.btn_llamadaProvincial);
            this.Controls.Add(this.btn_llamadaLocal);
            this.Controls.Add(this.lst_llamada);
            this.Name = "FrmCentralita";
            this.Text = "FrmCentralita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_llamada;
        private System.Windows.Forms.Button btn_llamadaLocal;
        private System.Windows.Forms.Button btn_llamadaProvincial;
        private System.Windows.Forms.ComboBox comboBox_ordenamiento;
        private System.Windows.Forms.Label label_ordenar;
    }
}

