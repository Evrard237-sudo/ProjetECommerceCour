using E_Commerce.Models;

namespace E_Commerce.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                // ajouter cinema
                if (!context.Cinema.Any())
                {
                    context.Cinema.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Logo ="https://static.pix-geeks.com/2017/05/titanic-4398-78859.jpg",
                            Name = "Titanic",
                            Description = "Le RMS Titanic est un paquebot transatlantique York."

                        },
                        new Cinema()
                        {
                            Logo ="https://static.pix-geeks.com/2017/05/titanic-4398-78859.jpg",
                            Name = "Titanic",
                            Description = "Le RMS Titanic est un paquebot transatlantique York."

                        },
                        new Cinema()
                        {
                            Logo ="https://static.pix-geeks.com/2017/05/titanic-4398-78859.jpg",
                            Name = "Titanic",
                            Description = "Le RMS Titanic est un paquebot transatlantique York."

                        }
                    });
                    context.SaveChanges();
                }


                //ajouter actor
                if (!context.Actor.Any())
                {
                    context.Actor.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            ProfilPictureUrl = "https://th.bing.com/th/id/OIP.0L5-i3T3Vr8J4e-JHlVR4gHaLh?pid=ImgDet&rs=1",
                            FullName = "Leonardo Dicaprio",
                            Bio = "Acteur principale de Titanic"

                        },
                        new Actor()
                        {
                             ProfilPictureUrl = "https://th.bing.com/th/id/OIP.0L5-i3T3Vr8J4e-JHlVR4gHaLh?pid=ImgDet&rs=1",
                            FullName = "Leonardo Dicaprio",
                            Bio = "Acteur principale de Titanic"
                        },
                        new Actor()
                        {
                            ProfilPictureUrl = "https://th.bing.com/th/id/OIP.0L5-i3T3Vr8J4e-JHlVR4gHaLh?pid=ImgDet&rs=1",
                            FullName = "Leonardo Dicaprio",
                            Bio = "Acteur principale de Titanic"
                        }
                    });
                    context.SaveChanges();
                }
            }   
        }
    }
}
