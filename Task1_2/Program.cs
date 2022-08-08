// смотри описание в README.txt
 
Console.Write("Input number 1 : ");
int number1 =Convert.ToInt32( Console.ReadLine());
Console.Write("Input number 2 : ");
int number2 = Convert.ToInt32( Console.ReadLine());

// вариант1
if (number1>number2)
  { Console.WriteLine($"Max = {number1}");
    Console.WriteLine($"Min = {number2}");
  }  
 else
{ Console.WriteLine($"Max = {number2}");
  Console.WriteLine($"Min= {number1}");
} 

/* 2 вариант
int min = number1,
    max = number2;
if ( number1> number2 )
  {  min = number2;
     max = number1;
  }
  Console.WriteLine($"Max = {max}");
  Console.WriteLine($"Min = {min}");   
  */