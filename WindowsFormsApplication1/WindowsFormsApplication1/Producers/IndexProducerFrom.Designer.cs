namespace WindowsFormsApplication1.Producers
{
    partial class IndexProducerFrom
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.updateProducerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddProducer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditProducer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteProducer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewCart = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(361, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateProducerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(361, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnViewItem,
            this.btnViewCart});
            this.menuStrip2.Location = new System.Drawing.Point(0, 288);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(361, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // updateProducerToolStripMenuItem
            // 
            this.updateProducerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddProducer,
            this.btnEditProducer,
            this.btnDeleteProducer});
            this.updateProducerToolStripMenuItem.Name = "updateProducerToolStripMenuItem";
            this.updateProducerToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.updateProducerToolStripMenuItem.Text = "Update Producer";
            // 
            // btnAddProducer
            // 
            this.btnAddProducer.Name = "btnAddProducer";
            this.btnAddProducer.Size = new System.Drawing.Size(158, 22);
            this.btnAddProducer.Text = "Add Producer";
            // 
            // btnEditProducer
            // 
            this.btnEditProducer.Name = "btnEditProducer";
            this.btnEditProducer.Size = new System.Drawing.Size(158, 22);
            this.btnEditProducer.Text = "Edit Producer";
            // 
            // btnDeleteProducer
            // 
            this.btnDeleteProducer.Name = "btnDeleteProducer";
            this.btnDeleteProducer.Size = new System.Drawing.Size(158, 22);
            this.btnDeleteProducer.Text = "Delete Producer";
            // 
            // btnViewItem
            // 
            this.btnViewItem.Name = "btnViewItem";
            this.btnViewItem.Size = new System.Drawing.Size(71, 20);
            this.btnViewItem.Text = "View Item";
            // 
            // btnViewCart
            // 
            this.btnViewCart.Name = "btnViewCart";
            this.btnViewCart.Size = new System.Drawing.Size(69, 20);
            this.btnViewCart.Text = "View Cart";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(264, 289);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // IndexProducerFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 312);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IndexProducerFrom";
            this.Text = "IndexProducerFrom";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateProducerToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btnAddProducer;
        private System.Windows.Forms.ToolStripMenuItem btnEditProducer;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteProducer;
        private System.Windows.Forms.ToolStripMenuItem btnViewItem;
        private System.Windows.Forms.ToolStripMenuItem btnViewCart;
        private System.Windows.Forms.Button btnClose;
    }
}