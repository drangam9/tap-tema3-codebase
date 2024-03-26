namespace Lab4Web.Services.Lambda
{
    public class LambdaService : ILambdaService
    {

        public string NoParameter()
        {
            var lambdaNoParameter = new Func<string>(() => $"Welcome! Today's date is {DateTime.Today}");
            return lambdaNoParameter();
        }
        public string OneParameter(string value)
        {
            var lambdaOneParameter = new Func<string, string>((v) => v[0].ToString().ToUpper() + v.Substring(1).ToLower());
            return lambdaOneParameter(value);
        }
        public string TwoParameters(string value, int age)
        {
            var lambdaTwoParameters = new Func<string, int, string>((v, a) => $"{v} is {a} years old");
            return lambdaTwoParameters(value, age);
        }
        public int UnusedParameters(int value1, int value2)
        {
            Func<int, int, int> lambdaUnusedParams = (_, _) => { return 42; };
            return lambdaUnusedParams(value1, value2);
        }
        public string DefaultParameters(string value = "John")
        {
            Func<string, string> lambdaDefaultParams = (v) =>
            {
                if (value == "John")
                {
                    return "Default name: John";
                }
                return "Name: " + v;
            };
            return lambdaDefaultParams(value);
        }
        public int TupleParameter(Tuple<int, int, int> value)
        {
            var lambdaExpression = new Func<Tuple<int, int, int>, int>((v) => v.Item1 * 100 + v.Item2 * 10 + v.Item3);
            return lambdaExpression(value);
        }
    }
}
