namespace Arv_princip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird myBird = new Bird();
            myBird.animalname = "Isak";
            myBird.featherColor = "gröna";
            myBird.displayInfo();

            Fish myFish = new Fish();
            myFish.eyeColor = "Gul";
            myFish.displayInfo();
        }
    }
    public class Animal
    {
        public string animalname;

        public void displayInfo()
        {
            Console.WriteLine("Test");
        }
    }
    public class Bird : Animal
    {
        public string featherColor;

        public new void displayInfo()
        {
            Console.WriteLine($"Fågeln {animalname} flyger med sina {featherColor} vingar och springer inte!");
        }

    }

    public class Fish : Animal
    {
        public string eyeColor;
        public new void displayInfo()
        {
            Console.WriteLine($"Fiskens ögon är {eyeColor}a");
        }
            
    }
        

}


