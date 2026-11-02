double[] week = [14.2, 17.5, 19.0, 16.8, 21.3, 22.7, 18.4];
static double Average(double[] t)
{
    double sum = 0;
    for (int i = 0; i < t.Length; i++)
    {
        sum += t[i];
    }
    return sum / t.Length;
}
double avrg =Average(week);

Console.WriteLine($"Average:{avrg:F1}");

Console.WriteLine("--------------------------------------------------");
int maxNum = 0;
for (int i=1 ; i<week.Length; i++)
{
    if (week[i]> week[maxNum])
    {
        maxNum = i;
    }
}

Console.WriteLine($"Hottest day:{maxNum + 1} \nTemperature:{week[maxNum]:f2} C");

Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Days Above Average:");
for(int i=0; i<week.Length; i++)
{
   if(week[i]> avrg)
    {
        Console.WriteLine($"Day {i + 1}: {week[i]:F2} C");
    }
     
}

Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Last three days temperatures:");
double[] lastThreeDays = week[^3..];
foreach(double temp in lastThreeDays)
{
    Console.WriteLine($"Temperature: {temp:F2} C");
}