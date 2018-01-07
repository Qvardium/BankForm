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
    public partial class Form1 : Form
    {
        DAL dal = new DAL();

        public Form1()
        {
            InitializeComponent();

            dgv_debitors.DataSource = dal.GetAllDebitors();
            SetingsDGV_Debitors();
        }

        void SetingsDGV_Debitors()
        {
            try
            {
                dgv_debitors.Columns["ID"].Visible = false;
                dgv_debitors.Columns["PostNumber"].Visible = false;
                dgv_debitors.Columns["PhoneNumber"].Visible = false;

            }
            catch
            {

            }
        }

        private void dgv_debitors_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txb_DebitorID.Text = dgv_debitors.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            txb_DebitorName.Text = dgv_debitors.Rows[e.RowIndex].Cells["name_1"].Value.ToString();
            txb_DebitorPostNumber.Text = dgv_debitors.Rows[e.RowIndex].Cells["PostNumber"].Value.ToString();
            string phone = dgv_debitors.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
            txb_DebitorPhoneNumber.Text = (phone == String.Empty) ? "Нет номера" : phone;

            dgv_credits.DataSource = dal.GetAllCreditsForDebitor(dgv_debitors.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_debitors.CellEnter += new DataGridViewCellEventHandler(dgv_debitors_CellEnter);
            dgv_credits.CellEnter += new DataGridViewCellEventHandler(dgv_credits_CellEnter);
        }

        void dgv_credits_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            dgv_payments.DataSource = dal.GetAllPaymentsForCredit(dgv_credits.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть приложение?", "Bank Manager", MessageBoxButtons.YesNo) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newDebitor nd = new newDebitor();
            if(nd.ShowDialog()==DialogResult.OK) MessageBox.Show("Новый дебитор создан","Банк",MessageBoxButtons.OK);
            else MessageBox.Show("Новый дебитор не создан", "Банк", MessageBoxButtons.OK);
        }
    }
}
