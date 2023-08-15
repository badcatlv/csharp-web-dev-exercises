//Exercises: Control Flow & Collections

//TODO: Write your code for List Practice below:

Console.WriteLine("Hello, Lists!");

static int sumEven(List<int> arr)
{
    int total = 0;
    foreach (int i in arr)
    {
        if (i % 2 == 0)
        {
            total += i;
        }

    }
    return total;
}

List<int> sum = new List<int> { 3, 6, 9, 24, 1, 88, 43, 67, 18, 2 };

Console.WriteLine(sumEven(sum));

static void numLetterWord(List<string> arr)
{
    Console.WriteLine("Choose a number between 1 and 7: ");
    string input = Console.ReadLine();
    int inputInt = int.Parse(input);
    foreach (string s in arr)
    {
        if (s.Length == inputInt)
        {
            Console.WriteLine(s);
        }
    }
}

List<string> strings = new List<string> { "hello", "bye", "focus", "dog", "raccoon" };
numLetterWord(strings);

//Another Example--- keeps the original method which is a drier code.

//Console.WriteLine("Enter a word length: ");
//string numInput = Console.ReadLine();
//int numChars = int.Parse(numInput);

//// Call the method to print out list words of the chosen length:
//printXLetterWords(wordList, numChars);


//static void printXLetterWords(List<string> wordlist, int length)
//{
//    foreach (string word in wordlist)
//    {
//        if (word.Length == length)
//        {
//            Console.WriteLine(word);
//        }
//    }
//}

