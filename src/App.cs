using System;
using System.Linq;

namespace CdsEfSampleApp
{
    public interface IApp
    {
        void Run();
    }

    public class App : IApp
    {
        private readonly CdsContext _cdsContext;

        public App(CdsContext cdsContext)
        {
            _cdsContext = cdsContext;
        }

        public void Run()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("contactid                            | firstname  | lastname  ");
            Console.WriteLine("--------------------------------------------------------------");

            var contacts = _cdsContext.Contacts.ToList();

            contacts.ForEach(contact => {
                Console.WriteLine($"{contact.Id, -36} | {contact.FirstName, -10} | {contact.LastName, -10}");
            });

            Console.WriteLine("--------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
