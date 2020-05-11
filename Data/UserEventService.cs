using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CampTiger.Models;

namespace CampTiger.Data
{
    public class UserEventService
    {
        CampDbContext _context;
        public UserEventService(CampDbContext context)
        {
            _context = context;
        }

        public async Task<List<UserEvent>> GetUserEventAsync()
        {
            return await _context.UserEvent.ToListAsync();
        }

        public async Task<UserEvent> GetUserEventByIdAsync(string id)
        {
            return await _context.UserEvent.FindAsync(id);
        }

        public async Task<UserEvent> InsertUserEventAsync(UserEvent userevent)
        {
            _context.UserEvent.Add(userevent);
            await _context.SaveChangesAsync();
            return userevent;
        }

        public async Task<UserEvent> UpdateUserEventAsync(string id, string id2, UserEvent u)
        {
            var userevent = await _context.UserEvent.FindAsync(id, id2);

            if (userevent == null)
                return null;

            userevent.EventId = u.EventId;
            userevent.UserId = u.UserId;
            userevent.Approved = u.Approved;

            _context.UserEvent.Update(userevent);
            await _context.SaveChangesAsync();

            return userevent;
        }
        public async Task<UserEvent> DeleteUserEventAsync(string id, string id2)
        {
            var userevent = await _context.UserEvent.FindAsync(id, id2);
            if (userevent == null)
                return null;
            _context.UserEvent.Remove(userevent);
            await _context.SaveChangesAsync();

            return userevent;
        }
        private bool UserEventExists(string id)
        {
            return _context.UserEvent.Any(e => e.UserId == id);
        }
    }
}