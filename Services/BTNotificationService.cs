using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheBugTracker.Models;
using TheBugTracker.Services.Interfaces;

namespace TheBugTracker.Services
{
    public class BTNotificationService : IBTNotificationService
    {
        public Task AddNotificationAsync(Notification notification)
        {
            throw new NotImplementedException();
        }

        public Task<List<Notification>> GetReceivedNotificationAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Notification>> GetSentNotificationAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task SendEmailNotification(Notification notification, string emailSubject)
        {
            throw new NotImplementedException();
        }

        public Task SendEmailNotificationByRoleAsync(Notification notification, int companyId, string role)
        {
            throw new NotImplementedException();
        }

        public Task SendMembersEmailNotificationsAsync(Notification notification, List<BTUser> members)
        {
            throw new NotImplementedException();
        }
    }
}
