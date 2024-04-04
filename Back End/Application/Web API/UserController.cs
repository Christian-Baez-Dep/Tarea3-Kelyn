using Entity;
using Entity.Entidades;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace Web_API
{
    public class UserController: ControllerBase
    {
        public readonly UserService _service;

        public UserController(UserService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("/Login")]
        public IActionResult Login([FromBody]LoginDTO loginDTO)
        {
            var response = _service.login(loginDTO);

            if (response == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(response);
            }
        }



        [HttpPost]
        [Route("/Register")]
        public IActionResult Register([FromBody] RegistroRequest request)
        {
            var response = _service.RegistrarUsuario(request);

            if (response == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(response);
            }
        }
    }
}
