namespace HW6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("------------------ HW - - 1 ---------------------");
            Console.WriteLine("");

            Console.WriteLine("Enter word:");
            string text = Console.ReadLine();
            int length = 0;

            foreach (char c in text)
            {
                length++;
            }

            Console.WriteLine($"Text length: {length}");


            Console.WriteLine("");
            Console.WriteLine("------------------ HW - - 2 ---------------------");
            Console.WriteLine("");


            {
                Console.WriteLine("Enter text:");
                string texts = Console.ReadLine();
                int wordCount = 0;
                bool inWord = false;

                foreach (char c in texts)
                {
                    if (c != ' ' && !inWord)
                    {
                        wordCount++;
                        inWord = true;
                    }
                    else if (c == ' ')
                    {
                        inWord = false;
                    }
                }

                Console.WriteLine($"Word count: {wordCount}");

            }

            Console.WriteLine("");
            Console.WriteLine("------------------ HW - - 3 ---------------------");
            Console.WriteLine("");


            Console.WriteLine("Enter text:");
            string textt = Console.ReadLine();
            int letters = 0, digits = 0, specials = 0;

            foreach (char c in textt)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                    letters++;
                else if (c >= '0' && c <= '9')
                    digits++;
                else
                    specials++;
            }

            Console.WriteLine($"Letters: {letters}, Digits: {digits}, Special characters: {specials}");


            Console.WriteLine("");
            Console.WriteLine("------------------ HW - - 4 ---------------------");
            Console.WriteLine("");


            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();
            bool isPalindrome = true;
            int left = 0;
            int right = word.Length - 1;

            while (left < right)
            {
                if (word[left] != word[right])
                {
                    isPalindrome = false;
                    break;
                }
                left++;
                right--;
            }

            Console.WriteLine(isPalindrome ? "It's a palindrome!" : "Not a palindrome.");


            Console.WriteLine("");
            Console.WriteLine("------------------ HW - - 5 ---------------------");
            Console.WriteLine("");


            Console.Write("Enter a text: ");
            string input = Console.ReadLine();

            // Keep only letters
            var letter = input.Where(char.IsLetter).ToArray();

            // Sort in ascending order
            var ascending = letter.OrderBy(c => c).ToArray();
            Console.WriteLine("Sorted ascending: " + new string(ascending));

            // Sort in descending order
            var descending = letter.OrderByDescending(c => c).ToArray();
            Console.WriteLine("Sorted descending: " + new string(descending));




            Console.WriteLine("");
            Console.WriteLine("------------------ HW - - 6 ---------------------");
            Console.WriteLine("");



            Console.WriteLine("Enter text:");
            string texta = Console.ReadLine();
            char[] result = new char[texta.Length];

            for (int i = 0; i < texta.Length; i++)
            {
                char c = texta[i];
                if (char.IsUpper(c))
                    result[i] = char.ToLower(c);
                else if (char.IsLower(c))
                    result[i] = char.ToUpper(c);
                else
                    result[i] = c;
            }

            Console.WriteLine("Converted text: " + new string(result));

            Console.WriteLine("");
            Console.WriteLine("------------------ HW - - 7 ---------------------");
            Console.WriteLine("");

            const string correctUsername = "abcd";
            const string correctPassword = "1234";
            bool loggedIn = false;

            for (int attempt = 0; attempt < 3; attempt++)
            {
                Console.Write("Input a username: ");
                string username = Console.ReadLine();

                Console.Write("Input a password: ");
                string password = Console.ReadLine();

                if (username == correctUsername && password == correctPassword)
                {
                    loggedIn = true;
                    Console.WriteLine("U have logged successfully!");
                    break;
                }

                if (attempt < 2)
                    Console.WriteLine("Try again.");
            }

            if (!loggedIn)
                Console.WriteLine("The username or password U have entered is wrong!");
        }
    }
}

