using System;
using System.Collections.Generic;

namespace Crypto_7__vs.Models
{
    public partial class Crypto
    {
        public Crypto()
        {
            CryptoXusuarios = new HashSet<CryptoXusuario>();
            Transaccions = new HashSet<Transaccion>();
        }

        public string Nombre { get; set; } = null!;
        public string NombreCorto { get; set; } = null!;
        public int? Precio { get; set; }
        public int IdCrypto { get; set; }

        public virtual ICollection<CryptoXusuario> CryptoXusuarios { get; set; }
        public virtual ICollection<Transaccion> Transaccions { get; set; }
    }
}
