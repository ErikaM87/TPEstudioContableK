namespace EstudioContable.interfazForm
{
    partial class FrmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleado));
            this._btnAltaEmpleado = new System.Windows.Forms.Button();
            this._txtIdCategoria = new System.Windows.Forms.TextBox();
            this._txtIdEmpresa = new System.Windows.Forms.TextBox();
            this._txtCuil = new System.Windows.Forms.TextBox();
            this.lblIdEmpresa = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCuil = new System.Windows.Forms.Label();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._txtId = new System.Windows.Forms.TextBox();
            this._txtFechaAlta = new System.Windows.Forms.TextBox();
            this._txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this._txtApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdCategoria = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this._btnConsultaEmpleado = new System.Windows.Forms.Button();
            this.lblVolver = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._lblFormato = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnAltaEmpleado
            // 
            this._btnAltaEmpleado.BackColor = System.Drawing.SystemColors.Highlight;
            this._btnAltaEmpleado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAltaEmpleado.Location = new System.Drawing.Point(345, 181);
            this._btnAltaEmpleado.Name = "_btnAltaEmpleado";
            this._btnAltaEmpleado.Size = new System.Drawing.Size(190, 47);
            this._btnAltaEmpleado.TabIndex = 0;
            this._btnAltaEmpleado.Text = "Alta Empleado";
            this._btnAltaEmpleado.UseVisualStyleBackColor = false;
            this._btnAltaEmpleado.Click += new System.EventHandler(this._btnAltaEmpleado_Clik);
            // 
            // _txtIdCategoria
            // 
            this._txtIdCategoria.Location = new System.Drawing.Point(146, 74);
            this._txtIdCategoria.Name = "_txtIdCategoria";
            this._txtIdCategoria.Size = new System.Drawing.Size(116, 22);
            this._txtIdCategoria.TabIndex = 1;
            this._txtIdCategoria.TextChanged += new System.EventHandler(this._txtIdCategoria_TextChanged);
            // 
            // _txtIdEmpresa
            // 
            this._txtIdEmpresa.Location = new System.Drawing.Point(146, 118);
            this._txtIdEmpresa.Name = "_txtIdEmpresa";
            this._txtIdEmpresa.Size = new System.Drawing.Size(116, 22);
            this._txtIdEmpresa.TabIndex = 2;
            this._txtIdEmpresa.TextChanged += new System.EventHandler(this._txtIdEmpresa_TextChanged);
            // 
            // _txtCuil
            // 
            this._txtCuil.Location = new System.Drawing.Point(146, 163);
            this._txtCuil.Name = "_txtCuil";
            this._txtCuil.Size = new System.Drawing.Size(116, 22);
            this._txtCuil.TabIndex = 3;
            this._txtCuil.TextChanged += new System.EventHandler(this._txtCuil_TextChanged);
            // 
            // lblIdEmpresa
            // 
            this.lblIdEmpresa.AutoSize = true;
            this.lblIdEmpresa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEmpresa.Location = new System.Drawing.Point(24, 125);
            this.lblIdEmpresa.Name = "lblIdEmpresa";
            this.lblIdEmpresa.Size = new System.Drawing.Size(70, 15);
            this.lblIdEmpresa.TabIndex = 4;
            this.lblIdEmpresa.Text = "ID Empresa";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(22, 255);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(52, 15);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido";
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuil.Location = new System.Drawing.Point(24, 170);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(36, 15);
            this.lblCuil.TabIndex = 6;
            this.lblCuil.Text = "CUIL";
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(146, 210);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(116, 22);
            this._txtNombre.TabIndex = 7;
            this._txtNombre.TextChanged += new System.EventHandler(this._txtNombre_TextChanged);
            // 
            // _txtId
            // 
            this._txtId.Location = new System.Drawing.Point(146, 24);
            this._txtId.Name = "_txtId";
            this._txtId.Size = new System.Drawing.Size(85, 22);
            this._txtId.TabIndex = 8;
            this._txtId.TextChanged += new System.EventHandler(this._txtId_TextChanged);
            // 
            // _txtFechaAlta
            // 
            this._txtFechaAlta.Location = new System.Drawing.Point(146, 348);
            this._txtFechaAlta.Name = "_txtFechaAlta";
            this._txtFechaAlta.Size = new System.Drawing.Size(116, 22);
            this._txtFechaAlta.TabIndex = 9;
            this._txtFechaAlta.Validated += new System.EventHandler(this._txtFechaAlta_Validated);
            // 
            // _txtFechaNacimiento
            // 
            this._txtFechaNacimiento.Location = new System.Drawing.Point(146, 302);
            this._txtFechaNacimiento.Name = "_txtFechaNacimiento";
            this._txtFechaNacimiento.Size = new System.Drawing.Size(116, 22);
            this._txtFechaNacimiento.TabIndex = 10;
            this._txtFechaNacimiento.Validated += new System.EventHandler(this._txtFechaNacimiento_Validated);
            // 
            // _txtApellido
            // 
            this._txtApellido.Location = new System.Drawing.Point(146, 255);
            this._txtApellido.Name = "_txtApellido";
            this._txtApellido.Size = new System.Drawing.Size(116, 22);
            this._txtApellido.TabIndex = 11;
            this._txtApellido.TextChanged += new System.EventHandler(this._txtApellido_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(24, 213);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 15);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre";
            // 
            // lblIdCategoria
            // 
            this.lblIdCategoria.AutoSize = true;
            this.lblIdCategoria.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCategoria.Location = new System.Drawing.Point(24, 77);
            this.lblIdCategoria.Name = "lblIdCategoria";
            this.lblIdCategoria.Size = new System.Drawing.Size(77, 15);
            this.lblIdCategoria.TabIndex = 13;
            this.lblIdCategoria.Text = "ID Categoría";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(24, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 15);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "ID";
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAlta.Location = new System.Drawing.Point(22, 351);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(64, 15);
            this.lblFechaAlta.TabIndex = 15;
            this.lblFechaAlta.Text = "Fecha Alta";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(21, 305);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(119, 15);
            this.lblFechaNacimiento.TabIndex = 16;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // _btnConsultaEmpleado
            // 
            this._btnConsultaEmpleado.BackColor = System.Drawing.SystemColors.Highlight;
            this._btnConsultaEmpleado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnConsultaEmpleado.Location = new System.Drawing.Point(345, 10);
            this._btnConsultaEmpleado.Name = "_btnConsultaEmpleado";
            this._btnConsultaEmpleado.Size = new System.Drawing.Size(190, 47);
            this._btnConsultaEmpleado.TabIndex = 17;
            this._btnConsultaEmpleado.Text = "Consulta Empleado";
            this._btnConsultaEmpleado.UseVisualStyleBackColor = false;
            this._btnConsultaEmpleado.Click += new System.EventHandler(this._btnConsultaEmpleado_Click);
            // 
            // lblVolver
            // 
            this.lblVolver.AutoSize = true;
            this.lblVolver.Location = new System.Drawing.Point(596, 321);
            this.lblVolver.Name = "lblVolver";
            this.lblVolver.Size = new System.Drawing.Size(42, 15);
            this.lblVolver.TabIndex = 18;
            this.lblVolver.TabStop = true;
            this.lblVolver.Text = "Volver";
            this.lblVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._btnVolver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(666, 321);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 65);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // _lblFormato
            // 
            this._lblFormato.AutoSize = true;
            this._lblFormato.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblFormato.Location = new System.Drawing.Point(279, 306);
            this._lblFormato.Name = "_lblFormato";
            this._lblFormato.Size = new System.Drawing.Size(132, 14);
            this._lblFormato.TabIndex = 20;
            this._lblFormato.Text = "Formato: \"dd-mm-yyyy\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "Formato: \"dd-mm-yyyy\"";
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(728, 392);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._lblFormato);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblVolver);
            this.Controls.Add(this._btnConsultaEmpleado);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblFechaAlta);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblIdCategoria);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this._txtApellido);
            this.Controls.Add(this._txtFechaNacimiento);
            this.Controls.Add(this._txtFechaAlta);
            this.Controls.Add(this._txtId);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this.lblCuil);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblIdEmpresa);
            this.Controls.Add(this._txtCuil);
            this.Controls.Add(this._txtIdEmpresa);
            this.Controls.Add(this._txtIdCategoria);
            this.Controls.Add(this._btnAltaEmpleado);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmEmpleado";
            this.Text = "EMPLEADOS";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnAltaEmpleado;
        private System.Windows.Forms.TextBox _txtIdCategoria;
        private System.Windows.Forms.TextBox _txtIdEmpresa;
        private System.Windows.Forms.TextBox _txtCuil;
        private System.Windows.Forms.Label lblIdEmpresa;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCuil;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.TextBox _txtId;
        private System.Windows.Forms.TextBox _txtFechaAlta;
        private System.Windows.Forms.TextBox _txtFechaNacimiento;
        private System.Windows.Forms.TextBox _txtApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdCategoria;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Button _btnConsultaEmpleado;
        private System.Windows.Forms.LinkLabel lblVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label _lblFormato;
        private System.Windows.Forms.Label label1;
    }
}