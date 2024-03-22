using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Mission_11_Stevens_OnlineBookstore.Models;

public class BookstoreContext : DbContext
{
    public BookstoreContext(DbContextOptions<BookstoreContext> options): base(options){ }

    public virtual DbSet<Book> Books { get; set; }

}
