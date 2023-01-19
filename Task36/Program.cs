// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на чётных позициях.


void GetSum()
{
  
    Console.Write("Введите количество элементов массива: ");
    int elements = int.Parse(Console.ReadLine());

    int[] myArray = new int [elements];
    
    int index = myArray[0];
    int sum = 0;

    for (index = 0; index < myArray.Length; index++)
        {        
            myArray[index] = new Random().Next(100);
            Console.Write(myArray[index]+" ");
            if ((double)index % 2 != 0) sum += myArray[index];
        }

    Console.WriteLine(sum);    

}    
GetSum();