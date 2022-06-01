using HamsterApp.API.Data;
using HamsterApp.Entities.Models;

namespace HamsterApp.API.Repo
{
    public class HamsterRepository : GenericRepository<Hamster>, IHamsterRepository
    {
        public HamsterRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
