using System;
using System.Collections.Generic;
using System.Linq;

class Campuses
{
    static void Main(string[] args)
    {
        // Call methods for each question
        question2_1();
        question2_2();
    }

    // Method to address question 2.1
    private static void question2_1()
    {
        // Array of Eduvos campuses
        string[] campuses = { "Midrand", "Pretoria", "Bedfordview", "Vanderbijlpark", "Potchefstroom", 
            "Durban", "East London", "Nelson Mandela Bay", "Bloemfontein", "Mbombela", "Tyger valley", "Claremont" };

        // Print the list of campuses
        Console.WriteLine("Eduvos Campuses List");
        foreach (string campus in campuses)
        {
            Console.WriteLine(campus);
        }

        // Group campuses into groups of 4
        Console.WriteLine("\nEduvos Campuses grouped together:");
        var groupedCampuses = campuses.Select((campus, index) => new { Campus = campus, Group = index / 4 })
                      .GroupBy(x => x.Group)
                      .Select(group => group.Select(x => x.Campus).ToList());

        foreach (var group in groupedCampuses)
        {
            foreach (var campus in group)
            {
                Console.Write($"{campus}   ");
            }
            Console.WriteLine();
        }
    }

    // Method to address question 2.2
    private static void question2_2()
    {
        // Dictionary to store campus and course information
        SortedDictionary<string, string> campusDictionary = new SortedDictionary<string, string>();

        // Add campus and course pairs
        campusDictionary.Add("Midrand", "BSc Computer Science");
        campusDictionary.Add("Pretoria", "BSc IT in Robotics");
        campusDictionary.Add("Bedfordview", "BSc IT in Software Engineering");
        campusDictionary.Add("Vanderbijlpark", "BSc IT in Software Engineering");
        campusDictionary.Add("Potchefstroom", "BSc IT in Software Engineering");
        campusDictionary.Add("Durban", "BSc IT in Robotics");
        campusDictionary.Add("East London", "BSc in Data Science");
        campusDictionary.Add("Nelson Mandela Bay", "BSc IT in Security and Network Engineering");
        campusDictionary.Add("Bloemfontein", "BSc in Data Science");
        campusDictionary.Add("Mbombela", "BSc in Data Science");
        campusDictionary.Add("Tyger valley", "BSc IT in Robotics");
        campusDictionary.Add("Claremont", "BSc IT in Security and Network Engineering");

        // Print the campus and course information
        foreach (KeyValuePair<string, string> pair in campusDictionary)
        {
            Console.WriteLine($"{pair.Key}, {pair.Value}");
        }

        // Print the total number of campuses
        Console.WriteLine($"The total number of campuses of Eduvos is: {campusDictionary.Count}");

        // Count campuses offering BSc IT in Software Engineering
        int softwareEngineeringCampuses = campusDictionary.Values.Count(course => course == "BSc IT in Software Engineering");
        Console.WriteLine($"Number of campuses offering BSc IT in Software Engineering is: {softwareEngineeringCampuses}");
    }
}
