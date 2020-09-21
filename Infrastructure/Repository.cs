namespace TCB.Option.Demo.Infrastructure
{
    internal sealed class Repository : IRepository
    {
        public Result<string, ErrorMessage> GetString(int id)
        {
            if (id % 2 == 0)
                return Result.SuccessOf(new string('*', id));

            return Result.FailureOf($"Value must be even. '{id}'");
        }
    }
}