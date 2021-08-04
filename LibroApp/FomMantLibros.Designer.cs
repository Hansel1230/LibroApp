namespace LibroApp
{
    partial class FomMantLibros
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.LblLibro = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblAutor = new System.Windows.Forms.Label();
            this.LblEditorial = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.CbxAutor = new System.Windows.Forms.ComboBox();
            this.CbxEditorial = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.38017F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.68595F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.76859F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnAgregar, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.LblLibro, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblNombre, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblFecha, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LblAutor, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.LblEditorial, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.TxtNombre, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtFecha, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CbxAutor, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.CbxEditorial, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(605, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(208, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrasToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // atrasToolStripMenuItem
            // 
            this.atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            this.atrasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atrasToolStripMenuItem.Text = "Atras";
            this.atrasToolStripMenuItem.Click += new System.EventHandler(this.atrasToolStripMenuItem_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.OldLace;
            this.BtnAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAgregar.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.DarkKhaki;
            this.BtnAgregar.Location = new System.Drawing.Point(211, 387);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(222, 51);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // LblLibro
            // 
            this.LblLibro.AutoSize = true;
            this.LblLibro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LblLibro.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblLibro.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLibro.ForeColor = System.Drawing.Color.Maroon;
            this.LblLibro.Location = new System.Drawing.Point(211, 30);
            this.LblLibro.Name = "LblLibro";
            this.LblLibro.Size = new System.Drawing.Size(222, 21);
            this.LblLibro.TabIndex = 2;
            this.LblLibro.Text = "Libro";
            this.LblLibro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNombre
            // 
            this.LblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.SeaShell;
            this.LblNombre.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(139, 128);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(66, 16);
            this.LblNombre.TabIndex = 3;
            this.LblNombre.Text = "Nombre";
            this.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFecha
            // 
            this.LblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.Color.SeaShell;
            this.LblFecha.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(35, 192);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(170, 16);
            this.LblFecha.TabIndex = 4;
            this.LblFecha.Text = "Fecha de Publicacion";
            // 
            // LblAutor
            // 
            this.LblAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAutor.AutoSize = true;
            this.LblAutor.BackColor = System.Drawing.Color.SeaShell;
            this.LblAutor.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutor.Location = new System.Drawing.Point(154, 256);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(51, 16);
            this.LblAutor.TabIndex = 5;
            this.LblAutor.Text = "Autor";
            this.LblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblEditorial
            // 
            this.LblEditorial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblEditorial.AutoSize = true;
            this.LblEditorial.BackColor = System.Drawing.Color.SeaShell;
            this.LblEditorial.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEditorial.Location = new System.Drawing.Point(134, 320);
            this.LblEditorial.Name = "LblEditorial";
            this.LblEditorial.Size = new System.Drawing.Size(71, 16);
            this.LblEditorial.TabIndex = 6;
            this.LblEditorial.Text = "Editorial";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtNombre.Location = new System.Drawing.Point(211, 131);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(222, 20);
            this.TxtNombre.TabIndex = 7;
            this.TxtNombre.Click += new System.EventHandler(this.TxtNombre_Click);
            this.TxtNombre.Leave += new System.EventHandler(this.TxtNombre_Leave);
            // 
            // TxtFecha
            // 
            this.TxtFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtFecha.Location = new System.Drawing.Point(211, 195);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(222, 20);
            this.TxtFecha.TabIndex = 8;
            this.TxtFecha.Click += new System.EventHandler(this.TxtFecha_Click);
            this.TxtFecha.Leave += new System.EventHandler(this.TxtFecha_Leave);
            // 
            // CbxAutor
            // 
            this.CbxAutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.CbxAutor.FormattingEnabled = true;
            this.CbxAutor.Location = new System.Drawing.Point(211, 259);
            this.CbxAutor.Name = "CbxAutor";
            this.CbxAutor.Size = new System.Drawing.Size(222, 21);
            this.CbxAutor.TabIndex = 9;
            // 
            // CbxEditorial
            // 
            this.CbxEditorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.CbxEditorial.FormattingEnabled = true;
            this.CbxEditorial.Location = new System.Drawing.Point(211, 323);
            this.CbxEditorial.Name = "CbxEditorial";
            this.CbxEditorial.Size = new System.Drawing.Size(222, 21);
            this.CbxEditorial.TabIndex = 10;
            // 
            // FomMantLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FomMantLibros";
            this.Text = "FomMantLibros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FomMantLibros_FormClosing);
            this.Load += new System.EventHandler(this.FomMantLibros_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrasToolStripMenuItem;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label LblLibro;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.Label LblEditorial;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.ComboBox CbxAutor;
        private System.Windows.Forms.ComboBox CbxEditorial;
    }
}