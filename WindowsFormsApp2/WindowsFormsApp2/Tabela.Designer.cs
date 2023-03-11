namespace WindowsFormsApp2
{
    partial class Tabela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabela));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prikaziSveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tTLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aNDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nANDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xNORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHIFTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kucisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podkategorijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaziSveToolStripMenuItem,
            this.kategorijeToolStripMenuItem,
            this.kucisteToolStripMenuItem,
            this.dodajToolStripMenuItem,
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prikaziSveToolStripMenuItem
            // 
            this.prikaziSveToolStripMenuItem.Name = "prikaziSveToolStripMenuItem";
            this.prikaziSveToolStripMenuItem.Size = new System.Drawing.Size(91, 27);
            this.prikaziSveToolStripMenuItem.Text = "Prikazi sve";
            this.prikaziSveToolStripMenuItem.Click += new System.EventHandler(this.prikaziSveToolStripMenuItem_Click);
            // 
            // kategorijeToolStripMenuItem
            // 
            this.kategorijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tTLToolStripMenuItem,
            this.cPUToolStripMenuItem,
            this.rAMToolStripMenuItem,
            this.rOMToolStripMenuItem});
            this.kategorijeToolStripMenuItem.Name = "kategorijeToolStripMenuItem";
            this.kategorijeToolStripMenuItem.Size = new System.Drawing.Size(92, 27);
            this.kategorijeToolStripMenuItem.Text = "Kategorije";
            // 
            // tTLToolStripMenuItem
            // 
            this.tTLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aNDToolStripMenuItem,
            this.oRToolStripMenuItem,
            this.nOTToolStripMenuItem,
            this.nANDToolStripMenuItem,
            this.nORToolStripMenuItem,
            this.xORToolStripMenuItem,
            this.xNORToolStripMenuItem,
            this.sHIFTToolStripMenuItem});
            this.tTLToolStripMenuItem.Name = "tTLToolStripMenuItem";
            this.tTLToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.tTLToolStripMenuItem.Text = "TTL";
            // 
            // aNDToolStripMenuItem
            // 
            this.aNDToolStripMenuItem.Name = "aNDToolStripMenuItem";
            this.aNDToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.aNDToolStripMenuItem.Text = "AND";
            // 
            // oRToolStripMenuItem
            // 
            this.oRToolStripMenuItem.Name = "oRToolStripMenuItem";
            this.oRToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.oRToolStripMenuItem.Text = "OR";
            // 
            // nOTToolStripMenuItem
            // 
            this.nOTToolStripMenuItem.Name = "nOTToolStripMenuItem";
            this.nOTToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.nOTToolStripMenuItem.Text = "NOT";
            // 
            // nANDToolStripMenuItem
            // 
            this.nANDToolStripMenuItem.Name = "nANDToolStripMenuItem";
            this.nANDToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.nANDToolStripMenuItem.Text = "NAND";
            // 
            // nORToolStripMenuItem
            // 
            this.nORToolStripMenuItem.Name = "nORToolStripMenuItem";
            this.nORToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.nORToolStripMenuItem.Text = "NOR";
            // 
            // xORToolStripMenuItem
            // 
            this.xORToolStripMenuItem.Name = "xORToolStripMenuItem";
            this.xORToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.xORToolStripMenuItem.Text = "XOR";
            // 
            // xNORToolStripMenuItem
            // 
            this.xNORToolStripMenuItem.Name = "xNORToolStripMenuItem";
            this.xNORToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.xNORToolStripMenuItem.Text = "XNOR";
            // 
            // sHIFTToolStripMenuItem
            // 
            this.sHIFTToolStripMenuItem.Name = "sHIFTToolStripMenuItem";
            this.sHIFTToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.sHIFTToolStripMenuItem.Text = "SHIFT";
            // 
            // cPUToolStripMenuItem
            // 
            this.cPUToolStripMenuItem.Name = "cPUToolStripMenuItem";
            this.cPUToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.cPUToolStripMenuItem.Text = "CPU";
            // 
            // rAMToolStripMenuItem
            // 
            this.rAMToolStripMenuItem.Name = "rAMToolStripMenuItem";
            this.rAMToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.rAMToolStripMenuItem.Text = "RAM";
            // 
            // rOMToolStripMenuItem
            // 
            this.rOMToolStripMenuItem.Name = "rOMToolStripMenuItem";
            this.rOMToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.rOMToolStripMenuItem.Text = "ROM";
            // 
            // kucisteToolStripMenuItem
            // 
            this.kucisteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dIPToolStripMenuItem});
            this.kucisteToolStripMenuItem.Name = "kucisteToolStripMenuItem";
            this.kucisteToolStripMenuItem.Size = new System.Drawing.Size(70, 27);
            this.kucisteToolStripMenuItem.Text = "Kuciste";
            // 
            // dIPToolStripMenuItem
            // 
            this.dIPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.dIPToolStripMenuItem.Name = "dIPToolStripMenuItem";
            this.dIPToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.dIPToolStripMenuItem.Text = "DIP";
            this.dIPToolStripMenuItem.Click += new System.EventHandler(this.dIPToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem2.Text = "14";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem3.Text = "16";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem4.Text = "20";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem5.Text = "28";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem6.Text = "40";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorijaToolStripMenuItem,
            this.podkategorijaToolStripMenuItem,
            this.cipToolStripMenuItem});
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(64, 27);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // kategorijaToolStripMenuItem
            // 
            this.kategorijaToolStripMenuItem.Name = "kategorijaToolStripMenuItem";
            this.kategorijaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kategorijaToolStripMenuItem.Text = "Kategorija";
            this.kategorijaToolStripMenuItem.Click += new System.EventHandler(this.kategorijaToolStripMenuItem_Click);
            // 
            // podkategorijaToolStripMenuItem
            // 
            this.podkategorijaToolStripMenuItem.Name = "podkategorijaToolStripMenuItem";
            this.podkategorijaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.podkategorijaToolStripMenuItem.Text = "Podkategorija";
            this.podkategorijaToolStripMenuItem.Click += new System.EventHandler(this.podkategorijaToolStripMenuItem_Click);
            // 
            // cipToolStripMenuItem
            // 
            this.cipToolStripMenuItem.Name = "cipToolStripMenuItem";
            this.cipToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cipToolStripMenuItem.Text = "Cip";
            this.cipToolStripMenuItem.Click += new System.EventHandler(this.cipToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Margin = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 27);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(542, 353);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Tabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(542, 383);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(560, 430);
            this.Name = "Tabela";
            this.Text = "Tabela";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategorijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tTLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cPUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rAMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rOMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aNDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nANDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xNORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHIFTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kucisteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem prikaziSveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podkategorijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cipToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}

