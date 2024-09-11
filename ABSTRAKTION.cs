namespace Abstraktion
{
   public abstract class Animal
    {
        public abstract void AnimalSound();
    }
    public class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Wof");
        }
    }




}