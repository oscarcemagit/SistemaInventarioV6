using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace InventorySystem.Models
{
    public class Storehouse
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is required.")]
        [MaxLength(60, ErrorMessage = "Name max length is larger as expected.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [MaxLength(100, ErrorMessage = "Description max length is larger as expected.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "State is required.")]
        public bool State { get; set; }
    }
}
