using Homework4;

var customList = new CustomList<User>()
{
    new User(890753, "Vadym", new DateTime(2004, 7, 2)),
    new User(270532, "Oleksii", new DateTime(2002, 6, 27)),
    new User(026549, "Walter", new DateTime(1965, 2, 15))
};

Console.WriteLine($"Capacity: {customList.Capacity}, Count: {customList.Count}");

customList.Add(new User(368284, "Mike", new DateTime(1954, 4, 21)));
customList.Add(new User(672515, "Jimmy", new DateTime(1967, 5, 30)));

//random linq method
Console.WriteLine(customList.FirstOrDefault(x => x.Id == 672515)?.Name);
Console.WriteLine();

//filtration
Console.WriteLine(string.Join(", ", customList.Where(x => (DateTime.Now - x.Birthday).TotalDays / 365 > 40).Select(x => x.Name)));
Console.WriteLine();

//sorting
Console.WriteLine(string.Join(", ", customList.OrderBy(x => x.Id).Select(x => x.Name)));
