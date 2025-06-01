using System;
using System.ComponentModel.DataAnnotations;

namespace InventarioValidade.Models
{
    public class ProdutoStatus
    {
        public Produto Produto { get; set; }
        public string StatusValidade { get; set; }
    }
}
