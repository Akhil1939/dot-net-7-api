using api.models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.models.DTOs
{
    public class UserDTO
    {
       

        public int UserId { get; set; }

        public string Username { get; set; } = null!;

        public string Email { get; set; } = null!;

        //public string Password { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        //public string? Address { get; set; }

        public string PhoneNumber { get; set; } = null!;

        public int Role { get; set; }

        
       
    }
}
