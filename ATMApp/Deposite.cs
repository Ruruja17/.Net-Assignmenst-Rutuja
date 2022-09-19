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
    public partial class Deposite : Form
    {
        AtmUserDatastore dataStore;
        
        public Deposite()
        {
            InitializeComponent();
            dataStore = new AtmUserDatastore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        private void btnDeposite_Click(object sender, EventArgs e)
        {
            long cardno = long.Parse(LoginAtm.instance.txt1.Text);
            int pinno = Convert.ToInt32(txtPin.Text);
            decimal amount = Convert.ToDecimal(txtAmount.Text);
       
            try
            {
                if (txtPin.Text == String.Empty || txtAmount.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter valid Details");
                    return;
                }
               
                AtmUser atmUser = dataStore.GetBalance(pinno);
                int count = dataStore.GetDeposit( amount, cardno);
                if(count ==1)
                {
                    MessageBox.Show("Your Transaction Done SuccessFully"," ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
               
                int count_add = dataStore.DepositIncr(cardno, amount);  
                if (count_add == 1)
                {
                    MessageBox.Show("Your Amount is Credited!", " ", MessageBoxButtons.OK);
                }
      


                if (atmUser == null)
                {

                    MessageBox.Show("Wrong Passkey please provide correct Details");


                }
                else

                {
                        MessageBox.Show("Have a Great Day !!!");
                    
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception :\n" + ex.Message);
            }

        }
    }
}
