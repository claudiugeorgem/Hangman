using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public class Connection
    {
        public static string ConString(string numeConectare)
        {
            return ConfigurationManager.ConnectionStrings[numeConectare].ConnectionString;
        }
    }
}
