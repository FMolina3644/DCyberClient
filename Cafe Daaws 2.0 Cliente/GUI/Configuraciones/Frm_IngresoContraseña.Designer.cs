namespace Cafe_Daaws_2._0_Cliente.GUI
{
    partial class Frm_IngresoContraseña
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
            this.Lbl_Tip = new System.Windows.Forms.Label();
            this.Txt_Contraseña = new System.Windows.Forms.TextBox();
            this.Txt_ConfContraseña = new System.Windows.Forms.TextBox();
            this.Lbl_Contraseña = new System.Windows.Forms.Label();
            this.Lbl_ConfContraseña = new System.Windows.Forms.Label();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Tip
            // 
            this.Lbl_Tip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_Tip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tip.Location = new System.Drawing.Point(4, 3);
            this.Lbl_Tip.Name = "Lbl_Tip";
            this.Lbl_Tip.Size = new System.Drawing.Size(260, 41);
            this.Lbl_Tip.TabIndex = 0;
            this.Lbl_Tip.Text = "Es la primera vez que ingresa al panel de configuración, debe ingresar una contra" +
    "seña";
            // 
            // Txt_Contraseña
            // 
            this.Txt_Contraseña.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Contraseña.Location = new System.Drawing.Point(7, 71);
            this.Txt_Contraseña.MaxLength = 15;
            this.Txt_Contraseña.Name = "Txt_Contraseña";
            this.Txt_Contraseña.Size = new System.Drawing.Size(257, 33);
            this.Txt_Contraseña.TabIndex = 1;
            this.Txt_Contraseña.UseSystemPasswordChar = true;
            this.Txt_Contraseña.TextChanged += new System.EventHandler(this.Txt_Contraseña_TextChanged);
            // 
            // Txt_ConfContraseña
            // 
            this.Txt_ConfContraseña.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ConfContraseña.Location = new System.Drawing.Point(7, 129);
            this.Txt_ConfContraseña.MaxLength = 15;
            this.Txt_ConfContraseña.Name = "Txt_ConfContraseña";
            this.Txt_ConfContraseña.Size = new System.Drawing.Size(257, 33);
            this.Txt_ConfContraseña.TabIndex = 2;
            this.Txt_ConfContraseña.UseSystemPasswordChar = true;
            this.Txt_ConfContraseña.TextChanged += new System.EventHandler(this.Txt_Contraseña_TextChanged);
            // 
            // Lbl_Contraseña
            // 
            this.Lbl_Contraseña.AutoSize = true;
            this.Lbl_Contraseña.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contraseña.Location = new System.Drawing.Point(4, 53);
            this.Lbl_Contraseña.Name = "Lbl_Contraseña";
            this.Lbl_Contraseña.Size = new System.Drawing.Size(68, 15);
            this.Lbl_Contraseña.TabIndex = 3;
            this.Lbl_Contraseña.Text = "Contraseña";
            // 
            // Lbl_ConfContraseña
            // 
            this.Lbl_ConfContraseña.AutoSize = true;
            this.Lbl_ConfContraseña.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ConfContraseña.Location = new System.Drawing.Point(4, 111);
            this.Lbl_ConfContraseña.Name = "Lbl_ConfContraseña";
            this.Lbl_ConfContraseña.Size = new System.Drawing.Size(129, 15);
            this.Lbl_ConfContraseña.TabIndex = 4;
            this.Lbl_ConfContraseña.Text = "Confirme la contraseña";
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Salir.FlatAppearance.BorderSize = 0;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Image = global::Cafe_Daaws_2._0_Cliente.Properties.Resources.Closed;
            this.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Salir.Location = new System.Drawing.Point(139, 168);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(125, 30);
            this.Btn_Salir.TabIndex = 6;
            this.Btn_Salir.Text = "Cancelar";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Aceptar.Enabled = false;
            this.Btn_Aceptar.FlatAppearance.BorderSize = 0;
            this.Btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Aceptar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aceptar.Image = global::Cafe_Daaws_2._0_Cliente.Properties.Resources.Floppy;
            this.Btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Aceptar.Location = new System.Drawing.Point(12, 168);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(121, 30);
            this.Btn_Aceptar.TabIndex = 5;
            this.Btn_Aceptar.Text = "Guardar";
            this.Btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Aceptar.UseVisualStyleBackColor = false;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Frm_IngresoContraseña
            // 
            this.AcceptButton = this.Btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(271, 206);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Lbl_ConfContraseña);
            this.Controls.Add(this.Lbl_Contraseña);
            this.Controls.Add(this.Txt_ConfContraseña);
            this.Controls.Add(this.Txt_Contraseña);
            this.Controls.Add(this.Lbl_Tip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_IngresoContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametro de Configuración";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_IngresoContraseña_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Tip;
        private System.Windows.Forms.TextBox Txt_Contraseña;
        private System.Windows.Forms.TextBox Txt_ConfContraseña;
        private System.Windows.Forms.Label Lbl_Contraseña;
        private System.Windows.Forms.Label Lbl_ConfContraseña;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Salir;
    }
}