using System.Collections.Generic;
using EFCoreMovie2_RazorPages.Interfaces;
using EFCoreMovie2_RazorPages.Models;

namespace EFCoreMovie2_RazorPages.EFServices;

public class EFMovieService : IMovieService
{
    private MovieDBContext context;
    public EFMovieService(MovieDBContext service)
    {
        context = service;
    }
    public IEnumerable<Movie> GetMovies()
    {
        return context.Movies;
    }
    
    public void AddMovie(Movie movie)
    {
        context.Movies.Add(movie);
        context.SaveChanges();
    }
    
    public Movie GetMovieById(int id)
    {
        return context.Movies.Find(id);
    }
    
    public void DeleteMovie(Movie movie)
    {
        context.Movies.Remove(movie);
        context.SaveChanges();
    }
}