
namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            string multiplayNumber = Console.ReadLine();

            Console.WriteLine(MultiplayNumbers(bigNumber, multiplayNumber));
        }

        private static string MultiplayNumbers(string bigNumber, string multiplayNumber)
        {
            if (bigNumber == "0" || multiplayNumber == "0")
            {
                return "0";
            }

            int carry = 0;
            int multiplayer = int.Parse(multiplayNumber);

            char[] resultChars = new char[bigNumber.Length + 1];

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(bigNumber[i].ToString());
                int product = digit * multiplayer + carry;

                resultChars[i + 1] = (char)(product % 10 + '0');
                carry = product / 10;
            }

            if (carry > 0)
            {
                resultChars[0] = (char)(carry + '0');
            }

            return new string(resultChars).TrimStart('\0');
        }
    }
}
