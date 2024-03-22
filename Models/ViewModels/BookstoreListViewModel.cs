namespace Mission_11_Stevens_OnlineBookstore.Models.ViewModels
{
    public class BookstoreListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}
