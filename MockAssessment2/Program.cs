// 1.) Create a static method named AddStarWarsCharacters() that takes in a string[]
//This method then searches for and returns the index of “Yoda”.
//If “Yoda” is not in the array, return -1.

using System.Linq;

//string[] characters = { "Chewbacca", "Darth Vader", "Obi-Wan Kenobi", "Yoda", "R2D2", "Luke Skywalker", "Han Solo", "Boba Fett" };
//List<string> newList = new List<string>();


//int AddStarWarsCharacters(string[] characters)
//{

    
//        for (int i = 0; i < characters.Length; i++)
//        {
           
//            if (characters[i] == "Yoda")
//            {
//                return i;
//            }
//        }
            
    
//    return -1;
//}
//Console.WriteLine(AddStarWarsCharacters(characters));

//  2.) Create a static method named DeathStarCombat() that takes in a Dictionary<string,int> of Star Wars characters (key) and their attack values (value)
//      A) This method should return the name of the Jedi with the highest Attack value.

Dictionary<string, int> starWarsCombat = new Dictionary<string, int>()
{
    {"Chewbacca", 35 },
    {"Daarth Vader", 75 },
    { "Obi-Wan Kenobi", 65},
    { "Yoda", 80},
    { "R2D2", 20},
    { "Luke SkyWalker" , 70},
    { "Hahn Solo", 50},
    { "Boba Fett", 70}

};
string DeathStarCombat(string character, int attack)
{
    foreach (KeyValuePair<string, int> kvp in starWarsCombat)
    {
        Console.WriteLine(kvp);
        starWarsCombat[kvp.Key] = kvp.Value;
    }
}
{
    Console.WriteLine(kvp);



//}

//  3.) create a static method named convertplanets() takes in one parameter: an array of planets
//the method will convert the array of planets into a list of planets
//in the reverse order.
//return list.

string[] planets = new string[] { "mercury", "venus", "earth", "mars", "jupiter", "saturn", "neptune", "pluto" };


string[] ConvertPlanets(string[] planet)
{
    for (var i = planets.Length - 1; i >= 0; i--)
    {
        Console.WriteLine(planet[i]);
    }
   
    return planet;
};
Console.WriteLine(ConvertPlanets(planets));


//      4.) Create a static method named AverageDroids() takes in an integer List for droids
//The method will search through the list and calculate the average of all even-numbered droids. 
//Return average.

List<int> numbers = new List<int> { 6, 6, 10, 7, 19, 24 };

List<int> AverageDroids(List<int> numbers)
{
    List<int> evenList = new List<int>();
    foreach (int i in numbers)
    {
        if (i % 2 == 0)
        {
            evenList.Add(i);
        }
    }
    List<int> averageNums = new List<int>();
    foreach (int i in evenList)
    {
        averageNums.Add(i);

    }
    int averageEvenNum = (averageNums.Sum()) / averageNums.Count();
    Console.WriteLine(averageEvenNum);
    return numbers;

}
Console.WriteLine(AverageDroids(numbers));




//      5.) Create a static method named TryToCatchDarthVader(). This method will take in a string as a parameter and parse that string as an integer.
//return “Vader Was Captured!” If the parse is successful.
//return “Vader Got Away!”. If FormatException is thrown.
//Hint: Use A Try-Catch.


Dictionary<string, bool> catchVader = new Dictionary<string, bool>();
catchVader.Add("Was Caught", true);
catchVader.Add("Was not Caught", false);

string TryToCatchDarthVader(string userInput)
{
    int catchVader;
    userInput = Console.ReadLine();
    try
    {
        Console.WriteLine("Please enter text or an int: ");
        catchVader = Int32.Parse(userInput);
        return "Vader Was Caught!";
    }
    catch (Exception e)
    {
        Console.WriteLine("Error! Invalid Input. ");
        Console.WriteLine(e);
        return "Vader Got Away!";
    }
    finally
    {
        Console.WriteLine("Finally Block is Executed");
        ;
    }
    
    Console.WriteLine("Program has ended. ");
}
Console.WriteLine(TryToCatchDarthVader(Console.ReadLine()));