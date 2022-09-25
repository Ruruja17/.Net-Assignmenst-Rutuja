using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMAtm_ASSIGN.Models;
using MVVMAtm_ASSIGN.Commands;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows;
using System.ComponentModel;
using MVVMAtm_ASSIGN.Views;
namespace MVVMAtm_ASSIGN.ViewModels
{
    public class AtmViewModel : INotifyPropertyChanged
    {

        AtmContext db = null;
      
        ObservableCollection<Card> cardList = null;
        ObservableCollection<User> userList = null;


        #region Properties

        private User userObj = new User();
        private Card cardObj = new Card();

        public string UI_CardNo 
        {
            get { return userObj.CardNo.ToString(); }   
            set
            {
                if(value != string.Empty)
                {
                    userObj.CardNo = long.Parse(value);
                    OnPropertyChanged("UI_CardNo");
                }
            }
        }

        public string UI_Pin
        {
            get { return userObj.Pin.ToString(); }  
            set
            {
                userObj.Pin = Convert.ToInt32(value);
                OnPropertyChanged("UI_Pin");
            }
        }

        public string UI_Balance
        {
            get { return userObj.Balance.ToString(); }
            set
            {
                userObj.Balance = Convert.ToInt32(value) ;
                OnPropertyChanged("UI_Balance");
            }
        }

        public string UIC_Transaction_Id
        {
            get { return cardObj.Transaction_Id.ToString(); }
            set
            {
                cardObj.Transaction_Id = Convert.ToInt32(value);
                OnPropertyChanged("UIC_Transaction_Id");
            }
        }
        public string UIC_CardNo
        {
            get { return cardObj.CardNo.ToString(); }
            set
            {
                cardObj.CardNo = long.Parse(value);
                OnPropertyChanged("UIC_CardNo");
            }
        }

        public string UIC_Transaction_Date
        {
            get { return cardObj.Transaction_Date.ToString(); }
            set
            {
                cardObj.Transaction_Date = Convert.ToDateTime(value);
                OnPropertyChanged("UIC_TranscDate");
            }
        }

        public string UIC_Transaction_Type
        {
            get { return cardObj.Transaction_Type; }
            set
            {
                cardObj.Transaction_Type = value;
                OnPropertyChanged("UIC_TranscType");
            }
        }

        public string UIC_Amount
        {
            get { return cardObj.Amount.ToString(); }
            set { cardObj.Amount = Convert.ToDecimal(value); }
        }




        #endregion

        #region collection of Card Table

        public ObservableCollection<Card> CardList
        {
            get { return cardList; }
            set
            {
                cardList = value;
                OnPropertyChanged("CardList");
            }
        }

        #endregion


        #region Constructor 
        public AtmViewModel()
        {
            db = new AtmContext();
            CardList = new ObservableCollection<Card>();
            userList = new ObservableCollection<User>();
            _validcmd = new RelayCommand(ValidUser,CanValid);
            _balance = new RelayCommand(BalanceToCheck);
            _trnascHistory = new RelayCommand(TranscHistory);
            _chkBalance = new RelayCommand(CheckBalance, CanChkBalance);
            _chkTranscHistory = new RelayCommand(CheckTranscHistory, CanCheckHistory);
        }

        #endregion


        #region Command

        private ICommand _validcmd;

        public ICommand ValidCommand
        {
            get { return _validcmd; }   
        }

        private ICommand _chkBalance;

            public ICommand CheckBalanceCommand
        {
            get { return _chkBalance; } 
        }

       private  ICommand _balance;
        public ICommand BalanceCommand
        {
            get { return _balance; }    
        }

        private ICommand _trnascHistory;
        public ICommand TtrnascHistoryCommand
        {
            get { return _trnascHistory; }  
        }

        private ICommand _chkTranscHistory;
        public ICommand CheckTranscHistoryCommand
        {
            get { return _chkTranscHistory; }   
        }

        
       
        public  bool CanValid(object obj)
        {
            if((this.UI_CardNo != string.Empty)&& (this.UI_Pin !=string.Empty))
                return true;    
            return false;   
        }


        public void ValidUser(object obj)
        {
            long cardno = long.Parse(this.UI_CardNo);
             int pinno = Convert.ToInt32(this.UI_Pin);   

            User user = db.Users.Where(u => u.CardNo == cardno).Select(u=>u).Where(u=>u.Pin == pinno).SingleOrDefault(); 

            if(user != null)
            {
                MessageBox.Show("Valid User");
                TransactionModeForm transactionModeForm = new TransactionModeForm();
                transactionModeForm.Show();

            }
            else
            {
                MessageBox.Show(" user not found Provide valid details!!!  ");

            }
        }

        public void BalanceToCheck(object obj)
        {

            TransactionForm transactionForm = new TransactionForm();
            transactionForm.Show();
            //LoginForm loginForm = new LoginForm();
            //loginForm.Close();


        }

        public void TranscHistory(object obj)
        {
            TranscHistoryForm transcHistoryForm = new TranscHistoryForm();
            transcHistoryForm.Show();
        }

        public bool CanChkBalance(object obj)
        {
            if (this.UI_Pin != string.Empty)
                return true;
            return false;
        }

        public void CheckBalance(object obj)
        {
            long cardno = long.Parse(LoginForm.instance.usercardno.Text);
            int pinno = Convert.ToInt32(this.UI_Pin);

            User user = db.Users.Where(u => u.CardNo == cardno).Select(u => u).Where(u=>u.Pin ==pinno).SingleOrDefault();
           

            if(user != null)
            {
                this.UI_Balance = user.Balance.ToString();
            }
            else
            {
                MessageBox.Show("User Not Found please provide valid details !!");
            }



        }

        public bool CanCheckHistory(object obj)
        {
            if (this.UI_Pin != string.Empty)
                return true;
            return false;

        }

        public void CheckTranscHistory(object obj)
        {
            long cardno = long.Parse(LoginForm.instance.usercardno.Text);
            int pinno = Convert.ToInt32(this.UI_Pin);

            User user = db.Users.Where(u => u.CardNo == cardno).Select(u => u).Where(u => u.Pin == pinno).SingleOrDefault();
            var data = db.Cards.ToList();
            data = data.Where(u => u.CardNo == cardno).ToList();    
            CardList = new ObservableCollection<Card>(data);

            if (user != null)
            {
                
                if(CardList.Count > 0)
                {
                    this.UIC_Transaction_Id = CardList[0].Transaction_Id.ToString();    
                    this.UIC_CardNo = CardList[0].CardNo.ToString();    
                    this.UIC_Transaction_Date = CardList[0].Transaction_Date.ToString();    
                    this.UIC_Transaction_Type = cardList[0].Transaction_Type.ToString();    
                    this.UIC_Amount = cardList[0].Amount.ToString();    
                }
                else
                {
                    MessageBox.Show("No transaction Done Yet");
                }
            }
            else
            {
                MessageBox.Show("User Not Found please provide valid details !!");
            }




        }




        #endregion











        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string PropertyName)
        {

            // raise the propertyChahnged event in case somebody subscribed to it 
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));  // raise the event
        }

        #endregion
    }
}
