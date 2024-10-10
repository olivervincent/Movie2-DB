using System.Collections.Generic;
using EFCoreMovie2_RazorPages.Interfaces;
using EFCoreMovie2_RazorPages.Models;

namespace EFCoreMovie2_RazorPages.EFServices;

public class EFStudioService : IStudioService
{
    private MovieDBContext context;
    public EFStudioService(MovieDBContext service)
    {
        context = service;
    }
    public IEnumerable<Studio> GetStudios()
    {
        return context.Studios;
    }
    
    public void AddStudio(Studio studio)
    {
        context.Studios.Add(studio);
        context.SaveChanges();
    }
    
    public Studio GetStudioById(int id)
    {
        return context.Studios.Find(id);
    }
    
    public void DeleteStudio(Studio studio)
    {
        context.Studios.Remove(studio);
        context.SaveChanges();
    }
    
}