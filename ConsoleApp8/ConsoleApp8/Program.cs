Console.WriteLine("How many flight fare and destinations you want to insert : ");
int arraysize = int.Parse(Console.ReadLine());

double[] flightFare = new double[arraysize];
for(int i = 0;i < arraysize - 1; i++)
{
    flightFare[i] = double.Parse(Console.ReadLine());
}

string[] destination = new string[arraysize];
for (int i = 0;i < destination.Length; i++)
{
    destination[i] = Console.ReadLine();
}

for(int i = 0;i < arraysize; i++)
{

}