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
            SuspendLayout();
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = SystemColors.Control;
            btnCreateAccount.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateAccount.ForeColor = Color.Green;
            btnCreateAccount.Location = new Point(245, 236);
            btnCreateAccount.Margin = new Padding(3, 2, 3, 2);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(201, 55);
            btnCreateAccount.TabIndex = 0;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
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
            lblBalance.Location = new Point(102, 84);
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
            txtBalance.Location = new Point(102, 113);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
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
    }
}
