namespace Store_
{
    class phoneStore
    {
        List<Phone> phones = new List<Phone>() {
        };
        public IPhoneReader Reader { get; set; }
        public IPhoneBinder Binder { get; set; }
        public IPhoneValidator Validator { get; set; }
        public IPhoneSaver Saver { get; set; }
        public phoneStore(IPhoneReader reader, IPhoneBinder binder, IPhoneValidator validator, IPhoneSaver saver)
        {
            this.Reader = reader;
            this.Binder = binder;
            this.Validator = validator;
            this.Saver = saver;
        }
        public void Process()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Choose the action\n1.Add List\n2.Show\n3.Buy a phone\n4.Stop");
                int? switcher = int.Parse(Console.ReadLine());


                switch (switcher)
                {
                    case 1:
                        string?[] data = Reader.GetInputData();
                        Phone phone = Binder.CreatePhone(data);
                        if (Validator.IsValid(phone))
                        {
                            phones.Add(phone);
                            Saver.Save(phone, "E:\\csharp\\catalog.txt");
                            Console.WriteLine("Data processed successfully");
                        }
                        else
                        {
                            Console.WriteLine("Incorrect data");
                        }
                        break;
                    case 2:
                        {
                            string showR;
                            using (StreamReader sr = new StreamReader("E:\\csharp\\catalog.txt"))
                            {
                                while ((showR = sr.ReadLine()) != null)
                                {
                                    Console.WriteLine(showR);
                                }
                            }

                            break;
                        }
                    case 3:
                        {
                            string? reader;
                            using (StreamReader sr2 = new StreamReader("E:\\csharp\\catalog.txt"))
                            {
                                while ((reader = sr2.ReadLine()) != null)
                                {
                                    Console.WriteLine(reader);                                   
                                }
                            }
                            Console.WriteLine("Hello, what's your name?");
                            string? customerName = Console.ReadLine();
                                Console.WriteLine("Choose the phone");
                                string? phonechoosing = Console.ReadLine();
                            string? goods;
                            //We are looking for the same item.
                            //That is, the catalog contains "Apple(name) iPhone 13(model) 1000(price)",
                            //so we enter it down if you need to buy: Apple iPhone 13 1000
                            using (StreamReader sr2 = new StreamReader("E:\\csharp\\catalog.txt"))
                            {
                                while ((goods = sr2.ReadLine()) != null)
                                    if (goods == phonechoosing)
                                    {
                                        Console.WriteLine($"Dear {customerName},\n" +
                                        $"You bought {goods} {DateTime.Now}" +
                                            $"\nHave a good day");
                                        loop = false;
                                    }
                            }
                            break;                            
                        }
                    case 4:
                        loop = false;
                        break;  

                default:
                        Console.WriteLine("You've chosen wrong action");
                        break; 
                }
            }
        }
    }
}
//checked
