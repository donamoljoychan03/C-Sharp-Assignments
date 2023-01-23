using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

string[] passenger = { "donamol joychan", "ashly k rarichan", "surabhi sm", "akshaya s", "bibin sasikumar", "jomet joseph", "gokul n", "varsha vm", "ciya tom", "tessamol" };
string[] passenger2 = new string[10];
for(int i = 0;i < passenger.Length; i++)
{
	passenger2[i] = Console.ReadLine();

}
Console.WriteLine("PASSENGER LIST IN ALPHEBETIC ORDER");
Array.Sort(passenger);
foreach(string psname in passenger)
{
   Console.WriteLine(psname);
}

Console.WriteLine("___________________________________________________________________");
Console.WriteLine("PASSENGER LIST IN REVERSE ORDER");
Array.Reverse(passenger);
foreach (string psname in passenger)
{
   Console.WriteLine(psname);
}

Console.WriteLine("___________________________________________________________________");

Console.WriteLine("SEARCH ELEMENT IN AN ARRAY");
Console.WriteLine("Enter 10 passenger name");
string[] passn = new string[10];
int flag = 0;
for (int i = 0; i < 10; i++)
{
   passn[i] = Console.ReadLine();
}
Console.WriteLine("Enter name to be search : ");
string name = Console.ReadLine();
for (int i = 0; i < 10; i++) 
{
   if (name == passn[i])
   {
       flag = flag + 1;
   }

}

if(flag == 0)
{
   Console.WriteLine("The passenger list not contains " + name);
}
else
{
   Console.WriteLine("The passenger list contains " + name);
}

Console.WriteLine("___________________________________________________________________");
for (int i = 0; i < passenger.Length; i++)
{
   int arraylength = passenger[i].Length;
   Console.WriteLine(passenger[i] +" : "+arraylength);
}
Console.WriteLine("___________________________________________________________________");
for(int i = 0;i < passenger.Length; i++)
{
   string[] splitnames = passenger[i].Split(' ');
   for (int j = 0;j < splitnames.Length; j++)
   {
       Console.WriteLine(splitnames[j]);
   }
   Console.WriteLine(" ");
} 

Console.WriteLine("___________________________________________________________________");
string[] passenger5 = { "donamol joychan", "donamol joychan", "ashly k rarichan", "surabhi sm", "akshaya s", "bibin sasikumar", "jomet joseph", "gokul n", "varsha vm", "ciya tom", "tessamol" };

Console.WriteLine(" duplicate entries");
int count = 0;
for (int i = 0; i < passenger5.Length; i++)
{
	for (int j = i + 1; j < passenger5.Length; j++)
	{
		if (passenger5[i] == passenger5[j])
		{
			Console.WriteLine($"Duplicate name : {passenger5[i]}");
			count++;
		}
	}
}
if(count == 0)
{
	Console.WriteLine("no duplicate entry");
}


