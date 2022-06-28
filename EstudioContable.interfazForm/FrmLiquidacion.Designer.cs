namespace EstudioContable.interfazForm
{
    partial class FrmLiquidacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLiquidacion));
            this._btnConsultarLiquidacion = new System.Windows.Forms.Button();
            this._btnAltaLiquidación = new System.Windows.Forms.Button();
            this._txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this._txtIdEmpleado = new System.Windows.Forms.TextBox();
            this._txtPeriodo = new System.Windows.Forms.TextBox();
            this._txtBruto = new System.Windows.Forms.TextBox();
            this._txtCodigoTransferencia = new System.Windows.Forms.TextBox();
            this._txtFechaAlta = new System.Windows.Forms.TextBox();
            this._txtDescuentos = new System.Windows.Forms.TextBox();
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblCodigoTransferencia = new System.Windows.Forms.Label();
            this.lblBruto = new System.Windows.Forms.Label();
            this.lblDescuentos = new System.Windows.Forms.Label();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.lblVolver = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._lblFormato = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnConsultarLiquidacion
            // 
            this._btnConsultarLiquidacion.BackColor = System.Drawing.SystemColors.Highlight;
            this._btnConsultarLiquidacion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnConsultarLiquidacion.Location = new System.Drawing.Point(379, 3);
            this._btnConsultarLiquidacion.Name = "_btnConsultarLiquidacion";
            this._btnConsultarLiquidacion.Size = new System.Drawing.Size(194, 51);
            this._btnConsultarLiquidacion.TabIndex = 0;
            this._btnConsultarLiquidacion.Text = "Consultar Liquidación";
            this._btnConsultarLiquidacion.UseVisualStyleBackColor = false;
            this._btnConsultarLiquidacion.Click += new System.EventHandler(this._btnConsultarLiquidacion_Click);
            // 
            // _btnAltaLiquidación
            // 
            this._btnAltaLiquidación.BackColor = System.Drawing.SystemColors.Highlight;
            this._btnAltaLiquidación.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAltaLiquidación.Location = new System.Drawing.Point(379, 146);
            this._btnAltaLiquidación.Name = "_btnAltaLiquidación";
            this._btnAltaLiquidación.Size = new System.Drawing.Size(194, 48);
            this._btnAltaLiquidación.TabIndex = 1;
            this._btnAltaLiquidación.Text = "Alta Liquidación";
            this._btnAltaLiquidación.UseVisualStyleBackColor = false;
            this._btnAltaLiquidación.Click += new System.EventHandler(this._btnAltaLiquidación_Click);
            // 
            // _txtId
            // 
            this._txtId.Location = new System.Drawing.Point(171, 15);
            this._txtId.Name = "_txtId";
            this._txtId.Size = new System.Drawing.Size(72, 22);
            this._txtId.TabIndex = 2;
            this._txtId.TextChanged += new System.EventHandler(this._txtId_TextChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(38, 22);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 15);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "ID";
            // 
            // _txtIdEmpleado
            // 
            this._txtIdEmpleado.Location = new System.Drawing.Point(171, 67);
            this._txtIdEmpleado.Name = "_txtIdEmpleado";
            this._txtIdEmpleado.Size = new System.Drawing.Size(116, 22);
            this._txtIdEmpleado.TabIndex = 4;
            this._txtIdEmpleado.TextChanged += new System.EventHandler(this._txtIdEmpleado_TextChanged);
            // 
            // _txtPeriodo
            // 
            this._txtPeriodo.Location = new System.Drawing.Point(171, 119);
            this._txtPeriodo.Name = "_txtPeriodo";
            this._txtPeriodo.Size = new System.Drawing.Size(116, 22);
            this._txtPeriodo.TabIndex = 5;
            this._txtPeriodo.TextChanged += new System.EventHandler(this._txtPeriodo_TextChanged);
            // 
            // _txtBruto
            // 
            this._txtBruto.Location = new System.Drawing.Point(171, 211);
            this._txtBruto.Name = "_txtBruto";
            this._txtBruto.Size = new System.Drawing.Size(116, 22);
            this._txtBruto.TabIndex = 6;
            this._txtBruto.TextChanged += new System.EventHandler(this._txtBruto_TextChanged);
            // 
            // _txtCodigoTransferencia
            // 
            this._txtCodigoTransferencia.Location = new System.Drawing.Point(171, 164);
            this._txtCodigoTransferencia.Name = "_txtCodigoTransferencia";
            this._txtCodigoTransferencia.Size = new System.Drawing.Size(116, 22);
            this._txtCodigoTransferencia.TabIndex = 7;
            // 
            // _txtFechaAlta
            // 
            this._txtFechaAlta.Location = new System.Drawing.Point(171, 312);
            this._txtFechaAlta.Name = "_txtFechaAlta";
            this._txtFechaAlta.Size = new System.Drawing.Size(116, 22);
            this._txtFechaAlta.TabIndex = 8;
            this._txtFechaAlta.Validated += new System.EventHandler(this._txtFechaAlta_Validated);
            // 
            // _txtDescuentos
            // 
            this._txtDescuentos.Location = new System.Drawing.Point(171, 262);
            this._txtDescuentos.Name = "_txtDescuentos";
            this._txtDescuentos.Size = new System.Drawing.Size(116, 22);
            this._txtDescuentos.TabIndex = 9;
            this._txtDescuentos.TextChanged += new System.EventHandler(this._txtDescuentos_TextChanged);
            // 
            // lblIdEmpleado
            // 
            this.lblIdEmpleado.AutoSize = true;
            this.lblIdEmpleado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEmpleado.Location = new System.Drawing.Point(38, 70);
            this.lblIdEmpleado.Name = "lblIdEmpleado";
            this.lblIdEmpleado.Size = new System.Drawing.Size(74, 15);
            this.lblIdEmpleado.TabIndex = 10;
            this.lblIdEmpleado.Text = "ID Empleado";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(38, 122);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(49, 15);
            this.lblPeriodo.TabIndex = 11;
            this.lblPeriodo.Text = "Período";
            // 
            // lblCodigoTransferencia
            // 
            this.lblCodigoTransferencia.AutoSize = true;
            this.lblCodigoTransferencia.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoTransferencia.Location = new System.Drawing.Point(38, 164);
            this.lblCodigoTransferencia.Name = "lblCodigoTransferencia";
            this.lblCodigoTransferencia.Size = new System.Drawing.Size(125, 15);
            this.lblCodigoTransferencia.TabIndex = 12;
            this.lblCodigoTransferencia.Text = "Código Transferencia";
            // 
            // lblBruto
            // 
            this.lblBruto.AutoSize = true;
            this.lblBruto.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBruto.Location = new System.Drawing.Point(38, 214);
            this.lblBruto.Name = "lblBruto";
            this.lblBruto.Size = new System.Drawing.Size(39, 15);
            this.lblBruto.TabIndex = 13;
            this.lblBruto.Text = "Bruto";
            // 
            // lblDescuentos
            // 
            this.lblDescuentos.AutoSize = true;
            this.lblDescuentos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuentos.Location = new System.Drawing.Point(38, 265);
            this.lblDescuentos.Name = "lblDescuentos";
            this.lblDescuentos.Size = new System.Drawing.Size(70, 15);
            this.lblDescuentos.TabIndex = 14;
            this.lblDescuentos.Text = "Descuentos";
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAlta.Location = new System.Drawing.Point(38, 312);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(64, 15);
            this.lblFechaAlta.TabIndex = 15;
            this.lblFechaAlta.Text = "Fecha Alta";
            // 
            // lblVolver
            // 
            this.lblVolver.AutoSize = true;
            this.lblVolver.Location = new System.Drawing.Point(584, 315);
            this.lblVolver.Name = "lblVolver";
            this.lblVolver.Size = new System.Drawing.Size(42, 15);
            this.lblVolver.TabIndex = 16;
            this.lblVolver.TabStop = true;
            this.lblVolver.Text = "Volver";
            this.lblVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._linkVolver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(655, 312);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 65);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // _lblFormato
            // 
            this._lblFormato.AutoSize = true;
            this._lblFormato.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblFormato.Location = new System.Drawing.Point(306, 320);
            this._lblFormato.Name = "_lblFormato";
            this._lblFormato.Size = new System.Drawing.Size(132, 14);
            this._lblFormato.TabIndex = 18;
            this._lblFormato.Text = "Formato: \"dd-mm-yyyy\"";
            // 
            // FrmLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(728, 392);
            this.Controls.Add(this._lblFormato);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblVolver);
            this.Controls.Add(this.lblFechaAlta);
            this.Controls.Add(this.lblDescuentos);
            this.Controls.Add(this.lblBruto);
            this.Controls.Add(this.lblCodigoTransferencia);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblIdEmpleado);
            this.Controls.Add(this._txtDescuentos);
            this.Controls.Add(this._txtFechaAlta);
            this.Controls.Add(this._txtCodigoTransferencia);
            this.Controls.Add(this._txtBruto);
            this.Controls.Add(this._txtPeriodo);
            this.Controls.Add(this._txtIdEmpleado);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this._txtId);
            this.Controls.Add(this._btnAltaLiquidación);
            this.Controls.Add(this._btnConsultarLiquidacion);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmLiquidacion";
            this.Text = "Liquidación";
            this.Load += new System.EventHandler(this.FrmLiquidacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnConsultarLiquidacion;
        private System.Windows.Forms.Button _btnAltaLiquidación;
        private System.Windows.Forms.TextBox _txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox _txtIdEmpleado;
        private System.Windows.Forms.TextBox _txtPeriodo;
        private System.Windows.Forms.TextBox _txtBruto;
        private System.Windows.Forms.TextBox _txtCodigoTransferencia;
        private System.Windows.Forms.TextBox _txtFechaAlta;
        private System.Windows.Forms.TextBox _txtDescuentos;
        private System.Windows.Forms.Label lblIdEmpleado;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblCodigoTransferencia;
        private System.Windows.Forms.Label lblBruto;
        private System.Windows.Forms.Label lblDescuentos;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.LinkLabel lblVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label _lblFormato;
    }
}