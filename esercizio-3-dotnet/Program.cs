
Console.WriteLine("inserisci i due numeri");
string? num1 = Console.ReadLine();

string? num2 = Console.ReadLine();

bool conv1 = int.TryParse(num1, out int result1);

bool conv2 = int.TryParse(num2, out int result2);
int sum = result1+result2;

Console.WriteLine("la somma dei due numeri è: " + sum);
