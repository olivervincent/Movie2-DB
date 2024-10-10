using EFCoreMovie2_RazorPages.EFServices;
using EFCoreMovie2_RazorPages.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreMovie2_RazorPages.Pages.Studios;

public class Delete : PageModel
{
    public EFStudioService _studioService;
    public Delete(EFStudioService studioService)
    {
        _studioService = studioService;
    }
    public void OnGet(int id)
    {
        Studio studio = _studioService.GetStudioById(id);
        _studioService.DeleteStudio(studio);
        Response.Redirect("/Studios/GetStudios");
    }
}