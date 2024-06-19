namespace TestApp2;

public class User
{
    public string Id = Guid.NewGuid().ToString();
    public string Login;
    public string PasswordHash = Guid.NewGuid().ToString();
    public string Email;

    public override string ToString()
    {
        return Id + " - " + Login + ": " + Email;
    }
}