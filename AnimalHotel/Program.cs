using AnimalHotel;
using AnimalHotel.Animals;
using AnimalHotel.Hotel;

var animalNames = new string[] { "Bella", "Charlie", "Luna", "Max", "Milo", "Daisy", "Oscar", "Cleo" };
var ownerNames = new string[] { "James", "John", "Mary", "Hank", "Walter", "Jesse", "Jimmy", "Mike" };
var phoneNumbers = new string[] { "9237674622", "9327564223", "6475834498", "7654392784" };

var genericHotel = new GenericHotel<IAnimal>();
var kyivHotel = new KyivHotel();
var romashkaHotel = new RomashkaHotel();

for (var i = 0; i < 4; i++)
{
    var genHotelOwner = new Owner(ownerNames[Random.Shared.Next(8)], (byte)Random.Shared.Next(20, 81), phoneNumbers[Random.Shared.Next(4)]);
    genericHotel.AddAnimal(AnimalFactory.CreateCat(animalNames[Random.Shared.Next(8)], (byte)Random.Shared.Next(21), (AnimalColor)Random.Shared.Next(4), genHotelOwner));
    genericHotel.AddAnimal(AnimalFactory.CreateDog(animalNames[Random.Shared.Next(8)], (byte)Random.Shared.Next(21), (AnimalColor)Random.Shared.Next(4), genHotelOwner));

    var kyivHotelOwner = new Owner(ownerNames[Random.Shared.Next(8)], (byte)Random.Shared.Next(20, 81), phoneNumbers[Random.Shared.Next(4)]);
    kyivHotel.AddAnimal(AnimalFactory.CreateCat(animalNames[Random.Shared.Next(8)], (byte)Random.Shared.Next(21), (AnimalColor)Random.Shared.Next(4), kyivHotelOwner));
    kyivHotel.AddAnimal(AnimalFactory.CreateDog(animalNames[Random.Shared.Next(8)], (byte)Random.Shared.Next(21), (AnimalColor)Random.Shared.Next(4), kyivHotelOwner));

    var romHotelOwner = new Owner(ownerNames[Random.Shared.Next(8)], (byte)Random.Shared.Next(20, 81), phoneNumbers[Random.Shared.Next(4)]);
    romashkaHotel.AddAnimal(AnimalFactory.CreateCat(animalNames[Random.Shared.Next(8)], (byte)Random.Shared.Next(21), (AnimalColor)Random.Shared.Next(4), romHotelOwner));
    romashkaHotel.AddAnimal(AnimalFactory.CreateDog(animalNames[Random.Shared.Next(8)], (byte)Random.Shared.Next(21), (AnimalColor)Random.Shared.Next(4), romHotelOwner));
}

genericHotel.SortAnimals();
genericHotel.PrintAnimals();

kyivHotel.SortAnimals();
kyivHotel.PrintAnimals();

romashkaHotel.SortAnimals();
romashkaHotel.PrintAnimals();

Console.WriteLine("********************");

string ownerName;
while (true)
{
    Console.Write("Enter owner name: ");
    ownerName = Console.ReadLine();
    if (ownerName != null)
        break;
}

Console.WriteLine("Generic Hotel:");
Console.WriteLine(string.Join(", ", genericHotel.FindAnimalsByOwnerName(ownerName)));

Console.WriteLine("Kyiv Hotel:");
Console.WriteLine(string.Join(", ", kyivHotel.FindAnimalsByOwnerName(ownerName)));

Console.WriteLine("Romashka Hotel:");
Console.WriteLine(string.Join(", ", romashkaHotel.FindAnimalsByOwnerName(ownerName)));
