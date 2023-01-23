//using ConsoleProject20Jan;
///* var s = new Student()
//{
//    Name = "John",
//    //Age = 10
//    Mark1 = 40,
//    Mark2 = 45
//};

////Console.WriteLine(s.Age);
////s.Display();
//Console.WriteLine(s.Name);
//Console.WriteLine(s.Total);

////Console.WriteLine(s); */



///*******************************************************************************************************
//*******************************************************************************************************
//*******************************************************************************************************/

//var lst = new List<int>();
//lst.Add(1);
//lst.Add(2);
//lst.Add(3);


//lst[0] = 33;
//Console.WriteLine(lst.Count);

//foreach (var item in lst)
//{
//    Console.WriteLine(item);
//}


//var lst2 = new List<int>() { 100, 200, 300 };
//var lst1 = new List<int>() { 400, 500, 600 };
//lst.AddRange(lst1);
//Console.WriteLine(String.Join(", ", lst2));

///*******************************************************************************************************
//*******************************************************************************************************
//*******************************************************************************************************/

//var lst5 = new List<int>();
//lst.Add(1);
//lst.Add(2);
//lst.Add(3);
//Console.WriteLine(lst.Count);

///*******************************************************************************************************
//*******************************************************************************************************
//*******************************************************************************************************/

//Dictionary<string, string> dict = new Dictionary<string, string>();
//dict.Add("Name", "Donamol");
//dict.Add("Age", "21");

//// Use to update value.
//dict["Name"] = "Della";  

//Console.WriteLine(dict["Name"]);
//Console.WriteLine(dict["Age"]);


//Console.WriteLine(dict.Count);
////Console.WriteLine(String.Join(", ", ));



//var employees = new List<Dictionary<string, string>>();

//Console.WriteLine(" 1. Add Employee");
//Console.WriteLine(" 2. View Employee");


////foreach (var employee in lst)


////void greet()
////{
////    Console.WriteLine("Hello DONAMOL");
////}
////greet();

//void greet() => Console.WriteLine("Hello DONAMOL");
//greet();

////int Add(int x, int y)
////{
////    return x + y;
////}

////var res = Add(1, 2);
////Console.WriteLine(res); 
//int Add(int x, int y) => x + y;

//var res = Add(1, 2);
//Console.WriteLine(res);

////string? data = "donamol";
////var res = data ?? "default";
////Console.WriteLine(res);


//var day = Days.Wednesday;   // o/p - wednesday
//// or  Days day = Days.Wednesday; ______o/p - wednesday 
//// or Days day = 2;_________o/p - wednesday
//Console.WriteLine(day);
//int d = (int)day;
//Console.WriteLine(d);

////Here datatype is Days
//enum Days
//{
//    Monday,
//    Tuesday,
//    Wednesday
//}


string ConvertCasing(string text, Option option)
{
    switch (option)
    {
        case Option.UpperCase:
            return text.ToUpper();
            case Option.LowerCase: 
            return text.ToLower();
        default:
            return text;
    }
}

var res = ConvertCasing("Hello", Option.UpperCase);
Console.WriteLine(res);

enum Option
{
    UpperCase,
    LowerCase
}