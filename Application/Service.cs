using TCB.Option.Demo.Infrastructure;

namespace TCB.Option.Demo.Application
{
    internal class Service : IService
    {
        private readonly IRepository _repository;
        private readonly IValidator _validator;
        private readonly ILogger _logger;

        public Service(IRepository repository, IValidator validator, ILogger logger)
        {
            _repository = repository;
            _validator = validator;
            _logger = logger;
        }

        public void Execute(int id)
        {
            var retrievedValue = _repository.GetString(id);

            _logger.WriteLine($"({id}) Retrieved '{retrievedValue}'.");

            var isValid = _validator.Validate(retrievedValue);

            _logger.WriteLine($"'{retrievedValue}' is {(isValid ? "" : "not ")}valid.");
        }
    }
}