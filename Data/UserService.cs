using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CampTiger.Models;

namespace CampTiger.Data
{
    public class UserService
    {
        CampDbContext _context;
        
        public UserService(CampDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetUserAsync()
        {
            return await _context.User.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(string id)
        {
            return await _context.User.FindAsync(id);
        }

        public async Task<User> InsertUserAsync(User user)
        {
            _context.User.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> UpdateUserAsync(string id, User u)
        {
            var user = await _context.User.FindAsync(id);

            if (user == null)
                return null;

            user.UserId = u.UserId;
            user.FirstName = u.FirstName;
            user.LastName = u.LastName;
            user.Address = u.Address;
            user.State = u.State;
            user.Zip = u.Zip;
            user.Phone = u.Phone;

            _context.User.Update(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<User> DeleteUserAsync(string id)
        {
            var user = await _context.User.FindAsync(id);
            if (user == null)
                return null;
            _context.User.Remove(user);
            await _context.SaveChangesAsync();

            return user;
        }

        private bool UserExists(string id)
        {
            return _context.User.Any(e => e.UserId == id);
        }
    }
}

