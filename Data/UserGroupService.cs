using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CampTiger.Models;

namespace CampTiger.Data
{
    public class UserGroupService
    {
        CampDbContext _context;
        public UserGroupService(CampDbContext context)
        {
            _context = context;
        }

        public async Task<List<UserGroups>> GetUserGroupAsync()
        {
            return await _context.UserGroups.ToListAsync();
        }

        public async Task<UserGroups> GetUserGroupByIdAsync(string id)
        {
            return await _context.UserGroups.FindAsync(id);
        }

        public async Task<UserGroups> InsertUserGroupAsync(UserGroups usergroups)
        {
            _context.UserGroups.Add(usergroups);
            await _context.SaveChangesAsync();
            return usergroups;
        }

        public async Task<UserGroups> UpdateUserGroupAsync(string id, UserGroups u)
        {
            var usergroups = await _context.UserGroups.FindAsync(id);

            if (usergroups == null)
                return null;

            usergroups.GroupId = u.GroupId;
            usergroups.UserId = u.UserId;

            _context.UserGroups.Update(usergroups);
            await _context.SaveChangesAsync();

            return usergroups;
        }
        public async Task<UserGroups> DeleteUserGroupAsync(string id , string id2)
        {
            var usergroups = await _context.UserGroups.FindAsync(id, id2);
            if (usergroups == null)
                return null;
            _context.UserGroups.Remove(usergroups);
            await _context.SaveChangesAsync();

            return usergroups;
        }
        private bool UserGroupExists(string id)
        {
            return _context.UserGroups.Any(e => e.UserId == id);
        }
    }
}