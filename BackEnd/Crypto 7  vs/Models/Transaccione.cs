using System;
using System.Collections.Generic;

namespace Crypto_7__vs.Models
{
    public partial class Transaccione
    {
        public string? Hash { get; set; }
        public int IdComprador { get; set; }
        public int IdVendedor { get; set; }
        public string Moneda { get; set; } = null!;
        public int Monto { get; set; }

        public virtual Cliente IdCompradorNavigation { get; set; } = null!;
        public virtual Cliente IdVendedorNavigation { get; set; } = null!;
    }
}
