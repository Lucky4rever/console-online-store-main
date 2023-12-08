using System;
using System.Collections.Generic;


namespace StoreBLL.Models
{
    public class UserModel : AbstractModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }

        public UserModel(int id, string name, string surname, string email, string password, int roleId):base(id)
        {
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Password = password;
            this.RoleId = roleId;
        }
        public override string ToString()
        {
            return $"User Id:{Id} Name:{Name} Surname:{Surname} Email:{Email} Password:{Password} RoleId:{RoleId}";
        }
    }
}
