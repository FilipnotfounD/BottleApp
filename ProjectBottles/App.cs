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

        var bottle = new Bottle(answer, answer2);
        bottle.CurrentVolume = answer;

        while (proceed)
        {
            Console.WriteLine("Zadej svůj požadavek: Doplnit lahev (D) / Snížit objem o 50ml (S) / Snížit objem o zadaný objem (Z) / Ukončit celý proces (U)");
            var answer3 = Console.ReadLine()!;

            if (answer3 == "D")
            {
                Console.WriteLine(bottle.Refill());
                PrintDeLimiter();
            }
            else if(answer3 == "S")
            {
                Console.WriteLine(bottle.Sip());
            }
            else if(answer3 == "Z")
            {
                PrintDeLimiter();
                Console.WriteLine("Zadej o kolik chceš snížit objem:");
                var answer4 = SafelyConvertToInt(Console.ReadLine()!);

                Console.WriteLine(bottle.Sip(answer4));
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
