namespace EstudioContable.interfazForm
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this._btnCategorias = new System.Windows.Forms.Button();
            this._btnLiquidaciones = new System.Windows.Forms.Button();
            this._btnEmpresas = new System.Windows.Forms.Button();
            this._btnEmpleados = new System.Windows.Forms.Button();
            this._btnGenerarReportes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnCategorias
            // 
            this._btnCategorias.BackColor = System.Drawing.SystemColors.Highlight;
            this._btnCategorias.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCategorias.Location = new System.Drawing.Point(38, 122);
            this._btnCategorias.Name = "_btnCategorias";
            this._btnCategorias.Size = new System.Drawing.Size(182, 38);
            this._btnCategorias.TabIndex = 2;
            this._btnCategorias.Text = "CATEGORÍAS";
            this._btnCategorias.UseVisualStyleBackColor = false;
            this._btnCategorias.Click += new System.EventHandler(this.btnCategorias_click);
            // 
            // _btnLiquidaciones
            // 
            this._btnLiquidaciones.BackColor = System.Drawing.SystemColors.Highlight;
            this._btnLiquidaciones.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnLiquidaciones.Location = new System.Drawing.Point(374, 122);
            this._btnLiquidaciones.Name = "_btnLiquidaciones";
            this._btnLiquidaciones.Size = new System.Drawing.Size(182, 38);
            this._btnLiquidaciones.TabIndex = 5;
            this._btnLiquidaciones.Text = "LIQUIDACIONES";
            this._btnLiquidaciones.UseVisualStyleBackColor = false;
            this._btnLiquidaciones.Click += new System.EventHandler(this._btnLiquidaciones_Click);
            // 
            // _btnEmpresas
            // 
            this._btnEmpresas.BackColor = System.Drawing.SystemColors.Highlight;
            this._btnEmpresas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnEmpresas.Location = new System.Drawing.Point(374, 41);
            this._btnEmpresas.Name = "_btnEmpresas";
            this._btnEmpresas.Size = new System.Drawing.Size(182, 38);
            this._btnEmpresas.TabIndex = 6;
            this._btnEmpresas.Text = "EMPRESAS";
            this._btnEmpresas.UseVisualStyleBackColor = false;
            this._btnEmpresas.Click += new System.EventHandler(this._btnEmpresas_Click);
            // 
            // _btnEmpleados
            // 
            this._btnEmpleados.BackColor = System.Drawing.SystemColors.Highlight;
            this._btnEmpleados.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnEmpleados.Location = new System.Drawing.Point(38, 41);
            this._btnEmpleados.Name = "_btnEmpleados";
            this._btnEmpleados.Size = new System.Drawing.Size(182, 38);
            this._btnEmpleados.TabIndex = 7;
            this._btnEmpleados.Text = "EMPLEADOS";
            this._btnEmpleados.UseVisualStyleBackColor = false;
            this._btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_click);
            // 
            // _btnGenerarReportes
            // 
            this._btnGenerarReportes.BackColor = System.Drawing.SystemColors.Highlight;
            this._btnGenerarReportes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnGenerarReportes.Location = new System.Drawing.Point(169, 206);
            this._btnGenerarReportes.Name = "_btnGenerarReportes";
            this._btnGenerarReportes.Size = new System.Drawing.Size(253, 38);
            this._btnGenerarReportes.TabIndex = 8;
            this._btnGenerarReportes.Text = "GENERACIÓN DE REPORTES";
            this._btnGenerarReportes.UseVisualStyleBackColor = false;
            this._btnGenerarReportes.Click += new System.EventHandler(this._btnGenerarReportes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(486, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 60);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(598, 256);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._btnGenerarReportes);
            this.Controls.Add(this._btnEmpleados);
            this.Controls.Add(this._btnEmpresas);
            this.Controls.Add(this._btnLiquidaciones);
            this.Controls.Add(this._btnCategorias);
            this.Name = "FrmPrincipal";
            this.Text = "Estudio Contable Krabappel & Asoc.";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button _btnCategorias;
        private System.Windows.Forms.Button _btnLiquidaciones;
        private System.Windows.Forms.Button _btnEmpresas;
        private System.Windows.Forms.Button _btnEmpleados;
        private System.Windows.Forms.Button _btnGenerarReportes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}