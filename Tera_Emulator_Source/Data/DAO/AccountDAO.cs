using Data.Structures.Account;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Data.DAO
{
    public class AccountDAO : BaseDAO
    {
        private MySqlConnection AccountDAOConnection;

        public AccountDAO(string conStr) : base(conStr)
        {            
            Stopwatch stopwatch = Stopwatch.StartNew();
            AccountDAOConnection = new MySqlConnection(conStr);
            AccountDAOConnection.Open();

            stopwatch.Stop();
            Log.Info("DAO: AccountDAO Initialized with {0} Accounts in {1}s"
            , LoadTotalAccounts()
            , (stopwatch.ElapsedMilliseconds / 1000.0).ToString("0.00"));
        }

        public Account LoadAccount(string username)
        {
            string SQL = "SELECT * FROM `accounts` WHERE `name` = ?username";
            MySqlCommand cmd = new MySqlCommand(SQL, AccountDAOConnection);
            cmd.Parameters.AddWithValue("?username", username);
            MySqlDataReader AccountReader = cmd.ExecuteReader();

            Account acc = new Account();
            if (AccountReader.HasRows)
            {
                while (AccountReader.Read())
                {
                    acc.AccountId = AccountReader.GetInt32(0);
                    acc.Name = AccountReader.GetString(1);
                    acc.Password = AccountReader.GetString(2);
                    acc.Email = AccountReader.GetString(3);
                    acc.AccessLevel = (byte)AccountReader.GetInt32(4);
                    acc.Membership = (byte)AccountReader.GetInt32(5);
                    acc.isGM = AccountReader.GetBoolean(6);
                    acc.LastOnlineUtc = AccountReader.GetInt64(7);
                    acc.Coins = (int)AccountReader.GetInt32(8);
                }
            }
            AccountReader.Close();
            return (acc.Name == "") ? null : acc;
        }

        public int LoadTotalAccounts()
        {
            string SQL = "SELECT COUNT(*) FROM `accounts`";
            MySqlCommand cmd = new MySqlCommand(SQL, AccountDAOConnection);
            MySqlDataReader LoadAccountCountReader = cmd.ExecuteReader();

            int count = 0;
            while (LoadAccountCountReader.Read())
            {
                count = LoadAccountCountReader.GetInt32(0);
            }

            LoadAccountCountReader.Close();

            return count;
        }

        /* removed isnt used...
        public bool SaveAccount(Account account)
        {
            string SQL = "INSERT INTO `accounts` (`name`,`password`) VALUES(?name, ?password);";
            MySqlCommand cmd = new MySqlCommand(SQL, AccountDAOConnection);
            cmd.Parameters.AddWithValue("?name", account.Name);
            cmd.Parameters.AddWithValue("?password", account.Password);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Log.ErrorException("DAO: SAVE ACCOUNT ERROR!", e);
            }
            return false;
        }
        */

    }
}
