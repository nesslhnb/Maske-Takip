using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "esra";
            person1.LastName = "arslan";
            person1.DateOfBirthYear = 2002;
            person1.NationalIdentity = 12345678987;


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
           
        }
    }
   
}