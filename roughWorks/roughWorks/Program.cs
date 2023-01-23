//DateOnly[] dona = new DateOnly[1];
//for (int i = 0; ; i++)
//{
//    dona[i] = DateOnly.Parse( Console.ReadLine());
//}
////dona =Console.ReadLine();
//Console.WriteLine(dona);

//var birthday = new DateTime(2001, 12, 11);
//var age = DateTime.Now.Year - birthday.Year;
//Console.WriteLine(age);

string name = "Donamol joychan";

foreach (var item in name)
{
    if( item == 'o')
    {
        Console.Write("*");

    }
    else
    {
        Console.WriteLine(item);    
    }
}

