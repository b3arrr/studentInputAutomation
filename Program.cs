/*
This program lets the user add student name and score manually,
instead of having it hardcoded in an array
*/


IDictionary<string, List<int>> students = new Dictionary<string, List<int>>(); // declares new dictionary for the students containing a list as the value
// and a string for student name as key

//Lets the user decide how many students to add during the session
Console.WriteLine("How many students do you wish to add");
string howManyStudentsAdded = Console.ReadLine();
if(int.TryParse(howManyStudentsAdded, out int numbersStudents))
{
    for(int i = 0; i < numbersStudents; i++)
    {
        addToDictionary(students);      //calls the functions that can add score and students to the "students" dictionary.
    }
}




foreach(KeyValuePair<string, List<int>> kvp in students)  //displays the students added in the dictionary
{
    Console.WriteLine($"\nStudent name: {kvp.Key}");
    Console.Write("Scores: ");

    bool isFirstScore = true;

    foreach (int score in kvp.Value)
    {
        if (!isFirstScore)
        {
            Console.Write(", ");
        }
        else
        {
            isFirstScore = false;
        }

        Console.Write(score);
    }

    Console.WriteLine(); // Add a new line after printing the scores
}





// Automated function that lets the user add student data by asking name and corresponding student score. 
static void addToDictionary(IDictionary<string, List<int>> dictionaryName)
 {
        

        Console.WriteLine("Enter name:");
        string keyInput = Console.ReadLine();

        List<int> valueInput = new List<int>(); //initialize an empty list
        
        while(true)
        {
            
            Console.WriteLine("Enter score(or type \"done\" to finish)");

            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "done")
            break;

            if(int.TryParse(userInput, out int score))
            {
                valueInput.Add(score);
            }
            else
            {
                Console.WriteLine("Error: Enter a valid integer score");
            }
        }

        dictionaryName.Add(keyInput, valueInput);
 }
