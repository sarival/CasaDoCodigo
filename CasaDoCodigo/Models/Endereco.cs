﻿using System.Collections.Generic;

namespace CasaDoCodigo.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public IEnumerable<Cliente> Clientes { get; set; }
    }
}