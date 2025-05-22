using Tripix.Abstractions;
using Tripix.Contracts.Authentication;
using Tripix.View_Models;

namespace Tripix.Services.Interfaces
{
    public interface IAuthService
    {
        public Task<Result> RegisterAsync ( RegisterModel model, CancellationToken token = default );
        public Task<Result<AuthResponse>> GetTokenAsync ( LoginModel model, CancellationToken token = default );
        public Task<Result<AuthResponse>> GetRefreshtoken ( string Token  , CancellationToken cencellationtoken = default);
        public Task<bool> RevokeRefreshTokenAsync ( string refreshToken, CancellationToken cancellationToken = default );
        public Task<Result<AuthResponse>> ConfirmEmailAsync ( ConfirmationEmailRequest request );
        public Task<Result> ResendConfirmEmailAsync ( ResendConfirmationEmailRequest request );
        public Task<Result> SendResetPasswordCodeAsync ( SendResetPasswordRequest request );
        public Task<Result> ResetPassowrdAsync ( ResetPasswordRequest request );
        public Task<Result<AuthResponse>> GoogleLogin ( GoogleAuthDTO model, CancellationToken cancellationToken = default );
    }
}
