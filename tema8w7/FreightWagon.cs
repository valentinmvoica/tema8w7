// See https://aka.ms/new-console-template for more information
class FreightWagon : Wagon
{
    public FreightWagon(int mass, int manufacturingYear, int capacity, CargoType cargoType) :
        base(mass, manufacturingYear)
    {
        this.Capacity = capacity;
        this.CargoType = cargoType;
    }
    public int Capacity{ get; private set; }
    public CargoType CargoType { get; private set; }
}

