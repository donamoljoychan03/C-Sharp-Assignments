DateTime[] passengerDob = new DateTime[10];
for(int i = 0;i < passengerDob.Length; i++)
{
    passengerDob[i] = DateTime.Parse(Console.ReadLine());  
}
foreach(DateTime i in passengerDob)
{
    Console.WriteLine(i);
}

foreach (DateTime i in passengerDob)
{
    var age = DateTime.Now.Year - i.Year;

    if(age < 10)
    {
        Console.WriteLine($"KID - Age: {age}");
    }
    else if(age >=10 && age < 30 )
    {
        Console.WriteLine($"YOUTH - Age: {age}");

    }
    else if (age >= 10 && age < 30)
    {
        Console.WriteLine($"ADULT - Age: {age}");

    }
    else
    {
        Console.WriteLine($"OLD - Age: {age}");
    }
}



