namespace TestApp2;

public class Library
{
    public List<Book> Books = new List<Book>();

    public void addBook(Book newBook)
    {
        Books.Add(newBook);
    }
    
    public void removeBook(string name)
    {
        Book deleteBook = Books.Single(item => item.Name == name);
        Books.Remove(deleteBook);
    }

    public void sortByName()
    {
        Books = Books.OrderBy(item => item.Name).ToList();
    }
    
    public void sortByYear()
    {
        Books = Books.OrderBy(item => item.Year).ToList();
    }
    
    public void sortByAuthor()
    {
        Books = Books.OrderBy(item => item.Author).ToList();
    }

    public List<Book> findBookByName(string bookName)
    {
        return Books.Where(item => Equals(item.Name, bookName)).ToList();
    }
    
    public List<Book> findBookByAuthor(string bookAuthor)
    {
        return Books.Where(item => Equals(item.Name, bookAuthor)).ToList();
    }

    public void print()
    {
        foreach (Book book in Books)
        {
            Console.WriteLine(book);
        }
    }
}