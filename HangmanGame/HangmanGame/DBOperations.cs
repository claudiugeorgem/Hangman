using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace HangmanGame
{
    public class DBOperations
    {

        public void AddUsers(string Username, string Password, int Games)
        {
            using (IDbConnection conectare = new System.Data.SqlClient.SqlConnection(Connection.ConString("HangMan")))
            {
                List<Users> obUsers = new List<Users>();
                obUsers.Add(new Users
                {
                    Username = Username,
                    Password = Password,
                    Games = 0
                });

                try
                {
                conectare.Execute("AddUsers @Username, @Password, @Games", obUsers);
                }
                catch
                {
                    MessageBox.Show("This username is not available.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SignUpWindow f = new SignUpWindow();
                    f.ShowDialog();
                }
                conectare.Close();
            }
        }

        public void UpdateGames(string Username, string Password, int Games)
        {
            using (IDbConnection conectare = new System.Data.SqlClient.SqlConnection(Connection.ConString("HangMan")))
            {
                List<Users> obUsers = new List<Users>();
                obUsers.Add(new Users
                {
                    Username = Username,
                    Password = Password,
                    Games = Games
                });

                conectare.Execute("UpdateGames @Username, @Password, @Games", obUsers);
                conectare.Close();
            }
        }
    }
}
