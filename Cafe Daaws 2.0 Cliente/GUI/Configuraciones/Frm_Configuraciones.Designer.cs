namespace Cafe_Daaws_2._0_Cliente.GUI.Configuraciones
{
    partial class Frm_Configuraciones
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
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Pnl_Automatico = new System.Windows.Forms.Panel();
            this.Pnl_Manual = new System.Windows.Forms.Panel();
            this.Btn_Manual = new System.Windows.Forms.Button();
            this.Btn_Automatico = new System.Windows.Forms.Button();
            this.Lbl_SelEquipo = new System.Windows.Forms.Label();
            this.Cmb_Equipos = new System.Windows.Forms.ComboBox();
            this.Lbl_TitIp = new System.Windows.Forms.Label();
            this.Lbl_ValIp = new System.Windows.Forms.Label();
            this.Lbl_IngresaHost = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Btn_Desconectar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Pnl_Automatico.SuspendLayout();
            this.Pnl_Manual.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.Location = new System.Drawing.Point(366, 2);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(24, 27);
            this.Btn_Cerrar.TabIndex = 8;
            this.Btn_Cerrar.Text = "X";
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Pnl_Automatico
            // 
            this.Pnl_Automatico.Controls.Add(this.Lbl_ValIp);
            this.Pnl_Automatico.Controls.Add(this.Lbl_TitIp);
            this.Pnl_Automatico.Controls.Add(this.Cmb_Equipos);
            this.Pnl_Automatico.Controls.Add(this.Lbl_SelEquipo);
            this.Pnl_Automatico.Controls.Add(this.Btn_Automatico);
            this.Pnl_Automatico.Location = new System.Drawing.Point(10, 55);
            this.Pnl_Automatico.Name = "Pnl_Automatico";
            this.Pnl_Automatico.Size = new System.Drawing.Size(183, 112);
            this.Pnl_Automatico.TabIndex = 9;
            this.Pnl_Automatico.Tag = "2";
            // 
            // Pnl_Manual
            // 
            this.Pnl_Manual.Controls.Add(this.Txt_Nombre);
            this.Pnl_Manual.Controls.Add(this.Lbl_IngresaHost);
            this.Pnl_Manual.Controls.Add(this.Btn_Manual);
            this.Pnl_Manual.Location = new System.Drawing.Point(199, 55);
            this.Pnl_Manual.Name = "Pnl_Manual";
            this.Pnl_Manual.Size = new System.Drawing.Size(183, 112);
            this.Pnl_Manual.TabIndex = 10;
            this.Pnl_Manual.Tag = "1";
            // 
            // Btn_Manual
            // 
            this.Btn_Manual.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_Manual.FlatAppearance.BorderSize = 0;
            this.Btn_Manual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Manual.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Manual.Location = new System.Drawing.Point(3, 3);
            this.Btn_Manual.Name = "Btn_Manual";
            this.Btn_Manual.Size = new System.Drawing.Size(177, 25);
            this.Btn_Manual.TabIndex = 1;
            this.Btn_Manual.Text = "Configuración Manual";
            this.Btn_Manual.UseVisualStyleBackColor = false;
            this.Btn_Manual.Click += new System.EventHandler(this.Btn_Manual_Click);
            // 
            // Btn_Automatico
            // 
            this.Btn_Automatico.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_Automatico.FlatAppearance.BorderSize = 0;
            this.Btn_Automatico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Automatico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Automatico.Location = new System.Drawing.Point(3, 3);
            this.Btn_Automatico.Name = "Btn_Automatico";
            this.Btn_Automatico.Size = new System.Drawing.Size(177, 25);
            this.Btn_Automatico.TabIndex = 2;
            this.Btn_Automatico.Text = "Configuración Automática";
            this.Btn_Automatico.UseVisualStyleBackColor = false;
            this.Btn_Automatico.Click += new System.EventHandler(this.Btn_Manual_Click);
            // 
            // Lbl_SelEquipo
            // 
            this.Lbl_SelEquipo.AutoSize = true;
            this.Lbl_SelEquipo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SelEquipo.Location = new System.Drawing.Point(5, 36);
            this.Lbl_SelEquipo.Name = "Lbl_SelEquipo";
            this.Lbl_SelEquipo.Size = new System.Drawing.Size(106, 13);
            this.Lbl_SelEquipo.TabIndex = 3;
            this.Lbl_SelEquipo.Text = "Seleccione el servidor";
            // 
            // Cmb_Equipos
            // 
            this.Cmb_Equipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Equipos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Equipos.FormattingEnabled = true;
            this.Cmb_Equipos.Location = new System.Drawing.Point(5, 52);
            this.Cmb_Equipos.Name = "Cmb_Equipos";
            this.Cmb_Equipos.Size = new System.Drawing.Size(174, 25);
            this.Cmb_Equipos.TabIndex = 4;
            this.Cmb_Equipos.SelectedIndexChanged += new System.EventHandler(this.Cmb_Equipos_SelectedIndexChanged);
            // 
            // Lbl_TitIp
            // 
            this.Lbl_TitIp.AutoSize = true;
            this.Lbl_TitIp.Location = new System.Drawing.Point(6, 82);
            this.Lbl_TitIp.Name = "Lbl_TitIp";
            this.Lbl_TitIp.Size = new System.Drawing.Size(17, 15);
            this.Lbl_TitIp.TabIndex = 5;
            this.Lbl_TitIp.Text = "IP";
            // 
            // Lbl_ValIp
            // 
            this.Lbl_ValIp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ValIp.Location = new System.Drawing.Point(28, 80);
            this.Lbl_ValIp.Name = "Lbl_ValIp";
            this.Lbl_ValIp.Size = new System.Drawing.Size(128, 19);
            this.Lbl_ValIp.TabIndex = 6;
            this.Lbl_ValIp.Text = ". . .";
            // 
            // Lbl_IngresaHost
            // 
            this.Lbl_IngresaHost.AutoSize = true;
            this.Lbl_IngresaHost.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IngresaHost.Location = new System.Drawing.Point(3, 36);
            this.Lbl_IngresaHost.Name = "Lbl_IngresaHost";
            this.Lbl_IngresaHost.Size = new System.Drawing.Size(147, 13);
            this.Lbl_IngresaHost.TabIndex = 7;
            this.Lbl_IngresaHost.Text = "Ingrese el nombre del servidor";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre.Location = new System.Drawing.Point(6, 52);
            this.Txt_Nombre.MaxLength = 25;
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(174, 25);
            this.Txt_Nombre.TabIndex = 8;
            // 
            // Btn_Desconectar
            // 
            this.Btn_Desconectar.BackColor = System.Drawing.Color.Tomato;
            this.Btn_Desconectar.FlatAppearance.BorderSize = 0;
            this.Btn_Desconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Desconectar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Desconectar.Image = global::Cafe_Daaws_2._0_Cliente.Properties.Resources.Blocked;
            this.Btn_Desconectar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Desconectar.Location = new System.Drawing.Point(180, 173);
            this.Btn_Desconectar.Name = "Btn_Desconectar";
            this.Btn_Desconectar.Size = new System.Drawing.Size(202, 30);
            this.Btn_Desconectar.TabIndex = 13;
            this.Btn_Desconectar.Text = "Desconectar del Servidor";
            this.Btn_Desconectar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Desconectar.UseVisualStyleBackColor = false;
            this.Btn_Desconectar.Click += new System.EventHandler(this.Btn_Desconectar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Salir.FlatAppearance.BorderSize = 0;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Image = global::Cafe_Daaws_2._0_Cliente.Properties.Resources.Closed;
            this.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Salir.Location = new System.Drawing.Point(285, 218);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(105, 30);
            this.Btn_Salir.TabIndex = 12;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Guardar.FlatAppearance.BorderSize = 0;
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.Image = global::Cafe_Daaws_2._0_Cliente.Properties.Resources.Floppy;
            this.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar.Location = new System.Drawing.Point(173, 218);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(105, 30);
            this.Btn_Guardar.TabIndex = 11;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Image = global::Cafe_Daaws_2._0_Cliente.Properties.Resources.Control_Panel;
            this.Lbl_Titulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Titulo.Location = new System.Drawing.Point(5, 3);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(247, 35);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Panel de Administración";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Frm_Configuraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(393, 253);
            this.Controls.Add(this.Btn_Desconectar);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Pnl_Manual);
            this.Controls.Add(this.Pnl_Automatico);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Lbl_Titulo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Configuraciones";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_Configuraciones_Load);
            this.Pnl_Automatico.ResumeLayout(false);
            this.Pnl_Automatico.PerformLayout();
            this.Pnl_Manual.ResumeLayout(false);
            this.Pnl_Manual.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Panel Pnl_Automatico;
        private System.Windows.Forms.Panel Pnl_Manual;
        private System.Windows.Forms.Button Btn_Manual;
        private System.Windows.Forms.Button Btn_Automatico;
        private System.Windows.Forms.Label Lbl_SelEquipo;
        private System.Windows.Forms.ComboBox Cmb_Equipos;
        private System.Windows.Forms.Label Lbl_TitIp;
        private System.Windows.Forms.Label Lbl_ValIp;
        private System.Windows.Forms.Label Lbl_IngresaHost;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Desconectar;
    }
}