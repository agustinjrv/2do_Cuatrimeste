namespace CentralitaWindowsForms
{
    partial class FrmProvincial
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_franja = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            //this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Franja";
            // 
            // comboBox_franja
            // 
            this.comboBox_franja.FormattingEnabled = true;
            this.comboBox_franja.Location = new System.Drawing.Point(19, 185);
            this.comboBox_franja.Name = "comboBox_franja";
            this.comboBox_franja.Size = new System.Drawing.Size(174, 21);
            this.comboBox_franja.TabIndex = 9;
            // 
            // FrmProvincial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 266);
            this.Controls.Add(this.comboBox_franja);
            this.Controls.Add(this.label1);
            this.Name = "FrmProvincial";
            this.Text = "FrmLocal";
            this.Controls.SetChildIndex(this.label_numeroOrigen, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBox_NumeroOrigen, 0);
            this.Controls.SetChildIndex(this.btn_Cancelar, 0);
            this.Controls.SetChildIndex(this.textBox_numeroDestino, 0);
            this.Controls.SetChildIndex(this.textBox_Duracion, 0);
            this.Controls.SetChildIndex(this.btn_aceptar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.comboBox_franja, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_franja;
    }
}