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

List<int> attack = new List<int>();
foreach (var item in starWarsCombat)
{
    attack.Add(item.Value);
}
List<int> highestAttack = attack.OrderByDescending(x => x).ToList();
foreach (var i in highestAttack)
{
    Console.WriteLine(i);
}

//Console.WriteLine();