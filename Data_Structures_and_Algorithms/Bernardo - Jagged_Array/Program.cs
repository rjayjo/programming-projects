int[][] jaggedArray =
{
    new int [3],
    new int [2],
    new int [2],
};

string quizScore = "QUIZ";
string assignScore = "ASSIGNMENT";
string examScore = "EXAM";

for (int i = 0; i < jaggedArray[0].Length; i++)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Enter " + quizScore + " Scores\n");
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.ResetColor(); 
        Console.Write(quizScore + " " + (j + 1) + ": ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        int scoreInput = int.Parse(Console.ReadLine());
        jaggedArray[i][j] = scoreInput;
    }
    if (jaggedArray[0].Length == 3)
    {
        quizScore = assignScore;
    }
    if (jaggedArray[0].Length == 3 && jaggedArray[1].Length == 2)
    {
        assignScore = examScore;
    }

    Console.WriteLine();
}

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\t\t\t\tSCORES SUMMARY\n");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("\t\t\tSCORES ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("\t\t\tAVERAGE\n");

quizScore = "      Quizzes";
assignScore = "    Assignments";
examScore = "   Examinations";

for (int i = 0; i < jaggedArray[0].Length; i++)
{
    double sum = 0.0, ave = 0.0;
    Console.ResetColor();
    Console.Write(quizScore + ": ");
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\t " + jaggedArray[i][j]);
        sum += jaggedArray[i][j];
    }
    ave = sum / jaggedArray[i].Length;

    if (jaggedArray[0].Length == 3)
    {
        quizScore = assignScore;
    }

    if (jaggedArray[0].Length == 3 && jaggedArray[1].Length == 2)
    {
        assignScore = examScore;
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\t\t" + ave);

}
    Console.ReadLine();




