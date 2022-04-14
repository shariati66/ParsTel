using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ParsTel
{
    public class users
    {
        [Key]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
    }

    
}
