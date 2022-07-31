using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public class Users
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Games { get; set; }

        public string AfisareUsers
        {
            get { return $"{Username} {Password} {Games}"; }
        }
    }
}
