namespace Store_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            phoneStore store = new phoneStore(
               new ConsolePhoneReader(), new GeneralPhoneBinder(),
               new GeneralPhoneValidator(), new TextPhoneSaver());
            store.Process();

        }
    }
}