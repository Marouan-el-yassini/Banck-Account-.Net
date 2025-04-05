namespace BankAccountt
{
    public partial class Form1 : Form
    {
        List<BanckAccount> a = new List<BanckAccount>();
        public Form1()
        {
            InitializeComponent();

        }

        private void WhitdrawBtn_Click(object sender, EventArgs e)
        {

            if (AccountGrid.SelectedRows.Count == 1 && numericUpDown1.Value > 0)
            {
                BanckAccount SelectedBanckAccount = AccountGrid.SelectedRows[0].DataBoundItem as BanckAccount;
                string message = SelectedBanckAccount.Withdraw((double)numericUpDown1.Value);
                
                RefrechGrid();
                numericUpDown1.Value = 0;
                MessageBox.Show(message);
            }
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                return;
            BanckAccount b = new BanckAccount(textBox1.Text);
            a.Add(b);
            RefrechGrid();
            textBox1.Text = string.Empty;
            MessageBox.Show("Account Created!");

        }
        private void RefrechGrid()
        {
            AccountGrid.DataSource = null;
            AccountGrid.DataSource = a;
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
           if(AccountGrid.SelectedRows.Count==1 && numericUpDown1.Value > 0)
            {
                BanckAccount SelectedBanckAccount = AccountGrid.SelectedRows[0].DataBoundItem as BanckAccount;
                string message = SelectedBanckAccount.Deposit((double)numericUpDown1.Value);
                RefrechGrid();
                numericUpDown1.Value = 0;
                MessageBox.Show(message);
            }
        }
    }
}
