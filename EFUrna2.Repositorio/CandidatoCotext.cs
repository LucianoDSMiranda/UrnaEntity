using EFUrna2.Dominio;
using Microsoft.EntityFrameworkCore;

namespace EFUrna2.Repositorio
{
    public class CandidatoContext : DbContext
    {

        public CandidatoContext(DbContextOptions<CandidatoContext> options) : base(options) { }

        
        public DbSet<Candidato> Candidatos { get; set; }
    }
}
