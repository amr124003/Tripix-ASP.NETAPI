using Tripix.Abstractions;
using Tripix.Contracts.Common;
using Tripix.Contracts.Tips;
using Tripix.Entities;
using Tripix.View_Models;

namespace Tripix.Services.Interfaces
{
    public interface ITip
    {
        public Task<PaginatedList<Tip>> GetTips(RequestFilter model , CancellationToken canToken = default);
        public Task<Result<Tip>> GetTip(int id , CancellationToken canToken = default);
        public Task<Result<Tip>> AddTip(AddTipDTO model, CancellationToken canToken = default);
        public Task<Result<Tip>> UpdateTip(UpdateTipDTO model, CancellationToken canToken = default);
        public Task<Result> DeleteTip(int Id , CancellationToken canToken = default);
        public Task<Result> LikeTip(string UserId , int Id , CancellationToken canToken = default);
        public Task<Result> DislikeTip(string UserId , int Id, CancellationToken canToken = default);
        public Task<Result> CommentToTip(string UserId, CommentDto model, CancellationToken canToken = default);
        public Task<Result> UpdateComment(string UserId , UpdateCommentDTO model, CancellationToken cancellationToken = default);
        public Task<Result> DeleteComment(int Id , CancellationToken canToken = default);
        public Task<Result> DeleteUserComment(string UserId , int Id , CancellationToken canToken = default);
        public Task<Result> ReplyForComment (string UserId , ReplyForComment model , CancellationToken canToken = default);
        
    }
}
