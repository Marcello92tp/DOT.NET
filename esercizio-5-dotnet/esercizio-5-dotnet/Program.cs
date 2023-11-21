Console.Write("Inserisci il percorso del file: ");
string filePath = Console.ReadLine();

// Verifica se il percorso è assoluto o relativo
if (!Path.IsPathRooted(filePath))
{
    // verifica percorso assoluto
    filePath = Path.GetFullPath(filePath);
}
// se il file esiste
if (File.Exists(filePath))
{
    // prendo tutto il contenuto del file e invio a schermo
    string content = File.ReadAllText(filePath);
    Console.WriteLine("Contenuto del file:");
    Console.WriteLine(content);
}
else
{
    Console.WriteLine("Il file specificato non esiste.");
}
    

