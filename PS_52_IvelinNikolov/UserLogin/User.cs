using System;
using System.Collections.Generic;
using System.Text;

namespace UserLogin
{
    class User
    {
        public DateTime created;
        public DateTime validThrough;
        public String username
        { get; set; }
        public String password
        { get; set; }
        public String fakNum
        { get; set; }
        public int role
        { get; set; }
    }
}
