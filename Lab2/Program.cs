
void MainApp()
{
//  Исходные данные: потребление каждого из М ресурсов на каждом из К предприятий. Данные определяются 
//  путем обращения к датчику случайных чисел. Задание:
//  а. Для любого ресурса определить среднее значение его потребления.
//  б. Для любого предприятия определить ресурс наибольшего потребления.
    Console.WriteLine("Введите коллсичество солбцов");
    int firstInput = Convert.ToInt16(Console.ReadLine()); //K
    Console.WriteLine("Введите коллсичество строк");
    int secondInput = Convert.ToInt16(Console.ReadLine());//M
    int[,] myArray = new int[firstInput, secondInput];
    Console.WriteLine("Таблица");
    int sum = firstInput + secondInput;
    int[] allEquip = new int[sum];
    int[] sredValueRes = new int[sum];

    int taskAstrRes(int[] allValue, int colum) // функция для задания 1
    {
        for (int i = 0; i < secondInput; i++)
        {
            allValue[i] += myArray[colum, i];
        }
        return allValue[colum] / firstInput;
    }

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
            allEquip[i] += myArray[i, j];
        }
        Console.WriteLine("\t");
    }

    int[] tasks = new int[sum];
    for (int i = 0; i < firstInput; i++)
    {
        tasks[i] = taskAstrRes(sredValueRes, i); // задание 1
        Console.WriteLine("ресурс:" + (secondInput + 1) + " ,сред значение - " + tasks[i]);
    }
    


    Console.WriteLine("Общ расход потребления ресурсов предприятий");
    for (int i = 0;i < firstInput; i++)
    {
        Console.WriteLine("Предприятие: " + (i+1) + ", общее колличество: " +allEquip[i]);
    }

}
while (true)
{
    MainApp();
}

