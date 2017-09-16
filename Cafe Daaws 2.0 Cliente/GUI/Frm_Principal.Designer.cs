namespace Cafe_Daaws_2._0_Cliente
{
    partial class Frm_Principal
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
            this.components = new System.ComponentModel.Container();
            this.Lbl_TitRazonSocial = new System.Windows.Forms.Label();
            this.Tmr_Conexion = new System.Windows.Forms.Timer(this.components);
            this.Lbl_Tiempo = new System.Windows.Forms.Label();
            this.Tmr_RecibirOrdenes = new System.Windows.Forms.Timer(this.components);
            this.Tmr_Bloquear = new System.Windows.Forms.Timer(this.components);
            this.Lbl_Contador = new System.Windows.Forms.Label();
            this.Pnl_Contador = new System.Windows.Forms.Panel();
            this.Ptb_Contador = new System.Windows.Forms.PictureBox();
            this.Btn_Chat = new System.Windows.Forms.Button();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Tmr_Cronos = new System.Windows.Forms.Timer(this.components);
            this.Tmr_BuscarConex = new System.Windows.Forms.Timer(this.components);
            this.Pnl_Contador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Contador)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_TitRazonSocial
            // 
            this.Lbl_TitRazonSocial.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Lbl_TitRazonSocial.AutoSize = true;
            this.Lbl_TitRazonSocial.Font = new System.Drawing.Font("Segoe WP Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitRazonSocial.Location = new System.Drawing.Point(222, 243);
            this.Lbl_TitRazonSocial.Name = "Lbl_TitRazonSocial";
            this.Lbl_TitRazonSocial.Size = new System.Drawing.Size(69, 50);
            this.Lbl_TitRazonSocial.TabIndex = 0;
            this.Lbl_TitRazonSocial.Text = ". . .";
            // 
            // Tmr_Conexion
            // 
            this.Tmr_Conexion.Tick += new System.EventHandler(this.Tmr_Conexion_Tick);
            // 
            // Lbl_Tiempo
            // 
            this.Lbl_Tiempo.AutoSize = true;
            this.Lbl_Tiempo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tiempo.Location = new System.Drawing.Point(12, 6);
            this.Lbl_Tiempo.Name = "Lbl_Tiempo";
            this.Lbl_Tiempo.Size = new System.Drawing.Size(34, 25);
            this.Lbl_Tiempo.TabIndex = 1;
            this.Lbl_Tiempo.Text = ". . .";
            // 
            // Tmr_RecibirOrdenes
            // 
            this.Tmr_RecibirOrdenes.Tick += new System.EventHandler(this.Tmr_RecibirOrdenes_Tick);
            // 
            // Tmr_Bloquear
            // 
            this.Tmr_Bloquear.Interval = 10;
            this.Tmr_Bloquear.Tick += new System.EventHandler(this.Tmr_Bloquear_Tick);
            // 
            // Lbl_Contador
            // 
            this.Lbl_Contador.AutoSize = true;
            this.Lbl_Contador.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contador.Location = new System.Drawing.Point(36, 5);
            this.Lbl_Contador.Name = "Lbl_Contador";
            this.Lbl_Contador.Size = new System.Drawing.Size(34, 25);
            this.Lbl_Contador.TabIndex = 4;
            this.Lbl_Contador.Text = ". . .";
            // 
            // Pnl_Contador
            // 
            this.Pnl_Contador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Contador.Controls.Add(this.Ptb_Contador);
            this.Pnl_Contador.Controls.Add(this.Lbl_Contador);
            this.Pnl_Contador.Location = new System.Drawing.Point(293, 0);
            this.Pnl_Contador.Name = "Pnl_Contador";
            this.Pnl_Contador.Size = new System.Drawing.Size(134, 38);
            this.Pnl_Contador.TabIndex = 5;
            // 
            // Ptb_Contador
            // 
            this.Ptb_Contador.Image = global::Cafe_Daaws_2._0_Cliente.Properties.Resources.Clock;
            this.Ptb_Contador.Location = new System.Drawing.Point(3, 3);
            this.Ptb_Contador.Name = "Ptb_Contador";
            this.Ptb_Contador.Size = new System.Drawing.Size(30, 30);
            this.Ptb_Contador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ptb_Contador.TabIndex = 6;
            this.Ptb_Contador.TabStop = false;
            // 
            // Btn_Chat
            // 
            this.Btn_Chat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Chat.BackColor = System.Drawing.Color.LightBlue;
            this.Btn_Chat.FlatAppearance.BorderSize = 0;
            this.Btn_Chat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Chat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Chat.Image = global::Cafe_Daaws_2._0_Cliente.Properties.Resources.Letter_Closed;
            this.Btn_Chat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Chat.Location = new System.Drawing.Point(569, 1);
            this.Btn_Chat.Name = "Btn_Chat";
            this.Btn_Chat.Size = new System.Drawing.Size(79, 30);
            this.Btn_Chat.TabIndex = 3;
            this.Btn_Chat.Text = "Chat";
            this.Btn_Chat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Chat.UseVisualStyleBackColor = false;
            this.Btn_Chat.Click += new System.EventHandler(this.Btn_Chat_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cerrar.BackColor = System.Drawing.Color.LightBlue;
            this.Btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.Image = global::Cafe_Daaws_2._0_Cliente.Properties.Resources.Closed;
            this.Btn_Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cerrar.Location = new System.Drawing.Point(650, 1);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(79, 30);
            this.Btn_Cerrar.TabIndex = 2;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Tmr_Cronos
            // 
            this.Tmr_Cronos.Interval = 1000;
            this.Tmr_Cronos.Tick += new System.EventHandler(this.Tmr_Cronos_Tick);
            // 
            // Tmr_BuscarConex
            // 
            this.Tmr_BuscarConex.Interval = 1000;
            this.Tmr_BuscarConex.Tick += new System.EventHandler(this.Tmr_BuscarConex_Tick);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 302);
            this.Controls.Add(this.Pnl_Contador);
            this.Controls.Add(this.Btn_Chat);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Lbl_Tiempo);
            this.Controls.Add(this.Lbl_TitRazonSocial);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Principal";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Info;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Principal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Principal_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Frm_Principal_KeyUp);
            this.Pnl_Contador.ResumeLayout(false);
            this.Pnl_Contador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Contador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_TitRazonSocial;
        private System.Windows.Forms.Timer Tmr_Conexion;
        private System.Windows.Forms.Label Lbl_Tiempo;
        private System.Windows.Forms.Timer Tmr_RecibirOrdenes;
        private System.Windows.Forms.Timer Tmr_Bloquear;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Button Btn_Chat;
        private System.Windows.Forms.Label Lbl_Contador;
        private System.Windows.Forms.Panel Pnl_Contador;
        private System.Windows.Forms.PictureBox Ptb_Contador;
        private System.Windows.Forms.Timer Tmr_Cronos;
        private System.Windows.Forms.Timer Tmr_BuscarConex;
    }
}

