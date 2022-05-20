using Microsoft.EntityFrameworkCore;
using ShowReel.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowReel.Data
{
     internal class ShowReelDbContext : DbContext
    {
        protected DbSet<Reel> Reels { get; set; }

        protected DbSet<Session> Sessions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ShowReelDb.db;");
            optionsBuilder.EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reel>().ToTable("Reels")
                .HasKey(e => e.Id);

            modelBuilder.Entity<Reel>()
                .Property(e => e.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Session>().ToTable("Sessions")
                .HasKey(e => e.Id);
            modelBuilder.Entity<Session>().Property(e => e.Id).ValueGeneratedOnAdd();

            SeedData(modelBuilder);
        }

        protected void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reel>().HasData(new Reel
            (
              id:1,
              name: "Bud Light",
              description: "A factory is working on the new Bud Light Platinum.",
              videoStandard: "PAL",
              videoDefinition: "SD",
              duration: "00:00:30:12"
            ),
            new Reel
            (
              id: 2,
              name: "M&M's",
              description: "At a party, a brown shelled M&M is mistaken for being naked. As a result, the red M&M tears off its skin and dances to \"Sexy and I Know It\" by LMFAO.",
              videoStandard: "NTSC",
              videoDefinition: "SD",
              duration: "00:00:15:27"
            ),
            new Reel
            (
              id: 3,
              name: "Audi",
              description: "A group of vampires are having a party in the woods. The vampire in charge of drinks (blood types) arrives in his Audi. The bright lights of the car kills all of the vampires, with him wondering where everyone went afterwards.",
              videoStandard: "PAL",
              videoDefinition: "SD",
              duration: "00:01:30:00"
            ),
            new Reel
            (
              id: 4,
              name: "Chrysler",
              description: "Clint Eastwood recounts how the automotive industry survived the Great Recession.",
              videoStandard: "PAL",
              videoDefinition: "SD",
              duration: "00:00:10:14"
            ),
            new Reel
            (
              id: 5,
              name: "Fiat",
              description: "A man walks through a street to discover a beautiful woman (Catrinel Menghia) standing on a parking space, who proceeds to approach and seduce him, when successfully doing so he then discovers he was about to kiss a Fiat 500 Abarth.",
              videoStandard: "NTSC",
              videoDefinition: "SD",
              duration: "00:00:18:11"
            ),
            new Reel
            (
              id: 6,
              name: "Pepsi",
              description: "People in the Middles Ages try to entertain their king (Elton John) for a Pepsi. While the first person fails, a mysterious person (Season 1 X Factor winner Melanie Amaro) wins the Pepsi by singing Aretha Franklin's \"Respect\".\" After she wins, she overthrows the king and gives Pepsi to all the town.",
              videoStandard: "NTSC",
              videoDefinition: "SD",
              duration: "00:00:20:00"
            ),
            new Reel
            (
              id: 7,
              name: "Best Buy",
              description: "An ad featuring the creators of the camera phone, Siri, and the first text message. The creators of Words with Friends also appear parodying the incident involving Alec Baldwin playing the game on an airplane.",
              videoStandard: "PAL",
              videoDefinition: "HD",
              duration: "00:00:10:05"
            ),
            new Reel
            (
              id: 8,
              name: "Captain America The First Avenger",
              description: "Video Promo",
              videoStandard: "PAL",
              videoDefinition: "HD",
              duration: "00:00:20:10"
            ),
            new Reel
            (
              id: 9,
              name: "Volkswagen \"Black Beetle\"",
              description: "A computer generated black beetle runs fast, as it is referencing the new,Volkswagen model",
              videoStandard: "NTSC",
              videoDefinition: "HD",
              duration: "00:00:30:00"
            ));
        }

    }
}
