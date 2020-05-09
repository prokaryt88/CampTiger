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
    }
}
