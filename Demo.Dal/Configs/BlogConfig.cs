using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Demo.Dal.Configs
{
    class BlogConfig : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property<DateTime>("CreateTime");
            builder.Property<DateTime>("LastUpdateTime");
            builder.HasMany(a => a.Posts).WithOne();
        }
    }
}
