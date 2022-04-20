using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace finalProject.Model
{
    public class Client
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


    }
}
