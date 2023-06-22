using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SlimeTAP.Pages.Register
{
    public class register : PageModel
    {
        private readonly ILogger<register> _logger;

        public register(ILogger<register> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}