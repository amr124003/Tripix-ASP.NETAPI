using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System.Net;
using System.Net.Mail;
using Tripix.Abstractions;
using Tripix.Abstractions.Consts;
using Tripix.Context;
using Tripix.Contracts.Jop;
using Tripix.Entities;
using Tripix.Errors;
using Tripix.Extentions;
using Tripix.Services.Interfaces;
using Tripix.View_Models;

namespace Tripix.Services.Repositories
{
    public class JopRepo : IJOP
    {
        private readonly ApplicationDbcontext context;
        private readonly UserManager<ApplicationUser> usermanger;

        public JopRepo(ApplicationDbcontext context, UserManager<ApplicationUser> usermanger)
        {
            this.context = context;
            this.usermanger = usermanger;
        }
        public async Task<Result> AcceptJopApplicationAsync(int Id, CancellationToken canToken)
        {
            var jopApplication = await context.JopApplications.FirstOrDefaultAsync(x => x.Id == Id, canToken);

            if (jopApplication == null)  {return Result.Failure(JopErrors.JopApplicationNotFound);}

            if (jopApplication.Status == JopApplicationStatus.Accepted) { return Result.Failure(JopErrors.JopAlreadyAccpted); }

            if (jopApplication.Status == JopApplicationStatus.Rejected) { return Result.Failure(JopErrors.JopApplicationRejected); }

            jopApplication.Status = JopApplicationStatus.Accepted;
            await context.SaveChangesAsync(canToken);

            var user = await usermanger.Users.FirstOrDefaultAsync(x => x.Email == jopApplication.UserEmail, canToken);

            var validuserRes = user!.ValidUser();
            if (validuserRes.IsFalure) { return validuserRes; }

            await SendJopApplicationEmail(user!,true);
            return Result.Success();
        }

        public async Task<Jop> AddJop(AddJopDTO model)
        {
            var newJop = model.Adapt<Jop>();

            await context.Jops.AddAsync(newJop);
            await context.SaveChangesAsync();
            return newJop;
        }

        public async Task<Result> ApplyForJopAsync(string UserId, ApplyForJopDTO model, CancellationToken canToken)
        {
            var user = await usermanger.Users.FirstOrDefaultAsync(X => X.Id == UserId, canToken);

            var validUserRes = user!.ValidUser();

            if (validUserRes.IsFalure) { return validUserRes; }

            var jop = await context.Jops.FirstOrDefaultAsync(x => x.Id == model.JopId, canToken);

            if (jop == null) { return Result.Failure(JopErrors.JopNotFound); }

            if (model.CV == null || model.CV.Length == 0)
            {
                return Result.Failure(JopErrors.CvNotFound);
            }

            using var Transaction = context.Database.BeginTransaction();

            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.JopApplicationCvs}{model.CV.FileName + "-" + model.UserName}");
                var jopApplication = new JopApplications()
                {
                    UserName = model.UserName ?? user!.Name,
                    UserEmail = model.UserEmail ?? user!.Email!,
                    UserPhone = model.UserPhone ?? user!.PhoneNumber,
                    JopId = model.JopId,
                    Position = jop.Position,
                    Status = JopApplicationStatus.Pending,
                    CV = $"{Urls.JopApplicationCvs}{model.CV.FileName + "-" + model.UserName}"
                };

                user!.JopApplications.Add(jopApplication);
                await context.SaveChangesAsync();
                await Transaction.CommitAsync(canToken);
                return Result.Success();
            }
            catch
            {
                await Transaction.RollbackAsync(canToken);
                return Result.Failure(JopErrors.ErrorOnApply);
            }
        }

        public async Task<Result> DeleteJop(int Id, CancellationToken canToken)
        {
            var jop = await context.Jops.FirstOrDefaultAsync(x => x.Id == Id, canToken);

            if (jop == null) { return Result.Failure(JopErrors.JopNotFound); }

            context.Jops.Remove(jop);
            await context.SaveChangesAsync(canToken);
            return Result.Success();
        }

        public async Task<Result> DeleteJopApplicaiton(int Id, CancellationToken canToken = default)
        {
            var jopApplication = await context.JopApplications.FirstOrDefaultAsync(x => x.Id == Id, canToken);

            if (jopApplication == null) { return Result.Failure(JopErrors.JopApplicationNotFound); }

            context.JopApplications.Remove(jopApplication);
            await context.SaveChangesAsync();
            return Result.Success();
        }

        public Task<List<JopApplicationResponse>> GetJopApplicationsAsync(CancellationToken canToken)
        {
            var JopApplications = context.JopApplications.
                 AsQueryable()
                .ProjectToType<JopApplicationResponse>()
                .ToListAsync(canToken);

            return JopApplications;
        }

        public Task<List<Jop>> GetJopsAsync(CancellationToken canToken)
        {
            var Jops = context.Jops.ToListAsync(canToken);

            return Jops;
        }

        public async Task<Result<List<JopApplicationResponse>>> GetUserJopApplications(string UserId, CancellationToken canToken)
        {
            var Response = new List<JopApplicationResponse>();

            var user = await usermanger.Users.FirstOrDefaultAsync(x => x.Id == UserId);

            var uservalidres = user!.ValidUser(Response);

            if (uservalidres.IsFalure) { return uservalidres!; }

            var JopApplications = await user!.JopApplications
                .AsQueryable()
                .ProjectToType<JopApplicationResponse>()
                .ToListAsync(canToken);

            return Result.Success(JopApplications);
        }

        public async Task<Result> RejectJopApplicationAsync(int Id, CancellationToken canToken)
        {
            var jopApplication = await context.JopApplications.FirstOrDefaultAsync(x => x.Id == Id, canToken);

            if (jopApplication == null) { return Result.Failure(JopErrors.JopApplicationNotFound); }

            if (jopApplication.Status == JopApplicationStatus.Accepted) { return Result.Failure(JopErrors.JopAlreadyAccpted); }

            if (jopApplication.Status == JopApplicationStatus.Rejected) { return Result.Failure(JopErrors.JopApplicationRejected); }

            jopApplication.Status = JopApplicationStatus.Rejected;
            await context.SaveChangesAsync(canToken);

            var user = await usermanger.Users.FirstOrDefaultAsync(x => x.Email == jopApplication.UserEmail, canToken);

            var validuserRes = user!.ValidUser();
            if (validuserRes.IsFalure) { return validuserRes; }

            await SendJopApplicationEmail(user!, false);
            return Result.Success();
        }

        public async Task<Result<Jop>> UpdateJopAsync(UpdateJopDTO model, CancellationToken canToken)
        {
            var Jop = await context.Jops.FirstOrDefaultAsync(x => x.Id == model.Id, canToken);

            if (Jop == null) { return Result.Failure<Jop>(JopErrors.JopNotFound); }

            model.Adapt(Jop);
            await context.SaveChangesAsync();
            return Result.Success(Jop);
        }

        private async Task SendJopApplicationEmail(ApplicationUser user, bool Accepted)
        {

            var message = Accepted ? "Congratulations" : "Unfortunately";
            var bigmessage = Accepted ? "You can come to the company for the second level of interview and your selection will be determined or not." : "Your Job Application has been rejected. You can apply for other or similar jobs later.";

            var fromEmail = Environment.GetEnvironmentVariable("superAdminEmail");
            var fromPassword = Environment.GetEnvironmentVariable("SMTPPassword");

            Console.WriteLine($"FromEmail: {fromEmail}");
            Console.WriteLine($"FromPassword: {fromPassword}");




            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromEmail, fromPassword),
                EnableSsl = true,
            };

            string subject = "Your Jop Application Result";

            string templatepath = Path.Combine(Directory.GetCurrentDirectory(), "Templates", "JopApplicationEmail.html");
            string template = File.ReadAllText(templatepath);
            string body = template.Replace("{{username}}", user.Name)
             .Replace("{{message}}", message)
             .Replace("{{bigmessage}}", bigmessage);


            var mailMessage = new MailMessage
            {
                From = new MailAddress(fromEmail!, "Tripix Support"),
                Subject = subject,
                Body = body,
                IsBodyHtml = true,
            };

            mailMessage.ReplyToList.Add(new MailAddress(fromEmail!));
            mailMessage.Headers.Add("X-Priority", "1");
            mailMessage.Headers.Add("X-MSMail-Priority", "High");
            mailMessage.Headers.Add("Importance", "High");
            mailMessage.To.Add(user.Email!);
            await smtpClient.SendMailAsync(mailMessage);

        }
    }
}
