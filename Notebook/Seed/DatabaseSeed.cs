using Notebook.Data;
using Notebook.Models;

namespace Notebook.Seed
{
    public static class DatabaseSeed
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                context.Contacts.AddRange(new List<Contact>()
                {
                new Contact()
                {
                    Id= Guid.NewGuid().ToString(),
                    Name= "Alex",
                    Surname= "Bond",
                    Patronymic = "A",
                    PhoneNumber = "1234567890",
                    Address = "Test Street 123",
                    Description = "User Description 1"
                },
                new Contact()
                {
                    Id= Guid.NewGuid().ToString(),
                    Name= "John",
                    Surname= "Smith",
                    Patronymic = "B",
                    PhoneNumber = "0987654321",
                    Address = "Test Street 999",
                    Description = "User Description 2"
                },
                new Contact()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name= "Bill",
                    Surname= "Anderson",
                    Patronymic = "C",
                    PhoneNumber = "8888888888",
                    Address = "Test Street 40004",
                    Description = "User Description 3"
                },
                new Contact()
                {   
                    Id = Guid.NewGuid().ToString(),
                    Name= "Maxwell",
                    Surname= "Peterson",
                    Patronymic = "D",
                    PhoneNumber = "7775588993",
                    Address = "Test Street 666",
                    Description = "User Description 4"
                },
                new Contact()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name= "Emmy",
                    Surname= "Jefferson",
                    Patronymic = "E",
                    PhoneNumber = "0000000000",
                    Address = "Test Street 2255",
                    Description = "User Description 5"
                },
                new Contact()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name= "Peter",
                    Surname= "Peterson",
                    Patronymic = "F",
                    PhoneNumber = "1289348765",
                    Address = "Test Street 0001",
                    Description = "User Description 6"
                }
                });
                context.SaveChanges();
            }
        }
    }
}
