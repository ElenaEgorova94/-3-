Console.WriteLine("Введите пятизначное число");
string N = Console.ReadLine();

if (N[0] == N[4] && N[1] == N[3])
{
    Console.WriteLine($"Ваше число {N} - палиндром");
}

else
{
    Console.WriteLine($"Ваше число {N} - не палиндром");
}