internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> cookies = new Dictionary<string, string>();

        cookies["user"] = "Maria";
        cookies["password"] = "joao";

        cookies["fone"] = "45998071677";



        Console.WriteLine(cookies["user"]);

    

        Console.WriteLine("todos os cookies " );

        //mostrar todos os valores

        foreach (KeyValuePair<string, string> item in cookies) 
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
        //ou
        foreach (var item in cookies)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }



    }
}