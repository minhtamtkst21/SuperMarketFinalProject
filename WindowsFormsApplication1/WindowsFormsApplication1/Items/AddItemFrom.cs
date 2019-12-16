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
        private Producers.ProducerManagement Pbusiness;
        public AddItemFrom()
        {
            InitializeComponent();
            business = new ItemManagement();
            Pbusiness = new Producers.ProducerManagement();
            this.btnCancel.Click += btnCancel_Click;
            this.btnSave.Click += btnSave_Click;
            this.Load += AddItemFrom_Load;
        }

        void AddItemFrom_Load(object sender, EventArgs e)
        {
            this.cobProducer.DataSource = this.Pbusiness.getProducer();
            this.cobProducer.DisplayMember = "Name";
            this.cobProducer.ValueMember = "Id";
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var code = this.txtCode.Text;
            var name = this.txtName.Text;
            var producer = (int) this.cobProducer.SelectedValue;
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
