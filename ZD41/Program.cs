// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear(); 

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите число и нажмите Enter: ");
       int x = Convert.ToInt32(Console.ReadLine());
       array[i] = x;
    }

}

int ReleaseArray(int[] array) 
{     int count = 0;     
      for (int i = 0; i < array.Length; i++)     
      {         if (array[i] > 0)             
      count++;     
      }     
return count; } 


Console.Write("Cколько чисел будем вводить? "); 
int m = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int[m];
Console.WriteLine(" "); 
InputArray(array);

Console.WriteLine(" "); 
Console.Write("Чисел больше нуля: "); 
Console.WriteLine(ReleaseArray(array));