using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreMovie2_RazorPages.EFServices;
using EFCoreMovie2_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreMovie2_RazorPages.Pages.Movies
{
    public class GetMoviesModel : PageModel
    {
        public string FilterCriteria { get; set; }
        private EFMovieService _service;
        public IEnumerable<Movie> Movies { get; set; }
        public GetMoviesModel(EFMovieService service)
        {
            _service = service;
        }
        
        public void OnGet()
        {
            Movies = _service.GetMovies();
        }
        public void OnPost()
        {

        }
    }
}