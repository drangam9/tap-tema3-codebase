namespace Lab4Web.Services.Lambda
{
    public interface ILambdaService
    {

        string NoParameter();
        string OneParameter(string value);
        string TwoParameters(string value, int age);
        int UnusedParameters(int value1, int value2);
        string DefaultParameters(string value = "John");
        int TupleParameter(Tuple<int, int, int> value);
    }
}
