using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MVVMAtm_ASSIGN.Models;
using MVVMAtm_ASSIGN.Commands;
using System.Collections.ObjectModel;

using System.ComponentModel;
using MVVMAtm_ASSIGN.Views;


namespace MVVMAtm_ASSIGN.Views
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        AtmContext db = null;
        public static LoginForm instance;
        public TextBox usercardno;

        public LoginForm()
        {
            InitializeComponent();
            db = new AtmContext();
            instance = this;
            usercardno = txtUserId;
        }
    }
}
