namespace HamsterApp.API.Repo
{
    public interface IGenericRepository<T> where T : class
    {
        Task UpDateAsync(T entity);
    }
}
