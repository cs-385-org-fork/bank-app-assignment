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
            btnCreateAccount.BackColor = Color.FromArgb(128, 128, 255);
            btnCreateAccount.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateAccount.ForeColor = Color.Green;
            btnCreateAccount.Location = new Point(280, 314);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(230, 73);
            btnCreateAccount.TabIndex = 0;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(116, 25);
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
            lblBalance.Location = new Point(116, 112);
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
            txtBalance.Location = new Point(116, 151);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(196, 27);
            txtBalance.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(116, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
