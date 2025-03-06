public class Breed
{
    public void Breed1()
    {
        Console.WriteLine("I am a Great Dane.");
    }

    public virtual void Breed2()
    {
        Console.WriteLine("I am a Beagle.");
    }
}
public class Dog : Breed
{
    public void Dog1()
    {
        Console.WriteLine("Hi! I am Scooby-Doo.");
    }

    public void Dog2()
    {
        Console.WriteLine("Hi! I am Scrappy-Doo.");
    }

    public void Dog3()
    {
        Console.WriteLine("Hi! I am Snoopy.");
    }

    public override void Breed2()
    {
        Console.WriteLine("I am a white Beagle.");
    }

}

/*Application

Dog Scooby = new Dog();
Scooby.Dog1();
Scooby.Breed1();
Console.WriteLine("");

Dog Scrappy = new Dog();
Scooby.Dog2();
Scooby.Breed1();
Console.WriteLine("");

Dog Snoopy = new Dog();
Scooby.Dog3();
Scooby.Breed2();

*/