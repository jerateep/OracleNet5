using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Oracle.DB.Models.Oracle;

namespace Oracle.DB.Data
{
    public partial class OracleContext : DbContext
    {
        public OracleContext()
        {
        }

        public OracleContext(DbContextOptions<OracleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TBL_PERSON> TBL_PERSON { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseOracle("User Id=SYSTEM;Password=8M6uaPUPpPQ=1;Data Source=localhost:1521/jrtp;Connection Timeout=600;min pool size=0;connection lifetime=18000;PERSIST SECURITY INFO=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBL_PERSON>(entity =>
            {
                entity.HasKey(e => e.PERSONID)
                    .HasName("SYS_C009995");

                entity.Property(e => e.PERSONID).HasColumnType("NUMBER(38)");

                entity.Property(e => e.AGE).HasColumnType("NUMBER(38)");

                entity.Property(e => e.FIRSTNAME)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LASTNAME)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.HasSequence("ISEQ$$_91999");

            modelBuilder.HasSequence("LOGMNR_DIDS$");

            modelBuilder.HasSequence("LOGMNR_EVOLVE_SEQ$");

            modelBuilder.HasSequence("LOGMNR_SEQ$");

            modelBuilder.HasSequence("LOGMNR_UIDS$");

            modelBuilder.HasSequence("MVIEW$_ADVSEQ_GENERIC");

            modelBuilder.HasSequence("MVIEW$_ADVSEQ_ID");

            modelBuilder.HasSequence("REPCAT$_EXCEPTIONS_S");

            modelBuilder.HasSequence("REPCAT$_FLAVOR_NAME_S");

            modelBuilder.HasSequence("REPCAT$_FLAVORS_S");

            modelBuilder.HasSequence("REPCAT$_REFRESH_TEMPLATES_S");

            modelBuilder.HasSequence("REPCAT$_REPPROP_KEY");

            modelBuilder.HasSequence("REPCAT$_RUNTIME_PARMS_S");

            modelBuilder.HasSequence("REPCAT$_TEMP_OUTPUT_S");

            modelBuilder.HasSequence("REPCAT$_TEMPLATE_OBJECTS_S");

            modelBuilder.HasSequence("REPCAT$_TEMPLATE_PARMS_S");

            modelBuilder.HasSequence("REPCAT$_TEMPLATE_REFGROUPS_S");

            modelBuilder.HasSequence("REPCAT$_TEMPLATE_SITES_S");

            modelBuilder.HasSequence("REPCAT$_USER_AUTHORIZATIONS_S");

            modelBuilder.HasSequence("REPCAT$_USER_PARM_VALUES_S");

            modelBuilder.HasSequence("REPCAT_LOG_SEQUENCE");

            modelBuilder.HasSequence("ROLLING_EVENT_SEQ$");

            modelBuilder.HasSequence("TEMPLATE$_TARGETS_S");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
