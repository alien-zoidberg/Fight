// int damage = Random.Shared.Next(1, 11);
// random.shared.next() creates a "random" number.
// The first number is included, while the latter is excluded.

int Player1_hp = Random.Shared.Next(50,151);
int Player2_hp = Random.Shared.Next(50,151);

Console.WriteLine($"Bric has {Player1_hp} hp");
Console.WriteLine($"Stone has {Player2_hp} hp");
Console.WriteLine("They will now fight to the death");
Console.WriteLine("");
Console.ReadLine();

while (true)
{
    int damage1 = Random.Shared.Next(0, 21);
    Player1_hp -= damage1;
    if (damage1 == 0)
    {
        Console.WriteLine("Stone missed his attack");
        Console.WriteLine($"Brick took no damage");
        Console.WriteLine($"Current hp: {Player1_hp}");
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine("Stone hit Brick");
        Console.WriteLine($"Brick took {damage1} damage");
        Console.WriteLine($"Current hp: {Player1_hp}");
        Console.WriteLine("");
    }


    int damage2 = Random.Shared.Next(0, 21);
    Player2_hp -= damage2;
    if (damage2 == 0)
    {
        Console.WriteLine("Brick missed his attack");
        Console.WriteLine("Stone took no damage");
        Console.WriteLine($"Current hp: {Player2_hp}");
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine("Brick hit Stone");
        Console.WriteLine($"Stone took {damage2} damage");
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

// break imediatly ends a loop.

// while (hp1 > 0 && hp2 > 0)
// {
//     Console.WriteLine("It's Alive!");
//     hp1 -= 10;
// }

// Loop, code that reapeats.
// While(), is a continuous loop. If the statment in the brakets is true it will continue to loop.
// An infinete loop is a loop that can not end.


Console.ReadLine();