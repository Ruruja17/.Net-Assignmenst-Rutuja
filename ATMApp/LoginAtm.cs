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
    public partial class LoginAtm : Form
    {
        AtmUserDatastore dataStore;

        public static LoginAtm instance;
        public TextBox txt1;
        public TextBox txt2;    
        
        public LoginAtm()
        {
            InitializeComponent();
            dataStore = new AtmUserDatastore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
            instance = this;
            txt1 = txtCardNo;
            txt2 = txtCardNo;   

        }

        private void LoginAtm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCardNo.Text == String.Empty && txtPin.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter valid Details");
                    return;
                }
                long cardno = long.Parse(txtCardNo.Text.ToString());
                long pinno = Convert.ToInt32(txtPin.Text);

               AtmUser atmUser = dataStore.GetValidUser(cardno, pinno);
                if (atmUser == null)
                { 
                
                    MessageBox.Show("No User Found please provide valid deatils" );


                }
                else
                {
                    MessageBox.Show("Valid User");
                    TransactionForm transactionForm = new TransactionForm();
                    transactionForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception :\n" + ex.Message);
            }



        }
    }
}
