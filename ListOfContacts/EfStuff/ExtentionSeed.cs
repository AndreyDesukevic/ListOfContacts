using ListOfContacts.EfStuff.DbRepositories;
using ListOfContacts.EfStuff.DbModel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace ListOfContacts.EfStuff
{
    // класс добавляет 5 контактов в пустую БД
    public static class ExtentionSeed
    {
        public static IHost Seed(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
                SeedContacts(scope);

            return host;
        }

        private static void SeedContacts(IServiceScope scope)
        {
            var contactsRepository = scope.ServiceProvider.GetService<ContactRepository>();

            if (!contactsRepository.Any())
            {
                var contact0 = new Contact()
                {
                    Name = "Чак Норрис",
                    MobilePhone = "+375(33) 345-29-92",
                    JobTitle = "Netflix",
                    BirthDate = new DateTime(1941,4,18)
                };
                contactsRepository.Save(contact0);

                var contact1 = new Contact()
                {
                    Name = "Дмитрий Козлов",
                    MobilePhone = "+375(29) 242-91-19",
                    JobTitle = "MTZ",
                    BirthDate = new DateTime(1986, 12, 22)
                };
                contactsRepository.Save(contact1);

                var contact2 = new Contact()
                {
                    Name = "Джонни Синс",
                    MobilePhone = "+375(44) 777-73-76",
                    JobTitle = "MAZ",
                    BirthDate = new DateTime(1991, 2, 27)
                };
                contactsRepository.Save(contact2);

                var contact3 = new Contact()
                {
                    Name = "Билл Гейтс",
                    MobilePhone = "+375(29) 344-77-97",
                    JobTitle = "Microsoft",
                    BirthDate = new DateTime(2002, 7, 12)
                };
                contactsRepository.Save(contact3);

                var contact4 = new Contact()
                {
                    Name = "Том Харди",
                    MobilePhone = "+375(33) 333-35-36",
                    JobTitle = "Green",
                    BirthDate = new DateTime(1999, 6, 25)
                };
                contactsRepository.Save(contact4);
            }

        }

    }
}

