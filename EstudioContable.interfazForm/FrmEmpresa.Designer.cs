namespace EstudioContable.interfazForm
{
    partial class FrmEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpresa));
            this._btnConsultaEmpresa = new System.Windows.Forms.Button();
            this._txtRazonSocial = new System.Windows.Forms.TextBox();
            this._txtCuit = new System.Windows.Forms.TextBox();
            this._txtDomicilio = new System.Windows.Forms.TextBox();
            this._txtFechaAlta = new System.Windows.Forms.TextBox();
            this._txtId = new System.Windows.Forms.TextBox();
            this._txtUsuario = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this._btnAltaEmpresa = new System.Windows.Forms.Button();
            this._btnVolver = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnConsultaEmpresa
            // 
            this._btnConsultaEmpresa.BackColor = System.Drawing.SystemColors.Highlight;
            this._btnConsultaEmpresa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnConsultaEmpresa.Location = new System.Drawing.Point(318, 3);
            this._btnConsultaEmpresa.Name = "_btnConsultaEmpresa";
            this._btnConsultaEmpresa.Size = new System.Drawing.Size(167, 50);
            this._btnConsultaEmpresa.TabIndex = 0;
            this._btnConsultaEmpresa.Text = "Consulta Empresa";
            this._btnConsultaEmpresa.UseVisualStyleBackColor = false;
            this._btnConsultaEmpresa.Click += new System.EventHandler(this._btnConsultaEmpresa_Click);
            // 
            // _txtRazonSocial
            // 
            this._txtRazonSocial.Location = new System.Drawing.Point(123, 89);
            this._txtRazonSocial.Name = "_txtRazonSocial";
            this._txtRazonSocial.Size = new System.Drawing.Size(139, 20);
            this._txtRazonSocial.TabIndex = 1;
            // 
            // _txtCuit
            // 
            this._txtCuit.Location = new System.Drawing.Point(123, 135);
            this._txtCuit.Name = "_txtCuit";
            this._txtCuit.Size = new System.Drawing.Size(139, 20);
            this._txtCuit.TabIndex = 2;
            // 
            // _txtDomicilio
            // 
            this._txtDomicilio.Location = new System.Drawing.Point(123, 181);
            this._txtDomicilio.Name = "_txtDomicilio";
            this._txtDomicilio.Size = new System.Drawing.Size(139, 20);
            this._txtDomicilio.TabIndex = 3;
            // 
            // _txtFechaAlta
            // 
            this._txtFechaAlta.Location = new System.Drawing.Point(123, 231);
            this._txtFechaAlta.Name = "_txtFechaAlta";
            this._txtFechaAlta.Size = new System.Drawing.Size(139, 20);
            this._txtFechaAlta.TabIndex = 4;
            // 
            // _txtId
            // 
            this._txtId.Location = new System.Drawing.Point(123, 20);
            this._txtId.Name = "_txtId";
            this._txtId.Size = new System.Drawing.Size(73, 20);
            this._txtId.TabIndex = 5;
            // 
            // _txtUsuario
            // 
            this._txtUsuario.Location = new System.Drawing.Point(123, 279);
            this._txtUsuario.Name = "_txtUsuario";
            this._txtUsuario.Size = new System.Drawing.Size(139, 20);
            this._txtUsuario.TabIndex = 6;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(24, 92);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(78, 15);
            this.lblRazonSocial.TabIndex = 7;
            this.lblRazonSocial.Text = "Razón Social";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuit.Location = new System.Drawing.Point(24, 140);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(31, 15);
            this.lblCuit.TabIndex = 8;
            this.lblCuit.Text = "Cuit";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.Location = new System.Drawing.Point(24, 183);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(60, 15);
            this.lblDomicilio.TabIndex = 9;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAlta.Location = new System.Drawing.Point(24, 236);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(64, 15);
            this.lblFechaAlta.TabIndex = 10;
            this.lblFechaAlta.Text = "Fecha Alta";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(24, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 15);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "ID";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(24, 284);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 15);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuario";
            // 
            // _btnAltaEmpresa
            // 
            this._btnAltaEmpresa.BackColor = System.Drawing.SystemColors.Highlight;
            this._btnAltaEmpresa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAltaEmpresa.Location = new System.Drawing.Point(318, 135);
            this._btnAltaEmpresa.Name = "_btnAltaEmpresa";
            this._btnAltaEmpresa.Size = new System.Drawing.Size(167, 48);
            this._btnAltaEmpresa.TabIndex = 13;
            this._btnAltaEmpresa.Text = "Alta Empresa";
            this._btnAltaEmpresa.UseVisualStyleBackColor = false;
            this._btnAltaEmpresa.Click += new System.EventHandler(this._btnAltaEmpresa_Click);
            // 
            // _btnVolver
            // 
            this._btnVolver.AutoSize = true;
            this._btnVolver.Location = new System.Drawing.Point(448, 252);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(37, 13);
            this._btnVolver.TabIndex = 14;
            this._btnVolver.TabStop = true;
            this._btnVolver.Text = "Volver";
            this._btnVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._btnVolver_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(552, 264);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 66);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(624, 342);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._btnAltaEmpresa);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblFechaAlta);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this._txtUsuario);
            this.Controls.Add(this._txtId);
            this.Controls.Add(this._txtFechaAlta);
            this.Controls.Add(this._txtDomicilio);
            this.Controls.Add(this._txtCuit);
            this.Controls.Add(this._txtRazonSocial);
            this.Controls.Add(this._btnConsultaEmpresa);
            this.Name = "FrmEmpresa";
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.FrmEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnConsultaEmpresa;
        private System.Windows.Forms.TextBox _txtRazonSocial;
        private System.Windows.Forms.TextBox _txtCuit;
        private System.Windows.Forms.TextBox _txtDomicilio;
        private System.Windows.Forms.TextBox _txtFechaAlta;
        private System.Windows.Forms.TextBox _txtId;
        private System.Windows.Forms.TextBox _txtUsuario;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button _btnAltaEmpresa;
        private System.Windows.Forms.LinkLabel _btnVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}