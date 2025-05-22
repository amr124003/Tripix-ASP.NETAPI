using Microsoft.EntityFrameworkCore;

namespace Tripix.Entities
{
    [Owned]
    public class RefreshTokens
    {
        public int Id { get; set; }
        public string RefreshToken { get; set; }
        public DateTime ExpiredDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? RevokeTime { get; set; }
        public bool IsExpired => DateTime.UtcNow >= ExpiredDate;
        public bool IsActive => RevokeTime is null && !IsExpired;

    }
}
