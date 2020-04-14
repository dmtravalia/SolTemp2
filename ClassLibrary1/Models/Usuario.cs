using System;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1.Models
{
    public class Usuario
    {
        [Key]
        public Guid Id { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
    }
}
