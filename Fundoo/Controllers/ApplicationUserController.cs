﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fundoo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Fundoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;

        public ApplicationUserController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        
        [HttpPost]
        [Route ("Register")]
            public async Task<object>PostApplicationUser(ApplicationUserModel model)
            {
            var applicationUser = new ApplicationUser()
            {
                UserName = model.UserName,
                Email = model.FullName,
                FullName = model.FullName
            };
            try
            {
                var result =await _userManager.CreateAsync(applicationUser, model.Password);
                return Ok(result);
            }
            catch (Exception ex)
            { 
                throw ex;
            }
            }
       
    }
}