namespace bank_app_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Customer cust = new Customer();

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            int nameBreak = txtName.Text.IndexOf(" ");
            cust.FirstName = txtName.Text.Substring(0, nameBreak);
            cust.LastName = txtName.Text.Substring(nameBreak + 1, txtName.Text.Length - nameBreak - 1);
            cust.AccountNumber = Int32.Parse(txtNumber.Text);
            cust.Balance = Double.Parse(txtBalance.Text);

            lblCurrentBalance.Text = ("Current Balance: $" + cust.Balance);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            cust.DepositTo(Int32.Parse(txtNumber.Text), Double.Parse(txtDeposit.Text));
            lblCurrentBalance.Text = ("Current Balance: $" + cust.Balance);
            Console.WriteLine(cust.Balance);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            cust.WithdrawFrom(Int32.Parse(txtNumber.Text), Double.Parse(txtWithdraw.Text));
            lblCurrentBalance.Text = ("Current Balance: $" + cust.Balance);
            Console.WriteLine(cust.Balance);
        }
    }
}
