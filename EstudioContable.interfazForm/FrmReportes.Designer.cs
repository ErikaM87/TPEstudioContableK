namespace EstudioContable.interfazForm
{
    partial class FrmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            this._lstEmpresas = new System.Windows.Forms.ListBox();
            this._lstCategorias = new System.Windows.Forms.ListBox();
            this._lblCategoria = new System.Windows.Forms.Label();
            this._lblEmpresa = new System.Windows.Forms.Label();
            this.btn_ReporteLiquidaciones = new System.Windows.Forms.Button();
            this._btnReporteEmpleados = new System.Windows.Forms.Button();
            this._btnVolver = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // _lstEmpresas
            // 
            this._lstEmpresas.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lstEmpresas.FormattingEnabled = true;
            this._lstEmpresas.ItemHeight = 14;
            this._lstEmpresas.Location = new System.Drawing.Point(117, 83);
            this._lstEmpresas.Name = "_lstEmpresas";
            this._lstEmpresas.Size = new System.Drawing.Size(218, 214);
            this._lstEmpresas.TabIndex = 0;
            this._lstEmpresas.SelectedIndexChanged += new System.EventHandler(this._lstEmpresas_SelectedIndexChanged);
            // 
            // _lstCategorias
            // 
            this._lstCategorias.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lstCategorias.FormattingEnabled = true;
            this._lstCategorias.ItemHeight = 14;
            this._lstCategorias.Location = new System.Drawing.Point(413, 83);
            this._lstCategorias.Name = "_lstCategorias";
            this._lstCategorias.Size = new System.Drawing.Size(218, 214);
            this._lstCategorias.TabIndex = 1;
            // 
            // _lblCategoria
            // 
            this._lblCategoria.AutoSize = true;
            this._lblCategoria.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCategoria.Location = new System.Drawing.Point(460, 43);
            this._lblCategoria.Name = "_lblCategoria";
            this._lblCategoria.Size = new System.Drawing.Size(107, 22);
            this._lblCategoria.TabIndex = 2;
            this._lblCategoria.Text = "Categorías:";
            // 
            // _lblEmpresa
            // 
            this._lblEmpresa.AutoSize = true;
            this._lblEmpresa.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblEmpresa.Location = new System.Drawing.Point(162, 43);
            this._lblEmpresa.Name = "_lblEmpresa";
            this._lblEmpresa.Size = new System.Drawing.Size(98, 22);
            this._lblEmpresa.TabIndex = 3;
            this._lblEmpresa.Text = "Empresas:";
            // 
            // btn_ReporteLiquidaciones
            // 
            this.btn_ReporteLiquidaciones.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_ReporteLiquidaciones.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReporteLiquidaciones.Location = new System.Drawing.Point(413, 332);
            this.btn_ReporteLiquidaciones.Name = "btn_ReporteLiquidaciones";
            this.btn_ReporteLiquidaciones.Size = new System.Drawing.Size(218, 44);
            this.btn_ReporteLiquidaciones.TabIndex = 4;
            this.btn_ReporteLiquidaciones.Text = "Reporte de Liquidaciones";
            this.btn_ReporteLiquidaciones.UseVisualStyleBackColor = false;
            this.btn_ReporteLiquidaciones.Click += new System.EventHandler(this.btn_ReporteLiquidaciones_Click);
            // 
            // _btnReporteEmpleados
            // 
            this._btnReporteEmpleados.BackColor = System.Drawing.SystemColors.WindowFrame;
            this._btnReporteEmpleados.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnReporteEmpleados.Location = new System.Drawing.Point(117, 332);
            this._btnReporteEmpleados.Name = "_btnReporteEmpleados";
            this._btnReporteEmpleados.Size = new System.Drawing.Size(218, 44);
            this._btnReporteEmpleados.TabIndex = 5;
            this._btnReporteEmpleados.Text = "Reporte de Empleados";
            this._btnReporteEmpleados.UseVisualStyleBackColor = false;
            this._btnReporteEmpleados.Click += new System.EventHandler(this._btnReporteEmpleados_Click);
            // 
            // _btnVolver
            // 
            this._btnVolver.AutoSize = true;
            this._btnVolver.Location = new System.Drawing.Point(641, 379);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(37, 13);
            this._btnVolver.TabIndex = 6;
            this._btnVolver.TabStop = true;
            this._btnVolver.Text = "Volver";
            this._btnVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(684, 379);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 67);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-3, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 94);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(752, 448);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._btnReporteEmpleados);
            this.Controls.Add(this.btn_ReporteLiquidaciones);
            this.Controls.Add(this._lblEmpresa);
            this.Controls.Add(this._lblCategoria);
            this.Controls.Add(this._lstCategorias);
            this.Controls.Add(this._lstEmpresas);
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox _lstEmpresas;
        private System.Windows.Forms.ListBox _lstCategorias;
        private System.Windows.Forms.Label _lblCategoria;
        private System.Windows.Forms.Label _lblEmpresa;
        private System.Windows.Forms.Button btn_ReporteLiquidaciones;
        private System.Windows.Forms.Button _btnReporteEmpleados;
        private System.Windows.Forms.LinkLabel _btnVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}