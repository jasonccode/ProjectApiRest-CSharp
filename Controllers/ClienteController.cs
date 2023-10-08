using apirestcsharp.Models;
using Microsoft.AspNetCore.Mvc;

namespace apirestcsharp.Controllers
{

    [ApiController]
    [Route("cliente")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public dynamic listarCliente()
        {
            List<Cliente> clientes = new List<Cliente>
            {
                new Cliente{
                    id = 1,
                    nombre = "Juan",
                    edad = 40,
                    correo = "juan@mail.com"
                },
                 new Cliente{
                    id = 2,
                    nombre = "Jose",
                    edad = 20,
                    correo = "jose@mail.com"
                },
                 new Cliente{
                    id = 3,
                    nombre = "Carlos",
                    edad = 30,
                    correo = "carlos@mail.com"
                },

            };
            return clientes;
        }

        [HttpGet]
        [Route("listarxid")]
        public dynamic listarClientexid(int _id)
        {
            return new Cliente
            {
                id = _id,
                nombre = "Juan",
                edad = 40,
                correo = "juan@mail.com"
            };
        }

        [HttpPost]
        [Route("guardar")]
        public dynamic guardarCliente(Cliente cliente)
        {
            cliente.id = 3;
            return new
            {
                success = true,
                message = "cliente registrado",
                result = cliente
            };
        }

        [HttpPost]
        [Route("eliminar")]
        public dynamic eliminarCliente(Cliente cliente)
        {
            string token = Request.Headers.FirstOrDefault(x => x.Key == "Authorization").Value;
            if (token != "marco1234")
            {
                return new
                {
                    success = false,
                    message = "token incorrecto",
                    result = ""
                };
            }

            return new
            {
                success = true,
                message = "cliente eliminado",
                result = cliente
            };
        }
    }


}