using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using API.Services;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private IUserService _userService;

        /*User user = new User
        {
            Id = "1",
            username = "Bertrand",
            role = "Admin",
            password = "1234",
            email = "bertrand@mail.loc",
            adresse = "12 rue Pierre Brunier"
        };*/

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        /*[Route("get"), HttpGet (Name = "GetUser")]
        public JsonResult Get()
        {
            return Json(new User
            {
                Id = "1",
                username = "Bertrand",
                role = "Admin",
                password = "1234",
                email = "bertrand@mail.loc",
                adresse = "12 rue Pierre Brunier"
            });
            
            return Json(_context.User.ToList());
        }*/

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [HttpGet("resctrited")]
        public IActionResult GetAllRestricted()
        {
            var users = _userService.GetAllRestricted();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _userService.GetUserById(id);

            return Ok(user);
        }
    }
}

