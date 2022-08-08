Console.Write("Input natural number  : ");
int number =Convert.ToInt32( Console.ReadLine());

if (number > 1)
{    
    int counter=2;
    Console.Write (number);
    Console.Write("-> ");
    while (counter<number)
    {
      Console.Write(counter);
      counter+=2;
      if (counter<=number) 
         Console.Write(" , ");
    }  
    if (counter==number) Console.Write(counter);
}
else Console.WriteLine("Nothing to print");