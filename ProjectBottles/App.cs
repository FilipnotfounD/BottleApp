namespace ProjectBottles;

public class App
{
    public void Run()
    {
        bool proceed = true;

        Console.WriteLine("Zadej maximální objem lahve (v mililitrech):");
        var answer = SafelyConvertToInt(Console.ReadLine()!);

        Console.WriteLine("Zadej výrobce lahve:");
        var answer2 = Console.ReadLine()!;

        var Bottle = new Bottle(answer, answer2);
        Bottle.CurrentVolume = answer;

        while (proceed)
        {
            Console.WriteLine("Zadej svůj požadavek: Doplnit lahev (D) / Snížit objem o 50ml (S) / Snížit objem o zadaný objem (Z) / Ukončit celý proces (U)");
            var answer3 = Console.ReadLine()!;

            if (answer3 == "D")
            {
                Console.WriteLine(Bottle.Refill());
                PrintDeLimiter();
            }
            else if(answer3 == "S")
            {
                Console.WriteLine(Bottle.Sip());
            }
            else if(answer3 == "Z")
            {
                PrintDeLimiter();
                Console.WriteLine("Zadej kolik o kolik chceš snížit objem:");
                int answer4 = SafelyConvertToInt(Console.ReadLine()!);

                Console.WriteLine(Bottle.Sip(answer4));
                PrintDeLimiter();
            }
            else if(answer3 == "U")
            {
                proceed = false;
            }
            else
            {
                continue;
            }
        }
    }

    public int SafelyConvertToInt(string input)
    {
        if (int.TryParse(input, out int result))
        {
            return result;
        }

        else
        {
            return int.MinValue;
        }
    }
    public void PrintDeLimiter()
    {
        Console.WriteLine("---------------------------");
    }
}
