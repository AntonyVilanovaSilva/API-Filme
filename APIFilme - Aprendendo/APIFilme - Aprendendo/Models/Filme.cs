﻿using System.ComponentModel.DataAnnotations;

namespace APIFilme___Aprendendo.Models
{
    public class Filme
    {
        [Key]
        public int FilId { get; set; }

        public string Titulo { get; set; }

        public string Diretor { get; set; }

        public DateTime DataLancamento { get; set; }

        public string Genero { get; set; }  

        public int? photourl { get; set; }

    }
}
