using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginService2.Models;
using LoginService2.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginService2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService iuserservice;
        public UserController(IUserService iuserservice)
        {
            this.iuserservice = iuserservice;
        }

        [HttpPost("CreateAccount")]
        public ActionResult CreateUser([FromBody]User temp)
        {
            return Ok(iuserservice.CreateUser(temp));
        }

        [HttpPost("Login")]
        public ActionResult LoginValidate([FromBody]User temp)
        {
            return Ok(iuserservice.LoginValidate(temp.UserName, temp.Password));
        }


    }
}
