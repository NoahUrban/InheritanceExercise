using System;
public class Bird : Animal
{
	public Bird()
	{

	}

	public bool Wings { get; set; }
	public bool LayEggs { get; set; }
	public bool Beak { get; set; }
	public string NestMaterials { get; set; }

    public void PrintBird()
    {
        Console.WriteLine($"Has Wings: {Wings}");
        Console.WriteLine($"Lays Eggs: {LayEggs}");
        Console.WriteLine($"Has Beak: {Beak}");
        Console.WriteLine($"Nest Materials: {NestMaterials}");
    }
}


