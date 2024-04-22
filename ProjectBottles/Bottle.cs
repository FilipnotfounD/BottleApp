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

    public bool Sip()
    {
        if (CurrentVolume >= 50)
        {
            CurrentVolume -= 50;

            return true;
        }

        else
        {

            return false;

        }
    }

    public string Sip(int input)
    {

        if(CurrentVolume < input)
        {
            var value = CurrentVolume;

            CurrentVolume = 0;

            return $"Bylo ubráno: {value} ml.";
        }

        else
        {
            CurrentVolume -= input;

            return $"Bylo ubráno: {input} ml.";
        }
    }

    public string Refill()
    {
        var rozdil = MaxVolume - CurrentVolume;

        CurrentVolume += rozdil;

        return $"Bylo doplněno: {rozdil} ml.";
    }
}
