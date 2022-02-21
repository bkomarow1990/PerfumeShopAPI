using System.Threading.Tasks;

namespace ASP_PerfumeShopAPI.Core.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string to, string from, string subject, string body);
    }
}