using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstRazorPage.Data;
using FirstRazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FirstRazorPage.Pages.ProductList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public IndexModel(ApplicationDbContext context)
        {
            this._context = context;
        }
        public IEnumerable<Product> Products { get; set; }
        public async Task OnGet()
        {
            Products = await _context.Products.ToListAsync();
        }
        
        public async Task<IActionResult> OnPostDelete(int id)
        {
            Product item = await _context.Products.FindAsync(id);
            if(item == null)
            {
                return NotFound(); // to send 404 error instead of 500.
            }
            _context.Products.Remove(item);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
