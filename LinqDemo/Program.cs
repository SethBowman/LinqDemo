using LinqDemo;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

Console.WriteLine("Int Collections:");

var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//Filtering with LINQ
var numbersAboveFive = numbers.Where(number => number > 5).ToList();

//foreach(var number in numbersAboveFive)
//{
//    Console.WriteLine(number);
//}

var evenNumbers = numbers.Where(x => x % 2 == 0).ToList();

//evenNumbers.ForEach(x => Console.WriteLine(x));

//Sum Method

Console.WriteLine(numbers.Sum());

//Average Method
Console.WriteLine(numbers.Average());

//Min and Max Method

Console.WriteLine($"The min number is {numbers.Min()} | The max number is {numbers.Max()}");

//Transforming with LINQ
var squaredNumbers = numbers.Select(number => number * number);

foreach(var number in squaredNumbers)
{
    Console.WriteLine(number);
}


Console.WriteLine("String collections:");

var names = new string[] { "Angel", "Anthony", "Ben", "Chinedu", "Dana", "Daniel", "James", "John", "Joseph", "Katherine", "Michael Driscoll", "Michael Vistocci", "Ryan", "Jose" };

//Filtering with LINQ
var longNames = names.Where(name => name.Length > 4).ToList();

//longNames.ForEach(x => Console.WriteLine(x));


//Transforming with LINQ
var upperCaseNames = names.Select(x => x.ToUpper());

//foreach(var name in upperCaseNames)
//{
//    Console.WriteLine(name);
//}

//Order by asc/desc

var sortedNames = names.OrderBy(name => name).ThenBy(name => name.Length);

foreach(var name in sortedNames)
{
    Console.WriteLine(name);
}

var dog1 = new Dog();
dog1.Name = "Bingo";
dog1.Age = 5;

var dog2 = new Dog();
dog2.Name = "Marmaduke";
dog2.Age = 1;

var dog3 = new Dog();
dog3.Name = "Marmaduke";
dog3.Age = 3;

var dogPound = new List<Dog>() { dog1, dog2, dog3 };

var sortedDogs = dogPound.OrderByDescending(dog => dog.Name).ThenBy(dog => dog.Age);

foreach(var dog in sortedDogs)
{
    Console.WriteLine($"{dog.Name} | {dog.Age}");
}