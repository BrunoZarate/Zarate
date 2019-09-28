using System;
using System.ComponentModel.DataAnnotations;

namespace Zarate.Models
{
    public enum wishes
    {
        Balones,
        Bocinas,
        Barco,
    }
    public class Fairy
    {
        [Key]
        public int FairyID { get; set; }
        [Required(ErrorMessage ="Nombre completo")]
        public string NickName { get; set; }
        [Required]
        public wishes Wishes { get; set; }
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

    }
}