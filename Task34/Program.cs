// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

void GetCount()
{
  
    Console.Write("Введите количество элементов массива: ");
    int elements = int.Parse(Console.ReadLine());

    int[] myArray = new int [elements];
    
    int index = myArray[0];

    int count = 0;
    
    for (index = 0; index < myArray.Length; index++)
    {        
        myArray[index] = new Random().Next(100, 1000);
        if(myArray[index]%2==0)
        {
            count++;
        }        
    }
    
    Console.WriteLine($"Количество четных чисел: {count}");

}

GetCount();