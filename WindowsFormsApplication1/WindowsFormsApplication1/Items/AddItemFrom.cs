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
    public partial class AddItemFrom : Form
    {
        private ItemManagement business;
        public AddItemFrom()
        {
            InitializeComponent();
            business = new ItemManagement();
            this.btnCancel.Click += btnCancel_Click;
            this.btnSave.Click += btnSave_Click;
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var code = this.txtCode.Text;
            var name = this.txtName.Text;
            var producer = int.Parse(this.txtProduce.Text);
            var quantity = int.Parse(this.txtQantity.Text);
            var price = int.Parse(this.txtPrice.Text);

            this.business.AddItem(code, name, producer, quantity, price);
            this.Close();
            MessageBox.Show("Add item complete");
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
