using System.ComponentModel.DataAnnotations;

namespace ProjectBottles;

public class Bottle
{
    public int MaxVolume;
    public int CurrentVolume;
    public string Maker { get; set; }= null!;

    public Bottle(int MaxObjem, string Vyrobce)
    {
        MaxVolume = MaxObjem;

        Maker = Vyrobce;
    }

    public void Sip()
    {
        if (CurrentVolume >= 50)
        {
            CurrentVolume -= 50;

            Console.WriteLine(true);
        }

        else
        {

            Console.WriteLine(false);

        }
    }

    public void Sip(int input)
    {

        if(CurrentVolume < input)
        {
            var value = CurrentVolume;

            CurrentVolume = 0;

            Console.WriteLine($"Bylo ubráno: {value} ml.");
        }

        else
        {
            CurrentVolume -= input;

            Console.WriteLine($"Bylo ubráno: {input} ml.");
        }
    }

    public void Refill()
    {
        var rozdil = MaxVolume - CurrentVolume;

        CurrentVolume += rozdil;

        Console.WriteLine($"Bylo doplněno: {rozdil} ml.");
    }
}
