class Campuses
{
    static void Main(string[] args)
    {
        question2_1();

        question2_2();
    }

    private static void question2_1()
    {
        string[] campuses = {"Midrand", "Pretoria", "Bedfordview", "Vanderbijlpark", "Potchefstroom", "Durban", "East London", "Nelson Mandela Bay", "Bloemfontein", "Mbombela", "Tyger valley", "Claremont"};

        Console.WriteLine("Eduvos Campuses List");
        for (int i = 0; i < campuses.Length; i++)
        {
            Console.WriteLine(campuses[i]);
        }

        Console.Write("\n");
        Console.WriteLine("Eduvos Campuses grouped together:");
        Console.Write("\n");

        var result = from i in Enumerable.Range(0, campuses.Length)
                     group campuses[i] by i / 3;

        foreach (var campusesGroup in result)
        {
            foreach (var campus in campusesGroup)
            {
                Console.Write($"{campus}    ");
            }
            Console.Write("\n");
        }
    }

    private static void question2_2()
    {
        SortedDictionary<string, string> campusDictionary = new SortedDictionary<string, string>();

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

        foreach (KeyValuePair<string, string> pair in campusDictionary)
        {
            Console.WriteLine($"{pair.Key}, {pair.Value}");
        }

        Console.WriteLine($"The totalnumber of campuses of Eduvos is: {campusDictionary.Count}");

        int i = 1;
        if (campusDictionary.ContainsValue("BSc IT in Software Engineering"))
        {            
            i++;
        }

        Console.WriteLine($"Number of campuses offering BSc IT in Software Engineering is: {i}");
    }
}