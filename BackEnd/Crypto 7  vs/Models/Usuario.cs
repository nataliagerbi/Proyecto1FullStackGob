using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crypto_7__vs.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            CryptoXusuarios = new HashSet<CryptoXusuario>();
            TransaccionMailCompradorNavigations = new HashSet<Transaccion>();
            TransaccionMailVendedorNavigations = new HashSet<Transaccion>();
        }
        [Key]
        public string Mail { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Password { get; set; } = null!;
        
        [NotMapped]
        public virtual ICollection<CryptoXusuario> CryptoXusuarios { get; set; }
        [NotMapped]
        public virtual ICollection<Transaccion> TransaccionMailCompradorNavigations { get; set; }
        [NotMapped]
        public virtual ICollection<Transaccion> TransaccionMailVendedorNavigations { get; set; }
    }
}
