Console.WriteLine("How many flight fare and destinations you want to insert : ");
int arraysize = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the fligt fare");
double[] flightFare = new double[arraysize];
for(int i = 0;i < arraysize; i++)
{
    flightFare[i] = double.Parse(Console.ReadLine());
}

Console.WriteLine("Enter the fligt destination");

string[] destination = new string[arraysize];
for (int i = 0;i < destination.Length; i++)
{
    destination[i] = Console.ReadLine();
}

for(int i = 0;i < arraysize; i++)
{
    Console.WriteLine("Enter the index of data to be fetched : ");
    int index = int.Parse(Console.ReadLine());
    if(index < arraysize)
    {
        Console.WriteLine($"Destination : {destination[index]} \n Flight fare : {flightFare[index]}");
    }
    else 
    { 
        Console.WriteLine("No such index present");
    }
}