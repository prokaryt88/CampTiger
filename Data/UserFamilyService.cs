using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CampTiger.Models;

namespace CampTiger.Data
{
    public class UserFamilyService
    {
        CampDbContext _context;
        public UserFamilyService(CampDbContext context)
        {
            _context = context;
        }

        public async Task<List<UserFamily>> GetUserFamilyAsync()
        {
            return await _context.UserFamily.ToListAsync();
        }

        public async Task<UserFamily> GetUserFamilyByIdAsync(string id, string id2)
        {
            return await _context.UserFamily.FindAsync(id, id2);
        }

        public async Task<UserFamily> InsertUserFamilyAsync(UserFamily UserFamily)
        {
            _context.UserFamily.Add(UserFamily);
            await _context.SaveChangesAsync();
            return UserFamily;
        }

        public async Task<UserFamily> UpdateUserFamilyAsync(string id, string id2, UserFamily f)
        {
            var UserFamily = await _context.UserFamily.FindAsync(id, id2);

            if (UserFamily == null)
                return null;

            UserFamily.FamilyId = f.FamilyId;
            UserFamily.UserId = f.UserId;

            _context.UserFamily.Update(UserFamily);
            await _context.SaveChangesAsync();

            return UserFamily;
        }

        public async Task<UserFamily> DeleteUserFamilyAsync(string id, string id2)
        {
            var UserFamily = await _context.UserFamily.FindAsync(id, id2);
            if (UserFamily == null)
                return null;
            _context.UserFamily.Remove(UserFamily);
            await _context.SaveChangesAsync();

            return UserFamily;
        }

        private bool UserFamilyExists(string id, string id2)
        {
            return _context.UserFamily.Any(e => e.FamilyId == id & e.UserId == id2);
        }
    }
}
