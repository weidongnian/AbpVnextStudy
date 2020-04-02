using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users;

namespace SZYJ.Stroke.EntityFrameworkCore
{
    public static class StrokeDbContextModelCreatingExtensions
    {
        public static void ConfigureStroke(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(StrokeConsts.DbTablePrefix + "YourEntities", StrokeConsts.DbSchema);

            //    //...
            //});

            builder.Entity<Book>(b =>
            {
                b.ToTable(StrokeConsts.DbTablePrefix + "Books", StrokeConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            });
        }

        public static void ConfigureCustomUserProperties<TUser>(this EntityTypeBuilder<TUser> b)
            where TUser: class, IUser
        {
            //b.Property<string>(nameof(AppUser.MyProperty))...
        }
    }
}