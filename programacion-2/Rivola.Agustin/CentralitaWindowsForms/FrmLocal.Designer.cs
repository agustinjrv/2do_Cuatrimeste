namespace CentralitaWindowsForms
{
    partial class FrmLocal
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
            this.textBox_Costo = new System.Windows.Forms.TextBox();
            this.Costo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Costo
            // 
            this.textBox_Costo.Location = new System.Drawing.Point(19, 171);
            this.textBox_Costo.Name = "textBox_Costo";
            this.textBox_Costo.Size = new System.Drawing.Size(174, 20);
            this.textBox_Costo.TabIndex = 8;
            // 
            // Costo
            // 
            this.Costo.AutoSize = true;
            this.Costo.Location = new System.Drawing.Point(16, 155);
            this.Costo.Name = "Costo";
            this.Costo.Size = new System.Drawing.Size(34, 13);
            this.Costo.TabIndex = 9;
            this.Costo.Text = "Costo";
            // 
            // FrmLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 276);
            this.Controls.Add(this.Costo);
            this.Controls.Add(this.textBox_Costo);
            this.Name = "FrmLocal";
            this.Text = "FrmLocal";
            this.Controls.SetChildIndex(this.label_numeroOrigen, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBox_NumeroOrigen, 0);
            this.Controls.SetChildIndex(this.btn_aceptar, 0);
            this.Controls.SetChildIndex(this.btn_Cancelar, 0);
            this.Controls.SetChildIndex(this.textBox_numeroDestino, 0);
            this.Controls.SetChildIndex(this.textBox_Duracion, 0);
            this.Controls.SetChildIndex(this.textBox_Costo, 0);
            this.Controls.SetChildIndex(this.Costo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Costo;
        private System.Windows.Forms.Label Costo;
    }
}