using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.models.DTOs
{
    public class TokenDTO
    {
        public string Token { get; set; } = null!;
        public int UserRole { get; set; }
    }
}
