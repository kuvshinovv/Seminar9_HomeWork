// // посчитать сумму от 1 до 5

// int Sum(int N)
// {
//     if(N >= 5) return N;

//     return N+Sum(N+1); // рекурсия
// }

// int outNum = Sum(1);
// OutNnum = 15;



// Напишмте программу, которая выводит натуральные числа от 1 до N (Задача 63 и 64)
//________________________________________________________________________
/*  
// Запрос данных пользователя
int ReadData(string line)
{
    Console.WriteLine(line);
    int num = int.Parse(Console.ReadLine() ?? "1");
    return num;
}

// Рекурсивный вызов (Рекурсия числа от 1 до N)
string RecursOneToN(int num)
{
    if (num <= 1)
    {
        return "1";
    }
    else
    {
        string outLine = RecursOneToN(num - 1) + " " + num;
        return outLine;
    }

}

// Рекурсивный вызов (Рекурсия числа от N до 1)
string RecursNToOne(int num)
{
    if (num <= 1)
    {
        return "1";
    }
    else
    {
        string outLine = num + " " + RecursNToOne(num - 1) ;
        return outLine;
    }

}

// Вывод Результата.
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}

int inputNumber = ReadData("Введите число N: ");
string outLine1 = RecursOneToN(inputNumber);
string outLine2 = RecursNToOne(inputNumber); 
PrintData("Числа от 1 до N: ", outLine1);
PrintData("Числа от N до 1: ", outLine2);
 */




// Напишите программу которая будеи принимаьт на вход число и выводит сумму цифр этого числа
//_______________________________________________________
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

// Сумма цифр в числе через рекурсию
int SumRec(int N)
{
    int sum = 0;
    if(N<=0) return 0;  // точка остановки рекурсии
    else
    {
        return sum = N % 10 + SumRec(N / 10);
    }
}

// Сумма цифр в числе через While 
int SumWhile(int N)
{
    int sum = 0;
    while(N>0) 
    {
        sum = sum + N%10;
        N = N/10;
    }
    return sum;
}


int num = ReadData("Введите число: ");
DateTime d1 = DateTime.Now;
int sumDigits1 = SumRec(num);
PrintData("Сумма цифр в числе = ", sumDigits1.ToString());
PrintData("Время работы рекурсии = ", (DateTime.Now-d1).ToString());

DateTime d2 = DateTime.Now;
int sumDigits2 = SumWhile(num);
PrintData("Время работы цикла While = ", (DateTime.Now-d2).ToString());

 */





// №69  Напишите программу которая принимает на вход 2 числа А и Б , и возводит число А в степень Б
//__________________________________________________________________
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
// Возведение в степень рекурсией
long PowRec(int numA, int numB)
{
    if (numB <= 0) return 1;
    else
    {
        return numA * PowRec(numA, numB - 1);
    }
}
// Возведение в степень с разбиением пополам с рекурсией
long MyPowRec(int numA, int numB)
{
    if (numB == 2) return numA * numA;
    if (numB == 1) return numA;
    if (numB % 2 == 0)
    {
        return MyPowRec(numA, numB / 2) * MyPowRec(numA, numB / 2);
    }
    else
    {
        return MyPowRec(numA, numB / 2) * MyPowRec(numA, numB / 2+1);
    }
}

int numA = ReadData("Введите число А: ");
int numB = ReadData("Введите число Б: ");

DateTime d1 = DateTime.Now;
long resPow1 = PowRec(numA, numB);
PrintData("Время работы рекурсии = ", (DateTime.Now-d1).ToString());

DateTime d2 = DateTime.Now;
long resPow2 = MyPowRec(numA, numB);
PrintData("Время работы рекурсии с разбиением = ", (DateTime.Now-d2).ToString());

DateTime d3 = DateTime.Now;
long resPow3 = (long)Math.Pow(numA, numB);
PrintData("Время работы метода Math = ", (DateTime.Now-d3).ToString());

long result = PowRec(numA, numB);
PrintData("Число А в степень Б = ", result.ToString());

 */


