using System.ComponentModel.DataAnnotations;

namespace ProjectBottles;

public class Bottle
{
    public int MaxVolume;
    public int CurrentVolume;
    public string Maker { get; set; } = null!;

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

    public int Sip(int input)
    {

        if(CurrentVolume < input)
        {
            var value = CurrentVolume;

            CurrentVolume = 0;

            return value;
        }

        else
        {
            CurrentVolume -= input;

            return input;
        }
    }

    public int Refill()
    {
        var rozdil = MaxVolume - CurrentVolume;

        CurrentVolume += rozdil;

        return rozdil;
    }
}
