Console.WriteLine("Add name of user");
string username = Console.ReadLine();

if(username.ToLower() == "maria")
{
    Console.WriteLine("My dear Maria!");    
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}