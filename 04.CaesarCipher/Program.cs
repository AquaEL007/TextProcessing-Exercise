using System.Text;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char original = text[i];
                sb.Append((char)(original + 3));
            }

            Console.WriteLine(sb);
        }
    }
}
