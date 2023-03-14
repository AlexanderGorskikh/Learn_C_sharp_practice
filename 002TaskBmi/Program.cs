/*
Напишите функцию bmi, которая вычисляет индекс массы тела (ИМТ = вес / рост2).
если ИМТ <= 18,5, верните "Недостаточный вес"
если ИМТ <= 25,0, верните "Нормальный"
если ИМТ <= 30,0, верните "Избыточный вес"
если ИМТ> 30 возвращает "Ожирение"
*/

string Bmi(double weight, double height)
{ 
    double bmi = weight/Math.Pow(height,2);
    if(bmi<=18.5) return "Underweight";
    if(bmi<=25.0) return "Normal";
    if(bmi<=30.0) return "Overweight";
    if(bmi>30.0) return "Obese"; 
    return "";
}

System.Console.WriteLine("Введите вес: ");
double.TryParse(Console.ReadLine(),out double weight);
System.Console.WriteLine("Введите рост: ");
double height = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine($"Индекс вашего тела: {Bmi(weight, height)}");
