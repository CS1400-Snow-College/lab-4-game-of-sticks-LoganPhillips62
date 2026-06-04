
int sticks = 20;
int player = 1;
Console.WriteLine("Take 1-3 sticks. Whoever takes the last stick loses.");
while (sticks > 0)
{
    int max = Math.Min(3, sticks);
Console.WriteLine($"Sticks left: {sticks}");
Console.Write($"Player {player}, take 1-{max}: ");
string? s = Console.ReadLine();
if (!int.TryParse(s, out int take))
{
    Console.WriteLine("Please enter a number.");
    continue;
}

if (take < 1 || take > max)
{
    Console.WriteLine("Invalid number. Try again.");
    continue;
}

sticks -= take;

if (sticks == 0)
{
    Console.WriteLine($"Player {player} took the last stick and loses.");
    Console.WriteLine($"Player {(player == 1 ? 2 : 1)} wins!");
    break;
}

player = (player == 1) ? 2 : 1;
}
