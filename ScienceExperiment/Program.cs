int Temperature;

do
{
    Console.Write("Input your Temperature (must be between -50 and 150): ");
    Temperature = int.Parse(Console.ReadLine());

    if (Temperature < -50 || Temperature > 150)
    {
        Console.WriteLine("Invalid input. Temperature must be between -50 and 150");
    }
    else
    {
        Console.WriteLine($"You entered a valid temperature: {Temperature}°C");
    }
} while (Temperature < -50 || Temperature > 150);

if (Temperature < 0)
{
    Console.WriteLine("It's freezing!");
}
else if (Temperature >= 0 && Temperature <= 30)
{
    Console.WriteLine("It's Normal.");
}
else if (Temperature > 30 && Temperature <= 100)
{
    Console.WriteLine("It's Hot.");
}
else
{
    Console.WriteLine("It's extremely hot!");
}