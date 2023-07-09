using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.models.DTOs
{
    public class UserListRequestDTO : BaseListRequestDTO
    {
        public string? SearchQuery { get; set; }
    }
}
