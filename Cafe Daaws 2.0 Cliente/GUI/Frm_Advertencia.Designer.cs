namespace Cafe_Daaws_2._0_Cliente.GUI
{
    partial class Frm_Advertencia
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
            this.Ptb_Titulo = new System.Windows.Forms.PictureBox();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            this.Btn_Leido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Titulo)).BeginInit();
            this.SuspendLayout();
            // 
            // Ptb_Titulo
            // 
            this.Ptb_Titulo.Image = global::Cafe_Daaws_2._0_Cliente.Properties.Resources.info;
            this.Ptb_Titulo.Location = new System.Drawing.Point(12, 12);
            this.Ptb_Titulo.Name = "Ptb_Titulo";
            this.Ptb_Titulo.Size = new System.Drawing.Size(70, 70);
            this.Ptb_Titulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ptb_Titulo.TabIndex = 0;
            this.Ptb_Titulo.TabStop = false;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(88, 15);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(278, 65);
            this.Lbl_Titulo.TabIndex = 1;
            this.Lbl_Titulo.Text = "Advertencia";
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.Location = new System.Drawing.Point(372, -1);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(24, 27);
            this.Btn_Cerrar.TabIndex = 7;
            this.Btn_Cerrar.Text = "X";
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Leido_Click);
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Descripcion.Location = new System.Drawing.Point(18, 85);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(357, 55);
            this.Lbl_Descripcion.TabIndex = 8;
            this.Lbl_Descripcion.Text = "Quedan 5 Minutos";
            this.Lbl_Descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Leido
            // 
            this.Btn_Leido.FlatAppearance.BorderSize = 0;
            this.Btn_Leido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Leido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Leido.Location = new System.Drawing.Point(141, 143);
            this.Btn_Leido.Name = "Btn_Leido";
            this.Btn_Leido.Size = new System.Drawing.Size(118, 23);
            this.Btn_Leido.TabIndex = 9;
            this.Btn_Leido.Text = "Entiendo";
            this.Btn_Leido.UseVisualStyleBackColor = true;
            this.Btn_Leido.Click += new System.EventHandler(this.Btn_Leido_Click);
            // 
            // Frm_Advertencia
            // 
            this.AcceptButton = this.Btn_Leido;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(398, 178);
            this.Controls.Add(this.Btn_Leido);
            this.Controls.Add(this.Lbl_Descripcion);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Ptb_Titulo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Advertencia";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Titulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ptb_Titulo;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Label Lbl_Descripcion;
        private System.Windows.Forms.Button Btn_Leido;
    }
}