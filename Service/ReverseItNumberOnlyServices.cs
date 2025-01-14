
namespace AllForOne.Service
{
    public class ReverseItNumberOnlyServices
    {
        public string reverseItNumberOnly;

        public ReverseItNumberOnlyServices()
        {
            reverseItNumberOnly = "Nothing to display!";
        }

        public void AddReverseItNumberOnly(string input1)
        {
            bool isValidNumber = int.TryParse(input1, out int convertNumber);
            if (!isValidNumber)
            {
                reverseItNumberOnly = "Invalid input. Please enter a valid integer.";
                return;
            }

            int input = convertNumber;  // Convert the string to an integer
            int reversedNumber = 0;

            // Reverse the integer using division and modulo operations
            while (input != 0)
            {
                int digit = input % 10; // Get the last digit
                reversedNumber = reversedNumber * 10 + digit; // Build the reversed number
                input /= 10; // Remove the last digit
            }

            reverseItNumberOnly = "You entered " + convertNumber + " reversed is " + reversedNumber;
        }
    }
}
