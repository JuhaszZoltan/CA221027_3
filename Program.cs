Random rnd = new();
int[] t = new int[10];
for (int i = 0; i < t.Length; i++) t[i] = rnd.Next(10, 100);
foreach (var elem in t) Console.Write($"{elem} ");
Console.Write('\n');

Console.WriteLine($"t elemeinek összege: {t.Sum()}");
Console.WriteLine($"t elemeinek átlaga: {t.Average()}");
Console.WriteLine($"t legkisebb eleme: {t.Min()}");
Console.WriteLine($"t legnagyobb eleme: {t.Max()}");
Console.Write("eldöntéshez: ");
int e = int.Parse(Console.ReadLine());
Console.WriteLine($"van-e a t-ben {e}: {(t.Contains(e) ? "igen" : "nem")}");
Console.Write("kereséshez/kiválasztáshoz: ");
int k = int.Parse(Console.ReadLine());
Console.WriteLine($"{k} indexe t-ben: {Array.IndexOf(t, k)}");

Console.WriteLine($"t-ben a legkisebb elem indexe: {Array.IndexOf(t, t.Min())}");
Console.WriteLine($"t-ben a legnagyobb elem indexe: {Array.IndexOf(t, t.Max())}");

//megszámlálás (~LINQ~)
//kiválogatás (~LINQ~)

//sorozatszámítás (osszegzés)
//szélszőérték (min, max, min_loc, max_loc)
//eldöntés
//linker
//kiválasztás


static void Tombok()
{
    string[] strings = new string[10];
    var ints = new int[10];
    bool[] bools = { true, false, false, true };
    var floats = new float[] { 10f, 22.2f, 3.14f };
    int[,] matrix = new int[2, 3]
    {
    { 0, 0, 1 },
    { 1, 0, 1 },
    };


    for (int i = 0; i < ints.Length; i++)
    {
        Console.Write($"t[{i}] = ");
        ints[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine($"elemek átlaga: {ints.Average()}");

    for (int i = 0; i < ints.Length; i++)
    {
        Console.Write($"{ints[i]} ");
    }
    Console.Write('\n');
    foreach (int elem in ints)
    {
        Console.Write($"{elem} ");
    }
}

static void Rendezes()
{
    string[] nevek = new string[5];
    int[] magassagok = new int[nevek.Length];

    for (int i = 0; i < nevek.Length; i++)
    {
        Console.Write($"{i + 1}. név: ");
        nevek[i] = Console.ReadLine();
        Console.Write($"{nevek[i]} magassága: ");
        magassagok[i] = int.Parse(Console.ReadLine());
    }

    //rendezzük a neveket a HOZZÁ TARTOZÓ magasságok szerint csökkenőbe:

    //for (int i = 0; i < magassagok.Length - 1; i++)
    //{
    //    for (int j = i; j < magassagok.Length; j++)
    //    {
    //        if (magassagok[i] > magassagok[j])
    //        {
    //            int  ms = magassagok[i];
    //            string ns = nevek[i];

    //            magassagok[i] = magassagok[j];
    //            nevek[i] = nevek[j];

    //            magassagok[j] = ms;
    //            nevek[j] = ns;
    //        }
    //    }
    //}

    Array.Sort(magassagok, nevek);
    magassagok.Reverse();
    nevek.Reverse();

    for (int i = 0; i < nevek.Length; i++)
    {
        Console.WriteLine($"{nevek[i]}: {magassagok[i]} cm");
    }
}