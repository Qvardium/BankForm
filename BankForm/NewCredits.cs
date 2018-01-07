using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace BankForm
{
    public partial class NewCredits : Form
    {
        DAL dl = new DAL();

        public NewCredits()
        {
            ArrayList allDebitors = dl.GetAllDebitors();
            InitializeComponent();
            if (allDebitors.Count == 0) btn_saveCredit.Enabled = false;
            debitorList.DataSource = allDebitors;
        }

        private void btn_saveCredit_Click(object sender, EventArgs e)
        {
            if (dl.saveCredit(Int32.Parse(debitorList.SelectedValue.ToString()),
                Int32.Parse(txb_creditAmount.Text.Trim()))) this.DialogResult = DialogResult.OK;
            else this.DialogResult = DialogResult.Cancel;
        }

        private void txb_creditAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8) e.Handled = true;
        }

        private void txb_creditAmount_Leave(object sender, EventArgs e)
        {
            //if(txb_creditAmount.Text==string.Empty || Int32.Parse(txb_creditAmount.Text.Trim())<100))
        }
    }
}
