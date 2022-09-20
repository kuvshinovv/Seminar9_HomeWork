//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""
/* 
// Запрос данных пользователя
int ReadData(string line)
{
    Console.WriteLine(line);
    int num = int.Parse(Console.ReadLine() ?? "1");
    return num;
}
// Вывод Результата.
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}
// все натуральные числа в промежутке от M до N
string NumMN(int M, int N)
{
    if (M >= N) return N.ToString();
    return M.ToString()+ ", " + NumMN(M + 1, N);
  
}

int numM = ReadData("Введите число М: ");
int numN = ReadData("Введите число N: ");
string numbersMN = (numM<numN) ? NumMN(numM, numN):NumMN(numN, numM);
PrintData($"Числа от {numM} до {numN}: ", numbersMN);
 */








//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30




//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29

