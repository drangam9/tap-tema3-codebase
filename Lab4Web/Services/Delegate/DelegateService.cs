namespace Lab4Web.Services.Delegate
{
    public class DelegateService : IDelegateService
    {
        public int Test1(int value)
        {
            return value * 10;
        }
    }
}
