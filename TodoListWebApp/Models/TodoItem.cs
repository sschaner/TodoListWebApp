using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TodoListWebApp.Models
{
    public class TodoItem
    {
        [Key]
        public int ItemId { get; set; }

        [Required]
        public string Description { get; set; }

        [DisplayName("Due Date")]
        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public bool Complete { get; set; }
    }
}
