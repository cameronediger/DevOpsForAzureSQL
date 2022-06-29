using DevOpsForAzureSQL.Data;
using DevOpsForAzureSQL.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
