using System;
using System.Collections.Generic;
using System.Text;

namespace Jaya.Core
{
    public class Transactions
    {
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
