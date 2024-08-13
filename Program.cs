using DogDoorApp.Models;

namespace DogDoorAppV1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DogDoor door = new DogDoor();
            door.AddAllowedBark("Woof");
            door.AddAllowedBark("Bark");

            Remote remote = new Remote(door);
            BarkRecognizer recognizer = new BarkRecognizer(door);

            Console.WriteLine("Fido starts barking...");
            recognizer.Recognize("Woof");

            if (door.IsOpen())
            {
                Console.WriteLine("\nFido has gone outside...");
                Console.WriteLine("\nFido's all done...");

                try
                {
                    System.Threading.Thread.Sleep(10000);
                }
                catch (System.Threading.ThreadInterruptedException e) { }

                Console.WriteLine("\nFido starts barking...");
                recognizer.Recognize("Woof");

                if (door.IsOpen())
                {
                    Console.WriteLine("\nFido's back inside...\n\n\n");
                }
            }

            // no bark only meow
            Console.WriteLine("testing with unrecognized bark!!....");
            recognizer.Recognize("Meow");

            if (!door.IsOpen())
            {
                Console.WriteLine("kwvd");
            }
        }
    }
}
