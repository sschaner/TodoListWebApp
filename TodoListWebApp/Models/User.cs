using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TodoListWebApp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(50)]
        [Required]
        public string Email { get; set; }

        [StringLength(20)]
        [Required]
        public string Password { get; set; }
    }
}
