using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNet.Capitulo02.Razor.Models
{
    public class ComentarioViewModel
    {
        public DateTime Data { get; set; }
        public string Comentarista { get; set; }
        public string Comentario { get; set; }
    }
}