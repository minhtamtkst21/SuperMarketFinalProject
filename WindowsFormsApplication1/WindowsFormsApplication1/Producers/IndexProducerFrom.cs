using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Producers
{
    public partial class IndexProducerFrom : Form
    {
        private ProducerManagement business;
        public IndexProducerFrom()
        {
            InitializeComponent();
            business = new ProducerManagement();
            this.Load += IndexProducerFrom_Load;
            this.btnAddProducer.Click += btnAddProducer_Click;
            this.btnEditProducer.Click += btnEditProducer_Click;
            this.btnDeleteProducer.Click += btnDeleteProducer_Click;
            this.btnViewCart.Click += btnViewCart_Click;
            this.btnViewItem.Click += btnViewItem_Click;
            this.btnClose.Click += btnClose_Click;
            this.grbViewProducer.DoubleClick += btnEditProducer_Click;
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

        void btnViewCart_Click(object sender, EventArgs e)
        {
            new WindowsFormsApplication1.Carts.IndexCartFrom().ShowDialog();
            this.Close();
        }

        void btnDeleteProducer_Click(object sender, EventArgs e)
        {
            if (this.grbViewProducer.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Do you want to delete this?", "Confirm",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var producer = (Item)this.grbViewProducer.SelectedRows[0].DataBoundItem;
                    this.business.DeleteProducer(producer.Id);
                    MessageBox.Show("Delete class successfully.");
                    this.ViewAllProducer();
                }
            }
        }

        void btnEditProducer_Click(object sender, EventArgs e)
        {
            if (this.grbViewProducer.SelectedRows.Count == 1)
            {
                var producer = (Producer)this.grbViewProducer.SelectedRows[0].DataBoundItem;
                var updateForm = new UpdateProducer(producer.Id);
                updateForm.ShowDialog();
                this.ViewAllProducer();
            }
        }

        void btnAddProducer_Click(object sender, EventArgs e)
        {
            new AddProducer().ShowDialog();
            this.ViewAllProducer();
        }

        void IndexProducerFrom_Load(object sender, EventArgs e)
        {
            this.ViewAllProducer();
        }

        private void ViewAllProducer()
        {
            var producer = this.business.getProducer();
            this.grbViewProducer.DataSource = producer;
        }
    }
}
