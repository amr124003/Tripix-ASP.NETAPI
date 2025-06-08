using Tripix.Abstractions;
using Tripix.Contracts.Notification;
using Tripix.Entities;
using Tripix.Services.Interfaces;
using Tripix.View_Models;

namespace Tripix.Services.Repositories
{
    public class NotificationRepo : INotification
    {
        public Task<Notification> AddNotification(AddNotificationDTO model, CancellationToken canToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<Result> DeleteNotification(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Notification> GenerateNotification()
        {
            throw new NotImplementedException();
        }

        public Task<Notification> GetNotification(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Notification>> GetNotifications()
        {
            throw new NotImplementedException();
        }

        public Task<Result<Notification>> UpdateNotification(UpdateNotifacationDTO model, CancellationToken canToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
