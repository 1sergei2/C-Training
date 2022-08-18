Console.Write("Введите имя пользователя ");
string? username = Console.ReadLine();

if (!String.IsNullOrWhiteSpace(username))
if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!");

}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);    
}