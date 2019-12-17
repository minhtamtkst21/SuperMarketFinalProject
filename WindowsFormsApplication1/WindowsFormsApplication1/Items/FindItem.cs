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
    public partial class FindItem : Form
    {
        private ItemManagement business;
        private int itemId;
        public FindItem(int id)
        {
            InitializeComponent();
            this.Load += FindItem_Load;
            this.button1.Click += button1_Click;
            itemId = id;
            business = new ItemManagement();
        }

        void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void FindItem_Load(object sender, EventArgs e)
        {
            var item=this.business.getItems(this.itemId);
            this.txtid.Text = item.Id.ToString();
            this.txtcode.Text = item.Code;
            this.txtName.Text = item.Name;
            this.txtprice.Text = item.Price.ToString();
            this.txtproducer.Text = item.Producer.ToString();
            this.txtquantity.Text = item.Amount.ToString();
        }
    }
}
