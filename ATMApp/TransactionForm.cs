using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATMLibrary;
using System.Configuration;


namespace ATMApp
{
    public partial class TransactionForm : Form
    {
        AtmUserDatastore dataStore;
        public TransactionForm()
        {
            InitializeComponent();
            dataStore = new AtmUserDatastore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
            
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBalanceCheck_Click(object sender, EventArgs e)
        {
            BalanceCheck balanceCheck = new BalanceCheck(); 
            
            balanceCheck.Show();


        }

        private void btnDeposite_Click(object sender, EventArgs e)
        {
            Deposite deposite = new Deposite();
            deposite.Show();    
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();    
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            TransactionHistory transactionHistory = new TransactionHistory();
            transactionHistory.Show();  
        }
    }
}
