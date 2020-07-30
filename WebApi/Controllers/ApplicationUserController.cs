using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
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
        [Route("Register")]
        //POST : /api/Application/Register
        public async Task<Object> PostApplicaionUser(ApplicationUserModel applicationUserModel)
        {
            var applicationUser = new ApplicationUser()
            {
                UserName = applicationUserModel.UserName,
                Email = applicationUserModel.Email,
                FullName = applicationUserModel.FullName
            };

            try
            {
                var result = await _userManager.CreateAsync(applicationUser, applicationUserModel.Password);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
