namespace Store_
{
    interface IPhoneBinder
    {
        Phone CreatePhone(string?[] data);
    }
    class GeneralPhoneBinder : IPhoneBinder
    {
        public  Phone CreatePhone(string?[] data)
        {
            if (data is { Length: 3 } && data[0] is string name &&
                name.Length > 0 && data[1] is string model &&
                model.Length > 0 && int.TryParse(data[2], out var price))
            {
                return new Phone(name, model, price);
            }
            throw new Exception("Phone model binder error. Incorrect data");
        }
    }
}
