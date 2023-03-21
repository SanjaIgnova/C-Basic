
using SEDC.Homeworks.Homework_5.Task3.Class;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Json;

User[] users = new User[]
{
    new User() {Id = 10, Username = "Sanja", Password = "12456", Messages = new string[] {"Hello Sanja", "Hi there"}},
    new User() { Id = 15,Username = "Nikola", Password = "mypassword", Messages = new string[] {"Welcome Nikola", "How are you today?" } },
    new User() { Id = 20, Username = "Marija", Password = "marija2", Messages = new string [] {"You are login now", "Now you can search!"}}
};


User FindUser(User[]users, string username, string password)
{
    foreach(User user in users)
    {
        if (user.Username.ToLower() == username.ToLower() && user.Password == password)
        {
            return user;
        }
        
    }
    return null;
}
void LogIn(User[] users, string username, string password)
{
    User user = FindUser(users, username, password);
    if(user == null)
    {
        Console.WriteLine("The user is not found!");
        return;
    } else
    {
        Console.WriteLine($"Welcome {user.Username}");
        Console.WriteLine($"Here is your message:");
        foreach (string message in user.Messages)
        {
            Console.WriteLine(message);
        }
    }
}

void RegisterUser(User[] users, string username, string password, int id)
{
    User user = FindUser(users, username, password);
    if (user != null)
    {
        Console.WriteLine("The user alredy exisits!");
    }
    
     Array.Resize(ref users, users.Length + 1);
     users[users.Length - 1] = new User() { Id = id, Username = username, Password = password};
     Console.WriteLine("You are successfully registered!");
     foreach (User newUser in users)
     {
         Console.WriteLine($"Id: {newUser.Id}, Username: {newUser.Username}");
     }
   
}


    
while (true)
{
    Console.WriteLine("Plase enter \n1) for Login of \n2) for Register or \n3 for exit");
    int choise;
    bool input = int.TryParse(Console.ReadLine(), out choise);
 
    if (choise == 1)
    {
        Console.WriteLine("Plase enter username:");
        string username = Console.ReadLine();
        Console.WriteLine("Plase enter password");
        string password = Console.ReadLine();
        LogIn(users, username, password);
      
    }
    else if (choise == 2)
    {
        Console.WriteLine("Plase enter username:");
        string newUserName = Console.ReadLine();
        Console.WriteLine("Plase enter password:");
        string newPassword = Console.ReadLine();
        Console.WriteLine("Plase enter your Id:");
        int newId = int.Parse(Console.ReadLine());
        RegisterUser(users, newUserName, newPassword, newId);
       
    }
    else if (choise == 3)
    {
        Console.WriteLine("See you next time! Bye Bye! ");
        break;
    }
    else
    {
        Console.WriteLine("You enter something wrong!");
       break;
    }
}

// koga ke vnesam nov user mi go registrira i posle pak koga ke vnesam nov posledniot mi go brise i mi go zamneuva so noviot.
