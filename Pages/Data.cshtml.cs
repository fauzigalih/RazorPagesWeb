using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesWeb.Pages
{
    public class DataModel : PageModel
    {
        public void OnGet()
        {
        }

        [Required]
        public string instagram = "kajja";
    }
}
