using System.Collections.Generic;
using EFCoreMovie2_RazorPages.Models;

namespace EFCoreMovie2_RazorPages.Interfaces;

public  interface IMovieService
{
    public IEnumerable<Movie> GetMovies();
    void AddMovie(Movie movie);
    void DeleteMovie(Movie movie);
    Movie GetMovieById(int id);
}
