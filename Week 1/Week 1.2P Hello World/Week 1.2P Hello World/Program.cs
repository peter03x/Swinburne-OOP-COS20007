namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Message myMessage;
            myMessage = new Message("Hello World!");
            myMessage.Print();
            Message[] messages = { null, null, null, null, null };
            messages[0] = new Message("Welcome back!");
            messages[1] = new Message("What a lovely name");
            messages[2] = new Message("Great name");
            messages[3] = new Message("Oh hi!");
            messages[4] = new Message("That is a sily name");
            string name;
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            if (name.ToLower() == "vy")
                messages[0].Print();
            else if (name.ToLower() == "bao")
                messages[1].Print();
            else if (name.ToLower() =="tony")
                messages[2].Print();
            else if (name.ToLower() == "vinh")
                messages[3].Print();
            else messages[4].Print();
            Console.ReadLine();
        }
    }
}