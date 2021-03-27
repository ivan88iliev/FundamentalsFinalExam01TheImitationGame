using System;
using System.Linq;
using System.Text;

namespace FundamentalsFinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //FundamentalsFinalExam01TheImitationGame

            string inputText = Console.ReadLine();

            StringBuilder decoder = new StringBuilder(inputText);

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Decode")
                {
                    Console.WriteLine($"The decrypted message is: {decoder}");
                    break;
                }
                string[] commandList = command.Split('|', StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (commandList[0])
                {
                    case "Move":
                        for (int i = 0; i < int.Parse(commandList[1]); i++)
                        {
                        decoder.Append(decoder[0]);
                        decoder.Remove(0, 1);
                        }
                        break;

                        case "Insert":
                        decoder.Insert(int.Parse(commandList[1]), commandList[2]);
                        break;

                        case "ChangeAll":
                        decoder.Replace(commandList[1], commandList[2]);
                        break;
                }

            }

            //
        }
    }
}
