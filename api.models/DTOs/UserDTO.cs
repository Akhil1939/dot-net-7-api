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

        public string FirstName { get; set; } = string.Empty!;

        public string LastName { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = null!;

        public int Role { get; set; }

        
       
    }
}
