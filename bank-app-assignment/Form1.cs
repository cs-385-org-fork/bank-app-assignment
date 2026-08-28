namespace bank_app_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();

            int nameBreak = txtName.Text.IndexOf(" ");
            cust.FirstName.set = "eabure";
        }
    }
}
