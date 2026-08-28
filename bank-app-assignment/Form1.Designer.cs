namespace bank_app_assignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCreateAccount = new Button();
            lblName = new Label();
            lblNumber = new Label();
            lblBalance = new Label();
            txtNumber = new TextBox();
            txtBalance = new TextBox();
            txtName = new TextBox();
            lblCurrentBalance = new Label();
            txtDeposit = new TextBox();
            txtWithdraw = new TextBox();
            btnDeposit = new Button();
            btnWithdraw = new Button();
            SuspendLayout();
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = SystemColors.Control;
            btnCreateAccount.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateAccount.ForeColor = Color.Green;
            btnCreateAccount.Location = new Point(240, 138);
            btnCreateAccount.Margin = new Padding(3, 2, 3, 2);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(201, 55);
            btnCreateAccount.TabIndex = 0;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(102, 19);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(409, 19);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(51, 15);
            lblNumber.TabIndex = 2;
            lblNumber.Text = "Number";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(102, 68);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(83, 15);
            lblBalance.TabIndex = 3;
            lblBalance.Text = "Initial Balance:";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(409, 36);
            txtNumber.Margin = new Padding(3, 2, 3, 2);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(167, 23);
            txtNumber.TabIndex = 4;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(102, 94);
            txtBalance.Margin = new Padding(3, 2, 3, 2);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(172, 23);
            txtBalance.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(102, 36);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(176, 23);
            txtName.TabIndex = 6;
            // 
            // lblCurrentBalance
            // 
            lblCurrentBalance.AutoSize = true;
            lblCurrentBalance.Location = new Point(104, 218);
            lblCurrentBalance.Name = "lblCurrentBalance";
            lblCurrentBalance.Size = new Size(94, 15);
            lblCurrentBalance.TabIndex = 7;
            lblCurrentBalance.Text = "Current Balance:";
            // 
            // txtDeposit
            // 
            txtDeposit.Location = new Point(104, 255);
            txtDeposit.Margin = new Padding(3, 2, 3, 2);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(110, 23);
            txtDeposit.TabIndex = 8;
            // 
            // txtWithdraw
            // 
            txtWithdraw.Location = new Point(424, 255);
            txtWithdraw.Margin = new Padding(3, 2, 3, 2);
            txtWithdraw.Name = "txtWithdraw";
            txtWithdraw.Size = new Size(110, 23);
            txtWithdraw.TabIndex = 9;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(112, 280);
            btnDeposit.Margin = new Padding(3, 2, 3, 2);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(82, 22);
            btnDeposit.TabIndex = 10;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(438, 280);
            btnWithdraw.Margin = new Padding(3, 2, 3, 2);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(82, 22);
            btnWithdraw.TabIndex = 11;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnWithdraw);
            Controls.Add(btnDeposit);
            Controls.Add(txtWithdraw);
            Controls.Add(txtDeposit);
            Controls.Add(lblCurrentBalance);
            Controls.Add(txtName);
            Controls.Add(txtBalance);
            Controls.Add(txtNumber);
            Controls.Add(lblBalance);
            Controls.Add(lblNumber);
            Controls.Add(lblName);
            Controls.Add(btnCreateAccount);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateAccount;
        private Label lblName;
        private Label lblNumber;
        private Label lblBalance;
        private TextBox txtNumber;
        private TextBox txtBalance;
        private TextBox txtName;
        private Label lblCurrentBalance;
        private TextBox txtDeposit;
        private TextBox txtWithdraw;
        private Button btnDeposit;
        private Button btnWithdraw;
    }
}
