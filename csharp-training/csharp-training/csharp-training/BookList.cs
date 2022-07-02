namespace CSharpTraining;

public class BookList
{
    private List<Book> _bookList;

    public List<Book> bookList
    {
        get { return _bookList; }
        set { _bookList = value; }
    }

    public BookList()
    {
        bookList = new List<Book>();
    }

    public void AddBook(Book book)
    {
        bookList.Add(book);
    }

    public Book this[int index]
    {
        get => bookList[index];
    }
}