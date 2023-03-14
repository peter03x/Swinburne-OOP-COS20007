namespace SwinAdventure
{
    internal class Program
    {

        static void Main(string[] args)
        {
            IdentifiableObject id = new IdentifiableObject(new string[] { "bob", "tom", "sarah" });
            id.AreYou("put");
            Console.WriteLine(id.FirstId);
            id.AddIdentifier("Tim");
            id.PrintIdents();
        }
    }
}