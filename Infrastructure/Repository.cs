namespace TCB.Option.Demo.Infrastructure
{
    internal sealed class Repository : IRepository
    {
        public string GetString(int id)
        {
            if (id % 2 != 0)
                throw new MissingStringException(id);

            return new string('*', id);
        }
    }
}