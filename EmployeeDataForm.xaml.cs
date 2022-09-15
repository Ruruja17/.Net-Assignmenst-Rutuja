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
using DataAccessLibrary;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;

namespace WPFDEmoApp
{
    /// <summary>
    /// Interaction logic for EmployeeDataForm.xaml
    /// </summary>
    public partial class EmployeeDataForm : Window
    {
        EmployeeDataStore dataStore;
        ObservableCollection<Employee> empList;
        public EmployeeDataForm()
        {
            InitializeComponent();
            dataStore = new EmployeeDataStore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        private void MainGrid_Loaded(object sender, RoutedEventArgs e)
        {
            List<Employee> employees = dataStore.GetAllEmployees();
            empList = new ObservableCollection<Employee>(employees);
            EmpDataGrid.DataContext = empList;
            

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Employee employee = new Employee()
                {
                    EmpNo = Convert.ToInt32(txtEmpNo.Text),
                    Ename = txtEmpName.Text,
                    HireDate = Convert.ToDateTime(txtHireDate.Text),
                    Sal = Convert.ToDecimal(txtSal.Text)


                };

                int count = dataStore.InsertEmployee(employee);
                if (count == 1)
                {
                    MessageBox.Show("Record Added");
                    EmpDataGrid.DataContext = dataStore.GetAllEmployees();
                    ClearTextBoxes();
                 
                }
                else
                {
                    MessageBox.Show("Insertion fail");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : \n" + ex.Message);
            }



        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                int empno = Convert.ToInt32(txtEmpNo.Text);
                int count = dataStore.DeleteEmployee(empno);
                if (count == 1)
                {
                    MessageBox.Show("Record Removed");



                    EmpDataGrid.DataContext = dataStore.GetAllEmployees();
                    ClearTextBoxes();

                 
                }
                else
                {
                    MessageBox.Show("Remove Fail");
                }
            }


            catch (Exception ex)
            {



                MessageBox.Show("Execption : \n" + ex.Message);

            }


        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                int empno = Convert.ToInt32(txtEmpNo.Text);
                Employee employee = new Employee()
                {
                    EmpNo = Convert.ToInt32(txtEmpNo.Text),
                    Ename = txtEmpName.Text,
                    HireDate = Convert.ToDateTime(txtHireDate.Text),
                    Sal = Convert.ToDecimal(txtSal.Text)



                };
                int count = dataStore.UpdateEmployee(employee);
                
                
                if (count == 1)
                {

                    MessageBox.Show("Edit Successful");
                    EmpDataGrid.DataContext = dataStore.GetAllEmployees();
                    ClearTextBoxes();

                }
                else
                {
                    MessageBox.Show("Edit fail");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : \n" + ex.Message);
            }


        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtEmpNo.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter empno value");
                    return;
                }
                int empno = Convert.ToInt32(txtEmpNo.Text);

                Employee employee = dataStore.GetEmployeeByNo(empno);

                if (employee == null)
                {
                    MessageBox.Show("No employee found for Eno" + empno.ToString());
                   ClearTextBoxes();

                }
                else
                {
                    txtEmpName.Text = employee.Ename;
                    txtHireDate.Text = employee.HireDate.ToString();
                    txtSal.Text = employee.Sal.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception :\n" + ex.Message);
            }

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearTextBoxes();   

        }
        public void ClearTextBoxes()
        {
            txtEmpName.Clear();
            txtEmpNo.Clear();
            txtHireDate.Clear();
            txtSal.Clear();
        }
    }
}
