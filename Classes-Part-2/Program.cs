//Classes part 2 exercises

// TODO: Test your exercise solutions with print statements here.
using Classes_Part_2;

Student Colleen = new Student("Colleen", 4, 20, 3.5);
Console.WriteLine(Colleen.ToString());

Student Bob = new Student("Bob", 4, 20, 4.0);
Console.WriteLine(Bob.ToString());

Console.WriteLine("Colleen and Bob are the same student based on their ID: " + Bob.Equals(Colleen));
