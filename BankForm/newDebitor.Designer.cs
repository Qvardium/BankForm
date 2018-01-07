namespace BankForm
{
    partial class newDebitor
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_DebitorPhoneNumber = new System.Windows.Forms.TextBox();
            this.txb_DebitorPostNumber = new System.Windows.Forms.TextBox();
            this.txb_DebitorName = new System.Windows.Forms.TextBox();
            this.btn_saveDebitor = new System.Windows.Forms.Button();
            this.grbx_inform.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_inform
            // 
            this.grbx_inform.Controls.Add(this.btn_saveDebitor);
            this.grbx_inform.Controls.Add(this.label4);
            this.grbx_inform.Controls.Add(this.label3);
            this.grbx_inform.Controls.Add(this.label2);
            this.grbx_inform.Controls.Add(this.txb_DebitorPhoneNumber);
            this.grbx_inform.Controls.Add(this.txb_DebitorPostNumber);
            this.grbx_inform.Controls.Add(this.txb_DebitorName);
            this.grbx_inform.Location = new System.Drawing.Point(12, 12);
            this.grbx_inform.Name = "grbx_inform";
            this.grbx_inform.Size = new System.Drawing.Size(526, 219);
            this.grbx_inform.TabIndex = 2;
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
            // txb_DebitorPhoneNumber
            // 
            this.txb_DebitorPhoneNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txb_DebitorPhoneNumber.Location = new System.Drawing.Point(111, 105);
            this.txb_DebitorPhoneNumber.Name = "txb_DebitorPhoneNumber";
            this.txb_DebitorPhoneNumber.Size = new System.Drawing.Size(406, 22);
            this.txb_DebitorPhoneNumber.TabIndex = 3;
            // 
            // txb_DebitorPostNumber
            // 
            this.txb_DebitorPostNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txb_DebitorPostNumber.Location = new System.Drawing.Point(111, 77);
            this.txb_DebitorPostNumber.Name = "txb_DebitorPostNumber";
            this.txb_DebitorPostNumber.Size = new System.Drawing.Size(406, 22);
            this.txb_DebitorPostNumber.TabIndex = 2;
            // 
            // txb_DebitorName
            // 
            this.txb_DebitorName.BackColor = System.Drawing.SystemColors.Info;
            this.txb_DebitorName.Location = new System.Drawing.Point(111, 49);
            this.txb_DebitorName.Name = "txb_DebitorName";
            this.txb_DebitorName.Size = new System.Drawing.Size(406, 22);
            this.txb_DebitorName.TabIndex = 1;
            // 
            // btn_saveDebitor
            // 
            this.btn_saveDebitor.Location = new System.Drawing.Point(111, 190);
            this.btn_saveDebitor.Name = "btn_saveDebitor";
            this.btn_saveDebitor.Size = new System.Drawing.Size(406, 23);
            this.btn_saveDebitor.TabIndex = 8;
            this.btn_saveDebitor.Text = "Добавить";
            this.btn_saveDebitor.UseVisualStyleBackColor = true;
            this.btn_saveDebitor.Click += new System.EventHandler(this.btn_saveDebitor_Click);
            // 
            // newDebitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 271);
            this.Controls.Add(this.grbx_inform);
            this.Name = "newDebitor";
            this.Text = "newDebitor";
            this.grbx_inform.ResumeLayout(false);
            this.grbx_inform.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_inform;
        private System.Windows.Forms.Button btn_saveDebitor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_DebitorPhoneNumber;
        private System.Windows.Forms.TextBox txb_DebitorPostNumber;
        private System.Windows.Forms.TextBox txb_DebitorName;
    }
}