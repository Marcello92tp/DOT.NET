﻿Console.WriteLine("Insert your first number");
string numbA = Console.ReadLine();
int a = int.Parse(numbA);

Console.WriteLine("Insert the operator for your operation");
string calcOp = Console.ReadLine();
if(calcOp.Length != 1 )
{
    Console.WriteLine("invalid input, try again.");
    Environment.Exit(1);
    return;
}

Console.WriteLine("insert your second number");
string numbB = Console.ReadLine();
int b = int.Parse(numbB);


int result;
char charOperator = calcOp.First();
if (charOperator == '+')
{
    result = a + b;
}
else if(charOperator == '-') 
{  
    result = a - b; 
}
else if(charOperator == '*') 
{  
    result = a * b; 
}
else if(charOperator == '/')
{ 
    result = a / b;
}
else if(charOperator == '%') 
{  
    result = a % b; 
}
else {
    Console.WriteLine("invalid input, try again.");
    Environment.Exit(1);
    return;
}



Console.Write($"{a} {calcOp} {b} = ");
Console.WriteLine(result); 
