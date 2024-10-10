using System.Collections.Generic;
using EFCoreMovie2_RazorPages.Models;

namespace EFCoreMovie2_RazorPages.Interfaces;

public  interface IStudioService
{
    public IEnumerable<Studio> GetStudios();
    void AddStudio(Studio studio);
    Studio GetStudioById(int id);
    void DeleteStudio(Studio studio);
}