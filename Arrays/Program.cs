//Exercises: Control Flow & Collections

//TODO: Write your code for Array Practice below:

Console.WriteLine("Hello, Arrays!");

int[] ints = { 1, 1, 2, 3, 5, 8 };

for (int i = 0; i < ints.Length; i++)
{
    if (ints[i] % 2 != 0)
    {
        Console.WriteLine(ints[i]);
    }
}

//Another example:
foreach (int num in ints)
{
    if (num % 2 == 1)
    {
        Console.WriteLine(num);
    }
}




Console.WriteLine(ints);