// GAMBLING SIMULATOR

// random class
Random rand = new(); // creates an instance of a new random class

// assigning random values
int throw1 = rand.Next(1,7);
int throw2 = rand.Next(1,7);
int throw3 = rand.Next(1,7);

int total = throw1 + throw2 + throw3;

// output simple throw info
Console.WriteLine($"Your throws are {throw1} + {throw2} + {throw3} = {total}");



// tripples bonus check
if (throw1 == throw2 && throw2 == throw3 && throw3 == throw1)
{
    total += 3;
    Console.WriteLine("\n\tYou rolled tripples! + 3 bonus");
}

// BONUS
else if (throw1 == throw2 || throw2 == throw3 || throw3 == throw1)
{
    total += 2;
    // output bonus info
    Console.WriteLine("\n\tYou rolled doubles! +2 to total");
}


// WIN assesment
if (total == 21) 
{
    Console.WriteLine("\n\t\tYou win 1000$ !");
}
else if (total >= 16)
{
    Console.WriteLine("\n\t\tYou win 333$ !");
}
else if (total >= 12)
{
    Console.WriteLine("\n\t\tYou win 111$ !");
}
else
{
    Console.WriteLine("\n\t\tYou lost... ");
}
