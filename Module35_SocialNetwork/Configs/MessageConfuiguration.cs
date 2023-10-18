using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Module35_SocialNetwork.Models.Users;

namespace Module35_SocialNetwork.Configs
{
    public class MessageConfuiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.ToTable("Mesages").HasKey(p => p.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
