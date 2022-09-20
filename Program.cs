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
// Считаем сумму элементов в промежутке от М до N
int SumMN(int numM, int numN)
{
    
    if (numM>=numN) return numN;
    return numM + SumMN(numM+1, numN);
}

int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
int summaMN = (numM<numN) ? SumMN(numM, numN):SumMN(numN, numM);
PrintData($"Сумма элементов от {numM} до {numN} = ",summaMN.ToString());

 */


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29

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
// Вычисление функции Аккермана
int AkermanFunc(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    else if ((numM > 0) && (numN == 0))
    {
        return AkermanFunc(numM - 1, 1);
    }
    else if ((numM > 0) && (numN > 0))
    {
        return AkermanFunc(numM - 1, AkermanFunc(numM, numN - 1));
    }
    return AkermanFunc(numM, numN);
}

int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");

//если вдруг отрицательные числа ввели
if (numM < 0 || numN < 0)
{
    Console.WriteLine("Вы ввели отрицательное число!!! Автоматически переведем его в положительное!!!");
    numM = Math.Abs(numM);
    numN = Math.Abs(numN);
    int akerman = AkermanFunc(numM, numN);
    PrintData("Результат вычисления функции Аккермана с помощью рекурсии = ", akerman.ToString());
}
else
{
    int akerman = AkermanFunc(numM, numN);
    PrintData("Результат вычисления функции Аккермана с помощью рекурсии = ", akerman.ToString()); 
}
