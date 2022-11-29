namespace Branshes_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var alien = new Alien() { Name = "Göran", Race = "Grey" };
            var spaceship = new Spaceship() { Name = "Millenium Falcon", Description = "Super fast" };
            var spaceship2 = new Spaceship() { Name = "X-wing", Description = "Fighter" };
        }
    }
}