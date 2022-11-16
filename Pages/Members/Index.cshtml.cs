﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tarau_damaris_lab2.Data;
using tarau_damaris_lab2.Models;

namespace tarau_damaris_lab2.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly tarau_damaris_lab2.Data.tarau_damaris_lab2Context _context;

        public IndexModel(tarau_damaris_lab2.Data.tarau_damaris_lab2Context context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Member != null)
            {
                Member = await _context.Member.ToListAsync();
            }
        }
    }
}
