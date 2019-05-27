﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models
{
    public class Autor
    {
        //chave primaria
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "Campo {0} precisa ter entre {2} e {1} caracteres ", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage = "Campo {0} precisa ter entre {2} e {1} caracteres ", MinimumLength = 2)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public string Imagem { get; set; }
        public IEnumerable<Livro> Livros { get; set; }
    }
}
