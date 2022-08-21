// Задача 37: Найдите произведение пар чисел в одномерном массиве. 	
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 	
// Результат запишите в новом массиве.	
// [1 2 3 4 5] -> 5 8 3	
// [6 7 3 6] -> 36 21	

int[] array = { 2, 2, 3, 4, 5 };

int[] resArray = new int[(array.Length + 1) / 2]; 
for (int i=0; i<resArray.Length;i++ )   // заполнение нового массива
{
    resArray[i] = array[i] * array[array.Length - 1 - i]; // по формуле  

}

if (array.Length % 2 != 0) // если в нечетном массиве нечетное количество элементов (or ==1)

{
 resArray[resArray.Length - 1]= array[array.Length / 2]; // последний элемент нового массива присваевается 
                                                // средний элемент начального  

}

Console.WriteLine(string.Join(", ", array));

Console.WriteLine(" ");
Console.WriteLine(string.Join(", ", resArray));


