﻿namespace Pubs
{
    partial class frmAltaTitulosAutor
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cbxTitulo = new System.Windows.Forms.ComboBox();
            this.cbxIdTitulo = new System.Windows.Forms.ComboBox();
            this.lblIdTitulo = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblRoyalty = new System.Windows.Forms.Label();
            this.lblOrden = new System.Windows.Forms.Label();
            this.nupOrdenAutor = new System.Windows.Forms.NumericUpDown();
            this.nupRoyalty = new System.Windows.Forms.NumericUpDown();
            this.lblNombreAutor = new System.Windows.Forms.Label();
            this.cbNombreAutor = new System.Windows.Forms.ComboBox();
            this.cbIdAutor = new System.Windows.Forms.ComboBox();
            this.lblIdAutor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupOrdenAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupRoyalty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 17F);
            this.label1.Location = new System.Drawing.Point(66, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 93;
            this.label1.Text = "ALTA TITULOS AUTOR";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(182, 239);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(36, 13);
            this.lblTitulo.TabIndex = 92;
            this.lblTitulo.Text = "Titulo:";
            // 
            // cbxTitulo
            // 
            this.cbxTitulo.FormattingEnabled = true;
            this.cbxTitulo.Location = new System.Drawing.Point(241, 231);
            this.cbxTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxTitulo.Name = "cbxTitulo";
            this.cbxTitulo.Size = new System.Drawing.Size(180, 21);
            this.cbxTitulo.TabIndex = 90;
            this.cbxTitulo.SelectedIndexChanged += new System.EventHandler(this.cbxTitulo_SelectedIndexChanged);
            // 
            // cbxIdTitulo
            // 
            this.cbxIdTitulo.FormattingEnabled = true;
            this.cbxIdTitulo.Location = new System.Drawing.Point(241, 190);
            this.cbxIdTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxIdTitulo.Name = "cbxIdTitulo";
            this.cbxIdTitulo.Size = new System.Drawing.Size(180, 21);
            this.cbxIdTitulo.TabIndex = 89;
            this.cbxIdTitulo.SelectedIndexChanged += new System.EventHandler(this.cbxIdTitulo_SelectedIndexChanged);
            // 
            // lblIdTitulo
            // 
            this.lblIdTitulo.AutoSize = true;
            this.lblIdTitulo.Location = new System.Drawing.Point(164, 198);
            this.lblIdTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdTitulo.Name = "lblIdTitulo";
            this.lblIdTitulo.Size = new System.Drawing.Size(48, 13);
            this.lblIdTitulo.TabIndex = 91;
            this.lblIdTitulo.Text = "Id Titulo:";
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(335, 394);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(112, 33);
            this.btnRegresar.TabIndex = 88;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(209, 394);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 33);
            this.btnAgregar.TabIndex = 87;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblRoyalty
            // 
            this.lblRoyalty.AutoSize = true;
            this.lblRoyalty.Location = new System.Drawing.Point(169, 335);
            this.lblRoyalty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoyalty.Name = "lblRoyalty";
            this.lblRoyalty.Size = new System.Drawing.Size(45, 13);
            this.lblRoyalty.TabIndex = 86;
            this.lblRoyalty.Text = "Royalty:";
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Location = new System.Drawing.Point(176, 288);
            this.lblOrden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(39, 13);
            this.lblOrden.TabIndex = 85;
            this.lblOrden.Text = "Orden:";
            // 
            // nupOrdenAutor
            // 
            this.nupOrdenAutor.Location = new System.Drawing.Point(241, 280);
            this.nupOrdenAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nupOrdenAutor.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nupOrdenAutor.Name = "nupOrdenAutor";
            this.nupOrdenAutor.Size = new System.Drawing.Size(80, 20);
            this.nupOrdenAutor.TabIndex = 84;
            // 
            // nupRoyalty
            // 
            this.nupRoyalty.Location = new System.Drawing.Point(241, 327);
            this.nupRoyalty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nupRoyalty.Name = "nupRoyalty";
            this.nupRoyalty.Size = new System.Drawing.Size(80, 20);
            this.nupRoyalty.TabIndex = 83;
            // 
            // lblNombreAutor
            // 
            this.lblNombreAutor.AutoSize = true;
            this.lblNombreAutor.Location = new System.Drawing.Point(120, 147);
            this.lblNombreAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreAutor.Name = "lblNombreAutor";
            this.lblNombreAutor.Size = new System.Drawing.Size(75, 13);
            this.lblNombreAutor.TabIndex = 82;
            this.lblNombreAutor.Text = "Nombre Autor:";
            // 
            // cbNombreAutor
            // 
            this.cbNombreAutor.FormattingEnabled = true;
            this.cbNombreAutor.Location = new System.Drawing.Point(241, 139);
            this.cbNombreAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNombreAutor.Name = "cbNombreAutor";
            this.cbNombreAutor.Size = new System.Drawing.Size(180, 21);
            this.cbNombreAutor.TabIndex = 80;
            this.cbNombreAutor.SelectedIndexChanged += new System.EventHandler(this.cbNombreAutor_SelectedIndexChanged);
            // 
            // cbIdAutor
            // 
            this.cbIdAutor.FormattingEnabled = true;
            this.cbIdAutor.Location = new System.Drawing.Point(241, 100);
            this.cbIdAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIdAutor.Name = "cbIdAutor";
            this.cbIdAutor.Size = new System.Drawing.Size(180, 21);
            this.cbIdAutor.TabIndex = 79;
            this.cbIdAutor.SelectedIndexChanged += new System.EventHandler(this.cbIdAutor_SelectedIndexChanged);
            // 
            // lblIdAutor
            // 
            this.lblIdAutor.AutoSize = true;
            this.lblIdAutor.Location = new System.Drawing.Point(164, 108);
            this.lblIdAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdAutor.Name = "lblIdAutor";
            this.lblIdAutor.Size = new System.Drawing.Size(47, 13);
            this.lblIdAutor.TabIndex = 81;
            this.lblIdAutor.Text = "Id Autor:";
            // 
            // frmAltaTitulosAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cbxTitulo);
            this.Controls.Add(this.cbxIdTitulo);
            this.Controls.Add(this.lblIdTitulo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblRoyalty);
            this.Controls.Add(this.lblOrden);
            this.Controls.Add(this.nupOrdenAutor);
            this.Controls.Add(this.nupRoyalty);
            this.Controls.Add(this.lblNombreAutor);
            this.Controls.Add(this.cbNombreAutor);
            this.Controls.Add(this.cbIdAutor);
            this.Controls.Add(this.lblIdAutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltaTitulosAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAltaTitulosAutor";
            this.Load += new System.EventHandler(this.frmAltaTitulosAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupOrdenAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupRoyalty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbxTitulo;
        private System.Windows.Forms.ComboBox cbxIdTitulo;
        private System.Windows.Forms.Label lblIdTitulo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblRoyalty;
        private System.Windows.Forms.Label lblOrden;
        private System.Windows.Forms.NumericUpDown nupOrdenAutor;
        private System.Windows.Forms.NumericUpDown nupRoyalty;
        private System.Windows.Forms.Label lblNombreAutor;
        private System.Windows.Forms.ComboBox cbNombreAutor;
        private System.Windows.Forms.ComboBox cbIdAutor;
        private System.Windows.Forms.Label lblIdAutor;
    }
}