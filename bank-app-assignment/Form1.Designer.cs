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
            btnCreateAccount.Location = new Point(274, 184);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(230, 73);
            btnCreateAccount.TabIndex = 0;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(117, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(467, 25);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(63, 20);
            lblNumber.TabIndex = 2;
            lblNumber.Text = "Number";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(117, 90);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(105, 20);
            lblBalance.TabIndex = 3;
            lblBalance.Text = "Initial Balance:";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(467, 48);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(190, 27);
            txtNumber.TabIndex = 4;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(117, 125);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(196, 27);
            txtBalance.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(117, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(201, 27);
            txtName.TabIndex = 6;
            // 
            // lblCurrentBalance
            // 
            lblCurrentBalance.AutoSize = true;
            lblCurrentBalance.Location = new Point(119, 291);
            lblCurrentBalance.Name = "lblCurrentBalance";
            lblCurrentBalance.Size = new Size(116, 20);
            lblCurrentBalance.TabIndex = 7;
            lblCurrentBalance.Text = "Current Balance:";
            // 
            // txtDeposit
            // 
            txtDeposit.Location = new Point(119, 340);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(125, 27);
            txtDeposit.TabIndex = 8;
            // 
            // txtWithdraw
            // 
            txtWithdraw.Location = new Point(484, 340);
            txtWithdraw.Name = "txtWithdraw";
            txtWithdraw.Size = new Size(125, 27);
            txtWithdraw.TabIndex = 9;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(128, 373);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(94, 29);
            btnDeposit.TabIndex = 10;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(500, 373);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(94, 29);
            btnWithdraw.TabIndex = 11;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
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
