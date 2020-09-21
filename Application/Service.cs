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
            _repository.GetString(id)
                .FlatMapValue(value => _validator.Validate(value))
                .Match(onSuccess: value => _logger.WriteLine($"Successful execution: '{value}'."),
                    onFailure: error => _logger.WriteLine($"Failed execution: '{error}'."));
        }
    }
}