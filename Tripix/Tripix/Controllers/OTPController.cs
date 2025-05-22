#nullable disable
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;
using Tripix.View_Models;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OTPController : ControllerBase
    {
        private readonly HttpClient client;
        public OTPController ( HttpClient client )
        {
            this.client = client;
        }
        [HttpPost("send-otp")]
        public async Task<IActionResult> SendOtp ( [FromBody] OtpRequest request )
        {
            var fromEmail = Environment.GetEnvironmentVariable("superAdminEmail"); 
            var fromPassword = Environment.GetEnvironmentVariable("SMTPPassword"); 

            if (!IsValidEmail(request.Email))
            {
                return BadRequest("Invalid email format.");
            }

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromEmail, fromPassword),
                EnableSsl = true,
            };

            string subject = "🔐 Your Tripix OTP Code";

            var otp = GenerateOtp();



            string templatepath = Path.Combine(Directory.GetCurrentDirectory(), "Templates", "OTP_Email.html");
            string template = System.IO.File.ReadAllText(templatepath);
            string body = template.Replace("{{otp}}", otp); 


            var mailMessage = new MailMessage
            {
                From = new MailAddress(fromEmail, "Tripix Support"),
                Subject = subject,
                Body = body,
                IsBodyHtml = true,
            };

            Console.WriteLine(body);

            mailMessage.ReplyToList.Add(new MailAddress(fromEmail)); 
            mailMessage.Headers.Add("X-Priority", "1"); 
            mailMessage.Headers.Add("X-MSMail-Priority", "High");
            mailMessage.Headers.Add("Importance", "High");
            mailMessage.To.Add(request.Email);
            await smtpClient.SendMailAsync(mailMessage);

            return Ok(new { otp });
        }


        private bool IsValidEmail ( string email )
        {
            return new EmailAddressAttribute().IsValid(email);
        }

        private string GenerateOtp ( int length = 4 )
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"; 
            Random random = new();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }

}
