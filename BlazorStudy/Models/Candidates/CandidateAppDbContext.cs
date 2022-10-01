using Microsoft.EntityFrameworkCore;

namespace BlazorStudy.Models.Candidates
{
    public class CandidateAppDbContext : DbContext
    {
        public CandidateAppDbContext(DbContextOptions<CandidateAppDbContext> options)
            : base(options) { }
    }
}
