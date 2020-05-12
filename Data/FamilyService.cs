using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CampTiger.Models;

namespace CampTiger.Data
{
    public class FamilyService
    {
        CampDbContext _context;
        public FamilyService(CampDbContext context)
        {
            _context = context;
        }

        public async Task<List<Family>> GetFamilyAsync()
        {
            return await _context.Family.ToListAsync();
        }

        public async Task<Family> GetFamilyByIdAsync(string id)
        {
            return await _context.Family.FindAsync(id);
        }

        public async Task<Family> InsertFamilyAsync(Family Family)
        {
            _context.Family.Add(Family);
            await _context.SaveChangesAsync();
            return Family;
        }

        public async Task<Family> UpdateFamilyAsync(string id, Family f)
        {
            var Family = await _context.Family.FindAsync(id);

            if (Family == null)
                return null;

            Family.FamilyId = f.FamilyId;
            Family.LeaderId = f.LeaderId;
            Family.Name = f.Name;

            _context.Family.Update(Family);
            await _context.SaveChangesAsync();

            return Family;
        }

        public async Task<Family> DeleteFamilyAsync(string id)
        {
            var Family = await _context.Family.FindAsync(id);
            if (Family == null)
                return null;
            _context.Family.Remove(Family);
            await _context.SaveChangesAsync();

            return Family;
        }

        private bool FamilyExists(string id)
        {
            return _context.Family.Any(e => e.FamilyId == id);
        }
    }
}
