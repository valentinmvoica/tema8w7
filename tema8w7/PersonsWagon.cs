// See https://aka.ms/new-console-template for more information
class PersonsWagon : Wagon
{
    private int seatsCount;
    public PersonsWagon(int mass, int manufacturingYear, int seatsCount) 
        : base(mass, manufacturingYear)
    {
        this.seatsCount = seatsCount;
    }
    public void OpenDoors()
    {
        Console.WriteLine("Doors opened");
    }
    public void CloseDoors()
    {
        Console.WriteLine("Doors closed");
    }
    public int SeatsCount { get { return this.seatsCount; } }
}
