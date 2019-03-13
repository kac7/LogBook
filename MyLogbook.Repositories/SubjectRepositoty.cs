using Microsoft.EntityFrameworkCore;
using MyLogbook.Abstractions;
using MyLogbook.AppContext;
using MyLogbook.Entities;


namespace MyLogbook.Repositories
{
    public class SubjectRepositoty : DbRepository<Subject>, ISubjectRepository
    {
        public SubjectRepositoty(AppDbContext context) : base(context)
        {
        }
    }
}
