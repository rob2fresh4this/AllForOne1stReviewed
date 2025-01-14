namespace AllForOne.Service
{
    public class ReverseItAlphanumericServices
    {
        public string reverseItAlphanumeric;

        public ReverseItAlphanumericServices()
        {
            reverseItAlphanumeric = "Nothing to display!";
        }

        public void AddReverseItAlphanumeric(string input)
        {
            string reversedString = "";

            // Iterate through the string in reverse order
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedString += input[i];
            }

            reverseItAlphanumeric = "You entered " + input + " reversed is " + reversedString;
        }
    }
}
