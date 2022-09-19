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
    public partial class BalanceCheck : Form
    {
        AtmUserDatastore dataStore;
        public BalanceCheck()
        {
            InitializeComponent();
            dataStore = new AtmUserDatastore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        private void btnBalanceCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPin.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter valid Details");
                    return;
                }
                
                int pinno = Convert.ToInt32(txtPin.Text);

                AtmUser atmUser = dataStore.GetBalance(pinno);
                if (atmUser == null)
                {

                    MessageBox.Show("Wrong Passkey please provide correct Details" );


                }
                else
                {
                    lblBalnace.Text = atmUser.Balance.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception :\n" + ex.Message);
            }

        }

        private void BalanceCheck_Load(object sender, EventArgs e)
        {
           
        }
    }
}
