using Microsoft.EntityFrameworkCore;
using MyLogbook.Abstractions;
using MyLogbook.AppContext;
using MyLogbook.Entities;


namespace MyLogbook.Repositories
{
    public class RatingRepositoty : DbRepository<Rating>, IRatingRepository
    {
        public RatingRepositoty(AppDbContext context) : base(context)
        {
        }
    }
}
