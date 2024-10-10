using EFCoreMovie2_RazorPages.EFServices;
using EFCoreMovie2_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreMovie2_RazorPages.Pages.Studios;

public class Create : PageModel
{
    [BindProperty]
    public Studio Studio { get; set; }
    public EFStudioService _studioService;
    public Create(EFStudioService studioService)
    {
        _studioService = studioService;
    }
    public void OnGet()
    {
        
    }
    public void OnPost(Studio studio)
    {
       _studioService.AddStudio(studio);
        Response.Redirect("/Studios/GetStudios");
    }
}