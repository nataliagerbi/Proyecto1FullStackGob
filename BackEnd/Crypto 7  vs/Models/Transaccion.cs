using System;
using System.Collections.Generic;

namespace Crypto_7__vs.Models
{
    public partial class Transaccion
    {
        public int IdTransaccion { get; set; }
        public string MailVendedor { get; set; } = null!;
        public string? MailComprador { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; } = null!;
        public int IdCrypto { get; set; }
        public int IdEstado { get; set; }

        public virtual Crypto IdCryptoNavigation { get; set; } = null!;
        public virtual Usuario? MailCompradorNavigation { get; set; }
        public virtual Usuario MailVendedorNavigation { get; set; } = null!;
    }
}
