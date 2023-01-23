/* string[] passenger = new string[3];
Console.WriteLine("Enter passenger name");
for (int i = 0; i < passenger.Length; i++)
{
    passenger[i] = Console.ReadLine();
} */


using System.Net.NetworkInformation;

Console.WriteLine("Enter passenger name");
string passenger = Console.ReadLine();
Console.WriteLine("Enter total miles traveled");
double miles = double.Parse(Console.ReadLine());
int frequentFlyerPoint = 0;

if(miles > 10000 && miles<= 20000)
{
    frequentFlyerPoint = frequentFlyerPoint + 10;
    Console.WriteLine($"Passenger Name : {passenger} \nFrequent Flyer Point : {frequentFlyerPoint}");
}
else if(miles > 20000 && miles <= 50000)
{
    frequentFlyerPoint = frequentFlyerPoint + 20;
    Console.WriteLine($"Passenger Name : {passenger} \nFrequent Flyer Point : {frequentFlyerPoint}");
}
else if(miles > 50000 && miles <= 100000)
{
    frequentFlyerPoint = frequentFlyerPoint + 30;
    Console.WriteLine($"Passenger Name : {passenger} \nFrequent Flyer Point : {frequentFlyerPoint}");    
}
else if(miles > 100000)
{
    frequentFlyerPoint = frequentFlyerPoint + 50;
    Console.WriteLine($"Passenger Name : {passenger} \nFrequent Flyer Point : {frequentFlyerPoint}");
}
else
{
    frequentFlyerPoint = 0;
    Console.WriteLine($" \nFrequent Flyer Point : {passenger} \nFrequent Flyer Point : {frequentFlyerPoint} \nNote : Total miles travelled is less than 10000 miles.");
}