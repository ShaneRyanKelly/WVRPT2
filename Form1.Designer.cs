namespace WVRPT2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buoysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectBuoyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breezyPointNYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newportORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.capeCodMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buoysToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buoysToolStripMenuItem
            // 
            this.buoysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectBuoyToolStripMenuItem});
            this.buoysToolStripMenuItem.Name = "buoysToolStripMenuItem";
            this.buoysToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.buoysToolStripMenuItem.Text = "Buoys";
            // 
            // selectBuoyToolStripMenuItem
            // 
            this.selectBuoyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capeCodMAToolStripMenuItem,
            this.breezyPointNYToolStripMenuItem,
            this.newportORToolStripMenuItem});
            this.selectBuoyToolStripMenuItem.Name = "selectBuoyToolStripMenuItem";
            this.selectBuoyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectBuoyToolStripMenuItem.Text = "Select Buoy";
            // 
            // breezyPointNYToolStripMenuItem
            // 
            this.breezyPointNYToolStripMenuItem.Name = "breezyPointNYToolStripMenuItem";
            this.breezyPointNYToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.breezyPointNYToolStripMenuItem.Text = "Breezy Point, NY";
            this.breezyPointNYToolStripMenuItem.Click += new System.EventHandler(this.breezyPointNYToolStripMenuItem_Click);
            // 
            // newportORToolStripMenuItem
            // 
            this.newportORToolStripMenuItem.Name = "newportORToolStripMenuItem";
            this.newportORToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newportORToolStripMenuItem.Text = "Newport, OR";
            this.newportORToolStripMenuItem.Click += new System.EventHandler(this.newportORToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 375);
            this.dataGridView1.TabIndex = 2;
            // 
            // capeCodMAToolStripMenuItem
            // 
            this.capeCodMAToolStripMenuItem.Name = "capeCodMAToolStripMenuItem";
            this.capeCodMAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.capeCodMAToolStripMenuItem.Text = "Cape Cod, MA";
            this.capeCodMAToolStripMenuItem.Click += new System.EventHandler(this.capeCodMAToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "WVRPT 2.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buoysToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem selectBuoyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breezyPointNYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newportORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capeCodMAToolStripMenuItem;
    }
}

