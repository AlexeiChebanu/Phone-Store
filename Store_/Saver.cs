namespace Store_
{
    interface IPhoneSaver
    {
        void Save(Phone phone, string fileName);
    }
    class TextPhoneSaver : IPhoneSaver
    {
        public void Save(Phone phone, string fileName)
        {
            using StreamWriter writer = new StreamWriter(fileName, true);            
            writer.Write(phone.name +" ");
            writer.Write(phone.model + " ");
            writer.WriteLine(phone.price);
        }
    }
}
