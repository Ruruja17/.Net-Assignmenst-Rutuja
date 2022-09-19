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
    public partial class Withdraw : Form
    {
        AtmUserDatastore dataStore;
        public Withdraw()
        {
            InitializeComponent();
            dataStore = new AtmUserDatastore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            long cardno = long.Parse(LoginAtm.instance.txt1.Text);
            int pinno = Convert.ToInt32(txtPin.Text);
            decimal amount = Convert.ToDecimal(txtAmount.Text);
            DateTime Tranc_Date = DateTime.Today; 
             
            if(amount <= 500)
            {
                MessageBox.Show("Please Enter amount above 500 !");
                return;
            }
            if (amount >=20000)
            {
                MessageBox.Show("you can only withdraw  under 20000!!");
                return;
            }
            
          


                try
                {
                    if (txtPin.Text == String.Empty || txtAmount.Text == String.Empty)
                    {
                        MessageBox.Show("Please Enter valid Details");
                        return;
                    }

                    AtmUser atmUser = dataStore.GetBalance(pinno);


                   
                long count1 = dataStore.WithdrawLimit(cardno, Tranc_Date);

                //count1= Convert.ToInt32(count1);    

                if (count1 >= 2)
                {
                    MessageBox.Show("You're Exceeded Your Limit !!");
                }

                else
                {
                    int count = dataStore.GetWithdraw(amount, cardno);
                    if (count == 1)
                    {
                        MessageBox.Show("Your Transaction Done SuccessFully", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }



                    int count_add = dataStore.WithdrawDecr(cardno, amount);
                    if (count_add == 1)
                    {
                        MessageBox.Show("Your Cash is Debited !!", " ", MessageBoxButtons.OK);
                    }



                    if (atmUser == null)
                    {

                        MessageBox.Show("Wrong Passkey please provide correct Details");


                    }
                    else

                    {
                        MessageBox.Show("Your Transaction is Success!!");


                    }
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception :\n" + ex.Message);
                }
            }


        
    }

}
    