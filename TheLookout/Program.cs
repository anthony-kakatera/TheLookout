namespace TheLookout {

    public class TheLookout {

        public static void Main(string[] args) {
            //article setting default to "a"
            string article = "a";

            //getting the name for the object
            Console.WriteLine("Provide object name");
            string name = Console.ReadLine();

            //getting location
            Console.WriteLine("Provide location name");
            string location = Console.ReadLine();

            //call out method
            string shoutOut = theLookout(name, article, location);
            //out put string
            Console.WriteLine(shoutOut);
            Console.ReadLine();
        }

        public static string theLookout(string? name, string article, string location)
        {
            // Creating a vowels array
            char[] vawels = { 'a', 'e', 'i', 'o', 'u' };
            //getting first letter of name
            char firstLetter = name.Distinct().First();
            //performing consonant and vowel check
            for (int i = 0; i < vawels.Length; i++)
            {
                if (vawels[i].Equals(firstLetter))
                {
                    //setting the article to "an" and breaking 
                    article = "an";
                    break;
                }
            }
            //printing out statement
            return "Ahoy, Captain, " + article + " " + name + " off to " + location;
        }
    }

}