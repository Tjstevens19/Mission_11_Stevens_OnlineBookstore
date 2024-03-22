namespace Mission_11_Stevens_OnlineBookstore.Models
{
    public interface IOnlineBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
