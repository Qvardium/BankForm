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
    public partial class newDebitor : Form
    {
        DAL dal = new DAL();

        public newDebitor()
        {
            InitializeComponent();
        }

        private void btn_saveDebitor_Click(object sender, EventArgs e)
        {
            if(dal.saveNewDebitor(txb_DebitorName.Text.Trim(),
                                txb_DebitorPostNumber.Text.Trim(),
                                txb_DebitorPhoneNumber.Text.Trim())) this.DialogResult = DialogResult.OK;
            else this.DialogResult = DialogResult.Cancel;
        }
    }
}
