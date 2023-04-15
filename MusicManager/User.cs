using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicManager
{
    public class User
    {
        private int id;
        private string mail;
        private string password;

        public int Id { get { return id; } }
        public string Mail { get { return mail; } }
        public string Password { get { return password; } }

        public User(string mail, string password, int id = 0)
        {
            this.id = id;
            this.mail = mail;
            this.password = password;
        }
    }
}
