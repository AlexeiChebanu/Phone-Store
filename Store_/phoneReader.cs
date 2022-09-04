namespace Store_
{
    interface IPhoneReader
    {
        string?[] GetInputData();
    }
    class ConsolePhoneReader : IPhoneReader
    {
        public string?[] GetInputData()
        {
            Console.WriteLine("Enter phone's name:\t");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter phone's model:\t");
            string? model = Console.ReadLine();
            Console.WriteLine("Enter phone's price:\t");
            string? price = Console.ReadLine();
            return new string?[] { name, model, price };
        }
    }
}
