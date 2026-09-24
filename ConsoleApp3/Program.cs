// random.shared.next() creates a "random" number.
// The first number is included, while the latter is excluded.

Restart:
// An indicator that goto can use to make the code run from a specified point.

int Player1_hp = Random.Shared.Next(50, 151);
int Player2_hp = Random.Shared.Next(50,151);
// HP is randomised

Console.WriteLine($"Brick has {Player1_hp} hp");
Console.WriteLine($"Stone has {Player2_hp} hp");
Console.WriteLine("They will now fight to the death");
Console.WriteLine("");
Console.ReadLine();

static int damageDealt()
{
    int damage = Random.Shared.Next(1, 21); //Attacks randomly deal 1 to 20 damage.
    return damage;
}
static int hitRate()
{
    int hitOrMiss = Random.Shared.Next(1, 11); //There is a 1/10 chance of any attack missing.
    return hitOrMiss;
}

int fightStatus = 1;
// fightStatur works as an indicator weather or not the fight is still going.

while (fightStatus == 1)
{
    if (hitRate() == 1)
    {
        Console.WriteLine("Stone missed his attack");
        Console.WriteLine($"Brick took no damage");
        Console.WriteLine($"Current hp: {Player1_hp}");
        Console.WriteLine("");
    }
    else
    {
        Player1_hp -= damageDealt();
        Console.WriteLine("Stone hit Brick");
        Console.WriteLine($"Brick took {damageDealt()} damage");
        Console.WriteLine($"Current hp: {Player1_hp}");
        Console.WriteLine("");
    }

    if (hitRate() == 1)
    {
        Console.WriteLine("Brick missed his attack");
        Console.WriteLine("Stone took no damage");
        Console.WriteLine($"Current hp: {Player2_hp}");
        Console.WriteLine("");
    }
    else
    {
        Player2_hp -= damageDealt();
        Console.WriteLine("Brick hit Stone");
        Console.WriteLine($"Stone took {damageDealt()} damage");
        Console.WriteLine($"Current hp: {Player2_hp}");
        Console.WriteLine("");
    }
    Console.ReadLine();

    if (Player1_hp <= 0)
    {
        Console.WriteLine("Stone won!");
        break;
    }
    else if (Player2_hp <= 0)
    {
        Console.WriteLine("Brick won!");
        break;
    }
    else if (Player1_hp <= 0 && Player2_hp <= 0)
    {
        Console.WriteLine("It's a tie!");
        break;
    }
}

fightStatus--;
while (fightStatus == 0)
// Basicly, if the fight is over this code will run.
{
    Console.WriteLine("Press [r] to restart");
    string restart = Console.ReadLine();
    restart = restart.ToLower();
    if (restart == "r")
    {
        Console.WriteLine(""); //This will just leave an empty line.
        goto Restart;
        // goto will make the code run from the specified marker. In this case "Restart".
    }
    else
    {
        break;
    }
}

// break imediatly ends a loop.

// Loop, code that reapeats.
// While(), is a continuous loop. If the statment in the brakets is true it will continue to loop.
// An infinete loop is a loop that can not end.

Console.ReadLine();