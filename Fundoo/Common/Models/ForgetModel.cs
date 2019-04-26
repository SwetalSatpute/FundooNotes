using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fundoo.Common.Models
{
    public class ForgetModel
    {
        [Required]
        private string email;

        public string Email{ get => email; set => email = value; }
    }
}
