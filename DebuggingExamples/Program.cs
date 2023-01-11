// See https://aka.ms/new-console-template for more information

using DebuggingExamples;

var separator = new string('-', 10);
DisplayPattern();
PrintMessage(separator);
PalydromeWords();
PrintMessage(separator);
PrintNames();
PrintMessage(separator);
var evenNumbers = DisplayEvenNumbers();

foreach (var number in evenNumbers)
{
    PrintMessage(number.ToString());
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
    var names = new List<string> { "ana", "sun", "Mom", "moon", "pop", "river", "RedDer", "Reparer", "LeveL" };

    for (int i = 0; i < names.Count; i++)
    {
        if (VerifyWord(names[i]))
        {
            PrintMessage(names[i]);
        }
    }
}

void PrintNames()
{
    var names = new List<string> { "Marta", "Maria", "Bety", "Luis", "Juan", "Pedro" };
    for (int i = 0; i < names.Count; i++)
    {
        var name = names[i];
        PrintMessage(name);
    }
}

void PrintMessage(string message)
{
    Console.WriteLine(message);
}

bool VerifyWord(string word)
{
    var newWord = string.Empty;
    word = word.ToLower();
    for (int i = word.Length - 1; i > -1; i--)
    {
        newWord += word[i];
    }

    return newWord == word;
}

List<int> DisplayEvenNumbers()
{
    var numbers = new List<int>() { 2, 1, 3, 6, 4, 5, 9, 7, 10 };
    var evenNumbers = new List<int>();

    foreach (var number in numbers)
    {
        var module = number % 2;
        if (module == 0)
        {
            evenNumbers.Add(number);
        }
    }

    return evenNumbers;
}