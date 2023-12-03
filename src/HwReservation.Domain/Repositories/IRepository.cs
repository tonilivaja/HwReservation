using HwReservation.Domain.Entities;

namespace HwReservation.Domain.Repositories;

public interface IRepository<TEntity>
    where TEntity : class, IEntity
{
    IQueryable<TEntity> GetAll();
}
