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
    public class DetailsModel : PageModel
    {
        private readonly tarau_damaris_lab2.Data.tarau_damaris_lab2Context _context;

        public DetailsModel(tarau_damaris_lab2.Data.tarau_damaris_lab2Context context)
        {
            _context = context;
        }

      public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Publisher == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else 
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
