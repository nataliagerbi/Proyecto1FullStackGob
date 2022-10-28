using System;
using System.Collections.Generic;

namespace Crypto_7__vs.Models
{
    public partial class CryptoXusuario
    {
        public string Mail { get; set; } = null!;
        public int IdCrypto { get; set; }
        public int Cantidad { get; set; }

        public virtual Crypto IdCryptoNavigation { get; set; } = null!;
        public virtual Usuario MailNavigation { get; set; } = null!;
    }
}
