namespace TestApp2;

class Program
{
    static void Main(string[] args)
    { 
        // 1. В баскетбольную команду могут быть приняты ученики, рост которых превышает 170 см.
        // Составьте список кандидатов в команду из учеников класса.
        // Student[] students = new Student[25];
        // NameGenerator generator = new NameGenerator();
        // Random random = new Random();
        // for (int i = 0; i < students.Length; i++)
        // {
        //     students[i] = new Student
        //     {
        //         Name = generator.GetRandomName(),
        //         Growth = random.Next(150, 200)
        //     };
        // }
        //
        // foreach (Student student in students)
        // {
        //     Console.WriteLine(student.Name + " " + student.Growth);
        // }
        //
        // Console.WriteLine();
        //
        // foreach (var student in GetBasketTeam(students))
        // {
        //     Console.WriteLine(student.Name + " " + student.Growth);
        // }
        
        
        // 2. Описать класс User, с полями: Id, Login, PasswordHash, Email.
        // В классе реализовать 2 метода сортировки: по Email-адресами и по Login. 
        // Создать массив пользователей на 5 элементов, вывести их в отсортированном порядке.
        // Методы сделать статичными. ПРИМЕЧАНИЕ: После вызова методов сортировки, изначальный массив,
        // должен иметь отсортированные значения в себе.
        // User[] users = new User[5];
        // EmailGenerator emailGenerator = new EmailGenerator();
        // NameGenerator nameGenerator = new NameGenerator();
        // for (int i = 0; i < users.Length; i++)
        // {
        //     users[i] = new User();
        //     users[i].Email = emailGenerator.GetRandomEmail();
        //     users[i].Login = nameGenerator.GetRandomName();
        // }
        //
        // foreach (User user in users)
        // {
        //     Console.WriteLine(user);
        // }
        //
        // Console.WriteLine();
        // users = sortUsersByLogin(users);
        // foreach (User user in users)
        // {
        //     Console.WriteLine(user);
        // }
        //
        // Console.WriteLine();
        // users = sortUsersByEmail(users);
        // foreach (User user in users)
        // {
        //     Console.WriteLine(user);
        // }
        
        
        // 3. Описать класс «Домашняя библиотека». Предусмотреть возможность работы с произвольным числом книг,
        // поиска книги по какому-либо признаку (например, по автору или по году издания),
        // добавления книг в библиотеку, удаления книг из нее, сортировки книг по разным полям.
        Library library = new Library();
        Book book1 = new Book()
        {
            Name = "Book1",
            Author = "Author1",
            Year = 2010
        };
        Book book2 = new Book()
        {
            Name = "Book2",
            Author = "Author2",
            Year = 2002
        };
        Book book3 = new Book()
        {
            Name = "Book3",
            Author = "Author3",
            Year = 1998
        };

        library.addBook(book1);
        library.addBook(book2);
        library.addBook(book3);
        library.print();
        
        Console.WriteLine();
        
        library.removeBook("Book1");
        library.print();
        
        Console.WriteLine();
        
        library.sortByYear();
        library.print();
        
        Console.WriteLine();
        foreach (Book book in library.findBookByName("Book2"))
        {
            Console.WriteLine(book);
        }

    }

    // 1
    static Student[] GetBasketTeam(Student[] students)
    {
        List<Student> team = new List<Student>();
        foreach (Student st in students)
        {
            if (st.Growth >= 170)
            {
                team.Add(st);
            }
        }

        return team.ToArray();
    }
    
    // 2
    static User[] sortUsersByLogin(User[] users)
    {
        return users.OrderBy(user => user.Login).ToArray();
    }
    
    static User[] sortUsersByEmail(User[] users)
    {
        return users.OrderBy(user => user.Email).ToArray();
    }
}
