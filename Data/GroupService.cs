using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CampTiger.Models;

namespace CampTiger.Data
{
    public class GroupService
    {
        CampDbContext _context;
        public GroupService(CampDbContext context)
        {
            _context = context;
        }

        public async Task<List<Group>> GetGroupAsync()
        {
            return await _context.Group.ToListAsync();
        }

        public async Task<Group> GetGroupByIdAsync(string id)
        {
            return await _context.Group.FindAsync(id);
        }

        public async Task<Group> InsertGroupAsync(Group group)
        {
            _context.Group.Add(group);
            await _context.SaveChangesAsync();
            return group;
        }

        public async Task<Group> UpdateGroupAsync(string id, Group g)
        {
            var group = await _context.Group.FindAsync(id);

            if (group == null)
                return null;

            group.GroupId = g.GroupId;
            group.Leader = g.Leader;
            group.Description = g.Description;
            group.Name = g.Name;

            _context.Group.Update(group);
            await _context.SaveChangesAsync();

            return group;
        }

        public async Task<Group> DeleteGroupAsync(string id)
        {
            var group = await _context.Group.FindAsync(id);
            if (group == null)
                return null;
            _context.Group.Remove(group);
            await _context.SaveChangesAsync();

            return group;
        }

        private bool GroupExists(string id)
        {
            return _context.Group.Any(e => e.GroupId == id);
        }
    }
}
