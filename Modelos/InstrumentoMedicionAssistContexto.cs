using System.Data.Entity;


namespace Modelos
{
    public class InstrumentoMedicionAssistContexto:DbContext 
    {
        public InstrumentoMedicionAssistContexto() : base("InstrumentoMedicionAssist")
        {

        }
    public DbSet<Pacientes> Pacientes { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoIdentificacion>()
              .HasMany(e => e.Pacientes)
              .WithRequired(e => e.IdTipoIdentificacion)
              .HasForeignKey(e => e.TipoIdentificacion)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<EstadoCivil>()
              .HasMany(e => e.Pacientes)
              .WithRequired(e => e.IdEstadoCivil)
              .HasForeignKey(e => e.EstadoCivil)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<NivelEscolaridad>()
              .HasMany(e => e.Pacientes)
              .WithRequired(e => e.IdNivelEscolaridad)
              .HasForeignKey(e => e.NivelEscolaridad)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<Genero>()
              .HasMany(e => e.Pacientes)
              .WithRequired(e => e.IdGenero)
              .HasForeignKey(e => e.Genero)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<Regimen>()
              .HasMany(e => e.Pacientes)
              .WithRequired(e => e.IdRegimen)
              .HasForeignKey(e => e.Regimen)
              .WillCascadeOnDelete(false);
        }
    }
}
