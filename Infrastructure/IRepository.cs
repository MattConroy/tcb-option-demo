namespace TCB.Option.Demo.Infrastructure
{
    internal interface IRepository
    {
        Result<string, ErrorMessage> GetString(int id);
    }
}