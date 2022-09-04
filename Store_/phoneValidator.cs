namespace Store_
{
    interface IPhoneValidator
    {
        bool IsValid(Phone phone);
    }
    class GeneralPhoneValidator : IPhoneValidator
    {
        public bool IsValid(Phone phone) =>
            !string.IsNullOrEmpty(phone.name) 
            && !string.IsNullOrEmpty(phone.model)
            && phone.price > 0;
    }
}
