Console.WriteLine("Name your cat:");
string myCatName = Console.ReadLine();
Cat myCat = new Cat(myCatName);

Console.WriteLine("Name your neighbours cat:");
string neighboursCatName = Console.ReadLine();
Cat neighboursCat = new Cat(neighboursCatName);


Console.WriteLine($"My cats name is {myCat.Name}");
Console.WriteLine($"My neighbours cats name is {neighboursCat.Name}");

myCat.Rename("Bad Boy");

while (myCat.LevelOfHapiness != 5)
{
    myCat.Purring();
}

myCat.MemeCat();

//Console.WriteLine($"Level of happiness: {myCat.LevelOfHapiness}");

//myCat.Purring();
//Console.WriteLine($"Level of happiness: {myCat.LevelOfHapiness}");


class Cat
{
    private string _name; //field
    private int _levelOfHapiness;

    //constructor
    public Cat(string name) //name - lets the user name the cat
    {
        _name = name;
        _levelOfHapiness = 0;
    }

    //getter
    public string Name
    {
        get { return _name; }
    }

    public int LevelOfHapiness
    {
        get { return _levelOfHapiness; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The cat has been renamed to: {newName}");
    }

    public void Purring()
    {
        Console.WriteLine("Purr-purr");
        _levelOfHapiness++;
    }

    public void MemeCat()
    {
        Console.WriteLine("Happy-happy-happy");
    }

}