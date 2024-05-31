// See https://aka.ms/new-console-template for more information


static double[] NHarm ()
{
    Console.WriteLine("Veuillez rentrer le nombre d'éléments harmoniques");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a < 1)
    {
        throw new ArgumentException("Le nombre à rentrer doit être strictement positif");
    }
    double[] THarm = new double[a];

    THarm = Calcul(THarm, a);

    return THarm;
}

static double[] Calcul(double[] THarm, int a)
{
    double s = 0, n = 0;

    for (int i = 0; i < a; i++)
    {
        n++;
        s = s + (1 / n);
        THarm[i] = s;
    }

    return THarm;
}

TAffichage(NHarm());

static void TAffichage(double[] THarm) 
{
    Console.WriteLine("Le tableau contient : ");
    for (int i = 0; i < THarm.Length; i++)
    {
        Console.WriteLine($"{THarm[i]:F2}");
    }
}