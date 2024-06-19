namespace TestApp2;

public class EmailGenerator
{
    private Random r;
 
    public EmailGenerator()
    {
        r = new Random();
    }
 
    private static string[] sampleNames = {
            "John", "Mary", "Michael", "Jennifer", "William", "Elizabeth",
            "David", "Patricia", "James", "Linda", "Robert", "Barbara",
            "Joseph", "Jessica", "Richard", "Sarah", "Thomas", "Karen",
            "Charles", "Nancy", "Daniel", "Margaret", "Matthew", "Lisa",
            "Anthony", "Betty", "Donald", "Dorothy", "Mark", "Sandra",
            "Paul", "Ashley", "Steven", "Kimberly", "Andrew", "Donna",
            "Kenneth", "Emily", "George", "Carol", "Joshua", "Michelle",
            "Kevin", "Amanda", "Brian", "Melissa", "Edward", "Deborah",
            "Ronald", "Stephanie", "Timothy", "Rebecca", "Jason", "Laura",
            "Jeffrey", "Sharon", "Ryan", "Cynthia", "Jacob", "Kathleen",
            "Gary", "Amy", "Nicholas", "Shirley", "Eric", "Angela",
            "Stephen", "Helen", "Jonathan", "Anna", "Larry", "Brenda",
            "Justin", "Pamela", "Scott", "Nicole", "Brandon", "Emma",
            "Benjamin", "Samantha", "Samuel", "Katherine", "Gregory", "Christine",
            "Frank", "Debra", "Alexander", "Rachel", "Raymond", "Carolyn",
            "Patrick", "Janet", "Jack", "Virginia", "Dennis", "Maria",
            "Jerry", "Heather", "Tyler", "Diane"
        };
 
    private string[] sampleSurnames = {
            "Smith", "Johnson", "Williams", "Brown", "Jones", "Miller",
            "Davis", "Garcia", "Rodriguez", "Martinez", "Hernandez", "Lopez",
            "Gonzalez", "Wilson", "Anderson", "Thomas", "Taylor", "Moore",
            "Jackson", "Martin", "Lee", "Perez", "Thompson", "White",
            "Harris", "Sanchez", "Clark", "Ramirez", "Lewis", "Robinson",
            "Walker", "Young", "Allen", "King", "Wright", "Scott",
            "Torres", "Nguyen", "Hill", "Flores", "Green", "Adams",
            "Nelson", "Baker", "Hall", "Rivera", "Campbell", "Mitchell",
            "Carter", "Roberts", "Gomez", "Phillips", "Evans", "Turner",
            "Diaz", "Parker", "Cruz", "Edwards", "Collins", "Reyes",
            "Stewart", "Morris", "Morales", "Murphy", "Cook", "Rogers",
            "Gutierrez", "Ortiz", "Morgan", "Cooper", "Peterson", "Bailey",
            "Reed", "Kelly", "Howard", "Ramos", "Kim", "Cox",
            "Ward", "Richardson", "Watson", "Brooks", "Chavez", "Wood",
            "James", "Bennett", "Gray", "Mendoza", "Ruiz", "Hughes",
            "Price", "Alvarez", "Castillo", "Sanders", "Patel", "Myers",
            "Long", "Ross"
        };
 
    public string GetRandomEmail()
    {
        return $"{sampleNames[r.Next(sampleNames.Length)]}.{sampleSurnames[r.Next(sampleSurnames.Length)]}@gmail.com";
    }
 
    public string[] GetRandomEmails(int count = 10)
    {
        string[] names = new string[10];
        for (int i = 0; i < names.Length; i++)
        {
            names[i] = $"{sampleNames[r.Next(sampleNames.Length)]}.{sampleSurnames[r.Next(sampleSurnames.Length)]}@gmail.com";
        }
        return names;
    }
}