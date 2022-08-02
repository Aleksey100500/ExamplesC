Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
Console.WriteLine(username);

if (username.ToLower() == "natasha")
{
    Console.WriteLine("Ура, это же ЖОПА!");
}

else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
