using To_do_It.Models;

namespace To_do_It
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Below are the detals of person:");

            Person person1 = new Person( 1, "Charles", "");

            //Console.WriteLine(person1.PersonId);
            Console.WriteLine(person1.PersonId + " " + person1.FirstName + " " + person1.LastName);

            //person1.PersonId = 1;
            //person1.FirstName = "Charles";
            // person1.LastName = "Ruds";

            //Console.WriteLine("This is details of person1:"+" "+ person1.PersonId + " " + person1.FirstName + " " + person1.LastName);

            // Person person2 = new Person(2, "Maria", "Svensson");

            // person2.PersonId = 2;
            // person2.FirstName = "Maria";
            // person2.LastName = "Svensson";
            //Console.WriteLine("This is details of person2:" + " " + person2.PersonId + " " + person2.FirstName + " " + person2.LastName);

            // Person person3 = new Person(3, "Sayeh", "Ghaderi");

            // person3.PersonId = 3;
            //person3.FirstName = "Sayeh";
            //person3.LastName = "Ghaderi";
            //Console.WriteLine("This is details of person3:" + " " + person3.PersonId + " " + person3.FirstName + " " + person3.LastName);

        }
    }
}