using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos
{
    public class pessoa
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Nome { get; set; }
        [Required]
        public String Sobrenome { get; set; }
    }
}
