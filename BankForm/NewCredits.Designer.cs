namespace BankForm
{
    partial class NewCredits
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbx_inform = new System.Windows.Forms.GroupBox();
            this.debitorList = new System.Windows.Forms.ListBox();
            this.btn_saveCredit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_creditAmount = new System.Windows.Forms.TextBox();
            this.grbx_inform.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_inform
            // 
            this.grbx_inform.Controls.Add(this.debitorList);
            this.grbx_inform.Controls.Add(this.btn_saveCredit);
            this.grbx_inform.Controls.Add(this.label3);
            this.grbx_inform.Controls.Add(this.label2);
            this.grbx_inform.Controls.Add(this.txb_creditAmount);
            this.grbx_inform.Location = new System.Drawing.Point(15, 12);
            this.grbx_inform.Name = "grbx_inform";
            this.grbx_inform.Size = new System.Drawing.Size(435, 262);
            this.grbx_inform.TabIndex = 3;
            this.grbx_inform.TabStop = false;
            this.grbx_inform.Text = "Информация";
            // 
            // debitorList
            // 
            this.debitorList.DisplayMember = "name_1";
            this.debitorList.FormattingEnabled = true;
            this.debitorList.ItemHeight = 16;
            this.debitorList.Location = new System.Drawing.Point(6, 49);
            this.debitorList.Name = "debitorList";
            this.debitorList.Size = new System.Drawing.Size(406, 84);
            this.debitorList.TabIndex = 9;
            this.debitorList.ValueMember = "id";
            // 
            // btn_saveCredit
            // 
            this.btn_saveCredit.Location = new System.Drawing.Point(6, 216);
            this.btn_saveCredit.Name = "btn_saveCredit";
            this.btn_saveCredit.Size = new System.Drawing.Size(406, 23);
            this.btn_saveCredit.TabIndex = 8;
            this.btn_saveCredit.Text = "Добавить";
            this.btn_saveCredit.UseVisualStyleBackColor = true;
            this.btn_saveCredit.Click += new System.EventHandler(this.btn_saveCredit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Сколько денег выдать:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберете клиента:";
            // 
            // txb_creditAmount
            // 
            this.txb_creditAmount.BackColor = System.Drawing.SystemColors.Info;
            this.txb_creditAmount.Location = new System.Drawing.Point(6, 174);
            this.txb_creditAmount.Name = "txb_creditAmount";
            this.txb_creditAmount.Size = new System.Drawing.Size(406, 22);
            this.txb_creditAmount.TabIndex = 2;
            this.txb_creditAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_creditAmount_KeyPress);
            this.txb_creditAmount.Leave += new System.EventHandler(this.txb_creditAmount_Leave);
            // 
            // NewCredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 293);
            this.Controls.Add(this.grbx_inform);
            this.Name = "NewCredits";
            this.Text = "Добавить кредит";
            this.grbx_inform.ResumeLayout(false);
            this.grbx_inform.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_inform;
        private System.Windows.Forms.ListBox debitorList;
        private System.Windows.Forms.Button btn_saveCredit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_creditAmount;
    }
}