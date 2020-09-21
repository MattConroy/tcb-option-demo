namespace TCB.Option.Demo.Application
{
    internal sealed class Validator : IValidator
    {
        public bool Validate(string value)
        {
            return value.Length % 3 == 0;
        }
    }
}