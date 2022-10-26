using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tarau_damaris_lab2.Data;
using tarau_damaris_lab2.Models;

namespace tarau_damaris_lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly tarau_damaris_lab2.Data.tarau_damaris_lab2Context _context;

        public IndexModel(tarau_damaris_lab2.Data.tarau_damaris_lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
