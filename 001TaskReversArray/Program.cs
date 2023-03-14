
// Преобразование числа в перевернутый массив цифр
// Учитывая случайное неотрицательное число, 
// вы должны вернуть цифры этого числа в массиве в обратном порядке.
// Пример (ввод => Вывод):
// 35231 => [1,3,2,5,3]
// 0 => [0]

long[] Digitize(long n)
{
    long size = 0;
    long current = n;
    if(n==0) size = 1;
    while(current>0)
    {
    size++;
    current/=10;
    }
    long[]array = new long[size];
    int i = 0;
    while(n>0)
    {
    array[i] = n%10;
    n/=10;
    i++;
    }
    return array;
}
System.Console.Write("Введите число: ");
long n = Convert.ToInt64(Console.ReadLine());
long [] array = Digitize(n);
System.Console.WriteLine($"{string.Join(" ",array)}");
