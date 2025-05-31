using System;
using System.ComponentModel.DataAnnotations;

namespace InventarioValidade.Models
{
    public class Produto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public double Preco { get; set; }

        public int Quantidade { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataValidade { get; set; }
    }
}
