using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge
{
    public class Phone
    {
        public static string OldPhonePad(string input)
        {
            char[][] matrix =
            [
                [' '],//0
                ['&', '\'', '('],//1
                ['A', 'B', 'C'],//2
                ['D', 'E', 'F'],//3
                ['G', 'H', 'I'],//4
                ['J', 'K', 'L'],//5
                ['M', 'N', 'O'],//6
                ['P', 'Q', 'R', 'S'],//7
                ['T', 'U', 'V'],//8
                ['W', 'X', 'Y', 'Z'],//9
            ];

            string temp = "";
            string message = "";
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == ' ') continue;
                if (input[i] == '*')
                {
                    message = message.Length > 0 ? message.Remove(message.Length - 1) : message;
                    continue;
                }
                temp += input[i];
                if (input[i] != input[i + 1])
                {
                    int key = input[i] - '0';
                    int keyLength = matrix[key].Length;
                    int index = (temp.Length - 1) % keyLength;
                    message += matrix[key][index];
                    temp = "";
                }
            }
            return message;
        }
    }
}
