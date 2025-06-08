using Tripix.Abstractions;
using Tripix.Contracts.Notification;
using Tripix.Entities;
using Tripix.View_Models;

namespace Tripix.Services.Interfaces
{
    public interface INotification
    {
        public Task<List<Notification>> GetNotifications();
        public Task<Notification> GetNotification(int id);
        public Task<Notification> GenerateNotification();
        public Task<Notification> AddNotification(AddNotificationDTO model , CancellationToken canToken = default);
        public Task<Result> DeleteNotification(int Id);
        public Task<Result<Notification>> UpdateNotification(UpdateNotifacationDTO model, CancellationToken canToken = default);
    }
}
