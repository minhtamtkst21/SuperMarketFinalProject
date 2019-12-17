using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Carts
{
    public partial class IndexCartFrom : Form
    {
        private CartManagement business;
        public IndexCartFrom()
        {
            InitializeComponent();
            business = new CartManagement();
            this.btnViewItem.Click += btnViewItem_Click;
            this.btnClose.Click += btnClose_Click;
            this.btnViewProducer.Click += btnViewProducer_Click;
            this.btnDeleteItem.Click += btnDeleteItem_Click;
            this.btnEditItem.Click += btnEditItem_Click;
            this.Load += IndexCartFrom_Load;
        }
        void IndexCartFrom_Load(object sender, EventArgs e)
        {
            this.ViewAllCart();
        }

        private void ViewAllCart()
        {
            var cart = this.business.getCart();
            this.grdViewCart.DataSource = cart;
        }

        void btnEditItem_Click(object sender, EventArgs e)
        {
            if (this.grdViewCart.SelectedRows.Count == 1)
            {
                var cart = (Cart)this.grdViewCart.SelectedRows[0].DataBoundItem;
                var updateForm = new UpdateItemInCart(cart.Id);
                updateForm.ShowDialog();
                this.loadAllCart();
            }
        }

        void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (this.grdViewCart.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Do you want to delete this?", "Confirm",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var cart = (Cart)this.grdViewCart.SelectedRows[0].DataBoundItem;
                    this.business.DeleteCart(cart.Id);
                    MessageBox.Show("Delete class successfully.");
                    this.loadAllCart();
                }
            }
        }

        private void loadAllCart()
        {
            var cart = this.business.getCart();
            this.grdViewCart.DataSource = cart;
        }

        void btnViewProducer_Click(object sender, EventArgs e)
        {
            new WindowsFormsApplication1.Producers.IndexProducerFrom().ShowDialog();
            this.Close();
        }

        void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnViewItem_Click(object sender, EventArgs e)
        {
            new WindowsFormsApplication1.Items.IndexItemFrom().ShowDialog();
            this.Close();
        }
    }
}
