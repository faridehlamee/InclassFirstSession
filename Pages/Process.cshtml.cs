using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Razor4602.Pages
{
    public class Process : PageModel
    {
        private readonly ILogger<Process> _logger;

        public Process(ILogger<Process> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
         //  Process[] proc = System.Diagnostics.Process.GetProcesses();

        }
    }
}