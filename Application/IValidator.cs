namespace TCB.Option.Demo.Application
{
    internal interface IValidator
    {
        Result<ErrorMessage> Validate(string value);
    }
}