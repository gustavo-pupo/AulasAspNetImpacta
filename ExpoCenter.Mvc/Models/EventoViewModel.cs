﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpoCenter.Mvc.Models
{
    public class EventoViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        public string Local { get; set; }

        [Required]
        [DisplayName("Preço")]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        public List<ParticipanteGridViewModel> Participantes { get; set; }
    }
}
