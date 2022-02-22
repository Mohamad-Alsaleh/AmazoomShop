using AmazoomShop.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazoomShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Bücher", Url = "books", Icon = "book" },
                new Category { Id = 2, Name = "Video Games", Url = "video-games", Icon = "aperture" },
                new Category { Id = 3, Name = "Electronics", Url = "electronics", Icon = "camera-slr" }
                );

            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     CategoryId = 1,
                     Title = "The Hitchhiker's Guide to the Galaxy",
                     Description = "The Hitchhiker's Guide to the Galaxy (sometimes referred to as HG2G, HHGTTG, H2G2, or tHGttG) is a comedy science fiction series created by Douglas Adams.",
                     Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                     DateCreated = new DateTime(2021, 1, 1),
                     Price = 9.99m,
                     OriginalPrice = 19.99m,
                     Beschreibung = "Per Anhalter durch die Galaxis ist eine Romanreihe, die Douglas Adams aus dem Radiohörspiel Per Anhalter ins All entwickelt hat " +
                 "und die er in mehreren Bänden fortsetzte,bis 1992 „Teil 5 der vierbändigen Trilogie“ erschien. Die einzelnen Teile sind:"
                 },
               new Product
               {
                   Id = 2,
                   CategoryId = 1,
                   Title = "Ready Player One",
                   Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune.",
                   Image = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                   DateCreated = new DateTime(2021, 1, 1),
                   Price = 20.99m,
                   OriginalPrice = 21.95m,
                   Beschreibung = "Ready Player One ist der Titel eines dystopischen Science-Fiction-Romans von Ernest Cline aus dem Jahr 2011." +
                 "Der Debütroman landete sofort auf verschiedenen Bestsellerlisten[1] und brachte für den Autor die literarische Anerkennung. Eine deutsche Übersetzung erschien 2012 von Hannes und Sara Riffel"
               },
               new Product
               {
                   Id = 3,
                   CategoryId = 1,
                   Title = "Nineteen Eighty-Four",
                   Description = "Nineteen Eighty-Four: A Novel, often published as 1984, is a dystopian social science fiction novel by English novelist George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime.",
                   Image = "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg",
                   DateCreated = new DateTime(2021, 1, 1),
                   Price = 9.99m,
                   OriginalPrice = 19.99m,
                   Beschreibung = "1984 (Originaltitel: Nineteen Eighty-Four, deutscher Alternativtitel: Neunzehnhundertvierundachtzig), geschrieben von 1946 bis 1948[1] und erschienen im Juni 1949, ist ein dystopischer Roman von George Orwell (eigentlich Eric Arthur Blair), " +
                 "in dem ein totalitärer Überwachungsstaat im Jahr 1984 dargestellt wird"
               },
               new Product
               {
                   Id = 4,
                   CategoryId = 2,
                   Title = "Pentax Spotmatic",
                   Description = "The Pentax Spotmatic refers to a family of 35mm single-lens reflex cameras manufactured by the Asahi Optical Co. Ltd., later known as Pentax Corporation, between 1964 and 1976.",
                   Image = "https://upload.wikimedia.org/wikipedia/commons/e/e9/Honeywell-Pentax-Spotmatic.jpg",
                   DateCreated = new DateTime(2021, 1, 1),
                   Price = 255.99m,
                   OriginalPrice = 300.99m,
                   Beschreibung = "Die 1964 erschienene Asahi Pentax Spotmatic war ein Meilenstein der Kleinbildfotografie, weil sie die erste wirklich erfolgreiche SLR mit TTL Belichtungsmessung war. " +
                 "Allerdings gab es keine Offenblendenmessung"
               },
               new Product
               {
                   Id = 5,
                   CategoryId = 2,
                   Title = "Xbox",
                   Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                   Image = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                   DateCreated = new DateTime(2021, 1, 1),
                   Price = 250.00m,
                   OriginalPrice = 275.99m,
                   Beschreibung = "Die Xbox ist eine von Microsoft entwickelte Spielkonsole, die größtenteils auf leicht modifizierten PC-Komponenten basiert. Der Erfolg der Spielkonsole sorgte für die Etablierung der gleichnamigen Marke Xbox. Die Xbox wurde zuerst am 15. November 2001 in den USA,[2] dann am 22. Februar 2002 in Japan und " +
                 "am 14. März 2002 in Europa veröffentlicht."
               },
               new Product
               {
                   Id = 6,
                   CategoryId = 2,
                   Title = "Super Nintendo Entertainment System",
                   Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                   Image = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                   DateCreated = new DateTime(2021, 1, 1),
                   Price = 199.80m,
                   OriginalPrice = 245.99m,
                   Beschreibung = "ist eine stationäre 16-Bit-Spielkonsole des japanischen Unternehmens Nintendo. Es ist die zweite weltweit veröffentlichte stationäre Spielkonsole des Unternehmens und sein Controller, der SNES-Controller, " +
                 "führte die Schultertasten ein, die fortan zum Standard aller nachfolgend erschienenen Gamepads wurden"

               },
               new Product
               {
                   Id = 7,
                   CategoryId = 3,
                   Title = "Half-Life 2",
                   Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                   Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                   DateCreated = new DateTime(2021, 1, 1),
                    Price = 9.99m,
                   OriginalPrice = 19.99m
               },
               new Product
               {
                   Id = 8,
                   CategoryId = 3,
                   Title = "Diablo II",
                   Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                   Image = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                   DateCreated = new DateTime(2021, 1, 1),
                    Price = 25.44m,
                   OriginalPrice = 50.79m,
               },
               new Product
               {
                   Id = 9,
                   CategoryId = 3,
                   Title = "Day of the Tentacle",
                   Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                   Image = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                   DateCreated = new DateTime(2021, 1, 1),
                   Price = 9.99m,
                   
               }
               
               );
        }


    }
}
