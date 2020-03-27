namespace Clase_09_WindowsForms
{
    partial class FrmAlumnoCalificado
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
            this.label_nota = new System.Windows.Forms.Label();
            this.textBox_Nota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click_1);
            // 
            // label_nota
            // 
            this.label_nota.AutoSize = true;
            this.label_nota.Location = new System.Drawing.Point(26, 211);
            this.label_nota.Name = "label_nota";
            this.label_nota.Size = new System.Drawing.Size(30, 13);
            this.label_nota.TabIndex = 10;
            this.label_nota.Text = "Nota";
            // 
            // textBox_Nota
            // 
            this.textBox_Nota.Location = new System.Drawing.Point(26, 227);
            this.textBox_Nota.Name = "textBox_Nota";
            this.textBox_Nota.Size = new System.Drawing.Size(192, 20);
            this.textBox_Nota.TabIndex = 11;
            // 
            // FrmAlumnoCalificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 311);
            this.Controls.Add(this.textBox_Nota);
            this.Controls.Add(this.label_nota);
            this.Name = "FrmAlumnoCalificado";
            this.Text = "FrmAlumnoCalificado";
            this.Controls.SetChildIndex(this.textBox_nombre, 0);
            this.Controls.SetChildIndex(this.textBox_apellido, 0);
            this.Controls.SetChildIndex(this.textBox_legajo, 0);
            this.Controls.SetChildIndex(this.comboBox_TipoExamen, 0);
            this.Controls.SetChildIndex(this.Btn_Aceptar, 0);
            this.Controls.SetChildIndex(this.label_nota, 0);
            this.Controls.SetChildIndex(this.textBox_Nota, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nota;
        private System.Windows.Forms.TextBox textBox_Nota;
    }
}