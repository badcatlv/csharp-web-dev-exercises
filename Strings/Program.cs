//Exercises: Control Flow & Collections

//TODO: Write your code for String Practice below:

Console.WriteLine("Hello, Strings!");

//Exercises: Control Flow & Collections

//TODO: Write your code for String Practice below:

Console.WriteLine("Hello, Strings!");

string sentence = "I would not, could not, in a box. " +
    "I would not, could not with a fox. I will not eat them in a house. " +
    "I will not eat them with a mouse.";

string[] words = sentence.Split(" ");

//Console.WriteLine(string.Join(",", words));

string[] words2 = sentence.Split(". ");
//Console.WriteLine(string.Join(",", words2));

List<string> words3 = sentence.Split(". ").ToList();

for (int i = 0; i < words3.Count; i++)
{
    Console.WriteLine(words3[i]);
}
Console.WriteLine(words3[0] + "\n" + words3[1] + "\n" + words3[2] + "\n" + words3[3]);