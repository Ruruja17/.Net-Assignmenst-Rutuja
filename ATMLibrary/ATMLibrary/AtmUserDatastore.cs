using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ATMLibrary
{
    public class AtmUserDatastore
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;
        

        public AtmUserDatastore(string connectionString)
        {
            connection = new MySqlConnection(connectionString);
        }


        public List<AtmUser> GetAtmUsers()
        {
            try
            {
                string sql = "select CardNo, Fname,Pin, Lname, Balance from User";

                command = new MySqlCommand(sql, connection);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                reader = command.ExecuteReader();
                List<AtmUser> atmUList = new List<AtmUser>();

                while (reader.Read())
                {
                    AtmUser atmUser = new AtmUser();

                    atmUser.CardNo = (int)Convert.ToInt32(reader["CardNo"].ToString());
                    atmUser.FName = reader["FName"].ToString();
                    atmUser.Lname = reader["LName"].ToString();
                    atmUser.Pin = (int)(reader["Pin"]);
                    atmUser.Balance = reader["Balance"] as decimal?;

                    atmUList.Add(atmUser);
                }
                return atmUList;

            }
            catch
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }

        public List<Transaction> GetTransactions(long cardno)
        {
            
            try

            {
                //string sql = "select CardNo, Transaction_Date, Transaction_type, Amount from Card order by Transaction_Date desc limit 3 where CARDNO = @cardno";
                string sql = " select CardNo, Transaction_Date, Transaction_type, Amount from card  where CARDNO = @cardno   order by Transaction_Date desc limit 3";


                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("cardno", cardno);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                reader = command.ExecuteReader();
                List<Transaction> txList = new List<Transaction>();
                while (reader.Read())
                {
                    Transaction transaction = new Transaction();
                   
                    transaction.CardNo = (long)(reader["CardNo"]);
                    transaction.TranscDate = reader["Transaction_Date"] as DateTime?;
                    transaction.TranscType = reader["Transaction_type"].ToString();
                    transaction.Amount = reader["Amount"]as Decimal?;
                    txList.Add(transaction);

                }
                return txList;


            }
            catch
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }

        public AtmUser GetValidUser(long cardno, long pinno)
        {
            try
            {
                string sql = "select CARDNO, PIN from user where CARDNO = @cardno and PIN = @pinno";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("cardno", cardno);
                command.Parameters.AddWithValue("pinno", pinno);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();


                }
                reader = command.ExecuteReader();
                AtmUser atmUser = null;
                if (reader.Read())
                {
                    atmUser = new AtmUser();
                   atmUser.CardNo = (int)Convert.ToInt64(reader["CardNo"]);
                    atmUser.Pin = Convert.ToInt32(reader["Pin"]);
                   

                }
                return atmUser; 

            }
            catch
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        public AtmUser GetBalance(long pinno)
        {
            try
            {
                string sql = "select Balance, PIN from user where  PIN = @pinno";
                command = new MySqlCommand(sql, connection);
              
                command.Parameters.AddWithValue("pinno", pinno);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    


                }
                reader = command.ExecuteReader();
                AtmUser atmUser = null;
                if (reader.Read())
                {
                    atmUser = new AtmUser();
                    atmUser.Pin = Convert.ToInt32(reader["Pin"]);
                    atmUser.Balance =reader["Balance"]as decimal?;
                    


                }
                return atmUser;

            }
            catch
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }

      
        public int GetDeposit( decimal amount, long cardno)
        {
            try
            {
                //string sql = " Insert into Card VALUES (Transaction_Id, @cardno ,curdate(),'Deoposit', @amount)";
                string sql = "select  CARDNO,Transaction_Date,Transaction_type,Amount from CARD where PIN = @pinno";
                string sql1 = "Insert into card( CARDNO,Transaction_Date,Transaction_type,Amount) values( @cardno, curdate(),'Deposit',@amount)";
                command = new MySqlCommand(sql, connection);
                command = new MySqlCommand(sql1, connection);
               
                command.Parameters.AddWithValue("Amount", amount); 
                command.Parameters.AddWithValue("CardNo", cardno); 




                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                int count = command.ExecuteNonQuery();
                return count;


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public int DepositIncr(long cardno, decimal amount)
        {
            int balance = 0;

            string sql = "select Balance from User where CARDNO = @cardno ";
            command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("cardno", cardno);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            reader = command.ExecuteReader();
           
            while(reader.Read())
            {
                balance = reader.GetInt32(0);
                break;
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            balance = balance + Convert.ToInt32(amount);

            string sql1 = "Update User Set Balance = @balance where CARDNO = @cardno";
            command = new MySqlCommand(sql1, connection);
            command.Parameters.AddWithValue("cardno", cardno);
            command.Parameters.AddWithValue("balance", balance);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            int count = command.ExecuteNonQuery();
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return count;



        }

        public int GetWithdraw(decimal amount, long cardno)
        {
            try
            {
                //string sql = " Insert into Card VALUES (Transaction_Id, @cardno ,curdate(),'Deoposit', @amount)";
                string sql = "select  CARDNO,Transaction_Date,Transaction_type,Amount from CARD where PIN = @pinno";
                string sql1 = "Insert into card( CARDNO,Transaction_Date,Transaction_type,Amount) values( @cardno, curdate(),'Withdraw',@amount)";
                
                command = new MySqlCommand(sql, connection);
                command = new MySqlCommand(sql1, connection);
                //command = new MySqlCommand(sql2, connection);

                command.Parameters.AddWithValue("Amount", amount);
                command.Parameters.AddWithValue("CardNo", cardno);

                

               


                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
             
                int count = command.ExecuteNonQuery();

                //string date = reader["Count_TranscDate"].ToString();    

                //count = Convert.ToInt32(date);
                
                return count;


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }

        public int WithdrawDecr(long cardno, decimal amount)
        {

            int balance = 0;

            string sql = "select Balance from User where CARDNO = @cardno ";
            command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("cardno", cardno);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                balance = reader.GetInt32(0);
                break;
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            balance = balance - Convert.ToInt32(amount);

            string sql1 = "Update User Set Balance = @balance where CARDNO = @cardno";
            command = new MySqlCommand(sql1, connection);
            command.Parameters.AddWithValue("cardno", cardno);
            command.Parameters.AddWithValue("balance", balance);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            int count = command.ExecuteNonQuery();
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return count;


        }

       public long WithdrawLimit(long cardno,  DateTime Tranc_Date)
        {
            long date = 0;
             Tranc_Date = DateTime.Today;    
            string sql = " select count(*)  as count from card  where CARDNO = @cardno and Transaction_Date = @Transc_Date";
            command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("cardno", cardno);
            command.Parameters.AddWithValue("Transc_Date", Tranc_Date);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            reader = command.ExecuteReader();

          while(reader.Read())
            {
                date = reader.GetInt32(0);
            }
             //date  = (long)reader["count"];    

           

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return date;



        }





    }

        }










   



