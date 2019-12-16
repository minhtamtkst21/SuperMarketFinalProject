namespace WindowsFormsApplication1.Items
{
    partial class IndexItemFrom
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
            this.grdViewItem = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.updateItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewAZ = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewQuantity = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnViewProducer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewCart = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewItem)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdViewItem
            // 
            this.grdViewItem.AllowUserToAddRows = false;
            this.grdViewItem.AllowUserToDeleteRows = false;
            this.grdViewItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdViewItem.Location = new System.Drawing.Point(0, 24);
            this.grdViewItem.Name = "grdViewItem";
            this.grdViewItem.ReadOnly = true;
            this.grdViewItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdViewItem.Size = new System.Drawing.Size(491, 228);
            this.grdViewItem.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateItemToolStripMenuItem,
            this.viewItemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // updateItemToolStripMenuItem
            // 
            this.updateItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddItem,
            this.btnEditItem,
            this.btnDeleteItem});
            this.updateItemToolStripMenuItem.Name = "updateItemToolStripMenuItem";
            this.updateItemToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.updateItemToolStripMenuItem.Text = "Update Item";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(134, 22);
            this.btnAddItem.Text = "Add item";
            // 
            // btnEditItem
            // 
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(134, 22);
            this.btnEditItem.Text = "Edit item";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(134, 22);
            this.btnDeleteItem.Text = "Delete item";
            // 
            // viewItemToolStripMenuItem
            // 
            this.viewItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnViewAZ,
            this.btnViewQuantity,
            this.btnViewPrice});
            this.viewItemToolStripMenuItem.Name = "viewItemToolStripMenuItem";
            this.viewItemToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.viewItemToolStripMenuItem.Text = "View Item";
            // 
            // btnViewAZ
            // 
            this.btnViewAZ.Name = "btnViewAZ";
            this.btnViewAZ.Size = new System.Drawing.Size(120, 22);
            this.btnViewAZ.Text = "AZ";
            // 
            // btnViewQuantity
            // 
            this.btnViewQuantity.Name = "btnViewQuantity";
            this.btnViewQuantity.Size = new System.Drawing.Size(120, 22);
            this.btnViewQuantity.Text = "Quantity";
            // 
            // btnViewPrice
            // 
            this.btnViewPrice.Name = "btnViewPrice";
            this.btnViewPrice.Size = new System.Drawing.Size(120, 22);
            this.btnViewPrice.Text = "Price";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(404, 0);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(280, 2);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(118, 20);
            this.txtFind.TabIndex = 3;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnViewProducer,
            this.btnViewCart});
            this.menuStrip2.Location = new System.Drawing.Point(0, 252);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(491, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btnViewProducer
            // 
            this.btnViewProducer.Name = "btnViewProducer";
            this.btnViewProducer.Size = new System.Drawing.Size(92, 20);
            this.btnViewProducer.Text = "ViewProducer";
            // 
            // btnViewCart
            // 
            this.btnViewCart.Name = "btnViewCart";
            this.btnViewCart.Size = new System.Drawing.Size(66, 20);
            this.btnViewCart.Text = "ViewCart";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(404, 252);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // IndexItemFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 276);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.grdViewItem);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IndexItemFrom";
            this.Text = "IndexItemFrom";
            ((System.ComponentModel.ISupportInitialize)(this.grdViewItem)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdViewItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAddItem;
        private System.Windows.Forms.ToolStripMenuItem btnEditItem;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteItem;
        private System.Windows.Forms.ToolStripMenuItem viewItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnViewAZ;
        private System.Windows.Forms.ToolStripMenuItem btnViewQuantity;
        private System.Windows.Forms.ToolStripMenuItem btnViewPrice;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btnViewProducer;
        private System.Windows.Forms.ToolStripMenuItem btnViewCart;
        private System.Windows.Forms.Button btnClose;
    }
}