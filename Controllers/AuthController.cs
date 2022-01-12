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
        [Authorize(Roles = "Admin, SuperAdmin")]
        public IActionResult Index()
        {
            var user = _userService.GetAllUser();
            return View(user);
        }
        [Authorize(Roles = "Admin, SuperAdmin")]
        [HttpGet]
        public IActionResult RegisterCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterCustomer(RegisterCustomerViewModel model)
        {
            if(model == null)
            {
                ViewBag.Message = "Cannot Create Account";
            }
            var role = _roleService.FindRoleByName("Customer");
            var roles = new List<Role>();
            roles.Add(role);
            model.Roles = roles;
            _userService.RegisterCustomer(model);
            ViewBag.Message = "Registration Successfull";
            return RedirectToAction("Login");
        }
        [HttpGet]
        [Authorize(Roles = "Admin, SuperAdmin")]
        public IActionResult UpdateAdmin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateAdmin(int id,UpdateAdminViewModel model)
        {
            
          /*  var role = _roleService.FindRoleByName("Admin");
            var roles = new List<Role>();
            roles.Add(role);
            model.Roles = roles;*/
            _userService.UpdateAdmin(id,model);
            ViewBag.Message = "Update Successfull";
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin, SuperAdmin")]
        public IActionResult RegisterAdmin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterAdmin(RegisterAdminViewModel model)
        {
            if( model == null)
            {
                ViewBag.Message = "Cannot Register Account";
            }
            var role = _roleService.FindRoleByName("Admin");
            var roles = new List<Role>();
            roles.Add(role);
            model.Roles = roles;
            _userService.RegisterAdmin(model);
            ViewBag.Message = "Registration Successfull";
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

       
        public IActionResult Details(int id)
        {
            var user = _userService.FindUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
        [HttpGet]
        [Authorize(Roles = "Admin, SuperAdmin")]
        public IActionResult UpdateCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateCustomer(UpdateCustomerViewModel model,int id)
        {
            var customer = _userService.UpdateCustomer(model,id);
            return View(customer);
        }

       
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel vm)
        {
            User user = _userService.Login(vm.Email, vm.Password);

            if (user == null)
            {
                ViewBag.Message = "null";
                return View();
            }

            var role = _userRoleRepository.FindUserRoles(user.Id);

            if (role.Any(r => r.Role.Id == 1))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Role, "SuperAdmin")
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
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Role, "Admin")
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
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Role, "Customer")
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);


                var props = new AuthenticationProperties();

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props);
                
                 return RedirectToAction("BookingHistory", "Bookings");
            }
           
        }
        [Authorize(Roles ="Admin, SuperAdmin")]
        public IActionResult GetAllCustomers()
        {
           var customer = _userService.GetAllCustomers();
            return View(customer);
        }
        [Authorize (Roles = "Admin, SuperAdmin")]
        public IActionResult GetAllAdmins()
        {
            var admin = _userService.GetAllAdmins();
            return View(admin);
        }
        public IActionResult Delete(int id)
        {
            var delete = _userService.FindUserById(id);
            if (delete == null)
            {
                ViewBag.Message = "Can not delete branch";
                return NotFound();
            }
            return View(delete);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index" , "Home");
        }

    }
}
