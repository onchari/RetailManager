using System.Threading.Tasks;
using SRMDesktopUI.Models;

namespace SRMDesktopUI.Helpers
{
    public interface IApiHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}