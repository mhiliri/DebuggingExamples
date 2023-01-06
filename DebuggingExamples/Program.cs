// See https://aka.ms/new-console-template for more information

using DebuggingExamples;

DisplayPattern();
PalydromeWords();
var evenNumbers = DisplayEvenNumbers();

foreach (var number in evenNumbers)
{
    PrintMessage(number.ToString());
}

void StopHere() 
{
    PrintMessage("Hi!");
}

void PrintNumbers()
{
    var names = new List<string> { "Marta", "Maria","Bety","Luis","Juan", "Pedro"};
    for (int i = 0; i < names.Count; i++)
    {
        PrintMessage(names[i]);
    }
}

void PrintMessage(string message)
{
    Console.WriteLine(message);
}

void DisplayPattern()
{
    var size = 4;
    var message = string.Empty;

    for (int i = 1; i <= size; i++)
    {
        PrintMessage(message);
        message += i.ToString();
    }
}

void PalydromeWords()
{
    var names = new List<string> { "ana", "MoM", "pop", "RedDer", "Reparer", "LeveL" };

    for (int i = 0; i < names.Count; i++)
    {
        if (VerifyWord(names[i]))
        {
            PrintMessage(names[i]);
        }
    }
}

bool VerifyWord(string word)
{
    var newWord = string.Empty;
    for (int i = word.Length - 1; i > -1 ; i--)
    {
        newWord+= word[i];
    }
    
    return newWord == word;
}

List<int> DisplayEvenNumbers()
{ 
    var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
    var evenNumbers = new List<int>();

    foreach (var number in numbers)
    {
        var module = number % 2;
        if (module == 0)
        {
            evenNumbers.Add(module);
        }
        return evenNumbers;
    }

    return evenNumbers;
}