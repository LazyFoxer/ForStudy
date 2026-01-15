
namespace ConsoleAppTest.Models
{
    public class GuesTheNumber
    {
        /// <summary>
        /// Number which we try to guess
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Max attemp before lose
        /// </summary>
        public int MaxAttempt { get; set; }

        private bool _isSecondGamerWin;

        public void Start()
        {
            FirstGamerSetTheNumber();

            SecondGamerTryGuessTheNumber();

            ShowResult();
        }

        private void FirstGamerSetTheNumber()
        {
            Number = ReadNumber("Enter the number");
            MaxAttempt = ReadNumber("Enter max attempt count");
            Console.Clear();
        }

        private void SecondGamerTryGuessTheNumber()
        {
            var attempt = 0;
            do
            {
                var guess = ReadNumber("Enter your guess");
                if (guess == Number)
                {
                    _isSecondGamerWin = true;   
                    break;
                }
                attempt++;
            }while(attempt < MaxAttempt);
        }

        private void ShowResult()
        {
            if (_isSecondGamerWin)
            {
                Console.WriteLine("Congratz");
            }
            else
            {
                Console.WriteLine("Looser");
            }
        }

        private int ReadNumber(string message) 
        {
            Console.WriteLine(message);
            var numberStr = Console.ReadLine();
            return int.Parse(numberStr);
        }
    }
}
