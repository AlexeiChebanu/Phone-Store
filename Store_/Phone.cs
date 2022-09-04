namespace Store_
{
    class Phone
    {
        public string name { get; }
        public string model { get; }
        public int price { get; }

        public Phone(string name, string model, int price)
        {
            this.name = name;
            this.model = model;
            this.price = price;
        }
    }
}
