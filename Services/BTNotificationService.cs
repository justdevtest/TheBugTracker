﻿using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheBugTracker.Data;
using TheBugTracker.Models;
using TheBugTracker.Services.Interfaces;

namespace TheBugTracker.Services
{
    public class BTNotificationService : IBTNotificationService
    {
        private readonly ApplicationDbContext _context;
        private readonly IEmailSender _emailSender;
        private readonly IBTRolesService _roleService;

        public BTNotificationService(ApplicationDbContext context, IEmailSender emailSender, IBTRolesService roleService)
        {
            _context = context;
            _emailSender = emailSender;
            _roleService = roleService;
        }

        public async Task AddNotificationAsync(Notification notification)
        {
            try
            {
                await _context.AddAsync(notification);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Notification>> GetReceivedNotificationAsync(string userId)
        {
            try
            {
                List<Notification> notifications = await _context.Notifications
                                                                 .Include(n => n.Recipient)
                                                                 .Include(n => n.Sender)
                                                                 .Include(n => n.Ticket)
                                                                     .ThenInclude(t => t.Project)
                                                                 .Where(n => n.RecipientId == userId).ToListAsync();
                return notifications;
            }
            catch (Exception)
            {

                throw;
            }
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
