// Enter Data
Console.Write("Enter your name: ");
string UserName = Console.ReadLine();

if(UserName.ToLower() == "anna")
{
    Console.Write("Hi, my darling ");
    Console.Write(UserName);
    Console.WriteLine("!");
}
else
{
    Console.Write("Hi, ");
    Console.Write(UserName);
    Console.WriteLine("!");
}
Console.WriteLine("End");