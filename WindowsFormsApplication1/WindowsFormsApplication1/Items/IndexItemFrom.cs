using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Items
{
    public partial class IndexItemFrom : Form
    {
        private ItemManagement businness;
        private Carts.CartManagement Cbusiness;
        public IndexItemFrom()
        {
            InitializeComponent();
            this.Load += IndexItemFrom_Load;
            this.btnAddItem.Click += btnAddItem_Click;
            this.btnEditItem.Click += btnEditItem_Click;
            this.btnDeleteItem.Click += btnDeleteItem_Click;
            this.btnViewCart.Click += btnViewCart_Click;
            this.btnViewProducer.Click += btnViewProducer_Click;
            this.grdViewItem.DoubleClick += btnEditItem_Click;
            this.btnClose.Click += btnClose_Click;
            businness = new ItemManagement();
            Cbusiness = new Carts.CartManagement();
            this.btnBuy.Click += btnBuy_Click;
            this.btnFind.Click += btnFind_Click;
        }

        void btnFind_Click(object sender, EventArgs e)
        {
            var id = int.Parse(this.txtFind.Text);
            var item=this.businness.getItems(id);

            new WindowsFormsApplication1.Items.FindItem(id).ShowDialog();
        }

        void btnBuy_Click(object sender, EventArgs e)
        {
            if (this.grdViewItem.SelectedRows.Count == 1)
            {
                var item = (Item)this.grdViewItem.SelectedRows[0].DataBoundItem;
                int quantity=1;
                this.Cbusiness.AddCart(item.Name,item.Id, item.Price, quantity, item.Price * quantity);
                this.businness.minusAmountItem(item.Id, 1);
                this.loadAllItem();
            }
        }

        void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnViewProducer_Click(object sender, EventArgs e)
        {
            new WindowsFormsApplication1.Producers.IndexProducerFrom().ShowDialog();
            this.Close();
        }

        void btnViewCart_Click(object sender, EventArgs e)
        {
            new WindowsFormsApplication1.Carts.IndexCartFrom().ShowDialog();
            this.Close();
        }
        void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (this.grdViewItem.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Do you want to delete this?", "Confirm",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var item = (Item)this.grdViewItem.SelectedRows[0].DataBoundItem;
                    this.businness.DeleteItem(item.Id);
                    MessageBox.Show("Delete class successfully.");
                    this.loadAllItem();
                }
            }
        }

        void btnEditItem_Click(object sender, EventArgs e)
        {
            if (this.grdViewItem.SelectedRows.Count == 1)
            {
                var item = (Item)this.grdViewItem.SelectedRows[0].DataBoundItem;
                var updateForm = new UpdateItemFrom(item.Id);
                updateForm.ShowDialog();
                this.loadAllItem();
            }
        }

        void btnAddItem_Click(object sender, EventArgs e)
        {
            new AddItemFrom().ShowDialog();
            this.loadAllItem();
        }

        void IndexItemFrom_Load(object sender, EventArgs e)
        {
            this.loadAllItem();
        }

        private void loadAllItem()
        {
            var item = this.businness.getItem();
            this.grdViewItem.DataSource =item;
        }
    }
}
