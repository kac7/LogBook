using Microsoft.EntityFrameworkCore;
using MyLogbook.Abstractions;
using MyLogbook.AppContext;
using MyLogbook.Entities;


namespace MyLogbook.Repositories
{
    public class TeacherRepositoty : DbRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepositoty(AppDbContext context) : base(context)
        {
        }
    }
}
