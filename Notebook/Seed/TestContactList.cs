using Notebook.Models;

namespace Notebook.Seed
{
    public static class TestContactList
    {
        public static List<Contact> Contacts { get; set; } = new List<Contact>()
        {   new Contact()
            {
                Id = "1",
                Name= "Foo",
                Surname= "Bar",
                Patronymic = "Boo",
                PhoneNumber = "1234567890",
                Address = "Poo",
                Description = "What?"
            },
            new Contact()
            {
                Id = "2",
                Name= "Paa",
                Surname= "Ner",
                Patronymic = "Ror",
                PhoneNumber = "0987654321",
                Address = "Iop",
                Description = "Who?"
            },
            new Contact()
            {
                Id = "3",
                Name= "Opp",
                Surname= "Ruu",
                Patronymic = "Err",
                PhoneNumber = "88888888888",
                Address = "Ndf",
                Description = "When?"
            }
        };
        
    }
}
