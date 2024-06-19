namespace TestApp2;

public class Book
{
    public string Name;
    public string Author;
    public int Year;

    public override string ToString()
    {
        return "book name: " + Name + ", author: " + Author + ", year:" + Year;
    }
}