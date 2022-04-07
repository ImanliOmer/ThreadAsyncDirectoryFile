using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadAsyncDirectoryFile.Models
{
    internal class User
    {
        private int _id;
        public int Id { get; set; }
        public string UserName { get; set; }

        public User(string username)
        {
            UserName = username;
            new List<Status>();
            _id++;
            Id = _id;
        }

    }
}
