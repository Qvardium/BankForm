namespace BankForm
{
    partial class NewPayment
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
            this.creditList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.debitorList = new System.Windows.Forms.ListBox();
            this.btn_savePayment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_payment = new System.Windows.Forms.TextBox();
            this.grbx_inform.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_inform
            // 
            this.grbx_inform.Controls.Add(this.creditList);
            this.grbx_inform.Controls.Add(this.label1);
            this.grbx_inform.Controls.Add(this.debitorList);
            this.grbx_inform.Controls.Add(this.btn_savePayment);
            this.grbx_inform.Controls.Add(this.label3);
            this.grbx_inform.Controls.Add(this.label2);
            this.grbx_inform.Controls.Add(this.txb_payment);
            this.grbx_inform.Location = new System.Drawing.Point(12, 12);
            this.grbx_inform.Name = "grbx_inform";
            this.grbx_inform.Size = new System.Drawing.Size(435, 376);
            this.grbx_inform.TabIndex = 4;
            this.grbx_inform.TabStop = false;
            this.grbx_inform.Text = "Информация";
            // 
            // creditList
            // 
            this.creditList.DisplayMember = "balance";
            this.creditList.FormattingEnabled = true;
            this.creditList.ItemHeight = 16;
            this.creditList.Location = new System.Drawing.Point(6, 188);
            this.creditList.Name = "creditList";
            this.creditList.Size = new System.Drawing.Size(406, 84);
            this.creditList.TabIndex = 11;
            this.creditList.ValueMember = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Выберете кредит:";
            // 
            // debitorList
            // 
            this.debitorList.DisplayMember = "name_1";
            this.debitorList.FormattingEnabled = true;
            this.debitorList.ItemHeight = 16;
            this.debitorList.Location = new System.Drawing.Point(6, 49);
            this.debitorList.Name = "debitorList";
            this.debitorList.Size = new System.Drawing.Size(406, 100);
            this.debitorList.TabIndex = 9;
            this.debitorList.ValueMember = "id";
            this.debitorList.SelectedIndexChanged += new System.EventHandler(this.debitorList_SelectedIndexChanged);
            // 
            // btn_savePayment
            // 
            this.btn_savePayment.Location = new System.Drawing.Point(6, 344);
            this.btn_savePayment.Name = "btn_savePayment";
            this.btn_savePayment.Size = new System.Drawing.Size(406, 23);
            this.btn_savePayment.TabIndex = 8;
            this.btn_savePayment.Text = "Добавить";
            this.btn_savePayment.UseVisualStyleBackColor = true;
            this.btn_savePayment.Click += new System.EventHandler(this.btn_savePayment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Сколько денег заплатить:";
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
            // txb_payment
            // 
            this.txb_payment.BackColor = System.Drawing.SystemColors.Info;
            this.txb_payment.Location = new System.Drawing.Point(6, 302);
            this.txb_payment.Name = "txb_payment";
            this.txb_payment.Size = new System.Drawing.Size(406, 22);
            this.txb_payment.TabIndex = 2;
            // 
            // NewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 403);
            this.Controls.Add(this.grbx_inform);
            this.Name = "NewPayment";
            this.Text = "NewPayment";
            this.grbx_inform.ResumeLayout(false);
            this.grbx_inform.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_inform;
        private System.Windows.Forms.ListBox creditList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox debitorList;
        private System.Windows.Forms.Button btn_savePayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_payment;
    }
}