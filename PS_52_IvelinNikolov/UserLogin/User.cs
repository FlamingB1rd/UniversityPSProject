using System;
using System.Collections.Generic;
using System.Text;

namespace UserLogin
{
    public class User
    {
        public DateTime created;
        public DateTime validThrough;
        public string username
        { get; set; }
        public string password
        { get; set; }
        public string fakNum
        { get; set; }
        public int role
        { get; set; }
    }
}
