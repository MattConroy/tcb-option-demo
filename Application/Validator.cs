namespace TCB.Option.Demo.Application
{
    internal sealed class Validator : IValidator
    {
        public Result<ErrorMessage> Validate(string value)
        {
            if (value.Length % 3 != 0) 
                return Result.Failure("Value must be multiple of 3.");

            if (value.Length % 5 != 0)
                return Result.Failure("Value must be multiple of 5.");

            return Result.Success();
        }
    }
}