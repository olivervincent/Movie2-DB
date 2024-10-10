using EFCoreMovie2_RazorPages.EFServices;
using EFCoreMovie2_RazorPages.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreMovie2_RazorPages.Pages.Movies;

public class Delete : PageModel
{
    public EFMovieService _movieService;
    public Delete(EFMovieService movieService)
    {
        _movieService = movieService;
    }
    public void OnGet(int id)
    {
        Movie movie = _movieService.GetMovieById(id);
        _movieService.DeleteMovie(movie);
        Response.Redirect("/Movies/GetMovies");
    }
}