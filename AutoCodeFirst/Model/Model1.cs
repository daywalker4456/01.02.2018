namespace AutoCodeFirst.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<TrackEvaluation> TrackEvaluation { get; set; }
        public virtual DbSet<TrackEvaluationComment> TrackEvaluationComment { get; set; }
        public virtual DbSet<TrackEvaluationHistory> TrackEvaluationHistory { get; set; }
        public virtual DbSet<TrackEvaluationPart> TrackEvaluationPart { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
