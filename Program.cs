Console.Write("Name : ");
string name = Console.ReadLine();
Console.Write("Input Weight : ");
double weight = double.Parse(Console.ReadLine());
Console.Write("Input Height : ");
double height = double.Parse(Console.ReadLine());
double BMI1 = Math.Round(weight / Math.Pow(height / 100, 2), 2);
Console.WriteLine("name : {name} BMI = {BMI1}");