using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SlimeTAP.Pages.Main
{
    public class main : PageModel
    {
        private readonly ILogger<main> _logger;

        public main(ILogger<main> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}