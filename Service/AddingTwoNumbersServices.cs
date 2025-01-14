namespace AllForOne.Service
{
    public class AddingTwoNumbersServices
    {
        public string anwser;

        public AddingTwoNumbersServices()
        {
            anwser = "Nothing here yet!";
        }

        public void AddingTwoNumbers(string num1, string num2)
        {
            int convertNum1;
            int convertNum2;

            bool isValied = int.TryParse(num1, out convertNum1);
            bool isValied1 = int.TryParse(num2, out convertNum2);

            if (!isValied && !isValied1)
            {
                anwser = "Both numbers are not numbers";
            }
            else if (!isValied)
            {
                anwser = "The first number is not a number";
            }
            else if (!isValied1)
            {
                anwser = "The second number is not a number";
            }
            else
            {
                int sum = convertNum1 + convertNum2;
                anwser = $"The sum of {convertNum1} and {convertNum2} is {sum}";
            }
        }
    }
}