// connexion initializer syntax
string[] menuItems = 
[
    // index from start
    "Add a password", // 0
    "View your password",
    "Quit"
];

// selected menu item
int index = 0;
ConsoleKeyInfo key;

// iteration until user action
do
{
    // clean console for each iteration to display only the name file
    Console.Clear();
    
    // catch the value from menuItem variable into idx (unbuild syntax)
    // iterates on each index value
    foreach (var (idx, menuItem) in menuItems.Index())
    {
        if (idx == index)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        Console.WriteLine(menuItem);
        Console.ResetColor();
    }
    
    // catches the key pressed by the user
    key = Console.ReadKey();

    if (key.Key == ConsoleKey.UpArrow)
    {
        // remains locked on the first menu item even if the user presses the up key
        index = Math.Max(0, index -1);
    }
    else if (key.Key == ConsoleKey.DownArrow)
    {
        index = Math.Min(menuItems.Length - 1, index + 1);
    }
    else if (key.Key == ConsoleKey.Enter)
    {
        var choice = menuItems[index];
        Console.WriteLine(choice);
        Console.WriteLine("Please, tape enter to continue...");
        Console.ReadLine();
    }
}
while(key.Key != ConsoleKey.Escape);

Console.WriteLine("Program terminated!");