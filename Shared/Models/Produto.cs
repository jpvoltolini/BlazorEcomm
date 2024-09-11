using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEcomm.Shared.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public string Imagem { get; set; } = "";
    }
}
