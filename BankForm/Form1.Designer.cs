namespace BankForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbx_debitors = new System.Windows.Forms.GroupBox();
            this.dgv_debitors = new System.Windows.Forms.DataGridView();
            this.grbx_inform = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_DebitorPhoneNumber = new System.Windows.Forms.TextBox();
            this.txb_DebitorPostNumber = new System.Windows.Forms.TextBox();
            this.txb_DebitorName = new System.Windows.Forms.TextBox();
            this.txb_DebitorID = new System.Windows.Forms.TextBox();
            this.grbx_credits = new System.Windows.Forms.GroupBox();
            this.dgv_credits = new System.Windows.Forms.DataGridView();
            this.grbx_payments = new System.Windows.Forms.GroupBox();
            this.dgv_payments = new System.Windows.Forms.DataGridView();
            this.grb_Search = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дебиторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кредитToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьНовыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.платежиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйПлатежToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbx_debitors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_debitors)).BeginInit();
            this.grbx_inform.SuspendLayout();
            this.grbx_credits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_credits)).BeginInit();
            this.grbx_payments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payments)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_debitors
            // 
            this.grbx_debitors.Controls.Add(this.dgv_debitors);
            this.grbx_debitors.Location = new System.Drawing.Point(12, 107);
            this.grbx_debitors.Name = "grbx_debitors";
            this.grbx_debitors.Size = new System.Drawing.Size(409, 170);
            this.grbx_debitors.TabIndex = 0;
            this.grbx_debitors.TabStop = false;
            this.grbx_debitors.Text = "Дебиторы";
            // 
            // dgv_debitors
            // 
            this.dgv_debitors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_debitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_debitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_debitors.Location = new System.Drawing.Point(3, 18);
            this.dgv_debitors.Name = "dgv_debitors";
            this.dgv_debitors.RowTemplate.Height = 24;
            this.dgv_debitors.Size = new System.Drawing.Size(403, 149);
            this.dgv_debitors.TabIndex = 0;
            // 
            // grbx_inform
            // 
            this.grbx_inform.Controls.Add(this.label4);
            this.grbx_inform.Controls.Add(this.label3);
            this.grbx_inform.Controls.Add(this.label2);
            this.grbx_inform.Controls.Add(this.label1);
            this.grbx_inform.Controls.Add(this.txb_DebitorPhoneNumber);
            this.grbx_inform.Controls.Add(this.txb_DebitorPostNumber);
            this.grbx_inform.Controls.Add(this.txb_DebitorName);
            this.grbx_inform.Controls.Add(this.txb_DebitorID);
            this.grbx_inform.Location = new System.Drawing.Point(427, 107);
            this.grbx_inform.Name = "grbx_inform";
            this.grbx_inform.Size = new System.Drawing.Size(888, 170);
            this.grbx_inform.TabIndex = 1;
            this.grbx_inform.TabStop = false;
            this.grbx_inform.Text = "Информация";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "ФИО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // txb_DebitorPhoneNumber
            // 
            this.txb_DebitorPhoneNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txb_DebitorPhoneNumber.Location = new System.Drawing.Point(111, 105);
            this.txb_DebitorPhoneNumber.Name = "txb_DebitorPhoneNumber";
            this.txb_DebitorPhoneNumber.ReadOnly = true;
            this.txb_DebitorPhoneNumber.Size = new System.Drawing.Size(771, 22);
            this.txb_DebitorPhoneNumber.TabIndex = 3;
            // 
            // txb_DebitorPostNumber
            // 
            this.txb_DebitorPostNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txb_DebitorPostNumber.Location = new System.Drawing.Point(111, 77);
            this.txb_DebitorPostNumber.Name = "txb_DebitorPostNumber";
            this.txb_DebitorPostNumber.ReadOnly = true;
            this.txb_DebitorPostNumber.Size = new System.Drawing.Size(771, 22);
            this.txb_DebitorPostNumber.TabIndex = 2;
            // 
            // txb_DebitorName
            // 
            this.txb_DebitorName.BackColor = System.Drawing.SystemColors.Info;
            this.txb_DebitorName.Location = new System.Drawing.Point(111, 49);
            this.txb_DebitorName.Name = "txb_DebitorName";
            this.txb_DebitorName.ReadOnly = true;
            this.txb_DebitorName.Size = new System.Drawing.Size(771, 22);
            this.txb_DebitorName.TabIndex = 1;
            // 
            // txb_DebitorID
            // 
            this.txb_DebitorID.BackColor = System.Drawing.SystemColors.Info;
            this.txb_DebitorID.Location = new System.Drawing.Point(111, 21);
            this.txb_DebitorID.Name = "txb_DebitorID";
            this.txb_DebitorID.ReadOnly = true;
            this.txb_DebitorID.Size = new System.Drawing.Size(771, 22);
            this.txb_DebitorID.TabIndex = 0;
            // 
            // grbx_credits
            // 
            this.grbx_credits.Controls.Add(this.dgv_credits);
            this.grbx_credits.Location = new System.Drawing.Point(12, 283);
            this.grbx_credits.Name = "grbx_credits";
            this.grbx_credits.Size = new System.Drawing.Size(1303, 206);
            this.grbx_credits.TabIndex = 2;
            this.grbx_credits.TabStop = false;
            this.grbx_credits.Text = "Кридиты";
            // 
            // dgv_credits
            // 
            this.dgv_credits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_credits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_credits.Location = new System.Drawing.Point(3, 18);
            this.dgv_credits.Name = "dgv_credits";
            this.dgv_credits.RowTemplate.Height = 24;
            this.dgv_credits.Size = new System.Drawing.Size(1297, 185);
            this.dgv_credits.TabIndex = 0;
            // 
            // grbx_payments
            // 
            this.grbx_payments.Controls.Add(this.dgv_payments);
            this.grbx_payments.Location = new System.Drawing.Point(15, 495);
            this.grbx_payments.Name = "grbx_payments";
            this.grbx_payments.Size = new System.Drawing.Size(1303, 201);
            this.grbx_payments.TabIndex = 3;
            this.grbx_payments.TabStop = false;
            this.grbx_payments.Text = "Платежи";
            // 
            // dgv_payments
            // 
            this.dgv_payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_payments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_payments.Location = new System.Drawing.Point(3, 18);
            this.dgv_payments.Name = "dgv_payments";
            this.dgv_payments.RowTemplate.Height = 24;
            this.dgv_payments.Size = new System.Drawing.Size(1297, 180);
            this.dgv_payments.TabIndex = 0;
            // 
            // grb_Search
            // 
            this.grb_Search.Location = new System.Drawing.Point(12, 31);
            this.grb_Search.Name = "grb_Search";
            this.grb_Search.Size = new System.Drawing.Size(1303, 70);
            this.grb_Search.TabIndex = 4;
            this.grb_Search.TabStop = false;
            this.grb_Search.Text = "Поиск";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.дебиторыToolStripMenuItem,
            this.кредитToolStripMenuItem,
            this.платежиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1327, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьВCSVToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьВCSVToolStripMenuItem
            // 
            this.сохранитьВCSVToolStripMenuItem.Name = "сохранитьВCSVToolStripMenuItem";
            this.сохранитьВCSVToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.сохранитьВCSVToolStripMenuItem.Text = "Сохранить в CSV";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // дебиторыToolStripMenuItem
            // 
            this.дебиторыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.дебиторыToolStripMenuItem.Name = "дебиторыToolStripMenuItem";
            this.дебиторыToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.дебиторыToolStripMenuItem.Text = "Дебитор";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // кредитToolStripMenuItem
            // 
            this.кредитToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьНовыйToolStripMenuItem});
            this.кредитToolStripMenuItem.Name = "кредитToolStripMenuItem";
            this.кредитToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.кредитToolStripMenuItem.Text = "Кредит";
            // 
            // открытьНовыйToolStripMenuItem
            // 
            this.открытьНовыйToolStripMenuItem.Name = "открытьНовыйToolStripMenuItem";
            this.открытьНовыйToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.открытьНовыйToolStripMenuItem.Text = "Открыть новый";
            // 
            // платежиToolStripMenuItem
            // 
            this.платежиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйПлатежToolStripMenuItem});
            this.платежиToolStripMenuItem.Name = "платежиToolStripMenuItem";
            this.платежиToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.платежиToolStripMenuItem.Text = "Платежи";
            // 
            // новыйПлатежToolStripMenuItem
            // 
            this.новыйПлатежToolStripMenuItem.Name = "новыйПлатежToolStripMenuItem";
            this.новыйПлатежToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.новыйПлатежToolStripMenuItem.Text = "Новый платеж";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 706);
            this.Controls.Add(this.grb_Search);
            this.Controls.Add(this.grbx_payments);
            this.Controls.Add(this.grbx_credits);
            this.Controls.Add(this.grbx_inform);
            this.Controls.Add(this.grbx_debitors);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bank Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbx_debitors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_debitors)).EndInit();
            this.grbx_inform.ResumeLayout(false);
            this.grbx_inform.PerformLayout();
            this.grbx_credits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_credits)).EndInit();
            this.grbx_payments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payments)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_debitors;
        private System.Windows.Forms.DataGridView dgv_debitors;
        private System.Windows.Forms.GroupBox grbx_inform;
        private System.Windows.Forms.GroupBox grbx_credits;
        private System.Windows.Forms.GroupBox grbx_payments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_DebitorPhoneNumber;
        private System.Windows.Forms.TextBox txb_DebitorPostNumber;
        private System.Windows.Forms.TextBox txb_DebitorName;
        private System.Windows.Forms.TextBox txb_DebitorID;
        private System.Windows.Forms.DataGridView dgv_credits;
        private System.Windows.Forms.DataGridView dgv_payments;
        private System.Windows.Forms.GroupBox grb_Search;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дебиторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кредитToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьНовыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem платежиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйПлатежToolStripMenuItem;
    }
}

