namespace Cafe_Daaws_2._0_Cliente.GUI.Configuraciones
{
    partial class Frm_Login
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
            this.Lbl_Contraseña = new System.Windows.Forms.Label();
            this.Txt_Contraseña = new System.Windows.Forms.TextBox();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Contraseña
            // 
            this.Lbl_Contraseña.AutoSize = true;
            this.Lbl_Contraseña.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contraseña.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Contraseña.Name = "Lbl_Contraseña";
            this.Lbl_Contraseña.Size = new System.Drawing.Size(122, 15);
            this.Lbl_Contraseña.TabIndex = 5;
            this.Lbl_Contraseña.Text = " Ingrese la contraseña";
            // 
            // Txt_Contraseña
            // 
            this.Txt_Contraseña.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Contraseña.Location = new System.Drawing.Point(12, 30);
            this.Txt_Contraseña.MaxLength = 15;
            this.Txt_Contraseña.Name = "Txt_Contraseña";
            this.Txt_Contraseña.Size = new System.Drawing.Size(220, 33);
            this.Txt_Contraseña.TabIndex = 4;
            this.Txt_Contraseña.UseSystemPasswordChar = true;
            this.Txt_Contraseña.TextChanged += new System.EventHandler(this.Txt_Contraseña_TextChanged);
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_Aceptar.Enabled = false;
            this.Btn_Aceptar.FlatAppearance.BorderSize = 0;
            this.Btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Aceptar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Aceptar.Location = new System.Drawing.Point(12, 69);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(220, 30);
            this.Btn_Aceptar.TabIndex = 6;
            this.Btn_Aceptar.Text = "Ingresar";
            this.Btn_Aceptar.UseVisualStyleBackColor = false;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Frm_Login
            // 
            this.AcceptButton = this.Btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(239, 109);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Lbl_Contraseña);
            this.Controls.Add(this.Txt_Contraseña);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validación de Contraseña";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Contraseña;
        private System.Windows.Forms.TextBox Txt_Contraseña;
        private System.Windows.Forms.Button Btn_Aceptar;
    }
}