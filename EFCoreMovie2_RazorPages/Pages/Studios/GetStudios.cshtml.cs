using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreMovie2_RazorPages.EFServices;
using EFCoreMovie2_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreMovie2_RazorPages.Pages.Studios
{
    public class GetStudiosModel : PageModel
    {
        public string FilterCriteria { get; set; }
        private EFStudioService _service;
        public IEnumerable<Studio> Studios { get; set; }
        public GetStudiosModel(EFStudioService service)
        {
            _service = service;
        }
        
        public void OnGet()
        {
            Studios = _service.GetStudios();
        }
        public void OnPost()
        {

        }
    }
}