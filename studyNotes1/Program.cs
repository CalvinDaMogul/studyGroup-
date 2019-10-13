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

            for (var i = 0; i < RemoveSpaceFromNewInput.Length; i++)
            {
                int j = 0; var tmp = "";
                while (j <= i)
                {
                    tmp += string.Concat((j == 0) ? char.ToUpper(RemoveSpaceFromNewInput[i]) : char.ToLower(RemoveSpaceFromNewInput[i]));
                    j++;
                }
                compositeChar += tmp + '-';
            }

            Console.WriteLine(compositeChar.Trim('-'));
        }
    }

}
