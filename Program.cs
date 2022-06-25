string heroName = "Angel";
int heroPower = 150;
string villainName = "Devil";
int villainPower = 100;
if (heroPower > villainPower)
{
    Console.WriteLine("villain damged");
}

else if (heroPower == villainPower)
{
    Console.WriteLine("oh..");
}
else if (heroPower < villainPower)
{
    Console.WriteLine("I am damged");
}
else
{
    Console.WriteLine("....");
}
