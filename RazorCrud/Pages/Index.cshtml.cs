using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
namespace RazorCrud.Pages
{
    public class IndexModel : PageModel
    {

        private readonly AppDbContext _db;

        //constructor
        public IndexModel(AppDbContext db)
        {
            _db = db;
        }

        public IList<Customer> Customers { get; private set; }

        public async Task OnGetAsync()
        {
            Customers = await _db.Customers.AsNoTracking().ToListAsync();
        }

        //delete data
        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var Customer = await _db.Customers.FindAsync(id);

            if (Customer != null)
            {
                _db.Customers.Remove(Customer);
                await _db.SaveChangesAsync();
            }
            return RedirectToPage();
        }
    }
}
