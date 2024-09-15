namespace polymorphism
    //Mainclass
public class Vehicle
{
    public string Name;
    public string Modell;
    public int Yearmodell;

    public virtual void StartMotor()
    {
        Console.WriteLine("Vehicle motor start");
    }

}

public class Bil : Vehicle
{
    public override void StartMotor()
    {
        Console.WriteLine("Bil motor start");
    }
}

public class Motorcykel : Vehicle
{
    public override void StartMotor()
    {
        Console.WriteLine("Motorcykel motor start")
    }
}
