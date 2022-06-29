using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DevOpsForAzureSQL.Data;

namespace DevOpsForAzureSQL.Pages
{
    public class CustomersModel : PageModel
    {
        private readonly DevOpsForAzureSQLContext _context;

        public CustomersModel(DevOpsForAzureSQLContext context)
        {
            _context = context;
        }

      public IEnumerable<Customer> Customers { get; set; } = default!; 

        public IActionResult OnGet()
        {
            var customers = _context.Customers;
            if (customers == null)
            {
                return NotFound();
            }
            else 
            {
                Customers = customers;
            }
            return Page();
        }
    }
}
