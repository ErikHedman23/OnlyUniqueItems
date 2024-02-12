// See https://aka.ms/new-console-template for more information
using OnlyUniqueElements;

Console.WriteLine("Hello, World!");

var lst = new List<string>();

string l = "catapult";

foreach (char item in l)
{
    lst.Add(item.ToString());
}

var answer = UniqueItems.OnlyReturnUniqueItems(lst.ToArray());

foreach (string s in answer)
{
    Console.WriteLine(s);
}


