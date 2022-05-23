using Microsoft.EntityFrameworkCore;
using ShowReel.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowReel.Data
{
    public class ShowReelDbContext : DbContext
    {
        public ShowReelDbContext(DbContextOptions<ShowReelDbContext> options) : base(options)
        {
        }

        protected DbSet<Reel> Reels { get; set; }

        protected DbSet<VideoQuality> VideoQualities { get; set; }

        
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


            modelBuilder.Entity<VideoQuality>().ToTable("VideoQualities")
                .HasKey(e => e.Id);

            modelBuilder.Entity<VideoQuality>()
                .Property(e => e.Id)
                .ValueGeneratedOnAdd();

            SeedData(modelBuilder);
        }

        protected void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VideoQuality>().HasData(
                    new VideoQuality
                    (
                       id: 1,
                       standard: "PAL",
                       definition: "SD"
                    ),
                    new VideoQuality
                    (
                        id: 2,
                        standard: "NTSC",
                        definition: "SD"
                    ),
                    new VideoQuality
                    (
                        id: 3,
                        standard: "PAL",
                        definition: "HD"
                    ),
                    new VideoQuality
                    (
                        id: 4,
                        standard: "NTSC",
                        definition: "HD"
                    )
                );

            modelBuilder.Entity<Reel>().HasData(
                    new Reel
                    (
                        id: 1,
                        name: "Bud Light",
                        description: "A factory is working on the new Bud Light Platinum.",
                        duration: "00:00:30:12",
                        videoQualityId: 1
                    ),
                    new Reel
                    (
                        id: 2,
                        name: "Audi",
                        description: "A group of vampires are having a party in the woods. The vampire in charge of drinks (blood types) arrives in his Audi. The bright lights of the car kills all of the vampires, with him wondering where everyone went afterwards.",
                        duration: "00:01:30:00",
                        videoQualityId: 1
                    ),
                    new Reel
                    (
                        id: 3,
                        name: "Chrysler",
                        description: "Clint Eastwood recounts how the automotive industry survived the Great Recession.",
                        duration: "00:00:10:14",
                        videoQualityId: 1
                    ),

                    new Reel
                    (
                        id: 4,
                        name: "M&M's",
                        description: "At a party, a brown shelled M&M is mistaken for being naked. As a result, the red M&M tears off its skin and dances to \"Sexy and I Know It\" by LMFAO.",
                        duration: "00:00:15:27",
                        videoQualityId: 2
                    ),
                    new Reel
                    (
                        id: 5,
                        name: "Fiat",
                        description: "A man walks through a street to discover a beautiful woman (Catrinel Menghia) standing on a parking space, who proceeds to approach and seduce him, when successfully doing so he then discovers he was about to kiss a Fiat 500 Abarth.",
                        duration: "00:00:18:11",
                        videoQualityId: 2
                    ),
                    new Reel
                    (
                        id: 6,
                        name: "Pepsi",
                        description: "People in the Middles Ages try to entertain their king (Elton John) for a Pepsi. While the first person fails, a mysterious person (Season 1 X Factor winner Melanie Amaro) wins the Pepsi by singing Aretha Franklin's \"Respect\".\" After she wins, she overthrows the king and gives Pepsi to all the town.",
                        duration: "00:00:20:00",
                        videoQualityId: 2
                    ),

                    new Reel
                    (
                        id: 7,
                        name: "Best Buy",
                        description: "An ad featuring the creators of the camera phone, Siri, and the first text message. The creators of Words with Friends also appear parodying the incident involving Alec Baldwin playing the game on an airplane.",
                        duration: "00:00:10:05",
                        videoQualityId: 3
                    ),
                    new Reel
                    (
                        id: 8,
                        name: "Captain America The First Avenger",
                        description: "Video Promo",
                        duration: "00:00:20:10",
                        videoQualityId: 3
                    ),

                    new Reel
                    (
                        id: 9,
                        name: "Volkswagen \"Black Beetle\"",
                        description: "A computer generated black beetle runs fast, as it is referencing the new,Volkswagen model",
                        duration: "00:00:30:00",
                        videoQualityId: 4
                    )
                );

        }
    }
}