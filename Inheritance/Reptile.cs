using System;
public class Reptile : Animal
{
	public Reptile()
	{

	}

	public bool ColdBlooded { get; set; }
	public bool NoLegs { get; set; }
	public bool Venemous { get; set; }
	public bool scales { get; set; }

    public void PrintReptile()
    {
		Console.WriteLine($"Coldblooded: {ColdBlooded}");
        Console.WriteLine($"No Legs: {NoLegs}");
        Console.WriteLine($"Venemous: {Venemous}");
        Console.WriteLine($"Has Scales: {scales}");
    }
}
