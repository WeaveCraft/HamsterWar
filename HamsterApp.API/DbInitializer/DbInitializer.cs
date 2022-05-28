using HamsterApp.API.Data;
using Microsoft.EntityFrameworkCore;

namespace HamsterApp.API.DbInitializer
{
    public class DbInitializer
    {
        private readonly ApplicationDbContext _db;

        public DbInitializer(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
