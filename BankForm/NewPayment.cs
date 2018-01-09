using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankForm
{
    public partial class NewPayment : Form
    {
        DAL dal = new DAL();

        public NewPayment()
        {
            InitializeComponent();
            debitorList.DataSource = dal.GetAllDebitors();
            creditList.DataSource = dal.GetAllCreditsForDebitor(debitorList.SelectedValue.ToString());

        }

        private void btn_savePayment_Click(object sender, EventArgs e)
        {
            if (dal.addPayment(Int32.Parse(creditList.SelectedValue.ToString()),
                Int32.Parse(txb_payment.Text.Trim()))) this.DialogResult = DialogResult.OK;
            else this.DialogResult = DialogResult.Cancel;
        }

        private void debitorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            creditList.DataSource = dal.GetAllCreditsForDebitor(debitorList.SelectedValue.ToString());
            int i=0;
        }
    }
}
