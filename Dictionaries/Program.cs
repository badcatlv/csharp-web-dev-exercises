//Exercises: Control Flow & Collections

//TODO: Write your code for Dictionary Practice below:
Dictionary<double, string> students = new Dictionary<double, string>();

Console.WriteLine("Hello, Dictionary!");

string newStudent;
do
{
    Console.WriteLine("Enter student name and ID (or Enter to finish): ");

    Console.WriteLine("Student Name: ");
    newStudent = Console.ReadLine();

    if (newStudent != "")
    {
        Console.WriteLine("ID: ");
        int newID = int.Parse(Console.ReadLine());
        students.Add(newID, newStudent);
    }
} while (newStudent != "");

Console.WriteLine("\nClass Roster -- ");
foreach (KeyValuePair<double, string> kvp in students)
{
    Console.WriteLine(kvp.Key + ": " + kvp.Value);
}
