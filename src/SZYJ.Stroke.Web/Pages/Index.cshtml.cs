using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace SZYJ.Stroke.Web.Pages
{
    public class IndexModel : StrokePageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}