
void MainApp()
{
    Console.WriteLine("Введите коллсичество солбцов");
    int firstInput = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите коллсичество строк");
    int secondInput = Convert.ToInt16(Console.ReadLine());
    int[,] myArray = new int[firstInput, secondInput];
    Console.WriteLine("Таблица");

    for (int i = 0; i < firstInput; i++)
    {
        for (int j = 0; j < secondInput; j++)
        {
            Random random = new Random();
            myArray[i, j] = random.Next(0, 100);
        }
    }
    for (int i = 0; i < firstInput; i++)
    {
        for (int j = 0; j < secondInput; j++)
        {
            Console.Write(myArray[i, j]+ "\t");
        }
        Console.WriteLine("\t");
    }
}
while (true)
{
    MainApp();
}

