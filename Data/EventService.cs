using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CampTiger.Models;
namespace CampTiger.Data
{
    public class EventService
    {
        CampDbContext _context;
        public EventService(CampDbContext context)
        {
            _context = context;
        }

        public async Task<List<Event>> GetEventsAsync()
        {
            return await _context.Event.ToListAsync();
        }

        public async Task<Event> GetEventByIdAsync(string id)
        {
            return await _context.Event.FindAsync(id);
        }

        public async Task<Event> InsertEventAsync(Event e)
        {
            _context.Event.Add(e);
            await _context.SaveChangesAsync();
            return e;
        }

        public async Task<Event> UpdateEventAsynC(string id, Event e)
        {
            var even = await _context.Event.FindAsync(id);
            if (even == null)
                return null;
            even.EventId = e.EventId;
            even.Leader = e.Leader;
            even.Group = e.Group;
            even.Name = e.Name;
            even.Description = e.Description;
            even.Date = e.Date;
            even.Time = e.Time;
            even.Capacity = e.Capacity;
            _context.Event.Update(even);
            await _context.SaveChangesAsync();
            return even;
        }

        public async Task<Event> DeleteEventAsync(string id)
        {
            var even = await _context.Event.FindAsync(id);

            if (even == null)
                return null;

            _context.Event.Remove(even);
            await _context.SaveChangesAsync();

            return even;
        }

        public bool EventExists(string id)
        {
            return _context.Event.Any(e => e.EventId == id);
        }
    }
}