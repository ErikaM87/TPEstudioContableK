namespace EstudioContable.interfazForm
{
    partial class FrmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoria));
            this._txtId = new System.Windows.Forms.TextBox();
            this._txtSueldoBasico = new System.Windows.Forms.TextBox();
            this._txtConvenio = new System.Windows.Forms.TextBox();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblConvenio = new System.Windows.Forms.Label();
            this.lblSueldoBasico = new System.Windows.Forms.Label();
            this._btnConsultaCategoria = new System.Windows.Forms.Button();
            this._btnAltaCategoria = new System.Windows.Forms.Button();
            this.lblVolver = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _txtId
            // 
            this._txtId.Location = new System.Drawing.Point(146, 50);
            this._txtId.Name = "_txtId";
            this._txtId.Size = new System.Drawing.Size(85, 22);
            this._txtId.TabIndex = 0;
            this._txtId.TextChanged += new System.EventHandler(this._txtId_TextChanged);
            // 
            // _txtSueldoBasico
            // 
            this._txtSueldoBasico.Location = new System.Drawing.Point(146, 284);
            this._txtSueldoBasico.Name = "_txtSueldoBasico";
            this._txtSueldoBasico.Size = new System.Drawing.Size(144, 22);
            this._txtSueldoBasico.TabIndex = 1;
            this._txtSueldoBasico.TextChanged += new System.EventHandler(this._txtSueldoBasico_TextChanged);
            // 
            // _txtConvenio
            // 
            this._txtConvenio.Location = new System.Drawing.Point(146, 211);
            this._txtConvenio.Name = "_txtConvenio";
            this._txtConvenio.Size = new System.Drawing.Size(144, 22);
            this._txtConvenio.TabIndex = 2;
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(146, 143);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(144, 22);
            this._txtNombre.TabIndex = 3;
            this._txtNombre.TextChanged += new System.EventHandler(this._txtNombre_TextChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(38, 57);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 15);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "ID";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(38, 146);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 15);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblConvenio
            // 
            this.lblConvenio.AutoSize = true;
            this.lblConvenio.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvenio.Location = new System.Drawing.Point(38, 215);
            this.lblConvenio.Name = "lblConvenio";
            this.lblConvenio.Size = new System.Drawing.Size(57, 15);
            this.lblConvenio.TabIndex = 6;
            this.lblConvenio.Text = "Convenio";
            // 
            // lblSueldoBasico
            // 
            this.lblSueldoBasico.AutoSize = true;
            this.lblSueldoBasico.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoBasico.Location = new System.Drawing.Point(38, 284);
            this.lblSueldoBasico.Name = "lblSueldoBasico";
            this.lblSueldoBasico.Size = new System.Drawing.Size(84, 15);
            this.lblSueldoBasico.TabIndex = 7;
            this.lblSueldoBasico.Text = "Sueldo Básico";
            // 
            // _btnConsultaCategoria
            // 
            this._btnConsultaCategoria.BackColor = System.Drawing.SystemColors.Highlight;
            this._btnConsultaCategoria.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnConsultaCategoria.Location = new System.Drawing.Point(360, 30);
            this._btnConsultaCategoria.Name = "_btnConsultaCategoria";
            this._btnConsultaCategoria.Size = new System.Drawing.Size(178, 57);
            this._btnConsultaCategoria.TabIndex = 8;
            this._btnConsultaCategoria.Text = "Consulta Categoría";
            this._btnConsultaCategoria.UseVisualStyleBackColor = false;
            this._btnConsultaCategoria.Click += new System.EventHandler(this._btnConsultaCategoria_Click);
            // 
            // _btnAltaCategoria
            // 
            this._btnAltaCategoria.BackColor = System.Drawing.SystemColors.Highlight;
            this._btnAltaCategoria.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAltaCategoria.Location = new System.Drawing.Point(360, 177);
            this._btnAltaCategoria.Name = "_btnAltaCategoria";
            this._btnAltaCategoria.Size = new System.Drawing.Size(178, 53);
            this._btnAltaCategoria.TabIndex = 9;
            this._btnAltaCategoria.Text = "Alta Categoría";
            this._btnAltaCategoria.UseVisualStyleBackColor = false;
            this._btnAltaCategoria.Click += new System.EventHandler(this._btnAltaCategoria_Click);
            // 
            // lblVolver
            // 
            this.lblVolver.AutoSize = true;
            this.lblVolver.Location = new System.Drawing.Point(596, 313);
            this.lblVolver.Name = "lblVolver";
            this.lblVolver.Size = new System.Drawing.Size(42, 15);
            this.lblVolver.TabIndex = 10;
            this.lblVolver.TabStop = true;
            this.lblVolver.Text = "Volver";
            this.lblVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._linkVolver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(664, 313);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 67);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(728, 392);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblVolver);
            this.Controls.Add(this._btnAltaCategoria);
            this.Controls.Add(this._btnConsultaCategoria);
            this.Controls.Add(this.lblSueldoBasico);
            this.Controls.Add(this.lblConvenio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this._txtConvenio);
            this.Controls.Add(this._txtSueldoBasico);
            this.Controls.Add(this._txtId);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmCategoria";
            this.Text = "Categoría";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtId;
        private System.Windows.Forms.TextBox _txtSueldoBasico;
        private System.Windows.Forms.TextBox _txtConvenio;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblConvenio;
        private System.Windows.Forms.Label lblSueldoBasico;
        private System.Windows.Forms.Button _btnConsultaCategoria;
        private System.Windows.Forms.Button _btnAltaCategoria;
        private System.Windows.Forms.LinkLabel lblVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}