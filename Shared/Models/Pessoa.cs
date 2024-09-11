using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEcomm.Shared.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string Tipo { get; set; } // Física ou Jurídica
    }
}
