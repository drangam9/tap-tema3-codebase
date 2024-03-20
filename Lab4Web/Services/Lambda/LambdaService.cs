namespace Lab4Web.Services.Lambda
{
    public class LambdaService : ILambdaService
    {
        public int Test1(int value)
        {
            return value * 100;
        }
    }
}
