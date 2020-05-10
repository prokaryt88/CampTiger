using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CampTiger.Models;

namespace CampTiger.Data
{
    public class AspNetUsersService
    {
        CampDbContext _context;
        
        public AspNetUsersService(CampDbContext context)
        {
            _context = context;
        }

        public async Task<List<AspNetUsers>> GetAspNetUsersAsync()
        {
            return await _context.AspNetUsers.ToListAsync();
        }

        public async Task<AspNetUsers> GetAspNetUsersByIdAsync(string id)
        {
            return await _context.AspNetUsers.FindAsync(id);
        }

        public async Task<AspNetUsers> InsertAspNetUsersAsync(AspNetUsers AspNetUsers)
        {
            _context.AspNetUsers.Add(AspNetUsers);
            await _context.SaveChangesAsync();
            return AspNetUsers;
        }

        public async Task<AspNetUsers> UpdateAspNetUsersAsync(string id, AspNetUsers u)
        {
            var AspNetUsers = await _context.AspNetUsers.FindAsync(id);

            if (AspNetUsers == null)
                return null;

            AspNetUsers.FirstName = u.FirstName;
            AspNetUsers.LastName = u.LastName;
            AspNetUsers.Address = u.Address;
            AspNetUsers.State = u.State;
            AspNetUsers.Zip = u.Zip;
            AspNetUsers.Phone = u.Phone;

            _context.AspNetUsers.Update(AspNetUsers);
            await _context.SaveChangesAsync();

            return AspNetUsers;
        }

        public async Task<AspNetUsers> DeleteAspNetUsersAsync(string id)
        {
            var AspNetUsers = await _context.AspNetUsers.FindAsync(id);
            if (AspNetUsers == null)
                return null;
            _context.AspNetUsers.Remove(AspNetUsers);
            await _context.SaveChangesAsync();

            return AspNetUsers;
        }

        private bool AspNetUsersExists(string id)
        {
            return _context.AspNetUsers.Any(e => e.Id == id);
        }
    }
}

