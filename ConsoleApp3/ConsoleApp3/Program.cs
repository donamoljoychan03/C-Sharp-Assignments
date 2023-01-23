using System.Globalization;
using System.Reflection.Metadata.Ecma335;

double[] fareList = new double[4];
Console.WriteLine("Enter fares");

for(int i = 0;i < fareList.Length; i++)
{
    fareList[i] = double.Parse(Console.ReadLine());
}


Console.WriteLine(" Fare list in ascending order");
for (int i = 0; i < fareList.Length; i++)
{
    for (int j = i; j < fareList.Length; j++)
    {
        if (fareList[i] > fareList[j])
        {
            double temp = fareList[i];
            fareList[i] = fareList[j];
            fareList[j] = temp;
        }
    }
}
for (int i = 0; i < fareList.Length; i++)
{
    Console.WriteLine(fareList[i]);
}

//_________________________________________________________________________________________________

Console.WriteLine(" Fare list in descending order");
for (int i = 0; i < fareList.Length; i++)
{
    for (int j = i; j < fareList.Length; j++)
    {
        if (fareList[i] < fareList[j])
        {
            double temp = fareList[i];
            fareList[i] = fareList[j];
            fareList[j] = temp;
        }
    }
}
foreach (var fare in fareList)
{
    Console.WriteLine(fare);
}

//_________________________________________________________________________________________________

Console.WriteLine("Enter fare to be find");
double searchedfare = double.Parse(Console.ReadLine());
int count = 0;

foreach (var fare in fareList)
{
    if (searchedfare == fare)
    {
        count++;
    }
}
if (count == 0)
{
    Console.WriteLine($"fare {searchedfare} is not found in the fare list");
}
else
{
    Console.WriteLine($"fare {searchedfare} is found in the fare list");
}


//_________________________________________________________________________________________________

Console.WriteLine("Finding maximum and minimum fares");

for (int i = 0; i < fareList.Length; i++)
{
    for (int j = i; j < fareList.Length; j++)
    {
        if (fareList[i] > fareList[j])
        {
            double temp = fareList[i];
            fareList[i] = fareList[j];
            fareList[j] = temp;
        }
    }
}

Console.WriteLine($"The minimum fare : {fareList[0]}");
Console.WriteLine($"The maximum fare : {fareList[fareList.Length - 1]}");


//_________________________________________________________________________________________________

int flag = 0;
for (int i = 0; i < fareList.Length; i++)
{
    for (int j = i+1; j < fareList.Length; j++)
    {
        if (fareList[i] == fareList[j])
        {
            Console.WriteLine($" duplicate fare entry : {fareList[i]}");
        }
    }
    
}
//if (flag == 0)
//{
//    Console.WriteLine("No duplicate fare entry");
//}
//else
//{
//    Console.WriteLine();
//}
