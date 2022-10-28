using Crypto_7__vs.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Crypto_7__vs.Controllers
{
    [ApiController]
    [Route("usuario")]
    public class UserController : Controller
    {

        private readonly ApplicationDbContext dbContext;


        public UserController(ApplicationDbContext dbContext)

        {
            this.dbContext = dbContext;
        }
        [HttpPost("login")]
        public async Task<Usuario> IniciarSesion([FromBody] LoginUsuario usuario)
        {

            
                var resultado = await (from u in dbContext.Usuario
                                 where u.Mail == usuario.Mail &&
                                 u.Password == usuario.Password
                                 select u).FirstOrDefaultAsync();

                return resultado;

            
    }



        [HttpPost("registrar")]
        public async Task<IActionResult> RegistrarUsuario([FromBody] Usuario usuario) 
        {
            try
            {
                //dbContext.Add<Usuario>(usuario);
                dbContext.Add(usuario);
                await dbContext.SaveChangesAsync();
                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }     
        }
    }
}
