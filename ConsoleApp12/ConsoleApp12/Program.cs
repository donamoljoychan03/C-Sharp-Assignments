//12) Accept passenger name and destination in two different arrays and merge in to one array and display

string[] psname = new string[3];
Console.WriteLine("Enter passenger name");
for (int i = 0;i < psname.Length; i++)
{
    psname[i] = Console.ReadLine();
}

string[] dsname = new string[3];
Console.WriteLine("Enter passenger destination");
for(int i = 0;i < dsname.Length; i++)
{
    dsname[i] = Console.ReadLine();
}

Console.WriteLine(" Name and destination list of passengers");

//for(int i = 0;i < 10; i++)
//{
//    Console.WriteLine($"{psname[i]} : {dsname[i]}");
//}

Console.WriteLine("Merged array");

string[] mergedArray = new string[psname.Length + dsname.Length];
int j = 0;
for (int i = 0;i < psname.Length; i++)
{
    mergedArray[j] = psname[i];
    mergedArray[j+ 1] = dsname[i];
    j = j+ 2;   
}
for(int i = 0;i < mergedArray.Length; i++)
{
    Console.WriteLine(mergedArray[i]);
}
for (int i = 0;i < mergedArray.Length; i = i + 2) { 
Console.WriteLine($"{mergedArray[i]} : {mergedArray[i + 1]}");
}