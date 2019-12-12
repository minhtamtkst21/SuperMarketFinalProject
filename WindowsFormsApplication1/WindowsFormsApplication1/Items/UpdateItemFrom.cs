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
    public partial class UpdateItemFrom : Form
    {
        public int itemId;
        private ItemManagement business;
        public UpdateItemFrom(int id)
        {
            InitializeComponent();
            business = new ItemManagement();
            this.itemId = id;
            this.Load += UpdateItemFrom_Load;
            this.btnCancel.Click += btnCancel_Click;
            this.btnSave.Click += btnSave_Click;
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var name = this.txtName.Text;
            var price = int.Parse(this.txtPrice.Text);
            var producer = int.Parse(this.txtProduce.Text);
            var quantity = int.Parse(this.txtQuantity.Text);

            this.business.UpdateItem(this.itemId, name, producer, quantity, price);
            this.Close();
            MessageBox.Show("Update complete");
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void UpdateItemFrom_Load(object sender, EventArgs e)
        {
            var item =this.business.getItems(this.itemId);
            this.txtCode.Text = item.Code;
            this.txtName.Text = item.Name;
            this.txtPrice.Text = item.Price.ToString();
            this.txtProduce.Text = item.Producer.ToString();
            this.txtQuantity.Text = item.Amount.ToString();
        }
    }
}
