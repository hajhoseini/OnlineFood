using Microsoft.EntityFrameworkCore;


namespace OnlineFood.Common.Interfaces
{
    public interface IOnlineFoodDBContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
