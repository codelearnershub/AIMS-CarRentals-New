using AimsCarRentals.Interfaces;
using AimsCarRentals.Models;
using AimsCarRentals.Models.ViewModel;
using AimsCarRentals.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AimsCarRentals.Controllers
{
    public class AuthController : Controller
    {
        public readonly IUserService _userService;
        public readonly IUserRoleRepository _userRoleRepository;
        public readonly IRoleService _roleService;
        public AuthController(IUserService userService, IUserRoleRepository userRoleRepository, IRoleService roleService)
        {
            _userService = userService;
            _userRoleRepository = userRoleRepository;
            _roleService = roleService;
        }
        public IActionResult Index()
        {
            var user = _userService.GetAllUser();
            return View(user);
        }

        [HttpGet]
        public IActionResult RegisterCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterCustomer(RegisterCustomerViewModel model)
        {
            var role = _roleService.FindRoleByName("Customer");
            var roles = new List<Role>();
            roles.Add(role);
            model.Roles = roles;
            _userService.RegisterCustomer(model);
            return RedirectToAction("Login");
        }

        public IActionResult RegisterAdmin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterAdmin(RegisterAdminViewModel model)
        {
            var role = _roleService.FindRoleByName("Admin");
            var roles = new List<Role>();
            roles.Add(role);
            model.Roles = roles;
            _userService.RegisterAdmin(model);
            return RedirectToAction("Login");
        }


        [Authorize]
        public void Delete(int id)
        {
            _userService.Delete(id);
        }
        [Authorize]
        public User Update(UpdateAdminViewModel model)
        {
            return _userService.UpdateAdmin(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel vm)
        {
            User user = _userService.LoginUser(vm.Email, vm.Password);

            if (user == null) return View();


            var role = _userRoleRepository.FindUserRoles(user.Id);

            if (role.Any(r => r.Role.Id == 1))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Email)
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);


                var props = new AuthenticationProperties();

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props);

                return RedirectToAction("Index", "Branch");
            }
            else if (role.Any(r => r.Role.Id == 2))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Email)
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);


                var props = new AuthenticationProperties();

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props);

                return RedirectToAction("Index", "AdminDashboard");
            }
            else
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Email)
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);


                var props = new AuthenticationProperties();

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props);
                return RedirectToAction("BookCar", "Car");
            }
        }
    }
}
