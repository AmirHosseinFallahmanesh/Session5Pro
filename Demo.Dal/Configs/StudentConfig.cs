using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Dal.Configs
{
    class StudentConfig : IEntityTypeConfiguration<StudentModel>
    {
        public void Configure(EntityTypeBuilder<StudentModel> builder)
        {
            builder.HasKey(a => a.SId1);
            //builder.HasKey(a => new { a.SId1, a.SId2 });
            builder.ToTable("Student", "HR");
            builder.Ignore(a => a.GetInformation);
            builder.Property(a => a.Name).HasColumnType("CHAR(20)");
            builder.Property(a => a.Average).IsRequired();
            builder.Property(a => a.BirthDate).HasColumnName("B.D");
           
            //builder.HasIndex(a => a.Name);
            
        }
    }
}
