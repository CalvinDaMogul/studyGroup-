using System;
using System.Globalization;

namespace studyNotes1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Message = "Put in something";


            Console.WriteLine(Message);
           var newInput = Console.ReadLine();
            var RemoveSpaceFromNewInput = newInput.Replace(" ", "");
            var compositeChar = "";

            for (var k = 0; k < RemoveSpaceFromNewInput.Length; k++)
            {
                int j = 0; var tmp = "";
                while (j <= k)
                {
                    tmp += string.Concat((j == 0) ? char.ToUpper(RemoveSpaceFromNewInput[k]) : char.ToLower(RemoveSpaceFromNewInput[k]));
                    j++;
                }
                compositeChar += tmp + '-';
            }

            Console.WriteLine(compositeChar.Trim('-'));
        }
    }

}
