namespace Tripix.Contracts.Authentication
{
    public record ConfirmationEmailRequest ( string Email, string OTP );
}
