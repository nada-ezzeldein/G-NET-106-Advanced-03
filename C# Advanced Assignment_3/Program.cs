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

            #region Phone Book
            //    Dictionary<string, string> phoneBook = new Dictionary<string, string>()
            //{
            //    { "Nada", "01029098734" },
            //    { "Rawan", "01005133160" },
            //    { "Mai", "01062876092" },
            //    { "Sara", "01021623461" }
            //};

            //    phoneBook["Mom"] = "01069778649";

            //    try
            //    {
            //        phoneBook.Add("Nada", "01029098734");
            //    }
            //    catch (ArgumentException ex)
            //    {
            //        Console.WriteLine($"Caught expected error: {ex.Message}");
            //    }

            //    bool isAdded = phoneBook.TryAdd("Nada", "01029098734");
            //    Console.WriteLine($"Did TryAdd succeed for 'Nada'? {isAdded}");

            //    string searchName = "Dad";
            //    bool exists = phoneBook.ContainsKey(searchName);
            //    Console.WriteLine($"Is '{searchName}' in the phone book? {exists}");

            //    string targetName = "Khaled";

            //    string phoneNumber = phoneBook.TryGetValue(targetName, out string number)
            //        ? number
            //        : "Not Found";

            //    Console.WriteLine($"Phone number for '{targetName}': {phoneNumber}");

            //    Console.WriteLine("Keys:   " + string.Join(", ", phoneBook.Keys));
            //    Console.WriteLine("Values: " + string.Join(", ", phoneBook.Values));
            #endregion

            #region Unique Email Validator
            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            //emails.Add("ahmed@test.com");
            //emails.Add("AHMED@test.com");
            //emails.Add("sara@test.com");
            //emails.Add("Sara@Test.Com");

            //Console.WriteLine($"Emails Count: {emails.Count}");
            //// 2 because HashSet only stores unique elements

            //HashSet<int> unionSet = new HashSet<int> { 1, 2, 3, 4, 5 };
            //HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };
            //unionSet.UnionWith(setB);
            //Console.WriteLine($"UnionWith (A & B): {string.Join(", ", unionSet)}");

            //HashSet<int> intersectSet = new HashSet<int> { 1, 2, 3, 4, 5 };
            //intersectSet.IntersectWith(setB);
            //Console.WriteLine($"IntersectWith (A & B): {string.Join(", ", intersectSet)}");

            //HashSet<int> exceptSet = new HashSet<int> { 1, 2, 3, 4, 5 };
            //exceptSet.ExceptWith(setB);
            //Console.WriteLine($"ExceptWith (A - B): {string.Join(", ", exceptSet)}");

            //HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            //HashSet<int> subSet = new HashSet<int> { 1, 2 };

            //bool isSubset = subSet.IsSubsetOf(setA);
            //Console.WriteLine($"\nIs {{1, 2}} a subset of Set A? {isSubset}");
            #endregion

            #region Queue Simulator
            //Queue<string> printQueue = new Queue<string>();
            //printQueue.Enqueue("Report.pdf");
            //printQueue.Enqueue("Invoice.pdf");
            //printQueue.Enqueue("Letter.docx");
            //printQueue.Enqueue("Resume.pdf");
            //printQueue.Enqueue("Photo.jpg");

            //Console.WriteLine($"Queue Contents: {string.Join(", ", printQueue)}");
            //Console.WriteLine($"Total Documents Count: {printQueue.Count}");

            //string nextDocument = printQueue.Peek();
            //Console.WriteLine($"Next document to print (Peek): {nextDocument}");
            //Console.WriteLine($"Count after Peek: {printQueue.Count}"); 

            //while (printQueue.Count > 0)
            //{
            //    string currentDoc = printQueue.Dequeue();
            //    Console.WriteLine($"Printing: {currentDoc}");
            //}

            //bool success = printQueue.TryDequeue(out string result);
            //Console.WriteLine($"Did TryDequeue succeed on empty queue? {success}");
            //Console.WriteLine($"Output result value: '{result}'");
            #endregion

            #region Browser History
            //Stack<string> history = new Stack<string>();
            //history.Push("google.com");
            //history.Push("github.com");
            //history.Push("stackoverflow.com");
            //history.Push("youtube.com");
            //history.Push("claude.ai");

            //string currentPage = history.Peek();
            //Console.WriteLine($"Current page (Peek): {currentPage}");

            //for (int i = 1; i <= 3; i++)
            //{
            //    string leftPage = history.Pop();
            //    Console.WriteLine($"Leaving page: {leftPage}");
            //}

            //Console.WriteLine($"Current active page: {history.Peek()}");

            //history.Pop(); 
            //history.Pop(); 

            //bool poppedSuccessfully = history.TryPop(out string poppedUrl);
            //Console.WriteLine($"Did TryPop succeed on empty stack? {poppedSuccessfully}");
            //Console.WriteLine($"Popped URL value: '{poppedUrl}'");
            #endregion
        }
    }
}
