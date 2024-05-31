// See https://aka.ms/new-console-template for more information


static double[] NHarm ()
{
    int a = Convert.ToInt32(Console.ReadLine());
    double s = 0,n = 0;
    double[] THarm = new double[a];

    for (int i = 0; i < a; i++)
    {
        n++;
        s = s + (1 / n);
        THarm[i] = s;
    }

    return THarm;
}

double[] t = NHarm ();
for (int i = 0; i < t.Length; i++)
{
    Console.WriteLine($"{t[i]:F2}");
}