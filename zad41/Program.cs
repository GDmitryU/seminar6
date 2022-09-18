//  Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int AmountPositiveNumbers(int M)

{
int count = 0;   
 for (int i=1;i<= M;i++)
     {
        Console.Write($"Введите  {i} число ");
        int positive = int.Parse(Console.ReadLine());
    
         if (positive > 0) 
         {
            count+=1;
         }
        
    }

    return count;
}
    
Console.Write("Введите количество чисел ");
int amountnumber = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество положительных элементов массива = {AmountPositiveNumbers( amountnumber)}");    


