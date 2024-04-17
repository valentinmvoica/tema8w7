// See https://aka.ms/new-console-template for more information
class PersonsWagonFirstClass : PersonsWagon
{
    public PersonsWagonFirstClass(int mass, int manufacturingYear, int seatsCount):
        base(mass, manufacturingYear, seatsCount)
    {
            
    }
    public void StartAC()
    {
        Console.WriteLine("Ac started");
    }
    public void StopAC()
    {
        Console.WriteLine("AC stopped");
    }
}