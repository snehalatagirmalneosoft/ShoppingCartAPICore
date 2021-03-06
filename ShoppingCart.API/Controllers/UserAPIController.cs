﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.BAL.Interfaces;

namespace ShoppingCart.API.Controllers
{
    [Produces("application/json")]
    [Route("api/UserAPI")]
    public class UserAPIController : Controller
    {
        IUserService _userService;
        public UserAPIController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetUserList")]
        public object GetUserList()
        {
            return _userService.GetAllUser();
        }

        [HttpGet("GetUserById")]
        public object GetUserById(int Id)
        {
            return _userService.GetUserById(Id);
        }
    }
}