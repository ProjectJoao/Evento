using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos.Models
{
    public class cafe
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String NomeDoEspaco { get; set; }
    }
}
