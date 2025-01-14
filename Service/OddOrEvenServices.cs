
namespace AllForOne.Service
{
    public class OddOrEvenServices
    {
        public string oddOrEven;
        public OddOrEvenServices()
        {
            oddOrEven = "Nothing to display!";
        }

        public void AddOddOrEven(string number)
        {
            int convertNumber;

            bool isValied = int.TryParse(number, out convertNumber);

            switch(isValied){
                case true:
                    if (convertNumber % 2 == 0)
                    {
                        oddOrEven = "The number " + convertNumber + " is even.";
                    }
                    else
                    {
                        oddOrEven = "The number " + convertNumber + " is odd.";
                    }
                    break;
                case false:
                    oddOrEven = "Please enter a valid number.";
                    break;
            }
        }
    }
}