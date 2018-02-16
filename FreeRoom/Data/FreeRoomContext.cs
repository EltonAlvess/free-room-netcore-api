using FreeRoom.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreeRoom.Data
{
    public class FreeRoomContext : DbContext
    {



        public FreeRoomContext(DbContextOptions<FreeRoomContext> options)
            : base(options)
        {
        }

        public DbSet<Sensors> Sensors { get; set; }
    }
}