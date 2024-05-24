using System.Threading.Channels;
using System.Xml.Resolvers;

namespace Project_120_L_11
{
    internal class Program
    {
        string student1 = "Hoang";
        string student2 = "Vicky";

        static string[] firstNames = new string[4];
        static string[] lastNames = new string[4];
        // students - Memory Address: 2000
        // type size: 16 |---|
        //student[0] : 2000 + (index * Type Size)
        // students[1} : 2000 + (1 *16)
        // If you define an array with no values, it has default values
        // string: | "" | "" | "" | "" |
        // int:    | 0 | 0 | 0 | 0 |
        // double: | 0.0 | 0.0 | 0.0 | 0.0 |
        // bool:   | false | false | false | false |
        // object: | null | null | null | null |

        static void Main(string[] args)
        {
            // Call my preload method to populate my arrays
            PreLoad();

            Console.Write("Please enter a last name to search for: ");
            string studentToSearchFor = Console.ReadLine();
            int studentIndex = FindStudentIdByLastName(studentToSearchFor);

            if(studentIndex >= 0)
            {
                DisplayStudentInformation(studentIndex);
            }

            else
            {
                Console.WriteLine("That student is not enrolled in the class");
            }

            // .Length gives the size of the array
            DisplayAllStudents();
            
        }//main

        // Linear Search
        // Create a method that returns if a student is in the class
        public static bool EnrolledInClassByLastName(string studentsLastName) // <--- Search Key
        {
            for (int i = 0; i < lastNames.Length; i++)
            {
                // If the current value == the searchkey
                if (lastNames[i].ToLower() == studentsLastName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        
        public static int FindStudentIdByLastName(string studentLastName)
        {
            for (int i = 0; i < lastNames.Length; i++)
            {
                // If the current value == the searchkey
                if (lastNames[i].ToLower() == studentLastName.ToLower())
                {
                    return i;
                }
            }
            return -1;
        }
        public static void DisplayStudentInformation(int studentIndex)
        {
            //student ID
            Console.WriteLine($"Student Id:{studentIndex}");
            //full name
            Console.WriteLine($"Full Name: {FullName(studentIndex)}");
            //first name
            Console.WriteLine($"First Name: {firstNames[studentIndex]}");
            //last name
            Console.WriteLine($"Last Name: {lastNames[studentIndex]}");
            // grades
            Console.WriteLine();


        }//display all students

        public static void DisplayAllStudents()
        {
            for (int i = 0; i < firstNames.Length; i++)
            {
                //string fullName = fullName(i);
                DisplayStudentInformation(i);
            }
        }

        // new method : Return a full name
        // Triple Forward slash /// defines a method in intellisense

        /// <summary>
        ///I will return a string of a students full name
        /// </summary>
        /// <paran name="studentIndex">Index of Student</paran>
        public static string FullName(int studentIndex)
        {
            string firstName = firstNames[studentIndex];
            string lastName = lastNames[studentIndex];
            string fullName = $"{firstName} {lastName}";
            // I am returning the full name of the student out side of our method
            // So can work with it in other methods
            // return full name of the student out side of our method
            //so can work with it in other methods
            return fullName;
        }

        public static void PreLoad()
        {
            firstNames[0] = "Hoang";
            firstNames[1] = "Vicky";
            firstNames[2] = "Brian";
            firstNames[3] = "Carla";

            lastNames[0] = "Nguyen";
            lastNames[1] = "Le";
            lastNames[2] = "Lee";
            lastNames[3] = "Baysinger";

        }

        // Switches

        public static void Menu()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    SwitchExample();
                    break;
                case "2":
                    break;
            }
        }// Menu
        public static void SwitchExample()
        {
            // Switch is decision structure that works on comparisons

            // Keywords
            // switch : define our code block
            // case : defines an individual set of instructions
            // break : defines the end of those instructions
            // default : runs if no case runs ( like an else )

            Console.Write("Please enter an animal: ");
        string userAnimal = Console.ReadLine();
            //switch (case) <---not a condition: "cat" == dog" don't put this
            switch (userAnimal)
            {
                //create our cases
                // you write case to define a new case followed by value comparing to
                //no curly braces
                //use a colon : , instead
                // Followed by break
                //cases do not have their own scope
                case "dog":
                case "owl":
              
                    Console.WriteLine("bark");
                    break;
                case "cat":
                    
                    Console.WriteLine("Meow");
                    Console.WriteLine("purr");
                    break;
                default:
                    Console.WriteLine("Please enter a valid animal");
                    break;
            }

        } // SwitchExample

        //Break example
        public static void BreakExample()
        {
            // new keyword
            // break
            // break indicates that we want to jump ou of the current code block
            for (int i = 0; i < 10000000; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    //once break is triggered it will jump out of our for loop
                    break;
                }
            }
        }
        

    } // class
} //namespace



