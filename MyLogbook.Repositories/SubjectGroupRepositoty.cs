using Microsoft.EntityFrameworkCore;
using MyLogbook.Abstractions;
using MyLogbook.AppContext;
using MyLogbook.Entities;


namespace MyLogbook.Repositories
{
    public class SubjectGroupRepositoty : DbRepository<SubjectGoup>, ISubjectGroupRepository
    {
        public SubjectGroupRepositoty(AppDbContext context) : base(context)
        {
        }
    }
}
