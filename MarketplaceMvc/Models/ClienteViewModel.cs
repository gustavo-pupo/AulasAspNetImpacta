using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarketplaceMvc.Models
{
    public class ClienteViewModel
    {

        public int Id { get; set; }

        [Required]
        [StringLength(14)]
        public string Documento { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}