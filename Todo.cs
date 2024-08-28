
using System.Collections;

namespace Container_1
{

    class TodoItem
    {
        public int id = 0;
        public string title;
        public string description;
        public TodoItem(string title, string description)
        {
            Random random = new Random();
            id = random.Next(0, 1000);
            this.title = title;
            this.description = description;
        }
    }
    class TodoList
    {

        ArrayList todos;
        public TodoList()
        {
            todos = new ArrayList();
        }
        public void AddTodo()
        {
            string title = string.Empty;
            string description = string.Empty;
            Console.WriteLine("Enter title:");
            title = Console.ReadLine();
            Console.WriteLine("Enter Description:");
            description = Console.ReadLine();
            TodoItem item = new TodoItem(title, description);
            todos.Add(item);
        }
        public void DeleteTodo()
        {
            foreach (TodoItem obj in todos)
            {
                Console.WriteLine($"ID:{obj.id} Title:{obj.title}, Description:{obj.description}");

            }
            Console.WriteLine("Enter id to delete:");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (TodoItem item in todos)
            {
                if (item.id == id)
                {
                    this.todos.Remove(item);
                    Console.WriteLine("Item deleted successfully.");
                    break;
                }
            }
        }
        public void DisplayTodo()
        {
            if (todos.Count > 0)
            {
                foreach (TodoItem obj in todos)
                {
                    Console.WriteLine($"ID:{obj.id} Title:{obj.title}, Description:{obj.description}");
                }
            }
            else
            {
                Console.WriteLine($"List is currently empty.");
            }

        }
        public void ClearAllTodo()
        {
            this.todos.Clear();
            Console.WriteLine("All Items have been cleared.");
        }
        public void ClearScreen()
        {
            Console.Clear();
        }
    }

    class MainClass
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine($"*** Welcome to TO-DO List ***");
        }
        public static void Menu()
        {
            Console.WriteLine($"1- Add Todo");
            Console.WriteLine($"2- Delete Todo");
            Console.WriteLine($"3- Display Todo");
            Console.WriteLine($"4- Clear All Todo");
            Console.WriteLine($"5- Clear Screen");
            Console.WriteLine($"6- Exit");
            Console.WriteLine($"Please select your choice");
        }
        public static void ChoiceLogic(TodoList todos)
        {
            do
            {
                WelcomeMessage();
                Menu();
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        todos.AddTodo();
                        break;
                    case 2:
                        todos.DeleteTodo();
                        break;
                    case 3:
                        todos.DisplayTodo();
                        break;
                    case 4:
                        todos.ClearAllTodo();
                        break;
                    case 5:
                        todos.ClearScreen();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid Input");
                        return;
                }
            } while (true);

        }
        public static void MainLogic()
        {
            TodoList todos = new TodoList();
            ChoiceLogic(todos);
        }
        public static void Main()
        {

            MainLogic();
        }
    }
}