namespace Polymorphism1
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Veicle veicle = new Veicle();
            veicle.StartMotor();

            Bil bil = new Bil();
            bil.StartMotor();

            Motorcykel motorcykel = new Motorcykel();
            motorcykel.StartMotor();
        }


    }

}
