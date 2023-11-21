int conversione;
double temperatura; 
double risultato;

Console.WriteLine("Programma di Conversione delle Temperature");
Console.WriteLine("[ 1 ] Calcolo Celsius a Fahrenheit");
Console.WriteLine("[ 2 ] Calcolo Fahrenheit a Celsius");
Console.Write("Inserisci la scelta 1 o 2");
Console.ReadLine();

if (int.TryParse(Console.ReadLine(), out conversione))
{
    switch (conversione)
    {
        case 1:
            Console.WriteLine("Inserisci la temperatura in Celsius: ");
            temperatura = Convert.ToDouble(Console.ReadLine());
            risultato = temperatura * 1.8 + 32;
            Console.WriteLine($"Temperatura in Fahrenheit: {risultato}°F");
            break;

        case 2:
            Console.WriteLine("Inserisci la temperatura in Fahrenheit: ");
            temperatura = Convert.ToDouble(Console.ReadLine());
            risultato = (temperatura - 32) * 0.5556;
            Console.WriteLine($"Temperatura in Celsius: {risultato}°C");
            break;

        default:
            Console.WriteLine("Scelta non valida. Inserisci solo 1 o 2.");
            break;
    }
}
else
{
    Console.WriteLine("Scelta non valida. Inserisci un numero valido.");
}