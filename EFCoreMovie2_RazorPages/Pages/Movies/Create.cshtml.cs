using System.Collections.Generic;
using System.Linq;
using EFCoreMovie2_RazorPages.EFServices;
using EFCoreMovie2_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreMovie2_RazorPages.Pages.Movies;

public class Create : PageModel
{
    [BindProperty]
    public Movie Movie { get; set; }
    public EFMovieService _movieService;
    public EFStudioService _studioService;
    public IEnumerable<Studio> Studios { get; set; }
    public Create(EFMovieService movieService, EFStudioService studioService)
    {
        _movieService = movieService;
        _studioService = studioService;
        Studios = new List<Studio>();
        
    }
    public void OnGet()
    {
        Studios = _studioService.GetStudios();
    }
    
    public void OnPost()
    {
        if (!ModelState.IsValid)
        {
            Studios = _studioService.GetStudios();
            return;
        }

        Movie.StudioId++;
        Movie.Id = _movieService.GetMovies().Max(m => m.Id) + 1;
        _movieService.AddMovie(Movie);
        Response.Redirect("/Movies/GetMovies");
    }
}