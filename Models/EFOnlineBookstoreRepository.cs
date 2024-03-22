namespace Mission_11_Stevens_OnlineBookstore.Models
{
    public class EFOnlineBookstoreRepository : IOnlineBookstoreRepository
    {
        private BookstoreContext _context;
        
        public EFOnlineBookstoreRepository(BookstoreContext context)
        {
            _context = context;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}
