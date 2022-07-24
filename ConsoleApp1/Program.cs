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
    var maxKey = starWarsCombat.Keys.Max();
    var maxValue = starWarsCombat.Values.Max();
    var keyOfMaxValue = starWarsCombat.Aggregate(maxKey, (current, key) => current + key);
    return character;
}
{
    Console.WriteLine(DeathStarCombat(starWarsCombat));
