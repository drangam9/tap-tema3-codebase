namespace Lab4Web.Services.Delegate
{
    public class DelegateService : IDelegateService
    {
        public string Introduction(string firstName, string lastName, Func<string, string, string> callback)
        {
            return callback(firstName.ToUpper(), lastName.ToUpper());
        }
        public string Hello(string firstName, string lastName)
        {
            return $"Hello, {firstName} {lastName}";
        }
        public string Goodbye(string firstName, string lastName)
        {
            return $"Goodbye, {firstName} {lastName}";
        }

    }
}
