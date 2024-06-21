using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIEcommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase     
    {

        

       [HttpPost]
        public void CadastrarUsuarios([FromBody] Usuarios user)
        {
            try
            {
                UsuarioRepository usuarioRepository = new UsuarioRepository();
                usuarioRepository.AddUsuario(user);
                
            }

             
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public List<Usuarios> ListarUsuarios()
        {
            try
            {
                UsuarioRepository usuarioRepository = new UsuarioRepository();
                var lista = usuarioRepository.GetAllUsers();

                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
