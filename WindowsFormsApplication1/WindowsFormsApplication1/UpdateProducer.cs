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
    public partial class UpdateProducer : Form
    {
        public int producerId;
        private ProducerManagement business;
        public UpdateProducer(int id)
        {
            InitializeComponent();
            business = new ProducerManagement();
            producerId = id;
            this.Load += UpdateProducer_Load;
            this.btnCancel.Click += btnCancel_Click;
            this.btnSave.Click += btnSave_Click;
        }

        void UpdateProducer_Load(object sender, EventArgs e)
        {
            var producer = this.business.getProducers(this.producerId);
            this.txtCode.Text = producer.Code;
            this.txtName.Text = producer.Name;
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var name = this.txtName.Text;

            this.business.UpdateProducer(this.producerId, name);
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
