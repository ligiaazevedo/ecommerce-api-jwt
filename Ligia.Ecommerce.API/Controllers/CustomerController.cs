using Ligia.Ecommerce.API.Application;
using Ligia.Ecommerce.API.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ligia.Ecommerce.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private static List<Customer> customers = new List<Customer>();
        private readonly TokenService _tokenService;

        public CustomerController(TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpGet("{id}")]
        [Authorize]
        public Customer GetCustomer(string id) 
        {
            return FindCustomer(id);
        
        }

        [HttpPost]
        [AllowAnonymous]
        public Customer PostCustomer(Customer model)
        {
            customers.Add(model);
            return model;
        }

        [HttpPost("/auth/token")]
        [AllowAnonymous]

        public dynamic AuthenticatePost(string id)
        {
            Customer? user = FindCustomer(id);

            if (user is null)
                return "Error!, customer not found";

            var token = _tokenService.GenerateToken(user);

            return new
            {
                token
            };
        }

        private static Customer FindCustomer(string id)
        {
            return customers.First(c => c.Id.Equals(id));
        }
    }
}