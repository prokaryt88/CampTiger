/*using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CampTiger.Models;

namespace CampTiger.Data
{
    public class UserGroupervice
    {
        CampDbContext _context;
        public UserGroupervice(CampDbContext context)
        {
            _context = context;
        }
        public async Task<List<UserGroup>> GetUserGroupAsync()
        {
            return await _context.UserGroup.ToListAsync();
        }
        public async Task<UserGroup> GetUserGroupByIdAsync(string id)
        {
            return await _context.UserGroup.FindAsync(id);
        }
        public async Task<UserGroup> InsertUserGroupAsync(UserGroup usergroup)
        {
            _context.UserGroup.Add(usergroup);
            await _context.SaveChangesAsync();
            return usergroup;
        }
        public async Task<UserGroup> UpdateUserGroupAsync(string id, UserGroup u)
        {
            var usergroup = await _context.UserGroup.FindAsync(id);

            if (usergroup == null)
                return null;

            usergroup.GroupId = u.GroupId;
            usergroup.UserId = u.UserId;

            _context.UserGroup.Update(usergroup);
            await _context.SaveChangesAsync();

            return usergroup;
        }
        public async Task<UserGroup> DeleteUserGroupAsync(string id)
        {
            var usergroup = await _context.UserGroup.FindAsync(id);
            if (usergroup == null)
                return null;
            _context.UserGroup.Remove(usergroup);
            await _context.SaveChangesAsync();

            return usergroup;
        }
        private bool UserGroupExists(string id)
        {
            return _context.UserGroup.Any(e => e.UserId == id);
        }
    }
}*/