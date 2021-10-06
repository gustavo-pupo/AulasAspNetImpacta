using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpoCenter.Mvc.Models
{
    public class ParticipanteViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }

        [Display(Name = "Nascimento")]
        public DateTime DataNascimento { get; set; } 
        

    }
}
