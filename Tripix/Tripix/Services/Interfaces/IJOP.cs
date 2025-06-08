using OpenQA.Selenium.DevTools.V132.DOM;
using Tripix.Abstractions;
using Tripix.Contracts.Jop;
using Tripix.Entities;
using Tripix.View_Models;

namespace Tripix.Services.Interfaces
{
    public interface IJOP
    {
        public Task<List<Jop>> GetJopsAsync(CancellationToken canToken = default);
        public Task<Jop> AddJop(AddJopDTO model);
        public Task<Result<Jop>> UpdateJopAsync(UpdateJopDTO model, CancellationToken canToken = default);
        public Task<Result> DeleteJop (int Id, CancellationToken canToken = default);
        public Task<Result> ApplyForJopAsync(string UserId , ApplyForJopDTO model, CancellationToken canToken = default);
        public Task<List<JopApplicationResponse>> GetJopApplicationsAsync(CancellationToken canToken = default);
        public Task<Result> RejectJopApplicationAsync(int Id, CancellationToken canToken = default);
        public Task<Result> AcceptJopApplicationAsync(int Id, CancellationToken canToken = default);
        public Task<Result<List<JopApplicationResponse>>> GetUserJopApplications(string UserId, CancellationToken canToken = default);
        public Task<Result> DeleteJopApplicaiton (int Id , CancellationToken canToken = default);


    }
}
