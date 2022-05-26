// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string name;
int age;
Console.WriteLine("Как вас зовут?");
name = Console.ReadLine();
Console.WriteLine("Сколько вам лет?");
age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вас зовут - " + name + ". Вам " + age + " лет.");