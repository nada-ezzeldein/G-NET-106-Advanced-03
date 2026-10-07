namespace C__Advanced_Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Student Grade Manager
            //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            //Console.WriteLine($"Grades: {string.Join(", ", grades)}");
            //Console.WriteLine($"Count: {grades.Count}");
            //Console.WriteLine($"First Grade: {grades.First()}");
            //Console.WriteLine($"Last Grade: {grades.Last()}");   

            //grades.Sort();
            //Console.WriteLine($"Sorted Grades: {string.Join(", ", grades)}");

            //int firstAbove90 = grades.First(g => g > 90);
            //Console.WriteLine($"First grade above 90: {firstAbove90}");

            //IEnumerable<int> failingGrades = grades.Where(g => g < 75);
            //Console.WriteLine($"Failing grades: {string.Join(", ", failingGrades)}");

            //grades.RemoveAll(g => g < 75);
            //Console.WriteLine($"Grades after removing failing grades: {string.Join(", ", grades)}");

            //bool hasPerfectScore = grades.Any(g => g == 100); 
            //Console.WriteLine($"Has any grade equal to 100? {hasPerfectScore}");

            //List<string> formattedGrades = grades.Select(g => $"Grade: {g}").ToList();

            //Console.WriteLine("Formatted Grade List:");
            //foreach (string gradeStr in formattedGrades)
            //{
            //    Console.WriteLine(gradeStr);
            //}

            #endregion

            #region Leaderboard
        //    SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>()
        //{
        //    { 500, "Ahmed" },
        //    { 200, "Sara" },
        //    { 800, "Ali" },
        //    { 350, "Mona" }
        //};

        //    Console.WriteLine("--- Sorted Leaderboard ---");
        //    foreach (KeyValuePair<int, string> entry in leaderboard)
        //    {
        //        Console.WriteLine($"Score: {entry.Key} -> Player: {entry.Value}");
        //    }

        //    Console.WriteLine("\n--- First Key and First Value ---");
        //    int firstKey = leaderboard.Keys.First();
        //    string firstValue = leaderboard.Values.First();
        //    Console.WriteLine($"First Key: {firstKey}");
        //    Console.WriteLine($"First Value: {firstValue}");

        //    Console.WriteLine("\n--- Check if Score 500 Exists ---");
        //    bool exists500 = leaderboard.ContainsKey(500);
        //    Console.WriteLine($"Does score 500 exist? {exists500}");

        //    Console.WriteLine("\n---Get Player with Score 999 ---");
        //    if (leaderboard.TryGetValue(999, out string player999))
        //    {
        //        Console.WriteLine($"Player with score 999: {player999}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("not found");
        //    }

        //    Console.WriteLine("\n--- Remove Score 200 & Print Updated List ---");
        //    leaderboard.Remove(200);

        //    Console.WriteLine("Updated Leaderboard:");
        //    foreach (var entry in leaderboard)
        //    {
        //        Console.WriteLine($"Score: {entry.Key} -> Player: {entry.Value}");
        //    }
            #endregion

        }
    }
}
