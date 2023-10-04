// --------- Divide By Zero! ----------


static double Divide(double x, double y)
{
    if (y == 0)
    {
        throw new ArgumentOutOfRangeException("y");
    }
    else
    {
        return x / y;
    }
}


// Test out your Divide() function here!


// --------- Test Student Labs ----------


static int CheckFileExtension(string fileName)
{
    if (fileName == null || fileName == "") 
    {
        throw new ArgumentNullException("fileName", "Work not submitted");
    }
    else
    {
        if (fileName.Substring(fileName.Length - 3, 3) == ".cs")
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    //return //an int reping the # of points a student recieves for properly submitting a file

    //if // file ends in .cs they get +1
    //if no .cs ending +0
    //if file is null or empty string exception thrown
}


// Test out your CheckFileExtension() function here!

Dictionary<string, string> students = new Dictionary<string, string>
{
    { "Carl", "Program.cs" },
    { "Brad", "" },
    { "Elizabeth", "MyCode.cs" }
};



static void Print(Dictionary<string, string> dict) {
    foreach (KeyValuePair<string, string> kvp in dict)
    {
        CheckFileExtension(kvp.Value);
        Console.WriteLine(kvp.Key + kvp.Value);
    }
}

Print(students);

//Console.WriteLine(students.Values);

