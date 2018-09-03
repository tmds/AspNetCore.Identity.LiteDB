using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace AspNetCore.Identity.LiteDB.Demo.Services
{
   public static class EmailSenderExtensions
   {
      public static Task SendEmailConfirmationAsync(this IEmailSender emailSender, string email, string link) =>
         emailSender.SendEmailAsync(email, "Confirm your email",
            $"Please confirm your account by clicking this link: <a href='{HtmlEncoder.Default.Encode(link)}'>link</a>");
   }
}