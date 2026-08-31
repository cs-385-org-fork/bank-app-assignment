using System.Reflection.Emit;

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

            lblCurrentBalance.Text = ("Current Balance: " + String.Format("{0:C2}", cust.Balance));
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            cust.DepositTo(Int32.Parse(txtNumber.Text), Double.Parse(txtDeposit.Text));
            if (cust.Balance < 0) { lblCurrentBalance.ForeColor = System.Drawing.Color.Red; lblCurrentBalance.Text = ("Current Balance: -" + String.Format("{0:C2}", cust.Balance) + " Overdrawn"); }
            else { lblCurrentBalance.ForeColor = System.Drawing.Color.Black; lblCurrentBalance.Text = ("Current Balance: " + String.Format("{0:C2}", cust.Balance)); }
            Console.WriteLine(cust.Balance);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            cust.WithdrawFrom(Int32.Parse(txtNumber.Text), Double.Parse(txtWithdraw.Text));
            if (cust.Balance < 0) { lblCurrentBalance.ForeColor = System.Drawing.Color.Red; lblCurrentBalance.Text = ("Current Balance: -" + String.Format("{0:C2}", cust.Balance) + " Overdrawn"); }
            else { lblCurrentBalance.ForeColor = System.Drawing.Color.Black; lblCurrentBalance.Text = ("Current Balance: " + String.Format("{0:C2}", cust.Balance)); }
            Console.WriteLine(cust.Balance);
        }

        private void txtDeposit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDeposit_Click(sender, e);
            }
        }

        private void txtWithdraw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnWithdraw_Click(sender, e);
            }
        }
    }
}
