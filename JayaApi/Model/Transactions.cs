using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JayaApi.Model
{
    public class Transactions
    {
        [Key]
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string MoedaOrigem { get; set; }
        public decimal ValorOrigem { get; set; }
        public string MoedaDestino { get; set; }
        public decimal ValorDestino { get; set; }
        public decimal TaxaConversao { get; set; }
        public DateTime Data { get; set; }
    }
}
