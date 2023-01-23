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

//string name = "Donamol joychan";

//foreach (var item in name)
//{
//    if( item == 'o')
//    {
//        Console.Write("*");

//    }
//    else
//    {
//        Console.WriteLine(item);    
//    }
//}




//Console.WriteLine("Enter the limit of array");
//int count = int.Parse(Console.ReadLine());

//double[] fare = new double[count];
//for (int i = 0;i < count; i++)
//{
//    fare[i] = double.Parse(Console.ReadLine());
//}


//int j = 0;
//int k = 1;

//for (int i = 0;i < count; i++)
//{
//    if (fare[i] % 2 == 0)
//    {
//        fare[j] = fare[i];
//        j = j + 2;
//        Console.WriteLine();
//    }

//    else
//    {
//        fare[k] = fare[i];
//        k = k + 2;
//    }
//}

//foreach (var item in fare) 
//{ 
//    Console.WriteLine(item); 
//}





//double[] arr = new double[10];
//double[] arr2 = new double[50];
//Console.WriteLine("enter array elements");
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = Convert.ToDouble(Console.ReadLine());
//}
//int j = -1;
//for (int i = 0; i < arr.Length; i++)
//{
//    if ((int)arr[i] % 2 != 0)
//    {
//        j += 2;
//        arr2[j] = arr[i];
//    }



//}
//int p = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if ((int)arr[i] % 2 == 0)
//    {
//        p += 2;
//        arr2[p] = arr[i];
//    }



//}
//foreach (var item in arr2)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("-------");
//Console.WriteLine("Even Or Odd");
//Console.WriteLine("-------");
//Console.WriteLine("Enter the array limit:");
//int count = int.Parse(Console.ReadLine());
//double[] arr = new double[count];
//double[] arr2 = new double[count * 2];
//Console.WriteLine("Enter flight fares(decimal format):");
//for (int i = 0; i < count; i++)
//{
//    arr[i] = Convert.ToDouble(Console.ReadLine());
//}
//var evenposition = 0;
//var oddposition = 1;



//for (int i = 0; i < count; i++)
//{



//    if (arr[i] % 2 == 0)
//    {
//        arr2[evenposition] = arr[i];
//        evenposition += 2;
//    }
//    else
//    {
//        arr2[oddposition] = arr[i];
//        oddposition = oddposition + 2;
//    }
//}
//Console.WriteLine(string.Join(',', arr2));


Console.WriteLine("Enter the dob");


DateTime dt = new DateTime(2019, 12, 31, 0, 0, 0);
Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss"));


