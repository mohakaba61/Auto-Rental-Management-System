using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMSClientApp
{
    public partial class frmMailWelcomeForm : Form
    {
        public frmMailWelcomeForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnERP_Click(object sender, EventArgs e)
        {
            //Declare object of ERP Form
            frmERPSystemForm objERP = new frmERPSystemForm();
            //Hide this form (frmMainWelcomeForm)
            this.Hide();
            //Display ERP System Form as Dialog Form
            //Dialog mode means program flow will STOP until the
            //Customer Management form Closes or Hides
            objERP.ShowDialog();
            //Once the ERP System Form closes or hides,
            //Control goes back to this form and this form
            //needs to Display itself since ERP System Form is
            //either hidden or cloased.
            this.Show();

        }

        private void frmMailWelcomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
