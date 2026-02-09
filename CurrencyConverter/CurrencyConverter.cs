Console.Write("Enter the amount in USD: ");
double amountInUSD = double.Parse(Console.ReadLine());
Console.Write("Enter exchange rate from USD to PHP: ");
double exchangeRate = double.Parse(Console.ReadLine());
double amountInPHP = amountInUSD * exchangeRate;

Console.WriteLine("Amount in PHP: " + amountInPHP);
