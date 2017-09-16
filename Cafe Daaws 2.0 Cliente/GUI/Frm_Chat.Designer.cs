namespace Cafe_Daaws_2._0_Cliente.GUI
{
    partial class Frm_Chat
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
            this.Rtb_Mensajes = new System.Windows.Forms.RichTextBox();
            this.Txt_Mensaje = new System.Windows.Forms.TextBox();
            this.Btn_Enviar = new System.Windows.Forms.Button();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rtb_Mensajes
            // 
            this.Rtb_Mensajes.Location = new System.Drawing.Point(12, 26);
            this.Rtb_Mensajes.Name = "Rtb_Mensajes";
            this.Rtb_Mensajes.ReadOnly = true;
            this.Rtb_Mensajes.Size = new System.Drawing.Size(244, 153);
            this.Rtb_Mensajes.TabIndex = 0;
            this.Rtb_Mensajes.Text = "";
            this.Rtb_Mensajes.TextChanged += new System.EventHandler(this.Rtb_Mensajes_TextChanged);
            // 
            // Txt_Mensaje
            // 
            this.Txt_Mensaje.Location = new System.Drawing.Point(12, 185);
            this.Txt_Mensaje.Multiline = true;
            this.Txt_Mensaje.Name = "Txt_Mensaje";
            this.Txt_Mensaje.Size = new System.Drawing.Size(163, 44);
            this.Txt_Mensaje.TabIndex = 1;
            this.Txt_Mensaje.TextChanged += new System.EventHandler(this.Txt_Mensaje_TextChanged);
            // 
            // Btn_Enviar
            // 
            this.Btn_Enviar.FlatAppearance.BorderSize = 0;
            this.Btn_Enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Enviar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Enviar.Image = global::Cafe_Daaws_2._0_Cliente.Properties.Resources.Letter_Closed;
            this.Btn_Enviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Enviar.Location = new System.Drawing.Point(176, 185);
            this.Btn_Enviar.Name = "Btn_Enviar";
            this.Btn_Enviar.Size = new System.Drawing.Size(80, 44);
            this.Btn_Enviar.TabIndex = 4;
            this.Btn_Enviar.Text = "Enviar";
            this.Btn_Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Enviar.UseVisualStyleBackColor = true;
            this.Btn_Enviar.Click += new System.EventHandler(this.Btn_Enviar_Click);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(8, 3);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(67, 20);
            this.Lbl_Titulo.TabIndex = 5;
            this.Lbl_Titulo.Text = "Mensajes";
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.Location = new System.Drawing.Point(237, 0);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(31, 23);
            this.Btn_Cerrar.TabIndex = 6;
            this.Btn_Cerrar.Text = "X";
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Frm_Chat
            // 
            this.AcceptButton = this.Btn_Enviar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(268, 237);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Btn_Enviar);
            this.Controls.Add(this.Txt_Mensaje);
            this.Controls.Add(this.Rtb_Mensajes);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Chat_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Rtb_Mensajes;
        private System.Windows.Forms.TextBox Txt_Mensaje;
        private System.Windows.Forms.Button Btn_Enviar;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Button Btn_Cerrar;
    }
}