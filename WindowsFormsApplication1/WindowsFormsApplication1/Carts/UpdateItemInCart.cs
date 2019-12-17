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
    public partial class UpdateItemInCart : Form
    {
        private int CartId;
        private CartManagement business;
        private WindowsFormsApplication1.Items.ItemManagement Ibusiness;
        public UpdateItemInCart(int id)
        {
            InitializeComponent();
            business = new CartManagement();
            Ibusiness = new Items.ItemManagement();
            CartId = id;
            this.Load += UpdateItemInCart_Load;
            this.btnCancel.Click += btnCancel_Click;
            this.btnSave.Click += btnSave_Click;
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var cart = this.business.getCarts(this.CartId);
            var oldCart=this.business.getCarts(this.CartId);
            var oldQuantity=(int)oldCart.Quantity;
            var quantity = int.Parse(this.txtQuantity.Text);
            this.business.UpdateCart(this.CartId, quantity);
            this.Ibusiness.minusAmountItem((int) cart.Id_item, quantity - oldQuantity);
            this.Close();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void UpdateItemInCart_Load(object sender, EventArgs e)
        {
            var cart = this.business.getCarts(this.CartId);
            this.txtName.Text = cart.Name;
            this.txtQuantity.Text = cart.Quantity.ToString();
        }
    }
}
