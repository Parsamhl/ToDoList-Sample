// See https://aka.ms/new-console-template for more information


using ToDoList_sample.DAL;
using ToDoList_sample.FrameWork;
using ToDoList_sample.Services;

AppDbContext appDbContext = new AppDbContext();
appDbContext.Database.EnsureCreated();
UserService userService = new UserService();
TaskService taskService = new TaskService();


string userName = "";
string password = "";
Result validation;

Console.WriteLine("To do list - Task Maneger ");

do
{
    Console.Clear();

    Console.Write("Enter Your user name :");
    userName = Console.ReadLine();

    Console.Write("Enter your password :");
    password = Console.ReadLine();

    validation = userService.PasswordValidation(userName, password);

    Console.ReadKey();

} while (!validation.Success);

while (true)
{
    Console.Clear();

    Console.WriteLine(" 1. Show Task list");
    Console.WriteLine("2. Show Your Active Tasks");
    Console.WriteLine("3. change active task status");
    Console.WriteLine("4. change password");
    Console.WriteLine("5. Log out");

    var option = Console.ReadKey();

    Console.Clear();
    switch (option.KeyChar)
    {
        case '1':
            break;
        case '2':
            break;
        case '3':
            break;
        case '4':
            break;
        case '5':
            break;

    }
}

void ShowTaskList()
{

}
