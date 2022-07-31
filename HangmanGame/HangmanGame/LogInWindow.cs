using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace HangmanGame
{
    public partial class LogInWindow : Form
    {
        public static string SetValueForText1;
        public static string SetValueForText2;
        public LogInWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show(this, "Please enter your username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show(this, "Please enter your password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show(this, "Please enter your username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            
            using (IDbConnection db = new SqlConnection(Connection.ConString("HangMan")))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                Users obj = db.Query<Users>($"SELECT * FROM Users WHERE Username = '{textBox1.Text}'", commandType: CommandType.Text).SingleOrDefault();
                if(obj != null)
                {
                    if (obj.Password == textBox2.Text)
                    {
                        SetValueForText1 = textBox1.Text;
                        SetValueForText2 = textBox2.Text;

                        this.Hide();
                        GameWindow f = new GameWindow();
                        f.ShowDialog();
                    }
                    else
                        MessageBox.Show(this, "Your username and password don't match.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(this, "Your username and password don't match.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow f = new MainWindow();
            f.ShowDialog();
        }
    }
}
