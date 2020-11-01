using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
  public class EditPageModel : PageModel
  {
    private ApplicationDbContext _db;

    public EditPageModel(ApplicationDbContext db)
    {
      _db = db;
    }
    [BindProperty]
    public Book Book { get; set; }
    public async Task OnGet(int id)
    {
      Book = await _db.Book.FindAsync(id);
    }
  }
}
