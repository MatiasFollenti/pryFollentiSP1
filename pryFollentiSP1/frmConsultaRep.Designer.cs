namespace pryFollentiSP1
{
    partial class frmConsultaRep
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
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblMarcaC = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.gbOrigen = new System.Windows.Forms.GroupBox();
            this.optAmbos = new System.Windows.Forms.RadioButton();
            this.optImp = new System.Windows.Forms.RadioButton();
            this.optNacional = new System.Windows.Forms.RadioButton();
            this.dgvRepuestos = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.gbOrigen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = global::pryFollentiSP1.Properties.Resources._2070730_logo2_16790;
            this.pcbLogo.Location = new System.Drawing.Point(29, 24);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(251, 65);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(509, 82);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(121, 43);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(509, 146);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 43);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblMarcaC
            // 
            this.lblMarcaC.AutoSize = true;
            this.lblMarcaC.Location = new System.Drawing.Point(29, 125);
            this.lblMarcaC.Name = "lblMarcaC";
            this.lblMarcaC.Size = new System.Drawing.Size(56, 19);
            this.lblMarcaC.TabIndex = 3;
            this.lblMarcaC.Text = "Marca:";
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(113, 122);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(167, 27);
            this.cmbMarca.TabIndex = 4;
            // 
            // gbOrigen
            // 
            this.gbOrigen.Controls.Add(this.optAmbos);
            this.gbOrigen.Controls.Add(this.optImp);
            this.gbOrigen.Controls.Add(this.optNacional);
            this.gbOrigen.Location = new System.Drawing.Point(33, 214);
            this.gbOrigen.Name = "gbOrigen";
            this.gbOrigen.Size = new System.Drawing.Size(597, 67);
            this.gbOrigen.TabIndex = 5;
            this.gbOrigen.TabStop = false;
            this.gbOrigen.Text = "Origen";
            // 
            // optAmbos
            // 
            this.optAmbos.AutoSize = true;
            this.optAmbos.Location = new System.Drawing.Point(362, 35);
            this.optAmbos.Name = "optAmbos";
            this.optAmbos.Size = new System.Drawing.Size(72, 23);
            this.optAmbos.TabIndex = 2;
            this.optAmbos.TabStop = true;
            this.optAmbos.Text = "Ambos";
            this.optAmbos.UseVisualStyleBackColor = true;
            // 
            // optImp
            // 
            this.optImp.AutoSize = true;
            this.optImp.Location = new System.Drawing.Point(197, 35);
            this.optImp.Name = "optImp";
            this.optImp.Size = new System.Drawing.Size(96, 23);
            this.optImp.TabIndex = 1;
            this.optImp.TabStop = true;
            this.optImp.Text = "Importado";
            this.optImp.UseVisualStyleBackColor = true;
            // 
            // optNacional
            // 
            this.optNacional.AutoSize = true;
            this.optNacional.Location = new System.Drawing.Point(39, 35);
            this.optNacional.Name = "optNacional";
            this.optNacional.Size = new System.Drawing.Size(89, 23);
            this.optNacional.TabIndex = 0;
            this.optNacional.TabStop = true;
            this.optNacional.Text = "Nacional";
            this.optNacional.UseVisualStyleBackColor = true;
            // 
            // dgvRepuestos
            // 
            this.dgvRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colMarca,
            this.colOrigen,
            this.colPrecio});
            this.dgvRepuestos.Location = new System.Drawing.Point(29, 298);
            this.dgvRepuestos.Name = "dgvRepuestos";
            this.dgvRepuestos.Size = new System.Drawing.Size(601, 337);
            this.dgvRepuestos.TabIndex = 6;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "CÓDIGO";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "NOMBRE";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colMarca
            // 
            this.colMarca.HeaderText = "MARCA";
            this.colMarca.Name = "colMarca";
            this.colMarca.ReadOnly = true;
            // 
            // colOrigen
            // 
            this.colOrigen.HeaderText = "ORIGEN";
            this.colOrigen.Name = "colOrigen";
            this.colOrigen.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "PRECIO";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // frmConsultaRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(720, 647);
            this.Controls.Add(this.dgvRepuestos);
            this.Controls.Add(this.gbOrigen);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.lblMarcaC);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.pcbLogo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmConsultaRep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OSAKA - Consulta";
            this.Load += new System.EventHandler(this.frmConsultaRep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.gbOrigen.ResumeLayout(false);
            this.gbOrigen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblMarcaC;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.GroupBox gbOrigen;
        private System.Windows.Forms.RadioButton optAmbos;
        private System.Windows.Forms.RadioButton optImp;
        private System.Windows.Forms.RadioButton optNacional;
        private System.Windows.Forms.DataGridView dgvRepuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
    }
}