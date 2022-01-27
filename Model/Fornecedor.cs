using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Fornecedor : BaseClass
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public bool Ativo { get; set; }
    }
}
