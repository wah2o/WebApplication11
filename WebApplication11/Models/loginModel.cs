using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication11.Models
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}
