using BookMyMovie.Data.Static;
using BookMyMovie.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyMovie.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinemas
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "https://s3.amazonaws.com/cdn.designcrowd.com/blog/40-Famous-Film-Company-Logos/Paramount-Pictures.png",
                            Description="This is the description of the firt Cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "https://brandongaille.com/wp-content/uploads/2013/07/Warner-Bros-Company-Logo1.jpg",
                            Description="This is the description of the Second Cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "https://cdn.dribbble.com/users/2812202/screenshots/17677700/media/edde888cecb5794ad0d99804c2dd418e.png?compress=1&resize=400x300",
                            Description = "This is the description of the Third Cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ6SPpSBizxFkNnB3ShoxyDu0bxLjDyUaW28w&usqp=CAU",
                            Description = "This is the description of the fourth Cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "https://brandongaille.com/wp-content/uploads/2013/07/Universal-Studios-Company-Logo.jpg",
                            Description = "This is the description of the fifth Cinema"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcRAdEFiYJ2ZnbTshnVPem8IDXRCTZNUrnHBj9eMT1iW_ryXQJCF"
                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcSjDaBBcgrMuqhTgKwupxdm4-iWpp2pa0lwl16zoKPGA5b6vppT"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the third actor",
                            ProfilePictureURL = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcRP7xq5bY3HF0PNXhEFnKyGv4yVokvrHot08MunqSobbokkpK6L"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the fourth actor",
                            ProfilePictureURL = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcTOj2HVmgtYgoxxh9hcakq_c_SmfqtFeciy7QJRGA0bfkPeHkAU"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the fifth actor",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQo6-IEFRfuWIHtgpxhoDgqyfhRWyQyUSvLnbJsJJukaiYXzdPu"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the bio of first producer",
                            ProfilePictureURL = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcRC3SM9d1fGhiiUw9nC1dCiXj-uoYoIA8E0sYu8RfkHRB6U7QIZ"
                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the bio of second producer",
                            ProfilePictureURL = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcS3k_BKMJMiQefToj1Ydv3u7sHpL0MnjDgfgyg0oCQoEIWysaIs"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the bio of third producer",
                            ProfilePictureURL = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcSe2hgUycgOBBxLt-YwChlv3mC5O8EkB123R_tv3lvY8SLv2r56"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the bio of fourth producer",
                            ProfilePictureURL = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQL5OqVb9DYe8dzj-J3eAQ5kIFa_2UntTK1hDT_zqC0Yi_1pw88"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the bio of fifth producer",
                            ProfilePictureURL = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcTXDx4TY20tMi-ZF8PY1RALePXAeg41l7TdsENRswkf0xWyZF0Z"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Pathaan",
                            Description = "This is the Pathaan movie description",
                            Price = 39.50,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c3/Pathaan_film_poster.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaID = 3,
                            ProducerID = 3,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaID = 1,
                            ProducerID = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "1920",
                            Description = "This is the 1920 movie description",
                            Price = 39.50,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/e/e7/1920_Evil_Returns_poster.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaID = 4,
                            ProducerID = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Sachin A Billion Dreams",
                            Description = "This is the Sachin A Billion Dreams movie description",
                            Price = 39.50,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/86/Sachin_A_Billion_Dreams_Poster.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaID = 1,
                            ProducerID = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Hanuman: Da' Damdaar",
                            Description = "This is the Hanuman movie description",
                            Price = 39.50,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a9/Hanuman_Da%27_Damdaar_Poster.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaID = 1,
                            ProducerID = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "RRR",
                            Description = "This is the RRR movie description",
                            Price = 39.50,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d7/RRR_Poster.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaID = 1,
                            ProducerID = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorID = 1,
                            MovieID = 1
                        },
                        new Actor_Movie()
                        {
                            ActorID = 3,
                            MovieID = 1
                        },

                         new Actor_Movie()
                        {
                            ActorID = 1,
                            MovieID = 2
                        },
                         new Actor_Movie()
                        {
                            ActorID = 4,
                            MovieID = 2
                        },

                        new Actor_Movie()
                        {
                            ActorID = 1,
                            MovieID = 3
                        },
                        new Actor_Movie()
                        {
                            ActorID = 2,
                            MovieID = 3
                        },
                        new Actor_Movie()
                        {
                            ActorID = 5,
                            MovieID = 3
                        },


                        new Actor_Movie()
                        {
                            ActorID = 2,
                            MovieID = 4
                        },
                        new Actor_Movie()
                        {
                            ActorID = 3,
                            MovieID = 4
                        },
                        new Actor_Movie()
                        {
                            ActorID = 4,
                            MovieID = 4
                        },


                        new Actor_Movie()
                        {
                            ActorID = 2,
                            MovieID = 5
                        },
                        new Actor_Movie()
                        {
                            ActorID = 3,
                            MovieID = 5
                        },
                        new Actor_Movie()
                        {
                            ActorID = 4,
                            MovieID = 5
                        },
                        new Actor_Movie()
                        {
                            ActorID = 5,
                            MovieID = 5
                        },


                        new Actor_Movie()
                        {
                            ActorID = 3,
                            MovieID = 6
                        },
                        new Actor_Movie()
                        {
                            ActorID = 4,
                            MovieID = 6
                        },
                        new Actor_Movie()
                        {
                            ActorID = 5,
                            MovieID = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }

        public static async Task SeedUserAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string appUserEmail = "user@bookmymovie.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if(appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        Fullname = "Admin User",
                        UserName = "admin",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }


            }
        }
    }
}
