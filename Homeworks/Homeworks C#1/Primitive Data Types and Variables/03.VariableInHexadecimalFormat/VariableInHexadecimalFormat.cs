//Problem 3. Variable in Hexadecimal Format

//Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
//Use Windows Calculator to find its hexadecimal representation.
//Print the variable and ensure that the result is 254.



//using System;
//class VariableInHexadecimalFormat
//{
//    static void Main()
//    {
//        int a = 0xFE;
//      string b = "0xFE";
//       // Console.WriteLine(a);
//        Console.WriteLine("The Variable {0} in HexadecimalFormat is {1} : ",a, b);
//      //  Console.WriteLine(b);
//    }
//}

 using System;
using System.Text;

    class PrintASCIITable
    {
        static void Main()
        {
            
            Console.WriteLine("All printable characters: ");
            for (int i = 0; i < 256; i++)
            {
                  char c = Convert.ToChar(i);
                if (!char.IsControl(c))
                Console.WriteLine(i + "\t" + c);
            }
            Console.WriteLine((char)7);
        }
    }