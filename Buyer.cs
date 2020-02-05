using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dmart.Models
{
    public class Buyer
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Phno { get; set; }

        //public Buyer(int Id, string Name, string Password, string Email, int Phno)
        //{
        //    this.Id = Id;
        //    this.Name = Name;
        //    this.Password = Password;
        //    this.Email = Email;
        //    this.Phno = Phno;

        //}

    }
}
