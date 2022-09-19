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

    public partial class TransactionHistory : Form

    {
        AtmUserDatastore dataStore;
        public TransactionHistory()
        {
            InitializeComponent();
            dataStore = new AtmUserDatastore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtPin.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter valid Details");
                    return;
                }

                long cardno = long.Parse(LoginAtm.instance.txt1.Text);
                int pinno = Convert.ToInt32(txtPin.Text);


                AtmUser atmUser = dataStore.GetBalance(pinno);
                if (atmUser == null)
                {

                    MessageBox.Show("Wrong Passkey please provide correct Details");


                }
                else
                {
                    historyDatagrid.DataSource = dataStore.GetTransactions(cardno);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : \n" + ex.Message);
            }
        }
    }
}
