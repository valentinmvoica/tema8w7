// See https://aka.ms/new-console-template for more information
using tema8w7;


var locomotive = new Locomotive();
var myTrain = new Train("accelerat 1900toamna", locomotive);

Wagon personsWagon = new PersonsWagon(1200, 1974, 150);
Wagon personsWagonFirstClass = new PersonsWagonFirstClass(1200, 1975, 150);

myTrain.AddWagon(personsWagon);

myTrain.AddWagon(personsWagonFirstClass);
myTrain.AddWagon(new PersonsWagon(1300, 1990, 120 ));
myTrain.AddWagon(new PersonsWagon(1300, 1990, 120));
myTrain.AddWagon(new FreightWagon(2000,2000,500,CargoType.Grain));
myTrain.AddWagon(new FreightWagon(2000, 2000, 30, CargoType.Coal));
myTrain.AddWagon(new FreightWagon(2000, 2000, 240, CargoType.Steel));
myTrain.AddWagon(new FreightWagon(2000, 2000, 300, CargoType.Grain));

myTrain.LeaveStation();
myTrain.ArriveAtStation();


Console.WriteLine($"trenul are {myTrain.SeatsCount} locuri");
var stats = myTrain.GetCargoSummary();

foreach(var stat in stats)
{
    Console.WriteLine($"tipul marfii: {stat.CargoType} capacitate: {stat.Capacity}t");
}
