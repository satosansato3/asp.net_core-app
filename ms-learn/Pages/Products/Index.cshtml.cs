using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ms_learn.Models;

namespace ms_learn.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ms_learn.Models.ms_learnContext _context;

        public IndexModel(ms_learn.Models.ms_learnContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
