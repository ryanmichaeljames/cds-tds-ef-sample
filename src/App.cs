using System;
using System.Linq;

namespace Sample
{
    public class App
    {
        private readonly CdsContext _cdsContext;

        public App(CdsContext cdsContext)
        {
            _cdsContext = cdsContext;
        }

        public void Run()
        {
            var contacts = _cdsContext.Contacts.ToList();

            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.FullName} ({contact.Id})");
            }

            Console.ReadKey();
        }
    }
}
