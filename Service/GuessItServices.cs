
namespace AllForOne.Service
{
    public class GuessItServices
    {
        public string reply;
        public GuessItServices()
        {
            reply = "Error: No number guessed";
        }
        public string EasyMode(string guess)
        {
            if (!int.TryParse(guess, out int convertedGuess))
            {
                return "Invalid guess. Please enter a valid number.";
            }

            int rng = new Random().Next(1, 11);
            if (convertedGuess == rng)
            {
                reply = "Correct!" + " The number was " + rng;
            }
            else if (convertedGuess > rng)
            {
                reply = "Lower!" + " The number was " + rng;
            }
            else if (convertedGuess < rng)
            {
                reply = "Higher!" + " The number was " + rng;
            }
            return reply;
        }

        public string MediumMode(string guess)
        {
            if (!int.TryParse(guess, out int convertedGuess))
            {
                return "Invalid guess. Please enter a valid number.";
            }

            int rng = new Random().Next(1, 51);
            if (convertedGuess == rng)
            {
                reply = "Correct!" + " The number was " + rng;
            }
            else if (convertedGuess > rng)
            {
                reply = "Lower!" + " The number was " + rng;
            }
            else if (convertedGuess < rng)
            {
                reply = "Higher!" + " The number was " + rng;
            }
            return reply;
        }

        public string HardMode(string guess)
        {
            if (!int.TryParse(guess, out int convertedGuess))
            {
                return "Invalid guess. Please enter a valid number.";
            }

            int rng = new Random().Next(1, 101);
            if (convertedGuess == rng)
            {
                reply = "Correct!" + " The number was " + rng;
            }
            else if (convertedGuess > rng)
            {
                reply = "Lower!" + " The number was " + rng;
            }
            else if (convertedGuess < rng)
            {
                reply = "Higher!" + " The number was " + rng;
            }
            return reply;
        }
    }
}
