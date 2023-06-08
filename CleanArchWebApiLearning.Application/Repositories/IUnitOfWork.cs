namespace CleanArchWebApiLearning.Application.Repositories;

interface IUnitOfWork
{
    Task Save(CancellationToken cancellationToken);
}