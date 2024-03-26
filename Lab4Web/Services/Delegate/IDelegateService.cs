namespace Lab4Web.Services.Delegate
{
    public interface IDelegateService
    {
        string Introduction(string value, string value2, Func<string, string, string> callback);
        string Hello(string firstName, string lastName);
        string Goodbye(string firstName, string lastName);
    }
}
