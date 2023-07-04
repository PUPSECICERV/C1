// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Console.Write("Введите первое число:");
//double num1 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Введите второе число:");
//double num2 = Convert.ToDouble(Console.ReadLine());

//if (num1 / num2 == num2)
//{
//   Console.WriteLine("1 число является квадратом 2");
//}
//else
//{
//    Console.WriteLine("1 число не является квадратом 2");
//}

//Console.WriteLine("Введите номе дня недели: ");
//int num1 = Int32.Parse(Console.ReadLine());
//if(num1 == 1 ){
//    Console.WriteLine("Понедельник");
//}else if(num1 == 2){
//    Console.WriteLine("Вторник");
//}else if(num1 == 3){
//    Console.WriteLine("Среда");
//}else if(num1 == 4){
//    Console.WriteLine("Четверг");
//}else if(num1 == 5){
//    Console.WriteLine("Пятница");
//}else if(num1 == 6){
//    Console.WriteLine("Суббота");
//}else if(num1 == 7){
//    Console.WriteLine("Воскресенье");
//}else{
//    Console.WriteLine("Нет такого дня");
//}

//Console.WriteLine("Введите число: ");
//int num = Int32.Parse(Console.ReadLine());
//if(num < 0){
//    num = num * -1;
//}
//for(int x = -num; x <= num; x++){
//    Console.Write(x + " ");
//}

Console.WriteLine("Введите трехзначное число: ");
int num1 = Int32.Parse(Console.ReadLine());
Console.WriteLine(num1 % 10);

