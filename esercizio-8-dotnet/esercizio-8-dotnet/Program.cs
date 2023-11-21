Console.WriteLine("la parola è un palindromo?");

string userInput = "pAliNdrOm e";
string verificaPalindromo = "palindrome";

Console.WriteLine($"la parola è {userInput}");

string imputPulito = userInput.Replace(" ", "").ToLower();

bool isPalindromo = imputPulito == verificaPalindromo;

if (isPalindromo)
{
    Console.WriteLine("È un palindromo!");
}
else
{
    Console.WriteLine("Non è un palindromo.");
}
