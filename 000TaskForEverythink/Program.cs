// Упражнение 1
// Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа.
// А программа сранивает два введенных числа и выводит на консоль результат сравнения
// (два числа равны, первое число больше второго или первое число меньше второго).
/*
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
void PrintDiffn1n2(int num1,int num2)
{
    if(num1>num2) Console.WriteLine($"{num1}>{num2}");
    else if(num1==num2) Console.WriteLine($"{num1}={num2}");
    else Console.WriteLine($"{num1}<{num2}");
}
PrintDiffn1n2(num1, num2);
*/
// Упражнение 2
// Напишите консольную программу, в которую пользователь вводит с клавиатуры число.
// Если число одновременно больше 5 и меньше 10,
// то программа выводит "Число больше 5 и меньше 10".
// Иначе программа выводит сообщение "Неизвестное число".
/*
void PrintNum (int number)
{
    if(number>5 && number<10) Console.WriteLine("Число больше 5 и меньше 10");
    else Console.WriteLine("Неизвестное число");
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNum (number);
*/
// Упражнение 3
// Напишите консольную программу, в которую пользователь вводит с клавиатуры число. 
// Если число либо равно 5, либо равно 10, 
// то программа выводит "Число либо равно 5, либо равно 10". 
// Иначе программа выводит сообщение "Неизвестное число".
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
void PrintNum (int number)
{
    if(number==5 || number==10) Console.WriteLine("Число равно 5 или равно 10");
    else Console.WriteLine("Неизвестное число");
}
PrintNum (number);
*/
// Упражнение 4
// В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться. 
// Напишите консольную программу, в которую пользователь вводит сумму вклада. 
// Если сумма вклада меньше 100, то начисляется 5%. Если сумма вклада от 100 до 200, 
// то начисляется 7%. Если сумма вклада больше 200, то начисляется 10%.
// В конце программа должна выводить сумму вклада с начисленными процентами.
// Для получения вводимого с клавиатуры числа используйте выражение 
// Convert.ToDouble(Console.ReadLine())
/*
bool IsPositive (double num)
{
    if(num<0) return false;
    return true;
}
double DepositAmount (double deposit)
{
    double percent =0;
    if(deposit<100) percent = deposit* 0.05;
    else if(deposit>100 && deposit<200) percent = deposit* 0.07;
    else percent = deposit* 0.1;
    return deposit + percent;
}
Console.Write("Введите сумму вклада: ");
double deposit = Convert.ToDouble(Console.ReadLine());
if(IsPositive (deposit)) Console.WriteLine(DepositAmount (deposit));
else System.Console.WriteLine("Вы ввели отрицательное число");
*/
// Упражнение 6
// Напишите консольную программу, которая выводит пользователю сообщение
// "Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение".
// Рядом с названием каждой операции указан ее номер, например,
// операция вычитания имеет номер 2. 
// Пусть пользователь вводит в программу номер операции, и в зависимости от номера операции 
// программа выводит ему название операции.
// Для определения операции по введенному номеру используйте конструкцию switch...case.
// Если введенное пользователем число не соответствует никакой операции 
// (например, число 120), то выведите пользователю сообщение о том, что операция неопределена.
/*
Console.Write("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение: ");
short operation = Convert.ToInt16(Console.ReadLine());
switch(operation)
{
    case 1:
    System.Console.WriteLine("Сложение");
    break;
    case 2:
    System.Console.WriteLine("Вычитание");
    break;
    case 3:
    System.Console.WriteLine("Умножение");
    break;
}
*/
// Упражнение 7
// Измените предыдущую программу. Пусть пользователь кроме номера операции вводит два числа,
// и в зависимости от номера операции с введенными числами выполняются 
// определенные действия (например, при вводе числа 3 числа умножаются). 
// Результ операции выводиться на консоль.

/*
Console.Write("Введите первое число: ");
short num1 = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение: ");
short operation = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите второе число: ");
short num2 = Convert.ToInt16(Console.ReadLine());
switch(operation)
{
    case 1:
    System.Console.WriteLine($"Сумма чисел равна: {num1+num2}");
    break;
    case 2:
    System.Console.WriteLine($"Разность чисел равна: {num1-num2}");
    break;
    case 3:
    System.Console.WriteLine($"Произведение чисел равно: {num1*num2}");
    break;
}
*/