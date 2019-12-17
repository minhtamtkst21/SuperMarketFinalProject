using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnLogin.Click += btnLogin_Click;
        }

        void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtPass.Text == "vlu")
            {
                new WindowsFormsApplication1.Items.IndexItemFrom().ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Fail Login!!!!!!!!!!!");
                this.txtPass.Text = null;
            }
        }
    }
}
