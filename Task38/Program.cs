// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.


void GetDif()
{
  
    Console.Write("Введите количество элементов массива: ");
    int elements = int.Parse(Console.ReadLine());

    int[] myArray = new int [elements];
    
    int index = myArray[0];
    
    for (index = 0; index < myArray.Length; index++)
        {        
            myArray[index] = new Random().Next(100);    
        }
    
    Console.WriteLine(myArray.Max() - myArray.Min());
}   

GetDif();